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
    public partial class DemoLinksBox : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public void LoadDemo(string demoName)
        {
            switch (demoName)
            {
                case "GettingStarted":
                    lnkGettingStarted.CssClass = "demolinks selected_demolinks";
                    break;
                case "HtmlToPdfFeatures":
                    lnkFeaturesDemo.CssClass = "demolinks selected_demolinks";
                    break;
                case "PdfInvoices":
                    lnkPdfInvoices.CssClass = "demolinks selected_demolinks";
                    break;
                case "ConvertMultipleUrls":
                    lnkConvertMultipleUrls.CssClass = "demolinks selected_demolinks";
                    break;
                case "HtmlInHeaderAndFooter":
                    lnkHtmlInHeaderAndFooter.CssClass = "demolinks selected_demolinks";
                    break;
                case "HtmlElementsLocation":
                    lnkHtmlElementsLocation.CssClass = "demolinks selected_demolinks";
                    break;
                case "RepeatTableHead":
                    lnkRepeatTableHead.CssClass = "demolinks selected_demolinks";
                    break;
                case "TableOfContents":
                    lnkTableOfContents.CssClass = "demolinks selected_demolinks";
                    break;
                case "PdfSecurity":
                    lnkPdfSecurity.CssClass = "demolinks selected_demolinks";
                    break;
                case "AppendPdf":
                    lnkAppendPdf.CssClass = "demolinks selected_demolinks";
                    break;
                case "HtmlToPdfElement":
                    lnkHtmlToPdfElement.CssClass = "demolinks selected_demolinks";
                    break;
                case "TextAndFonts":
                    lnkTextAndFonts.CssClass = "demolinks selected_demolinks";
                    break;
                case "ImageElement":
                    lnkImageElement.CssClass = "demolinks selected_demolinks";
                    break;
                case "PdfShapes":
                    lnkPdfShapes.CssClass = "demolinks selected_demolinks";
                    break;                
                case "PdfStamps":
                    lnkPdfStamps.CssClass = "demolinks selected_demolinks";
                    break;
                case "SvgToPdf":
                    lnkSvgToPdf.CssClass = "demolinks selected_demolinks";
                    break;
                default:
                    break;
            }
        }

        protected void lnkGettingStarted_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }

        protected void lnkConvertMultipleUrls_Click(object sender, EventArgs e)
        {
            Response.Redirect("ConvertMultipleURLs.aspx");
        }

        protected void lnkHtmlElementsLocation_Click(object sender, EventArgs e)
        {
            Response.Redirect("HtmlElementsLocation.aspx");
        }

        protected void lnkRepeatTableHead_Click(object sender, EventArgs e)
        {
            Response.Redirect("RepeatTableHead.aspx");
        }

        protected void lnkTableOfContents_Click(object sender, EventArgs e)
        {
            Response.Redirect("TableOfContentsAndBookmarks.aspx");
        }

        protected void lnkPdfInvoices_Click(object sender, EventArgs e)
        {
            Response.Redirect("PdfInvoicesDemo.aspx");
        }

        protected void lnkPdfSecurity_Click(object sender, EventArgs e)
        {
            Response.Redirect("PdfSecurity.aspx");
        }

        protected void lnkAppendPdf_Click(object sender, EventArgs e)
        {
            Response.Redirect("AppendExternalPDFs.aspx");
        }

        protected void lnkHtmlToPdfElement_Click(object sender, EventArgs e)
        {
            Response.Redirect("HtmlToPdfElementDemo.aspx");
        }

        protected void lnkFeaturesDemo_Click(object sender, EventArgs e)
        {
            Response.Redirect("HtmlToPdfFeaturesDemo.aspx");
        }

        protected void lnkTextAndFonts_Click(object sender, EventArgs e)
        {
            Response.Redirect("TextAndFonts.aspx");
        }

        protected void lnkImageElement_Click(object sender, EventArgs e)
        {
            Response.Redirect("ImageElementDemo.aspx");
        }

        protected void lnkPdfShapes_Click(object sender, EventArgs e)
        {
            Response.Redirect("PdfShapes.aspx");
        }
        
        protected void lnkPdfStamps_Click(object sender, EventArgs e)
        {
            Response.Redirect("PdfStamps.aspx");
        }

        protected void lnkSvgToPdf_Click(object sender, EventArgs e)
        {
            Response.Redirect("SvgToPdfDemo.aspx");
        }

        protected void lnkHtmlInHeaderAndFooter_Click(object sender, EventArgs e)
        {
            Response.Redirect("HtmlInHeaderAndFooter.aspx");
        }
    }
}