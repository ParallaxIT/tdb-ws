Imports System.ComponentModel
Imports System.Text

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class ImageElementDemo
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnCreatePdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreatePdf.Click
			' create a PDF document
			Dim document As New Document()

			' set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' add a page to the PDF document
			Dim firstPage As PdfPage = document.AddPage()

			Dim imagesPath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\Img")

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

			Dim outFilePath As String = System.IO.Path.Combine(Application.StartupPath, "ImageElementDemo.pdf")

			' save the PDF document to disk
			document.Save(outFilePath)

			' close the PDF document to release the resources
			document.Close()

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
	End Class
End Namespace