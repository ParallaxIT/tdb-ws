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
    public partial class ImageElementDemo : Form
    {
        public ImageElementDemo()
        {
            InitializeComponent();
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            // create a PDF document
            Document document = new Document();

            // set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // add a page to the PDF document
            PdfPage firstPage = document.AddPage();

            string imagesPath = System.IO.Path.Combine(Application.StartupPath, @"..\..\Img");

            // display image in the available space in page and with a auto determined height to keep the aspect ratio
            ImageElement imageElement1 = new ImageElement(0, 0, System.IO.Path.Combine(imagesPath, "evologo-250.png"));
            AddElementResult addResult = firstPage.AddElement(imageElement1);

            // display image with the specified width and the height auto determined to keep the aspect ratio
            // the images is displayed to the right of the previous image and the bounds of the image inside the current page
            // are taken from the AddElementResult object
            ImageElement imageElement2 = new ImageElement(addResult.EndPageBounds.Right + 10, 0, 100,
                    System.IO.Path.Combine(imagesPath, "evologo-250.png"));
            addResult = firstPage.AddElement(imageElement2);

            // Display image with the specified width and the specified height. It is possible for the image to not preserve the aspect ratio 
            // The images is displayed to the right of the previous image and the bounds of the image inside the current page
            // are taken from the AddElementResult object
            ImageElement imageElement3 = new ImageElement(addResult.EndPageBounds.Right + 10, 0, 100, 50,
                    System.IO.Path.Combine(imagesPath, "evologo-250.png"));
            addResult = firstPage.AddElement(imageElement3);

            string outFilePath = System.IO.Path.Combine(Application.StartupPath, "ImageElementDemo.pdf");

            // save the PDF document to disk
            document.Save(outFilePath);

            // close the PDF document to release the resources
            document.Close();

            DialogResult dr = MessageBox.Show("Open the saved file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start(outFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }
}