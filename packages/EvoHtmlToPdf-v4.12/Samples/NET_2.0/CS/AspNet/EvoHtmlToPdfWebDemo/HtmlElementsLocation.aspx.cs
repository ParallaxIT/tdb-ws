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

using System.Drawing;

using EvoPdf;

namespace EvoHtmlToPdfWebDemo
{
    public partial class HtmlElementsLocation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("HtmlElementsLocation");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            PdfConverter pdfConverter = new PdfConverter();

            // set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // inform the converter about the HTML elements for which we want the location in PDF
            // in this sample we want the location of IMG, H1 and H2 elements and the elements with ID 
            // equal to 'id1' or 'id2'
            pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = new string[] { "IMG", "H1", "H2", "#id1", "#id2" };

            // call the converter and get a Document object from URL
            Document pdfDocument = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxWebPageURL.Text.Trim());

            // iterate over the HTML elements locations and hightlight each element with a green rectangle
            foreach (HtmlElementMapping elementMapping in pdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult)
            {
                // because a HTML element can span over many PDF pages the mapping 
                // of the HTML element in PDF document consists in a list of rectangles,
                // one rectangle for each PDF page where this element was rendered
                foreach (HtmlElementPdfRectangle elementLocationInPdf in elementMapping.PdfRectangles)
                {
                    // get the PDF page
                    PdfPage pdfPage = pdfDocument.Pages[elementLocationInPdf.PageIndex];
                    RectangleF pdfRectangleInPage = elementLocationInPdf.Rectangle;

                    // create a RectangleElement to highlight the HTML element
                    RectangleElement highlightRectangle = new RectangleElement(pdfRectangleInPage.X, pdfRectangleInPage.Y,
                        pdfRectangleInPage.Width, pdfRectangleInPage.Height);
                    highlightRectangle.ForeColor = Color.Green;

                    pdfPage.AddElement(highlightRectangle);
                }
            }

            byte[] pdfBytes = null;

            try
            {
                pdfBytes = pdfDocument.Save();
            }
            finally
            {
                // close the Document to realease all the resources
                pdfDocument.Close();
            }

            // send the generated PDF document to client browser

            // get the object representing the HTTP response to browser
            HttpResponse httpResponse = HttpContext.Current.Response;

            // add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf");
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlElementsLocation.pdf; size={0}", pdfBytes.Length.ToString()));

            // write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes);

            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to PDF document stream
            httpResponse.End();
        }
    }
}
