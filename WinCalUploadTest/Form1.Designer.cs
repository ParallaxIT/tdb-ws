namespace WinCalUploadTest
{
    partial class Form1
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
            this.btnBrowse = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnPDFUpload = new System.Windows.Forms.Button();
            this.txtPDFFileName = new System.Windows.Forms.TextBox();
            this.btnBrowsePDFCreator = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(16, 27);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 0;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.BtnBrowseClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(16, 64);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(345, 22);
            this.txtFileName.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(263, 286);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 31);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.BtnCloseClick);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(263, 96);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(100, 28);
            this.btnUpload.TabIndex = 3;
            this.btnUpload.Text = "upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.BtnUploadClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Calendar Upload Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "PDF Creation Test";
            // 
            // btnPDFUpload
            // 
            this.btnPDFUpload.Location = new System.Drawing.Point(264, 244);
            this.btnPDFUpload.Margin = new System.Windows.Forms.Padding(4);
            this.btnPDFUpload.Name = "btnPDFUpload";
            this.btnPDFUpload.Size = new System.Drawing.Size(100, 34);
            this.btnPDFUpload.TabIndex = 7;
            this.btnPDFUpload.Text = "upload";
            this.btnPDFUpload.UseVisualStyleBackColor = true;
            this.btnPDFUpload.Click += new System.EventHandler(this.btnPDFUpload_Click);
            // 
            // txtPDFFileName
            // 
            this.txtPDFFileName.Location = new System.Drawing.Point(17, 215);
            this.txtPDFFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtPDFFileName.Name = "txtPDFFileName";
            this.txtPDFFileName.Size = new System.Drawing.Size(345, 22);
            this.txtPDFFileName.TabIndex = 6;
            // 
            // btnBrowsePDFCreator
            // 
            this.btnBrowsePDFCreator.Location = new System.Drawing.Point(17, 178);
            this.btnBrowsePDFCreator.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowsePDFCreator.Name = "btnBrowsePDFCreator";
            this.btnBrowsePDFCreator.Size = new System.Drawing.Size(100, 28);
            this.btnBrowsePDFCreator.TabIndex = 5;
            this.btnBrowsePDFCreator.Text = "Browse";
            this.btnBrowsePDFCreator.UseVisualStyleBackColor = true;
            this.btnBrowsePDFCreator.Click += new System.EventHandler(this.btnBrowsePDFCreator_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 330);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPDFUpload);
            this.Controls.Add(this.txtPDFFileName);
            this.Controls.Add(this.btnBrowsePDFCreator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpload);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnBrowse);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Upload Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnPDFUpload;
        private System.Windows.Forms.TextBox txtPDFFileName;
        private System.Windows.Forms.Button btnBrowsePDFCreator;
    }
}

