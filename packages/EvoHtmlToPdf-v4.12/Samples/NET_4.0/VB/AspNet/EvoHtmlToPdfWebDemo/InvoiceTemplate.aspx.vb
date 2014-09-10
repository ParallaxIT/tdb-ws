Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class InvoiceTemplate
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			If Not IsPostBack Then
				LoadInvoiceData()
			End If
		End Sub

		Private Sub LoadInvoiceData()
			litInvoiceDate.Text = Date.Now.ToString("MMMM dd, yyyy")
			litInvoiceNum.Text = "30643"
			LoadCustomerInfo()
			LoadInvoiceItems()
			lblTotalPrice.Text = InvoiceData.GetInvoiceData().TotalInvoice.ToString("N2")
		End Sub

		Private Sub LoadCustomerInfo()
			Dim customerInfo As CustomerInfo = InvoiceData.GetInvoiceData().CustomerInfo

			If customerInfo Is Nothing Then
				Return
			End If

			litCustomerName.Text = customerInfo.Name
			litCustomerAddress1.Text = customerInfo.Address1
			litCustomerAddress2.Text = customerInfo.Address2
			litCustomerPhone.Text = customerInfo.Phone
			litCustomerEmail.Text = customerInfo.Email
		End Sub

		Private Sub LoadInvoiceItems()
			itemsGrid.Visible = False
			If InvoiceData.GetInvoiceData().InvoiceItems.Count > 0 Then
				itemsGrid.DataSource = InvoiceData.GetInvoiceData().InvoiceItems
				itemsGrid.DataBind()
				itemsGrid.Visible = True
			End If
		End Sub
	End Class
End Namespace
