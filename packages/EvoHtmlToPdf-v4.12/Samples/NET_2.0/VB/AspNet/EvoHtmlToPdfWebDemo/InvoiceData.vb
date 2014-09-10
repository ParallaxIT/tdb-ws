Imports System.Configuration
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports System.Collections

Namespace EvoHtmlToPdfWebDemo
	Public Class InvoiceData
'INSTANT VB NOTE: The variable customerInfo was renamed since Visual Basic does not allow class members with the same name:
		Private customerInfo_Renamed As CustomerInfo
'INSTANT VB NOTE: The variable invoiceItems was renamed since Visual Basic does not allow class members with the same name:
		Private invoiceItems_Renamed As ArrayList
'INSTANT VB NOTE: The variable totalInvoice was renamed since Visual Basic does not allow class members with the same name:
		Private totalInvoice_Renamed As Double = 0

		Public Sub New()
			invoiceItems_Renamed = New ArrayList()
		End Sub

		Public Shared Function GetInvoiceData() As InvoiceData
			If HttpContext.Current.Session("InvoiceData") Is Nothing Then
				HttpContext.Current.Session("InvoiceData") = New InvoiceData()
			End If
			Return CType(HttpContext.Current.Session("InvoiceData"), InvoiceData)
		End Function

		Public Sub Reset()
			invoiceItems_Renamed.Clear()
			totalInvoice_Renamed = 0
			customerInfo_Renamed = Nothing
		End Sub

		Public ReadOnly Property TotalInvoice() As Double
			Get
				Return totalInvoice_Renamed
			End Get
		End Property

		Public Sub AddItem(ByVal invoiceItem As InvoiceItem)
			invoiceItems_Renamed.Add(invoiceItem)
			totalInvoice_Renamed += invoiceItem.ItemPrice
		End Sub

		Public Property InvoiceItems() As ArrayList
			Get
				Return invoiceItems_Renamed
			End Get
			Set(ByVal value As ArrayList)
				invoiceItems_Renamed = value
			End Set
		End Property

		Public Property CustomerInfo() As CustomerInfo
			Get
				Return customerInfo_Renamed
			End Get
			Set(ByVal value As CustomerInfo)
				customerInfo_Renamed = value
			End Set
		End Property
	End Class

	Public Class InvoiceItem
'INSTANT VB NOTE: The variable productCode was renamed since Visual Basic does not allow class members with the same name:
		Private productCode_Renamed As String
'INSTANT VB NOTE: The variable productDescription was renamed since Visual Basic does not allow class members with the same name:
		Private productDescription_Renamed As String = String.Empty
'INSTANT VB NOTE: The variable productName was renamed since Visual Basic does not allow class members with the same name:
		Private productName_Renamed As String
'INSTANT VB NOTE: The variable productPrice was renamed since Visual Basic does not allow class members with the same name:
		Private productPrice_Renamed As Double
'INSTANT VB NOTE: The variable quantity was renamed since Visual Basic does not allow class members with the same name:
		Private quantity_Renamed As Integer

		Public Sub New(ByVal productCode As String, ByVal productDescription As String, ByVal productName As String, ByVal productPrice As Double, ByVal quantity As Integer)
			Me.productCode_Renamed = productCode
			Me.productDescription_Renamed = productDescription
			Me.productName_Renamed = productName
			Me.productPrice_Renamed = productPrice
			Me.quantity_Renamed = quantity
		End Sub

		Public Property ProductCode() As String
			Get
				Return productCode_Renamed
			End Get
			Set(ByVal value As String)
				productCode_Renamed = value
			End Set
		End Property

		Public Property ProductDescription() As String
			Get
				Return productDescription_Renamed
			End Get
			Set(ByVal value As String)
				productDescription_Renamed = value
			End Set
		End Property
		Public Property ProductName() As String
			Get
				Return productName_Renamed
			End Get
			Set(ByVal value As String)
				productName_Renamed = value
			End Set
		End Property
		Public Property ProductPrice() As Double
			Get
				Return productPrice_Renamed
			End Get
			Set(ByVal value As Double)
				productPrice_Renamed = value
			End Set
		End Property

		Public ReadOnly Property ItemPrice() As Double
			Get
				Return ProductPrice * Quantity
			End Get
		End Property

		Public Property Quantity() As Integer
			Get
				Return quantity_Renamed
			End Get
			Set(ByVal value As Integer)
				quantity_Renamed = value
			End Set
		End Property
	End Class

	Public Class CustomerInfo
'INSTANT VB NOTE: The variable name was renamed since Visual Basic does not allow class members with the same name:
		Private name_Renamed As String
'INSTANT VB NOTE: The variable address1 was renamed since Visual Basic does not allow class members with the same name:
		Private address1_Renamed As String
'INSTANT VB NOTE: The variable address2 was renamed since Visual Basic does not allow class members with the same name:
		Private address2_Renamed As String
'INSTANT VB NOTE: The variable phone was renamed since Visual Basic does not allow class members with the same name:
		Private phone_Renamed As String
'INSTANT VB NOTE: The variable email was renamed since Visual Basic does not allow class members with the same name:
		Private email_Renamed As String

		Public Sub New(ByVal name As String, ByVal address1 As String, ByVal address2 As String, ByVal phone As String, ByVal email As String)
			Me.name_Renamed = name
			Me.address1_Renamed = address1
			Me.address2_Renamed = Me.Address2
			Me.phone_Renamed = phone
			Me.email_Renamed = email
		End Sub

		Public Property Name() As String
			Get
				Return name_Renamed
			End Get
			Set(ByVal value As String)
				name_Renamed = value
			End Set
		End Property
		Public Property Address1() As String
			Get
				Return address1_Renamed
			End Get
			Set(ByVal value As String)
				address1_Renamed = value
			End Set
		End Property
		Public Property Address2() As String
			Get
				Return address2_Renamed
			End Get
			Set(ByVal value As String)
				address2_Renamed = value
			End Set
		End Property
		Public Property Phone() As String
			Get
				Return phone_Renamed
			End Get
			Set(ByVal value As String)
				phone_Renamed = value
			End Set
		End Property
		Public Property Email() As String
			Get
				Return email_Renamed
			End Get
			Set(ByVal value As String)
				email_Renamed = value
			End Set
		End Property
	End Class
End Namespace
