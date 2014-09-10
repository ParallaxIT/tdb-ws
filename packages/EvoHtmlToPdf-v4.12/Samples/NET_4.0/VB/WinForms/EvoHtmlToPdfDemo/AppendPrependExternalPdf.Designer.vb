Namespace EvoHtmlToPdfDemo
	Partial Public Class AppendPrependExternalPdf
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(AppendPrependExternalPdf))
			Me.label1 = New Label()
			Me.textBoxURL1 = New TextBox()
			Me.label2 = New Label()
			Me.textBoxURL2 = New TextBox()
			Me.btnConvertMerge = New Button()
			Me.label3 = New Label()
			Me.label4 = New Label()
			Me.textBoxURL3 = New TextBox()
			Me.btnCancel = New Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Location = New Point(12, 88)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(38, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "URL 1"
			' 
			' textBoxURL1
			' 
			Me.textBoxURL1.Location = New Point(65, 85)
			Me.textBoxURL1.Name = "textBoxURL1"
			Me.textBoxURL1.Size = New Size(344, 20)
			Me.textBoxURL1.TabIndex = 1
			Me.textBoxURL1.Text = "http://www.evopdf.com"
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.label2.Location = New Point(12, 123)
			Me.label2.Name = "label2"
			Me.label2.Size = New Size(38, 13)
			Me.label2.TabIndex = 0
			Me.label2.Text = "URL 2"
			' 
			' textBoxURL2
			' 
			Me.textBoxURL2.Location = New Point(65, 120)
			Me.textBoxURL2.Name = "textBoxURL2"
			Me.textBoxURL2.Size = New Size(344, 20)
			Me.textBoxURL2.TabIndex = 1
			Me.textBoxURL2.Text = "http://www.google.com"
			' 
			' btnConvertMerge
			' 
			Me.btnConvertMerge.FlatStyle = FlatStyle.Flat
			Me.btnConvertMerge.Location = New Point(15, 198)
			Me.btnConvertMerge.Name = "btnConvertMerge"
			Me.btnConvertMerge.Size = New Size(140, 30)
			Me.btnConvertMerge.TabIndex = 2
			Me.btnConvertMerge.Text = "Convert and Merge"
			Me.btnConvertMerge.UseVisualStyleBackColor = True
'			Me.btnConvertMerge.Click += New System.EventHandler(Me.btnConvertMerge_Click)
			' 
			' label3
			' 
			Me.label3.Location = New Point(15, 19)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(404, 49)
			Me.label3.TabIndex = 3
			Me.label3.Text = "This demo shows you how to use the built-in merge capabilities of the EVO HTML to" & " PDF Converter for .NET to convert many URLs to PDF and merge them into a single" & " final PDF document."
			' 
			' label4
			' 
			Me.label4.AutoSize = True
			Me.label4.Location = New Point(12, 159)
			Me.label4.Name = "label4"
			Me.label4.Size = New Size(38, 13)
			Me.label4.TabIndex = 0
			Me.label4.Text = "URL 3"
			' 
			' textBoxURL3
			' 
			Me.textBoxURL3.Location = New Point(65, 156)
			Me.textBoxURL3.Name = "textBoxURL3"
			Me.textBoxURL3.Size = New Size(344, 20)
			Me.textBoxURL3.TabIndex = 1
            Me.textBoxURL3.Text = "http://www.evopdf.com/urltopdf/htmlbook/book.htm"
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(501, 242)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 4
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' AppendPrependExternalPdf
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(510, 250)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.btnConvertMerge)
			Me.Controls.Add(Me.textBoxURL3)
			Me.Controls.Add(Me.label4)
			Me.Controls.Add(Me.textBoxURL2)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.textBoxURL1)
			Me.Controls.Add(Me.label1)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "AppendPrependExternalPdf"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Convert and Merge Sample"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As Label
		Private textBoxURL1 As TextBox
		Private label2 As Label
		Private textBoxURL2 As TextBox
		Private WithEvents btnConvertMerge As Button
		Private label3 As Label
		Private label4 As Label
		Private textBoxURL3 As TextBox
		Private btnCancel As Button
	End Class
End Namespace

