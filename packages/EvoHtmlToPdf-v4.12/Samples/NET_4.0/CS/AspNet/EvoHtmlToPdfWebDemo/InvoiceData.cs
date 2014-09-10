using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections;

namespace EvoHtmlToPdfWebDemo
{
    public class InvoiceData
    {
        CustomerInfo customerInfo;
        ArrayList invoiceItems;
        double totalInvoice = 0;

        public InvoiceData()
        {
            invoiceItems = new ArrayList();
        }

        public static InvoiceData GetInvoiceData()
        {
            if (HttpContext.Current.Session["InvoiceData"] == null)
            {
                HttpContext.Current.Session["InvoiceData"] = new InvoiceData();
            }
            return (InvoiceData)HttpContext.Current.Session["InvoiceData"];
        }

        public void Reset()
        {
            invoiceItems.Clear();
            totalInvoice = 0;
            customerInfo = null;
        }

        public double TotalInvoice
        {
            get
            {
                return totalInvoice;
            }
        }

        public void AddItem(InvoiceItem invoiceItem)
        {
            invoiceItems.Add(invoiceItem);
            totalInvoice += invoiceItem.ItemPrice;
        }

        public ArrayList InvoiceItems
        {
            get
            {
                return invoiceItems;
            }
            set
            {
                invoiceItems = value;
            }
        }

        public CustomerInfo CustomerInfo
        {
            get
            {
                return customerInfo;
            }
            set
            {
                customerInfo = value;
            }
        }
    }

    public class InvoiceItem
    {
        string productCode;
        string productDescription = String.Empty;
        string productName;
        double productPrice;
        int quantity;

        public InvoiceItem(string productCode, string productDescription, string productName,
                            double productPrice, int quantity)
        {
            this.productCode = productCode;
            this.productDescription = productDescription;
            this.productName = productName;
            this.productPrice = productPrice;
            this.quantity = quantity;
        }

        public string ProductCode
        {
            get
            {
                return productCode;
            }
            set
            {
                productCode = value;
            }
        }

        public string ProductDescription
        {
            get
            {
                return productDescription;
            }
            set
            {
                productDescription = value;
            }
        }
        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                productName = value;
            }
        }
        public double ProductPrice
        {
            get
            {
                return productPrice;
            }
            set
            {
                productPrice = value;
            }
        }

        public double ItemPrice
        {
            get
            {
                return ProductPrice * Quantity;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }
            set
            {
                quantity = value;
            }
        }
    }

    public class CustomerInfo
    {
        string name;
        string address1;
        string address2;
        string phone;
        string email;

        public CustomerInfo(string name, string address1, string address2,
                    string phone, string email)
        {
            this.name = name;
            this.address1 = address1;
            this.address2 = Address2;
            this.phone = phone;
            this.email = email;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Address1
        {
            get
            {
                return address1;
            }
            set
            {
                address1 = value;
            }
        }
        public string Address2
        {
            get
            {
                return address2;
            }
            set
            {
                address2 = value;
            }
        }
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }
    }
}
