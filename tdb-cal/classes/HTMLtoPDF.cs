using System;
using EvoPdf;
using System.Drawing;

namespace tdb_cal.classes
{
    public class HTMLtoPDF
    {
        public static byte[] GeneratePDF(string html, string title, int topMargin, int bottomMargin, int leftMargin, int rightMargin)
        {
            var pdfConv = new PdfConverter { LicenseKey = "Z+n56Pv76Pn6/uj85vjo+/nm+frm8fHx8Q==" };

            pdfConv.PdfDocumentOptions.TopMargin = topMargin;
            pdfConv.PdfDocumentOptions.BottomMargin = bottomMargin;
            pdfConv.PdfDocumentOptions.LeftMargin = leftMargin;
            pdfConv.PdfDocumentOptions.RightMargin = rightMargin;

            pdfConv.PdfDocumentOptions.EmbedFonts = true;

            // set header options
            pdfConv.PdfDocumentOptions.ShowHeader = true;
            pdfConv.PdfHeaderOptions.HeaderHeight = 50;
            AddHeaderElements(pdfConv);

            // set footer options
            pdfConv.PdfDocumentOptions.ShowFooter = true;
            pdfConv.PdfFooterOptions.FooterHeight = 50f;
            AddFooterElements(pdfConv);

            pdfConv.PdfDocumentInfo.Title = title;
            pdfConv.PdfDocumentInfo.CreatedDate = DateTime.Now;
            pdfConv.PdfDocumentInfo.AuthorName = "";

            return pdfConv.GetPdfBytesFromHtmlString(html, "http://www.thedrillbook.com/");

        }

        private static void AddHeaderElements(PdfConverter pdfConverter)
        {
            // set the header HTML area
            var headerHtml = new HtmlToPdfElement("<img src='img/tdb_logo_l2.png' />", "http://www.thedrillbook.com/")
            {
                FitHeight = true
            };
            pdfConverter.PdfHeaderOptions.AddElement(headerHtml);

            // set the header line
            float pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageOrientation == PdfPageOrientation.Portrait ? pdfConverter.PdfDocumentOptions.PdfPageSize.Width : pdfConverter.PdfDocumentOptions.PdfPageSize.Height;

            var headerLine = new LineElement(0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                        pdfPageWidth - pdfConverter.PdfDocumentOptions.LeftMargin - pdfConverter.PdfDocumentOptions.RightMargin,
                        pdfConverter.PdfHeaderOptions.HeaderHeight)
            {
                LineStyle = { LineWidth = 0.5f },
                ForeColor = Color.Black
            };

            pdfConverter.PdfHeaderOptions.AddElement(headerLine);


        }

        private static void AddFooterElements(PdfConverter pdfConverter)
        {
            //write the page number
            var footerText = new TextElement(0, pdfConverter.PdfFooterOptions.FooterHeight - 15, "Page &p; of &P;  ",
                new Font(new FontFamily("Arial"), 10, GraphicsUnit.Point))
            {
                EmbedSysFont = true,
                TextAlign = HorizontalTextAlign.Right
            };
            pdfConverter.PdfFooterOptions.AddElement(footerText);

            // set the footer line
            float pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageOrientation == PdfPageOrientation.Portrait ? pdfConverter.PdfDocumentOptions.PdfPageSize.Width : pdfConverter.PdfDocumentOptions.PdfPageSize.Height;

            var footerLine = new LineElement(0, 0,
                        pdfPageWidth - pdfConverter.PdfDocumentOptions.LeftMargin -
                        pdfConverter.PdfDocumentOptions.RightMargin, 0)
            {
                LineStyle = { LineWidth = 0.5f },
                ForeColor = Color.Black
            };
            pdfConverter.PdfFooterOptions.AddElement(footerLine);

        }
    }
}