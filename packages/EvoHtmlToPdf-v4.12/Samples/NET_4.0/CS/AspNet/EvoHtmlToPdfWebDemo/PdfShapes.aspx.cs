using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

using EvoPdf;

namespace EvoHtmlToPdfWebDemo
{
    public partial class PdfShapes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ctrlDemoLinksBox.LoadDemo("PdfShapes");
        }

        protected void btnCreatePDF_Click(object sender, EventArgs e)
        {
            // create a PDF document
            Document document = new Document();

            // set the license key
            document.LicenseKey = "B4mYiJubiJiInIaYiJuZhpmahpGRkZE=";

            // add a page to the PDF document
            PdfPage firstPage = document.AddPage();

            // draw rectangle
            RectangleElement rectangle1 = new RectangleElement(10, 10, 150, 100);
            rectangle1.ForeColor = System.Drawing.Color.Blue;
            rectangle1.LineStyle.LineWidth = 5; // a 5 points line width
            rectangle1.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin;
            firstPage.AddElement(rectangle1);

            // draw colored rectangle
            RectangleElement rectangle2 = new RectangleElement(200, 10, 150, 100);
            rectangle2.ForeColor = System.Drawing.Color.Blue;
            rectangle2.BackColor = System.Drawing.Color.Green;
            firstPage.AddElement(rectangle2);

            // draw gradient colored rectangle
            RectangleElement rectangle3 = new RectangleElement(400, 25, 100, 50);
            rectangle3.ForeColor = System.Drawing.Color.Blue;
            rectangle3.Gradient = new GradientColor(GradientDirection.Vertical, System.Drawing.Color.Green, System.Drawing.Color.Blue);
            firstPage.AddElement(rectangle3);

            // draw ellipse
            EllipseElement ellipse1 = new EllipseElement(75, 200, 70, 50);
            ellipse1.ForeColor = System.Drawing.Color.Blue;
            ellipse1.LineStyle.LineDashStyle = LineDashStyle.Dash;
            firstPage.AddElement(ellipse1);

            // draw ellipse
            EllipseElement ellipse2 = new EllipseElement(275, 200, 70, 50);
            ellipse2.ForeColor = System.Drawing.Color.Blue;
            ellipse2.BackColor = System.Drawing.Color.Green;
            firstPage.AddElement(ellipse2);

            // draw ellipse
            EllipseElement ellipse3 = new EllipseElement(450, 200, 50, 25);
            ellipse3.ForeColor = System.Drawing.Color.Blue;
            ellipse3.Gradient = new GradientColor(GradientDirection.Vertical, System.Drawing.Color.Green, System.Drawing.Color.Blue);
            firstPage.AddElement(ellipse3);


            BezierCurveElement bezierCurve1 = new BezierCurveElement(10, 350, 100, 300, 200, 400, 300, 350);
            bezierCurve1.ForeColor = System.Drawing.Color.Blue;
            bezierCurve1.LineStyle.LineWidth = 3;
            bezierCurve1.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin;
            firstPage.AddElement(bezierCurve1);

            BezierCurveElement bezierCurve2 = new BezierCurveElement(10, 350, 100, 400, 200, 300, 300, 350);
            bezierCurve2.ForeColor = System.Drawing.Color.Green;
            bezierCurve2.LineStyle.LineWidth = 3;
            bezierCurve2.LineStyle.LineJoinStyle = LineJoinStyle.RoundJoin;
            firstPage.AddElement(bezierCurve2);

            try
            {
                // get the PDF document bytes
                byte[] pdfBytes = document.Save();

                // send the generated PDF document to client browser

                // get the object representing the HTTP response to browser
                HttpResponse httpResponse = HttpContext.Current.Response;

                // add the Content-Type and Content-Disposition HTTP headers
                httpResponse.AddHeader("Content-Type", "application/pdf");
                httpResponse.AddHeader("Content-Disposition", String.Format("attachment; filename=Shapes.pdf; size={0}", pdfBytes.Length.ToString()));

                // write the PDF document bytes as attachment to HTTP response 
                httpResponse.BinaryWrite(pdfBytes);

                // Note: it is important to end the response, otherwise the ASP.NET
                // web page will render its content to PDF document stream
                httpResponse.End();
            }
            finally
            {
                // close the PDF document to release the resources
                document.Close();
            }
        }
    }
}
