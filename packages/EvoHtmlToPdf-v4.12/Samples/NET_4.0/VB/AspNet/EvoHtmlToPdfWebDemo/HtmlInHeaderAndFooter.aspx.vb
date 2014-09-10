Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class HtmlInHeaderAndFooter
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("HtmlInHeaderAndFooter")
		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfConverter As New PdfConverter()

			' set the license key
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' show header and footer in the rendered PDF
			pdfConverter.PdfDocumentOptions.ShowHeader = True
			pdfConverter.PdfDocumentOptions.ShowFooter = True

			' set the header height in points
			pdfConverter.PdfHeaderOptions.HeaderHeight = 60

			Dim thisPageURL As String = HttpContext.Current.Request.Url.AbsoluteUri
			Dim headerAndFooterHtmlUrl As String = thisPageURL.Substring(0, thisPageURL.LastIndexOf("/"c)) & "/HeaderFooter/HeaderAndFooterHtml.htm"

			' set the header HTML area
            Dim headerHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight, headerAndFooterHtmlUrl, 1024, 0)
            headerHtml.FitHeight = True
            pdfConverter.PdfHeaderOptions.AddElement(headerHtml)

			' set the footer height in points
			pdfConverter.PdfFooterOptions.FooterHeight = 60
			'write the page number
            Dim footerTextElement As TextElement = New TextElement(0, 30, "This is page &p; of &P;  ",
                             New Font(New FontFamily("Times New Roman"), 10, GraphicsUnit.Point))
            footerTextElement.TextAlign = HorizontalTextAlign.Right
            pdfConverter.PdfFooterOptions.AddElement(footerTextElement)

            ' set the footer HTML area
            Dim footerHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfFooterOptions.FooterHeight, headerAndFooterHtmlUrl, 1024, 0)
            footerHtml.FitHeight = True
            pdfConverter.PdfFooterOptions.AddElement(footerHtml)

			If Not cbAlternateHeaderAndFooter.Checked Then
				' Performs the conversion and get the pdf document bytes that can 
				' be saved to a file or sent as a browser response
				Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromUrl(textBoxWebPageURL.Text)

                ' send the generated PDF document to client browser

                ' get the object representing the HTTP response to browser
                Dim httpResponse As HttpResponse = HttpContext.Current.Response

                ' add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf")
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlInHeaderAndFooter.pdf; size={0}", pdfBytes.Length.ToString()))

                ' write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes)

                ' Note: it is important to end the response, otherwise the ASP.NET
                ' web page will render its content to PDF document stream
                httpResponse.End()
			Else
				' set an alternate header and footer on the even pages

				' call the converter and get a Document object from URL
				Dim pdfDocument As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxWebPageURL.Text)

				If pdfDocument.Pages.Count >= 2 Then
					' get the alternate header and footer width and height
					' the width is given by the PDF page width
					Dim altHeaderFooterWidth As Single = pdfDocument.Pages(0).ClientRectangle.Width
					' the height is the same with the document header height from the PdfConverter object
					Dim altHeaderHeight As Single = pdfConverter.PdfHeaderOptions.HeaderHeight
					Dim altFooterHeight As Single = pdfConverter.PdfFooterOptions.FooterHeight

					' create the alternate header template
					Dim altHeaderTemplate As Template = pdfDocument.Templates.AddNewTemplate(altHeaderFooterWidth, altHeaderHeight)

					Dim alternateHeaderAndFooterHtmlUrl As String = thisPageURL.Substring(0, thisPageURL.LastIndexOf("/"c)) & "/HeaderFooter/HeaderAndFooterHtml2.htm"

					' add html to the header
					Dim altHeaderHtml As New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight, alternateHeaderAndFooterHtmlUrl, 1024, 0)
					altHeaderHtml.FitHeight = True
					altHeaderTemplate.AddElement(altHeaderHtml)

					' add a horizontal line to the bottom of the header
					Dim headerLine As New LineElement(0, altHeaderHeight, altHeaderFooterWidth, altHeaderHeight)
					altHeaderTemplate.AddElement(headerLine)

					' add page numbering to the left of the header
					Dim pageNumberFont As PdfFont = pdfDocument.Fonts.Add(New Font(New FontFamily("Times New Roman"), 10, GraphicsUnit.Point))
					Dim pageNumbering As New TextElement(10, 10, "Page &p; of &P;", pageNumberFont, Color.Blue)

					altHeaderTemplate.AddElement(pageNumbering)

					' create the alternate footer template
					Dim altFooterTemplate As Template = pdfDocument.Templates.AddNewTemplate(altHeaderFooterWidth, altFooterHeight)

					' add html to the footer
					Dim altFooterHtml As New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight, alternateHeaderAndFooterHtmlUrl, 1024, 0)
					altFooterHtml.FitHeight = True
					altFooterTemplate.AddElement(altFooterHtml)

					For pageIndex As Integer = 1 To pdfDocument.Pages.Count - 1 Step 2
						Dim pdfPage As PdfPage = pdfDocument.Pages(pageIndex)

                        pdfPage.Header = altHeaderTemplate
                        pdfPage.Footer = altFooterTemplate
					Next pageIndex
				End If

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
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlInHeaderAndFooter.pdf; size={0}", pdfBytes.Length.ToString()))

                ' write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes)

                ' Note: it is important to end the response, otherwise the ASP.NET
                ' web page will render its content to PDF document stream
                httpResponse.End()
			End If
		End Sub
	End Class
End Namespace
