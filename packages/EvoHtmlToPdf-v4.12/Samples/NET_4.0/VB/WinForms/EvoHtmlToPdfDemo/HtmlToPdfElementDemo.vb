Imports System.ComponentModel
Imports System.Text
Imports System.IO

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class HtmlToPdfElementDemo
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub WnvHtmlConvertForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
		End Sub

		Private Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvert.Click
			Me.Cursor = Cursors.WaitCursor

			Dim outFilePath As String = Path.Combine(Application.StartupPath, "HtmlToPdfElement.pdf")

			' the PDF document
			Dim document As Document = Nothing

			Try
				'create a PDF document
				document = New Document()

				' set the license key
                document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

				'optional settings for the PDF document like margins, compression level,
				'security options, viewer preferences, document information, etc
				document.CompressionLevel = PdfCompressionLevel.Normal
				document.Margins = New Margins(10, 10, 0, 0)
				'document.Security.CanPrint = true;
				'document.Security.UserPassword = "";
				document.DocumentInformation.Author = "HTML to PDF Converter"
				document.ViewerPreferences.HideToolbar = False

				' set if the JPEG compression is enabled for the images in PDF - default is true
				document.JpegCompressionEnabled = cbJpegCompression.Checked

				'Add a first page to the document. The next pages will inherit the settings from this page 
                Dim page As PdfPage = document.Pages.AddNewPage(PdfPageSize.A4, New Margins(10, 10, 0, 0), PdfPageOrientation.Portrait)

				' the code below can be used to create a page with default settings A4, document margins inherited, portrait orientation
				'PdfPage page = document.Pages.AddNewPage();

				' add a font to the document that can be used for the texts elements 
				Dim font As PdfFont = document.Fonts.Add(New Font(New FontFamily("Times New Roman"), 10, GraphicsUnit.Point))

				' add header and footer before renderng the content
				If cbAddHeader.Checked Then
					AddHtmlHeader(document)
				End If
				If cbAddFooter.Checked Then
					AddHtmlFooter(document, font)
				End If

				' the result of adding an element to a PDF page
				Dim addResult As AddElementResult

				' Get the specified location and size of the rendered content
				' A negative value for width and height means to auto determine
				' The auto determined width is the available width in the PDF page
				' and the auto determined height is the height necessary to render all the content
				Dim xLocation As Single = Single.Parse(textBoxXLocation.Text.Trim())
				Dim yLocation As Single = Single.Parse(textBoxYLocation.Text.Trim())
				Dim width As Single = Single.Parse(textBoxWidth.Text.Trim())
				Dim height As Single = Single.Parse(textBoxHeight.Text.Trim())

				If radioConvertToSelectablePDF.Checked Then
					' convert HTML to PDF
					Dim htmlToPdfElement As HtmlToPdfElement


						' convert a URL to PDF
						Dim urlToConvert As String = textBoxWebPageURL.Text.Trim()

						htmlToPdfElement = New HtmlToPdfElement(xLocation, yLocation, width, height, urlToConvert)


					'optional settings for the HTML to PDF converter
					htmlToPdfElement.FitWidth = cbFitWidth.Checked
					htmlToPdfElement.EmbedFonts = cbEmbedFonts.Checked
					htmlToPdfElement.LiveUrlsEnabled = cbLiveLinks.Checked
					htmlToPdfElement.JavaScriptEnabled = cbScriptsEnabled.Checked
					If cbBookmarks.Checked Then
						htmlToPdfElement.PdfBookmarkOptions.HtmlElementSelectors = New String() { "H1", "H2" }
					Else
						htmlToPdfElement.PdfBookmarkOptions.HtmlElementSelectors = Nothing
					End If

					' add theHTML to PDF converter element to page
					addResult = page.AddElement(htmlToPdfElement)
				Else
					Dim htmlToImageElement As HtmlToImageElement

					' convert HTML to image and add image to PDF document

						' convert a URL to PDF
						Dim urlToConvert As String = textBoxWebPageURL.Text.Trim()

						htmlToImageElement = New HtmlToImageElement(xLocation, yLocation, width, height, urlToConvert)

					'optional settings for the HTML to PDF converter
					htmlToImageElement.FitWidth = cbFitWidth.Checked
					htmlToImageElement.LiveUrlsEnabled = cbLiveLinks.Checked
					htmlToImageElement.JavaScriptEnabled = cbScriptsEnabled.Checked
					If cbBookmarks.Checked Then
						htmlToImageElement.PdfBookmarkOptions.HtmlElementSelectors = New String() { "H1", "H2" }
					Else
						htmlToImageElement.PdfBookmarkOptions.HtmlElementSelectors = Nothing
					End If

					addResult = page.AddElement(htmlToImageElement)
				End If

				If cbAdditionalContent.Checked Then
					' The code below can be used add some other elements right under the conversion result 
					' like texts or another HTML to PDF conversion

					' add a text element right under the HTML to PDF document
					Dim endPage As PdfPage = document.Pages(addResult.EndPageIndex)
					Dim nextTextElement As New TextElement(0, addResult.EndPageBounds.Bottom + 10, "Below there is another HTML to PDF Element", font)
					nextTextElement.ForeColor = Color.Green
					addResult = endPage.AddElement(nextTextElement)

					' add another HTML to PDF converter element right under the text element
					endPage = document.Pages(addResult.EndPageIndex)
                    Dim nextHtmlToPdfElement As New HtmlToPdfElement(0, addResult.EndPageBounds.Bottom + 10, "http://www.google.com")
                    addResult = endPage.AddElement(nextHtmlToPdfElement)
                End If

                ' save the PDF document to disk
                document.Save(outFilePath)

            Catch ex As Exception
                MessageBox.Show(ex.Message)
                Return
            Finally
                ' close the PDF document to release the resources
                If document IsNot Nothing Then
                    document.Close()
                End If

                Me.Cursor = Cursors.Arrow
            End Try

            Dim dr As DialogResult = MessageBox.Show("Open the saved file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo)
            If dr = DialogResult.Yes Then
                Try
                    Process.Start(outFilePath)
                Catch ex As Exception
                    MessageBox.Show(ex.Message)
                    Return
                End Try
            End If
        End Sub

        Private Sub AddHtmlHeader(ByVal document As Document)
            Dim headerAndFooterHtmlUrl As String = Path.Combine(Application.StartupPath, "..\..\HeaderFooter\HeaderAndFooterHtml.htm")

            'create a template to be added in the header and footer
            document.Header = document.AddTemplate(document.Pages(0).ClientRectangle.Width, 60)
            ' create a HTML to PDF converter element to be added to the header template
            Dim headerHtmlToPdf As HtmlToPdfElement = New HtmlToPdfElement(0, 0, document.Header.ClientRectangle.Width,
                    document.Header.ClientRectangle.Height, headerAndFooterHtmlUrl)
            headerHtmlToPdf.FitHeight = True
            document.Header.AddElement(headerHtmlToPdf)
        End Sub

        Private Sub AddHtmlFooter(ByVal document As Document, ByVal footerPageNumberFont As PdfFont)
            Dim headerAndFooterHtmlUrl As String = Path.Combine(Application.StartupPath, "..\..\HeaderFooter\HeaderAndFooterHtml.htm")

            'create a template to be added in the header and footer
            document.Footer = document.AddTemplate(document.Pages(0).ClientRectangle.Width, 60)
            ' create a HTML to PDF converter element to be added to the header template
            Dim footerHtmlToPdf As HtmlToPdfElement = New HtmlToPdfElement(0, 0, document.Footer.ClientRectangle.Width,
                    document.Footer.ClientRectangle.Height, headerAndFooterHtmlUrl)
            footerHtmlToPdf.FitHeight = True
            document.Footer.AddElement(footerHtmlToPdf)

            ' add page number to the footer
            Dim pageNumberText As TextElement = New TextElement(document.Footer.ClientRectangle.Width - 100, 30,
                                "This is page &p; of &P; pages", footerPageNumberFont)
            document.Footer.AddElement(pageNumberText)
        End Sub
	End Class
End Namespace