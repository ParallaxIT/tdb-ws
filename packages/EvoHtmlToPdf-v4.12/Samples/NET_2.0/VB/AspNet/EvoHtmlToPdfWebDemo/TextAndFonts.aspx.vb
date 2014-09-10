Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class TextAndFonts
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("TextAndFonts")
		End Sub

		Protected Sub btnCreatePDF_Click(ByVal sender As Object, ByVal e As EventArgs)
			' create a PDF document
			Dim document As New Document()

			' set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' add a page to the PDF document
			Dim firstPage As PdfPage = document.AddPage()

			' Create a Times New Roman .NET font of 10 points
			Dim ttfFont As New Font("Times New Roman", 10, GraphicsUnit.Point)
			' Create a Times New Roman Italic .NET font of 10 points
			Dim ttfFontItalic As New Font("Times New Roman", 10, FontStyle.Italic, GraphicsUnit.Point)
			' Create a Times New Roman Bold .NET font of 10 points
			Dim ttfFontBold As New Font("Times New Roman", 10, FontStyle.Bold, GraphicsUnit.Point)
			' Create a Times New Roman Bold .NET font of 10 points
			Dim ttfFontBoldItalic As New Font("Times New Roman", 10, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)

			' Create a Sim Sun .NET font of 10 points
			Dim ttfCJKFont As New Font("SimSun", 10, FontStyle.Regular, GraphicsUnit.Point)

			' Create the PDF fonts based on the .NET true type fonts
			Dim newTimesFont As PdfFont = document.AddFont(ttfFont)
			Dim newTimesFontItalic As PdfFont = document.AddFont(ttfFontItalic)
			Dim newTimesFontBold As PdfFont = document.AddFont(ttfFontBold)
			Dim newTimesFontBoldItalic As PdfFont = document.AddFont(ttfFontBoldItalic)

			' Create the embedded PDF fonts based on the .NET true type fonts
			Dim newTimesEmbeddedFont As PdfFont = document.AddFont(ttfFont, True)
			Dim newTimesItalicEmbeddedFont As PdfFont = document.AddFont(ttfFontItalic, True)
			Dim newTimesBoldEmbeddedFont As PdfFont = document.AddFont(ttfFontBold, True)
			Dim newTimesBoldItalicEmbeddedFont As PdfFont = document.AddFont(ttfFontBoldItalic, True)

			Dim cjkEmbeddedFont As PdfFont = document.AddFont(ttfCJKFont, True)

			' Create a standard Times New Roman Type 1 Font
			Dim stdTimesFont As PdfFont = document.AddFont(StdFontBaseFamily.TimesRoman)
			Dim stdTimesFontItalic As PdfFont = document.AddFont(StdFontBaseFamily.TimesItalic)
			Dim stdTimesFontBold As PdfFont = document.AddFont(StdFontBaseFamily.TimesBold)
			Dim stdTimesFontBoldItalic As PdfFont = document.AddFont(StdFontBaseFamily.TimesBoldItalic)

			' Create CJK standard Type 1 fonts
			Dim cjkJapaneseStandardFont As PdfFont = document.AddFont(StandardCJKFont.HeiseiKakuGothicW5)
			Dim cjkChineseTraditionalStandardFont As PdfFont = document.AddFont(StandardCJKFont.MonotypeHeiMedium)

			' Add text elements to the document

			Dim trueTypeText As New TextElement(0, 10, "True Type Fonts Demo:", newTimesFontBold)
			Dim addResult As AddElementResult = firstPage.AddElement(trueTypeText)

			' Create the text element
			Dim textElement1 As New TextElement(20, addResult.EndPageBounds.Bottom + 10, "Hello World !!!!", newTimesFont)
			' Add element to page. The result of adding the text element is stored into the addResult object
			' which can be used to get information about the rendered size in PDF page.
			addResult = firstPage.AddElement(textElement1)

			' Add another element 5 points below the text above. The bottom of the text above is taken from the AddElementResult object
			' set the font size
			newTimesFontItalic.Size = 15
			Dim textElement2 As New TextElement(20, addResult.EndPageBounds.Bottom + 5, "Hello World !!!!", newTimesFontItalic)
			textElement2.ForeColor = Color.Green
			addResult = firstPage.AddElement(textElement2)

			newTimesFontBoldItalic.Size = 20
			Dim textElement3 As New TextElement(20, addResult.EndPageBounds.Bottom + 5, "Hello World !!!!", newTimesFontBoldItalic)
			textElement3.ForeColor = Color.Blue
			addResult = firstPage.AddElement(textElement3)

			Dim stdTypeText As New TextElement(0, addResult.EndPageBounds.Bottom + 10, "Standard PDF Fonts Demo:", newTimesFontBold)
			addResult = firstPage.AddElement(stdTypeText)

			Dim textElement4 As New TextElement(20, addResult.EndPageBounds.Bottom + 10, "Hello World !!!!", stdTimesFont)
			addResult = firstPage.AddElement(textElement4)

			stdTimesFontItalic.Size = 15
			Dim textElement5 As New TextElement(20, addResult.EndPageBounds.Bottom + 5, "Hello World !!!!", stdTimesFontItalic)
			textElement5.ForeColor = Color.Green
			addResult = firstPage.AddElement(textElement5)

			stdTimesFontBoldItalic.Size = 20
			Dim textElement6 As New TextElement(20, addResult.EndPageBounds.Bottom + 5, "Hello World !!!!", stdTimesFontBoldItalic)
			textElement6.ForeColor = Color.Blue
			addResult = firstPage.AddElement(textElement6)

			' embedded true type fonts

			Dim embeddedTtfText As New TextElement(0, addResult.EndPageBounds.Bottom + 10, "Embedded True Type Fonts Demo:", newTimesFontBold)
			addResult = firstPage.AddElement(embeddedTtfText)

			' russian text
			Dim textElement8 As New TextElement(20, addResult.EndPageBounds.Bottom + 5, "Появление на свет!!", newTimesEmbeddedFont)
			addResult = firstPage.AddElement(textElement8)

			Try
                ' get the PDF document bytes
                Dim pdfBytes As Byte() = document.Save()

                ' send the generated PDF document to client browser

                ' get the object representing the HTTP response to browser
                Dim httpResponse As HttpResponse = HttpContext.Current.Response

                ' add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf")
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=TextAndFonts.pdf; size={0}", pdfBytes.Length.ToString()))

                ' write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes)

                ' Note: it is important to end the response, otherwise the ASP.NET
                ' web page will render its content to PDF document stream
                httpResponse.End()
			Finally
				' close the PDF document to release the resources
				document.Close()
			End Try
		End Sub
	End Class
End Namespace
