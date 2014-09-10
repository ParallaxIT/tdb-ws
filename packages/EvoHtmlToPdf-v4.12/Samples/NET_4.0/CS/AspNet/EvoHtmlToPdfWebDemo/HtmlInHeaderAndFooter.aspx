<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    Codebehind="HtmlInHeaderAndFooter.aspx.cs" Inherits="EvoHtmlToPdfWebDemo.HtmlInHeaderAndFooter"
    Title="HTML in Header and Footer" %>

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
                HTML in Header and Footer
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 1px">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_description" style="height: 45px">
                This demo shows how to add HTML in the header and footer of the generated PDF document
                and how to add page numbers in the footer. It also offers the possibility to alternate
                the header and footer content for the consecutive PDF pages.
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
                                        <!-- demo content -->
                                        <table>
                                            <tr>
                                                <td>
                                                    Click the button to create a PDF with HTML in header and footer. Check on the 'Alternate
                                                    Header and Footer Content' checkbox to change the header and footer content on the
                                                    even pages.
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 5px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="text-align: left; width: 100%">
                                                    <table cellspacing="0" cellpadding="0" style="text-align: left; width: 100%">
                                                        <tr>
                                                            <td style="height: 29px">
                                                                <table cellspacing="0" cellpadding="0">
                                                                    <tr>
                                                                        <td style="font-weight: bold">
                                                                            Enter URL:</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxWebPageURL" runat="server" Text="http://www.evopdf.com/urltopdf/htmlbook/book.htm" Width="315px"></asp:TextBox></td>
                                                                        <td>
                                                                            <asp:RequiredFieldValidator ID="urlRequired" runat="server" ControlToValidate="textBoxWebPageURL">*</asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 5px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblConvertMessage" runat="server" ForeColor="Red"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Button runat="server" Text="Convert to PDF" ID="btnConvert" OnClick="btnConvert_Click" />&nbsp;&nbsp;
                                                    &nbsp; &nbsp; &nbsp;<asp:CheckBox ID="cbAlternateHeaderAndFooter" runat="server"
                                                        Text="Alternate Header and Footer Content" /></td>
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
