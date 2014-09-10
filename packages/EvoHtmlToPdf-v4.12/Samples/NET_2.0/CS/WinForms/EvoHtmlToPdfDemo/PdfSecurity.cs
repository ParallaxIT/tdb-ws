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
    public partial class PdfSecurity : Form
    {
        public PdfSecurity()
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

                // set user and owner passwords
                pdfConverter.PdfSecurityOptions.UserPassword = "user";
                pdfConverter.PdfSecurityOptions.OwnerPassword = "owner";

                // restrict the right to print and to copy the document content
                pdfConverter.PdfSecurityOptions.CanPrint = false;
                pdfConverter.PdfSecurityOptions.CanCopyContent = false;

                // save the PDF bytes in a file on disk
                string outFilePath = Path.Combine(Application.StartupPath, "PdfSecurity.pdf");

                pdfConverter.SavePdfFromUrlToFile(textBoxURL1.Text, outFilePath);
                
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