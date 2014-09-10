Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class ImageElementDemo
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("ImageElement")
		End Sub

		Protected Sub btnCreatePDF_Click(ByVal sender As Object, ByVal e As EventArgs)
			' create a PDF document
			Dim document As New Document()

			' set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' add a page to the PDF document
			Dim firstPage As PdfPage = document.AddPage()

			Dim imagesPath As String = System.IO.Path.Combine(Server.MapPath("~"), "Images")

			' display image in the available space in page and with a auto determined height to keep the aspect ratio
			Dim imageElement1 As New ImageElement(0, 0, System.IO.Path.Combine(imagesPath, "evologo-250.png"))
			Dim addResult As AddElementResult = firstPage.AddElement(imageElement1)

			' display image with the specified width and the height auto determined to keep the aspect ratio
			' the images is displayed to the right of the previous image and the bounds of the image inside the current page
			' are taken from the AddElementResult object
			Dim imageElement2 As New ImageElement(addResult.EndPageBounds.Right + 10, 0, 100, System.IO.Path.Combine(imagesPath, "evologo-250.png"))
			addResult = firstPage.AddElement(imageElement2)

			' Display image with the specified width and the specified height. It is possible for the image to not preserve the aspect ratio 
			' The images is displayed to the right of the previous image and the bounds of the image inside the current page
			' are taken from the AddElementResult object
			Dim imageElement3 As New ImageElement(addResult.EndPageBounds.Right + 10, 0, 100, 50, System.IO.Path.Combine(imagesPath, "evologo-250.png"))
			addResult = firstPage.AddElement(imageElement3)

			Try
                ' get the PDF document bytes
                Dim pdfBytes As Byte() = document.Save()

                ' send the generated PDF document to client browser

                ' get the object representing the HTTP response to browser
                Dim httpResponse As HttpResponse = HttpContext.Current.Response

                ' add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf")
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=ImageElement.pdf; size={0}", pdfBytes.Length.ToString()))

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
