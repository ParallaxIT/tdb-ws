Namespace EvoHtmlToPdfDemo
	Partial Public Class HtmlElementsLocationInPdf
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(HtmlElementsLocationInPdf))
			Me.label3 = New Label()
			Me.btnConvert = New Button()
			Me.textBoxURL = New TextBox()
			Me.label1 = New Label()
			Me.btnCancel = New Button()
			Me.SuspendLayout()
			' 
			' label3
			' 
			Me.label3.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.label3.Location = New Point(20, 12)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(528, 41)
			Me.label3.TabIndex = 7
			Me.label3.Text = resources.GetString("label3.Text")
			' 
			' btnConvert
			' 
			Me.btnConvert.FlatStyle = FlatStyle.Flat
			Me.btnConvert.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.btnConvert.Location = New Point(20, 113)
			Me.btnConvert.Name = "btnConvert"
			Me.btnConvert.Size = New Size(140, 27)
			Me.btnConvert.TabIndex = 6
			Me.btnConvert.Text = "Convert"
			Me.btnConvert.UseVisualStyleBackColor = True
'			Me.btnConvert.Click += New System.EventHandler(Me.btnConvert_Click)
			' 
			' textBoxURL
			' 
			Me.textBoxURL.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.textBoxURL.Location = New Point(237, 69)
			Me.textBoxURL.Name = "textBoxURL"
			Me.textBoxURL.Size = New Size(325, 20)
			Me.textBoxURL.TabIndex = 5
			Me.textBoxURL.Text = "http://www.evopdf.com"
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.label1.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Bold, GraphicsUnit.Pixel, (CByte(0)))
			Me.label1.Location = New Point(17, 72)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(192, 13)
			Me.label1.TabIndex = 4
			Me.label1.Text = "Web Page URL or Full File Path:"
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(568, 142)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 8
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' HtmlElementsLocationInPdf
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(579, 152)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.btnConvert)
			Me.Controls.Add(Me.textBoxURL)
			Me.Controls.Add(Me.label1)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "HtmlElementsLocationInPdf"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "HTML Elements Location in the Generated PDF Document"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label3 As Label
		Private WithEvents btnConvert As Button
		Private textBoxURL As TextBox
		Private label1 As Label
		Private btnCancel As Button
	End Class
End Namespace

