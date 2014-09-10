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
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("GettingStarted");
        }

        /// <summary>
        /// Convert the HTML code from the specified URL to a PDF document and send the 
        /// document to the browser
        /// </summary>
        private void ConvertURLToPDF()
        {
            string urlToConvert = textBoxWebPageURL.Text.Trim();

            // Create the PDF converter. Optionally the HTML viewer width can be specified as parameter
            // The default HTML viewer width is 1024 pixels.
            PdfConverter pdfConverter = new PdfConverter();

            // set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // set the converter options - optional
            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4;
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
            pdfConverter.PdfDocumentOptions.PdfPageOrientation = PdfPageOrientation.Portrait;


            // set if header and footer are shown in the PDF - optional - default is false 
            pdfConverter.PdfDocumentOptions.ShowHeader = cbAddHeader.Checked;
            pdfConverter.PdfDocumentOptions.ShowFooter = cbAddFooter.Checked;
            // set if the HTML content is resized if necessary to fit the PDF page width - default is true
            pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked;

            // set the embedded fonts option - optional - default is false
            pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked;
            // set the live HTTP links option - optional - default is true
            pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinks.Checked;

            // set if the JavaScript is enabled during conversion to a PDF - default is true
            pdfConverter.JavaScriptEnabled = cbClientScripts.Checked;

            // set if the images in PDF are compressed with JPEG to reduce the PDF document size - default is true
            pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked;

            // enable auto-generated bookmarks for a specified list of HTML selectors (e.g. H1 and H2)
            if (cbBookmarks.Checked)
            {
                pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = new string[] { "H1", "H2" };
            }

            // add HTML header
            if (cbAddHeader.Checked)
                AddHeader(pdfConverter);
            // add HTML footer
            if (cbAddFooter.Checked)
                AddFooter(pdfConverter);

            // optionally wait for asynchronous items
            pdfConverter.ConversionDelay = 2;

            // Performs the conversion and get the pdf document bytes that can 
            // be saved to a file or sent as a browser response
            byte[] pdfBytes = pdfConverter.GetPdfBytesFromUrl(urlToConvert);

            // send the generated PDF document to client browser

            // get the object representing the HTTP response to browser
            HttpResponse httpResponse = HttpContext.Current.Response;

            // add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf");
            if (radioAttachment.Checked)
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=GettingStarted.pdf; size={0}", pdfBytes.Length.ToString()));
            else
                httpResponse.AddHeader("Content-Disposition", String.Format("inline; filename=GettingStarted.pdf; size={0}", pdfBytes.Length.ToString()));

            // write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes);

            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to PDF document stream
            httpResponse.End();
        }


        /// <summary>
        /// Convert the HTML code from the specified URL to a PNG image and send the 
        /// image as an attachment to the browser
        /// </summary>
        private void ConvertURLToImage()
        {
            string urlToConvert = textBoxWebPageURL.Text.Trim();

            // Create the Image converter. Optionally the HTML viewer width can be specified as parameter
            // The default HTML viewer width is 1024 pixels.
            ImgConverter imgConverter = new ImgConverter();

            // set the license key
            imgConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // set if the JavaScript is enabled during conversion - default is true
            imgConverter.JavaScriptEnabled = cbClientScripts.Checked;

            // Performs the conversion and get the image bytes that can be further 
            // saved to a file or sent as a response to browser
            byte[] imgBytes = imgConverter.GetImageBytesFromUrl(urlToConvert, System.Drawing.Imaging.ImageFormat.Png);

            // send the image as a response to the browser for download
            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.Clear();
            response.AddHeader("Content-Type", "image/png");
            response.AddHeader("Content-Disposition", String.Format("attachment; filename=GettingStarted.png; size={0}", imgBytes.Length.ToString()));
            response.BinaryWrite(imgBytes);
            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to image stream
            response.End();
        }


        /// <summary>
        /// Convert the specified HTML string to a PDF document and send the 
        /// document to the browser
        /// </summary>
        private void ConvertHTMLStringToPDF()
        {
            string htmlString = textBoxHTMLCode.Text;
            string baseURL = textBoxBaseURL.Text.Trim();
            bool selectablePDF = radioConvertToSelectablePDF.Checked;

            // Create the PDF converter. Optionally the HTML viewer width can be specified as parameter
            // The default HTML viewer width is 1024 pixels.
            PdfConverter pdfConverter = new PdfConverter();

            // set the license key
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // set the converter options
            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4;
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
            pdfConverter.PdfDocumentOptions.PdfPageOrientation = PdfPageOrientation.Portrait;

            // set if header and footer are shown in the PDF - optional - default is false 
            pdfConverter.PdfDocumentOptions.ShowHeader = cbAddHeader.Checked;
            pdfConverter.PdfDocumentOptions.ShowFooter = cbAddFooter.Checked;
            // set if the HTML content is resized if necessary to fit the PDF page width - default is true
            pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked;
            // 
            // set the embedded fonts option - optional - default is false
            pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked;
            // set the live HTTP links option - optional - default is true
            pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinks.Checked;

            // set if the JavaScript is enabled during conversion to a PDF - default is true
            pdfConverter.JavaScriptEnabled = cbClientScripts.Checked;

            // set if the images in PDF are compressed with JPEG to reduce the PDF document size - default is true
            pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked;

            // enable auto-generated bookmarks for a specified list of tags (e.g. H1 and H2)
            if (cbBookmarks.Checked)
            {
                pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = new string[] { "H1", "H2" };
            }

            // add HTML header
            if (cbAddHeader.Checked)
                AddHeader(pdfConverter);
            // add HTML footer
            if (cbAddFooter.Checked)
                AddFooter(pdfConverter);

            // Performs the conversion and get the pdf document bytes that can be further 
            // saved to a file or sent as response to browser
            //
            // The baseURL parameter helps the converter to get the CSS files and images
            // referenced by a relative URL in the HTML string.  
            byte[] pdfBytes = null;
            if (baseURL.Length > 0)
                pdfBytes = pdfConverter.GetPdfBytesFromHtmlString(htmlString, baseURL);
            else
                pdfBytes = pdfConverter.GetPdfBytesFromHtmlString(htmlString);

            // send the generated PDF document to client browser

            // get the object representing the HTTP response to browser
            HttpResponse httpResponse = HttpContext.Current.Response;

            // add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf");
            if (radioAttachment.Checked)
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=GettingStarted.pdf; size={0}", pdfBytes.Length.ToString()));
            else
                httpResponse.AddHeader("Content-Disposition", String.Format("inline; filename=GettingStarted.pdf; size={0}", pdfBytes.Length.ToString()));

            // write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes);

            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to PDF document stream
            httpResponse.End();
        }


        /// <summary>
        /// Convert the specified HTML string to a PNG image and send the 
        /// image as an attachment to the browser
        /// </summary>
        private void ConvertHTMLStringToImage()
        {
            string htmlString = textBoxHTMLCode.Text;
            string baseURL = textBoxBaseURL.Text.Trim();

            // Create the Image converter. Optionally the HTML viewer width can be specified as parameter
            // The default HTML viewer width is 1024 pixels.
            ImgConverter imgConverter = new ImgConverter();

            // set the license key
            imgConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // set if the JavaScript is enabled during conversion - default is true
            imgConverter.JavaScriptEnabled = cbClientScripts.Checked;

            // Performs the conversion and get the image bytes that can be further 
            // saved to a file or sent as a browser response
            //
            // The baseURL parameter helps the converter to get the CSS files and images
            // referenced by a relative URL in the HTML string.  
            byte[] imgBytes = null;
            if (baseURL.Length > 0)
                imgBytes = imgConverter.GetImageBytesFromHtmlString(htmlString, System.Drawing.Imaging.ImageFormat.Png, baseURL);
            else
                imgBytes = imgConverter.GetImageBytesFromHtmlString(htmlString, System.Drawing.Imaging.ImageFormat.Png);

            // send the image as a response to the browser for download
            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.Clear();
            response.AddHeader("Content-Type", "image/png");
            response.AddHeader("Content-Disposition", String.Format("attachment; filename=GettingStarted.png; size={0}", imgBytes.Length.ToString()));
            response.BinaryWrite(imgBytes);
            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to image stream
            response.End();
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
            headerHtml.EmbedFonts = cbEmbedFonts.Checked;
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
            footerHtml.EmbedFonts = cbEmbedFonts.Checked;
            pdfConverter.PdfFooterOptions.AddElement(footerHtml);
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            if (radioConvertURL.Checked)
            {
                // convert the HTML from a specified URL
                if (radioConvertToImage.Checked)
                    ConvertURLToImage(); // convert URL to image
                else
                    ConvertURLToPDF(); // convert URL to PDF
            }
            else
            {
                // convert the specified HTML string
                if (radioConvertToImage.Checked)
                    ConvertHTMLStringToImage(); // convert HTML string to image
                else
                    ConvertHTMLStringToPDF(); // convert HTML string to PDF
            }
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
