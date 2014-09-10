Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class SvgToPdfDemo
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("SvgToPdf")
		End Sub

		Protected Sub btnConvert_Click(ByVal sender As Object, ByVal e As EventArgs)
			Dim pdfConverter As New PdfConverter()

			' set the license key - required
            pdfConverter.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

'            /
'/ convert a XML document with inline SVG
'            string thisPageURL = HttpContext.Current.Request.Url.AbsoluteUri;
'            string htmlWithSvgUrl = thisPageURL.Substring(0, thisPageURL.LastIndexOf('/')) + "/SVG/svginline.xml";

			' We convert the HTML page as local disk file because IIS and VS WebDev Server 
			' don't have .svg included in MIME types by default.
			' When converting HTML pages from an IIS server the MIME type image/svg+xml 
			' must be added to IIS in order to serve the .svg files referenced in HTML
			Dim htmlWithSvgUrl As String = System.IO.Path.Combine(Server.MapPath("~"), "SVG\svg.html")

			' call the converter
			Dim pdfBytes() As Byte = pdfConverter.GetPdfBytesFromUrl(htmlWithSvgUrl)

            ' send the generated PDF document to client browser

            ' get the object representing the HTTP response to browser
            Dim httpResponse As HttpResponse = HttpContext.Current.Response

            ' add the Content-Type and Content-Disposition HTTP headers
            httpResponse.AddHeader("Content-Type", "application/pdf")
            httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=SvgToPdf.pdf; size={0}", pdfBytes.Length.ToString()))

            ' write the PDF document bytes as attachment to HTTP response 
            httpResponse.BinaryWrite(pdfBytes)

            ' Note: it is important to end the response, otherwise the ASP.NET
            ' web page will render its content to PDF document stream
            httpResponse.End()
		End Sub
	End Class
End Namespace
