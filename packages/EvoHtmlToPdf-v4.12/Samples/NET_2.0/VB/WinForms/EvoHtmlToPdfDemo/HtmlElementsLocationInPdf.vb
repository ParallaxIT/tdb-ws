Imports System.ComponentModel
Imports System.Text

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class HtmlElementsLocationInPdf
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvert.Click
			Me.Cursor = Cursors.WaitCursor

			Try
				Dim pdfConverter As New PdfConverter()

				' set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

				' inform the converter about the HTML elements for which we want the location in PDF
				' in this sample we want the location of IMG, H1 and H2 elements and the elements having ID 'id1' or 'id2'
				pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = New String() { "IMG", "H1", "H2", "#id1", "#id2" }

				' call the converter and get a Document object from URL
				Dim pdfDocument As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL.Text.Trim())

				' iterate over the HTML elements locations and hightlight each element with a green rectangle
				For Each elementMapping As HtmlElementMapping In pdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult
					' because a HTML element can span over many PDF pages the mapping 
					' of the HTML element in PDF document consists in a list of rectangles,
					' one rectangle for each PDF page where this element was rendered
					For Each elementLocationInPdf As HtmlElementPdfRectangle In elementMapping.PdfRectangles
						' get the PDF page
						Dim pdfPage As PdfPage = pdfDocument.Pages(elementLocationInPdf.PageIndex)
						Dim pdfRectangleInPage As RectangleF = elementLocationInPdf.Rectangle

						' create a RectangleElement to highlight the HTML element
						Dim highlightRectangle As New RectangleElement(pdfRectangleInPage.X, pdfRectangleInPage.Y, pdfRectangleInPage.Width, pdfRectangleInPage.Height)
						highlightRectangle.ForeColor = Color.Green

						pdfPage.AddElement(highlightRectangle)
					Next elementLocationInPdf
				Next elementMapping

				' save the PDF bytes in a file on disk
				Dim outFilePath As String = System.IO.Path.Combine(Application.StartupPath, "HtmlElementsLocation.pdf")

				Try
					pdfDocument.Save(outFilePath)
				Finally
					' close the Document to realease all the resources
					pdfDocument.Close()
				End Try

				' open the generated PDF document in an external viewer
				Dim dr As DialogResult = MessageBox.Show("Open the rendered file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo)
				If dr = DialogResult.Yes Then
					Process.Start(outFilePath)
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			Finally
				Me.Cursor = Cursors.Arrow
			End Try
		End Sub
	End Class
End Namespace