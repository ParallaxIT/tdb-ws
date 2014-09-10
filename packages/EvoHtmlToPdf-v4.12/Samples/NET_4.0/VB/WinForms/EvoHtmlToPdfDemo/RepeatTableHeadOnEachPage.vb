Imports System.ComponentModel
Imports System.Text

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class RepeatTableHeadOnEachPage
		Inherits Form
		Private Const TOC_ENTRIES_COUNT As Integer = 16
		Private Const PAGE_NUMBER_FONT_SIZE As Integer = 10

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvert.Click
			Me.Cursor = Cursors.WaitCursor

			Try
				Dim pdfConverter As New PdfConverter()

				' set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

				' the URL of the HTML table with repeated header
				Dim htmlTableFilePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\HtmlTable\table_with_repeated_head.html")

				Me.Cursor = Cursors.WaitCursor

				' save the PDF bytes in a file on disk
				Dim outFilePath As String = System.IO.Path.Combine(Application.StartupPath, "RepeatedTableHead.pdf")

				Try
					' call the converter
					Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromUrl(htmlTableFilePath)
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


		Private Sub lnkViewHtmlTable_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkViewHtmlTable.LinkClicked
			' the URL of the HTML document to convert
			Dim htmlTableFilePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\HtmlTable\table_with_repeated_head.html")
			Try
				Process.Start(htmlTableFilePath)
			Catch
				MessageBox.Show("There is no HTML viewer installed.")
			End Try
		End Sub
	End Class
End Namespace