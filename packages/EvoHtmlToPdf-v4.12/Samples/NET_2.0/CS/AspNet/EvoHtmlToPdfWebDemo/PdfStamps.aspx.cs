using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using System.Drawing;

using EvoPdf;

namespace EvoHtmlToPdfWebDemo
{
    public partial class PdfStamps : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("PdfStamps");

            if (!IsPostBack)
            {
                string defaultExistingPdf = System.IO.Path.Combine(Server.MapPath("~"), @"ExternalPdfs\book.pdf");
                textBoxPdfFilePath.Text = defaultExistingPdf;
            }
        }

        protected void btnCreatePDF_Click(object sender, EventArgs e)
        {
            string pdfToModify = textBoxPdfFilePath.Text.Trim();

            // create a PDF document
            Document document = new Document(pdfToModify);

            // set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // get the first page the PDF document
            PdfPage firstPage = document.Pages[0];

            string logoTransImagePath = System.IO.Path.Combine(Server.MapPath("~"), @"images\evologo-100-trans.png");
            string logoOpaqueImagePath = System.IO.Path.Combine(Server.MapPath("~"), @"images\evologo-100.jpg");

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

            // save the document on http response stream
            try
            {
                // get the PDF document bytes
                byte[] pdfBytes = document.Save();

                // send the generated PDF document to client browser

                // get the object representing the HTTP response to browser
                HttpResponse httpResponse = HttpContext.Current.Response;

                // add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf");
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=PdfStamps.pdf; size={0}", pdfBytes.Length.ToString()));

                // write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes);

                // Note: it is important to end the response, otherwise the ASP.NET
                // web page will render its content to PDF document stream
                httpResponse.End();
            }
            finally
            {
                document.Close();
            }
        }
    }
}
