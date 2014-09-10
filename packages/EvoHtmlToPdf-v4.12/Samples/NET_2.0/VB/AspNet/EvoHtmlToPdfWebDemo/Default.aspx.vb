Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class [Default]
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("GettingStarted")
		End Sub

		''' <summary>
		''' Convert the HTML code from the specified URL to a PDF document and send the 
		''' document to the browser
		''' </summary>
		Private Sub ConvertURLToPDF()
			Dim urlToConvert As String = textBoxWebPageURL.Text.Trim()

			' Create the PDF converter. Optionally the HTML viewer width can be specified as parameter
			' The default HTML viewer width is 1024 pixels.
			Dim pdfConverter As New PdfConverter()

			' set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

            ' set the converter options - optional
            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal
            pdfConverter.PdfDocumentOptions.PdfPageOrientation = PdfPageOrientation.Portrait


            ' set if header and footer are shown in the PDF - optional - default is false 
            pdfConverter.PdfDocumentOptions.ShowHeader = cbAddHeader.Checked
            pdfConverter.PdfDocumentOptions.ShowFooter = cbAddFooter.Checked
            ' set if the HTML content is resized if necessary to fit the PDF page width - default is true
            pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked

            ' set the embedded fonts option - optional - default is false
            pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked
            ' set the live HTTP links option - optional - default is true
            pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinks.Checked

            ' set if the JavaScript is enabled during conversion to a PDF - default is true
            pdfConverter.JavaScriptEnabled = cbClientScripts.Checked

            ' set if the images in PDF are compressed with JPEG to reduce the PDF document size - default is true
            pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked

            ' enable auto-generated bookmarks for a specified list of HTML selectors (e.g. H1 and H2)
            If cbBookmarks.Checked Then
                pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = New String() {"H1", "H2"}
            End If

            ' add HTML header
            If cbAddHeader.Checked Then
                AddHeader(pdfConverter)
            End If
            ' add HTML footer
            If cbAddFooter.Checked Then
                AddFooter(pdfConverter)
            End If

            ' optionally wait for asynchronous items
            pdfConverter.ConversionDelay = 2

            ' Performs the conversion and get the pdf document bytes that can 
            ' be saved to a file or sent as a browser response
            Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromUrl(urlToConvert)

            ' send the generated PDF document to client browser

            ' get the object representing the HTTP response to browser
            Dim httpResponse As HttpResponse = HttpContext.Current.Response

            ' add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf")
            If radioAttachment.Checked Then
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=GettingStarted.pdf; size={0}", pdfBytes.Length.ToString()))
            Else
                httpResponse.AddHeader("Content-Disposition", String.Format("inline; filename=GettingStarted.pdf; size={0}", pdfBytes.Length.ToString()))
            End If

            ' write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes)

            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to PDF document stream
            httpResponse.End()
        End Sub


        ''' <summary>
        ''' Convert the HTML code from the specified URL to a PNG image and send the 
        ''' image as an attachment to the browser
        ''' </summary>
        Private Sub ConvertURLToImage()
            Dim urlToConvert As String = textBoxWebPageURL.Text.Trim()

            ' Create the Image converter. Optionally the HTML viewer width can be specified as parameter
            ' The default HTML viewer width is 1024 pixels.
            Dim imgConverter As New ImgConverter()

            ' set the license key
            imgConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

            ' set if the JavaScript is enabled during conversion - default is true
            imgConverter.JavaScriptEnabled = cbClientScripts.Checked

            ' Performs the conversion and get the image bytes that can be further 
            ' saved to a file or sent as a response to browser
            Dim imgBytes() As Byte = imgConverter.GetImageBytesFromUrl(urlToConvert, System.Drawing.Imaging.ImageFormat.Png)

            ' send the image as a response to the browser for download
            Dim response As HttpResponse = HttpContext.Current.Response
            response.Clear()
            response.AddHeader("Content-Type", "image/png")
            response.AddHeader("Content-Disposition", String.Format("attachment; filename=GettingStarted.png; size={0}", imgBytes.Length.ToString()))
            response.BinaryWrite(imgBytes)
            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to image stream
            response.End()
        End Sub


        ''' <summary>
        ''' Convert the specified HTML string to a PDF document and send the 
        ''' document to the browser
        ''' </summary>
        Private Sub ConvertHTMLStringToPDF()
            Dim htmlString As String = textBoxHTMLCode.Text
            Dim baseURL As String = textBoxBaseURL.Text.Trim()
            Dim selectablePDF As Boolean = radioConvertToSelectablePDF.Checked

            ' Create the PDF converter. Optionally the HTML viewer width can be specified as parameter
            ' The default HTML viewer width is 1024 pixels.
            Dim pdfConverter As New PdfConverter()

            ' set the license key
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

            ' set the converter options
            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4
            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal
            pdfConverter.PdfDocumentOptions.PdfPageOrientation = PdfPageOrientation.Portrait

            ' set if header and footer are shown in the PDF - optional - default is false 
            pdfConverter.PdfDocumentOptions.ShowHeader = cbAddHeader.Checked
            pdfConverter.PdfDocumentOptions.ShowFooter = cbAddFooter.Checked
            ' set if the HTML content is resized if necessary to fit the PDF page width - default is true
            pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked
            ' 
            ' set the embedded fonts option - optional - default is false
            pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked
            ' set the live HTTP links option - optional - default is true
            pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinks.Checked

            ' set if the JavaScript is enabled during conversion to a PDF - default is true
            pdfConverter.JavaScriptEnabled = cbClientScripts.Checked

            ' set if the images in PDF are compressed with JPEG to reduce the PDF document size - default is true
            pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked

            ' enable auto-generated bookmarks for a specified list of tags (e.g. H1 and H2)
            If cbBookmarks.Checked Then
                pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = New String() {"H1", "H2"}
            End If

            ' add HTML header
            If cbAddHeader.Checked Then
                AddHeader(pdfConverter)
            End If
            ' add HTML footer
            If cbAddFooter.Checked Then
                AddFooter(pdfConverter)
            End If

            ' Performs the conversion and get the pdf document bytes that can be further 
            ' saved to a file or sent as response to browser
            '
            ' The baseURL parameter helps the converter to get the CSS files and images
            ' referenced by a relative URL in the HTML string.  
            Dim pdfBytes() As Byte = Nothing
            If baseURL.Length > 0 Then
                pdfBytes = pdfConverter.GetPdfBytesFromHtmlString(htmlString, baseURL)
            Else
                pdfBytes = pdfConverter.GetPdfBytesFromHtmlString(htmlString)
            End If

            ' send the generated PDF document to client browser

            ' get the object representing the HTTP response to browser
            Dim httpResponse As HttpResponse = HttpContext.Current.Response

            ' add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf")
            If radioAttachment.Checked Then
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=GettingStarted.pdf; size={0}", pdfBytes.Length.ToString()))
            Else
                httpResponse.AddHeader("Content-Disposition", String.Format("inline; filename=GettingStarted.pdf; size={0}", pdfBytes.Length.ToString()))
            End If

            ' write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes)

            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to PDF document stream
            httpResponse.End()
        End Sub


        ''' <summary>
        ''' Convert the specified HTML string to a PNG image and send the 
        ''' image as an attachment to the browser
        ''' </summary>
        Private Sub ConvertHTMLStringToImage()
            Dim htmlString As String = textBoxHTMLCode.Text
            Dim baseURL As String = textBoxBaseURL.Text.Trim()

            ' Create the Image converter. Optionally the HTML viewer width can be specified as parameter
            ' The default HTML viewer width is 1024 pixels.
            Dim imgConverter As New ImgConverter()

            ' set the license key
            imgConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

            ' set if the JavaScript is enabled during conversion - default is true
            imgConverter.JavaScriptEnabled = cbClientScripts.Checked

            ' Performs the conversion and get the image bytes that can be further 
            ' saved to a file or sent as a browser response
            '
            ' The baseURL parameter helps the converter to get the CSS files and images
            ' referenced by a relative URL in the HTML string.  
            Dim imgBytes() As Byte = Nothing
            If baseURL.Length > 0 Then
                imgBytes = imgConverter.GetImageBytesFromHtmlString(htmlString, System.Drawing.Imaging.ImageFormat.Png, baseURL)
            Else
                imgBytes = imgConverter.GetImageBytesFromHtmlString(htmlString, System.Drawing.Imaging.ImageFormat.Png)
            End If

            ' send the image as a response to the browser for download
            Dim response As HttpResponse = HttpContext.Current.Response
            response.Clear()
            response.AddHeader("Content-Type", "image/png")
            response.AddHeader("Content-Disposition", String.Format("attachment; filename=GettingStarted.png; size={0}", imgBytes.Length.ToString()))
            response.BinaryWrite(imgBytes)
            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to image stream
            response.End()
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
            headerHtml.EmbedFonts = cbEmbedFonts.Checked
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
            footerHtml.EmbedFonts = cbEmbedFonts.Checked
            pdfConverter.PdfFooterOptions.AddElement(footerHtml)

		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			If radioConvertURL.Checked Then
				' convert the HTML from a specified URL
				If radioConvertToImage.Checked Then
					ConvertURLToImage() ' convert URL to image
				Else
					ConvertURLToPDF() ' convert URL to PDF
				End If
			Else
				' convert the specified HTML string
				If radioConvertToImage.Checked Then
					ConvertHTMLStringToImage() ' convert HTML string to image
				Else
					ConvertHTMLStringToPDF() ' convert HTML string to PDF
				End If
			End If
		End Sub

		Protected Sub radioConvertURL_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			pnlConvertURL.Visible = radioConvertURL.Checked
			pnlConvertHTML.Visible = Not radioConvertURL.Checked
		End Sub

		Protected Sub radioConvertHTML_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			pnlConvertURL.Visible = Not radioConvertHTML.Checked
			pnlConvertHTML.Visible = radioConvertHTML.Checked
		End Sub
	End Class
End Namespace
