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
    public partial class TableOfContentsAndBookmarks : System.Web.UI.Page
    {
        private const int TOC_ENTRIES_COUNT = 16;
        private const int PAGE_NUMBER_FONT_SIZE = 10;

        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("TableOfContents");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            PdfConverter pdfConverter = new PdfConverter();

            // show the bookmarks when the document is opened
            pdfConverter.PdfViewerPreferences.PageMode = ViewerPageMode.UseOutlines;

            // set top and bottom page margins
            pdfConverter.PdfDocumentOptions.TopMargin = 5;
            pdfConverter.PdfDocumentOptions.BottomMargin = 5;

            // Inform the converter about the HTML elements for which we want the location in PDF
            // In this sample we want the location of the entries in the Table of Contents
            // The HTML ID of each entry in the table of contents is of form TOCEntry_{EntryIndex}_ID
            // the HTML ID of each target of a table of contents entry is of form TOCEntry_{EntryIndex}_Target_ID

            // Both toc entries and toc entries targets locations in PDF will be retrieved
            // and therefore the number of IDs is twice TOC entries number
            pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = new string[2 * TOC_ENTRIES_COUNT];

            int mappingsTableIdx = 0;
            for (int tocEntryIndex = 1; tocEntryIndex <= TOC_ENTRIES_COUNT; tocEntryIndex++)
            {
                // add the HTML ID of the TOC entry element to the list of elements for which we want the PDF location
                string tocEntryID = String.Format("#TOCEntry_{0}_ID", tocEntryIndex);
                pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors[mappingsTableIdx++] = tocEntryID;

                // add the HTML ID of the TOC entry target element to the list of elements for which we want the PDF location
                string tocEntryTargetID = String.Format("#TOCEntry_{0}_Target_ID", tocEntryIndex);
                pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors[mappingsTableIdx++] = tocEntryTargetID;
            }

            // set bookmark options
            pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = new string[] { "A[class=\"bookmark\"]" };

            // the URL of the HTML document to convert
            string thisPageURL = HttpContext.Current.Request.Url.AbsoluteUri;
            string htmlBookFilePath = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + "/HtmlBook/Book.htm";

            // call the converter and get a Document object from URL
            Document pdfDocument = pdfConverter.GetPdfDocumentObjectFromUrl(htmlBookFilePath);

            // Create a font used to write the page numbers in the table of contents
            PdfFont pageNumberFont = pdfDocument.Fonts.Add(new Font("Arial", PAGE_NUMBER_FONT_SIZE, FontStyle.Bold, GraphicsUnit.Point), true);

            // get the right edge of the table of contents where to position the page numbers
            float tocEntryMaxRight = 0.0f;
            for (int tocEntryIdx = 1; tocEntryIdx <= TOC_ENTRIES_COUNT; tocEntryIdx++)
            {
                string tocEntryID = String.Format("TOCEntry_{0}_ID", tocEntryIdx);
                HtmlElementMapping tocEntryLocation = pdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByHtmlId(tocEntryID);
                if (tocEntryLocation.PdfRectangles[0].Rectangle.Right > tocEntryMaxRight)
                    tocEntryMaxRight = tocEntryLocation.PdfRectangles[0].Rectangle.Right;
            }


            // Add page number for each entry in the table of contents
            for (int tocEntryIdx = 1; tocEntryIdx <= TOC_ENTRIES_COUNT; tocEntryIdx++)
            {
                string tocEntryID = String.Format("TOCEntry_{0}_ID", tocEntryIdx);
                string tocEntryTargetID = String.Format("TOCEntry_{0}_Target_ID", tocEntryIdx);

                HtmlElementMapping tocEntryLocation = pdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByHtmlId(tocEntryID);
                HtmlElementMapping tocEntryTargetLocation = pdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByHtmlId(tocEntryTargetID);

                // get the TOC entry page and bounds
                PdfPage tocEntryPdfPage = pdfDocument.Pages[tocEntryLocation.PdfRectangles[0].PageIndex];
                RectangleF tocEntryPdfRectangle = tocEntryLocation.PdfRectangles[0].Rectangle;

                // get the page number of target where the TOC entry points
                int tocEntryTargetPageNumber = tocEntryTargetLocation.PdfRectangles[0].PageIndex + 1;

                // add dashed line from text entry to the page number
                LineElement lineToNumber = new LineElement(tocEntryPdfRectangle.Right + 5, tocEntryPdfRectangle.Y + tocEntryPdfRectangle.Height / 2,
                        tocEntryMaxRight + 80, tocEntryPdfRectangle.Y + tocEntryPdfRectangle.Height / 2);
                lineToNumber.LineStyle.LineWidth = 1;
                lineToNumber.LineStyle.LineDashStyle = LineDashStyle.Dash;
                lineToNumber.ForeColor = Color.Green;
                tocEntryPdfPage.AddElement(lineToNumber);

                // create the page number text element to the right of the TOC entry
                TextElement pageNumberTextEement = new TextElement(tocEntryMaxRight + 85, tocEntryPdfRectangle.Y, -1, tocEntryPdfRectangle.Height,
                        tocEntryTargetPageNumber.ToString(), pageNumberFont);
                pageNumberTextEement.TextAlign = HorizontalTextAlign.Left;
                pageNumberTextEement.VerticalTextAlign = VerticalTextAlign.Middle;
                pageNumberTextEement.ForeColor = Color.Blue;

                // add the page number to the right of the TOC entry
                tocEntryPdfPage.AddElement(pageNumberTextEement);
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
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=TableOfContents.pdf; size={0}", pdfBytes.Length.ToString()));

            // write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes);

            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to PDF document stream
            httpResponse.End();
        }
    }
}
