namespace EvoHtmlToPdfDemo
{
    partial class HtmlToPdfElementDemo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HtmlToPdfElementDemo));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlControlPanel = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbAdditionalContent = new System.Windows.Forms.CheckBox();
            this.cbJpegCompression = new System.Windows.Forms.CheckBox();
            this.cbBookmarks = new System.Windows.Forms.CheckBox();
            this.cbScriptsEnabled = new System.Windows.Forms.CheckBox();
            this.cbEmbedFonts = new System.Windows.Forms.CheckBox();
            this.cbFitWidth = new System.Windows.Forms.CheckBox();
            this.cbLiveLinks = new System.Windows.Forms.CheckBox();
            this.radioConvertToSelectablePDF = new System.Windows.Forms.RadioButton();
            this.radioConvertToEmbeddedImagePDF = new System.Windows.Forms.RadioButton();
            this.textBoxYLocation = new System.Windows.Forms.TextBox();
            this.textBoxHeight = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.textBoxXLocation = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxWebPageURL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEnterURL = new System.Windows.Forms.Label();
            this.cbAddHeader = new System.Windows.Forms.CheckBox();
            this.cbAddFooter = new System.Windows.Forms.CheckBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.pnlConvertCommand = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlControlPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnlConvertCommand.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.label27);
            this.pnlHeader.Controls.Add(this.label26);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(594, 87);
            this.pnlHeader.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(83, 9);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(422, 17);
            this.label27.TabIndex = 1;
            this.label27.Text = "HTML to PDF Element and HTML to Image Element Demo";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(12, 39);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(554, 35);
            this.label26.TabIndex = 0;
            this.label26.Text = resources.GetString("label26.Text");
            // 
            // pnlContent
            // 
            this.pnlContent.AutoScroll = true;
            this.pnlContent.AutoSize = true;
            this.pnlContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlContent.Controls.Add(this.pnlControlPanel);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlContent.Location = new System.Drawing.Point(0, 87);
            this.pnlContent.MaximumSize = new System.Drawing.Size(600, 560);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(594, 293);
            this.pnlContent.TabIndex = 1;
            // 
            // pnlControlPanel
            // 
            this.pnlControlPanel.Controls.Add(this.groupBox1);
            this.pnlControlPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlControlPanel.Location = new System.Drawing.Point(0, 0);
            this.pnlControlPanel.Name = "pnlControlPanel";
            this.pnlControlPanel.Size = new System.Drawing.Size(594, 293);
            this.pnlControlPanel.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cbAdditionalContent);
            this.groupBox1.Controls.Add(this.cbJpegCompression);
            this.groupBox1.Controls.Add(this.cbBookmarks);
            this.groupBox1.Controls.Add(this.cbScriptsEnabled);
            this.groupBox1.Controls.Add(this.cbEmbedFonts);
            this.groupBox1.Controls.Add(this.cbFitWidth);
            this.groupBox1.Controls.Add(this.cbLiveLinks);
            this.groupBox1.Controls.Add(this.radioConvertToSelectablePDF);
            this.groupBox1.Controls.Add(this.radioConvertToEmbeddedImagePDF);
            this.groupBox1.Controls.Add(this.textBoxYLocation);
            this.groupBox1.Controls.Add(this.textBoxHeight);
            this.groupBox1.Controls.Add(this.textBoxWidth);
            this.groupBox1.Controls.Add(this.textBoxXLocation);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.textBoxWebPageURL);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblEnterURL);
            this.groupBox1.Controls.Add(this.cbAddHeader);
            this.groupBox1.Controls.Add(this.cbAddFooter);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // cbAdditionalContent
            // 
            this.cbAdditionalContent.AutoSize = true;
            this.cbAdditionalContent.Location = new System.Drawing.Point(290, 235);
            this.cbAdditionalContent.Name = "cbAdditionalContent";
            this.cbAdditionalContent.Size = new System.Drawing.Size(196, 17);
            this.cbAdditionalContent.TabIndex = 10;
            this.cbAdditionalContent.Text = "Additional elements after conversion";
            this.cbAdditionalContent.UseVisualStyleBackColor = true;
            // 
            // cbJpegCompression
            // 
            this.cbJpegCompression.AutoSize = true;
            this.cbJpegCompression.Checked = true;
            this.cbJpegCompression.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbJpegCompression.Location = new System.Drawing.Point(419, 212);
            this.cbJpegCompression.Name = "cbJpegCompression";
            this.cbJpegCompression.Size = new System.Drawing.Size(116, 17);
            this.cbJpegCompression.TabIndex = 10;
            this.cbJpegCompression.Text = "JPEG Compression";
            this.cbJpegCompression.UseVisualStyleBackColor = true;
            // 
            // cbBookmarks
            // 
            this.cbBookmarks.AutoSize = true;
            this.cbBookmarks.Location = new System.Drawing.Point(150, 235);
            this.cbBookmarks.Name = "cbBookmarks";
            this.cbBookmarks.Size = new System.Drawing.Size(79, 17);
            this.cbBookmarks.TabIndex = 10;
            this.cbBookmarks.Text = "Bookmarks";
            this.cbBookmarks.UseVisualStyleBackColor = true;
            // 
            // cbScriptsEnabled
            // 
            this.cbScriptsEnabled.AutoSize = true;
            this.cbScriptsEnabled.Checked = true;
            this.cbScriptsEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbScriptsEnabled.Location = new System.Drawing.Point(41, 236);
            this.cbScriptsEnabled.Name = "cbScriptsEnabled";
            this.cbScriptsEnabled.Size = new System.Drawing.Size(76, 17);
            this.cbScriptsEnabled.TabIndex = 10;
            this.cbScriptsEnabled.Text = "JavaScript";
            this.cbScriptsEnabled.UseVisualStyleBackColor = true;
            // 
            // cbEmbedFonts
            // 
            this.cbEmbedFonts.AutoSize = true;
            this.cbEmbedFonts.Checked = true;
            this.cbEmbedFonts.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbEmbedFonts.Location = new System.Drawing.Point(290, 212);
            this.cbEmbedFonts.Name = "cbEmbedFonts";
            this.cbEmbedFonts.Size = new System.Drawing.Size(88, 17);
            this.cbEmbedFonts.TabIndex = 10;
            this.cbEmbedFonts.Text = "Embed Fonts";
            this.cbEmbedFonts.UseVisualStyleBackColor = true;
            // 
            // cbFitWidth
            // 
            this.cbFitWidth.AutoSize = true;
            this.cbFitWidth.Checked = true;
            this.cbFitWidth.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFitWidth.Location = new System.Drawing.Point(41, 212);
            this.cbFitWidth.Name = "cbFitWidth";
            this.cbFitWidth.Size = new System.Drawing.Size(68, 17);
            this.cbFitWidth.TabIndex = 10;
            this.cbFitWidth.Text = "Fit Width";
            this.cbFitWidth.UseVisualStyleBackColor = true;
            // 
            // cbLiveLinks
            // 
            this.cbLiveLinks.AutoSize = true;
            this.cbLiveLinks.Checked = true;
            this.cbLiveLinks.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbLiveLinks.Location = new System.Drawing.Point(150, 212);
            this.cbLiveLinks.Name = "cbLiveLinks";
            this.cbLiveLinks.Size = new System.Drawing.Size(70, 17);
            this.cbLiveLinks.TabIndex = 10;
            this.cbLiveLinks.Text = "Live links";
            this.cbLiveLinks.UseVisualStyleBackColor = true;
            // 
            // radioConvertToSelectablePDF
            // 
            this.radioConvertToSelectablePDF.AutoSize = true;
            this.radioConvertToSelectablePDF.Checked = true;
            this.radioConvertToSelectablePDF.Location = new System.Drawing.Point(15, 48);
            this.radioConvertToSelectablePDF.Name = "radioConvertToSelectablePDF";
            this.radioConvertToSelectablePDF.Size = new System.Drawing.Size(195, 17);
            this.radioConvertToSelectablePDF.TabIndex = 6;
            this.radioConvertToSelectablePDF.TabStop = true;
            this.radioConvertToSelectablePDF.Text = "Convert to PDF with searchable text";
            this.radioConvertToSelectablePDF.UseVisualStyleBackColor = true;
            // 
            // radioConvertToEmbeddedImagePDF
            // 
            this.radioConvertToEmbeddedImagePDF.AutoSize = true;
            this.radioConvertToEmbeddedImagePDF.Location = new System.Drawing.Point(238, 48);
            this.radioConvertToEmbeddedImagePDF.Name = "radioConvertToEmbeddedImagePDF";
            this.radioConvertToEmbeddedImagePDF.Size = new System.Drawing.Size(204, 17);
            this.radioConvertToEmbeddedImagePDF.TabIndex = 6;
            this.radioConvertToEmbeddedImagePDF.Text = "Convert to PDF with embedded image";
            this.radioConvertToEmbeddedImagePDF.UseVisualStyleBackColor = true;
            // 
            // textBoxYLocation
            // 
            this.textBoxYLocation.Location = new System.Drawing.Point(290, 108);
            this.textBoxYLocation.Name = "textBoxYLocation";
            this.textBoxYLocation.Size = new System.Drawing.Size(77, 20);
            this.textBoxYLocation.TabIndex = 5;
            this.textBoxYLocation.Text = "0";
            // 
            // textBoxHeight
            // 
            this.textBoxHeight.Location = new System.Drawing.Point(290, 137);
            this.textBoxHeight.Name = "textBoxHeight";
            this.textBoxHeight.Size = new System.Drawing.Size(77, 20);
            this.textBoxHeight.TabIndex = 5;
            this.textBoxHeight.Text = "0";
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(108, 137);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(77, 20);
            this.textBoxWidth.TabIndex = 5;
            this.textBoxWidth.Text = "0";
            // 
            // textBoxXLocation
            // 
            this.textBoxXLocation.Location = new System.Drawing.Point(108, 108);
            this.textBoxXLocation.Name = "textBoxXLocation";
            this.textBoxXLocation.Size = new System.Drawing.Size(77, 20);
            this.textBoxXLocation.TabIndex = 5;
            this.textBoxXLocation.Text = "0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(220, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Y Location:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(220, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Height:";
            // 
            // textBoxWebPageURL
            // 
            this.textBoxWebPageURL.Location = new System.Drawing.Point(238, 13);
            this.textBoxWebPageURL.Name = "textBoxWebPageURL";
            this.textBoxWebPageURL.Size = new System.Drawing.Size(328, 20);
            this.textBoxWebPageURL.TabIndex = 5;
            this.textBoxWebPageURL.Text = "http://www.evopdf.com";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Width:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "X Location:";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "- zero values means auto determined";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 19);
            this.label7.TabIndex = 4;
            this.label7.Text = "Converter options";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Location and size of the rendered content in points";
            // 
            // lblEnterURL
            // 
            this.lblEnterURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.lblEnterURL.Location = new System.Drawing.Point(15, 16);
            this.lblEnterURL.Name = "lblEnterURL";
            this.lblEnterURL.Size = new System.Drawing.Size(217, 29);
            this.lblEnterURL.TabIndex = 4;
            this.lblEnterURL.Text = "Enter Web Page URL or File Path:";
            // 
            // cbAddHeader
            // 
            this.cbAddHeader.AutoSize = true;
            this.cbAddHeader.Location = new System.Drawing.Point(41, 259);
            this.cbAddHeader.Name = "cbAddHeader";
            this.cbAddHeader.Size = new System.Drawing.Size(83, 17);
            this.cbAddHeader.TabIndex = 5;
            this.cbAddHeader.Text = "Add Header";
            this.cbAddHeader.UseVisualStyleBackColor = true;
            // 
            // cbAddFooter
            // 
            this.cbAddFooter.AutoSize = true;
            this.cbAddFooter.Checked = true;
            this.cbAddFooter.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAddFooter.Location = new System.Drawing.Point(150, 258);
            this.cbAddFooter.Name = "cbAddFooter";
            this.cbAddFooter.Size = new System.Drawing.Size(78, 17);
            this.cbAddFooter.TabIndex = 6;
            this.cbAddFooter.Text = "Add Footer";
            this.cbAddFooter.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // pnlConvertCommand
            // 
            this.pnlConvertCommand.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlConvertCommand.BackColor = System.Drawing.Color.White;
            this.pnlConvertCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConvertCommand.Controls.Add(this.btnCancel);
            this.pnlConvertCommand.Controls.Add(this.btnConvert);
            this.pnlConvertCommand.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConvertCommand.Location = new System.Drawing.Point(0, 380);
            this.pnlConvertCommand.Name = "pnlConvertCommand";
            this.pnlConvertCommand.Size = new System.Drawing.Size(594, 54);
            this.pnlConvertCommand.TabIndex = 3;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Location = new System.Drawing.Point(582, 43);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(0, 0);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.TabStop = false;
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnConvert
            // 
            this.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvert.Location = new System.Drawing.Point(227, 13);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(118, 27);
            this.btnConvert.TabIndex = 0;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // HtmlToPdfElementDemo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(594, 434);
            this.Controls.Add(this.pnlConvertCommand);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(238)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 33);
            this.Name = "HtmlToPdfElementDemo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HTML to PDF Element and HTML to Image Element Demo";
            this.Load += new System.EventHandler(this.WnvHtmlConvertForm_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlContent.ResumeLayout(false);
            this.pnlControlPanel.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnlConvertCommand.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Panel pnlControlPanel;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.CheckBox cbAddHeader;
        private System.Windows.Forms.CheckBox cbAddFooter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioConvertToEmbeddedImagePDF;
        private System.Windows.Forms.TextBox textBoxWebPageURL;
        private System.Windows.Forms.Label lblEnterURL;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Panel pnlConvertCommand;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.RadioButton radioConvertToSelectablePDF;
        private System.Windows.Forms.CheckBox cbLiveLinks;
        private System.Windows.Forms.CheckBox cbScriptsEnabled;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxYLocation;
        private System.Windows.Forms.TextBox textBoxHeight;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.TextBox textBoxXLocation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbEmbedFonts;
        private System.Windows.Forms.CheckBox cbFitWidth;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbAdditionalContent;
        private System.Windows.Forms.CheckBox cbBookmarks;
        private System.Windows.Forms.CheckBox cbJpegCompression;
        private System.Windows.Forms.Button btnCancel;
    }
}

