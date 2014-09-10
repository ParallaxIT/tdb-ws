Imports System.ComponentModel
Imports System.Text
Imports System.IO

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class MainFeaturesForm
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub MainFeaturesForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			LoadImageFormats()
			LoadPdfFormats()
			LoadPageOrientations()
			LoadColors()
			LoadCompressionLevels()
			LoadPdfSubsets()
		End Sub

		Private Function GetPDFConverter() As PdfConverter
			Dim htmlViewerWidthPx As Integer = Integer.Parse(textBoxWebPageWidth.Text.Trim())
			Dim htmlViewerHeightPx As Integer = Integer.Parse(textBoxWebPageHeight.Text.Trim())

			' create the PDF converter with the specified width and height for HTML viewer
			' the default HTML viewer width is 1024 pixels and default height is 0 to auto determine the height
			Dim pdfConverter As New PdfConverter(htmlViewerWidthPx, htmlViewerHeightPx)

			' set PDF page size to a standard size like A4 or to a custom size
            pdfConverter.PdfDocumentOptions.PdfPageSize = GetSelectedPageSize()

			' set the PDF page orientation (portrait or landscape)
			' default orientation is portrait
			pdfConverter.PdfDocumentOptions.PdfPageOrientation = CType(System.Enum.Parse(GetType(PdfPageOrientation), ddlPageOrientation.SelectedItem.ToString()), PdfPageOrientation)

			' set the compression level of the streams in the PDF document
			' the default compression is Normal
			pdfConverter.PdfDocumentOptions.PdfCompressionLevel = CType(System.Enum.Parse(GetType(PdfCompressionLevel), ddlCompression.SelectedItem.ToString()), PdfCompressionLevel)

            ' the the PDF standard used to generate the PDF document (PDF, PDF/A or PDF/SiqQ)
			' the default standard is full PDF
            pdfConverter.PdfDocumentOptions.PdfStandardSubset = GetPdfStandard(ddlPdfSubset.SelectedItem.ToString())

			' set if the generated document will have header and footer
			' by default the generated document does not have header or footer
			pdfConverter.PdfDocumentOptions.ShowHeader = cbShowHeader.Checked
			pdfConverter.PdfDocumentOptions.ShowFooter = cbShowFooter.Checked

			'set PDF document margins in points (1 point = 1/72 inch)
			pdfConverter.PdfDocumentOptions.LeftMargin = Integer.Parse(textBoxLeftMargin.Text.Trim())
			pdfConverter.PdfDocumentOptions.RightMargin = Integer.Parse(textBoxRightMargin.Text.Trim())
			pdfConverter.PdfDocumentOptions.TopMargin = Integer.Parse(textBoxTopMargin.Text.Trim())
			pdfConverter.PdfDocumentOptions.BottomMargin = Integer.Parse(textBoxBottomMargin.Text.Trim())

			' set if the fonts are embedded in the PDF document
			' by default the fonts are embedded only if it is necessary
			pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked

			' set if the images are compressed with JPEG in PDF to reduce the PDF document size
			' by default the JPEG compression is enabled and can be controlled by the JpegCompressionLevel property
			pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked


			' set if the HTML content is resized if necessary to fit the PDF page width
			' by default this property is true
			pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked
			' set if the PDF page is automatically resized to show all the HTML content when FitWidth is false
			' by default this property os false
			pdfConverter.PdfDocumentOptions.AutoSizePdfPage = cbAutoSizePdfPage.Checked

			' set if the HTTP links are enabled in the generated PDF
			' by default this property is true
			pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinks.Checked

			' set if the converter should try to avoid breaking the images between PDF pages
			' by default this property is false
            pdfConverter.PdfDocumentOptions.AvoidImageBreak = cbAvoidImageBreak.Checked

			' Enable or disable JavaScript
			' JavaScript is enabled by default
			pdfConverter.JavaScriptEnabled = cbScriptsEnabled.Checked

			' set a delay if necessary to allow asynchronous content (like the content written by JavaScript) to load 
			' or a web page redirect to finish before starting rendering the content. The default delay is 0.
			pdfConverter.ConversionDelay = Integer.Parse(textBoxConversionDelay.Text.Trim())

			' set a timeout in case the web page loading takes too long
			' the default navigation timout is 60 seconds
			pdfConverter.NavigationTimeout = Integer.Parse(textBoxNavigationTimeout.Text.Trim())

			' set the selectors for the HTML elements to be bookmarked
			' by default no HTML element is bookmarked
			If cbBookmarks.Checked Then
				pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = New String() { "H1", "H2" }
			Else
				pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = Nothing
			End If

			' set HTTP authentication if necessary
			' for IIS Integrated Windows Authentication for example the username and password must be valid
			' Windows username and password
			If textBoxUsername.Text.Trim().Length > 0 Then
				pdfConverter.AuthenticationOptions.Username = textBoxUsername.Text.Trim()
				pdfConverter.AuthenticationOptions.Password = textBoxPassword.Text.Trim()
			End If

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

            Select ddlPageFormat.SelectedItem.ToString()

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
            Dim htmlViewerWidthPx As Integer = Integer.Parse(textBoxWebPageWidth.Text.Trim())
            Dim htmlViewerHeightPx As Integer = Integer.Parse(textBoxWebPageHeight.Text.Trim())

            ' create the image converter with the specified width and height for HTML viewer
            ' the default HTML viewer width is 1024 pixels and default height is 0 to auto determine the height
            Dim imgConverter As New ImgConverter(htmlViewerWidthPx, htmlViewerHeightPx)

            ' set HTTP authentication if necessary
            ' for IIS Integrated Windows Authentication for example the username and password must be valid
            ' Windows username and password
            If textBoxUsername.Text.Trim().Length > 0 Then
                imgConverter.AuthenticationOptions.Username = textBoxUsername.Text.Trim()
                imgConverter.AuthenticationOptions.Password = textBoxPassword.Text.Trim()
            End If

            ' Enable or disable JavaScript. 
            ' JavaScript is enabled by default
            imgConverter.JavaScriptEnabled = cbScriptsEnabled.Checked

            ' set a delay if necessary to allow asynchronous content (like the content written by JavaScript) to load 
            ' or a web page redirect to finish before starting rendering the content. The default delay is 0.
            imgConverter.ConversionDelay = Integer.Parse(textBoxConversionDelay.Text.Trim())

            ' set a timeout in case the web page loading takes too long
            ' the default navigation timout is 60 seconds
            imgConverter.NavigationTimeout = Integer.Parse(textBoxNavigationTimeout.Text.Trim())

            Return imgConverter
        End Function

        ' convert the web page to PDF or Image using the selected parameters
        Private Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvert.Click
            If Not PageIsValid() Then
                Return
            End If

            Me.Cursor = Cursors.WaitCursor

            Dim outFile As String = Nothing

            Try
                If radioButtonConvertToPdf.Checked Then
                    ' get the PDF converter
                    Dim pdfConverter As PdfConverter = GetPDFConverter()

                    ' set the license key
                    pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

                    ' handle the PrepareRenderPdfPageEvent to set the header and footer visibility in each page
                    AddHandler pdfConverter.PrepareRenderPdfPageEvent, AddressOf pdfConverter_PrepareRenderPdfPageEvent

                    outFile = Path.Combine(Application.StartupPath, "MainFeatures.pdf")
                    Try
                        pdfConverter.SavePdfFromUrlToFile(textBoxWebPageURL.Text, outFile)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Return
                    Finally
                        RemoveHandler pdfConverter.PrepareRenderPdfPageEvent, AddressOf pdfConverter_PrepareRenderPdfPageEvent
                    End Try
                ElseIf radioConvertToImage.Checked Then
                    ' get the image converter
                    Dim imgConverter As ImgConverter = GetImgConverter()

                    ' set the license key
                    imgConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

                    outFile = Path.Combine(Application.StartupPath, String.Format("MainFeatures.{0}", ddlImageFormat.SelectedItem.ToString()))
                    Try
                        Dim renderImageFormat As System.Drawing.Imaging.ImageFormat = GetImageFormat(ddlImageFormat.SelectedItem.ToString())
                        imgConverter.SaveImageFromUrlToFile(textBoxWebPageURL.Text, renderImageFormat, outFile)
                    Catch ex As Exception
                        MessageBox.Show(ex.Message)
                        Return
                    End Try
                End If
            Finally
                Me.Cursor = Cursors.Arrow
            End Try

            Dim dr As DialogResult = MessageBox.Show("Open the rendered file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo)
            If dr = DialogResult.Yes Then
                Try
                    Process.Start(outFile)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return
                End Try
            End If
        End Sub

        Private Sub pdfConverter_PrepareRenderPdfPageEvent(ByVal eventParams As PrepareRenderPdfPageParams)
            ' set the header and footer visibility on first, odd and even pages
            If cbShowFooter.Checked Then

                If eventParams.PageNumber = 1 And Not cbShowFooterOnFirstPage.Checked Then
                    eventParams.Page.ShowFooter = False
                ElseIf (eventParams.PageNumber Mod 2) = 0 And Not cbShowFooterOnEvenPages.Checked Then
                    eventParams.Page.ShowFooter = False
                ElseIf (eventParams.PageNumber Mod 2) = 1 And Not cbShowFooterOnOddPages.Checked Then
                    eventParams.Page.ShowFooter = False
                End If
            End If

            If (cbShowHeader.Checked) Then

                If eventParams.PageNumber = 1 And Not cbShowHeaderOnFirstPage.Checked Then
                    eventParams.Page.ShowHeader = False
                ElseIf (eventParams.PageNumber Mod 2) = 0 And Not cbShowHeaderOnEvenPages.Checked Then
                    eventParams.Page.ShowHeader = False
                ElseIf (eventParams.PageNumber Mod 2) = 1 And Not cbShowHeaderOnOddPages.Checked Then
                    eventParams.Page.ShowHeader = False
                End If
            End If
        End Sub

        Private Sub lnkBtnSettings_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkBtnSettings.LinkClicked
            If Not PageIsValid() Then
                Return
            End If

            If pnlSettingsPanel.Visible Then
                pnlSettingsPanel.Visible = False
                lnkBtnSettings.Text = "More Converter Settings >>"
            Else
                pnlSettingsPanel.Visible = True
                lnkBtnSettings.Text = "<< Hide Settings"
            End If
            Me.ClientSize = New Size(Me.ClientSize.Width, pnlHeader.Height + pnlContent.Height + pnlConvertCommand.Height)
        End Sub

        Private Sub radioConvertToImage_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioConvertToImage.CheckedChanged
            cbJpegCompression.Visible = Not radioConvertToImage.Checked
            cbEmbedFonts.Visible = cbJpegCompression.Visible
            cbAutoSizePdfPage.Visible = cbEmbedFonts.Visible
            cbFitWidth.Visible = cbAutoSizePdfPage.Visible
            cbBookmarks.Visible = cbFitWidth.Visible
            cbLiveLinks.Visible = cbBookmarks.Visible
            cbJpegCompression.Visible = cbLiveLinks.Visible
        End Sub

        Private Sub radioButtonConvertToPdf_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles radioButtonConvertToPdf.CheckedChanged
            pnlPDFSettings.Visible = (CType(sender, RadioButton)).Checked
            pnlImgeOptions.Visible = Not (CType(sender, RadioButton)).Checked
            Me.ClientSize = New Size(Me.ClientSize.Width, pnlHeader.Height + pnlContent.Height + pnlConvertCommand.Height)
        End Sub

        Private Sub cbShowHeader_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbShowHeader.CheckedChanged
            pnlHeaderOptions.Visible = (CType(sender, CheckBox)).Checked
            Me.ClientSize = New Size(Me.ClientSize.Width, pnlHeader.Height + pnlContent.Height + pnlConvertCommand.Height)
        End Sub

        Private Sub cbShowFooter_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles cbShowFooter.CheckedChanged
            pnlFooterOptions.Visible = (CType(sender, CheckBox)).Checked
            Me.ClientSize = New Size(Me.ClientSize.Width, pnlHeader.Height + pnlContent.Height + pnlConvertCommand.Height)
        End Sub

        Private Sub LoadImageFormats()
            Dim imageFormats() As String = {"Png", "Jpeg", "Bmp", "Gif", "Tiff"}
            ddlImageFormat.DataSource = imageFormats
            ddlImageFormat.SelectedItem = "Png"
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
            ddlCompression.DataSource = pdfCompressionLevels
            ddlCompression.SelectedItem = PdfCompressionLevel.Normal.ToString()
        End Sub

        Private Sub LoadPdfFormats()
            ddlPageFormat.SelectedItem = "A4"
        End Sub

        Private Sub LoadPageOrientations()
            Dim pdfPageOrientations() As String = System.Enum.GetNames(GetType(PdfPageOrientation))
            ddlPageOrientation.DataSource = pdfPageOrientations
            ddlPageOrientation.SelectedItem = PdfPageOrientation.Portrait.ToString()
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
            ddlPdfSubset.SelectedItem = "PDF"
        End Sub

        Private Sub LoadColors()
            Dim colors() As String = System.Enum.GetNames(GetType(KnownColor))

            Dim colors1() As String = System.Enum.GetNames(GetType(KnownColor))
            ddlHeaderLineColor.DataSource = colors1
            ddlHeaderLineColor.SelectedItem = KnownColor.Black.ToString()

            Dim colors3() As String = System.Enum.GetNames(GetType(KnownColor))
            ddlFooterLineColor.DataSource = colors3
            ddlFooterLineColor.SelectedItem = KnownColor.Black.ToString()
        End Sub

        Private Function PageIsValid() As Boolean
            errorProvider.Clear()
            Dim invalid As Boolean = False

            If textBoxWebPageURL.Text.Trim() = String.Empty Then
                errorProvider.SetError(textBoxWebPageURL, "The web page URL cannot be empty")
                invalid = True
            End If
            If pnlSettingsPanel.Visible Then

                ' check custom width and height
                Try
                    Dim width As Integer = Integer.Parse(textBoxWebPageWidth.Text.Trim())
                    If width < 0 Then
                        Throw New Exception()
                    End If
                Catch
                    errorProvider.SetError(textBoxWebPageWidth, "The web page width must be a positive integer")
                    invalid = True
                End Try

                Try
                    Dim height As Integer = Integer.Parse(textBoxWebPageHeight.Text.Trim())
                    If height < 0 Then
                        Throw New Exception()
                    End If
                Catch
                    errorProvider.SetError(textBoxWebPageHeight, "The web page height must be a positive integer")
                    invalid = True
                End Try

                Try
                    Dim conversionDelay As Integer = Integer.Parse(textBoxConversionDelay.Text.Trim())
                    If conversionDelay < 0 Then
                        Throw New Exception()
                    End If
                Catch
                    errorProvider.SetError(textBoxConversionDelay, "The conversion delay must be a positive integer")
                    invalid = True
                End Try

                Try
                    Dim navigationTimeout As Integer = Integer.Parse(textBoxNavigationTimeout.Text.Trim())
                    If navigationTimeout < 0 Then
                        Throw New Exception()
                    End If
                Catch
                    errorProvider.SetError(textBoxConversionDelay, "The navigation timeout must be a positive integer")
                    invalid = True
                End Try

                If radioButtonConvertToPdf.Checked Then
                    Try
                        Dim leftMargin As Integer = Integer.Parse(textBoxLeftMargin.Text.Trim())
                        If leftMargin < 0 Then
                            Throw New Exception()
                        End If
                    Catch
                        errorProvider.SetError(textBoxLeftMargin, "The PDF document left margin must be a positive integer")
                        invalid = True
                    End Try

                    Try
                        Dim rightMargin As Integer = Integer.Parse(textBoxRightMargin.Text.Trim())
                        If rightMargin < 0 Then
                            Throw New Exception()
                        End If
                    Catch
                        errorProvider.SetError(textBoxRightMargin, "The PDF document right margin must be a positive integer")
                        invalid = True
                    End Try

                    Try
                        Dim topMargin As Integer = Integer.Parse(textBoxTopMargin.Text.Trim())
                        If topMargin < 0 Then
                            Throw New Exception()
                        End If
                    Catch
                        errorProvider.SetError(textBoxTopMargin, "The PDF document top margin must be a positive integer")
                        invalid = True
                    End Try

                    Try
                        Dim bottomMargin As Integer = Integer.Parse(textBoxBottomMargin.Text.Trim())
                        If bottomMargin < 0 Then
                            Throw New Exception()
                        End If
                    Catch
                        errorProvider.SetError(textBoxBottomMargin, "The PDF document bottom margin must be a positive integer")
                        invalid = True
                    End Try

                    Try
                        Dim headerHeight As Single = Single.Parse(textBoxHeaderHeight.Text.Trim())
                        If headerHeight < 0 Then
                            Throw New Exception()
                        End If
                    Catch
                        errorProvider.SetError(textBoxHeaderHeight, "The PDF document header height must be a positive float")
                        invalid = True
                    End Try

                    Try
                        Dim footerHeight As Single = Single.Parse(textBoxFooterHeight.Text.Trim())
                        If footerHeight < 0 Then
                            Throw New Exception()
                        End If
                    Catch
                        errorProvider.SetError(textBoxFooterHeight, "The PDF document footer height must be a positive float")
                        invalid = True
                    End Try
                End If

            End If
            Return Not invalid
        End Function
    End Class
End Namespace