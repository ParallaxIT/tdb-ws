using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using EvoPdf;

namespace EvoHtmlToPdfWebDemo
{
    public partial class SvgToPdfDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("SvgToPdf");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            PdfConverter pdfConverter = new PdfConverter();

            // set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            /*// convert a XML document with inline SVG
            string thisPageURL = HttpContext.Current.Request.Url.AbsoluteUri;
            string htmlWithSvgUrl = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + "/SVG/svginline.xml";*/

            // We convert the HTML page as local disk file because IIS and VS WebDev Server 
            // don't have .svg included in MIME types by default.
            // When converting HTML pages from an IIS server the MIME type image/svg+xml 
            // must be added to IIS in order to serve the .svg files referenced in HTML
            string htmlWithSvgUrl = System.IO.Path.Combine(Server.MapPath("~"), @"SVG\svg.html");

            // call the converter
            byte[] pdfBytes = pdfConverter.GetPdfBytesFromUrl(htmlWithSvgUrl);

            // send the generated PDF document to client browser

            // get the object representing the HTTP response to browser
            HttpResponse httpResponse = HttpContext.Current.Response;

            // add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf");
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=SvgToPdf.pdf; size={0}", pdfBytes.Length.ToString()));

            // write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes);

            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to PDF document stream
            httpResponse.End();
        }
    }
}
