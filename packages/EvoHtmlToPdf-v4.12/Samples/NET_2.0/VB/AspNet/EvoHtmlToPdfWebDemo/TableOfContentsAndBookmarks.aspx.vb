Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class TableOfContentsAndBookmarks
		Inherits System.Web.UI.Page
		Private Const TOC_ENTRIES_COUNT As Integer = 16
		Private Const PAGE_NUMBER_FONT_SIZE As Integer = 10

		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("TableOfContents")
		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfConverter As New PdfConverter()

			' show the bookmarks when the document is opened
			pdfConverter.PdfViewerPreferences.PageMode = ViewerPageMode.UseOutlines

			' set top and bottom page margins
			pdfConverter.PdfDocumentOptions.TopMargin = 5
			pdfConverter.PdfDocumentOptions.BottomMargin = 5

			' Inform the converter about the HTML elements for which we want the location in PDF
			' In this sample we want the location of the entries in the Table of Contents
			' The HTML ID of each entry in the table of contents is of form TOCEntry_{EntryIndex}_ID
			' the HTML ID of each target of a table of contents entry is of form TOCEntry_{EntryIndex}_Target_ID

			' Both toc entries and toc entries targets locations in PDF will be retrieved
			' and therefore the number of IDs is twice TOC entries number
			pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors = New String(2 * TOC_ENTRIES_COUNT - 1){}

			Dim mappingsTableIdx As Integer = 0
			For tocEntryIndex As Integer = 1 To TOC_ENTRIES_COUNT
				' add the HTML ID of the TOC entry element to the list of elements for which we want the PDF location
				Dim tocEntryID As String = String.Format("#TOCEntry_{0}_ID", tocEntryIndex)
				pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors(mappingsTableIdx) = tocEntryID
				mappingsTableIdx += 1

				' add the HTML ID of the TOC entry target element to the list of elements for which we want the PDF location
				Dim tocEntryTargetID As String = String.Format("#TOCEntry_{0}_Target_ID", tocEntryIndex)
				pdfConverter.HtmlElementsMappingOptions.HtmlElementSelectors(mappingsTableIdx) = tocEntryTargetID
				mappingsTableIdx += 1
			Next tocEntryIndex

			' set bookmark options
			pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = New String() { "A[class=""bookmark""]" }

			' the URL of the HTML document to convert
			Dim thisPageURL As String = HttpContext.Current.Request.Url.AbsoluteUri
			Dim htmlBookFilePath As String = thisPageURL.Substring(0, thisPageURL.LastIndexOf("/"c)) & "/HtmlBook/Book.htm"

			' call the converter and get a Document object from URL
			Dim pdfDocument As Document = pdfConverter.GetPdfDocumentObjectFromUrl(htmlBookFilePath)

			' Create a font used to write the page numbers in the table of contents
			Dim pageNumberFont As PdfFont = pdfDocument.Fonts.Add(New Font("Arial", PAGE_NUMBER_FONT_SIZE, FontStyle.Bold, GraphicsUnit.Point), True)

			' get the right edge of the table of contents where to position the page numbers
			Dim tocEntryMaxRight As Single = 0.0f
			For tocEntryIdx As Integer = 1 To TOC_ENTRIES_COUNT
				Dim tocEntryID As String = String.Format("TOCEntry_{0}_ID", tocEntryIdx)
				Dim tocEntryLocation As HtmlElementMapping = pdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByHtmlId(tocEntryID)
				If tocEntryLocation.PdfRectangles(0).Rectangle.Right > tocEntryMaxRight Then
					tocEntryMaxRight = tocEntryLocation.PdfRectangles(0).Rectangle.Right
				End If
			Next tocEntryIdx


			' Add page number for each entry in the table of contents
			For tocEntryIdx As Integer = 1 To TOC_ENTRIES_COUNT
				Dim tocEntryID As String = String.Format("TOCEntry_{0}_ID", tocEntryIdx)
				Dim tocEntryTargetID As String = String.Format("TOCEntry_{0}_Target_ID", tocEntryIdx)

				Dim tocEntryLocation As HtmlElementMapping = pdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByHtmlId(tocEntryID)
				Dim tocEntryTargetLocation As HtmlElementMapping = pdfConverter.HtmlElementsMappingOptions.HtmlElementsMappingResult.GetElementByHtmlId(tocEntryTargetID)

				' get the TOC entry page and bounds
				Dim tocEntryPdfPage As PdfPage = pdfDocument.Pages(tocEntryLocation.PdfRectangles(0).PageIndex)
				Dim tocEntryPdfRectangle As RectangleF = tocEntryLocation.PdfRectangles(0).Rectangle

				' get the page number of target where the TOC entry points
				Dim tocEntryTargetPageNumber As Integer = tocEntryTargetLocation.PdfRectangles(0).PageIndex + 1

				' add dashed line from text entry to the page number
                Dim lineToNumber As New LineElement(tocEntryPdfRectangle.Right + 5, tocEntryPdfRectangle.Y + tocEntryPdfRectangle.Height / 2, tocEntryMaxRight + 80, tocEntryPdfRectangle.Y + tocEntryPdfRectangle.Height / 2)
				lineToNumber.LineStyle.LineWidth = 1
				lineToNumber.LineStyle.LineDashStyle = LineDashStyle.Dash
				lineToNumber.ForeColor = Color.Green
				tocEntryPdfPage.AddElement(lineToNumber)

				' create the page number text element to the right of the TOC entry
                Dim pageNumberTextEement As New TextElement(tocEntryMaxRight + 85, tocEntryPdfRectangle.Y, -1, tocEntryPdfRectangle.Height, tocEntryTargetPageNumber.ToString(), pageNumberFont)
				pageNumberTextEement.TextAlign = HorizontalTextAlign.Left
				pageNumberTextEement.VerticalTextAlign = VerticalTextAlign.Middle
				pageNumberTextEement.ForeColor = Color.Blue

				' add the page number to the right of the TOC entry
				tocEntryPdfPage.AddElement(pageNumberTextEement)
			Next tocEntryIdx

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
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=TableOfContents.pdf; size={0}", pdfBytes.Length.ToString()))

            ' write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes)

            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to PDF document stream
            httpResponse.End()
		End Sub
	End Class
End Namespace
