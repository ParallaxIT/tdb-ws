Imports System.ComponentModel
Imports System.Text

Imports EvoPdf

Namespace EvoHtmlToPdfDemo
	Partial Public Class DigitalSignature
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub btnCreatePdf_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCreatePdf.Click
			' create a PDF document
			Dim document As New Document()

			' set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' add a page to the PDF document
			Dim firstPage As PdfPage = document.AddPage()

			Dim logoImagePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\img\evologo-250.png")
			Dim certificateFilePath As String = System.IO.Path.Combine(Application.StartupPath, "..\..\certificates\evopdf.pfx")

			Dim pdfFont As PdfFont = document.Fonts.Add(New Font("Arial", 10, FontStyle.Regular, GraphicsUnit.Point))
			Dim descriptionTextElement As New TextElement(0, 0, "A digital signature was applied on the logo image below. Click on the image to see the signature details", pdfFont)
			Dim addResult As AddElementResult = firstPage.AddElement(descriptionTextElement)

			' create the area where the digital signature will be displayed in the PDF document
			' in this sample the area is a logo image but it could be anything else
			Dim logoElement As New ImageElement(0, addResult.EndPageBounds.Bottom + 10, 100, logoImagePath)
			addResult = firstPage.AddElement(logoElement)

			'get the #PKCS 12 certificate from file
			Dim certificates As DigitalCertificatesCollection = DigitalCertificatesStore.GetCertificates(certificateFilePath, "evopdf")
			Dim certificate As DigitalCertificate = certificates(0)

			' create the digital signature over the logo image element
			Dim signature As New DigitalSignatureElement(addResult.EndPageBounds, certificate)
			signature.Reason = "Protect the document from unwanted changes"
			signature.ContactInfo = "The contact email is support@evopdf.com"
			signature.Location = "Development server"
			firstPage.AddElement(signature)

			Dim outFilePath As String = System.IO.Path.Combine(Application.StartupPath, "DigitalSignature.pdf")

			' save the PDF document to disk
			document.Save(outFilePath)

			' close the PDF document to release the resources
			document.Close()

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
	End Class
End Namespace