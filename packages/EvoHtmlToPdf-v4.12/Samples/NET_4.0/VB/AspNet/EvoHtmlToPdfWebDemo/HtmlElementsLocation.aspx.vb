Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class HtmlElementsLocation
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("HtmlElementsLocation")
		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfConverter As New PdfConverter()

			' set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' inform the converter about the HTML elements for which we want the location in PDF
			' in this sample we want the location of IMG, H1 and H2 elements and the elements with ID 
			' equal to 'id1' or 'id2'
			pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = New String() { "IMG", "H1", "H2", "#id1", "#id2" }

			' call the converter and get a Document object from URL
			Dim pdfDocument As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxWebPageURL.Text.Trim())

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
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlElementsLocation.pdf; size={0}", pdfBytes.Length.ToString()))

            ' write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes)

            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to PDF document stream
            httpResponse.End()
		End Sub
	End Class
End Namespace
