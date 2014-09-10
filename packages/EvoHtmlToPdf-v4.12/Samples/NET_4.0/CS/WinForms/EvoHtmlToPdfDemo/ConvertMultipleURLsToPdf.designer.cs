namespace EvoHtmlToPdfDemo
{
    partial class ConvertMultipleURLsToPdf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertMultipleURLsToPdf));
            this.label3 = new System.Windows.Forms.Label();
            this.btnConvert = new System.Windows.Forms.Button();
            this.textBoxURL1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxURL2 = new System.Windows.Forms.TextBox();
            this.cbStartOnNewPage = new System.Windows.Forms.CheckBox();
            this.cbAddHeader = new System.Windows.Forms.CheckBox();
            this.cbAddFooter = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(19, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(570, 36);
            this.label3.TabIndex = 11;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.btnConvert.Location = new System.Drawing.Point(19, 199);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(140, 37);
            this.btnConvert.TabIndex = 10;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // textBoxURL1
            // 
            this.textBoxURL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.textBoxURL1.Location = new System.Drawing.Point(289, 68);
            this.textBoxURL1.Name = "textBoxURL1";
            this.textBoxURL1.Size = new System.Drawing.Size(336, 20);
            this.textBoxURL1.TabIndex = 9;
            this.textBoxURL1.Text = "http://www.evopdf.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "First Web Page URL or Full File Path:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Web Page URL or Full File Path:";
            // 
            // textBoxURL2
            // 
            this.textBoxURL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.textBoxURL2.Location = new System.Drawing.Point(289, 94);
            this.textBoxURL2.Name = "textBoxURL2";
            this.textBoxURL2.Size = new System.Drawing.Size(336, 20);
            this.textBoxURL2.TabIndex = 9;
            this.textBoxURL2.Text = "http://www.google.com";
            // 
            // cbStartOnNewPage
            // 
            this.cbStartOnNewPage.AutoSize = true;
            this.cbStartOnNewPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.cbStartOnNewPage.Location = new System.Drawing.Point(19, 133);
            this.cbStartOnNewPage.Name = "cbStartOnNewPage";
            this.cbStartOnNewPage.Size = new System.Drawing.Size(264, 17);
            this.cbStartOnNewPage.TabIndex = 12;
            this.cbStartOnNewPage.Text = "Start second URL conversion on a new PDF page";
            this.cbStartOnNewPage.UseVisualStyleBackColor = true;
            // 
            // cbAddHeader
            // 
            this.cbAddHeader.AutoSize = true;
            this.cbAddHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.cbAddHeader.Location = new System.Drawing.Point(19, 174);
            this.cbAddHeader.Name = "cbAddHeader";
            this.cbAddHeader.Size = new System.Drawing.Size(83, 17);
            this.cbAddHeader.TabIndex = 12;
            this.cbAddHeader.Text = "Add Header";
            this.cbAddHeader.UseVisualStyleBackColor = true;
            // 
            // cbAddFooter
            // 
            this.cbAddFooter.AutoSize = true;
            this.cbAddFooter.Checked = true;
            this.cbAddFooter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.cbAddFooter.Location = new System.Drawing.Point(121, 174);
            this.cbAddFooter.Name = "cbAddFooter";
            this.cbAddFooter.Size = new System.Drawing.Size(78, 17);
            this.cbAddFooter.TabIndex = 12;
            this.cbAddFooter.Text = "Add Footer";
            this.cbAddFooter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(587, 213);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // ConvertMultipleURLsToPdf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(637, 248);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbAddFooter);
            this.Controls.Add(this.cbAddHeader);
            this.Controls.Add(this.cbStartOnNewPage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.textBoxURL2);
            this.Controls.Add(this.textBoxURL1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConvertMultipleURLsToPdf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convert Multiple URLs to the Same PDF Document";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.TextBox textBoxURL1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxURL2;
        private System.Windows.Forms.CheckBox cbStartOnNewPage;
        private System.Windows.Forms.CheckBox cbAddHeader;
        private System.Windows.Forms.CheckBox cbAddFooter;
        private System.Windows.Forms.Button btnCancel;
    }
}

