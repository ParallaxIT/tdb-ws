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
    public partial class HtmlElementsLocationInPdf : Form
    {
        public HtmlElementsLocationInPdf()
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

                // inform the converter about the HTML elements for which we want the location in PDF
                // in this sample we want the location of IMG, H1 and H2 elements and the elements having ID 'id1' or 'id2'
                pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = new string[] { "IMG", "H1", "H2", "#id1", "#id2" };
                
                // call the converter and get a Document object from URL
                Document pdfDocument = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL.Text.Trim());

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

                // save the PDF bytes in a file on disk
                string outFilePath = System.IO.Path.Combine(Application.StartupPath, "HtmlElementsLocation.pdf");

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
    }
}