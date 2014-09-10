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

using EvoPdf;

namespace EvoHtmlToPdfWebDemo
{
    public partial class ImageElementDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("ImageElement");
        }

        protected void btnCreatePDF_Click(object sender, EventArgs e)
        {
            // create a PDF document
            Document document = new Document();

            // set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // add a page to the PDF document
            PdfPage firstPage = document.AddPage();

            string imagesPath = System.IO.Path.Combine(Server.MapPath("~"), "Images");

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

            try
            {
                // get the PDF document bytes
                byte[] pdfBytes = document.Save();

                // send the generated PDF document to client browser

                // get the object representing the HTTP response to browser
                HttpResponse httpResponse = HttpContext.Current.Response;

                // add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf");
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=ImageElement.pdf; size={0}", pdfBytes.Length.ToString()));

                // write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes);

                // Note: it is important to end the response, otherwise the ASP.NET
                // web page will render its content to PDF document stream
                httpResponse.End();
            }
            finally
            {
                // close the PDF document to release the resources
                document.Close();
            }
        }
    }
}
