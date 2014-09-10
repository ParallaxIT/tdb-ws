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
    public partial class HtmlInHeaderAndFooter : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("HtmlInHeaderAndFooter");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            PdfConverter pdfConverter = new PdfConverter();

            // set the license key
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // show header and footer in the rendered PDF
            pdfConverter.PdfDocumentOptions.ShowHeader = true;
            pdfConverter.PdfDocumentOptions.ShowFooter = true;

            // set the header height in points
            pdfConverter.PdfHeaderOptions.HeaderHeight = 60;

            string thisPageURL = HttpContext.Current.Request.Url.AbsoluteUri;
            string headerAndFooterHtmlUrl = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + 
                            "/HeaderFooter/HeaderAndFooterHtml.htm";

            // set the header HTML area
            HtmlToPdfElement headerHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                   headerAndFooterHtmlUrl, 1024, 0);
            headerHtml.FitHeight = true;
            pdfConverter.PdfHeaderOptions.AddElement(headerHtml);

            // set the footer height in points
            pdfConverter.PdfFooterOptions.FooterHeight = 60;
            //write the page number
            TextElement footerTextElement = new TextElement(0, 30, "This is page &p; of &P;  ",
                    new Font(new FontFamily("Times New Roman"), 10, GraphicsUnit.Point));
            footerTextElement.TextAlign = HorizontalTextAlign.Right;
            pdfConverter.PdfFooterOptions.AddElement(footerTextElement);

            // set the footer HTML area
            HtmlToPdfElement footerHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfFooterOptions.FooterHeight,
                headerAndFooterHtmlUrl, 1024, 0);
            footerHtml.FitHeight = true;
            pdfConverter.PdfFooterOptions.AddElement(footerHtml);

            if (!cbAlternateHeaderAndFooter.Checked)
            {
                // Performs the conversion and get the pdf document bytes that can 
                // be saved to a file or sent as a browser response
                byte[] pdfBytes = pdfConverter.GetPdfBytesFromUrl(textBoxWebPageURL.Text);

                // send the generated PDF document to client browser

                // get the object representing the HTTP response to browser
                HttpResponse httpResponse = HttpContext.Current.Response;

                // add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf");
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlInHeaderAndFooter.pdf; size={0}", pdfBytes.Length.ToString()));

                // write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes);

                // Note: it is important to end the response, otherwise the ASP.NET
                // web page will render its content to PDF document stream
                httpResponse.End();
            }
            else
            {
                // set an alternate header and footer on the even pages

                // call the converter and get a Document object from URL
                Document pdfDocument = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxWebPageURL.Text);

                if (pdfDocument.Pages.Count >= 2)
                {
                    // get the alternate header and footer width and height
                    // the width is given by the PDF page width
                    float altHeaderFooterWidth = pdfDocument.Pages[0].ClientRectangle.Width;
                    // the height is the same with the document header height from the PdfConverter object
                    float altHeaderHeight = pdfConverter.PdfHeaderOptions.HeaderHeight;
                    float altFooterHeight = pdfConverter.PdfFooterOptions.FooterHeight;

                    // create the alternate header template
                    Template altHeaderTemplate = pdfDocument.Templates.AddNewTemplate(altHeaderFooterWidth, altHeaderHeight);

                    string alternateHeaderAndFooterHtmlUrl = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + 
                                "/HeaderFooter/HeaderAndFooterHtml2.htm";

                    // add html to the header
                    HtmlToPdfElement altHeaderHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                                        alternateHeaderAndFooterHtmlUrl, 1024, 0);
                    altHeaderHtml.FitHeight = true;
                    altHeaderTemplate.AddElement(altHeaderHtml);

                    // add a horizontal line to the bottom of the header
                    LineElement headerLine = new LineElement(0, altHeaderHeight, altHeaderFooterWidth, altHeaderHeight);
                    altHeaderTemplate.AddElement(headerLine);

                    // add page numbering to the left of the header
                    PdfFont pageNumberFont = pdfDocument.Fonts.Add(new Font(new FontFamily("Times New Roman"), 10, GraphicsUnit.Point));
                    TextElement pageNumbering = new TextElement(10, 10, "Page &p; of &P;", pageNumberFont, Color.Blue);

                    altHeaderTemplate.AddElement(pageNumbering);

                    // create the alternate footer template
                    Template altFooterTemplate = pdfDocument.Templates.AddNewTemplate(altHeaderFooterWidth, altFooterHeight);

                    // add html to the footer
                    HtmlToPdfElement altFooterHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                                        alternateHeaderAndFooterHtmlUrl, 1024, 0);
                    altFooterHtml.FitHeight = true;
                    altFooterTemplate.AddElement(altFooterHtml);

                    for (int pageIndex = 1; pageIndex < pdfDocument.Pages.Count; pageIndex += 2)
                    {
                        PdfPage pdfPage = pdfDocument.Pages[pageIndex];

                        pdfPage.Header = altHeaderTemplate;
                        pdfPage.Footer = altFooterTemplate;
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
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlInHeaderAndFooter.pdf; size={0}", pdfBytes.Length.ToString()));

                // write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes);

                // Note: it is important to end the response, otherwise the ASP.NET
                // web page will render its content to PDF document stream
                httpResponse.End();
            }
        }
    }
}
