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
    public partial class HtmlToPdfFeaturesDemo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("HtmlToPdfFeatures");

            lblConvertMessage.Visible = false;

            if (!IsPostBack)
            {
                LoadImageFormats();
                LoadPDFFormats();
                LoadPageOrientations();
                LoadColors();
                LoadCompressionLevels();
                LoadPdfSubsets();
            }
        }

        /// <summary>
        /// Create a PdfConverter object
        /// </summary>
        /// <returns></returns>
        private PdfConverter GetPdfConverter()
        {
            PdfConverter pdfConverter = new PdfConverter();

            // set the HTML viewer width and height in pixels
            // the default value is 1024 pixels for width and 0 for height 
            pdfConverter.HtmlViewerWidth = int.Parse(textBoxHtmlViewerWidth.Text.Trim());
            pdfConverter.HtmlViewerHeight = int.Parse(textBoxHtmlViewerHeight.Text.Trim());

            //set the PDF page size - default value is A4
            pdfConverter.PdfDocumentOptions.PdfPageSize = GetSelectedPageSize();
            // set the PDF compression level - default value is Normal
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = (PdfCompressionLevel)Enum.Parse(typeof(PdfCompressionLevel), ddlCompressionLevel.SelectedValue);
            // set the PDF page orientation (portrait or landscape) - default value is portrait
            pdfConverter.PdfDocumentOptions.PdfPageOrientation = (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation), ddlPageOrientation.SelectedValue.ToString());
            //set the PDF standard used to generate the PDF document - default value is Full
            pdfConverter.PdfDocumentOptions.PdfStandardSubset = GetPdfStandard(ddlPdfSubset.SelectedItem.ToString());
            // show or hide header and footer - default value is false
            pdfConverter.PdfDocumentOptions.ShowHeader = cbShowHeader.Checked;
            pdfConverter.PdfDocumentOptions.ShowFooter = cbShowFooter.Checked;

            //set the PDF document margins - default margins are 0
            pdfConverter.PdfDocumentOptions.LeftMargin = int.Parse(textBoxLeftMargin.Text.Trim());
            pdfConverter.PdfDocumentOptions.RightMargin = int.Parse(textBoxRightMargin.Text.Trim());
            pdfConverter.PdfDocumentOptions.TopMargin = int.Parse(textBoxTopMargin.Text.Trim());
            pdfConverter.PdfDocumentOptions.BottomMargin = int.Parse(textBoxBottomMargin.Text.Trim());

            // set if the HTTP links are enabled in the generated PDF - default value is true
            pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinksEnabled.Checked;

            // set if the HTML content is resized if necessary to fit the PDF page width - default is true
            pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked;

            // set if the PDF page should be automatically resized to the size of the HTML content when FitWidth is false
            pdfConverter.PdfDocumentOptions.AutoSizePdfPage = true;

            // embed the true type fonts in the generated PDF document - default value is false
            pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked;

            // compress the images in PDF with JPEG to reduce the PDF document size - default is true
            pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked;

            // set if the JavaScript is enabled during conversion - default value is true
            pdfConverter.JavaScriptEnabled = cbScriptsEnabled.Checked;

            // set if the converter should try to avoid breaking the images between PDF pages - default value is false
            pdfConverter.PdfDocumentOptions.AvoidImageBreak = cbAvoidImageBreak.Checked;

            // set the automatic bookmarks options - by default no bookmarks are automatically generated
            pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = cbBookmarks.Checked ? new string[] { "h1", "h2" } : null;

            // set HTTP authentication username and password
            // by default these properties are not set
            if (textBoxAuthUsername.Text.Trim().Length > 0)
                pdfConverter.AuthenticationOptions.Username = textBoxAuthUsername.Text.Trim();
            if (textBoxAuthPassword.Text.Trim().Length > 0)
                pdfConverter.AuthenticationOptions.Password = textBoxAuthPassword.Text.Trim();

            // set conversion delay which can be used to allow more time for JavaScript and redirects to execute before conversion
            // the default value is 0
            pdfConverter.ConversionDelay = int.Parse(textBoxConversionDelay.Text.Trim());

            // set the navigation timout in seconds - the default value is 45 seconds
            pdfConverter.NavigationTimeout = int.Parse(textBoxNavigationTimeout.Text.Trim());

            // set header options
            if (pdfConverter.PdfDocumentOptions.ShowHeader)
            {
                pdfConverter.PdfHeaderOptions.HeaderHeight = float.Parse(textBoxHeaderHeight.Text.Trim());

                AddHeaderElements(pdfConverter);
            }

            // set footer options
            if (pdfConverter.PdfDocumentOptions.ShowFooter)
            {
                pdfConverter.PdfFooterOptions.FooterHeight = float.Parse(textBoxFooterHeight.Text.Trim());

                AddFooterElements(pdfConverter);
            }

            return pdfConverter;
        }

        void pdfConverter_PrepareRenderPdfPageEvent(PrepareRenderPdfPageParams eventParams)
        {
            // set the header and footer visibility on first, odd and even pages
            if (cbShowFooter.Checked)
            {
                if (eventParams.PageNumber == 1 && !cbShowFooterOnFirstPage.Checked)
                    eventParams.Page.ShowFooter = false;
                else if ((eventParams.PageNumber % 2) == 0 && !cbShowFooterOnEvenPages.Checked)
                    eventParams.Page.ShowFooter = false;
                else if ((eventParams.PageNumber % 2) == 1 && !cbShowFooterOnOddPages.Checked)
                    eventParams.Page.ShowFooter = false;
            }

            if (cbShowHeader.Checked)
            {
                if (eventParams.PageNumber == 1 && !cbShowHeaderOnFirstPage.Checked)
                    eventParams.Page.ShowHeader = false;
                else if ((eventParams.PageNumber % 2) == 0 && !cbShowHeaderOnEvenPages.Checked)
                    eventParams.Page.ShowHeader = false;
                else if ((eventParams.PageNumber % 2) == 1 && !cbShowHeaderOnOddPages.Checked)
                    eventParams.Page.ShowHeader = false;
            }
        }

        private PdfPageSize GetSelectedPageSize()
        {
            switch (ddlPDFPageFormat.SelectedItem.ToString())
            {
                case "A0":
                    return PdfPageSize.A0;
                case "A1":
                    return PdfPageSize.A1;
                case "A10":
                    return PdfPageSize.A10;
                case "A2":
                    return PdfPageSize.A2;
                case "A3":
                    return PdfPageSize.A3;
                case "A4":
                    return PdfPageSize.A4;
                case "A5":
                    return PdfPageSize.A5;
                case "A6":
                    return PdfPageSize.A6;
                case "A7":
                    return PdfPageSize.A7;
                case "A8":
                    return PdfPageSize.A8;
                case "A9":
                    return PdfPageSize.A9;
                case "ArchA":
                    return PdfPageSize.ArchA;
                case "ArchB":
                    return PdfPageSize.ArchB;
                case "ArchC":
                    return PdfPageSize.ArchC;
                case "ArchD":
                    return PdfPageSize.ArchD;
                case "ArchE":
                    return PdfPageSize.ArchE;
                case "B0":
                    return PdfPageSize.B0;
                case "B1":
                    return PdfPageSize.B1;
                case "B2":
                    return PdfPageSize.B2;
                case "B3":
                    return PdfPageSize.B3;
                case "B4":
                    return PdfPageSize.B4;
                case "B5":
                    return PdfPageSize.B5;
                case "Flsa":
                    return PdfPageSize.Flsa;
                case "HalfLetter":
                    return PdfPageSize.HalfLetter;
                case "Ledger":
                    return PdfPageSize.Ledger;
                case "Legal":
                    return PdfPageSize.Legal;
                case "Letter":
                    return PdfPageSize.Letter;
                case "Letter11x17":
                    return PdfPageSize.Letter11x17;
                case "Note":
                    return PdfPageSize.Note;
                default:
                    return PdfPageSize.A4;
            }
        }

        private void AddHeaderElements(PdfConverter pdfConverter)
        {
            // set the header HTML area
            HtmlToPdfElement headerHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                    "<b>HTML in Header</b>", null, 1024, 0);
            headerHtml.FitHeight = true;
            headerHtml.EmbedFonts = cbEmbedFonts.Checked;
            pdfConverter.PdfHeaderOptions.AddElement(headerHtml);

            if (cbDrawHeaderLine.Checked)
            {
                // set the header line
                float pdfPageWidth = 0;
                if (pdfConverter.PdfDocumentOptions.PdfPageOrientation == PdfPageOrientation.Portrait)
                    pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageSize.Width;
                else
                    pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageSize.Height;

                LineElement headerLine = new LineElement(0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                            pdfPageWidth - pdfConverter.PdfDocumentOptions.LeftMargin - pdfConverter.PdfDocumentOptions.RightMargin,
                            pdfConverter.PdfHeaderOptions.HeaderHeight);
                headerLine.LineStyle.LineWidth = 0.5f;
                headerLine.ForeColor = Color.FromKnownColor((KnownColor)Enum.Parse(typeof(KnownColor), ddlHeaderLineColor.SelectedItem.ToString()));
                pdfConverter.PdfHeaderOptions.AddElement(headerLine);
            }
        }

        private void AddFooterElements(PdfConverter pdfConverter)
        {
            //write the page number
            TextElement footerText = new TextElement(0, pdfConverter.PdfFooterOptions.FooterHeight - 15, "This is page &p; of &P;  ",
                new System.Drawing.Font(new System.Drawing.FontFamily("Times New Roman"), 10, System.Drawing.GraphicsUnit.Point));
            footerText.EmbedSysFont = true;
            footerText.TextAlign = HorizontalTextAlign.Right;
            pdfConverter.PdfFooterOptions.AddElement(footerText);

            // set the footer HTML area
            HtmlToPdfElement footerHtml = new HtmlToPdfElement(0, 0, 0, pdfConverter.PdfFooterOptions.FooterHeight,
                        "<i>HTML in Footer</i>", null, 1024, 0);
            footerHtml.FitHeight = true;
            footerHtml.EmbedFonts = cbEmbedFonts.Checked;
            pdfConverter.PdfFooterOptions.AddElement(footerHtml);

            if (cbDrawFooterLine.Checked)
            {
                // set the footer line
                float pdfPageWidth = 0;
                if (pdfConverter.PdfDocumentOptions.PdfPageOrientation == PdfPageOrientation.Portrait)
                    pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageSize.Width;
                else
                    pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageSize.Height;

                LineElement footerLine = new LineElement(0, 0,
                            pdfPageWidth - pdfConverter.PdfDocumentOptions.LeftMargin - pdfConverter.PdfDocumentOptions.RightMargin, 0);
                footerLine.LineStyle.LineWidth = 0.5f;
                footerLine.ForeColor = Color.FromKnownColor((KnownColor)Enum.Parse(typeof(KnownColor), ddlFooterLineColor.SelectedItem.ToString()));
                pdfConverter.PdfFooterOptions.AddElement(footerLine);
            }
        }

        private ImgConverter GetImgConverter()
        {
            ImgConverter imgConverter = new ImgConverter();

            // set the HTML viewer width and height in pixels
            // the default value is 1024 pixels for width and 0 for height 
            imgConverter.HtmlViewerWidth = int.Parse(textBoxHtmlViewerWidth.Text.Trim());
            imgConverter.HtmlViewerHeight = int.Parse(textBoxHtmlViewerHeight.Text.Trim());

            // set if the JavaScript is executed during conversion - default value is true
            imgConverter.JavaScriptEnabled = cbScriptsEnabled.Checked;

            return imgConverter;
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            lblConvertMessage.Visible = false;

            if (!Page.IsValid)
                return;

            string urlToConvert = textBoxWebPageURL.Text.Trim();

            if (radioConvertToPdf.Checked)
            {
                PdfConverter pdfConverter = GetPdfConverter();

                // set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

                // handle the PrepareRenderPdfPageEvent to set the header and footer visibility in each page
                pdfConverter.PrepareRenderPdfPageEvent += new PrepareRenderPdfPageDelegate(pdfConverter_PrepareRenderPdfPageEvent);

                // Performs the conversion and get the pdf document bytes that can 
                // be saved to a file or sent as a browser response
                byte[] pdfBytes = pdfConverter.GetPdfBytesFromUrl(urlToConvert);

                // remove event handler
                pdfConverter.PrepareRenderPdfPageEvent -= new PrepareRenderPdfPageDelegate(pdfConverter_PrepareRenderPdfPageEvent);

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
            else
            {
                ImgConverter imgConverter = GetImgConverter();

                // set the license key
                imgConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

                byte[] imageBytes = imgConverter.GetImageBytesFromUrl(urlToConvert, GetImageFormat(ddlImageFormat.SelectedValue));

                string imageName = "HtmlToImageFeatures." + ddlImageFormat.SelectedValue;

                System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
                response.Clear();
                response.AddHeader("Content-Type", "binary/octet-stream");
                response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}; size={1}", imageName, imageBytes.Length.ToString()));
                response.BinaryWrite(imageBytes);
                // Note: it is important to end the response, otherwise the ASP.NET
                // web page will render its content to image stream
                response.End();
            }
        }

        protected void lnkBtnSettings_Click(object sender, EventArgs e)
        {
            if (!Page.IsValid)
                return;

            if (pnlRenderMoreOptions.Visible)
            {
                pnlRenderMoreOptions.Visible = false;
                lnkBtnSettings.Text = "More Converter Features >>";
            }
            else
            {
                pnlRenderMoreOptions.Visible = true;
                lnkBtnSettings.Text = "<< Hide Features";
            }
        }

        private void LoadImageFormats()
        {
            string[] imageFormats = new string[] { "Png", "Jpeg", "Bmp", "Gif", "Tiff" };
            ddlImageFormat.DataSource = imageFormats;
            ddlImageFormat.DataBind();
            ddlImageFormat.SelectedValue = "Png";
        }

        private System.Drawing.Imaging.ImageFormat GetImageFormat(string imageFormatName)
        {
            switch (imageFormatName)
            {
                case "Png":
                    return System.Drawing.Imaging.ImageFormat.Png;
                case "Jpeg":
                    return System.Drawing.Imaging.ImageFormat.Jpeg;
                case "Bmp":
                    return System.Drawing.Imaging.ImageFormat.Bmp;
                case "Gif":
                    return System.Drawing.Imaging.ImageFormat.Gif;
                case "Tiff":
                    return System.Drawing.Imaging.ImageFormat.Tiff;
                default:
                    return System.Drawing.Imaging.ImageFormat.Png;

            }
        }

        private void LoadCompressionLevels()
        {
            string[] pdfCompressionLevels = Enum.GetNames(typeof(PdfCompressionLevel));
            ddlCompressionLevel.DataSource = pdfCompressionLevels;
            ddlCompressionLevel.DataBind();
            ddlCompressionLevel.SelectedValue = PdfCompressionLevel.Normal.ToString();
        }

        private void LoadPageOrientations()
        {
            string[] pdfPageOrientations = Enum.GetNames(typeof(PdfPageOrientation));
            ddlPageOrientation.DataSource = pdfPageOrientations;
            ddlPageOrientation.DataBind();
            ddlPageOrientation.SelectedValue = PdfPageOrientation.Portrait.ToString();
        }

        private void LoadPDFFormats()
        {
            ddlPDFPageFormat.SelectedValue = "A4";
        }

        private void LoadColors()
        {
            string[] colors = Enum.GetNames(typeof(KnownColor));

            ddlHeaderLineColor.DataSource = colors;
            ddlHeaderLineColor.DataBind();
            ddlHeaderLineColor.SelectedValue = KnownColor.Black.ToString();

            ddlFooterLineColor.DataSource = colors;
            ddlFooterLineColor.DataBind();
            ddlFooterLineColor.SelectedValue = KnownColor.Black.ToString();
        }

        private string[] pdfStandards = { "PDF", "PDF/A", "PDF/X" };
        private PdfStandardSubset GetPdfStandard(string standardName)
        {
            switch (standardName)
            {
                case "PDF":
                    return PdfStandardSubset.Full;
                case "PDF/A":
                    return PdfStandardSubset.Pdf_A_1b;
                case "PDF/X":
                    return PdfStandardSubset.Pdf_X_1a;
                default:
                    return PdfStandardSubset.Full;

            }
        }

        private void LoadPdfSubsets()
        {
            ddlPdfSubset.DataSource = pdfStandards;
            ddlPdfSubset.DataBind();
            ddlPdfSubset.SelectedValue = "PDF";
        }

        protected void radioConvertToPdf_CheckedChanged(object sender, EventArgs e)
        {
            pnlImageRenderOptions.Visible = !((RadioButton)sender).Checked;
            pnlPDFRenderOptions.Visible = ((RadioButton)sender).Checked;
            cbEmbedFonts.Visible = cbJpegCompression.Visible = cbFitWidth.Visible = cbLiveLinksEnabled.Visible = cbBookmarks.Visible = !radioConvertToImage.Checked;
        }

        protected void radioConvertToImage_CheckedChanged(object sender, EventArgs e)
        {
            pnlImageRenderOptions.Visible = ((RadioButton)sender).Checked;
            pnlPDFRenderOptions.Visible = !((RadioButton)sender).Checked;
            cbEmbedFonts.Visible = cbJpegCompression.Visible = cbFitWidth.Visible = cbLiveLinksEnabled.Visible = cbBookmarks.Visible = !radioConvertToImage.Checked;
        }

        protected void cbShowheader_CheckedChanged(object sender, EventArgs e)
        {
            pnlPDFHeaderOptions.Visible = ((CheckBox)sender).Checked;
        }

        protected void cbShowFooter_CheckedChanged(object sender, EventArgs e)
        {
            pnlPDFFooterOptions.Visible = ((CheckBox)sender).Checked;
        }

        protected void cvLeftMargin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            int width = 0;
            try
            {
                width = int.Parse(textBoxLeftMargin.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = width >= 0;
        }

        protected void cvRightMargin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            int width = 0;
            try
            {
                width = int.Parse(textBoxRightMargin.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = width >= 0;
        }

        protected void cvTopMargin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            int width = 0;
            try
            {
                width = int.Parse(textBoxTopMargin.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = width >= 0;
        }

        protected void cvBottomMargin_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            int width = 0;
            try
            {
                width = int.Parse(textBoxBottomMargin.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = width >= 0;
        }

        protected void cvHtmlViewerWidth_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            int width = 0;
            try
            {
                width = int.Parse(textBoxHtmlViewerWidth.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = width >= 0;
        }

        protected void cvHtmlViewerHeight_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            int width = 0;
            try
            {
                width = int.Parse(textBoxHtmlViewerHeight.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = width >= 0;
        }

        protected void cvHeaderHeight_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            float height = 0;
            try
            {
                height = int.Parse(textBoxHeaderHeight.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = height > 0;
        }

        protected void cvFooterHeight_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            float height = 0;
            try
            {
                height = int.Parse(textBoxFooterHeight.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = height > 0;
        }

        protected void cvConversionDelay_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            int val = 0;
            try
            {
                val = int.Parse(textBoxConversionDelay.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = val >= 0;
        }

        protected void cvNavigationTimeout_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = true;
            int val = 0;
            try
            {
                val = int.Parse(textBoxNavigationTimeout.Text.Trim());
            }
            catch
            {
                args.IsValid = false;
                return;
            }
            args.IsValid = val >= 0;
        }
    }
}
