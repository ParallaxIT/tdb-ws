<%@ Control Language="C#" AutoEventWireup="true" Codebehind="DemoLinksBox.ascx.vb"
    Inherits="EvoHtmlToPdfWebDemo.DemoLinksBox" %>
<table cellpadding="3">
    <tr>
        <td style="height: 5px">
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton CssClass="demolinks" ID="lnkGettingStarted" runat="server" OnClick="lnkGettingStarted_Click">Getting Started</asp:LinkButton></td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton CssClass="demolinks" ID="lnkFeaturesDemo" runat="server" OnClick="lnkFeaturesDemo_Click">HTML to PDF Features Demo</asp:LinkButton></td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton CssClass="demolinks" ID="lnkPdfInvoices" runat="server" OnClick="lnkPdfInvoices_Click">Dinamically Create PDF Invoices</asp:LinkButton></td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkConvertMultipleUrls" runat="server" CssClass="demolinks" OnClick="lnkConvertMultipleUrls_Click">Convert Multiple URLs to PDF</asp:LinkButton></td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkHtmlInHeaderAndFooter" runat="server" CssClass="demolinks" OnClick="lnkHtmlInHeaderAndFooter_Click">HTML in Header and Footer</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkHtmlElementsLocation" runat="server" CssClass="demolinks"
                OnClick="lnkHtmlElementsLocation_Click">HTML Elements Location in PDF</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkRepeatTableHead" runat="server" CssClass="demolinks" OnClick="lnkRepeatTableHead_Click">Repeat HTML Table Head in PDF</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkTableOfContents" runat="server" CssClass="demolinks" OnClick="lnkTableOfContents_Click">Table
            of Contents and Bookmarks</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkPdfSecurity" runat="server" CssClass="demolinks" OnClick="lnkPdfSecurity_Click">PDF Security and Permissions</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkAppendPdf" runat="server" CssClass="demolinks" OnClick="lnkAppendPdf_Click">Append External PDF Documents</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkHtmlToPdfElement" runat="server" CssClass="demolinks" OnClick="lnkHtmlToPdfElement_Click">Html to PDF Elements Demo</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkTextAndFonts" runat="server" CssClass="demolinks" OnClick="lnkTextAndFonts_Click">Text and True Type Fonts Demo</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkImageElement" runat="server" CssClass="demolinks" OnClick="lnkImageElement_Click">Image Elements Demo</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkPdfShapes" runat="server" CssClass="demolinks" OnClick="lnkPdfShapes_Click">PDF Graphics Shapes Demo</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkPdfStamps" runat="server" CssClass="demolinks" OnClick="lnkPdfStamps_Click">PDF Stamps and Watermarks Demo</asp:LinkButton>
        </td>
    </tr>
    <tr>
        <td>
            <asp:LinkButton ID="lnkSvgToPdf" runat="server" CssClass="demolinks" OnClick="lnkSvgToPdf_Click">SVG to PDF Conversion Demo</asp:LinkButton>
        </td>
    </tr>
</table>
