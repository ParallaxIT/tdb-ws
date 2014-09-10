Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class ConvertMultipleURLs
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("ConvertMultipleUrls")
		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfConverter As New PdfConverter()

			' set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' add header and footer
			If cbAddHeader.Checked Then
				AddHeader(pdfConverter)
			End If
			If cbAddFooter.Checked Then
				AddFooter(pdfConverter)
			End If

			' call the converter and get a Document object from URL
			Dim pdfDocument As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL1.Text.Trim())

			' get the conversion summary object from the event arguments
			Dim conversionSummary As ConversionSummary = pdfConverter.ConversionSummary

			' the PDF page where the previous conversion ended
			Dim lastPage As PdfPage = pdfDocument.Pages(conversionSummary.LastPageIndex)
			' the last rectangle in the last PDF page where the previous conversion ended
			Dim lastRectangle As RectangleF = conversionSummary.LastPageRectangle

			' the result of adding an element to a PDF page
			' ofers the index of the PDF page where the rendering ended 
			' and the bounding rectangle of the rendered content in the last page
			Dim addResult As AddElementResult = Nothing

			' the converter for the second URL
			Dim htmlToPdfURL2 As HtmlToPdfElement = Nothing

			If cbStartOnNewPage.Checked Then
				' render the HTML from the second URL on a new page after the first URL
				Dim newPage As PdfPage = pdfDocument.Pages.AddNewPage()
				htmlToPdfURL2 = New HtmlToPdfElement(0, 0, textBoxURL2.Text)
				addResult = newPage.AddElement(htmlToPdfURL2)
			Else
				' render the HTML from the second URL immediately after the first URL
				htmlToPdfURL2 = New HtmlToPdfElement(lastRectangle.Left, lastRectangle.Bottom, textBoxURL2.Text)
				addResult = lastPage.AddElement(htmlToPdfURL2)
			End If

			' the PDF page where the previous conversion ended
			lastPage = pdfDocument.Pages(addResult.EndPageIndex)

			' add a HTML string after all the rendered content
			Dim htmlStringToPdf As New HtmlToPdfElement(addResult.EndPageBounds.Left, addResult.EndPageBounds.Bottom, "<b><i>The rendered content ends here</i></b>", Nothing)

			lastPage.AddElement(htmlStringToPdf)

			Dim pdfBytes() As Byte = Nothing

			Try
				pdfBytes = pdfDocument.Save()
			Finally
				' close the Document to realease all the resources
				pdfDocument.Close()
			End Try

            ' send the generated PDF document to client browser

            ' get the object representing the HTTP response to browser
            Dim httpResponse As HttpResponse = HttpContext.Current.Response

            ' add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf")
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=ConvertMultipleUrls.pdf; size={0}", pdfBytes.Length.ToString()))

            ' write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes)

            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to PDF document stream
            httpResponse.End()
		End Sub

		Private Sub AddHeader(ByVal pdfConverter As PdfConverter)
			Dim thisPageURL As String = HttpContext.Current.Request.Url.AbsoluteUri
			Dim headerAndFooterHtmlUrl As String = thisPageURL.Substring(0, thisPageURL.LastIndexOf("/"c)) & "/HeaderFooter/HeaderAndFooterHtml.htm"

			'enable header
			pdfConverter.PdfDocumentOptions.ShowHeader = True
			' set the header height in points
			pdfConverter.PdfHeaderOptions.HeaderHeight = 60
			' set the header HTML area
            Dim headerHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                                      headerAndFooterHtmlUrl, 1024, 0)
            headerHtml.FitHeight = True
            pdfConverter.PdfHeaderOptions.AddElement(headerHtml)
		End Sub

		Private Sub AddFooter(ByVal pdfConverter As PdfConverter)
			Dim thisPageURL As String = HttpContext.Current.Request.Url.AbsoluteUri
			Dim headerAndFooterHtmlUrl As String = thisPageURL.Substring(0, thisPageURL.LastIndexOf("/"c)) & "/HeaderFooter/HeaderAndFooterHtml.htm"

			'enable footer
			pdfConverter.PdfDocumentOptions.ShowFooter = True
			' set the footer height in points
			pdfConverter.PdfFooterOptions.FooterHeight = 60
			'write the page number
            Dim footerText As TextElement = New TextElement(0, 30, "This is page &p; of &P;  ",
                                  New System.Drawing.Font(New System.Drawing.FontFamily("Times New Roman"), 10, System.Drawing.GraphicsUnit.Point))
            footerText.EmbedSysFont = True
            footerText.TextAlign = HorizontalTextAlign.Right
            pdfConverter.PdfFooterOptions.AddElement(footerText)

            ' set the footer HTML area
            Dim footerHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfFooterOptions.FooterHeight,
                    headerAndFooterHtmlUrl, 1024, 0)
            footerHtml.FitHeight = True
            pdfConverter.PdfFooterOptions.AddElement(footerHtml)
		End Sub
	End Class
End Namespace
