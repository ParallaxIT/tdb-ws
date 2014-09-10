Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class DemoLinksBox
		Inherits System.Web.UI.UserControl
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		End Sub

		Public Sub LoadDemo(ByVal demoName As String)
			Select Case demoName
				Case "GettingStarted"
					lnkGettingStarted.CssClass = "demolinks selected_demolinks"
				Case "HtmlToPdfFeatures"
					lnkFeaturesDemo.CssClass = "demolinks selected_demolinks"
				Case "PdfInvoices"
					lnkPdfInvoices.CssClass = "demolinks selected_demolinks"
				Case "ConvertMultipleUrls"
					lnkConvertMultipleUrls.CssClass = "demolinks selected_demolinks"
				Case "HtmlInHeaderAndFooter"
					lnkHtmlInHeaderAndFooter.CssClass = "demolinks selected_demolinks"
				Case "HtmlElementsLocation"
					lnkHtmlElementsLocation.CssClass = "demolinks selected_demolinks"
				Case "RepeatTableHead"
					lnkRepeatTableHead.CssClass = "demolinks selected_demolinks"
				Case "TableOfContents"
					lnkTableOfContents.CssClass = "demolinks selected_demolinks"
				Case "PdfSecurity"
					lnkPdfSecurity.CssClass = "demolinks selected_demolinks"
				Case "AppendPdf"
					lnkAppendPdf.CssClass = "demolinks selected_demolinks"
				Case "HtmlToPdfElement"
					lnkHtmlToPdfElement.CssClass = "demolinks selected_demolinks"
				Case "TextAndFonts"
					lnkTextAndFonts.CssClass = "demolinks selected_demolinks"
				Case "ImageElement"
					lnkImageElement.CssClass = "demolinks selected_demolinks"
				Case "PdfShapes"
					lnkPdfShapes.CssClass = "demolinks selected_demolinks"
                Case "PdfStamps"
                    lnkPdfStamps.CssClass = "demolinks selected_demolinks"
				Case "SvgToPdf"
					lnkSvgToPdf.CssClass = "demolinks selected_demolinks"
				Case Else
			End Select
		End Sub

		Protected Sub lnkGettingStarted_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("Default.aspx")
		End Sub

		Protected Sub lnkConvertMultipleUrls_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("ConvertMultipleURLs.aspx")
		End Sub

		Protected Sub lnkHtmlElementsLocation_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("HtmlElementsLocation.aspx")
		End Sub

		Protected Sub lnkRepeatTableHead_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("RepeatTableHead.aspx")
		End Sub

		Protected Sub lnkTableOfContents_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("TableOfContentsAndBookmarks.aspx")
		End Sub

		Protected Sub lnkPdfInvoices_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("PdfInvoicesDemo.aspx")
		End Sub

		Protected Sub lnkPdfSecurity_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("PdfSecurity.aspx")
		End Sub

		Protected Sub lnkAppendPdf_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("AppendExternalPDFs.aspx")
		End Sub

		Protected Sub lnkHtmlToPdfElement_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("HtmlToPdfElementDemo.aspx")
		End Sub

		Protected Sub lnkFeaturesDemo_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("HtmlToPdfFeaturesDemo.aspx")
		End Sub

		Protected Sub lnkTextAndFonts_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("TextAndFonts.aspx")
		End Sub

		Protected Sub lnkImageElement_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("ImageElementDemo.aspx")
		End Sub

		Protected Sub lnkPdfShapes_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("PdfShapes.aspx")
		End Sub

		Protected Sub lnkPdfStamps_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("PdfStamps.aspx")
		End Sub

		Protected Sub lnkSvgToPdf_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("SvgToPdfDemo.aspx")
		End Sub

		Protected Sub lnkHtmlInHeaderAndFooter_Click(ByVal sender As Object, ByVal e As EventArgs)
			Response.Redirect("HtmlInHeaderAndFooter.aspx")
		End Sub
	End Class
End Namespace