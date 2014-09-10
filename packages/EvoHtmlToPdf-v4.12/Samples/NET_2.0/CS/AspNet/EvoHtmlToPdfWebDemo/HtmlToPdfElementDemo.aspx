<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    Codebehind="HtmlToPdfElementDemo.aspx.cs" Inherits="EvoHtmlToPdfWebDemo.HtmlToPdfElementDemo"
    Title="HTML to PDF Elements and HTML to Image Elements Demo" %>

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
                HTML to PDF Elements and HTML to Image Elements Demo
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 1px">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_description" style="height: 45px">
                This sample shows how to add HtmlToPdfElement and HtmlToImageElement objects to
                an empty Document object. To convert a web page to PDF enter the web page full URL
                in the text box below and press 'Convert to PDF' button.
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
                                                    Click the button to place a HTML to PDF Element or a HTML to Image Element in any
                                                    position in PDF.
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 5px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 50px">
                                                    <table cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td colspan="3" style="font-weight: bold; height: 13px;">
                                                                Select HTML source:</td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="3" style="height: 5px">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 20px">
                                                                <asp:RadioButton ID="radioConvertURL" runat="server" GroupName="SelectConvertSource"
                                                                    Text="Convert URL" AutoPostBack="True" OnCheckedChanged="radioConvertURL_CheckedChanged"
                                                                    Checked="True" Font-Bold="False" />
                                                            </td>
                                                            <td style="height: 20px; width: 20px">
                                                            </td>
                                                            <td style="height: 20px">
                                                                <asp:RadioButton ID="radioConvertHTML" runat="server" GroupName="SelectConvertSource"
                                                                    Text="Convert HTML String" AutoPostBack="True" OnCheckedChanged="radioConvertHTML_CheckedChanged"
                                                                    Font-Bold="False" />
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
                                                <td style="text-align: left; width: 100%">
                                                    <asp:Panel ID="pnlConvertURL" runat="server" Width="100%">
                                                        <table cellspacing="0" cellpadding="0" style="text-align: left; width: 100%">
                                                            <tr>
                                                                <td style="height: 29px">
                                                                    <table cellspacing="0" cellpadding="0">
                                                                        <tr>
                                                                            <td style="font-weight: bold; height: 24px;">
                                                                                Enter URL:</td>
                                                                            <td style="height: 24px">
                                                                                &nbsp;</td>
                                                                            <td style="height: 24px">
                                                                                <asp:TextBox ID="textBoxWebPageURL" runat="server" Text="http://www.evopdf.com" Width="315px"></asp:TextBox></td>
                                                                            <td style="height: 24px">
                                                                                <asp:RequiredFieldValidator ID="urlRequired" runat="server" ControlToValidate="textBoxWebPageURL">*</asp:RequiredFieldValidator>
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                    <asp:Panel ID="pnlConvertHTML" runat="server" Width="100%" Visible="false">
                                                        <table cellspacing="0" cellpadding="0" style="text-align: left; width: 100%">
                                                            <tr>
                                                                <td style="height: 29px">
                                                                    <table cellspacing="0" cellpadding="0">
                                                                        <tr>
                                                                            <td style="height: 29px">
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="font-weight: bold; width: 147px;" valign="top">
                                                                                Enter HTML Code:</td>
                                                                            <td>
                                                                                &nbsp;</td>
                                                                            <td style="width: 400px">
                                                                                <asp:TextBox ID="textBoxHTMLCode" runat="server" Width="400px" Height="202px" TextMode="MultiLine">&lt;!DOCTYPE html PUBLIC &quot;-//W3C//DTD XHTML 1.0 Transitional//EN&quot; &quot;http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd&quot;&gt;
&lt;html xmlns=&quot;http://www.w3.org/1999/xhtml&quot;&gt;
&lt;head&gt;
    &lt;title&gt;Evo HTML to PDF - Convert HTML String to Pdf&lt;/title&gt;
&lt;/head&gt;
&lt;body&gt;
    &lt;span style=&quot;background-color: White; color: Navy; font-family: Verdana; font-size: 14pt&quot;&gt;
        &lt;b&gt;&lt;i&gt;This is a simple HTML string to convert to PDF&lt;/i&gt;&lt;/b&gt; &lt;/span&gt;
    &lt;br /&gt;
    &lt;br /&gt;
    &lt;br /&gt;
    This image is referenced by a &lt;b&gt;relative URL&lt;/b&gt; and the base URL parameter is
    necessary to resolve it to a full URL:&lt;br /&gt;
    &lt;br /&gt;
    &lt;a href=&quot;http://www.evopdf.com&quot;&gt;
        &lt;img alt=&quot;Image with Relative URL&quot; src=&quot;HtmlStringToPdf/Images/Logo.jpg&quot; /&gt;&lt;/a&gt;&lt;br /&gt;
    &lt;br /&gt;
    This image is referenced by a &lt;b&gt;full URL&lt;/b&gt; and the base URL parameter is no required:&lt;br /&gt;
    &lt;br /&gt;
    &lt;a href=&quot;http://www.evopdf.com&quot;&gt;
        &lt;img alt=&quot;Image with Full URL&quot; src=&quot;http://www.evopdf.com/HtmlStringToPdf/Images/Logo.jpg&quot; /&gt;&lt;/a&gt;
