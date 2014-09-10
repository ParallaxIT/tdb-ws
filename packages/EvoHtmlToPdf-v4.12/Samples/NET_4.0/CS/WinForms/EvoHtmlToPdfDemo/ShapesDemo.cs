using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using EvoPdf;

namespace EvoHtmlToPdfDemo
{
    public partial class ShapesDemo : Form
    {
        public ShapesDemo()
        {
            InitializeComponent();
        }

        private void btnCreatePdf_Click(object sender, EventArgs e)
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

            string outFilePath = System.IO.Path.Combine(Application.StartupPath, "ShapesDemo.pdf");

            // save the PDF document to disk
            document.Save(outFilePath);

            // close the PDF document to release the resources
            document.Close();

            DialogResult dr = MessageBox.Show("Open the saved file in an external viewer?", "Open Rendered File", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    System.Diagnostics.Process.Start(outFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
        }
    }
}