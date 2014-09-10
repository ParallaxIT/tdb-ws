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
using System.Text;

using EvoPdf;

namespace EvoHtmlToPdfWebDemo
{
    public partial class PdfInvoicesDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("PdfInvoices");

            lblInvoiceTemplateMessage.Visible = false;

            if (!IsPostBack)
            {
                ShowItemsCount();
                LoadInvoiceItems();
            }
        }

        private void ShowItemsCount()
        {
            lblItemsCount.Text = InvoiceData.GetInvoiceData().InvoiceItems.Count.ToString();
        }

        protected void btnAddItem_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            if (InvoiceData.GetInvoiceData().InvoiceItems.Count >= 100)
            {
                lblInvoiceTemplateMessage.Text = "The maximum number of items reached.";
                lblInvoiceTemplateMessage.Visible = true;
                return;
            }

            InvoiceItem newInvoiceItem = new InvoiceItem(textBoxProductCode.Text, textBoxProductDescription.Text,
                textBoxProductName.Text, double.Parse(textBoxProductPrice.Text.Trim()), int.Parse(textBoxProductQuantity.Text.Trim()));

            InvoiceData.GetInvoiceData().AddItem(newInvoiceItem);

            ShowItemsCount();
            LoadInvoiceItems();
        }

        private void LoadInvoiceItems()
        {
            itemsGrid.Visible = false;
            if (InvoiceData.GetInvoiceData().InvoiceItems.Count > 0)
            {
                itemsGrid.DataSource = InvoiceData.GetInvoiceData().InvoiceItems;
                itemsGrid.DataBind();
                itemsGrid.Visible = true;
            }
        }

        private void SaveCustomerInfo()
        {
            InvoiceData.GetInvoiceData().CustomerInfo = new CustomerInfo(textBoxCustomerName.Text, textBoxCustomerAddress.Text,
                textBoxAddress2.Text, textBoxCustomerPhone.Text, textBoxCustomerEmail.Text);
        }

        /// <summary>
        /// Generate the PDF invoice from the HTML template based on the current session data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnGenerateInvoice_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            // save customer info on the session 
            // to make it available in the report page
            SaveCustomerInfo();

            // get the html string for the report
            StringWriter htmlStringWriter = new StringWriter();
            Server.Execute("InvoiceTemplate.aspx", htmlStringWriter);
            string htmlCodeToConvert = htmlStringWriter.GetStringBuilder().ToString();
            htmlStringWriter.Close();

            //initialize the PdfConvert object
            PdfConverter pdfConverter = new PdfConverter();

            // set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4;
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
            pdfConverter.PdfDocumentOptions.ShowHeader = false;
            pdfConverter.PdfDocumentOptions.ShowFooter = false;

            // get the base url for string conversion which is the url from where the html code was retrieved
            // the base url is used by the converter to get the full URL of the external CSS and images referenced by relative URLs
            string baseUrl = HttpContext.Current.Request.Url.AbsoluteUri;

            // get the pdf bytes from html string
            byte[] pdfBytes = pdfConverter.GetPdfBytesFromHtmlString(htmlCodeToConvert, baseUrl);

            System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
            response.Clear();
            response.AddHeader("Content-Type", "application/pdf");
            response.AddHeader("Content-Disposition", String.Format("attachment; filename=PdfInvoice.pdf; size={0}", pdfBytes.Length.ToString()));
            response.BinaryWrite(pdfBytes);
            // Note: it is important to end the response, otherwise the ASP.NET
            // web page will render its content to PDF document stream
            response.End();
        }

        protected void btnInvoicePreview_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            SaveCustomerInfo();

            Response.Redirect("InvoiceTemplate.aspx");
        }
        protected void cvPriceValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            try
            {
                double price = double.Parse(textBoxProductPrice.Text.Trim());
                if (price < 0)
                    throw new Exception();
            }
            catch
            {
                args.IsValid = false;
                return;
            }
        }
        protected void cvQuantityValidator_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            try
            {
                int quantity = int.Parse(textBoxProductQuantity.Text.Trim());
                if (quantity < 0)
                    throw new Exception();
            }
            catch
            {
                args.IsValid = false;
                return;
            }
        }
        protected void lnkBtnPreviewReport_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            InvoiceData.GetInvoiceData().CustomerInfo = new CustomerInfo(textBoxCustomerName.Text, textBoxCustomerAddress.Text,
                textBoxAddress2.Text, textBoxCustomerPhone.Text, textBoxCustomerEmail.Text);

            Response.Redirect("InvoiceTemplate.aspx");
        }
        protected void btnReserItems_Click(object sender, EventArgs e)
        {
            InvoiceData.GetInvoiceData().Reset();
            ShowItemsCount();
            LoadInvoiceItems();
        }
    }
}
