Namespace EvoHtmlToPdfDemo
	Partial Public Class ConvertMultipleURLsToPdf
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(ConvertMultipleURLsToPdf))
			Me.label3 = New Label()
			Me.btnConvert = New Button()
			Me.textBoxURL1 = New TextBox()
			Me.label1 = New Label()
			Me.label2 = New Label()
			Me.textBoxURL2 = New TextBox()
			Me.cbStartOnNewPage = New CheckBox()
			Me.cbAddHeader = New CheckBox()
			Me.cbAddFooter = New CheckBox()
			Me.btnCancel = New Button()
			Me.SuspendLayout()
			' 
			' label3
			' 
			Me.label3.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.label3.Location = New Point(19, 11)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(570, 36)
			Me.label3.TabIndex = 11
			Me.label3.Text = resources.GetString("label3.Text")
			' 
			' btnConvert
			' 
			Me.btnConvert.FlatStyle = FlatStyle.Flat
			Me.btnConvert.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.btnConvert.Location = New Point(19, 199)
			Me.btnConvert.Name = "btnConvert"
			Me.btnConvert.Size = New Size(140, 37)
			Me.btnConvert.TabIndex = 10
			Me.btnConvert.Text = "Convert"
			Me.btnConvert.UseVisualStyleBackColor = True
'			Me.btnConvert.Click += New System.EventHandler(Me.btnConvert_Click)
			' 
			' textBoxURL1
			' 
			Me.textBoxURL1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.textBoxURL1.Location = New Point(289, 68)
			Me.textBoxURL1.Name = "textBoxURL1"
			Me.textBoxURL1.Size = New Size(336, 20)
			Me.textBoxURL1.TabIndex = 9
			Me.textBoxURL1.Text = "http://www.evopdf.com"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Pixel, (CByte(0)))
			Me.label1.Location = New Point(16, 71)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(220, 13)
			Me.label1.TabIndex = 8
			Me.label1.Text = "First Web Page URL or Full File Path:"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Pixel, (CByte(0)))
			Me.label2.Location = New Point(16, 97)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(239, 13)
			Me.label2.TabIndex = 8
			Me.label2.Text = "Second Web Page URL or Full File Path:"
			' 
			' textBoxURL2
			' 
			Me.textBoxURL2.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.textBoxURL2.Location = New Point(289, 94)
			Me.textBoxURL2.Name = "textBoxURL2"
			Me.textBoxURL2.Size = New Size(336, 20)
			Me.textBoxURL2.TabIndex = 9
			Me.textBoxURL2.Text = "http://www.google.com"
			' 
			' cbStartOnNewPage
			' 
			Me.cbStartOnNewPage.AutoSize = True
			Me.cbStartOnNewPage.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.cbStartOnNewPage.Location = New Point(19, 133)
			Me.cbStartOnNewPage.Name = "cbStartOnNewPage"
			Me.cbStartOnNewPage.Size = New Size(264, 17)
			Me.cbStartOnNewPage.TabIndex = 12
			Me.cbStartOnNewPage.Text = "Start second URL conversion on a new PDF page"
			Me.cbStartOnNewPage.UseVisualStyleBackColor = True
			' 
			' cbAddHeader
			' 
			Me.cbAddHeader.AutoSize = True
			Me.cbAddHeader.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.cbAddHeader.Location = New Point(19, 174)
			Me.cbAddHeader.Name = "cbAddHeader"
			Me.cbAddHeader.Size = New Size(83, 17)
			Me.cbAddHeader.TabIndex = 12
			Me.cbAddHeader.Text = "Add Header"
			Me.cbAddHeader.UseVisualStyleBackColor = True
			' 
			' cbAddFooter
			' 
			Me.cbAddFooter.AutoSize = True
			Me.cbAddFooter.Checked = True
			Me.cbAddFooter.CheckState = CheckState.Checked
			Me.cbAddFooter.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.cbAddFooter.Location = New Point(121, 174)
			Me.cbAddFooter.Name = "cbAddFooter"
			Me.cbAddFooter.Size = New Size(78, 17)
			Me.cbAddFooter.TabIndex = 12
			Me.cbAddFooter.Text = "Add Footer"
			Me.cbAddFooter.UseVisualStyleBackColor = True
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(587, 213)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 13
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' ConvertMultipleURLsToPdf
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(637, 248)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.cbAddFooter)
			Me.Controls.Add(Me.cbAddHeader)
			Me.Controls.Add(Me.cbStartOnNewPage)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.btnConvert)
			Me.Controls.Add(Me.textBoxURL2)
			Me.Controls.Add(Me.textBoxURL1)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "ConvertMultipleURLsToPdf"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Convert Multiple URLs to the Same PDF Document"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label3 As Label
		Private WithEvents btnConvert As Button
		Private textBoxURL1 As TextBox
		Private label1 As Label
		Private label2 As Label
		Private textBoxURL2 As TextBox
		Private cbStartOnNewPage As CheckBox
		Private cbAddHeader As CheckBox
		Private cbAddFooter As CheckBox
		Private btnCancel As Button
	End Class
End Namespace

