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
    public partial class RepeatTableHeadOnEachPage : Form
    {
        private const int TOC_ENTRIES_COUNT = 16;
        private const int PAGE_NUMBER_FONT_SIZE = 10;

        public RepeatTableHeadOnEachPage()
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

                // the URL of the HTML table with repeated header
                string htmlTableFilePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\HtmlTable\table_with_repeated_head.html");

                this.Cursor = Cursors.WaitCursor;

                // save the PDF bytes in a file on disk
                string outFilePath = System.IO.Path.Combine(Application.StartupPath, "RepeatedTableHead.pdf");

                try
                {
                    // call the converter
                    byte[] pdfBytes = pdfConverter.GetPdfBytesFromUrl(htmlTableFilePath);
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


        private void lnkViewHtmlTable_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // the URL of the HTML document to convert
            string htmlTableFilePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\HtmlTable\table_with_repeated_head.html");
            try
            {
                System.Diagnostics.Process.Start(htmlTableFilePath);
            }
            catch
            {
                MessageBox.Show("There is no HTML viewer installed.");
            }
        }
    }
}