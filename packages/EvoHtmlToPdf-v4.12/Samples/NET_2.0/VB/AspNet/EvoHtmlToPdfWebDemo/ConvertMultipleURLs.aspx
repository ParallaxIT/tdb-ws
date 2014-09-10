<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    Codebehind="ConvertMultipleURLs.aspx.vb" Inherits="EvoHtmlToPdfWebDemo.ConvertMultipleURLs"
    Title="Convert Multiple Web Pages Into the Same PDF" %>

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
                Combine Multiple Web Pages Into the Same PDF Demo
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 1px">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_description" style="height: 45px">
                This demo shows how to convert multiple URLs into the same PDF document. There is
                also an option to specify if the result of the conversion of an URL starts right
                after the previous conversion or on a new PDF page.
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
                                                    Click the button to add the content from the two web pages into the same PDF document.
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 5px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td align="left" style="width: 100%">
                                                    <table cellspacing="0" cellpadding="0" style="text-align: left; width: 100%">
                                                        <tr>
                                                            <td style="height: 33px">
                                                                <table cellspacing="0" cellpadding="0">
                                                                    <tr>
                                                                        <td style="font-weight: bold">
                                                                            Enter First URL:</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxURL1" runat="server" Text="http://www.evopdf.com" Width="315px"></asp:TextBox></td>
                                                                        <td>
                                                                            <asp:RequiredFieldValidator ID="urlRequired" runat="server" ControlToValidate="textBoxURL1">*</asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="4" style="height: 12px">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="font-weight: bold">
                                                                            Enter Second URL:</td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxURL2" runat="server" Text="http://www.google.com" Width="315px"></asp:TextBox></td>
                                                                        <td>
                                                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textBoxURL2">*</asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 12px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 5px">
                                                    <asp:CheckBox ID="cbAddHeader" runat="server" Text="Add Header" ToolTip="Add a HTML header to the rendered PDF document" />&nbsp;&nbsp;
                                                    &nbsp;
                                                    <asp:CheckBox ID="cbAddFooter" runat="server" Text="Add Footer" ToolTip="Add
                                                a footer to the rendered PDF document" Checked="True" />
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 12px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 5px">
                                                    <asp:CheckBox ID="cbStartOnNewPage" runat="server" Text="Start second URL conversion on a new PDF page"
                                                        ToolTip="Start second URL conversion on a new PDF page" /></td>
                                            </tr>
                                            <tr>
                                                <td style="height: 12px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Label ID="lblConvertMessage" runat="server" ForeColor="Red"></asp:Label></td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Button runat="server" Text="Convert to PDF" ID="btnConvert" OnClick="btnConvert_Click" />&nbsp;&nbsp;
                                                    &nbsp; &nbsp;</td>
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
