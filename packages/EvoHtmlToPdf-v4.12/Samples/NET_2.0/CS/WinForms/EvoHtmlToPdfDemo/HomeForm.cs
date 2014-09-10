using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace EvoHtmlToPdfDemo
{
    public partial class HomeForm : Form
    {
        private string currentDemoName = "MainFeatures";
        private LinkLabel currentLink = null;

        public HomeForm()
        {
            InitializeComponent();

            currentLink = lnkMainFeaturesDemo;
        }

        private void LoadDemoDetails(string demoName)
        {
            LinkLabel previousLink = currentLink;           
            switch (demoName)
            {
                case "MainFeatures":
                    lblSampleDescription.Text = "This sample shows the main features and options of the EVO HTML to PDF Converter for .NET.\r\n\r\n" + 
                                                "Options like PDF page size, PDF page orientation, margins, headers and footers, live URLs,\r\n" +
                                                "font embedding, JavaScript execution, automatic bookmarks generation, JPEG compression\r\n" +
                                                "can be controlled using this demo.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "Main Features Demo";
                    currentDemoName = demoName;
                    currentLink = lnkMainFeaturesDemo;
                    break;
                case "HtmlPdfLocation":
                    lblSampleDescription.Text = "This sample shows how to determine the location in PDF of the HTML elements from\r\n"+
                                                "the converted page.\r\n\r\n" + 
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "HTML Elements Location in PDF";
                    currentDemoName = demoName;
                    currentLink = lnkHtmlPdfLocation;
                    break;
                case "ConvertMultipleUrl":
                    lblSampleDescription.Text = "This sample shows how to combine multiple web pages into the same PDF document.\r\n" + 
                                                "The PDF content resulted after conversion of one web page can be added right after\r\n" +
                                                "the content from the previous page or it can start on a new PDF page.\r\n\r\n" + 
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "Combine Multiple Web Pages Into the Same PDF";
                    currentDemoName = demoName;
                    currentLink = lnkConvertMultipleURL;
                    break;
                case "HtmlInHeaderFooter":
                    lblSampleDescription.Text = "This sample shows how to add HTML in the header and footer of the generated PDF document\r\n" +
                                                "and how to add page numbers in the footer. It also offers the possibility to alternate the\r\n" +
                                                "header and footer content for the consecutive PDF pages.\r\n\r\n" + 
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "HTML in Header and Footer";
                    currentDemoName = demoName;
                    currentLink = lnkHtmlInHeaderFooter;
                    break;
                case "RepeatTableHead":
                    lblSampleDescription.Text = "This sample shows how to repeat the head of a HTML table on each PDF page where the \r\n" + 
                                                "table is rendered.\r\n\r\n" +
                                                "The thead element of the HTML table must have the display:table-header-group style \r\n" + 
                                                "in order to get this effect\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "Repeat Tables Head on PDF Pages";
                    currentDemoName = demoName;
                    currentLink = lnkRepeatTableHead;
                    break;
                case "TableOfContents":
                    lblSampleDescription.Text = "This sample shows how to create a table of contents in the PDF document generated from\r\n" + 
                                                "a HTML book and how to add bookmarks in PDF to the sections of the book.\r\n\r\n" +
                                                "The creation of the table of contents is based on the capabilities of the converter to\r\n" + 
                                                "convert the internal links from HTML to internal links in PDF and to obtain the position\r\n" + 
                                                "in PDF of a HTML element based on the ID of the element.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo."; 
                    groupBoxSampleDetails.Text = "Table of Contents and Bookmarks";
                    currentDemoName = demoName;
                    currentLink = lnkTableOfContents;
                    break;
                case "AppendExternalPdf":
                    lblSampleDescription.Text = "This sample shows how to use the the converter to convert many web pages to PDF and merge\r\n" +
                                                "them into a single final PDF document.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo."; 
                    groupBoxSampleDetails.Text = "Append and Prepend External PDFs";
                    currentDemoName = demoName;
                    currentLink = lnkAppendPrependPdf;
                    break;
                case "HtmlToPdfElement":
                    lblSampleDescription.Text = "This sample shows how to add HtmlToPdfElement and HtmlToImageElement objects to an\r\n" + 
                                                "empty Document object.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "HTML to PDF and HTML to Image Elements Demo";
                    currentDemoName = demoName;
                    currentLink = lnkHtmlToPdfElement;
                    break;
                case "PdfShapes":
                    lblSampleDescription.Text = "This sample shows how to add gaphic elements like rectangles, ellipses and bezier\r\n" + 
                                                "curves to a PDF document. It also demonstrate how to fill the shapes with colors\r\n" + 
                                                "and gradient colors, set the line dash style, width and joining style.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "PDF Shapes Demo";
                    currentDemoName = demoName;
                    currentLink = lnkPdfShapes;
                    break;
                case "PdfSecurity":
                    lblSampleDescription.Text = "This sample shows how to set the security options for the generated PDF document.\r\n" +
                                                "The generated PDF document is password protected with an User and an Owner password.\r\n" +
                                                "The User password is 'user' and the Owner password is 'owner'. When the PDF document\r\n" +
                                                "is opened by owner its security properties can be changed. If the document is opened \r\n" +
                                                "by an user the security properties of the document cannot be changed.\r\n\r\n" +
                                                "The demo also restricts the right to print or copy the generated PDF document content\r\n" +
                                                "when the document is opened by an user. Other restrictions like the right to edit the\r\n" +
                                                "document content can also be applied.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "PDF Security Demo";
                    currentDemoName = demoName;
                    currentLink = lnkPdfSecurity;
                    break;
                case "DigitalSignature":
                    lblSampleDescription.Text = "This sample shows how to add a digital signature to a PDF document. The digital signature\r\n" +
                                                "requires a digital certificate in PKCS #12 format cotaining both the public and private\r\n" + 
                                                "encryption keys.\r\n\r\n" +
                                                "Such a certificate is usually stored in a .pfx or .p12 file.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "Digital Signatures Demo";
                    currentDemoName = demoName;
                    currentLink = lnkDigitalSignature;
                    break;
                case "TextAndFonts":
                    lblSampleDescription.Text = "This sample will generate a PDF document to demonstrate how to add fonts to the PDF\r\n" +
                                                "document and write text using the TextElement class. Unicode texts require the font\r\n" +
                                                "to be embedded in the generated PDF document.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "Text and Fonts Demo";
                    currentDemoName = demoName;
                    currentLink = lnkTextFonts;
                    break;
                case "PdfStamps":
                    lblSampleDescription.Text = "This sample shows how to add a stamp to an existing PDF document. The application will\r\n" +
                                                "add an image stamp in the top left corner of the first page and a template stamp to be\r\n" +
                                                "repeated on each page of the generated PDF document.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "PDF Stamps Demo";
                    currentDemoName = demoName;
                    currentLink = lnkStampsDemo;
                    break;
                case "ConvertHtmlString":
                    lblSampleDescription.Text = "This sample shows how to convert a HTML string to PDF. The base URL parameter is used to\r\n" +
                                                "resolve the relative URLs found in HTML string to full URLs. When the HTML string contains\r\n" +
                                                "only full URLs this parameter is not necessary and can be empty.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "Convert HTML String to PDF Demo";
                    currentDemoName = demoName;
                    currentLink = lnkConvertHtmlString;
                    break;
                case "ImageElement":
                    lblSampleDescription.Text = "This sample shows how to add image elements to a PDF document. The images can be resized\r\n" +
                                                "and displayed in any position in a PDF page.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "Image Elements Demo";
                    currentDemoName = demoName;
                    currentLink = lnkImageElement;
                    break;
                case "SvgToPdf":
                    lblSampleDescription.Text = "This sample shows how to convert a HTML page containing SVG to PDF. The SVG that will be\r\n" + 
                                                "converted contains a shape and a text written on that shape.\r\n\r\n" +
                                                "Click the 'Run This Sample' button to view the demo.";
                    groupBoxSampleDetails.Text = "SVG to PDF Conversion Demo";
                    currentDemoName = demoName;
                    currentLink = lnkSvgToPdf;
                    break;
                default:
                    break;
            }
            previousLink.BackColor = Color.WhiteSmoke;
            currentLink.BackColor = Color.LightBlue;
        }


        private void btnRunSample_Click(object sender, EventArgs e)
        {
            switch (currentDemoName)
            {
                case "MainFeatures":
                    using (MainFeaturesForm mainFeaturesForm = new MainFeaturesForm())
                    {
                        mainFeaturesForm.ShowDialog();
                    }
                    break;
                case "HtmlPdfLocation":
                    using (HtmlElementsLocationInPdf htmlLocationInPdfForm = new HtmlElementsLocationInPdf())
                    {
                        htmlLocationInPdfForm.ShowDialog();
                    }
                    break;
                case "ConvertMultipleUrl":
                    using (ConvertMultipleURLsToPdf convertMultipleURLsForm = new ConvertMultipleURLsToPdf())
                    {
                        convertMultipleURLsForm.ShowDialog();
                    }
                    break;
                case "HtmlInHeaderFooter":
                    using (HtmlInHeaderAndFooter htmlInHeaderAndFooterForm = new HtmlInHeaderAndFooter())
                    {
                        htmlInHeaderAndFooterForm.ShowDialog();
                    }
                    break;
                case "RepeatTableHead":
                    using (RepeatTableHeadOnEachPage repeatTableHeadForm = new RepeatTableHeadOnEachPage())
                    {
                        repeatTableHeadForm.ShowDialog();
                    }
                    break;
                case "TableOfContents":
                    using (TableOfContentsAndBookmarks tableOfContentsForm = new TableOfContentsAndBookmarks())
                    {
                        tableOfContentsForm.ShowDialog();
                    }
                    break;
                case "AppendExternalPdf":
                    using (AppendPrependExternalPdf appendPrependExternalPdfForm = new AppendPrependExternalPdf())
                    {
                        appendPrependExternalPdfForm.ShowDialog();
                    }
                    break;
                case "HtmlToPdfElement":
                    using (HtmlToPdfElementDemo htmlToPdfElementDemoForm = new HtmlToPdfElementDemo())
                    {
                        htmlToPdfElementDemoForm.ShowDialog();
                    }
                    break;
                case "PdfShapes":
                    using (ShapesDemo pdfShapesDemoForm = new ShapesDemo())
                    {
                        pdfShapesDemoForm.ShowDialog();
                    }
                    break;
                case "PdfSecurity":
                    using (PdfSecurity pdfSecurityDemoForm = new PdfSecurity())
                    {
                        pdfSecurityDemoForm.ShowDialog();
                    }
                    break;
                case "DigitalSignature":
                    using (DigitalSignature digitalSignatureDemoForm = new DigitalSignature())
                    {
                        digitalSignatureDemoForm.ShowDialog();
                    }
                    break;
                case "TextAndFonts":
                    using (TextAndFonts textAndFontsDemoForm = new TextAndFonts())
                    {
                        textAndFontsDemoForm.ShowDialog();
                    }
                    break;
                case "PdfStamps":
                    using (PdfStamps pdfStampsDemoForm = new PdfStamps())
                    {
                        pdfStampsDemoForm.ShowDialog();
                    }
                    break;
                case "ConvertHtmlString":
                    using (ConvertHtmlString convertHtmlStringDemoForm = new ConvertHtmlString())
                    {
                        convertHtmlStringDemoForm.ShowDialog();
                    }
                    break;
                case "ImageElement":
                    using (ImageElementDemo imageElementDemoForm = new ImageElementDemo())
                    {
                        imageElementDemoForm.ShowDialog();
                    }
                    break;
                case "SvgToPdf":
                    using (SvgToPdf svgToPdfDemoForm = new SvgToPdf())
                    {
                        svgToPdfDemoForm.ShowDialog();
                    }
                    break;
                default:
                    using (MainFeaturesForm mainFeaturesForm = new MainFeaturesForm())
                    {
                        mainFeaturesForm.ShowDialog();
                    }
                    break;
            }       
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadDemoDetails("MainFeatures");
        }

        private void lnkMainFeaturesDemo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("MainFeatures");
        }

        private void lnkHtmlPdfLocation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("HtmlPdfLocation");
        }

        private void lnkConvertMultipleURL_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("ConvertMultipleUrl");
        }

        private void lnkHtmlInHeaderFooter_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("HtmlInHeaderFooter");
        }

        private void lnkRepeatTableHead_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("RepeatTableHead");
        }

        private void lnkTableOfContents_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("TableOfContents");
        }

        private void lnkAppendPrependPdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("AppendExternalPdf");
        }

        private void lnkHtmlToPdfElement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("HtmlToPdfElement");
        }

        private void lnkPdfShapes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("PdfShapes");
        }

        private void lnkPdfSecurity_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("PdfSecurity");
        }

        private void lnkDigitalSignature_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("DigitalSignature");
        }

        private void lnkTextFonts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("TextAndFonts");
        }

        private void lnkStampsDemo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("PdfStamps");
        }

        private void lnkConvertHtmlString_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("ConvertHtmlString");
        }

        private void lnkImageElement_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("ImageElement");
        }

        private void lnkSvgToPdf_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoadDemoDetails("SvgToPdf");
        }
    }
}