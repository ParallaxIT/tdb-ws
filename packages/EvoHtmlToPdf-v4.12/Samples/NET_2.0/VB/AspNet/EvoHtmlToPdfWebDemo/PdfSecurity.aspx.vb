Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class PdfSecurity
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("PdfSecurity")
		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfConverter As New PdfConverter()

			' set the license key
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' set user and owner passwords
			pdfConverter.PdfSecurityOptions.UserPassword = "user"
			pdfConverter.PdfSecurityOptions.OwnerPassword = "owner"

			' restrict the right to print and to copy the document content
			pdfConverter.PdfSecurityOptions.CanPrint = False
			pdfConverter.PdfSecurityOptions.CanCopyContent = False

			' call the converter
			Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromUrl(textBoxWebPageURL.Text.Trim())

            ' send the generated PDF document to client browser

            ' get the object representing the HTTP response to browser
            Dim httpResponse As HttpResponse = HttpContext.Current.Response

            ' add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf")
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=PdfSecurity.pdf; size={0}", pdfBytes.Length.ToString()))

            ' write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes)

            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to PDF document stream
            httpResponse.End()
		End Sub
	End Class
End Namespace
