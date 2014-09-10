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
    public partial class PdfSecurity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("PdfSecurity");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            PdfConverter pdfConverter = new PdfConverter();

            // set the license key
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // set user and owner passwords
            pdfConverter.PdfSecurityOptions.UserPassword = "user";
            pdfConverter.PdfSecurityOptions.OwnerPassword = "owner";

            // restrict the right to print and to copy the document content
            pdfConverter.PdfSecurityOptions.CanPrint = false;
            pdfConverter.PdfSecurityOptions.CanCopyContent = false;

            // call the converter
            byte[] pdfBytes = pdfConverter.GetPdfBytesFromUrl(textBoxWebPageURL.Text.Trim());

            // send the generated PDF document to client browser

            // get the object representing the HTTP response to browser
            HttpResponse httpResponse = HttpContext.Current.Response;

            // add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf");
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=PdfSecurity.pdf; size={0}", pdfBytes.Length.ToString()));

            // write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes);

            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to PDF document stream
            httpResponse.End();
        }
    }
}
