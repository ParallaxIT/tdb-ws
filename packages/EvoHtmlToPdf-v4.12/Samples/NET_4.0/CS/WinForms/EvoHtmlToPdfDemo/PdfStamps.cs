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
    public partial class PdfStamps : Form
    {
        public PdfStamps()
        {
            InitializeComponent();
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            string pdfToModify = textBoxPdfFilePath.Text.Trim();

            // create a PDF document
            Document document = new Document(pdfToModify);

            // set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // get the first page the PDF document
            PdfPage firstPage = document.Pages[0];

            string logoTransImagePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\img\evologo-100-trans.png");
            string logoOpaqueImagePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\img\evologo-100.jpg");

            // add an opaque image stamp in the top left corner of the first page
            // and make it semitransparent when rendered in PDF
            ImageElement imageStamp = new ImageElement(1, 1, logoOpaqueImagePath);
            imageStamp.Opacity = 50;
            AddElementResult addResult = firstPage.AddElement(imageStamp);

            // add a border for the image stamp
            RectangleElement imageBorderRectangleElement = new RectangleElement(1, 1, addResult.EndPageBounds.Width,
                                addResult.EndPageBounds.Height);
            firstPage.AddElement(imageBorderRectangleElement);

            // add a template stamp to the document repeated on each document page
            // the template contains an image and a text

            System.Drawing.Image logoImg = System.Drawing.Image.FromFile(logoTransImagePath);

            // calculate the template stamp location and size
            System.Drawing.SizeF imageSizePx = logoImg.PhysicalDimension;

            float imageWidthPoints = UnitsConverter.PixelsToPoints(imageSizePx.Width);
            float imageHeightPoints = UnitsConverter.PixelsToPoints(imageSizePx.Height);

            float templateStampXLocation = (firstPage.ClientRectangle.Width - imageWidthPoints) / 2;
            float templateStampYLocation = firstPage.ClientRectangle.Height / 4;

            // the stamp size is equal to image size in points
            Template templateStamp = document.AddTemplate(new System.Drawing.RectangleF(templateStampXLocation, templateStampYLocation,
                    imageWidthPoints, imageHeightPoints + 20));

            // set a semitransparent background color for template
            RectangleElement background = new RectangleElement(0, 0, templateStamp.ClientRectangle.Width, templateStamp.ClientRectangle.Height);
            background.BackColor = Color.White;
            background.Opacity = 25;
            templateStamp.AddElement(background);

            // add a true type font to the document
            System.Drawing.Font ttfFontBoldItalic = new System.Drawing.Font("Times New Roman", 10,
                        System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            PdfFont templateStampTextFont = document.AddFont(ttfFontBoldItalic, true);

            // Add a text element to the template. You can add any other types of elements to a template like a HtmlToPdfElement.
            TextElement templateStampTextElement = new TextElement(3, 0, "This is the Stamp Text", templateStampTextFont);
            templateStampTextElement.ForeColor = System.Drawing.Color.DarkBlue;
            templateStamp.AddElement(templateStampTextElement);

            // Add an image with transparency to the template. You can add any other types of elements to a template like a HtmlToPdfElement.
            ImageElement templateStampImageElement = new ImageElement(0, 20, logoImg);
            // instruct the library to use transparency information
            templateStampImageElement.RenderTransparentImage = true;
            templateStamp.AddElement(templateStampImageElement);

            // add a border to template
            RectangleElement templateStampRectangleElement = new RectangleElement(0, 0, templateStamp.ClientRectangle.Width,
                        templateStamp.ClientRectangle.Height);
            templateStamp.AddElement(templateStampRectangleElement);

            // dispose the image
            logoImg.Dispose();

            string outFilePath = System.IO.Path.Combine(Application.StartupPath, "PdfStamps.pdf");

            // save the PDF document to disk
            try
            {
                document.Save(outFilePath);
            }
            finally
            {
                document.Close();
            }

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

        private void PdfStamps_Load(object sender, EventArgs e)
        {
            textBoxPdfFilePath.Text = System.IO.Path.Combine(Application.StartupPath, @"..\..\ExternalPdfs\book.pdf");
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*";
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textBoxPdfFilePath.Text = fd.FileName;
            }
        }
    }
}