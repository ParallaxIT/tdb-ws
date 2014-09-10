<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="HtmlToPdfFeaturesDemo.aspx.cs" Inherits="EvoHtmlToPdfWebDemo.HtmlToPdfFeaturesDemo"
    Title="HTML to PDF Main Features Demo - EVO HTML to PDF Converter for .NET" %>

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
                HTML to PDF Main Features Demo
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 1px">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_description" style="height: 45px">
                To convert a web page to image or to PDF enter the web page full URL in the text
                box below and press 'Convert' button. To customize the converter press 'More Converter
                Settings'.
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
                                                <td align="left" style="width: 667px">
                                                    <table cellspacing="0" cellpadding="0" style="text-align: left">
                                                        <tr>
                                                            <td style="height: 29px; width: 634px;">
                                                                <table cellspacing="0" cellpadding="0">
                                                                    <tr>
                                                                        <td style="font-weight: bold">
                                                                            Enter URL:
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxWebPageURL" runat="server" Text="http://www.evopdf.com" Width="315px"></asp:TextBox>
                                                                        </td>
                                                                        <td>
                                                                            <asp:RequiredFieldValidator ID="urlRequired" runat="server" ControlToValidate="textBoxWebPageURL">*</asp:RequiredFieldValidator>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 634px">
                                                                <table cellspacing="0" cellpadding="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td style="width: 639px">
                                                                                <table style="width: 351px" id="convertTypeTable" cellspacing="0" cellpadding="0">
                                                                                    <tbody>
                                                                                        <tr>
                                                                                            <td style="height: 22px">
                                                                                                <asp:RadioButton ID="radioConvertToPdf" runat="server" Text="Convert to PDF" OnCheckedChanged="radioConvertToPdf_CheckedChanged"
                                                                                                    AutoPostBack="True" GroupName="ConvertFormat" Checked="True"></asp:RadioButton>
                                                                                            </td>
                                                                                        </tr>
                                                                                        <tr>
                                                                                            <td style="height: 22px">
                                                                                                <asp:RadioButton ID="radioConvertToImage" runat="server" Text="Convert to image"
                                                                                                    OnCheckedChanged="radioConvertToImage_CheckedChanged" AutoPostBack="True" GroupName="ConvertFormat">
                                                                                                </asp:RadioButton>
                                                                                            </td>
                                                                                        </tr>
                                                                                    </tbody>
                                                                                </table>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="width: 639px">
                                                                                &nbsp;
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="width: 639px">
                                                                                <asp:Panel ID="htmlConvertControlPanel" runat="server" Width="100%">
                                                                                    <table cellspacing="0" cellpadding="0" width="100%">
                                                                                        <tbody>
                                                                                            <tr>
                                                                                                <td>
                                                                                                    <table cellspacing="0" cellpadding="0" style="width: 635px">
                                                                                                        <tbody>
                                                                                                            <tr>
                                                                                                                <td>
                                                                                                                    <table cellpadding="0" cellspacing="0" style="width: 436px">
                                                                                                                        <tr>
                                                                                                                            <td style="width: 150px; height: 20px">
                                                                                                                                <asp:CheckBox ID="cbLiveLinksEnabled" runat="server" Text="Live HTTP links" Checked="True"
                                                                                                                                    ToolTip="Make the HTTP links live in the generated PDF"></asp:CheckBox>
                                                                                                                            </td>
                                                                                                                            <td style="width: 8px; height: 20px;">
                                                                                                                            </td>
                                                                                                                            <td style="height: 20px; width: 105px;">
                                                                                                                                <asp:CheckBox ID="cbBookmarks" runat="server" Text="Bookmarks" Checked="False" ToolTip="Bookmark H1 and H2 tags">
                                                                                                                                </asp:CheckBox>
                                                                                                                            </td>
                                                                                                                            <td style="width: 6px; height: 20px;">
                                                                                                                            </td>
                                                                                                                            <td style="width: 158px; height: 20px">
                                                                                                                                &nbsp;<asp:CheckBox ID="cbFitWidth" runat="server" Text="Fit Width" Checked="True"
                                                                                                                                    ToolTip="When is checked the HTML content will be resized if necessary to fit the PDF page">
                                                                                                                                </asp:CheckBox>
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                        <tr>
                                                                                                                            <td style="height: 28px; width: 150px;">
                                                                                                                                <asp:CheckBox ID="cbScriptsEnabled" runat="server" Text="JavaScript Enabled" Checked="True"
                                                                                                                                    ToolTip="Enable JavaScripts and Java applets during conversion"></asp:CheckBox>
                                                                                                                            </td>
                                                                                                                            <td style="width: 8px">
                                                                                                                            </td>
                                                                                                                            <td style="width: 105px">
                                                                                                                                <asp:CheckBox ID="cbEmbedFonts" runat="server" Text="Embed Fonts" Checked="True"
                                                                                                                                    
                                                                                                                                    ToolTip="When is checked the true type fonts will be embedded in the PDF document">
                                                                                                                                </asp:CheckBox>
                                                                                                                            </td>
                                                                                                                            <td style="width: 6px">
                                                                                                                            </td>
                                                                                                                            <td style="width: 158px">
                                                                                                                                &nbsp;<asp:CheckBox ID="cbJpegCompression" runat="server" Text="JPEG Compression"
                                                                                                                                    Checked="True" ToolTip="When is checked the images are compressed with JPEG in PDF"
                                                                                                                                    Width="145px"></asp:CheckBox>
                                                                                                                            </td>
                                                                                                                        </tr>
                                                                                                                    </table>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                            <tr>
                                                                                                                <td style="height: 15px">
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                            <tr>
                                                                                                                <td style="height: 15px">
                                                                                                                    <asp:LinkButton ID="lnkBtnSettings" OnClick="lnkBtnSettings_Click" runat="server">More Converter Features >></asp:LinkButton>
                                                                                                                </td>
                                                                                                            </tr>
                                                                                                        </tbody>
                                                                                                    </table>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </tbody>
                                                                                    </table>
                                                                                </asp:Panel>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="width: 639px">
                                                                                <asp:Panel ID="pnlRenderMoreOptions" runat="server" Visible="false">
                                                                                    <table cellspacing="0" cellpadding="0" style="width: 616px">
                                                                                        <tbody>
                                                                                            <tr>
                                                                                                <td style="width: 424px">
                                                                                                    &nbsp;
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td style="width: 424px">
                                                                                                    <asp:Panel ID="pnlRenderCommonOptions" runat="server">
                                                                                                        <table style="width: 292px" id="commonOptionsTable" cellspacing="0" cellpadding="0">
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td style="font-weight: bold; width: 246px; height: 30px">
                                                                                                                        HTML Viewer Size:
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td>
                                                                                                                        <table cellspacing="0" cellpadding="0">
                                                                                                                            <tbody>
                                                                                                                                <tr>
                                                                                                                                    <td style="width: 136px">
                                                                                                                                        HTML viewer width:
                                                                                                                                    </td>
                                                                                                                                    <td style="width: 6px">
                                                                                                                                    </td>
                                                                                                                                    <td>
                                                                                                                                        <asp:TextBox ID="textBoxHtmlViewerWidth" runat="server" Columns="4" MaxLength="10">1024</asp:TextBox>
                                                                                                                                    </td>
                                                                                                                                    <td>
                                                                                                                                        &nbsp;px&nbsp;
                                                                                                                                    </td>
                                                                                                                                    <td style="width: 11px">
                                                                                                                                        <asp:CustomValidator ID="cvHtmlViewerWidth" runat="server" Display="Dynamic" OnServerValidate="cvHtmlViewerWidth_ServerValidate"
                                                                                                                                            Width="6px">*</asp:CustomValidator>
                                                                                                                                    </td>
                                                                                                                                </tr>
                                                                                                                                <tr>
                                                                                                                                    <td style="width: 136px">
                                                                                                                                        HTML viewer height:
                                                                                                                                    </td>
                                                                                                                                    <td style="width: 6px">
                                                                                                                                    </td>
                                                                                                                                    <td>
                                                                                                                                        <asp:TextBox ID="textBoxHtmlViewerHeight" runat="server" Columns="4" MaxLength="10">0</asp:TextBox>
                                                                                                                                    </td>
                                                                                                                                    <td>
                                                                                                                                        &nbsp;px
                                                                                                                                    </td>
                                                                                                                                    <td style="width: 11px">
                                                                                                                                        <asp:CustomValidator ID="cvHtmlViewerHeight" runat="server" Display="Dynamic" OnServerValidate="cvHtmlViewerHeight_ServerValidate"
                                                                                                                                            Width="6px">*</asp:CustomValidator>
                                                                                                                                    </td>
                                                                                                                                </tr>
                                                                                                                            </tbody>
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td style="font-weight: bold; width: 246px; height: 10px">
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td style="font-weight: bold; width: 246px; height: 30px">
                                                                                                                        Authentication Options:
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td>
                                                                                                                        <table cellspacing="0" cellpadding="0">
                                                                                                                            <tr>
                                                                                                                                <td>
                                                                                                                                    Username:
                                                                                                                                </td>
                                                                                                                                <td style="width: 27px">
                                                                                                                                    <asp:TextBox ID="textBoxAuthUsername" runat="server" Width="202px"></asp:TextBox>
                                                                                                                                </td>
                                                                                                                                <td>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="height: 2px">
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td>
                                                                                                                                    Password:
                                                                                                                                </td>
                                                                                                                                <td style="width: 27px">
                                                                                                                                    <asp:TextBox ID="textBoxAuthPassword" runat="server" Width="202px"></asp:TextBox>
                                                                                                                                </td>
                                                                                                                                <td>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td style="font-weight: bold; width: 246px; height: 10px">
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td style="font-weight: bold; width: 246px; height: 30px">
                                                                                                                        Navigation Options:
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td>
                                                                                                                        <table cellspacing="0" cellpadding="0" style="width: 258px">
                                                                                                                            <tr>
                                                                                                                                <td style="width: 139px">
                                                                                                                                    Conversion Delay:
                                                                                                                                </td>
                                                                                                                                <td style="width: 65px">
                                                                                                                                    <asp:TextBox ID="textBoxConversionDelay" runat="server" Columns="4" MaxLength="10">2</asp:TextBox>&nbsp;
                                                                                                                                </td>
                                                                                                                                <td>
                                                                                                                                    sec&nbsp;<asp:CustomValidator ID="cvConversionDelay" runat="server" Display="Dynamic"
                                                                                                                                        OnServerValidate="cvConversionDelay_ServerValidate">*</asp:CustomValidator>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="width: 139px; height: 3px;">
                                                                                                                                </td>
                                                                                                                                <td style="width: 65px; height: 3px">
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="width: 139px">
                                                                                                                                    Navigation Timeout:
                                                                                                                                </td>
                                                                                                                                <td style="width: 65px">
                                                                                                                                    <asp:TextBox ID="textBoxNavigationTimeout" runat="server" Columns="4" MaxLength="10">60</asp:TextBox>
                                                                                                                                </td>
                                                                                                                                <td>
                                                                                                                                    sec&nbsp;<asp:CustomValidator ID="cvNavigationTimeout" runat="server" Display="Dynamic"
                                                                                                                                        OnServerValidate="cvNavigationTimeout_ServerValidate">*</asp:CustomValidator>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </tbody>
                                                                                                        </table>
                                                                                                    </asp:Panel>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td style="width: 424px">
                                                                                                    <asp:Panel ID="pnlImageRenderOptions" runat="server" Visible="false">
                                                                                                        <table cellspacing="0" cellpadding="0" style="width: 197px">
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td colspan="3" style="height: 10px">
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td style="font-weight: bold; width: 110px;">
                                                                                                                        Image format:
                                                                                                                    </td>
                                                                                                                    <td style="width: 2px">
                                                                                                                        &nbsp;
                                                                                                                    </td>
                                                                                                                    <td>
                                                                                                                        <asp:DropDownList ID="ddlImageFormat" runat="server">
                                                                                                                        </asp:DropDownList>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </tbody>
                                                                                                        </table>
                                                                                                    </asp:Panel>
                                                                                                </td>
                                                                                            </tr>
                                                                                            <tr>
                                                                                                <td style="width: 424px">
                                                                                                    <asp:Panel ID="pnlPDFRenderOptions" runat="server">
                                                                                                        <table id="PDFRenderOptionsTable" cellspacing="0" cellpadding="0" style="width: 589px">
                                                                                                            <tbody>
                                                                                                                <tr>
                                                                                                                    <td colspan="2" style="height: 10px">
                                                                                                                        &nbsp;
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td style="font-weight: bold" colspan="2">
                                                                                                                        PDF Document Options:
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2">
                                                                                                                        &nbsp;
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2">
                                                                                                                        <table cellspacing="0" cellpadding="0">
                                                                                                                            <tr>
                                                                                                                                <td style="height: 23px">
                                                                                                                                    PDF page format:
                                                                                                                                </td>
                                                                                                                                <td style="width: 12px">
                                                                                                                                </td>
                                                                                                                                <td style="width: 64px; height: 23px;">
                                                                                                                                    <asp:DropDownList ID="ddlPDFPageFormat" runat="server">
                                                                                                                                        <asp:ListItem>A0</asp:ListItem>
                                                                                                                                        <asp:ListItem>A1</asp:ListItem>
                                                                                                                                        <asp:ListItem>A2</asp:ListItem>
                                                                                                                                        <asp:ListItem>A3</asp:ListItem>
                                                                                                                                        <asp:ListItem>A4</asp:ListItem>
                                                                                                                                        <asp:ListItem>A5</asp:ListItem>
                                                                                                                                        <asp:ListItem>A6</asp:ListItem>
                                                                                                                                        <asp:ListItem>A7</asp:ListItem>
                                                                                                                                        <asp:ListItem>A8</asp:ListItem>
                                                                                                                                        <asp:ListItem>A9</asp:ListItem>
                                                                                                                                        <asp:ListItem>A10</asp:ListItem>
                                                                                                                                        <asp:ListItem>B0</asp:ListItem>
                                                                                                                                        <asp:ListItem>B1</asp:ListItem>
                                                                                                                                        <asp:ListItem>B2</asp:ListItem>
                                                                                                                                        <asp:ListItem>B3</asp:ListItem>
                                                                                                                                        <asp:ListItem>B4</asp:ListItem>
                                                                                                                                        <asp:ListItem>B5</asp:ListItem>
                                                                                                                                        <asp:ListItem>ArchA</asp:ListItem>
                                                                                                                                        <asp:ListItem>ArchB</asp:ListItem>
                                                                                                                                        <asp:ListItem>ArchC</asp:ListItem>
                                                                                                                                        <asp:ListItem>ArchD</asp:ListItem>
                                                                                                                                        <asp:ListItem>ArchE</asp:ListItem>
                                                                                                                                        <asp:ListItem>Flsa</asp:ListItem>
                                                                                                                                        <asp:ListItem>HalfLetter</asp:ListItem>
                                                                                                                                        <asp:ListItem>Ledger</asp:ListItem>
                                                                                                                                        <asp:ListItem>Legal</asp:ListItem>
                                                                                                                                        <asp:ListItem>Letter</asp:ListItem>
                                                                                                                                        <asp:ListItem>Letter11x17</asp:ListItem>
                                                                                                                                        <asp:ListItem>Note</asp:ListItem>
                                                                                                                                    </asp:DropDownList>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="height: 23px">
                                                                                                                                    PDF Compression Level:
                                                                                                                                </td>
                                                                                                                                <td style="width: 12px">
                                                                                                                                </td>
                                                                                                                                <td style="width: 64px; height: 23px;">
                                                                                                                                    <asp:DropDownList ID="ddlCompressionLevel" runat="server">
                                                                                                                                    </asp:DropDownList>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="height: 23px">
                                                                                                                                    PDF Page Orientation:
                                                                                                                                </td>
                                                                                                                                <td style="width: 12px">
                                                                                                                                </td>
                                                                                                                                <td style="width: 64px; height: 23px">
                                                                                                                                    <asp:DropDownList ID="ddlPageOrientation" runat="server">
                                                                                                                                    </asp:DropDownList>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                            <tr>
                                                                                                                                <td style="height: 23px">
                                                                                                                                    PDF Standard:
                                                                                                                                </td>
                                                                                                                                <td style="width: 12px">
                                                                                                                                </td>
                                                                                                                                <td style="width: 64px; height: 23px;">
                                                                                                                                    <asp:DropDownList ID="ddlPdfSubset" runat="server">
                                                                                                                                    </asp:DropDownList>
                                                                                                                                </td>
                                                                                                                            </tr>
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2" style="height: 10px">
                                                                                                                        &nbsp;
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2">
                                                                                                                        <table cellspacing="0" cellpadding="0">
                                                                                                                            <tbody>
                                                                                                                                <tr>
                                                                                                                                    <td style="height: 24px" colspan="3">
                                                                                                                                        <strong>Header &amp; Footer:</strong>
                                                                                                                                    </td>
                                                                                                                                </tr>
                                                                                                                                <tr>
                                                                                                                                    <td style="height: 20px">
                                                                                                                                        <asp:CheckBox ID="cbShowHeader" runat="server" Text="Show header" OnCheckedChanged="cbShowheader_CheckedChanged"
                                                                                                                                            AutoPostBack="true"></asp:CheckBox>
                                                                                                                                    </td>
                                                                                                                                    <td style="height: 20px; width: 16px;">
                                                                                                                                        &nbsp;
                                                                                                                                    </td>
                                                                                                                                    <td style="height: 20px">
                                                                                                                                        <asp:CheckBox ID="cbShowFooter" runat="server" Text="Show Footer" OnCheckedChanged="cbShowFooter_CheckedChanged"
                                                                                                                                            AutoPostBack="true"></asp:CheckBox>
                                                                                                                                    </td>
                                                                                                                                </tr>
                                                                                                                            </tbody>
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2">
                                                                                                                        <asp:Panel ID="pnlPDFHeaderOptions" runat="server" Visible="false">
                                                                                                                            <table cellspacing="0" cellpadding="0" style="width: 468px">
                                                                                                                                <tbody>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2">
                                                                                                                                            &nbsp;
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td style="font-weight: bold;" colspan="2">
                                                                                                                                            PDF Header Options:
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2">
                                                                                                                                            &nbsp;
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td style="width: 120px">
                                                                                                                                            Header Height:
                                                                                                                                        </td>
                                                                                                                                        <td>
                                                                                                                                            <asp:TextBox ID="textBoxHeaderHeight" runat="server" Width="30px">40</asp:TextBox>
                                                                                                                                            pt
                                                                                                                                            <asp:CustomValidator ID="cvHeaderHeight" runat="server" Display="Dynamic" OnServerValidate="cvHeaderHeight_ServerValidate">*</asp:CustomValidator>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td style="width: 120px">
                                                                                                                                            Header Line Color:
                                                                                                                                        </td>
                                                                                                                                        <td>
                                                                                                                                            <asp:DropDownList ID="ddlHeaderLineColor" runat="server">
                                                                                                                                            </asp:DropDownList>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2">
                                                                                                                                            <asp:CheckBox ID="cbDrawHeaderLine" runat="server" Text="Draw Header Line" Checked="True">
                                                                                                                                            </asp:CheckBox>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2">
                                                                                                                                            <asp:CheckBox ID="cbShowHeaderOnFirstPage" runat="server" Checked="True" Text="Show On First Page" />&nbsp;<asp:CheckBox
                                                                                                                                                ID="cbShowHeaderOnOddPages" runat="server" Checked="True" Text="Show On Odd Pages" />&nbsp;<asp:CheckBox
                                                                                                                                                    ID="cbShowHeaderOnEvenPages" runat="server" Checked="True" Text="Show On Even Pages" />
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                </tbody>
                                                                                                                            </table>
                                                                                                                        </asp:Panel>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2">
                                                                                                                        <asp:Panel ID="pnlPDFFooterOptions" runat="server" Visible="false">
                                                                                                                            <table cellspacing="0" cellpadding="0" style="width: 468px">
                                                                                                                                <tbody>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2">
                                                                                                                                            &nbsp;
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2" style="font-weight: bold;">
                                                                                                                                            PDF Footer Options:
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2">
                                                                                                                                            &nbsp;
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td style="width: 120px">
                                                                                                                                            Footer Height:
                                                                                                                                        </td>
                                                                                                                                        <td style="height: 23px">
                                                                                                                                            <asp:TextBox ID="textBoxFooterHeight" runat="server" Width="30px">40</asp:TextBox>
                                                                                                                                            pt
                                                                                                                                            <asp:CustomValidator ID="cvFooterHeight" runat="server" Display="Dynamic" OnServerValidate="cvFooterHeight_ServerValidate">*</asp:CustomValidator>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td style="width: 120px">
                                                                                                                                            Footer Line Color:
                                                                                                                                        </td>
                                                                                                                                        <td style="height: 23px">
                                                                                                                                            <asp:DropDownList ID="ddlFooterLineColor" runat="server">
                                                                                                                                            </asp:DropDownList>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2">
                                                                                                                                            <asp:CheckBox ID="cbDrawFooterLine" runat="server" Text="Draw Footer Line" Checked="True">
                                                                                                                                            </asp:CheckBox>
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                    <tr>
                                                                                                                                        <td colspan="2" style="height: 23px">
                                                                                                                                            <asp:CheckBox ID="cbShowFooterOnFirstPage" runat="server" Checked="True" Text="Show On First Page" />&nbsp;<asp:CheckBox
                                                                                                                                                ID="cbShowFooterOnOddPages" runat="server" Checked="True" Text="Show On Odd Pages" />&nbsp;<asp:CheckBox
                                                                                                                                                    ID="cbShowFooterOnEvenPages" runat="server" Checked="True" Text="Show On Even Pages" />
                                                                                                                                        </td>
                                                                                                                                    </tr>
                                                                                                                                </tbody>
                                                                                                                            </table>
                                                                                                                        </asp:Panel>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2" style="height: 10px">
                                                                                                                        &nbsp;
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2">
                                                                                                                        <table cellspacing="0" cellpadding="0">
                                                                                                                            <tbody>
                                                                                                                                <tr>
                                                                                                                                    <td style="height: 25px">
                                                                                                                                        <strong>Document Margins:</strong>
                                                                                                                                    </td>
                                                                                                                                </tr>
                                                                                                                                <tr>
                                                                                                                                    <td>
                                                                                                                                        <table cellspacing="0" cellpadding="0">
                                                                                                                                            <tbody>
                                                                                                                                                <tr>
                                                                                                                                                    <td>
                                                                                                                                                        Left:
                                                                                                                                                        <asp:TextBox ID="textBoxLeftMargin" runat="server" Columns="5" MaxLength="10">0</asp:TextBox>
                                                                                                                                                        pt
                                                                                                                                                        <asp:CustomValidator ID="cvLeftMargin" runat="server" OnServerValidate="cvLeftMargin_ServerValidate"
                                                                                                                                                            Display="Dynamic">*</asp:CustomValidator>
                                                                                                                                                    </td>
                                                                                                                                                    <td style="width: 16px">
                                                                                                                                                        &nbsp;
                                                                                                                                                    </td>
                                                                                                                                                    <td>
                                                                                                                                                        Right: &nbsp; &nbsp;
                                                                                                                                                        <asp:TextBox ID="textBoxRightMargin" runat="server" Columns="5" MaxLength="10">0</asp:TextBox>
                                                                                                                                                        pt
                                                                                                                                                        <asp:CustomValidator ID="cvRightMargin" runat="server" OnServerValidate="cvRightMargin_ServerValidate"
                                                                                                                                                            Display="Dynamic">*</asp:CustomValidator>
                                                                                                                                                    </td>
                                                                                                                                                </tr>
                                                                                                                                                <tr>
                                                                                                                                                    <td>
                                                                                                                                                        Top:
                                                                                                                                                        <asp:TextBox ID="textBoxTopMargin" runat="server" Columns="5" MaxLength="10">0</asp:TextBox>
                                                                                                                                                        pt
                                                                                                                                                        <asp:CustomValidator ID="cvTopMargin" runat="server" OnServerValidate="cvTopMargin_ServerValidate"
                                                                                                                                                            Display="Dynamic">*</asp:CustomValidator>
                                                                                                                                                    </td>
                                                                                                                                                    <td style="width: 16px">
                                                                                                                                                        &nbsp;
                                                                                                                                                    </td>
                                                                                                                                                    <td>
                                                                                                                                                        Bottom: &nbsp;<asp:TextBox ID="textBoxBottomMargin" runat="server" Columns="5" MaxLength="10">0</asp:TextBox>
                                                                                                                                                        pt
                                                                                                                                                        <asp:CustomValidator ID="cvBottomMargin" runat="server" OnServerValidate="cvBottomMargin_ServerValidate"
                                                                                                                                                            Display="Dynamic">*</asp:CustomValidator>
                                                                                                                                                    </td>
                                                                                                                                                </tr>
                                                                                                                                            </tbody>
                                                                                                                                        </table>
                                                                                                                                    </td>
                                                                                                                                </tr>
                                                                                                                            </tbody>
                                                                                                                        </table>
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2" style="height: 10px">
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                                <tr>
                                                                                                                    <td colspan="2">
                                                                                                                        <asp:CheckBox ID="cbAvoidImageBreak" runat="server" Text="Avoid image break" Font-Bold="True" />
                                                                                                                    </td>
                                                                                                                </tr>
                                                                                                            </tbody>
                                                                                                        </table>
                                                                                                    </asp:Panel>
                                                                                                </td>
                                                                                            </tr>
                                                                                        </tbody>
                                                                                    </table>
                                                                                </asp:Panel>
                                                                                &nbsp;&nbsp;
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 634px">
                                                                <asp:Label ID="lblConvertMessage" runat="server" ForeColor="Red"></asp:Label>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 634px">
                                                                &nbsp;
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 634px">
                                                                <asp:Button runat="server" Text="Convert" ID="btnConvert" OnClick="btnConvert_Click" />
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
                </table>
            </td>
        </tr>
        <tr>
            <td>
            </td>
        </tr>
    </table>
</asp:Content>
