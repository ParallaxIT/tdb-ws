Imports System.ComponentModel
Imports System.Text

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class SvgToPdf
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnCreatePdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreatePdf.Click
			Me.Cursor = Cursors.WaitCursor

			Try
				Dim pdfConverter As New PdfConverter()

				' set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

				' We convert the HTML page as local disk file because IIS and VS WebDev Server 
				' don't have .svg included in MIME types by default.
				' When converting HTML pages from an IIS server the MIME type image/svg+xml 
				' must be added to IIS in order to serve the .svg files referenced in HTML
				Dim htmlWithSvgFilePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\SVG\svg.html")

				' SVG can be used inline in a XML document
				Dim xmlWithInlineSvgFilePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\SVG\svginline.xml")

				Me.Cursor = Cursors.WaitCursor

				' save the PDF bytes in a file on disk
				Dim outFilePath As String = System.IO.Path.Combine(Application.StartupPath, "SvgToPdf.pdf")

				Try
					' call the converter
					Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromUrl(htmlWithSvgFilePath)
					System.IO.File.WriteAllBytes(outFilePath, pdfBytes)
				Finally
					Me.Cursor = Cursors.Arrow
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

		Private Sub lnkViewSvg_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkViewSvg.LinkClicked
			' the URL of the HTML with SVG document to convert
			Dim htmlWithSvgFilePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\SVG\svg.html")
			Try
				Process.Start(htmlWithSvgFilePath)
			Catch
				MessageBox.Show("There is no HTML viewer installed.")
			End Try
		End Sub
	End Class
End Namespace