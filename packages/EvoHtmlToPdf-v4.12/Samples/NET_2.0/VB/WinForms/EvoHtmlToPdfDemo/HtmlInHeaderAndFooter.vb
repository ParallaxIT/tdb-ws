Imports System.ComponentModel
Imports System.Text
Imports System.IO

Imports EvoPdf


Namespace EvoHtmlToPdfDemo
	Partial Public Class HtmlInHeaderAndFooter
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnConvertMerge.Click
			Me.Cursor = Cursors.WaitCursor

			Try
				Dim pdfConverter As New PdfConverter()

				' set the license key
                pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

				' show header and footer in the rendered PDF
				pdfConverter.PdfDocumentOptions.ShowHeader = True
				pdfConverter.PdfDocumentOptions.ShowFooter = True

				' set the header height in points
				pdfConverter.PdfHeaderOptions.HeaderHeight = 60

                ' set the header HTML area
                Dim headerHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight,
                    Path.Combine(Application.StartupPath, "..\..\HeaderFooter\HeaderAndFooterHtml.htm"), 1024, 0)
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
                Dim footerHtml As HtmlToPdfElement = New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfFooterOptions.FooterHeight,
                    Path.Combine(Application.StartupPath, "..\..\HeaderFooter\HeaderAndFooterHtml.htm"), 1024, 0)
                footerHtml.FitHeight = True
                pdfConverter.PdfFooterOptions.AddElement(footerHtml)

				' save the PDF bytes in a file on disk
				Dim outFilePath As String = Path.Combine(Application.StartupPath, "HtmlInHeaderAndFooter.pdf")

				If Not cbAlternateHeaderAndFooter.Checked Then
					' the header content is the same on all the PDF pages
					' the footer content is the same on all the PDF pages
					pdfConverter.SavePdfFromUrlToFile(textBoxURL1.Text, outFilePath)
				Else
					' set an alternate header and footer on the even pages

					' call the converter and get a Document object from URL
					Dim pdfDocument As Document = pdfConverter.GetPdfDocumentObjectFromUrl(textBoxURL1.Text)

					If pdfDocument.Pages.Count >= 2 Then
						' get the alternate header and footer width and height
						' the width is given by the PDF page width
						Dim altHeaderFooterWidth As Single = pdfDocument.Pages(0).ClientRectangle.Width
						' the height is the same with the document header height from the PdfConverter object
						Dim altHeaderHeight As Single = pdfConverter.PdfHeaderOptions.HeaderHeight
						Dim altFooterHeight As Single = pdfConverter.PdfFooterOptions.FooterHeight

						' create the alternate header template
						Dim altHeaderTemplate As Template = pdfDocument.Templates.AddNewTemplate(altHeaderFooterWidth, altHeaderHeight)

						' add html to the header
						Dim altHeaderHtml As New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight, Path.Combine(Application.StartupPath, "..\..\HeaderFooter\HeaderAndFooterHtml2.htm"), 1024, 0)
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
						Dim altFooterHtml As New HtmlToPdfElement(0, 0, 0, pdfConverter.PdfHeaderOptions.HeaderHeight, Path.Combine(Application.StartupPath, "..\..\HeaderFooter\HeaderAndFooterHtml2.htm"), 1024, 0)
						altFooterHtml.FitHeight = True
						altFooterTemplate.AddElement(altFooterHtml)

						For pageIndex As Integer = 1 To pdfDocument.Pages.Count - 1 Step 2
							Dim pdfPage As PdfPage = pdfDocument.Pages(pageIndex)

                            pdfPage.Header = altHeaderTemplate
                            pdfPage.Footer = altFooterTemplate
						Next pageIndex
					End If

					' save the PDF document to a file on disk
					Try
						pdfDocument.Save(outFilePath)
					Finally
						' close the Document to realease all the resources
						pdfDocument.Close()
					End Try
				End If

				Dim dr As DialogResult = MessageBox.Show("Open the rendered file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo)
				If dr = DialogResult.Yes Then
					Process.Start(outFilePath)
				End If
			Catch ex As Exception
				MessageBox.Show(ex.Message)
				Return
			Finally
				Me.Cursor = Cursors.Arrow
			End Try
		End Sub
	End Class
End Namespace