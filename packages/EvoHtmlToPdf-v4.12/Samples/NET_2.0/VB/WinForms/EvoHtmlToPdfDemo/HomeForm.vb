Imports System.ComponentModel
Imports System.Text

Namespace EvoHtmlToPdfDemo
	Partial Public Class HomeForm
		Inherits Form
		Private currentDemoName As String = "MainFeatures"
		Private currentLink As LinkLabel = Nothing

		Public Sub New()
			InitializeComponent()

			currentLink = lnkMainFeaturesDemo
		End Sub

		Private Sub LoadDemoDetails(ByVal demoName As String)
			Dim previousLink As LinkLabel = currentLink
			Select Case demoName
				Case "MainFeatures"
					lblSampleDescription.Text = "This sample shows the main features and options of the EVO HTML to PDF Converter for .NET." & vbCrLf & vbCrLf & "Options like PDF page size, PDF page orientation, margins, headers and footers, live URLs," & vbCrLf & "font embedding, JavaScript execution, automatic bookmarks generation, JPEG compression" & vbCrLf & "can be controlled using this demo." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Main Features Demo"
					currentDemoName = demoName
					currentLink = lnkMainFeaturesDemo
				Case "HtmlPdfLocation"
					lblSampleDescription.Text = "This sample shows how to determine the location in PDF of the HTML elements from" & vbCrLf & "the converted page." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "HTML Elements Location in PDF"
					currentDemoName = demoName
					currentLink = lnkHtmlPdfLocation
				Case "ConvertMultipleUrl"
					lblSampleDescription.Text = "This sample shows how to combine multiple web pages into the same PDF document." & vbCrLf & "The PDF content resulted after conversion of one web page can be added right after" & vbCrLf & "the content from the previous page or it can start on a new PDF page." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Combine Multiple Web Pages Into the Same PDF"
					currentDemoName = demoName
					currentLink = lnkConvertMultipleURL
				Case "HtmlInHeaderFooter"
					lblSampleDescription.Text = "This sample shows how to add HTML in the header and footer of the generated PDF document" & vbCrLf & "and how to add page numbers in the footer. It also offers the possibility to alternate the" & vbCrLf & "header and footer content for the consecutive PDF pages." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "HTML in Header and Footer"
					currentDemoName = demoName
					currentLink = lnkHtmlInHeaderFooter
				Case "RepeatTableHead"
					lblSampleDescription.Text = "This sample shows how to repeat the head of a HTML table on each PDF page where the " & vbCrLf & "table is rendered." & vbCrLf & vbCrLf & "The thead element of the HTML table must have the display:table-header-group style " & vbCrLf & "in order to get this effect" & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Repeat Tables Head on PDF Pages"
					currentDemoName = demoName
					currentLink = lnkRepeatTableHead
				Case "TableOfContents"
					lblSampleDescription.Text = "This sample shows how to create a table of contents in the PDF document generated from" & vbCrLf & "a HTML book and how to add bookmarks in PDF to the sections of the book." & vbCrLf & vbCrLf & "The creation of the table of contents is based on the capabilities of the converter to" & vbCrLf & "convert the internal links from HTML to internal links in PDF and to obtain the position" & vbCrLf & "in PDF of a HTML element based on the ID of the element." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Table of Contents and Bookmarks"
					currentDemoName = demoName
					currentLink = lnkTableOfContents
				Case "AppendExternalPdf"
					lblSampleDescription.Text = "This sample shows how to use the the converter to convert many web pages to PDF and merge" & vbCrLf & "them into a single final PDF document." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Append and Prepend External PDFs"
					currentDemoName = demoName
					currentLink = lnkAppendPrependPdf
				Case "HtmlToPdfElement"
					lblSampleDescription.Text = "This sample shows how to add HtmlToPdfElement and HtmlToImageElement objects to an" & vbCrLf & "empty Document object." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "HTML to PDF and HTML to Image Elements Demo"
					currentDemoName = demoName
					currentLink = lnkHtmlToPdfElement
				Case "PdfShapes"
					lblSampleDescription.Text = "This sample shows how to add gaphic elements like rectangles, ellipses and bezier" & vbCrLf & "curves to a PDF document. It also demonstrate how to fill the shapes with colors" & vbCrLf & "and gradient colors, set the line dash style, width and joining style." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "PDF Shapes Demo"
					currentDemoName = demoName
					currentLink = lnkPdfShapes
				Case "PdfSecurity"
					lblSampleDescription.Text = "This sample shows how to set the security options for the generated PDF document." & vbCrLf & "The generated PDF document is password protected with an User and an Owner password." & vbCrLf & "The User password is 'user' and the Owner password is 'owner'. When the PDF document" & vbCrLf & "is opened by owner its security properties can be changed. If the document is opened " & vbCrLf & "by an user the security properties of the document cannot be changed." & vbCrLf & vbCrLf & "The demo also restricts the right to print or copy the generated PDF document content" & vbCrLf & "when the document is opened by an user. Other restrictions like the right to edit the" & vbCrLf & "document content can also be applied." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "PDF Security Demo"
					currentDemoName = demoName
					currentLink = lnkPdfSecurity
				Case "DigitalSignature"
					lblSampleDescription.Text = "This sample shows how to add a digital signature to a PDF document. The digital signature" & vbCrLf & "requires a digital certificate in PKCS #12 format cotaining both the public and private" & vbCrLf & "encryption keys." & vbCrLf & vbCrLf & "Such a certificate is usually stored in a .pfx or .p12 file." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Digital Signatures Demo"
					currentDemoName = demoName
					currentLink = lnkDigitalSignature
				Case "TextAndFonts"
					lblSampleDescription.Text = "This sample will generate a PDF document to demonstrate how to add fonts to the PDF" & vbCrLf & "document and write text using the TextElement class. Unicode texts require the font" & vbCrLf & "to be embedded in the generated PDF document." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Text and Fonts Demo"
					currentDemoName = demoName
					currentLink = lnkTextFonts
				Case "PdfStamps"
					lblSampleDescription.Text = "This sample shows how to add a stamp to an existing PDF document. The application will" & vbCrLf & "add an image stamp in the top left corner of the first page and a template stamp to be" & vbCrLf & "repeated on each page of the generated PDF document." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "PDF Stamps Demo"
					currentDemoName = demoName
					currentLink = lnkStampsDemo
				Case "ConvertHtmlString"
					lblSampleDescription.Text = "This sample shows how to convert a HTML string to PDF. The base URL parameter is used to" & vbCrLf & "resolve the relative URLs found in HTML string to full URLs. When the HTML string contains" & vbCrLf & "only full URLs this parameter is not necessary and can be empty." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Convert HTML String to PDF Demo"
					currentDemoName = demoName
					currentLink = lnkConvertHtmlString
				Case "ImageElement"
					lblSampleDescription.Text = "This sample shows how to add image elements to a PDF document. The images can be resized" & vbCrLf & "and displayed in any position in a PDF page." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "Image Elements Demo"
					currentDemoName = demoName
					currentLink = lnkImageElement
				Case "SvgToPdf"
					lblSampleDescription.Text = "This sample shows how to convert a HTML page containing SVG to PDF. The SVG that will be" & vbCrLf & "converted contains a shape and a text written on that shape." & vbCrLf & vbCrLf & "Click the 'Run This Sample' button to view the demo."
					groupBoxSampleDetails.Text = "SVG to PDF Conversion Demo"
					currentDemoName = demoName
					currentLink = lnkSvgToPdf
				Case Else
			End Select
            previousLink.BackColor = Color.WhiteSmoke
			currentLink.BackColor = Color.LightBlue
		End Sub


		Private Sub btnRunSample_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnRunSample.Click
			Select Case currentDemoName
				Case "MainFeatures"
					Using mainFeaturesForm As New MainFeaturesForm()
						mainFeaturesForm.ShowDialog()
					End Using
				Case "HtmlPdfLocation"
					Using htmlLocationInPdfForm As New HtmlElementsLocationInPdf()
						htmlLocationInPdfForm.ShowDialog()
					End Using
				Case "ConvertMultipleUrl"
					Using convertMultipleURLsForm As New ConvertMultipleURLsToPdf()
						convertMultipleURLsForm.ShowDialog()
					End Using
				Case "HtmlInHeaderFooter"
					Using htmlInHeaderAndFooterForm As New HtmlInHeaderAndFooter()
						htmlInHeaderAndFooterForm.ShowDialog()
					End Using
				Case "RepeatTableHead"
					Using repeatTableHeadForm As New RepeatTableHeadOnEachPage()
						repeatTableHeadForm.ShowDialog()
					End Using
				Case "TableOfContents"
					Using tableOfContentsForm As New TableOfContentsAndBookmarks()
						tableOfContentsForm.ShowDialog()
					End Using
				Case "AppendExternalPdf"
					Using appendPrependExternalPdfForm As New AppendPrependExternalPdf()
						appendPrependExternalPdfForm.ShowDialog()
					End Using
				Case "HtmlToPdfElement"
					Using htmlToPdfElementDemoForm As New HtmlToPdfElementDemo()
						htmlToPdfElementDemoForm.ShowDialog()
					End Using
				Case "PdfShapes"
					Using pdfShapesDemoForm As New ShapesDemo()
						pdfShapesDemoForm.ShowDialog()
					End Using
				Case "PdfSecurity"
					Using pdfSecurityDemoForm As New PdfSecurity()
						pdfSecurityDemoForm.ShowDialog()
					End Using
				Case "DigitalSignature"
					Using digitalSignatureDemoForm As New DigitalSignature()
						digitalSignatureDemoForm.ShowDialog()
					End Using
				Case "TextAndFonts"
					Using textAndFontsDemoForm As New TextAndFonts()
						textAndFontsDemoForm.ShowDialog()
					End Using
				Case "PdfStamps"
					Using pdfStampsDemoForm As New PdfStamps()
						pdfStampsDemoForm.ShowDialog()
					End Using
				Case "ConvertHtmlString"
					Using convertHtmlStringDemoForm As New ConvertHtmlString()
						convertHtmlStringDemoForm.ShowDialog()
					End Using
				Case "ImageElement"
					Using imageElementDemoForm As New ImageElementDemo()
						imageElementDemoForm.ShowDialog()
					End Using
				Case "SvgToPdf"
					Using svgToPdfDemoForm As New SvgToPdf()
						svgToPdfDemoForm.ShowDialog()
					End Using
				Case Else
					Using mainFeaturesForm As New MainFeaturesForm()
						mainFeaturesForm.ShowDialog()
					End Using
			End Select
		End Sub

		Private Sub HomeForm_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			LoadDemoDetails("MainFeatures")
		End Sub

		Private Sub lnkMainFeaturesDemo_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkMainFeaturesDemo.LinkClicked
			LoadDemoDetails("MainFeatures")
		End Sub

		Private Sub lnkHtmlPdfLocation_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkHtmlPdfLocation.LinkClicked
			LoadDemoDetails("HtmlPdfLocation")
		End Sub

		Private Sub lnkConvertMultipleURL_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkConvertMultipleURL.LinkClicked
			LoadDemoDetails("ConvertMultipleUrl")
		End Sub

		Private Sub lnkHtmlInHeaderFooter_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkHtmlInHeaderFooter.LinkClicked
			LoadDemoDetails("HtmlInHeaderFooter")
		End Sub

		Private Sub lnkRepeatTableHead_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkRepeatTableHead.LinkClicked
			LoadDemoDetails("RepeatTableHead")
		End Sub

		Private Sub lnkTableOfContents_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkTableOfContents.LinkClicked
			LoadDemoDetails("TableOfContents")
		End Sub

		Private Sub lnkAppendPrependPdf_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkAppendPrependPdf.LinkClicked
			LoadDemoDetails("AppendExternalPdf")
		End Sub

		Private Sub lnkHtmlToPdfElement_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkHtmlToPdfElement.LinkClicked
			LoadDemoDetails("HtmlToPdfElement")
		End Sub

		Private Sub lnkPdfShapes_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkPdfShapes.LinkClicked
			LoadDemoDetails("PdfShapes")
		End Sub

		Private Sub lnkPdfSecurity_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkPdfSecurity.LinkClicked
			LoadDemoDetails("PdfSecurity")
		End Sub

		Private Sub lnkDigitalSignature_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkDigitalSignature.LinkClicked
			LoadDemoDetails("DigitalSignature")
		End Sub

		Private Sub lnkTextFonts_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkTextFonts.LinkClicked
			LoadDemoDetails("TextAndFonts")
		End Sub

		Private Sub lnkStampsDemo_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkStampsDemo.LinkClicked
			LoadDemoDetails("PdfStamps")
		End Sub

		Private Sub lnkConvertHtmlString_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkConvertHtmlString.LinkClicked
			LoadDemoDetails("ConvertHtmlString")
		End Sub

		Private Sub lnkImageElement_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkImageElement.LinkClicked
			LoadDemoDetails("ImageElement")
		End Sub

		Private Sub lnkSvgToPdf_LinkClicked(ByVal sender As Object, ByVal e As LinkLabelLinkClickedEventArgs) Handles lnkSvgToPdf.LinkClicked
			LoadDemoDetails("SvgToPdf")
		End Sub
	End Class
End Namespace