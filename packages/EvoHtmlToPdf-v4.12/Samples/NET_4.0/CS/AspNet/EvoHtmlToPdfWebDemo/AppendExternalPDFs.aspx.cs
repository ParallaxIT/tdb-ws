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

using System.IO;

using EvoPdf;

namespace EvoHtmlToPdfWebDemo
{
    public partial class AppendExternalPDFs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("AppendPdf");
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            MemoryStream pdfStream2 = null;

            try
            {
                PdfConverter pdfConverter = new PdfConverter();

                // set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

                // Convert the first document and produce a Document object containing the conversion result
                Document document1 = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxWebPageURL1.Text);

                // Load a second document from a stream produced by the conversion of the second URL
                byte[] doc2Bytes = pdfConverter.GetPdfBytesFromUrl(textBoxWebPageURL2.Text);
                pdfStream2 = new MemoryStream(doc2Bytes);

                // Load a PDF document from a stream
                Document document2 = new Document(pdfStream2);

                // Append second to the first document
                document1.AppendDocument(document2);

                // Convert the third URL to PDF and obtain a PDF document object
                Document document3 = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxWebPageURL3.Text);

                // Append the third document after the second
                document1.AppendDocument(document3);

                // When AutoCloseAppendedDocs property is set on true the appended documents are automatically closed
                // when the document to which they are appended is closed
                document1.AutoCloseAppendedDocs = true;

                byte[] pdfBytes = null;

                try
                {
                    pdfBytes = document1.Save();
                }
                finally
                {
                    // Close the Document to realease all the resources
                    // The appended document3 will be automatically closed also
                    document1.Close();
                }

                // send the generated PDF document to client browser

                // get the object representing the HTTP response to browser
                HttpResponse httpResponse = HttpContext.Current.Response;

                // add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf");
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlToPdfFeatures.pdf; size={0}", pdfBytes.Length.ToString()));

                // write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes);

                // Note: it is important to end the response, otherwise the ASP.NET
                // web page will render its content to PDF document stream
                httpResponse.End();
            }
            finally
            {
                if (pdfStream2 != null)
                    pdfStream2.Close();
            }
        }
    }
}
