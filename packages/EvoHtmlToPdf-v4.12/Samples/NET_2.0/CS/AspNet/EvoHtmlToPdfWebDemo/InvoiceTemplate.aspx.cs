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

namespace EvoHtmlToPdfWebDemo
{
    public partial class InvoiceTemplate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadInvoiceData();
            }
        }

        private void LoadInvoiceData()
        {
            litInvoiceDate.Text = DateTime.Now.ToString("MMMM dd, yyyy");
            litInvoiceNum.Text = "30643";
            LoadCustomerInfo();
            LoadInvoiceItems();
            lblTotalPrice.Text = InvoiceData.GetInvoiceData().TotalInvoice.ToString("N2");
        }

        private void LoadCustomerInfo()
        {
            CustomerInfo customerInfo = InvoiceData.GetInvoiceData().CustomerInfo;

            if (customerInfo == null)
                return;

            litCustomerName.Text = customerInfo.Name;
            litCustomerAddress1.Text = customerInfo.Address1;
            litCustomerAddress2.Text = customerInfo.Address2;
            litCustomerPhone.Text = customerInfo.Phone;
            litCustomerEmail.Text = customerInfo.Email;
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
    }
}
