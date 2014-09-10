using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using EvoPdf;

namespace EvoHtmlToPdfDemo
{
    public partial class TableOfContentsAndBookmarks : Form
    {
        private const int TOC_ENTRIES_COUNT = 16;
        private const int PAGE_NUMBER_FONT_SIZE = 10;

        public TableOfContentsAndBookmarks()
        {
            InitializeComponent();
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                PdfConverter pdfConverter = new PdfConverter();

                // set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

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
                string htmlBookFilePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\HtmlBook\Book.htm");

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

                // save the PDF bytes in a file on disk
                string outFilePath = System.IO.Path.Combine(Application.StartupPath, "TOCAndBookmarks.pdf");

                try
                {
                    pdfDocument.Save(outFilePath);
                }
                finally
                {
                    // close the Document to realease all the resources
                    pdfDocument.Close();
                }

                // open the generated PDF document in an external viewer
                DialogResult dr = MessageBox.Show("Open the rendered file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                {
                    System.Diagnostics.Process.Start(outFilePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }
        }

        private void lnkViewHtmlBook_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // the URL of the HTML document to convert
            string htmlBookFilePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\HtmlBook\Book.htm");
            try
            {
                System.Diagnostics.Process.Start(htmlBookFilePath);
            }
            catch
            {
                MessageBox.Show("There is no HTML viewer installed.");
            }
        }
    }
}