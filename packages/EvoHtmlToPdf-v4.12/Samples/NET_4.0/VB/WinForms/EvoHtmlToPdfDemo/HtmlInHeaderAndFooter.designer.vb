Namespace EvoHtmlToPdfDemo
	Partial Public Class HtmlInHeaderAndFooter
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HtmlInHeaderAndFooter))
			Me.label1 = New Label()
			Me.textBoxURL1 = New TextBox()
			Me.btnConvertMerge = New Button()
			Me.label3 = New Label()
			Me.cbAlternateHeaderAndFooter = New CheckBox()
			Me.btnCancel = New Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Pixel, (CByte(0)))
			Me.label1.Location = New Point(12, 66)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(192, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Web Page URL or Full File Path:"
			' 
			' textBoxURL1
			' 
			Me.textBoxURL1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.textBoxURL1.Location = New Point(232, 63)
			Me.textBoxURL1.Name = "textBoxURL1"
			Me.textBoxURL1.Size = New Size(290, 20)
			Me.textBoxURL1.TabIndex = 1
            Me.textBoxURL1.Text = "http://www.evopdf.com/urltopdf/htmlbook/book.htm"
			' 
			' btnConvertMerge
			' 
			Me.btnConvertMerge.FlatStyle = FlatStyle.Flat
			Me.btnConvertMerge.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.btnConvertMerge.Location = New Point(15, 98)
			Me.btnConvertMerge.Name = "btnConvertMerge"
			Me.btnConvertMerge.Size = New Size(140, 27)
			Me.btnConvertMerge.TabIndex = 2
			Me.btnConvertMerge.Text = "Convert"
			Me.btnConvertMerge.UseVisualStyleBackColor = True
'			Me.btnConvertMerge.Click += New System.EventHandler(Me.btnConvert_Click)
			' 
			' label3
			' 
			Me.label3.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.label3.Location = New Point(12, 9)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(513, 41)
			Me.label3.TabIndex = 3
			Me.label3.Text = resources.GetString("label3.Text")
			' 
			' cbAlternateHeaderAndFooter
			' 
			Me.cbAlternateHeaderAndFooter.AutoSize = True
			Me.cbAlternateHeaderAndFooter.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.cbAlternateHeaderAndFooter.Location = New Point(196, 103)
			Me.cbAlternateHeaderAndFooter.Name = "cbAlternateHeaderAndFooter"
			Me.cbAlternateHeaderAndFooter.Size = New Size(200, 17)
			Me.cbAlternateHeaderAndFooter.TabIndex = 4
			Me.cbAlternateHeaderAndFooter.Text = "Alternate Header and Footer Content"
			Me.cbAlternateHeaderAndFooter.UseVisualStyleBackColor = True
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(515, 115)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 5
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' HtmlInHeaderAndFooter
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(544, 133)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.cbAlternateHeaderAndFooter)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.btnConvertMerge)
			Me.Controls.Add(Me.textBoxURL1)
			Me.Controls.Add(Me.label1)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "HtmlInHeaderAndFooter"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "HTML in Header and Footer Sample"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As Label
		Private textBoxURL1 As TextBox
		Private WithEvents btnConvertMerge As Button
		Private label3 As Label
		Private cbAlternateHeaderAndFooter As CheckBox
		Private btnCancel As Button
	End Class
End Namespace

