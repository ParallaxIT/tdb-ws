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
    public partial class ConvertMultipleURLsToPdf : Form
    {
        public ConvertMultipleURLsToPdf()
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

                // save the PDF bytes in a file on disk
                string outFilePath = System.IO.Path.Combine(Application.StartupPath, "Result.pdf");

                // save the PDF document to a file on disk
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
                DialogResult dr = MessageBox.Show("Open the rendered file in an external viewer?",
                    "Open Rendered File", MessageBoxButtons.YesNo);

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

        private void AddHeader(PdfConverter pdfConverter)
        {
            string headerAndFooterHtmlUrl = System.IO.Path.Combine(Application.StartupPath,
                        @"..\..\HeaderFooter\HeaderAndFooterHtml.htm");

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
            string headerAndFooterHtmlUrl = System.IO.Path.Combine(Application.StartupPath,
                        @"..\..\HeaderFooter\HeaderAndFooterHtml.htm");

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