&lt;/body&gt;
&lt;/html&gt;
                                                                                
                                                                                </asp:TextBox></td>
                                                                            <td>
                                                                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="textBoxWebPageURL">*</asp:RequiredFieldValidator>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="3">
                                                                                &nbsp;
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="font-weight: bold; width: 147px;">
                                                                                Base URL (Optional):
                                                                            </td>
                                                                            <td>
                                                                                &nbsp;</td>
                                                                            <td style="width: 400px">
                                                                                <asp:TextBox ID="textBoxBaseURL" runat="server" Text="http://www.evopdf.com" Width="400px"></asp:TextBox></td>
                                                                            <td>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td colspan="3">
                                                                            </td>
                                                                        </tr>
                                                                    </table>
                                                                </td>
                                                            </tr>
                                                        </table>
                                                    </asp:Panel>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 5px">
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="width: 400px">
                                                    <table style="width: 400px" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td>
                                                                <table style="width: 351px" id="convertTypeTable" cellspacing="0" cellpadding="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td style="height: 22px">
                                                                                <asp:RadioButton ID="radioConvertToSelectablePDF" runat="server" Text="Convert to PDF with searchable Text"
                                                                                    GroupName="ConvertFormat" Checked="True"></asp:RadioButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="height: 22px">
                                                                                <asp:RadioButton ID="radioConvertToEmbeddedImagePDF" runat="server" Text="Convert to PDF with embedded image"
                                                                                    GroupName="ConvertFormat"></asp:RadioButton>
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
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
                                            <tr>
                                                <td>
                                                    <table style="width: 558px">
                                                        <tr>
                                                            <td>
                                                                <table>
                                                                    <tr>
                                                                        <td style="height: 27px;">
                                                                            <div style="font-weight: bold">
                                                                                Location and size of the rendered content</div>
                                                                        </td>
                                                                        <td>
                                                                            - zero values means auto determined</td>
                                                                        <td>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 400px">
                                                                <table>
                                                                    <tr>
                                                                        <td>
                                                                            X Location:</td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxXLocation" runat="server" Width="59px">0</asp:TextBox>
                                                                            pt</td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            Y Location:</td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxYLocation" runat="server" Width="59px">0</asp:TextBox>
                                                                            pt</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            Width:</td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxWidth" runat="server" Width="59px">0</asp:TextBox>
                                                                            pt</td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            Height:</td>
                                                                        <td>
                                                                            <asp:TextBox ID="textBoxHeight" runat="server" Width="59px">0</asp:TextBox>
                                                                            pt</td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                    </table>
                                                </td>
                                            </tr>
                                            <tr>
                                                <td>
                                                    <table style="width: 496px">
                                                        <tr>
                                                            <td>
                                                                <table>
                                                                    <tr>
                                                                        <td style="height: 27px;">
                                                                            <div style="font-weight: bold">
                                                                                Converter Options</div>
                                                                        </td>
                                                                    </tr>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="width: 400px">
                                                                <table style="width: 551px">
                                                                    <tr>
                                                                        <td style="width: 102px">
                                                                            <asp:CheckBox ID="cbFitWidth" runat="server" Text="Fit Width" ToolTip="Resize the rendered HTML content to fit the specified size"
                                                                                Checked="True" /></td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbLiveLinks" runat="server" Text="Live Links" ToolTip="Enable HTTP links in the rendered PDF document"
                                                                                Checked="True" /></td>
                                                                        <td>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td style="width: 131px">
                                                                            &nbsp;<asp:CheckBox ID="cbEmbedFonts" runat="server" Text="Embed Fonts" 
                                                                                ToolTip="Embed the true type fonts in the rendered PDF document" 
                                                                                Checked="True" /></td>
                                                                        <td style="width: 9px">
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 102px">
                                                                            <asp:CheckBox ID="cbClientScripts" runat="server" Text="JavaScript" ToolTip="Enable JavaScript and other client scripts during conversion"
                                                                                Checked="True" /></td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbBookmarks" runat="server" Text="Bookmarks" ToolTip="Bookmark H1 and H2 HTML tags" /></td>
                                                                        <td>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td style="width: 131px">
                                                                            &nbsp;<asp:CheckBox ID="cbJpegCompression" runat="server" Text="JPEG Compression"
                                                                                ToolTip="Compress images with JPEG" Checked="True" Width="227px" /></td>
                                                                        <td style="width: 9px">
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;</td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td style="width: 102px">
                                                                            <asp:CheckBox ID="cbAddHeader" runat="server" Text="Add Header" ToolTip="Add a HTML header to the rendered PDF document" /></td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbAddFooter" runat="server" Text="Add Footer" ToolTip="Add a footer to the rendered PDF document"
                                                                                Checked="True" /></td>
                                                                        <td>
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td colspan="3">
                                                                            &nbsp;<asp:CheckBox ID="cbAdditionalContent" runat="server" Text="Additional elements after conversion"
                                                                                ToolTip="Enable the demo application to render another conversion right after the first conversion"
                                                                                Width="260px" /></td>
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
