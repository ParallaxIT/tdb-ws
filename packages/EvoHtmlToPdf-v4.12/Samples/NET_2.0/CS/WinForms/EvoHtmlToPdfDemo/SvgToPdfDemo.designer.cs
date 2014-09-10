namespace EvoHtmlToPdfDemo
{
    partial class SvgToPdf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SvgToPdf));
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreatePdf = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lnkViewSvg = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "This sample shows how to convert a HTML page containing SVG to PDF. The SVG that " +
                "will be converted contains a shape and a text written on that shape.";
            // 
            // btnCreatePdf
            // 
            this.btnCreatePdf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreatePdf.Location = new System.Drawing.Point(12, 63);
            this.btnCreatePdf.Name = "btnCreatePdf";
            this.btnCreatePdf.Size = new System.Drawing.Size(75, 32);
            this.btnCreatePdf.TabIndex = 1;
            this.btnCreatePdf.Text = "Create PDF";
            this.btnCreatePdf.UseVisualStyleBackColor = true;
            this.btnCreatePdf.Click += new System.EventHandler(this.btnCreatePdf_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(414, 87);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lnkViewSvg
            // 
            this.lnkViewSvg.AutoSize = true;
            this.lnkViewSvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.lnkViewSvg.Location = new System.Drawing.Point(119, 73);
            this.lnkViewSvg.Name = "lnkViewSvg";
            this.lnkViewSvg.Size = new System.Drawing.Size(110, 13);
            this.lnkViewSvg.TabIndex = 13;
            this.lnkViewSvg.TabStop = true;
            this.lnkViewSvg.Text = "View HTML with SVG";
            this.lnkViewSvg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkViewSvg_LinkClicked);
            // 
            // SvgToPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(427, 107);
            this.Controls.Add(this.lnkViewSvg);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnCreatePdf);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SvgToPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SVG to PDF Conversion Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreatePdf;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lnkViewSvg;
    }
}

