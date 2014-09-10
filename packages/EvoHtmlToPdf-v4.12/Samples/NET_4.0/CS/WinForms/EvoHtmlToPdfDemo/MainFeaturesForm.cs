using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using EvoPdf;

namespace EvoHtmlToPdfDemo
{
    public partial class MainFeaturesForm : Form
    {
        public MainFeaturesForm()
        {
            InitializeComponent();
        }

        private void MainFeaturesForm_Load(object sender, EventArgs e)
        {
            LoadImageFormats();
            LoadPdfFormats();
            LoadPageOrientations();
            LoadColors();
            LoadCompressionLevels();
            LoadPdfSubsets();
        }

        private PdfConverter GetPDFConverter()
        {
            int htmlViewerWidthPx = int.Parse(textBoxWebPageWidth.Text.Trim());
            int htmlViewerHeightPx = int.Parse(textBoxWebPageHeight.Text.Trim());

            // create the PDF converter with the specified width and height for HTML viewer
            // the default HTML viewer width is 1024 pixels and default height is 0 to auto determine the height
            PdfConverter pdfConverter = new PdfConverter(htmlViewerWidthPx, htmlViewerHeightPx);

            // set PDF page size to a standard size like A4 or to a custom size
            PdfPageSize pageSize = GetSelectedPageSize();
            pdfConverter.PdfDocumentOptions.PdfPageSize = pageSize;

            // set the PDF page orientation (portrait or landscape)
            // default orientation is portrait
            pdfConverter.PdfDocumentOptions.PdfPageOrientation = (PdfPageOrientation)Enum.Parse(typeof(PdfPageOrientation), ddlPageOrientation.SelectedItem.ToString());

            // set the compression level of the streams in the PDF document
            // the default compression is Normal
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = (PdfCompressionLevel)Enum.Parse(typeof(PdfCompressionLevel), ddlCompression.SelectedItem.ToString());

            // the the PDF standard used to generate the PDF document (PDF, PDF/A or PDF/SiqQ)
            // the default standard is full PDF
            pdfConverter.PdfDocumentOptions.PdfStandardSubset = GetPdfStandard(ddlPdfSubset.SelectedItem.ToString());

            // set if the generated document will have header and footer
            // by default the generated document does not have header or footer
            pdfConverter.PdfDocumentOptions.ShowHeader = cbShowHeader.Checked;
            pdfConverter.PdfDocumentOptions.ShowFooter = cbShowFooter.Checked;

            //set PDF document margins in points (1 point = 1/72 inch)
            pdfConverter.PdfDocumentOptions.LeftMargin = int.Parse(textBoxLeftMargin.Text.Trim());
            pdfConverter.PdfDocumentOptions.RightMargin = int.Parse(textBoxRightMargin.Text.Trim());
            pdfConverter.PdfDocumentOptions.TopMargin = int.Parse(textBoxTopMargin.Text.Trim());
            pdfConverter.PdfDocumentOptions.BottomMargin = int.Parse(textBoxBottomMargin.Text.Trim());

            // set if the fonts are embedded in the PDF document
            // by default the fonts are embedded only if it is necessary
            pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked;

            // set if the images are compressed with JPEG in PDF to reduce the PDF document size
            // by default the JPEG compression is enabled and can be controlled by the JpegCompressionLevel property
            pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked;

            // set if the HTML content is resized if necessary to fit the PDF page width
            // by default this property is true
            pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked;
            // set if the PDF page is automatically resized to show all the HTML content when FitWidth is false
            // by default this property os false
            pdfConverter.PdfDocumentOptions.AutoSizePdfPage = cbAutoSizePdfPage.Checked;

            // set if the HTTP links are enabled in the generated PDF
            // by default this property is true
            pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinks.Checked;

            // set if the converter should try to avoid breaking the images between PDF pages
            // by default this property is false
            pdfConverter.PdfDocumentOptions.AvoidImageBreak = cbAvoidImageBreak.Checked;

            // Enable or disable JavaScript
            // JavaScript is enabled by default
            pdfConverter.JavaScriptEnabled = cbScriptsEnabled.Checked;

            // set a delay if necessary to allow asynchronous content (like the content written by JavaScript) to load 
            // or a web page redirect to finish before starting rendering the content. The default delay is 0.
            pdfConverter.ConversionDelay = int.Parse(textBoxConversionDelay.Text.Trim());

            // set a timeout in case the web page loading takes too long
            // the default navigation timout is 60 seconds
            pdfConverter.NavigationTimeout = int.Parse(textBoxNavigationTimeout.Text.Trim());

            // set the selectors for the HTML elements to be bookmarked
            // by default no HTML element is bookmarked
            pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = cbBookmarks.Checked ? new string[] { "H1", "H2" } : null;

            // set HTTP authentication if necessary
            // for IIS Integrated Windows Authentication for example the username and password must be valid
            // Windows username and password
            if (textBoxUsername.Text.Trim().Length > 0)
            {
                pdfConverter.AuthenticationOptions.Username = textBoxUsername.Text.Trim();
                pdfConverter.AuthenticationOptions.Password = textBoxPassword.Text.Trim();
            }

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
            switch (ddlPageFormat.SelectedItem.ToString())
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
            int htmlViewerWidthPx = int.Parse(textBoxWebPageWidth.Text.Trim());
            int htmlViewerHeightPx = int.Parse(textBoxWebPageHeight.Text.Trim());

            // create the image converter with the specified width and height for HTML viewer
            // the default HTML viewer width is 1024 pixels and default height is 0 to auto determine the height
            ImgConverter imgConverter = new ImgConverter(htmlViewerWidthPx, htmlViewerHeightPx);

            // set HTTP authentication if necessary
            // for IIS Integrated Windows Authentication for example the username and password must be valid
            // Windows username and password
            if (textBoxUsername.Text.Trim().Length > 0)
            {
                imgConverter.AuthenticationOptions.Username = textBoxUsername.Text.Trim();
                imgConverter.AuthenticationOptions.Password = textBoxPassword.Text.Trim();
            }

            // Enable or disable JavaScript. 
            // JavaScript is enabled by default
            imgConverter.JavaScriptEnabled = cbScriptsEnabled.Checked;

            // set a delay if necessary to allow asynchronous content (like the content written by JavaScript) to load 
            // or a web page redirect to finish before starting rendering the content. The default delay is 0.
            imgConverter.ConversionDelay = int.Parse(textBoxConversionDelay.Text.Trim());

            // set a timeout in case the web page loading takes too long
            // the default navigation timout is 60 seconds
            imgConverter.NavigationTimeout = int.Parse(textBoxNavigationTimeout.Text.Trim());

            return imgConverter;
        }

