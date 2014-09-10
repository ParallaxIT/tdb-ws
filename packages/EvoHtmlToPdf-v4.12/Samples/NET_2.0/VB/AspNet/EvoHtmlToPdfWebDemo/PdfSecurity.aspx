<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    Codebehind="PdfSecurity.aspx.vb" Inherits="EvoHtmlToPdfWebDemo.PdfSecurity" Title="PDF Security and Permissions" %>

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
                PDF Security and Permissions
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 1px">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_description" style="height: 45px">
                This demo shows how to set the security options for the generated PDF document.
                The generated PDF document is password protected with an User and an Owner password.
                The User password is <b>'user'</b> and the Owner password is <b>'owner'</b>. When
                the PDF document is opened by owner its security properties can be changed. If the
                document is opened by an user the security properties of the document cannot be
                changed.<br />
                <br />
                The demo also restricts the right to print or copy the generated PDF document content
                when the document is opened by an user. Other restrictions like the right to edit
                the document content can be applied.
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
                                                    Click the button to create a password protected PDF which does not allow content
                                                    printing or copying. The user password to open the document is <b>'user'</b> and
                                                    the owner password is <b>'owner'</b>.
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
                                                                            <asp:TextBox ID="textBoxWebPageURL" runat="server" Text="http://www.evopdf.com" Width="315px"></asp:TextBox></td>
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
