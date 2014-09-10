Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports System.IO
Imports System.Text

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class PdfInvoicesDemo
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("PdfInvoices")

			lblInvoiceTemplateMessage.Visible = False

			If Not IsPostBack Then
				ShowItemsCount()
				LoadInvoiceItems()
			End If
		End Sub

		Private Sub ShowItemsCount()
			lblItemsCount.Text = InvoiceData.GetInvoiceData().InvoiceItems.Count.ToString()
		End Sub

		Protected Sub btnAddItem_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not Page.IsValid Then
				Return
			End If

			If InvoiceData.GetInvoiceData().InvoiceItems.Count >= 100 Then
				lblInvoiceTemplateMessage.Text = "The maximum number of items reached."
				lblInvoiceTemplateMessage.Visible = True
				Return
			End If

			Dim newInvoiceItem As New InvoiceItem(textBoxProductCode.Text, textBoxProductDescription.Text, textBoxProductName.Text, Double.Parse(textBoxProductPrice.Text.Trim()), Integer.Parse(textBoxProductQuantity.Text.Trim()))

			InvoiceData.GetInvoiceData().AddItem(newInvoiceItem)

			ShowItemsCount()
			LoadInvoiceItems()
		End Sub

		Private Sub LoadInvoiceItems()
			itemsGrid.Visible = False
			If InvoiceData.GetInvoiceData().InvoiceItems.Count > 0 Then
				itemsGrid.DataSource = InvoiceData.GetInvoiceData().InvoiceItems
				itemsGrid.DataBind()
				itemsGrid.Visible = True
			End If
		End Sub

		Private Sub SaveCustomerInfo()
			InvoiceData.GetInvoiceData().CustomerInfo = New CustomerInfo(textBoxCustomerName.Text, textBoxCustomerAddress.Text, textBoxAddress2.Text, textBoxCustomerPhone.Text, textBoxCustomerEmail.Text)
		End Sub

		''' <summary>
		''' Generate the PDF invoice from the HTML template based on the current session data
		''' </summary>
		''' <param name="sender"></param>
		''' <param name="e"></param>
		Protected Sub btnGenerateInvoice_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not Page.IsValid Then
				Return
			End If

			' save customer info on the session 
			' to make it available in the report page
			SaveCustomerInfo()

			' get the html string for the report
			Dim htmlStringWriter As New StringWriter()
			Server.Execute("InvoiceTemplate.aspx", htmlStringWriter)
			Dim htmlCodeToConvert As String = htmlStringWriter.GetStringBuilder().ToString()
			htmlStringWriter.Close()

			'initialize the PdfConvert object
			Dim pdfConverter As New PdfConverter()

			' set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4
			pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal
			pdfConverter.PdfDocumentOptions.ShowHeader = False
			pdfConverter.PdfDocumentOptions.ShowFooter = False

			' get the base url for string conversion which is the url from where the html code was retrieved
			' the base url is used by the converter to get the full URL of the external CSS and images referenced by relative URLs
			Dim baseUrl As String = HttpContext.Current.Request.Url.AbsoluteUri

			' get the pdf bytes from html string
			Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromHtmlString(htmlCodeToConvert, baseUrl)

			Dim response As HttpResponse = HttpContext.Current.Response
			response.Clear()
			response.AddHeader("Content-Type", "application/pdf")
			response.AddHeader("Content-Disposition", String.Format("attachment; filename=PdfInvoice.pdf; size={0}", pdfBytes.Length.ToString()))
			response.BinaryWrite(pdfBytes)
			' Note: it is important to end the response, otherwise the ASP.NET
			' web page will render its content to PDF document stream
			response.End()
		End Sub

		Protected Sub btnInvoicePreview_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not Page.IsValid Then
				Return
			End If

			SaveCustomerInfo()

			Response.Redirect("InvoiceTemplate.aspx")
		End Sub
		Protected Sub cvPriceValidator_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Try
				Dim price As Double = Double.Parse(textBoxProductPrice.Text.Trim())
				If price < 0 Then
					Throw New Exception()
				End If
			Catch
				args.IsValid = False
				Return
			End Try
		End Sub
		Protected Sub cvQuantityValidator_ServerValidate(ByVal source As Object, ByVal args As ServerValidateEventArgs)
			args.IsValid = True
			Try
				Dim quantity As Integer = Integer.Parse(textBoxProductQuantity.Text.Trim())
				If quantity < 0 Then
					Throw New Exception()
				End If
			Catch
				args.IsValid = False
				Return
			End Try
		End Sub
		Protected Sub lnkBtnPreviewReport_Click(ByVal sender As Object, ByVal e As EventArgs)
			If Not Page.IsValid Then
				Return
			End If

			InvoiceData.GetInvoiceData().CustomerInfo = New CustomerInfo(textBoxCustomerName.Text, textBoxCustomerAddress.Text, textBoxAddress2.Text, textBoxCustomerPhone.Text, textBoxCustomerEmail.Text)

			Response.Redirect("InvoiceTemplate.aspx")
		End Sub
		Protected Sub btnReserItems_Click(ByVal sender As Object, ByVal e As EventArgs)
			InvoiceData.GetInvoiceData().Reset()
			ShowItemsCount()
			LoadInvoiceItems()
		End Sub
	End Class
End Namespace
