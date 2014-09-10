namespace EvoHtmlToPdfDemo
{
    partial class ConvertHtmlString
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertHtmlString));
            this.lblBaseUrl = new System.Windows.Forms.Label();
            this.textBoxBaseUrl = new System.Windows.Forms.TextBox();
            this.btnConvertMerge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblHtmlString = new System.Windows.Forms.Label();
            this.textBoxHtmlString = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBaseUrl
            // 
            this.lblBaseUrl.AutoSize = true;
            this.lblBaseUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblBaseUrl.Location = new System.Drawing.Point(12, 363);
            this.lblBaseUrl.Name = "lblBaseUrl";
            this.lblBaseUrl.Size = new System.Drawing.Size(258, 13);
            this.lblBaseUrl.TabIndex = 0;
            this.lblBaseUrl.Text = "Base URL to resolve relative URLs in string:";
            // 
            // textBoxBaseUrl
            // 
            this.textBoxBaseUrl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.textBoxBaseUrl.Location = new System.Drawing.Point(15, 389);
            this.textBoxBaseUrl.Name = "textBoxBaseUrl";
            this.textBoxBaseUrl.Size = new System.Drawing.Size(682, 20);
            this.textBoxBaseUrl.TabIndex = 1;
            this.textBoxBaseUrl.Text = "http://www.evopdf.com";
            // 
            // btnConvertMerge
            // 
            this.btnConvertMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.btnConvertMerge.Location = new System.Drawing.Point(15, 439);
            this.btnConvertMerge.Name = "btnConvertMerge";
            this.btnConvertMerge.Size = new System.Drawing.Size(140, 26);
            this.btnConvertMerge.TabIndex = 2;
            this.btnConvertMerge.Text = "Convert";
            this.btnConvertMerge.UseVisualStyleBackColor = true;
            this.btnConvertMerge.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(685, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(492, 54);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblHtmlString
            // 
            this.lblHtmlString.AutoSize = true;
            this.lblHtmlString.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblHtmlString.Location = new System.Drawing.Point(12, 63);
            this.lblHtmlString.Name = "lblHtmlString";
            this.lblHtmlString.Size = new System.Drawing.Size(145, 13);
            this.lblHtmlString.TabIndex = 0;
            this.lblHtmlString.Text = "HTML String to Convert:";
            // 
            // textBoxHtmlString
            // 
            this.textBoxHtmlString.Location = new System.Drawing.Point(15, 89);
            this.textBoxHtmlString.MaxLength = 1024000;
            this.textBoxHtmlString.Multiline = true;
            this.textBoxHtmlString.Name = "textBoxHtmlString";
            this.textBoxHtmlString.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxHtmlString.Size = new System.Drawing.Size(682, 245);
            this.textBoxHtmlString.TabIndex = 5;
            this.textBoxHtmlString.Text = resources.GetString("textBoxHtmlString.Text");
            // 
            // ConvertHtmlString
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(709, 477);
            this.Controls.Add(this.textBoxHtmlString);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvertMerge);
            this.Controls.Add(this.textBoxBaseUrl);
            this.Controls.Add(this.lblHtmlString);
            this.Controls.Add(this.lblBaseUrl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ConvertHtmlString";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Convert a HTML String to PDF";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaseUrl;
        private System.Windows.Forms.TextBox textBoxBaseUrl;
        private System.Windows.Forms.Button btnConvertMerge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblHtmlString;
        private System.Windows.Forms.TextBox textBoxHtmlString;
    }
}

