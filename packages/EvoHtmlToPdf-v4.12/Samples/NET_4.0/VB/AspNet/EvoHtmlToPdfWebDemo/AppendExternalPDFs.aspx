<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="AppendExternalPDFs.aspx.vb" Inherits="EvoHtmlToPdfWebDemo.AppendExternalPDFs"
    Title="Append External PDF Documents" %>

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
                Append External PDF Documents
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 1px">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_description" style="height: 45px">
                This demo shows you how to use the built-in merge capabilities of the EVO HTML to
                PDF Converter for .NET to convert many URLs to PDF and merge them into a single
                final PDF document.
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
                                                    Click the button to convert the URLs to PDF and merge the conversion results into
                                                    a single PDF.
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
                                                                            URL 1:
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxWebPageURL1" runat="server" Text="http://www.evopdf.com"
                                                                                Width="315px"></asp:TextBox>
                                                                        </td>
                                                                        <td>
                                                                            <asp:RequiredFieldValidator ID="urlRequired1" runat="server" ControlToValidate="textBoxWebPageURL1">*</asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="4" style="height: 5px">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="font-weight: bold">
                                                                            URL 2:
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxWebPageURL2" runat="server" Text="http://www.google.com"
                                                                                Width="315px"></asp:TextBox>
                                                                        </td>
                                                                        <td>
                                                                            <asp:RequiredFieldValidator ID="urlRequired2" runat="server" ControlToValidate="textBoxWebPageURL2">*</asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td colspan="4" style="height: 5px">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="font-weight: bold">
                                                                            URL 3:
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxWebPageURL3" runat="server" Text="http://www.evopdf.com/urltopdf/htmlbook/book.htm"
                                                                                Width="315px"></asp:TextBox>
                                                                        </td>
                                                                        <td>
                                                                            <asp:RequiredFieldValidator ID="urlRequired3" runat="server" ControlToValidate="textBoxWebPageURL3">*</asp:RequiredFieldValidator>
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
                                                    <asp:Label ID="lblConvertMessage" runat="server" ForeColor="Red"></asp:Label>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <asp:Button runat="server" Text="Convert to PDF and Merge" ID="btnConvert" OnClick="btnConvert_Click" />&nbsp;&nbsp;
                                                    &nbsp; &nbsp;
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
