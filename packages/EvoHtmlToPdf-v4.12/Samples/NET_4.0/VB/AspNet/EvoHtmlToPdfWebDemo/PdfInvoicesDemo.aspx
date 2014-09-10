<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    Codebehind="PdfInvoicesDemo.aspx.vb" Inherits="EvoHtmlToPdfWebDemo.PdfInvoicesDemo"
    Title="Dinamically Create PDF Invoices with EVO HTML to PDF Converter for .NET" %>

<%@ Register Src="DemoLinksBox.ascx" TagName="DemoLinksBox" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="5" style="width: 100%; border-right: black 1px solid; border-top: black 1px solid;
        border-left: black 1px solid; border-bottom: black 1px solid;">
        <tr>
            <td colspan="2" style="height: 1px;">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_title" align="left">
                Dinamically Create PDF Invoices
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 1px">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_description" style="height: 45px">
                This demo shows how to dynamically create printable invoices directly from ASP.NET
                pages. The invoice will contain the customer name, email, phone number and email
                and the list of invoice items.<br />
                <br />
                From this configuration page you can enter the customer details and the invoice
                items. When you press the 'Generate Invoice' button, the information you introduced
                and stored in the current session will be used to fill the invoice template page,
                which is a regular ASP.NET page. The HTML to PDF Converter will convert the invoice
                template page to a PDF document or to an image.
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 10px">
            </td>
        </tr>
        <tr>
            <td colspan="2">
                <table cellpadding="0" cellspacing="0" border="1">
                    <tr>
                        <td class="demolinks_box" style="vertical-align: top; width: 280px">
                            <uc1:DemoLinksBox ID="ctrlDemoLinksBox" runat="server" />
                        </td>
                        <td style="vertical-align: top; width: 680px">
                            <table>
                                <tr>
                                    <td colspan="2" style="height: 3px">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width: 5px">
                                    </td>
                                    <td>
                                        <table>
                                            <tr>
                                                <td>
                                                    Use the 'Add Item to Invoice' button to add invoice items and the click the 'Generate
                                                    Invoice' button to create the PDF invoice for the added items.
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 5px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b>Customer Information</b>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                Name:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxCustomerName" runat="server" Text="Customer Name" Columns="50"
                                                                    MaxLength="50"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="nameRequired" runat="server" Text="*" ControlToValidate="textBoxCustomerName"
                                                                    Display="Dynamic"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Address #1:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxCustomerAddress" runat="server" Text="12345 This Street "
                                                                    Columns="50" MaxLength="50"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" Text="*"
                                                                    ControlToValidate="textBoxCustomerAddress" Display="Dynamic"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Address #2:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxAddress2" runat="server" Text="Anytown, CA 00000 " Columns="50"
                                                                    MaxLength="50"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="*"
                                                                    ControlToValidate="textBoxAddress2" Display="Dynamic"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Phone:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxCustomerPhone" runat="server" Text="Tel: (310) 555-555555"
                                                                    Columns="30" MaxLength="30"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*"
                                                                    ControlToValidate="textBoxCustomerPhone" Display="Dynamic"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Email:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxCustomerEmail" runat="server" Text="customer@email.com" Columns="30"
                                                                    MaxLength="30"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="*"
                                                                    ControlToValidate="textBoxCustomerEmail" Display="Dynamic"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <b>Add Item to Invoice:</b>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td>
                                                                Product Code:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxProductCode" runat="server" Text="123" Columns="10" MaxLength="10"
                                                                    Width="61px"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" Text="*"
                                                                    ControlToValidate="textBoxProductCode" Display="Dynamic"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Product Name:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxProductName" runat="server" Text="Product 1" Columns="50"
                                                                    MaxLength="50" Width="172px"></asp:TextBox>
                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="*"
                                                                    ControlToValidate="textBoxProductName" Display="Dynamic"></asp:RequiredFieldValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Product Description:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxProductDescription" runat="server" Text="Product 1 Description"
                                                                    Columns="100" MaxLength="100" Width="281px"></asp:TextBox>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Price:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxProductPrice" runat="server" Text="10" Columns="10" MaxLength="10"
                                                                    Width="59px"></asp:TextBox>
                                                                <asp:CustomValidator ID="cvPriceValidator" runat="server" Text="*" Display="Dynamic"
                                                                    OnServerValidate="cvPriceValidator_ServerValidate"></asp:CustomValidator>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                Quantity:
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                <asp:TextBox ID="textBoxProductQuantity" runat="server" Text="1" Columns="10" MaxLength="10"
                                                                    Width="58px"></asp:TextBox>
                                                                <asp:CustomValidator ID="cvQuantityValidator" runat="server" Text="*" Display="Dynamic"
                                                                    OnServerValidate="cvQuantityValidator_ServerValidate"></asp:CustomValidator>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Button ID="btnAddItem" runat="server" Text="Add Item to Invoice" OnClick="btnAddItem_Click" />&nbsp;
                                                    <asp:Button ID="btnReserItems" runat="server" Text="Reset Items" OnClick="btnReserItems_Click" />
                                                    &nbsp;&nbsp; Items currently added:&nbsp;
                                                    <asp:Label ID="lblItemsCount" runat="server" Font-Bold="True"></asp:Label>&nbsp;</td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblInvoiceTemplateMessage" runat="server" ForeColor="Red"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table>
                                                        <tr>
                                                            <td style="width: 162px">
                                                                <asp:Button ID="btnGenerateInvoice" runat="server" Text="Generate Invoice" OnClick="btnGenerateInvoice_Click"
                                                                    Width="166px" />
                                                            </td>
                                                            <td>
                                                                &nbsp;
                                                            </td>
                                                            <td>
                                                                &nbsp;<asp:LinkButton ID="lnkBtnPreviewReport" runat="server" OnClick="lnkBtnPreviewReport_Click">Preview report web page</asp:LinkButton></td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="center" style="height: 19px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left">
                                                    <b>Ivoice items:</b>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:GridView ID="itemsGrid" runat="server" Font-Names="Arial" Width="100%" CellPadding="5"
                                                        BorderStyle="Solid" AutoGenerateColumns="False">
                                                        <Columns>
                                                            <asp:BoundField DataField="ProductCode" HeaderText="Code">
                                                                <ItemStyle BackColor="AliceBlue" />
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="ProductName" HeaderText="Name"></asp:BoundField>
                                                            <asp:BoundField DataField="ProductDescription" HeaderText="Description"></asp:BoundField>
                                                            <asp:BoundField DataField="ProductPrice" HeaderText="Price" DataFormatString="{0:N2}">
                                                            </asp:BoundField>
                                                            <asp:BoundField DataField="Quantity" HeaderText="Quantity"></asp:BoundField>
                                                            <asp:BoundField DataField="ItemPrice" HeaderText="Item Price" DataFormatString="{0:N2}">
                                                                <ItemStyle HorizontalAlign="Center" BackColor="#E0E0E0" Font-Bold="True" />
                                                                <HeaderStyle HorizontalAlign="Center" />
                                                            </asp:BoundField>
                                                        </Columns>
                                                        <AlternatingRowStyle Font-Bold="False" Font-Italic="False" BackColor="WhiteSmoke" />
                                                        <RowStyle Font-Italic="False" />
                                                        <HeaderStyle BackColor="PeachPuff" />
                                                    </asp:GridView>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    &nbsp;
                                                </td>
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
