Namespace EvoHtmlToPdfDemo
	Partial Public Class SvgToPdf
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(SvgToPdf))
			Me.label1 = New Label()
			Me.btnCreatePdf = New Button()
			Me.btnCancel = New Button()
			Me.lnkViewSvg = New LinkLabel()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New Point(2, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(422, 40)
			Me.label1.TabIndex = 0
			Me.label1.Text = "This sample shows how to convert a HTML page containing SVG to PDF. The SVG that " & "will be converted contains a shape and a text written on that shape."
			' 
			' btnCreatePdf
			' 
			Me.btnCreatePdf.FlatStyle = FlatStyle.Flat
			Me.btnCreatePdf.Location = New Point(12, 63)
			Me.btnCreatePdf.Name = "btnCreatePdf"
			Me.btnCreatePdf.Size = New Size(75, 32)
			Me.btnCreatePdf.TabIndex = 1
			Me.btnCreatePdf.Text = "Create PDF"
			Me.btnCreatePdf.UseVisualStyleBackColor = True
'			Me.btnCreatePdf.Click += New System.EventHandler(Me.btnCreatePdf_Click)
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(414, 87)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 2
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' lnkViewSvg
			' 
			Me.lnkViewSvg.AutoSize = True
			Me.lnkViewSvg.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.lnkViewSvg.Location = New Point(119, 73)
			Me.lnkViewSvg.Name = "lnkViewSvg"
			Me.lnkViewSvg.Size = New Size(110, 13)
			Me.lnkViewSvg.TabIndex = 13
			Me.lnkViewSvg.TabStop = True
			Me.lnkViewSvg.Text = "View HTML with SVG"
'			Me.lnkViewSvg.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.lnkViewSvg_LinkClicked)
			' 
			' SvgToPdf
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(427, 107)
			Me.Controls.Add(Me.lnkViewSvg)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnCreatePdf)
			Me.Controls.Add(Me.label1)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "SvgToPdf"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "SVG to PDF Conversion Demo"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As Label
		Private WithEvents btnCreatePdf As Button
		Private btnCancel As Button
		Private WithEvents lnkViewSvg As LinkLabel
	End Class
End Namespace

