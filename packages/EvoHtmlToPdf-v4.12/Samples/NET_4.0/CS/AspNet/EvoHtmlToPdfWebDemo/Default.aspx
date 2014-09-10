<%@ Page Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true"
    CodeBehind="Default.aspx.cs" Inherits="EvoHtmlToPdfWebDemo.Default" Title="Getting Started with EVO HTML to PDF Converter for .NET" %>

<%@ Register Src="DemoLinksBox.ascx" TagName="DemoLinksBox" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table cellpadding="5px" style="width: 100%; border-right: black 1px solid; border-top: black 1px solid;
        border-left: black 1px solid; border-bottom: black 1px solid;">
        <tr>
            <td colspan="2" style="height: 1px;">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_title" align="left">
                Getting Started with EVO HTML to PDF Converter for .NET
            </td>
        </tr>
        <tr>
            <td colspan="2" style="height: 1px">
            </td>
        </tr>
        <tr>
            <td colspan="2" class="demo_description" style="height: 45px">
                Select to convert an URL or a HTML code, then select to convert to PDF or to an
                image and press the Convert button. When converting a HTML string the Base URL parameter
                helps the converter to determine the full URL of the CSS and images referenced by
                relative URLs in the HTML string.
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
                            <uc1:DemoLinksBox ID="ctrlDemoLinksBox" runat="server">
                            </uc1:DemoLinksBox>
                        </td>
                        <td style="vertical-align: top; width: 680px">
                            <table style="vertical-align: top">
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
                                                </td>
                                            </tr>
                                            <tr>
                                                <td style="height: 50px">
                                                    <table cellpadding="0" cellspacing="0">
                                                        <tr>
                                                            <td colspan="3" style="font-weight: bold; height: 13px;">
                                                                Select HTML source:
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td colspan="3" style="height: 5px">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 20px">
                                                                <asp:RadioButton ID="radioConvertURL" runat="server" GroupName="SelectConvertSource"
                                                                    Text="Convert HTML from URL" AutoPostBack="True" OnCheckedChanged="radioConvertURL_CheckedChanged"
                                                                    Checked="True" Font-Bold="False" />
                                                            </td>
                                                            <td style="width: 20px; height: 20px">
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
                                                <td align="left" style="width: 100%">
                                                    <asp:Panel ID="pnlConvertURL" runat="server" Width="100%">
                                                        <table cellspacing="0" cellpadding="0" style="text-align: left" width="100%">
                                                            <tr>
                                                                <td style="height: 29px">
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
                                                                                Enter HTML Code:
                                                                            </td>
                                                                            <td>
                                                                                &nbsp;
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="textBoxHTMLCode" runat="server" Width="451px" Height="202px" TextMode="MultiLine">&lt;!DOCTYPE html PUBLIC &quot;-//W3C//DTD XHTML 1.0 Transitional//EN&quot; &quot;http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd&quot;&gt;
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
                                                                                </asp:TextBox>
                                                                            </td>
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
                                                                                &nbsp;
                                                                            </td>
                                                                            <td>
                                                                                <asp:TextBox ID="textBoxBaseURL" runat="server" Text="http://www.evopdf.com" Width="447px"></asp:TextBox>
                                                                            </td>
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
                                                <td style="width: 550px">
                                                    <table style="width: 506px" cellspacing="0" cellpadding="0">
                                                        <tr>
                                                            <td>
                                                                <table style="width: 351px" id="convertTypeTable" cellspacing="0" cellpadding="0">
                                                                    <tbody>
                                                                        <tr>
                                                                            <td style="height: 22px">
                                                                                <asp:RadioButton ID="radioConvertToSelectablePDF" runat="server" Text="Convert to PDF"
                                                                                    GroupName="ConvertFormat" Checked="True"></asp:RadioButton>
                                                                            </td>
                                                                        </tr>
                                                                        <tr>
                                                                            <td style="height: 22px">
                                                                                <asp:RadioButton ID="radioConvertToImage" runat="server" Text="Convert to image"
                                                                                    GroupName="ConvertFormat"></asp:RadioButton>
                                                                            </td>
                                                                        </tr>
                                                                    </tbody>
                                                                </table>
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td style="height: 15px">
                                                            </td>
                                                        </tr>
                                                        <tr>
                                                            <td>
                                                                <table style="width: 476px">
                                                                    <tr>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbFitWidth" runat="server" Text="Fit Width" ToolTip="Resize the rendered HTML content to fit the specified size"
                                                                                Checked="True" />
                                                                        </td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbLiveLinks" runat="server" Text="Live Links" ToolTip="Enable HTTP links in the rendered PDF document"
                                                                                Checked="True" />
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbEmbedFonts" runat="server" Text="Embed Fonts" ToolTip="Embed the true type fonts in the rendered PDF document"
                                                                                Checked="True" />
                                                                        </td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            &nbsp;
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbBookmarks" runat="server" Text="Bookmarks" ToolTip="Bookmark H1 and H2 HTML tags" />
                                                                        </td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbClientScripts" runat="server" Text="JavaScript" ToolTip="Enable JavaScript and other client scripts during conversion"
                                                                                Checked="True" />
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbJpegCompression" runat="server" Text="JPEG Compression" ToolTip="Enable or disable JPEG compression of images in PDF"
                                                                                Checked="True" Width="157px" />
                                                                        </td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                    </tr>
                                                                    <tr>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbAddHeader" runat="server" Text="Add Header" ToolTip="Add a HTML header to the rendered PDF document" />
                                                                        </td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td>
                                                                            <asp:CheckBox ID="cbAddFooter" runat="server" Text="Add Footer" ToolTip="Add
                                                a footer to the rendered PDF document" Checked="True" />
                                                                        </td>
                                                                        <td>
                                                                        </td>
                                                                        <td style="width: 20px">
                                                                        </td>
                                                                        <td colspan="3">
                                                                            &nbsp;
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
                                                <td style="height: 5px">
                                                    <strong>PDF Open Mode:</strong> &nbsp;<asp:RadioButton ID="radioAttachment" runat="server"
                                                        Checked="True" GroupName="OpenMode" Text="Attachment" />&nbsp;<asp:RadioButton ID="radioInline"
                                                            runat="server" GroupName="OpenMode" Text="Inline" />
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
        <tr>
            <td>
            </td>
        </tr>
    </table>
    <br />
    <table cellpadding="0" cellspacing="0" border="1" style="width: 1000px">
        <tr>
            <td class="demo_title" align="left" style="height: 50px">
                &nbsp;C# Code Sample
            </td>
        </tr>
        <tr>
            <td>
                <pre class="csharpcode">
    <span class="rem">/// &lt;summary&gt;</span>
    <span class="rem">/// Convert the HTML code from the specified URL to a PDF document
        and send the document to the browser</span>
    <span class="rem">/// &lt;/summary&gt;</span>
    <span class="kwrd">private</span> <span class="kwrd">void</span> ConvertURLToPDF()
    {
        <span class="kwrd">string</span> urlToConvert = textBoxWebPageURL.Text.Trim();

        <span class="rem">// Create the PDF converter. Optionally the HTML viewer width can
            be specified as parameter</span>
        <span class="rem">// The default HTML viewer width is 1024 pixels.</span>
        PdfConverter pdfConverter = <span class="kwrd">new</span> PdfConverter();

        <span class="rem">// set the license key - required</span>
        pdfConverter.LicenseKey = <span class="str">&quot;B4mYiJubiJiInIaYiJuZhpmahpGRkZE="</span>;

        <span class="rem">// set the converter options - optional</span>
        pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4;
        pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
        pdfConverter.PdfDocumentOptions.PdfPageOrientation = PdfPageOrientation.Portrait;


        <span class="rem">// set if header and footer are shown in the PDF - optional - default
            is false </span>
        pdfConverter.PdfDocumentOptions.ShowHeader = cbAddHeader.Checked;
        pdfConverter.PdfDocumentOptions.ShowFooter = cbAddFooter.Checked;
        <span class="rem">// set if the HTML content is resized if necessary to fit the PDF
            page width - default is true</span>
        pdfConverter.PdfDocumentOptions.FitWidth = cbFitWidth.Checked;

        <span class="rem">// set the embedded fonts option - optional - default is false</span>
        pdfConverter.PdfDocumentOptions.EmbedFonts = cbEmbedFonts.Checked;
        <span class="rem">// set the live HTTP links option - optional - default is true</span>
        pdfConverter.PdfDocumentOptions.LiveUrlsEnabled = cbLiveLinks.Checked;

        <span class="rem">// set if the JavaScript is enabled during conversion to a PDF - default
            is true</span>
        pdfConverter.JavaScriptEnabled = cbClientScripts.Checked;

        <span class="rem">// set if the images in PDF are compressed with JPEG to reduce the
            PDF document size - default is true</span>
        pdfConverter.PdfDocumentOptions.JpegCompressionEnabled = cbJpegCompression.Checked;

        <span class="rem">// enable auto-generated bookmarks for a specified list of HTML selectors
            (e.g. H1 and H2)</span>
        <span class="kwrd">if</span> (cbBookmarks.Checked)
        {
            pdfConverter.PdfBookmarkOptions.HtmlElementSelectors = <span class="kwrd">new</span> <span
                class="kwrd">string</span>[] { <span class="str">"H1"</span>, <span class="str">"H2"</span> };
        }

        <span class="rem">// add HTML header</span>
        <span class="kwrd">if</span> (cbAddHeader.Checked)
            AddHeader(pdfConverter);
        <span class="rem">// add HTML footer</span>
        <span class="kwrd">if</span> (cbAddFooter.Checked)
            AddFooter(pdfConverter);

        <span class="rem">// Performs the conversion and get the pdf document bytes that can
        </span>
        <span class="rem">// be saved to a file or sent as a browser response</span>
        <span class="kwrd">byte</span>[] pdfBytes = pdfConverter.GetPdfBytesFromUrl(urlToConvert);

        <span class="rem">// send the PDF document as a response to the browser for download</span>
        System.Web.HttpResponse response = System.Web.HttpContext.Current.Response;
        response.Clear();
        response.AddHeader(<span class="str">"Content-Type"</span>, <span class="str">"application/pdf"</span>);
        <span class="kwrd">if</span> (radioAttachment.Checked)
            response.AddHeader(<span class="str">"Content-Disposition"</span>, String.Format(<span
                class="str">"attachment; filename=GettingStarted.pdf; size={0}"</span>, 
                                pdfBytes.Length.ToString()));
        <span class="kwrd">else</span>
            response.AddHeader(<span class="str">"Content-Disposition"</span>, String.Format(<span
                class="str">"inline; filename=GettingStarted.pdf; size={0}"</span>, 
                                pdfBytes.Length.ToString()));
        response.BinaryWrite(pdfBytes);
        <span class="rem">// Note: it is important to end the response, otherwise the ASP.NET</span>
        <span class="rem">// web page will render its content to PDF document stream</span>
        response.End();
    }</pre>
            </td>
        </tr>
    </table>
</asp:Content>