        // convert the web page to PDF or Image using the selected parameters
        private void btnConvert_Click(object sender, EventArgs e)
        {
            if (!PageIsValid())
                return;

            this.Cursor = Cursors.WaitCursor;

            string outFile = null;

            try
            {
                if (radioButtonConvertToPdf.Checked)
                {
                    // get the PDF converter
                    PdfConverter pdfConverter = GetPDFConverter();

                    // set the license key
                    pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

                    // handle the PrepareRenderPdfPageEvent to set the header and footer visibility in each page
                    pdfConverter.PrepareRenderPdfPageEvent += new PrepareRenderPdfPageDelegate(pdfConverter_PrepareRenderPdfPageEvent);

                    outFile = Path.Combine(Application.StartupPath, "MainFeatures.pdf");
                    try
                    {
                        pdfConverter.SavePdfFromUrlToFile(textBoxWebPageURL.Text, outFile);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    finally
                    {
                        pdfConverter.PrepareRenderPdfPageEvent -= new PrepareRenderPdfPageDelegate(pdfConverter_PrepareRenderPdfPageEvent);
                    }
                }
                else if (radioConvertToImage.Checked)
                {
                    // get the image converter
                    ImgConverter imgConverter = GetImgConverter();

                    // set the license key
                    imgConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

                    outFile = Path.Combine(Application.StartupPath, String.Format("MainFeatures.{0}", ddlImageFormat.SelectedItem.ToString()));
                    try
                    {
                        System.Drawing.Imaging.ImageFormat renderImageFormat = GetImageFormat(ddlImageFormat.SelectedItem.ToString());
                        imgConverter.SaveImageFromUrlToFile(
                                textBoxWebPageURL.Text,
                                renderImageFormat,
                                outFile
                             );
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
            finally
            {
                this.Cursor = Cursors.Arrow;
            }

            DialogResult dr = MessageBox.Show("Open the rendered file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start(outFile);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }

        private void lnkBtnSettings_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!PageIsValid())
                return;

            if (pnlSettingsPanel.Visible)
            {
                pnlSettingsPanel.Visible = false;
                lnkBtnSettings.Text = "More Converter Settings >>";
            }
            else
            {
                pnlSettingsPanel.Visible = true;
                lnkBtnSettings.Text = "<< Hide Settings";
            }
            this.ClientSize = new Size(this.ClientSize.Width, pnlHeader.Height + pnlContent.Height + pnlConvertCommand.Height);
        }

        private void radioConvertToImage_CheckedChanged(object sender, EventArgs e)
        {
            cbJpegCompression.Visible = cbLiveLinks.Visible = cbBookmarks.Visible = cbFitWidth.Visible = cbAutoSizePdfPage.Visible
                = cbEmbedFonts.Visible = cbJpegCompression.Visible = !radioConvertToImage.Checked;
        }

        private void radioButtonConvertToPdf_CheckedChanged(object sender, EventArgs e)
        {
            pnlPDFSettings.Visible = ((RadioButton)sender).Checked;
            pnlImgeOptions.Visible = !((RadioButton)sender).Checked;
            this.ClientSize = new Size(this.ClientSize.Width, pnlHeader.Height + pnlContent.Height + pnlConvertCommand.Height);
        }

        private void cbShowHeader_CheckedChanged(object sender, EventArgs e)
        {
            pnlHeaderOptions.Visible = ((CheckBox)sender).Checked;
            this.ClientSize = new Size(this.ClientSize.Width, pnlHeader.Height + pnlContent.Height + pnlConvertCommand.Height);
        }

        private void cbShowFooter_CheckedChanged(object sender, EventArgs e)
        {
            pnlFooterOptions.Visible = ((CheckBox)sender).Checked;
            this.ClientSize = new Size(this.ClientSize.Width, pnlHeader.Height + pnlContent.Height + pnlConvertCommand.Height);
        }

        private void LoadImageFormats()
        {
            string[] imageFormats = new string[] { "Png", "Jpeg", "Bmp", "Gif", "Tiff" };
            ddlImageFormat.DataSource = imageFormats;
            ddlImageFormat.SelectedItem = "Png";
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
            ddlCompression.DataSource = pdfCompressionLevels;
            ddlCompression.SelectedItem = PdfCompressionLevel.Normal.ToString();
        }

        private void LoadPdfFormats()
        {
            ddlPageFormat.SelectedItem = "A4";
        }

        private void LoadPageOrientations()
        {
            string[] pdfPageOrientations = Enum.GetNames(typeof(PdfPageOrientation));
            ddlPageOrientation.DataSource = pdfPageOrientations;
            ddlPageOrientation.SelectedItem = PdfPageOrientation.Portrait.ToString();
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
            ddlPdfSubset.SelectedItem = "PDF";
        }

        private void LoadColors()
        {
            string[] colors = Enum.GetNames(typeof(KnownColor));

            string[] colors1 = Enum.GetNames(typeof(KnownColor));
            ddlHeaderLineColor.DataSource = colors1;
            ddlHeaderLineColor.SelectedItem = KnownColor.Black.ToString();

            string[] colors3 = Enum.GetNames(typeof(KnownColor));
            ddlFooterLineColor.DataSource = colors3;
            ddlFooterLineColor.SelectedItem = KnownColor.Black.ToString();
        }

        private bool PageIsValid()
        {
            errorProvider.Clear();
            bool invalid = false;

            if (textBoxWebPageURL.Text.Trim() == String.Empty)
            {
                errorProvider.SetError(textBoxWebPageURL, "The web page URL cannot be empty");
                invalid = true;
            }
            if (pnlSettingsPanel.Visible)
            {

                // check custom width and height
                try
                {
                    int width = int.Parse(textBoxWebPageWidth.Text.Trim());
                    if (width < 0)
                        throw new Exception();
                }
                catch
                {
                    errorProvider.SetError(textBoxWebPageWidth, "The web page width must be a positive integer");
                    invalid = true;
                }

                try
                {
                    int height = int.Parse(textBoxWebPageHeight.Text.Trim());
                    if (height < 0)
                        throw new Exception();
                }
                catch
                {
                    errorProvider.SetError(textBoxWebPageHeight, "The web page height must be a positive integer");
                    invalid = true;
                }

                try
                {
                    int conversionDelay = int.Parse(textBoxConversionDelay.Text.Trim());
                    if (conversionDelay < 0)
                        throw new Exception();
                }
                catch
                {
                    errorProvider.SetError(textBoxConversionDelay, "The conversion delay must be a positive integer");
                    invalid = true;
                }

                try
                {
                    int navigationTimeout = int.Parse(textBoxNavigationTimeout.Text.Trim());
                    if (navigationTimeout < 0)
                        throw new Exception();
                }
                catch
                {
                    errorProvider.SetError(textBoxConversionDelay, "The navigation timeout must be a positive integer");
                    invalid = true;
                }

                if (radioButtonConvertToPdf.Checked)
                {
                    try
                    {
                        int leftMargin = int.Parse(textBoxLeftMargin.Text.Trim());
                        if (leftMargin < 0)
                            throw new Exception();
                    }
                    catch
                    {
                        errorProvider.SetError(textBoxLeftMargin, "The PDF document left margin must be a positive integer");
                        invalid = true;
                    }

                    try
                    {
                        int rightMargin = int.Parse(textBoxRightMargin.Text.Trim());
                        if (rightMargin < 0)
                            throw new Exception();
                    }
                    catch
                    {
                        errorProvider.SetError(textBoxRightMargin, "The PDF document right margin must be a positive integer");
                        invalid = true;
                    }

                    try
                    {
                        int topMargin = int.Parse(textBoxTopMargin.Text.Trim());
                        if (topMargin < 0)
                            throw new Exception();
                    }
                    catch
                    {
                        errorProvider.SetError(textBoxTopMargin, "The PDF document top margin must be a positive integer");
                        invalid = true;
                    }

                    try
                    {
                        int bottomMargin = int.Parse(textBoxBottomMargin.Text.Trim());
                        if (bottomMargin < 0)
                            throw new Exception();
                    }
                    catch
                    {
                        errorProvider.SetError(textBoxBottomMargin, "The PDF document bottom margin must be a positive integer");
                        invalid = true;
                    }

                    try
                    {
                        float headerHeight = float.Parse(textBoxHeaderHeight.Text.Trim());
                        if (headerHeight < 0)
                            throw new Exception();
                    }
                    catch
                    {
                        errorProvider.SetError(textBoxHeaderHeight, "The PDF document header height must be a positive float");
                        invalid = true;
                    }

                    try
                    {
                        float footerHeight = float.Parse(textBoxFooterHeight.Text.Trim());
                        if (footerHeight < 0)
                            throw new Exception();
                    }
                    catch
                    {
                        errorProvider.SetError(textBoxFooterHeight, "The PDF document footer height must be a positive float");
                        invalid = true;
                    }
                }

            }
            return !invalid;
        }
    }
}