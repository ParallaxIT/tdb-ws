Namespace EvoHtmlToPdfDemo
	Partial Public Class HtmlToPdfElementDemo
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HtmlToPdfElementDemo))
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.label27 = New System.Windows.Forms.Label()
            Me.label26 = New System.Windows.Forms.Label()
            Me.pnlContent = New System.Windows.Forms.Panel()
            Me.pnlControlPanel = New System.Windows.Forms.Panel()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbAdditionalContent = New System.Windows.Forms.CheckBox()
            Me.cbJpegCompression = New System.Windows.Forms.CheckBox()
            Me.cbBookmarks = New System.Windows.Forms.CheckBox()
            Me.cbScriptsEnabled = New System.Windows.Forms.CheckBox()
            Me.cbEmbedFonts = New System.Windows.Forms.CheckBox()
            Me.cbFitWidth = New System.Windows.Forms.CheckBox()
            Me.cbLiveLinks = New System.Windows.Forms.CheckBox()
            Me.radioConvertToSelectablePDF = New System.Windows.Forms.RadioButton()
            Me.radioConvertToEmbeddedImagePDF = New System.Windows.Forms.RadioButton()
            Me.textBoxYLocation = New System.Windows.Forms.TextBox()
            Me.textBoxHeight = New System.Windows.Forms.TextBox()
            Me.textBoxWidth = New System.Windows.Forms.TextBox()
            Me.textBoxXLocation = New System.Windows.Forms.TextBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.label6 = New System.Windows.Forms.Label()
            Me.textBoxWebPageURL = New System.Windows.Forms.TextBox()
            Me.label5 = New System.Windows.Forms.Label()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.lblEnterURL = New System.Windows.Forms.Label()
            Me.cbAddHeader = New System.Windows.Forms.CheckBox()
            Me.cbAddFooter = New System.Windows.Forms.CheckBox()
            Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.pnlConvertCommand = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnConvert = New System.Windows.Forms.Button()
            Me.pnlHeader.SuspendLayout()
            Me.pnlContent.SuspendLayout()
            Me.pnlControlPanel.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlConvertCommand.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.White
            Me.pnlHeader.Controls.Add(Me.label27)
            Me.pnlHeader.Controls.Add(Me.label26)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(594, 87)
            Me.pnlHeader.TabIndex = 0
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.label27.Location = New System.Drawing.Point(83, 9)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(422, 17)
            Me.label27.TabIndex = 1
            Me.label27.Text = "HTML to PDF Element and HTML to Image Element Demo"
            '
            'label26
            '
            Me.label26.Location = New System.Drawing.Point(12, 39)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(554, 35)
            Me.label26.TabIndex = 0
            Me.label26.Text = resources.GetString("label26.Text")
            '
            'pnlContent
            '
            Me.pnlContent.AutoScroll = True
            Me.pnlContent.AutoSize = True
            Me.pnlContent.Controls.Add(Me.pnlControlPanel)
            Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlContent.Location = New System.Drawing.Point(0, 87)
            Me.pnlContent.MaximumSize = New System.Drawing.Size(600, 560)
            Me.pnlContent.Name = "pnlContent"
            Me.pnlContent.Size = New System.Drawing.Size(594, 293)
            Me.pnlContent.TabIndex = 1
            '
            'pnlControlPanel
            '
            Me.pnlControlPanel.Controls.Add(Me.groupBox1)
            Me.pnlControlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlControlPanel.Location = New System.Drawing.Point(0, 0)
            Me.pnlControlPanel.Name = "pnlControlPanel"
            Me.pnlControlPanel.Size = New System.Drawing.Size(594, 293)
            Me.pnlControlPanel.TabIndex = 0
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.White
            Me.groupBox1.Controls.Add(Me.cbAdditionalContent)
            Me.groupBox1.Controls.Add(Me.cbJpegCompression)
            Me.groupBox1.Controls.Add(Me.cbBookmarks)
            Me.groupBox1.Controls.Add(Me.cbScriptsEnabled)
            Me.groupBox1.Controls.Add(Me.cbEmbedFonts)
            Me.groupBox1.Controls.Add(Me.cbFitWidth)
            Me.groupBox1.Controls.Add(Me.cbLiveLinks)
            Me.groupBox1.Controls.Add(Me.radioConvertToSelectablePDF)
            Me.groupBox1.Controls.Add(Me.radioConvertToEmbeddedImagePDF)
            Me.groupBox1.Controls.Add(Me.textBoxYLocation)
            Me.groupBox1.Controls.Add(Me.textBoxHeight)
            Me.groupBox1.Controls.Add(Me.textBoxWidth)
            Me.groupBox1.Controls.Add(Me.textBoxXLocation)
            Me.groupBox1.Controls.Add(Me.label4)
            Me.groupBox1.Controls.Add(Me.label6)
            Me.groupBox1.Controls.Add(Me.textBoxWebPageURL)
            Me.groupBox1.Controls.Add(Me.label5)
            Me.groupBox1.Controls.Add(Me.label3)
            Me.groupBox1.Controls.Add(Me.label2)
            Me.groupBox1.Controls.Add(Me.label7)
            Me.groupBox1.Controls.Add(Me.label1)
            Me.groupBox1.Controls.Add(Me.lblEnterURL)
            Me.groupBox1.Controls.Add(Me.cbAddHeader)
            Me.groupBox1.Controls.Add(Me.cbAddFooter)
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBox1.Location = New System.Drawing.Point(0, 0)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(594, 293)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            '
            'cbAdditionalContent
            '
            Me.cbAdditionalContent.AutoSize = True
            Me.cbAdditionalContent.Location = New System.Drawing.Point(290, 235)
            Me.cbAdditionalContent.Name = "cbAdditionalContent"
            Me.cbAdditionalContent.Size = New System.Drawing.Size(196, 17)
            Me.cbAdditionalContent.TabIndex = 10
            Me.cbAdditionalContent.Text = "Additional elements after conversion"
            Me.cbAdditionalContent.UseVisualStyleBackColor = True
            '
            'cbJpegCompression
            '
            Me.cbJpegCompression.AutoSize = True
            Me.cbJpegCompression.Checked = True
            Me.cbJpegCompression.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbJpegCompression.Location = New System.Drawing.Point(419, 212)
            Me.cbJpegCompression.Name = "cbJpegCompression"
            Me.cbJpegCompression.Size = New System.Drawing.Size(116, 17)
            Me.cbJpegCompression.TabIndex = 10
            Me.cbJpegCompression.Text = "JPEG Compression"
            Me.cbJpegCompression.UseVisualStyleBackColor = True
            '
            'cbBookmarks
            '
            Me.cbBookmarks.AutoSize = True
            Me.cbBookmarks.Location = New System.Drawing.Point(150, 235)
            Me.cbBookmarks.Name = "cbBookmarks"
            Me.cbBookmarks.Size = New System.Drawing.Size(79, 17)
            Me.cbBookmarks.TabIndex = 10
            Me.cbBookmarks.Text = "Bookmarks"
            Me.cbBookmarks.UseVisualStyleBackColor = True
            '
            'cbScriptsEnabled
            '
            Me.cbScriptsEnabled.AutoSize = True
            Me.cbScriptsEnabled.Checked = True
            Me.cbScriptsEnabled.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbScriptsEnabled.Location = New System.Drawing.Point(41, 236)
            Me.cbScriptsEnabled.Name = "cbScriptsEnabled"
            Me.cbScriptsEnabled.Size = New System.Drawing.Size(76, 17)
            Me.cbScriptsEnabled.TabIndex = 10
            Me.cbScriptsEnabled.Text = "JavaScript"
            Me.cbScriptsEnabled.UseVisualStyleBackColor = True
            '
            'cbEmbedFonts
            '
            Me.cbEmbedFonts.AutoSize = True
            Me.cbEmbedFonts.Checked = True
            Me.cbEmbedFonts.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbEmbedFonts.Location = New System.Drawing.Point(290, 212)
            Me.cbEmbedFonts.Name = "cbEmbedFonts"
            Me.cbEmbedFonts.Size = New System.Drawing.Size(88, 17)
            Me.cbEmbedFonts.TabIndex = 10
            Me.cbEmbedFonts.Text = "Embed Fonts"
            Me.cbEmbedFonts.UseVisualStyleBackColor = True
            '
            'cbFitWidth
            '
            Me.cbFitWidth.AutoSize = True
            Me.cbFitWidth.Checked = True
            Me.cbFitWidth.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbFitWidth.Location = New System.Drawing.Point(41, 212)
            Me.cbFitWidth.Name = "cbFitWidth"
            Me.cbFitWidth.Size = New System.Drawing.Size(68, 17)
            Me.cbFitWidth.TabIndex = 10
            Me.cbFitWidth.Text = "Fit Width"
            Me.cbFitWidth.UseVisualStyleBackColor = True
            '
            'cbLiveLinks
            '
            Me.cbLiveLinks.AutoSize = True
            Me.cbLiveLinks.Checked = True
            Me.cbLiveLinks.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbLiveLinks.Location = New System.Drawing.Point(150, 212)
            Me.cbLiveLinks.Name = "cbLiveLinks"
            Me.cbLiveLinks.Size = New System.Drawing.Size(70, 17)
            Me.cbLiveLinks.TabIndex = 10
            Me.cbLiveLinks.Text = "Live links"
            Me.cbLiveLinks.UseVisualStyleBackColor = True
            '
            'radioConvertToSelectablePDF
            '
            Me.radioConvertToSelectablePDF.AutoSize = True
            Me.radioConvertToSelectablePDF.Checked = True
            Me.radioConvertToSelectablePDF.Location = New System.Drawing.Point(15, 48)
            Me.radioConvertToSelectablePDF.Name = "radioConvertToSelectablePDF"
            Me.radioConvertToSelectablePDF.Size = New System.Drawing.Size(195, 17)
            Me.radioConvertToSelectablePDF.TabIndex = 6
            Me.radioConvertToSelectablePDF.TabStop = True
            Me.radioConvertToSelectablePDF.Text = "Convert to PDF with searchable text"
            Me.radioConvertToSelectablePDF.UseVisualStyleBackColor = True
            '
            'radioConvertToEmbeddedImagePDF
            '
            Me.radioConvertToEmbeddedImagePDF.AutoSize = True
            Me.radioConvertToEmbeddedImagePDF.Location = New System.Drawing.Point(238, 48)
            Me.radioConvertToEmbeddedImagePDF.Name = "radioConvertToEmbeddedImagePDF"
            Me.radioConvertToEmbeddedImagePDF.Size = New System.Drawing.Size(204, 17)
            Me.radioConvertToEmbeddedImagePDF.TabIndex = 6
            Me.radioConvertToEmbeddedImagePDF.Text = "Convert to PDF with embedded image"
            Me.radioConvertToEmbeddedImagePDF.UseVisualStyleBackColor = True
            '
            'textBoxYLocation
            '
            Me.textBoxYLocation.Location = New System.Drawing.Point(290, 108)
            Me.textBoxYLocation.Name = "textBoxYLocation"
            Me.textBoxYLocation.Size = New System.Drawing.Size(77, 20)
            Me.textBoxYLocation.TabIndex = 5
            Me.textBoxYLocation.Text = "0"
            '
            'textBoxHeight
            '
            Me.textBoxHeight.Location = New System.Drawing.Point(290, 137)
            Me.textBoxHeight.Name = "textBoxHeight"
            Me.textBoxHeight.Size = New System.Drawing.Size(77, 20)
            Me.textBoxHeight.TabIndex = 5
            Me.textBoxHeight.Text = "0"
            '
            'textBoxWidth
            '
            Me.textBoxWidth.Location = New System.Drawing.Point(108, 137)
            Me.textBoxWidth.Name = "textBoxWidth"
            Me.textBoxWidth.Size = New System.Drawing.Size(77, 20)
            Me.textBoxWidth.TabIndex = 5
            Me.textBoxWidth.Text = "0"
            '
            'textBoxXLocation
            '
            Me.textBoxXLocation.Location = New System.Drawing.Point(108, 108)
            Me.textBoxXLocation.Name = "textBoxXLocation"
            Me.textBoxXLocation.Size = New System.Drawing.Size(77, 20)
            Me.textBoxXLocation.TabIndex = 5
            Me.textBoxXLocation.Text = "0"
            '
            'label4
            '
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(220, 111)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(64, 19)
            Me.label4.TabIndex = 4
            Me.label4.Text = "Y Location:"
            '
            'label6
            '
            Me.label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label6.Location = New System.Drawing.Point(220, 140)
            Me.label6.Name = "label6"
            Me.label6.Size = New System.Drawing.Size(64, 19)
            Me.label6.TabIndex = 4
            Me.label6.Text = "Height:"
            '
            'textBoxWebPageURL
            '
            Me.textBoxWebPageURL.Location = New System.Drawing.Point(238, 13)
            Me.textBoxWebPageURL.Name = "textBoxWebPageURL"
            Me.textBoxWebPageURL.Size = New System.Drawing.Size(328, 20)
            Me.textBoxWebPageURL.TabIndex = 5
            Me.textBoxWebPageURL.Text = "http://www.evopdf.com"
            '
            'label5
            '
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(38, 140)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(64, 19)
            Me.label5.TabIndex = 4
            Me.label5.Text = "Width:"
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label3.Location = New System.Drawing.Point(38, 111)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(64, 19)
            Me.label3.TabIndex = 4
            Me.label3.Text = "X Location:"
            '
            'label2
            '
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label2.Location = New System.Drawing.Point(350, 86)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(216, 19)
            Me.label2.TabIndex = 4
            Me.label2.Text = "- zero values means auto determined"
            '
            'label7
            '
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label7.Location = New System.Drawing.Point(15, 179)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(121, 19)
            Me.label7.TabIndex = 4
            Me.label7.Text = "Converter options"
            '
            'label1
            '
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label1.Location = New System.Drawing.Point(15, 86)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(340, 19)
            Me.label1.TabIndex = 4
            Me.label1.Text = "Location and size of the rendered content in points"
            '
            'lblEnterURL
            '
            Me.lblEnterURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.lblEnterURL.Location = New System.Drawing.Point(15, 16)
            Me.lblEnterURL.Name = "lblEnterURL"
            Me.lblEnterURL.Size = New System.Drawing.Size(217, 29)
            Me.lblEnterURL.TabIndex = 4
            Me.lblEnterURL.Text = "Enter Web Page URL or File Path:"
            '
            'cbAddHeader
            '
            Me.cbAddHeader.AutoSize = True
            Me.cbAddHeader.Location = New System.Drawing.Point(41, 259)
            Me.cbAddHeader.Name = "cbAddHeader"
            Me.cbAddHeader.Size = New System.Drawing.Size(83, 17)
            Me.cbAddHeader.TabIndex = 5
            Me.cbAddHeader.Text = "Add Header"
            Me.cbAddHeader.UseVisualStyleBackColor = True
            '
            'cbAddFooter
            '
            Me.cbAddFooter.AutoSize = True
            Me.cbAddFooter.Checked = True
            Me.cbAddFooter.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbAddFooter.Location = New System.Drawing.Point(150, 258)
            Me.cbAddFooter.Name = "cbAddFooter"
            Me.cbAddFooter.Size = New System.Drawing.Size(78, 17)
            Me.cbAddFooter.TabIndex = 6
            Me.cbAddFooter.Text = "Add Footer"
            Me.cbAddFooter.UseVisualStyleBackColor = True
            '
            'errorProvider
            '
            Me.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorProvider.ContainerControl = Me
            '
            'pnlConvertCommand
            '
            Me.pnlConvertCommand.BackColor = System.Drawing.Color.White
            Me.pnlConvertCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlConvertCommand.Controls.Add(Me.btnCancel)
            Me.pnlConvertCommand.Controls.Add(Me.btnConvert)
            Me.pnlConvertCommand.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlConvertCommand.Location = New System.Drawing.Point(0, 380)
            Me.pnlConvertCommand.Name = "pnlConvertCommand"
            Me.pnlConvertCommand.Size = New System.Drawing.Size(594, 54)
            Me.pnlConvertCommand.TabIndex = 3
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Location = New System.Drawing.Point(582, 43)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(0, 0)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.TabStop = False
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'btnConvert
            '
            Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnConvert.Location = New System.Drawing.Point(227, 13)
            Me.btnConvert.Name = "btnConvert"
            Me.btnConvert.Size = New System.Drawing.Size(118, 27)
            Me.btnConvert.TabIndex = 0
            Me.btnConvert.Text = "Convert"
            Me.btnConvert.UseVisualStyleBackColor = True
            '
            'HtmlToPdfElementDemo
            '
            Me.AutoSize = True
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(594, 434)
            Me.Controls.Add(Me.pnlConvertCommand)
            Me.Controls.Add(Me.pnlContent)
            Me.Controls.Add(Me.pnlHeader)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimumSize = New System.Drawing.Size(600, 33)
            Me.Name = "HtmlToPdfElementDemo"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "HTML to PDF Element and HTML to Image Element Demo"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlContent.ResumeLayout(False)
            Me.pnlControlPanel.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlConvertCommand.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private pnlHeader As Panel
		Private pnlContent As Panel
		Private pnlControlPanel As Panel
		Private label26 As Label
		Private label27 As Label
		Private cbAddHeader As CheckBox
		Private cbAddFooter As CheckBox
		Private groupBox1 As GroupBox
		Private radioConvertToEmbeddedImagePDF As RadioButton
		Private textBoxWebPageURL As TextBox
		Private lblEnterURL As Label
		Private errorProvider As ErrorProvider
		Private pnlConvertCommand As Panel
		Private WithEvents btnConvert As Button
		Private radioConvertToSelectablePDF As RadioButton
		Private cbLiveLinks As CheckBox
		Private cbScriptsEnabled As CheckBox
		Private label2 As Label
		Private label1 As Label
		Private textBoxYLocation As TextBox
		Private textBoxHeight As TextBox
		Private textBoxWidth As TextBox
		Private textBoxXLocation As TextBox
		Private label4 As Label
		Private label6 As Label
		Private label5 As Label
		Private label3 As Label
		Private cbEmbedFonts As CheckBox
		Private cbFitWidth As CheckBox
		Private label7 As Label
		Private cbAdditionalContent As CheckBox
		Private cbBookmarks As CheckBox
		Private cbJpegCompression As CheckBox
		Private btnCancel As Button
	End Class
End Namespace

