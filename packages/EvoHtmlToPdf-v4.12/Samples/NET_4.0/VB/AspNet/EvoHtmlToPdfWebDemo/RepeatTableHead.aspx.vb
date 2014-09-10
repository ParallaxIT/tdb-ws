Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class RepeatTableHead
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("RepeatTableHead")
		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfConverter As New PdfConverter()

			' set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' the URL of the HTML document to convert
			Dim thisPageURL As String = HttpContext.Current.Request.Url.AbsoluteUri
			Dim htmlTableFilePath As String = thisPageURL.Substring(0, thisPageURL.LastIndexOf("/"c)) & "/HtmlTable/table_with_repeated_head.html"

			' call the converter
			Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromUrl(htmlTableFilePath)

            ' send the generated PDF document to client browser

            ' get the object representing the HTTP response to browser
            Dim httpResponse As HttpResponse = HttpContext.Current.Response

            ' add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf")
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=RepeatedTableHead.pdf; size={0}", pdfBytes.Length.ToString()))

            ' write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes)

            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to PDF document stream
            httpResponse.End()
		End Sub
	End Class
End Namespace
