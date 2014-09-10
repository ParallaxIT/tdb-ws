<%@ Page Language="C#" AutoEventWireup="true" Codebehind="InvoiceTemplate.aspx.cs"
    Inherits="EvoHtmlToPdfWebDemo.InvoiceTemplate" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Invoice Template</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table width="800">
                <tr>
                    <td style="width: 100%">
                        <table>
                            <tr>
                                <td style="width: 787px" align="center">
                                    <a href="http://www.evopdf.com">
                                        <img alt="Logo Image" src="images/logo.jpg" /></a>
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
                    <td style="width: 100%; height: 163px;">
                        <table border="0" width="100%">
                            <tr>
                                <td style="font-family: Arial">
                                    <table border="0">
                                        <tr>
                                            <td style="font-weight: bold">
                                                <asp:Literal ID="litCustomerName" runat="server"></asp:Literal></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Literal ID="litCustomerAddress1" runat="server"></asp:Literal>&nbsp;</td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Literal ID="litCustomerAddress2" runat="server"></asp:Literal></td>
                                        </tr>
                                        <tr>
                                            <td>
                                                <asp:Literal ID="litCustomerPhone" runat="server"></asp:Literal></td>
                                        </tr>
                                        <tr>
                                            <td style="color: blue">
                                                <asp:Literal ID="litCustomerEmail" runat="server"></asp:Literal></td>
                                        </tr>
                                    </table>
                                </td>
                                <td valign="top" style="width: 395px" align="right">
                                    <table border="0">
                                        <tr>
                                            <td style="background-color: #F5F5F5; font-weight: bold; font-family: Arial;" align="left">
                                                Invoice Date
                                            </td>
                                            <td>
                                                &nbsp;</td>
                                            <td style="background-color: #F5F5F5; font-weight: bold; font-family: Arial;" align="left">
                                                Invoice Num
                                            </td>
                                        </tr>
                                        <tr>
                                            <td align="left">
                                                <asp:Literal ID="litInvoiceDate" runat="server"></asp:Literal>&nbsp;</td>
                                            <td>
                                                &nbsp;</td>
                                            <td align="left">
                                                <asp:Literal ID="litInvoiceNum" runat="server"></asp:Literal></td>
                                        </tr>
                                    </table>
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="height: 33px; font-weight: bold; font-family: Arial;">
                        Report Items:</td>
                </tr>
                <tr>
                    <td align="left" style="width: 100%;">
                        <table width="100%">
                            <tr>
                                <td>
                                    <asp:GridView ID="itemsGrid" runat="server" AutoGenerateColumns="False" BorderStyle="Double"
                                        CellPadding="5" Width="100%" Font-Names="Arial">
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
                        </table>
                    </td>
                </tr>
                <tr>
                    <td style="height: 21px; width: 754px;">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 754px">
                        <table border="0">
                            <tr>
                                <td>
                                </td>
                                <td>
                                    <asp:Label ID="lblTotal" runat="server" Font-Bold="True" Font-Size="Medium" Font-Underline="True"
                                        ForeColor="Blue" Text="Total: " Font-Names="Arial"></asp:Label></td>
                                <td>
                                    &nbsp;
                                </td>
                                <td>
                                    <asp:Label ID="lblTotalPrice" runat="server" Font-Bold="True" ForeColor="Black" BackColor="#E0E0E0"
                                        Font-Names="Arial"></asp:Label></td>
                            </tr>
                        </table>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
