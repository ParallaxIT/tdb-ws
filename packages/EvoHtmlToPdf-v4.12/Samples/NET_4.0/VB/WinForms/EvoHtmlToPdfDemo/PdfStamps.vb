Imports System.ComponentModel
Imports System.Text

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class PdfStamps
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnCreatePdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreatePdf.Click
			Dim pdfToModify As String = textBoxPdfFilePath.Text.Trim()

			' create a PDF document
			Dim document As New Document(pdfToModify)

			' set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' get the first page the PDF document
			Dim firstPage As PdfPage = document.Pages(0)

			Dim logoTransImagePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\img\evologo-100-trans.png")
			Dim logoOpaqueImagePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\img\evologo-100.jpg")

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

			Dim logoImg As Image = Image.FromFile(logoTransImagePath)

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

			Dim outFilePath As String = System.IO.Path.Combine(Application.StartupPath, "PdfStamps.pdf")

			' save the PDF document to disk
			Try
				document.Save(outFilePath)
			Finally
				document.Close()
			End Try

			Dim dr As DialogResult = MessageBox.Show("Open the saved file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo)
			If dr = DialogResult.Yes Then
				Try
					Process.Start(outFilePath)
				Catch ex As Exception
					MessageBox.Show(ex.Message)
					Return
				End Try
			End If
		End Sub

		Private Sub PdfStamps_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			textBoxPdfFilePath.Text = System.IO.Path.Combine(Application.StartupPath, "..\..\ExternalPdfs\book.pdf")
		End Sub

		Private Sub btnSelectFile_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSelectFile.Click
			Dim fd As New OpenFileDialog()
			fd.Filter = "PDF files (*.pdf)|*.pdf|All files (*.*)|*.*"
			If fd.ShowDialog() = DialogResult.OK Then
				textBoxPdfFilePath.Text = fd.FileName
			End If
		End Sub
	End Class
End Namespace