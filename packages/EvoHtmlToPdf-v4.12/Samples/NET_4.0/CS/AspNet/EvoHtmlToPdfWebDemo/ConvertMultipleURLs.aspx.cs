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
    public partial class ConvertMultipleURLs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("ConvertMultipleUrls");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            PdfConverter pdfConverter = new PdfConverter();

            // set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // add header and footer
            if (cbAddHeader.Checked)
                AddHeader(pdfConverter);
            if (cbAddFooter.Checked)
                AddFooter(pdfConverter);

            // call the converter and get a Document object from URL
            Document pdfDocument = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL1.Text.Trim());

            // get the conversion summary object from the event arguments
            ConversionSummary conversionSummary = pdfConverter.ConversionSummary;

            // the PDF page where the previous conversion ended
            PdfPage lastPage = pdfDocument.Pages[conversionSummary.LastPageIndex];
            // the last rectangle in the last PDF page where the previous conversion ended
            RectangleF lastRectangle = conversionSummary.LastPageRectangle;

            // the result of adding an element to a PDF page
            // ofers the index of the PDF page where the rendering ended 
            // and the bounding rectangle of the rendered content in the last page
            AddElementResult addResult = null;

            // the converter for the second URL
            HtmlToPdfElement htmlToPdfURL2 = null;

            if (cbStartOnNewPage.Checked)
            {
                // render the HTML from the second URL on a new page after the first URL
                PdfPage newPage = pdfDocument.Pages.AddNewPage();
                htmlToPdfURL2 = new HtmlToPdfElement(0, 0, textBoxURL2.Text);
                addResult = newPage.AddElement(htmlToPdfURL2);
            }
            else
            {
                // render the HTML from the second URL immediately after the first URL
                htmlToPdfURL2 = new HtmlToPdfElement(lastRectangle.Left, lastRectangle.Bottom, textBoxURL2.Text);
                addResult = lastPage.AddElement(htmlToPdfURL2);
            }

            // the PDF page where the previous conversion ended
            lastPage = pdfDocument.Pages[addResult.EndPageIndex];

            // add a HTML string after all the rendered content
            HtmlToPdfElement htmlStringToPdf = new HtmlToPdfElement(addResult.EndPageBounds.Left, addResult.EndPageBounds.Bottom,
                "<b><i>The rendered content ends here</i></b>", null);

            lastPage.AddElement(htmlStringToPdf);

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
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=ConvertMultipleUrls.pdf; size={0}", pdfBytes.Length.ToString()));

            // write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes);

            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to PDF document stream
            httpResponse.End();
        }

        private void AddHeader(PdfConverter pdfConverter)
        {
            string thisPageURL = HttpContext.Current.Request.Url.AbsoluteUri;
            string headerAndFooterHtmlUrl = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + "/HeaderFooter/HeaderAndFooterHtml.htm";

            //enable header
            pdfConverter.PdfDocumentOptions.ShowHeader = true;
            // set the header height in points
            pdfConverter.PdfHeaderOptions.HeaderHeight = 60;
            // set the header HTML area
            HtmlToPdfElement headerHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                    headerAndFooterHtmlUrl, 1024, 0);
            headerHtml.FitHeight = true;
            pdfConverter.PdfHeaderOptions.AddElement(headerHtml);
        }

        private void AddFooter(PdfConverter pdfConverter)
        {
            string thisPageURL = HttpContext.Current.Request.Url.AbsoluteUri;
            string headerAndFooterHtmlUrl = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + "/HeaderFooter/HeaderAndFooterHtml.htm";

            //enable footer
            pdfConverter.PdfDocumentOptions.ShowFooter = true;
            // set the footer height in points
            pdfConverter.PdfFooterOptions.FooterHeight = 60;
            //write the page number
            TextElement footerText = new TextElement(0, 30, "This is page &p; of &P;  ",
                new System.Drawing.Font(new System.Drawing.FontFamily("Times New Roman"), 10, System.Drawing.GraphicsUnit.Point));
            footerText.EmbedSysFont = true;
            footerText.TextAlign = HorizontalTextAlign.Right;
            pdfConverter.PdfFooterOptions.AddElement(footerText);

            // set the footer HTML area
            HtmlToPdfElement footerHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfFooterOptions.FooterHeight,
                    headerAndFooterHtmlUrl, 1024, 0);
            footerHtml.FitHeight = true;
            pdfConverter.PdfFooterOptions.AddElement(footerHtml);
        }
    }
}
