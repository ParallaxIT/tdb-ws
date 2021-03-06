using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using EvoPdf;

namespace EvoHtmlToPdfDemo
{
    public partial class TextAndFonts : Form
    {
        public TextAndFonts()
        {
            InitializeComponent();
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
        {
            // create a PDF document
            Document document = new Document();

            // set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // add a page to the PDF document
            PdfPage firstPage = document.AddPage();

            // Create a Times New Roman .NET font of 10 points
            System.Drawing.Font ttfFont = new System.Drawing.Font("Times New Roman", 10, System.Drawing.GraphicsUnit.Point);
            // Create a Times New Roman Italic .NET font of 10 points
            System.Drawing.Font ttfFontItalic = new System.Drawing.Font("Times New Roman", 10,
                        System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            // Create a Times New Roman Bold .NET font of 10 points
            System.Drawing.Font ttfFontBold = new System.Drawing.Font("Times New Roman", 10,
                        System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            // Create a Times New Roman Bold .NET font of 10 points
            System.Drawing.Font ttfFontBoldItalic = new System.Drawing.Font("Times New Roman", 10,
                        System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);

            // Create a Sim Sun .NET font of 10 points
            System.Drawing.Font ttfCJKFont = new System.Drawing.Font("SimSun", 10,
                        System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);

            // Create the PDF fonts based on the .NET true type fonts
            PdfFont newTimesFont = document.AddFont(ttfFont);
            PdfFont newTimesFontItalic = document.AddFont(ttfFontItalic);
            PdfFont newTimesFontBold = document.AddFont(ttfFontBold);
            PdfFont newTimesFontBoldItalic = document.AddFont(ttfFontBoldItalic);

            // Create the embedded PDF fonts based on the .NET true type fonts
            PdfFont newTimesEmbeddedFont = document.AddFont(ttfFont, true);
            PdfFont newTimesItalicEmbeddedFont = document.AddFont(ttfFontItalic, true);
            PdfFont newTimesBoldEmbeddedFont = document.AddFont(ttfFontBold, true);
            PdfFont newTimesBoldItalicEmbeddedFont = document.AddFont(ttfFontBoldItalic, true);

            PdfFont cjkEmbeddedFont = document.AddFont(ttfCJKFont, true);

            // Create a standard Times New Roman Type 1 Font
            PdfFont stdTimesFont = document.AddFont(StdFontBaseFamily.TimesRoman);
            PdfFont stdTimesFontItalic = document.AddFont(StdFontBaseFamily.TimesItalic);
            PdfFont stdTimesFontBold = document.AddFont(StdFontBaseFamily.TimesBold);
            PdfFont stdTimesFontBoldItalic = document.AddFont(StdFontBaseFamily.TimesBoldItalic);

            // Create CJK standard Type 1 fonts
            PdfFont cjkJapaneseStandardFont = document.AddFont(StandardCJKFont.HeiseiKakuGothicW5);
            PdfFont cjkChineseTraditionalStandardFont = document.AddFont(StandardCJKFont.MonotypeHeiMedium);

            // Add text elements to the document

            TextElement trueTypeText = new TextElement(0, 10, "True Type Fonts Demo:", newTimesFontBold);
            AddElementResult addResult = firstPage.AddElement(trueTypeText);

            // Create the text element
            TextElement textElement1 = new TextElement(20, addResult.EndPageBounds.Bottom + 10, "Hello World !!!!", newTimesFont);
            // Add element to page. The result of adding the text element is stored into the addResult object
            // which can be used to get information about the rendered size in PDF page.
            addResult = firstPage.AddElement(textElement1);

            // Add another element 5 points below the text above. The bottom of the text above is taken from the AddElementResult object
            // set the font size
            newTimesFontItalic.Size = 15;
            TextElement textElement2 = new TextElement(20, addResult.EndPageBounds.Bottom + 5, "Hello World !!!!", newTimesFontItalic);
            textElement2.ForeColor = System.Drawing.Color.Green;
            addResult = firstPage.AddElement(textElement2);

            newTimesFontBoldItalic.Size = 20;
            TextElement textElement3 = new TextElement(20, addResult.EndPageBounds.Bottom + 5, "Hello World !!!!", newTimesFontBoldItalic);
            textElement3.ForeColor = System.Drawing.Color.Blue;
            addResult = firstPage.AddElement(textElement3);

            TextElement stdTypeText = new TextElement(0, addResult.EndPageBounds.Bottom + 10, "Standard PDF Fonts Demo:", newTimesFontBold);
            addResult = firstPage.AddElement(stdTypeText);

            TextElement textElement4 = new TextElement(20, addResult.EndPageBounds.Bottom + 10, "Hello World !!!!", stdTimesFont);
            addResult = firstPage.AddElement(textElement4);

            stdTimesFontItalic.Size = 15;
            TextElement textElement5 = new TextElement(20, addResult.EndPageBounds.Bottom + 5, "Hello World !!!!", stdTimesFontItalic);
            textElement5.ForeColor = System.Drawing.Color.Green;
            addResult = firstPage.AddElement(textElement5);

            stdTimesFontBoldItalic.Size = 20;
            TextElement textElement6 = new TextElement(20, addResult.EndPageBounds.Bottom + 5, "Hello World !!!!", stdTimesFontBoldItalic);
            textElement6.ForeColor = System.Drawing.Color.Blue;
            addResult = firstPage.AddElement(textElement6);

            // embedded true type fonts

            TextElement embeddedTtfText = new TextElement(0, addResult.EndPageBounds.Bottom + 10, "Embedded True Type Fonts Demo:", newTimesFontBold);
            addResult = firstPage.AddElement(embeddedTtfText);

            // russian text
            TextElement textElement8 = new TextElement(20, addResult.EndPageBounds.Bottom + 5, "Появление на свет!!", newTimesEmbeddedFont);
            addResult = firstPage.AddElement(textElement8);

            string outFilePath = System.IO.Path.Combine(Application.StartupPath, "TextsAndFontsDemo.pdf");

            // save the PDF document to disk
            document.Save(outFilePath);

            // close the PDF document to release the resources
            document.Close();

            DialogResult dr = MessageBox.Show("Open the saved file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start(outFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }
}