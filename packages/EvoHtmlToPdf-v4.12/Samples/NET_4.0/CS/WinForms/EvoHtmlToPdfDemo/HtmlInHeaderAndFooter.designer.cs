namespace EvoHtmlToPdfDemo
{
    partial class HtmlInHeaderAndFooter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HtmlInHeaderAndFooter));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxURL1 = new System.Windows.Forms.TextBox();
            this.btnConvertMerge = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbAlternateHeaderAndFooter = new System.Windows.Forms.CheckBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Web Page URL or Full File Path:";
            // 
            // textBoxURL1
            // 
            this.textBoxURL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.textBoxURL1.Location = new System.Drawing.Point(232, 63);
            this.textBoxURL1.Name = "textBoxURL1";
            this.textBoxURL1.Size = new System.Drawing.Size(290, 20);
            this.textBoxURL1.TabIndex = 1;
            this.textBoxURL1.Text = "http://www.evopdf.com/urltopdf/htmlbook/book.htm";
            // 
            // btnConvertMerge
            // 
            this.btnConvertMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.btnConvertMerge.Location = new System.Drawing.Point(15, 98);
            this.btnConvertMerge.Name = "btnConvertMerge";
            this.btnConvertMerge.Size = new System.Drawing.Size(140, 27);
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
            this.label3.Size = new System.Drawing.Size(513, 41);
            this.label3.TabIndex = 3;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // cbAlternateHeaderAndFooter
            // 
            this.cbAlternateHeaderAndFooter.AutoSize = true;
            this.cbAlternateHeaderAndFooter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.cbAlternateHeaderAndFooter.Location = new System.Drawing.Point(196, 103);
            this.cbAlternateHeaderAndFooter.Name = "cbAlternateHeaderAndFooter";
            this.cbAlternateHeaderAndFooter.Size = new System.Drawing.Size(200, 17);
            this.cbAlternateHeaderAndFooter.TabIndex = 4;
            this.cbAlternateHeaderAndFooter.Text = "Alternate Header and Footer Content";
            this.cbAlternateHeaderAndFooter.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(515, 115);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // HtmlInHeaderAndFooter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(544, 133);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cbAlternateHeaderAndFooter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnConvertMerge);
            this.Controls.Add(this.textBoxURL1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HtmlInHeaderAndFooter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HTML in Header and Footer Sample";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxURL1;
        private System.Windows.Forms.Button btnConvertMerge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbAlternateHeaderAndFooter;
        private System.Windows.Forms.Button btnCancel;
    }
}

