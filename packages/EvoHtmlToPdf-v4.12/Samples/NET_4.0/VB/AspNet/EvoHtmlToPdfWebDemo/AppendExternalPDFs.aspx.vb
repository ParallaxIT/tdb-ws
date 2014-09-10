Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports System.IO

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class AppendExternalPDFs
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("AppendPdf")
		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfStream2 As MemoryStream = Nothing

			Try
				Dim pdfConverter As New PdfConverter()

				 ' Convert the first document and produce a Document object containing the conversion result
                Dim document1 As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxWebPageURL1.Text)

                ' Load a second document from a stream produced by the conversion of the second URL
                Dim doc2Bytes As Byte() = pdfConverter.GetPdfBytesFromUrl(textBoxWebPageURL2.Text)
                pdfStream2 = New MemoryStream(doc2Bytes)

                ' Load a PDF document from a stream
                Dim document2 As Document = New Document(pdfStream2)

                ' Append second to the first document
                document1.AppendDocument(document2)

                ' Convert the third URL to PDF and obtain a PDF document object
                Dim document3 As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxWebPageURL3.Text)

                ' Append the third document after the second
                document1.AppendDocument(document3)

                ' When AutoCloseAppendedDocs property is set on true the appended documents are automatically closed
                ' when the document to which they are appended is closed
                document1.AutoCloseAppendedDocs = True

				Dim pdfBytes() As Byte = Nothing

				Try
                    pdfBytes = document1.Save()
				Finally
                    ' Close the Document to realease all the resources
                    ' The appended document2 and document3 will be automatically closed
                    document1.Close()
				End Try

                ' send the generated PDF document to client browser

                ' get the object representing the HTTP response to browser
                Dim httpResponse As HttpResponse = HttpContext.Current.Response

                ' add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf")
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=AppendDocument.pdf; size={0}", pdfBytes.Length.ToString()))

                ' write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes)

                ' Note: it is important to end the response, otherwise the ASP.NET
                ' web page will render its content to PDF document stream
                httpResponse.End()
			Finally
				If pdfStream2 IsNot Nothing Then
					pdfStream2.Close()
				End If
            End Try
		End Sub
	End Class
End Namespace
