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
    public partial class SvgToPdf : Form
    {
        public SvgToPdf()
        {
            InitializeComponent();
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                PdfConverter pdfConverter = new PdfConverter();

                // set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

                // We convert the HTML page as local disk file because IIS and VS WebDev Server 
                // don't have .svg included in MIME types by default.
                // When converting HTML pages from an IIS server the MIME type image/svg+xml 
                // must be added to IIS in order to serve the .svg files referenced in HTML
                string htmlWithSvgFilePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\SVG\svg.html");

                // SVG can be used inline in a XML document
                string xmlWithInlineSvgFilePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\SVG\svginline.xml");

                this.Cursor = Cursors.WaitCursor;

                // save the PDF bytes in a file on disk
                string outFilePath = System.IO.Path.Combine(Application.StartupPath, "SvgToPdf.pdf");

                try
                {
                    // call the converter
                    byte[] pdfBytes = pdfConverter.GetPdfBytesFromUrl(htmlWithSvgFilePath);
                    System.IO.File.WriteAllBytes(outFilePath, pdfBytes);
                }
                finally
                {
                    this.Cursor = Cursors.Arrow;
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

        private void lnkViewSvg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // the URL of the HTML with SVG document to convert
            string htmlWithSvgFilePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\SVG\svg.html");
            try
            {
                System.Diagnostics.Process.Start(htmlWithSvgFilePath);
            }
            catch
            {
                MessageBox.Show("There is no HTML viewer installed.");
            }
        }
    }
}