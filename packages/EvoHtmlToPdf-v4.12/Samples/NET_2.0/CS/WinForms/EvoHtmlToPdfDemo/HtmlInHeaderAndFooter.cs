using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

using EvoPdf;

namespace EvoHtmlToPdfDemo
{
    public partial class HtmlInHeaderAndFooter : Form
    {
        public HtmlInHeaderAndFooter()
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

                // show header and footer in the rendered PDF
                pdfConverter.PdfDocumentOptions.ShowHeader = true;
                pdfConverter.PdfDocumentOptions.ShowFooter = true;

                // set the header height in points
                pdfConverter.PdfHeaderOptions.HeaderHeight = 60;

                // set the header HTML area
                HtmlToPdfElement headerHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                    Path.Combine(Application.StartupPath, @"..\..\HeaderFooter\HeaderAndFooterHtml.htm"), 1024, 0);
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
                    Path.Combine(Application.StartupPath, @"..\..\HeaderFooter\HeaderAndFooterHtml.htm"), 1024, 0);
                footerHtml.FitHeight = true;
                pdfConverter.PdfFooterOptions.AddElement(footerHtml);

                // save the PDF bytes in a file on disk
                string outFilePath = Path.Combine(Application.StartupPath, "HtmlInHeaderAndFooter.pdf");

                if (!cbAlternateHeaderAndFooter.Checked)
                {
                    // the header content is the same on all the PDF pages
                    // the footer content is the same on all the PDF pages
                    pdfConverter.SavePdfFromUrlToFile(textBoxURL1.Text, outFilePath);
                }
                else
                {
                    // set an alternate header and footer on the even pages

                    // call the converter and get a Document object from URL
                    Document pdfDocument = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL1.Text);

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

                        // add html to the header
                        HtmlToPdfElement altHeaderHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                            Path.Combine(Application.StartupPath, @"..\..\HeaderFooter\HeaderAndFooterHtml2.htm"), 1024, 0);
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
                            Path.Combine(Application.StartupPath, @"..\..\HeaderFooter\HeaderAndFooterHtml2.htm"), 1024, 0);
                        altFooterHtml.FitHeight = true;
                        altFooterTemplate.AddElement(altFooterHtml);

                        for (int pageIndex = 1; pageIndex < pdfDocument.Pages.Count; pageIndex += 2)
                        {
                            PdfPage pdfPage = pdfDocument.Pages[pageIndex];

                            pdfPage.Header = altHeaderTemplate;
                            pdfPage.Footer = altFooterTemplate;
                        }
                    }

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
                }

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
    }
}