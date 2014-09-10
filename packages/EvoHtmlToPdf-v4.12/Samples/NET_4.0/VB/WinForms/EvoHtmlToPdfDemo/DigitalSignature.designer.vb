Namespace EvoHtmlToPdfDemo
	Partial Public Class DigitalSignature
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(DigitalSignature))
			Me.label1 = New Label()
			Me.btnCreatePdf = New Button()
			Me.btnCancel = New Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New Point(2, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(403, 51)
			Me.label1.TabIndex = 0
			Me.label1.Text = resources.GetString("label1.Text")
			' 
			' btnCreatePdf
			' 
			Me.btnCreatePdf.FlatStyle = FlatStyle.Flat
			Me.btnCreatePdf.Location = New Point(12, 63)
			Me.btnCreatePdf.Name = "btnCreatePdf"
			Me.btnCreatePdf.Size = New Size(131, 33)
			Me.btnCreatePdf.TabIndex = 1
			Me.btnCreatePdf.Text = "Create Signed PDF"
			Me.btnCreatePdf.UseVisualStyleBackColor = True
'			Me.btnCreatePdf.Click += New System.EventHandler(Me.btnCreatePdf_Click)
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(417, 98)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 2
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' DigitalSignature
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(427, 108)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnCreatePdf)
			Me.Controls.Add(Me.label1)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "DigitalSignature"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Digital Signatures Demo"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private label1 As Label
		Private WithEvents btnCreatePdf As Button
		Private btnCancel As Button
	End Class
End Namespace

