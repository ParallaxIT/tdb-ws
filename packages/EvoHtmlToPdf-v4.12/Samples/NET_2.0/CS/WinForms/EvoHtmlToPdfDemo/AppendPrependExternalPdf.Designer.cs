namespace EvoHtmlToPdfDemo
{
    partial class AppendPrependExternalPdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppendPrependExternalPdf));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURL1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL2 = new System.Windows.Forms.TextBox();
            this.btnConvertMerge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxURL3 = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "URL 1";
            // 
            // textBoxURL1
            // 
            this.textBoxURL1.Location = new System.Drawing.Point(65, 85);
            this.textBoxURL1.Name = "textBoxURL1";
            this.textBoxURL1.Size = new System.Drawing.Size(344, 20);
            this.textBoxURL1.TabIndex = 1;
            this.textBoxURL1.Text = "http://www.evopdf.com";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "URL 2";
            // 
            // textBoxURL2
            // 
            this.textBoxURL2.Location = new System.Drawing.Point(65, 120);
            this.textBoxURL2.Name = "textBoxURL2";
            this.textBoxURL2.Size = new System.Drawing.Size(344, 20);
            this.textBoxURL2.TabIndex = 1;
            this.textBoxURL2.Text = "http://www.google.com";
            // 
            // btnConvertMerge
            // 
            this.btnConvertMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertMerge.Location = new System.Drawing.Point(15, 198);
            this.btnConvertMerge.Name = "btnConvertMerge";
            this.btnConvertMerge.Size = new System.Drawing.Size(140, 30);
            this.btnConvertMerge.TabIndex = 2;
            this.btnConvertMerge.Text = "Convert and Merge";
            this.btnConvertMerge.UseVisualStyleBackColor = true;
            this.btnConvertMerge.Click += new System.EventHandler(this.btnConvertMerge_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(15, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(404, 49);
            this.label3.TabIndex = 3;
            this.label3.Text = "This demo shows you how to use the built-in merge capabilities of the EVO HTML to" +
                " PDF Converter for .NET to convert many URLs to PDF and merge them into a single" +
                " final PDF document.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "URL 3";
            // 
            // textBoxURL3
            // 
            this.textBoxURL3.Location = new System.Drawing.Point(65, 156);
            this.textBoxURL3.Name = "textBoxURL3";
            this.textBoxURL3.Size = new System.Drawing.Size(344, 20);
            this.textBoxURL3.TabIndex = 1;
            this.textBoxURL3.Text = "http://www.evopdf.com/urltopdf/htmlbook/book.htm";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(501, 242);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // AppendPrependExternalPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(510, 250);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvertMerge);
            this.Controls.Add(this.textBoxURL3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxURL2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxURL1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AppendPrependExternalPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convert and Merge Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxURL1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL2;
        private System.Windows.Forms.Button btnConvertMerge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxURL3;
        private System.Windows.Forms.Button btnCancel;
    }
}

