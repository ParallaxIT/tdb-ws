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
    public partial class HtmlToPdfElementDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("HtmlToPdfElement");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            //create a PDF document
            Document document = new Document();

            // set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            //optional settings for the PDF document like margins, compression level,
            //security options, viewer preferences, document information, etc
            document.CompressionLevel = PdfCompressionLevel.Normal;
            document.Margins = new Margins(10, 10, 0, 0);
            //document.Security.CanPrint = true;
            //document.Security.UserPassword = "";
            document.ViewerPreferences.HideToolbar = false;

            // set if the images are compressed in PDF with JPEG to reduce the PDF document size
            document.JpegCompressionEnabled = cbJpegCompression.Checked;

            //Add a first page to the document. The next pages will inherit the settings from this page 
            PdfPage page = document.Pages.AddNewPage(PdfPageSize.A4, new Margins(10, 10, 0, 0), PdfPageOrientation.Portrait);

            // the code below can be used to create a page with default settings A4, document margins inherited, portrait orientation
            //PdfPage page = document.Pages.AddNewPage();

            // add a font to the document that can be used for the texts elements 
            PdfFont font = document.Fonts.Add(new System.Drawing.Font(new System.Drawing.FontFamily("Times New Roman"), 10,
                        System.Drawing.GraphicsUnit.Point));

            // add header and footer before renderng the content
            if (cbAddHeader.Checked)
                AddHtmlHeader(document);
            if (cbAddFooter.Checked)
                AddHtmlFooter(document, font);

            // the result of adding an element to a PDF page
            AddElementResult addResult;

            // Get the specified location and size of the rendered content
            // A negative value for width and height means to auto determine
            // The auto determined width is the available width in the PDF page
            // and the auto determined height is the height necessary to render all the content
            float xLocation = float.Parse(textBoxXLocation.Text.Trim());
            float yLocation = float.Parse(textBoxYLocation.Text.Trim());
            float width = float.Parse(textBoxWidth.Text.Trim());
            float height = float.Parse(textBoxHeight.Text.Trim());

            if (radioConvertToSelectablePDF.Checked)
            {
                // convert HTML to PDF
                HtmlToPdfElement htmlToPdfElement;

                if (radioConvertURL.Checked)
                {
                    // convert a URL to PDF
                    string urlToConvert = textBoxWebPageURL.Text.Trim();

                    htmlToPdfElement = new HtmlToPdfElement(xLocation, yLocation, width, height, urlToConvert);
                }
                else
                {
                    // convert a HTML string to PDF
                    string htmlStringToConvert = textBoxHTMLCode.Text;
                    string baseURL = textBoxBaseURL.Text.Trim();

                    htmlToPdfElement = new HtmlToPdfElement(xLocation, yLocation, width, height, htmlStringToConvert, baseURL);
                }

                //optional settings for the HTML to PDF converter
                htmlToPdfElement.FitWidth = cbFitWidth.Checked;
                htmlToPdfElement.EmbedFonts = cbEmbedFonts.Checked;
                htmlToPdfElement.LiveUrlsEnabled = cbLiveLinks.Checked;
                htmlToPdfElement.JavaScriptEnabled = cbClientScripts.Checked;
                htmlToPdfElement.PdfBookmarkOptions.HtmlElementSelectors = cbBookmarks.Checked ? new string[] { "H1", "H2" } : null;

                // add theHTML to PDF converter element to page
                addResult = page.AddElement(htmlToPdfElement);
            }
            else
            {
                HtmlToImageElement htmlToImageElement;

                // convert HTML to image and add image to PDF document
                if (radioConvertURL.Checked)
                {
                    // convert a URL to PDF
                    string urlToConvert = textBoxWebPageURL.Text.Trim();

                    htmlToImageElement = new HtmlToImageElement(xLocation, yLocation, width, height, urlToConvert);
                }
                else
                {
                    // convert a HTML string to PDF
                    string htmlStringToConvert = textBoxHTMLCode.Text;
                    string baseURL = textBoxBaseURL.Text.Trim();

                    htmlToImageElement = new HtmlToImageElement(xLocation, yLocation, width, height, htmlStringToConvert, baseURL);
                }

                //optional settings for the HTML to PDF converter
                htmlToImageElement.FitWidth = cbFitWidth.Checked;
                htmlToImageElement.LiveUrlsEnabled = cbLiveLinks.Checked;
                htmlToImageElement.JavaScriptEnabled = cbClientScripts.Checked;
                htmlToImageElement.PdfBookmarkOptions.HtmlElementSelectors = cbBookmarks.Checked ? new string[] { "H1", "H2" } : null;

                addResult = page.AddElement(htmlToImageElement);
            }

            if (cbAdditionalContent.Checked)
            {
                // The code below can be used add some other elements right under the conversion result 
                // like texts or another HTML to PDF conversion

                // add a text element right under the HTML to PDF document
                PdfPage endPage = document.Pages[addResult.EndPageIndex];
                TextElement nextTextElement = new TextElement(0, addResult.EndPageBounds.Bottom + 10, "Below there is another HTML to PDF Element", font);
                nextTextElement.ForeColor = System.Drawing.Color.Green;
                addResult = endPage.AddElement(nextTextElement);

                // add another HTML to PDF converter element right under the text element
                endPage = document.Pages[addResult.EndPageIndex];
                HtmlToPdfElement nextHtmlToPdfElement = new HtmlToPdfElement(0, addResult.EndPageBounds.Bottom + 10, "http://www.google.com");
                addResult = endPage.AddElement(nextHtmlToPdfElement);
            }

            try
            {
                // get the PDF document bytes
                byte[] pdfBytes = document.Save();

                // send the generated PDF document to client browser

                // get the object representing the HTTP response to browser
                HttpResponse httpResponse = HttpContext.Current.Response;

                // add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf");
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlToPdfElement.pdf; size={0}", pdfBytes.Length.ToString()));

                // write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes);

                // Note: it is important to end the response, otherwise the ASP.NET
                // web page will render its content to PDF document stream
                httpResponse.End();
            }
            finally
            {
                // close the PDF document to release the resources
                document.Close();
            }
        }

        private void AddHtmlHeader(Document document)
        {
            string thisPageURL = HttpContext.Current.Request.Url.AbsoluteUri;
            string headerAndFooterHtmlUrl = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + "/HeaderFooter/HeaderAndFooterHtml.htm";

            //create a template to be added in the header and footer
            document.Header = document.AddTemplate(document.Pages[0].ClientRectangle.Width, 60);
            // create a HTML to PDF converter element to be added to the header template
            HtmlToPdfElement headerHtmlToPdf = new HtmlToPdfElement(0, 0, document.Header.ClientRectangle.Width,
                    document.Header.ClientRectangle.Height, headerAndFooterHtmlUrl);
            headerHtmlToPdf.FitHeight = true;
            document.Header.AddElement(headerHtmlToPdf);
        }

        private void AddHtmlFooter(Document document, PdfFont footerPageNumberFont)
        {
            string thisPageURL = HttpContext.Current.Request.Url.AbsoluteUri;
            string headerAndFooterHtmlUrl = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + "/HeaderFooter/HeaderAndFooterHtml.htm";

            //create a template to be added in the header and footer
            document.Footer = document.AddTemplate(document.Pages[0].ClientRectangle.Width, 60);
            // create a HTML to PDF converter element to be added to the header template
            HtmlToPdfElement footerHtmlToPdf = new HtmlToPdfElement(0, 0, document.Footer.ClientRectangle.Width,
                    document.Footer.ClientRectangle.Height, headerAndFooterHtmlUrl);
            footerHtmlToPdf.FitHeight = true;
            document.Footer.AddElement(footerHtmlToPdf);

            // add page number to the footer
            TextElement pageNumberText = new TextElement(document.Footer.ClientRectangle.Width - 100, 30,
                                "This is page &p; of &P; pages", footerPageNumberFont);
            document.Footer.AddElement(pageNumberText);
        }


        protected void radioConvertURL_CheckedChanged(object sender, EventArgs e)
        {
            pnlConvertURL.Visible = radioConvertURL.Checked;
            pnlConvertHTML.Visible = !radioConvertURL.Checked;
        }

        protected void radioConvertHTML_CheckedChanged(object sender, EventArgs e)
        {
            pnlConvertURL.Visible = !radioConvertHTML.Checked;
            pnlConvertHTML.Visible = radioConvertHTML.Checked;
        }
    }
}
