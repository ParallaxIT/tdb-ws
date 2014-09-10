Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class PdfStamps
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("PdfStamps")

			If Not IsPostBack Then
				Dim defaultExistingPdf As String = System.IO.Path.Combine(Server.MapPath("~"), "ExternalPdfs\book.pdf")
				textBoxPdfFilePath.Text = defaultExistingPdf
			End If
		End Sub

		Protected Sub btnCreatePDF_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfToModify As String = textBoxPdfFilePath.Text.Trim()

			' create a PDF document
			Dim document As New Document(pdfToModify)

			' set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' get the first page the PDF document
			Dim firstPage As PdfPage = document.Pages(0)

			Dim logoTransImagePath As String = System.IO.Path.Combine(Server.MapPath("~"), "images\evologo-100-trans.png")
			Dim logoOpaqueImagePath As String = System.IO.Path.Combine(Server.MapPath("~"), "images\evologo-100.jpg")

			' add an opaque image stamp in the top left corner of the first page
			' and make it semitransparent when rendered in PDF
			Dim imageStamp As New ImageElement(1, 1, logoOpaqueImagePath)
            imageStamp.Opacity = 50
			Dim addResult As AddElementResult = firstPage.AddElement(imageStamp)

			' add a border for the image stamp
			Dim imageBorderRectangleElement As New RectangleElement(1, 1, addResult.EndPageBounds.Width, addResult.EndPageBounds.Height)
			firstPage.AddElement(imageBorderRectangleElement)

			' add a template stamp to the document repeated on each document page
			' the template contains an image and a text

            Dim logoImg As System.Drawing.Image = System.Drawing.Image.FromFile(logoTransImagePath)

			' calculate the template stamp location and size
			Dim imageSizePx As SizeF = logoImg.PhysicalDimension

			Dim imageWidthPoints As Single = UnitsConverter.PixelsToPoints(imageSizePx.Width)
			Dim imageHeightPoints As Single = UnitsConverter.PixelsToPoints(imageSizePx.Height)

			Dim templateStampXLocation As Single = (firstPage.ClientRectangle.Width - imageWidthPoints) / 2
            Dim templateStampYLocation As Single = firstPage.ClientRectangle.Height / 4

			' the stamp size is equal to image size in points
			Dim templateStamp As Template = document.AddTemplate(New RectangleF(templateStampXLocation, templateStampYLocation, imageWidthPoints, imageHeightPoints + 20))

			' set a semitransparent background color for template
			Dim background As New RectangleElement(0, 0, templateStamp.ClientRectangle.Width, templateStamp.ClientRectangle.Height)
			background.BackColor = Color.White
            background.Opacity = 25
			templateStamp.AddElement(background)

			' add a true type font to the document
			Dim ttfFontBoldItalic As New Font("Times New Roman", 10, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
			Dim templateStampTextFont As PdfFont = document.AddFont(ttfFontBoldItalic, True)

			' Add a text element to the template. You can add any other types of elements to a template like a HtmlToPdfElement.
			Dim templateStampTextElement As New TextElement(3, 0, "This is the Stamp Text", templateStampTextFont)
			templateStampTextElement.ForeColor = Color.DarkBlue
			templateStamp.AddElement(templateStampTextElement)

			' Add an image with transparency to the template. You can add any other types of elements to a template like a HtmlToPdfElement.
			Dim templateStampImageElement As New ImageElement(0, 20, logoImg)
			' instruct the library to use transparency information
			templateStampImageElement.RenderTransparentImage = True
			templateStamp.AddElement(templateStampImageElement)

			' add a border to template
			Dim templateStampRectangleElement As New RectangleElement(0, 0, templateStamp.ClientRectangle.Width, templateStamp.ClientRectangle.Height)
			templateStamp.AddElement(templateStampRectangleElement)

			' dispose the image
			logoImg.Dispose()

			' save the document on http response stream
			Try
                ' get the PDF document bytes
                Dim pdfBytes As Byte() = document.Save()

                ' send the generated PDF document to client browser

                ' get the object representing the HTTP response to browser
                Dim httpResponse As HttpResponse = HttpContext.Current.Response

                ' add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf")
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=PdfStamps.pdf; size={0}", pdfBytes.Length.ToString()))

                ' write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes)

                ' Note: it is important to end the response, otherwise the ASP.NET
                ' web page will render its content to PDF document stream
                httpResponse.End()
			Finally
				document.Close()
			End Try
		End Sub
	End Class
End Namespace
