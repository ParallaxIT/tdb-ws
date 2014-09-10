Imports System.Configuration
Imports System.Collections
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls

Imports EvoPdf

Namespace EvoHtmlToPdfWebDemo
	Partial Public Class PdfShapes
		Inherits System.Web.UI.Page
		Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
			ctrlDemoLinksBox.LoadDemo("PdfShapes")
		End Sub

		Protected Sub btnCreatePDF_Click(ByVal sender As Object, ByVal e As EventArgs)
			' create a PDF document
			Dim document As New Document()

			' set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE="

			' add a page to the PDF document
			Dim firstPage As PdfPage = document.AddPage()

			' draw rectangle
			Dim rectangle1 As New RectangleElement(10, 10, 150, 100)
			rectangle1.ForeColor = Color.Blue
			rectangle1.LineStyle.LineWidth = 5 ' a 5 points line width
			rectangle1.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin
			firstPage.AddElement(rectangle1)

			' draw colored rectangle
			Dim rectangle2 As New RectangleElement(200, 10, 150, 100)
			rectangle2.ForeColor = Color.Blue
			rectangle2.BackColor = Color.Green
			firstPage.AddElement(rectangle2)

			' draw gradient colored rectangle
			Dim rectangle3 As New RectangleElement(400, 25, 100, 50)
			rectangle3.ForeColor = Color.Blue
			rectangle3.Gradient = New GradientColor(GradientDirection.Vertical, Color.Green, Color.Blue)
			firstPage.AddElement(rectangle3)

			' draw ellipse
			Dim ellipse1 As New EllipseElement(75, 200, 70, 50)
			ellipse1.ForeColor = Color.Blue
			ellipse1.LineStyle.LineDashStyle = LineDashStyle.Dash
			firstPage.AddElement(ellipse1)

			' draw ellipse
			Dim ellipse2 As New EllipseElement(275, 200, 70, 50)
			ellipse2.ForeColor = Color.Blue
			ellipse2.BackColor = Color.Green
			firstPage.AddElement(ellipse2)

			' draw ellipse
			Dim ellipse3 As New EllipseElement(450, 200, 50, 25)
			ellipse3.ForeColor = Color.Blue
			ellipse3.Gradient = New GradientColor(GradientDirection.Vertical, Color.Green, Color.Blue)
			firstPage.AddElement(ellipse3)


			Dim bezierCurve1 As New BezierCurveElement(10, 350, 100, 300, 200, 400, 300, 350)
			bezierCurve1.ForeColor = Color.Blue
			bezierCurve1.LineStyle.LineWidth = 3
			bezierCurve1.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin
			firstPage.AddElement(bezierCurve1)

			Dim bezierCurve2 As New BezierCurveElement(10, 350, 100, 400, 200, 300, 300, 350)
			bezierCurve2.ForeColor = Color.Green
			bezierCurve2.LineStyle.LineWidth = 3
			bezierCurve2.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin
			firstPage.AddElement(bezierCurve2)

			Try
                ' get the PDF document bytes
                Dim pdfBytes As Byte() = document.Save()

                ' send the generated PDF document to client browser

                ' get the object representing the HTTP response to browser
                Dim httpResponse As HttpResponse = HttpContext.Current.Response

                ' add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf")
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=Shapes.pdf; size={0}", pdfBytes.Length.ToString()))

                ' write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes)

                ' Note: it is important to end the response, otherwise the ASP.NET
                ' web page will render its content to PDF document stream
                httpResponse.End()
			Finally
				' close the PDF document to release the resources
				document.Close()
			End Try
		End Sub
	End Class
End Namespace
