Namespace EvoHtmlToPdfDemo
	Partial Public Class PdfSecurity
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PdfSecurity))
			Me.label1 = New Label()
			Me.textBoxURL1 = New TextBox()
			Me.btnConvertMerge = New Button()
			Me.label3 = New Label()
			Me.btnCancel = New Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Pixel, (CByte(0)))
			Me.label1.Location = New Point(12, 135)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(192, 13)
			Me.label1.TabIndex = 0
			Me.label1.Text = "Web Page URL or Full File Path:"
			' 
			' textBoxURL1
			' 
			Me.textBoxURL1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.textBoxURL1.Location = New Point(232, 132)
			Me.textBoxURL1.Name = "textBoxURL1"
			Me.textBoxURL1.Size = New Size(281, 20)
			Me.textBoxURL1.TabIndex = 1
			Me.textBoxURL1.Text = "http://www.evopdf.com"
			' 
			' btnConvertMerge
			' 
			Me.btnConvertMerge.FlatStyle = FlatStyle.Flat
			Me.btnConvertMerge.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.btnConvertMerge.Location = New Point(15, 168)
			Me.btnConvertMerge.Name = "btnConvertMerge"
			Me.btnConvertMerge.Size = New Size(140, 28)
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
			Me.label3.Size = New Size(516, 106)
			Me.label3.TabIndex = 3
			Me.label3.Text = resources.GetString("label3.Text")
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(518, 198)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 4
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' PdfSecurity
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(530, 208)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.btnConvertMerge)
			Me.Controls.Add(Me.textBoxURL1)
			Me.Controls.Add(Me.label1)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "PdfSecurity"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "PDF Security Demo"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As Label
		Private textBoxURL1 As TextBox
		Private WithEvents btnConvertMerge As Button
		Private label3 As Label
		Private btnCancel As Button
	End Class
End Namespace

