Imports System.ComponentModel
Imports System.Text
Imports System.IO

Imports EvoPdf


Namespace EvoHtmlToPdfDemo
	Partial Public Class ConvertHtmlString
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvertMerge.Click
			Me.Cursor = Cursors.WaitCursor

			Try
				Dim pdfConverter As New PdfConverter()

				' set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

				' save the PDF bytes in a file on disk
				Dim outFilePath As String = Path.Combine(Application.StartupPath, "ConvertHtmlString.pdf")

				pdfConverter.SavePdfFromHtmlStringToFile(textBoxHtmlString.Text, outFilePath, textBoxBaseUrl.Text.Trim())

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