Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class HtmlToPdfFeaturesDemo
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("HtmlToPdfFeatures")

			lblConvertMessage.Visible = False

			If Not IsPostBack Then
				LoadImageFormats()
				LoadPDFFormats()
				LoadPageOrientations()
				LoadColors()
				LoadCompressionLevels()
				LoadPdfSubsets()
			End If
		End Sub

		''' <summary>
		''' Create a PdfConverter object
		''' </summary>
		''' <returns></returns>
		Private Function GetPdfConverter() As PdfConverter
			Dim pdfConverter As New PdfConverter()

			' set the HTML viewer width and height in pixels
			' the default value is 1024 pixels for width and 0 for height 
			pdfConverter.HtmlViewerWidth = Integer.Parse(textBoxHtmlViewerWidth.Text.Trim())
			pdfConverter.HtmlViewerHeight = Integer.Parse(textBoxHtmlViewerHeight.Text.Trim())

			'set the PDF page size - default value is A4
            pdfConverter.PdfDocumentOptions.PdfPageSize = GetSelectedPageSize()
			' set the PDF compression level - default value is Normal
			pdfConverter.PdfDocumentOptions.PdfCompressionLevel = CType(System.Enum.Parse(GetType(PdfCompressionLevel), ddlCompressionLevel.SelectedValue), PdfCompressionLevel)
			' set the PDF page orientation (portrait or landscape) - default value is portrait
			pdfConverter.PdfDocumentOptions.PdfPageOrientation = CType(System.Enum.Parse(GetType(PdfPageOrientation), ddlPageOrientation.SelectedValue.ToString()), PdfPageOrientation)
			'set the PDF standard used to generate the PDF document - default value is Full
            pdfConverter.PdfDocumentOptions.PdfStandardSubset = GetPdfStandard(ddlPdfSubset.SelectedItem.ToString())
			' show or hide header and footer - default value is false
			pdfConverter.PdfDocumentOptions.ShowHeader = cbShowheader.Checked
			pdfConverter.PdfDocumentOptions.ShowFooter = cbShowFooter.Checked

			'set the PDF document margins - default margins are 0
			pdfConverter.PdfDocumentOptions.LeftMargin = Integer.Parse(textBoxLeftMargin.Text.Trim())
			pdfConverter.PdfDocumentOptions.RightMargin = Integer.Parse(textBoxRightMargin.Text.Trim())
			pdfConverter.PdfDocumentOptions.TopMargin = Integer.Parse(textBoxTopMargin.Text.Trim())
			pdfConverter.PdfDocumentOptions.BottomMargin = Integer.Parse(textBoxBottomMargin.Text.Trim())

			' set if the HTTP links are enabled in the generated PDF - default value is true
			pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinksEnabled.Checked

			' set if the HTML content is resized if necessary to fit the PDF page width - default is true
			pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked

			' set if the PDF page should be automatically resized to the size of the HTML content when FitWidth is false
			pdfConverter.PdfDocumentOptions.AutoSizePdfPage = True

			' embed the true type fonts in the generated PDF document - default value is false
			pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked

			' compress the images in PDF with JPEG to reduce the PDF document size - default is true
			pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked

			' set if the JavaScript is enabled during conversion - default value is true
			pdfConverter.JavaScriptEnabled = cbScriptsEnabled.Checked

			' set if the converter should try to avoid breaking the images between PDF pages - default value is false
            pdfConverter.PdfDocumentOptions.AvoidImageBreak = cbAvoidImageBreak.Checked

			' set the automatic bookmarks options - by default no bookmarks are automatically generated
			If cbBookmarks.Checked Then
				pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = New String() { "h1", "h2" }
			Else
				pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = Nothing
			End If

			' set HTTP authentication username and password
			' by default these properties are not set
			If textBoxAuthUsername.Text.Trim().Length > 0 Then
				pdfConverter.AuthenticationOptions.Username = textBoxAuthUsername.Text.Trim()
			End If
			If textBoxAuthPassword.Text.Trim().Length > 0 Then
				pdfConverter.AuthenticationOptions.Password = textBoxAuthPassword.Text.Trim()
			End If

			' set conversion delay which can be used to allow more time for JavaScript and redirects to execute before conversion
			' the default value is 0
			pdfConverter.ConversionDelay = Integer.Parse(textBoxConversionDelay.Text.Trim())

			' set the navigation timout in seconds - the default value is 45 seconds
			pdfConverter.NavigationTimeout = Integer.Parse(textBoxNavigationTimeout.Text.Trim())

			' set header options
			If pdfConverter.PdfDocumentOptions.ShowHeader Then
				pdfConverter.PdfHeaderOptions.HeaderHeight = Single.Parse(textBoxHeaderHeight.Text.Trim())

				AddHeaderElements(pdfConverter)
			End If

			' set footer options
			If pdfConverter.PdfDocumentOptions.ShowFooter Then
				pdfConverter.PdfFooterOptions.FooterHeight = Single.Parse(textBoxFooterHeight.Text.Trim())

				AddFooterElements(pdfConverter)
			End If

			Return pdfConverter
        End Function

        Private Function GetSelectedPageSize() As PdfPageSize

            Select Case ddlPDFPageFormat.SelectedItem.ToString()

                Case "A0"
                    Return PdfPageSize.A0
                Case "A1"
                    Return PdfPageSize.A1
                Case "A10"
                    Return PdfPageSize.A10
                Case "A2"
                    Return PdfPageSize.A2
                Case "A3"
                    Return PdfPageSize.A3
                Case "A4"
                    Return PdfPageSize.A4
                Case "A5"
                    Return PdfPageSize.A5
                Case "A6"
                    Return PdfPageSize.A6
                Case "A7"
                    Return PdfPageSize.A7
                Case "A8"
                    Return PdfPageSize.A8
                Case "A9"
                    Return PdfPageSize.A9
                Case "ArchA"
                    Return PdfPageSize.ArchA
                Case "ArchB"
                    Return PdfPageSize.ArchB
                Case "ArchC"
                    Return PdfPageSize.ArchC
                Case "ArchD"
                    Return PdfPageSize.ArchD
                Case "ArchE"
                    Return PdfPageSize.ArchE
                Case "B0"
                    Return PdfPageSize.B0
                Case "B1"
                    Return PdfPageSize.B1
                Case "B2"
                    Return PdfPageSize.B2
                Case "B3"
                    Return PdfPageSize.B3
                Case "B4"
                    Return PdfPageSize.B4
                Case "B5"
                    Return PdfPageSize.B5
                Case "Flsa"
                    Return PdfPageSize.Flsa
                Case "HalfLetter"
                    Return PdfPageSize.HalfLetter
                Case "Ledger"
                    Return PdfPageSize.Ledger
                Case "Legal"
                    Return PdfPageSize.Legal
                Case "Letter"
                    Return PdfPageSize.Letter
                Case "Letter11x17"
                    Return PdfPageSize.Letter11x17
                Case "Note"
                    Return PdfPageSize.Note
                Case Else
                    Return PdfPageSize.A4
            End Select
        End Function

		Private Sub AddHeaderElements(ByVal pdfConverter As PdfConverter)
            ' set the header HTML area
            Dim headerHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                    "<b>HTML in Header</b>", Nothing, 1024, 0)
            headerHtml.FitHeight = True
            headerHtml.EmbedFonts = cbEmbedFonts.Checked
            pdfConverter.PdfHeaderOptions.AddElement(headerHtml)

            If cbDrawHeaderLine.Checked Then
                ' set the header line
                Dim pdfPageWidth As Single = 0
                If pdfConverter.PdfDocumentOptions.PdfPageOrientation = PdfPageOrientation.Portrait Then
                    pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageSize.Width
                Else
                    pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageSize.Height
                End If

                Dim headerLine As LineElement = New LineElement(0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                            pdfPageWidth - pdfConverter.PdfDocumentOptions.LeftMargin - pdfConverter.PdfDocumentOptions.RightMargin,
                            pdfConverter.PdfHeaderOptions.HeaderHeight)
                headerLine.LineStyle.LineWidth = 0.5F
                headerLine.ForeColor = Color.FromKnownColor(CType(System.Enum.Parse(GetType(KnownColor), ddlHeaderLineColor.SelectedItem.ToString()), KnownColor))
                pdfConverter.PdfHeaderOptions.AddElement(headerLine)
            End If
        End Sub

		Private Sub AddFooterElements(ByVal pdfConverter As PdfConverter)
            'write the page number
            Dim footerText As TextElement = New TextElement(0, pdfConverter.PdfFooterOptions.FooterHeight - 15, "This is page &p; of &P;  ",
                New System.Drawing.Font(New System.Drawing.FontFamily("Times New Roman"), 10, System.Drawing.GraphicsUnit.Point))
            footerText.EmbedSysFont = True
            footerText.TextAlign = HorizontalTextAlign.Right
            pdfConverter.PdfFooterOptions.AddElement(footerText)

            ' set the footer HTML area
            Dim footerHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfFooterOptions.FooterHeight,
                        "<i>HTML in Footer</i>", Nothing, 1024, 0)
            footerHtml.FitHeight = True
            footerHtml.EmbedFonts = cbEmbedFonts.Checked
            pdfConverter.PdfFooterOptions.AddElement(footerHtml)

            If cbDrawFooterLine.Checked Then
                ' set the footer line
                Dim pdfPageWidth As Single = 0
                If pdfConverter.PdfDocumentOptions.PdfPageOrientation = PdfPageOrientation.Portrait Then
                    pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageSize.Width
                Else
                    pdfPageWidth = pdfConverter.PdfDocumentOptions.PdfPageSize.Height
                End If

                Dim footerLine As LineElement = New LineElement(0, 0,
                            pdfPageWidth - pdfConverter.PdfDocumentOptions.LeftMargin - pdfConverter.PdfDocumentOptions.RightMargin, 0)
                footerLine.LineStyle.LineWidth = 0.5F
                footerLine.ForeColor = Color.FromKnownColor(CType(System.Enum.Parse(GetType(KnownColor), ddlFooterLineColor.SelectedItem.ToString()), KnownColor))
                pdfConverter.PdfFooterOptions.AddElement(footerLine)
            End If
        End Sub

		Private Function GetImgConverter() As ImgConverter
			Dim imgConverter As New ImgConverter()

			' set the HTML viewer width and height in pixels
			' the default value is 1024 pixels for width and 0 for height 
			imgConverter.HtmlViewerWidth = Integer.Parse(textBoxHtmlViewerWidth.Text.Trim())
			imgConverter.HtmlViewerHeight = Integer.Parse(textBoxHtmlViewerHeight.Text.Trim())

			' set if the JavaScript is executed during conversion - default value is true
			imgConverter.JavaScriptEnabled = cbScriptsEnabled.Checked

			Return imgConverter
		End Function

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			lblConvertMessage.Visible = False

			If Not Page.IsValid Then
				Return
			End If

			Dim urlToConvert As String = textBoxWebPageURL.Text.Trim()

			If radioConvertToPdf.Checked Then
				Dim pdfConverter As PdfConverter = GetPdfConverter()

				' set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

                ' Performs the conversion and get the pdf document bytes that can 
                ' be saved to a file or sent as a browser response
                Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromUrl(urlToConvert)

                ' send the generated PDF document to client browser

                ' get the object representing the HTTP response to browser
                Dim httpResponse As HttpResponse = HttpContext.Current.Response

                ' add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf")
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=HtmlToPdfFeatures.pdf; size={0}", pdfBytes.Length.ToString()))

                ' write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes)

                ' Note: it is important to end the response, otherwise the ASP.NET
                ' web page will render its content to PDF document stream
                httpResponse.End()
            Else
                Dim imgConverter As ImgConverter = GetImgConverter()

                ' set the license key
                imgConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

                Dim imageBytes() As Byte = imgConverter.GetImageBytesFromUrl(urlToConvert, GetImageFormat(ddlImageFormat.SelectedValue))

                Dim imageName As String = "HtmlToImageFeatures." & ddlImageFormat.SelectedValue

                Dim response As HttpResponse = HttpContext.Current.Response
                response.Clear()
                response.AddHeader("Content-Type", "binary/octet-stream")
                response.AddHeader("Content-Disposition", String.Format("attachment; filename={0}; size={1}", imageName, imageBytes.Length.ToString()))
                response.BinaryWrite(imageBytes)
                ' Note: it is important to end the response, otherwise the ASP.NET
                ' web page will render its content to image stream
                response.End()
			End If
		End Sub

		Protected Sub lnkBtnSettings_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not Page.IsValid Then
				Return
			End If

			If pnlRenderMoreOptions.Visible Then
				pnlRenderMoreOptions.Visible = False
				lnkBtnSettings.Text = "More Converter Features >>"
			Else
				pnlRenderMoreOptions.Visible = True
				lnkBtnSettings.Text = "<< Hide Features"
			End If
		End Sub

		Private Sub LoadImageFormats()
			Dim imageFormats() As String = { "Png", "Jpeg", "Bmp", "Gif", "Tiff" }
			ddlImageFormat.DataSource = imageFormats
			ddlImageFormat.DataBind()
			ddlImageFormat.SelectedValue = "Png"
		End Sub

		Private Function GetImageFormat(ByVal imageFormatName As String) As System.Drawing.Imaging.ImageFormat
			Select Case imageFormatName
				Case "Png"
					Return System.Drawing.Imaging.ImageFormat.Png
				Case "Jpeg"
					Return System.Drawing.Imaging.ImageFormat.Jpeg
				Case "Bmp"
					Return System.Drawing.Imaging.ImageFormat.Bmp
				Case "Gif"
					Return System.Drawing.Imaging.ImageFormat.Gif
				Case "Tiff"
					Return System.Drawing.Imaging.ImageFormat.Tiff
				Case Else
					Return System.Drawing.Imaging.ImageFormat.Png

			End Select
		End Function

		Private Sub LoadCompressionLevels()
			Dim pdfCompressionLevels() As String = System.Enum.GetNames(GetType(PdfCompressionLevel))
			ddlCompressionLevel.DataSource = pdfCompressionLevels
			ddlCompressionLevel.DataBind()
			ddlCompressionLevel.SelectedValue = PdfCompressionLevel.Normal.ToString()
		End Sub

		Private Sub LoadPageOrientations()
			Dim pdfPageOrientations() As String = System.Enum.GetNames(GetType(PdfPageOrientation))
			ddlPageOrientation.DataSource = pdfPageOrientations
			ddlPageOrientation.DataBind()
			ddlPageOrientation.SelectedValue = PdfPageOrientation.Portrait.ToString()
		End Sub

		Private Sub LoadPDFFormats()
            ddlPDFPageFormat.SelectedValue = "A4"
		End Sub

		Private Sub LoadColors()
			Dim colors() As String = System.Enum.GetNames(GetType(KnownColor))

			ddlHeaderLineColor.DataSource = colors
			ddlHeaderLineColor.DataBind()
			ddlHeaderLineColor.SelectedValue = KnownColor.Black.ToString()

			ddlFooterLineColor.DataSource = colors
			ddlFooterLineColor.DataBind()
			ddlFooterLineColor.SelectedValue = KnownColor.Black.ToString()
		End Sub

        Private pdfStandards() As String = {"PDF", "PDF/A", "PDF/X"}
		Private Function GetPdfStandard(ByVal standardName As String) As PdfStandardSubset
			Select Case standardName
				Case "PDF"
					Return PdfStandardSubset.Full
				Case "PDF/A"
					Return PdfStandardSubset.Pdf_A_1b
                Case "PDF/X"
                    Return PdfStandardSubset.Pdf_X_1a
                Case Else
                    Return PdfStandardSubset.Full

            End Select
		End Function

		Private Sub LoadPdfSubsets()
			ddlPdfSubset.DataSource = pdfStandards
			ddlPdfSubset.DataBind()
			ddlPdfSubset.SelectedValue = "PDF"
		End Sub

		Protected Sub radioConvertToPdf_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			pnlImageRenderOptions.Visible = Not(CType(sender, RadioButton)).Checked
			pnlPDFRenderOptions.Visible = (CType(sender, RadioButton)).Checked
			cbBookmarks.Visible = Not radioConvertToImage.Checked
			cbLiveLinksEnabled.Visible = cbBookmarks.Visible
			cbFitWidth.Visible = cbLiveLinksEnabled.Visible
			cbJpegCompression.Visible = cbFitWidth.Visible
			cbEmbedFonts.Visible = cbJpegCompression.Visible
		End Sub

		Protected Sub radioConvertToImage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			pnlImageRenderOptions.Visible = (CType(sender, RadioButton)).Checked
			pnlPDFRenderOptions.Visible = Not(CType(sender, RadioButton)).Checked
			cbBookmarks.Visible = Not radioConvertToImage.Checked
			cbLiveLinksEnabled.Visible = cbBookmarks.Visible
			cbFitWidth.Visible = cbLiveLinksEnabled.Visible
			cbJpegCompression.Visible = cbFitWidth.Visible
			cbEmbedFonts.Visible = cbJpegCompression.Visible
		End Sub

		Protected Sub cbShowheader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			pnlPDFHeaderOptions.Visible = (CType(sender, CheckBox)).Checked
		End Sub

		Protected Sub cbShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
			pnlPDFFooterOptions.Visible = (CType(sender, CheckBox)).Checked
		End Sub

		Protected Sub cvLeftMargin_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim width As Integer = 0
			Try
				width = Integer.Parse(textBoxLeftMargin.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = width >= 0
		End Sub

		Protected Sub cvRightMargin_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim width As Integer = 0
			Try
				width = Integer.Parse(textBoxRightMargin.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = width >= 0
		End Sub

		Protected Sub cvTopMargin_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim width As Integer = 0
			Try
				width = Integer.Parse(textBoxTopMargin.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = width >= 0
		End Sub

		Protected Sub cvBottomMargin_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim width As Integer = 0
			Try
				width = Integer.Parse(textBoxBottomMargin.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = width >= 0
		End Sub

		Protected Sub cvHtmlViewerWidth_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim width As Integer = 0
			Try
				width = Integer.Parse(textBoxHtmlViewerWidth.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = width >= 0
		End Sub

		Protected Sub cvHtmlViewerHeight_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim width As Integer = 0
			Try
				width = Integer.Parse(textBoxHtmlViewerHeight.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = width >= 0
		End Sub

		Protected Sub cvHeaderHeight_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim height As Single = 0
			Try
				height = Integer.Parse(textBoxHeaderHeight.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = height > 0
		End Sub

		Protected Sub cvFooterHeight_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim height As Single = 0
			Try
				height = Integer.Parse(textBoxFooterHeight.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = height > 0
		End Sub

		Protected Sub cvConversionDelay_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim val As Integer = 0
			Try
				val = Integer.Parse(textBoxConversionDelay.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = val >= 0
		End Sub

		Protected Sub cvNavigationTimeout_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Dim val As Integer = 0
			Try
				val = Integer.Parse(textBoxNavigationTimeout.Text.Trim())
			Catch
				args.IsValid = False
				Return
			End Try
			args.IsValid = val >= 0
		End Sub
	End Class
End Namespace
