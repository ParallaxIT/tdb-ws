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
    public partial class DigitalSignature : Form
    {
        public DigitalSignature()
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

            string logoImagePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\img\evologo-250.png");
            string certificateFilePath = System.IO.Path.Combine(Application.StartupPath, @"..\..\certificates\evopdf.pfx");

            PdfFont pdfFont = document.Fonts.Add(new Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point));
            TextElement descriptionTextElement = new TextElement(0, 0, 
                "A digital signature was applied on the logo image below. Click on the image to see the signature details", pdfFont);
            AddElementResult addResult = firstPage.AddElement(descriptionTextElement);

            // create the area where the digital signature will be displayed in the PDF document
            // in this sample the area is a logo image but it could be anything else
            ImageElement logoElement = new ImageElement(0, addResult.EndPageBounds.Bottom + 10, 100, logoImagePath);
            addResult = firstPage.AddElement(logoElement);

            //get the #PKCS 12 certificate from file
            DigitalCertificatesCollection certificates = DigitalCertificatesStore.GetCertificates(certificateFilePath, "evopdf");
            DigitalCertificate certificate = certificates[0];

            // create the digital signature over the logo image element
            DigitalSignatureElement signature = new DigitalSignatureElement(addResult.EndPageBounds, certificate);
            signature.Reason = "Protect the document from unwanted changes";
            signature.ContactInfo = "The contact email is support@evopdf.com";
            signature.Location = "Development server";
            firstPage.AddElement(signature);

            string outFilePath = System.IO.Path.Combine(Application.StartupPath, "DigitalSignature.pdf");

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