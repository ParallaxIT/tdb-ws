Imports System.ComponentModel
Imports System.Text
Imports System.IO

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class AppendPrependExternalPdf
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnConvertMerge_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvertMerge.Click
			Me.Cursor = Cursors.WaitCursor

			Dim pdfStream2 As MemoryStream = Nothing

			Try
				Dim pdfConverter As New PdfConverter()

				' set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

                ' Convert the first document and produce a Document object containing the conversion result
                Dim document1 As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL1.Text)

                ' Load a second document from a stream produced by the conversion of the second URL
                Dim doc2Bytes As Byte() = pdfConverter.GetPdfBytesFromUrl(textBoxURL2.Text)
                pdfStream2 = New MemoryStream(doc2Bytes)

                ' Load a PDF document from a stream
                Dim document2 As Document = New Document(pdfStream2)

                ' Append second to the first document
                document1.AppendDocument(document2)

                ' Convert the third URL to PDF and obtain a PDF document object
                Dim document3 As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL3.Text)

                ' Append the third document after the second
                document1.AppendDocument(document3)

                ' When AutoCloseAppendedDocs property is set on true the appended documents are automatically closed
                ' when the document to which they are appended is closed
                document1.AutoCloseAppendedDocs = True

				Dim outFilePath As String = Path.Combine(Application.StartupPath, "AppendDocument.pdf")

				Try
                    document1.Save(outFilePath)
				Finally
                    ' Close the Document to realease all the resources
                    ' The appended document2 and document3 will be automatically closed
                    document1.Close()
				End Try

				Dim dr As DialogResult = MessageBox.Show("Open the rendered file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo)
				If dr = DialogResult.Yes Then
					Process.Start(outFilePath)
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			Finally
				If pdfStream2 IsNot Nothing Then
					pdfStream2.Close()
                End If

                Me.Cursor = Cursors.Arrow
			End Try
		End Sub
	End Class
End Namespace