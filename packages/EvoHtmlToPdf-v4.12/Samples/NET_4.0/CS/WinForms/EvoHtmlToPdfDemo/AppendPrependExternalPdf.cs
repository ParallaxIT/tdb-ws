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
    public partial class AppendPrependExternalPdf : Form
    {
        public AppendPrependExternalPdf()
        {
            InitializeComponent();
        }

        private void btnConvertMerge_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            MemoryStream pdfStream2 = null;

            try
            {
                PdfConverter pdfConverter = new PdfConverter();

                // set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

                // Convert the first document and produce a Document object containing the conversion result
                Document document1 = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL1.Text);

                // Load a second document from a stream produced by the conversion of the second URL
                byte[] doc2Bytes = pdfConverter.GetPdfBytesFromUrl(textBoxURL2.Text);
                pdfStream2 = new MemoryStream(doc2Bytes);

                // Load a PDF document from a stream
                Document document2 = new Document(pdfStream2);

                // Append second to the first document
                document1.AppendDocument(document2);

                // Convert the third URL to PDF and obtain a PDF document object
                Document document3 = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL3.Text);

                // Append the third document after the second
                document1.AppendDocument(document3);

                // When AutoCloseAppendedDocs property is set on true the appended documents are automatically closed
                // when the document to which they are appended is closed
                document1.AutoCloseAppendedDocs = true;

                string outFilePath = Path.Combine(Application.StartupPath, "AppendDocument.pdf");

                try
                {
                    document1.Save(outFilePath);
                }
                finally
                {
                    // Close the Document to realease all the resources
                    // The appended document2 and document3 will be automatically closed
                    document1.Close();
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
                // close the memory stream
                if (pdfStream2 != null) 
                    pdfStream2.Close();

                this.Cursor = Cursors.Arrow;
            }
        }
    }
}