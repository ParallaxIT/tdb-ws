Namespace EvoHtmlToPdfDemo
	Partial Public Class PdfStamps
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(PdfStamps))
			Me.label1 = New Label()
			Me.btnCreatePdf = New Button()
			Me.textBoxPdfFilePath = New TextBox()
			Me.btnSelectFile = New Button()
			Me.btnCancel = New Button()
			Me.SuspendLayout()
			' 
			' label1
			' 
			Me.label1.Location = New Point(2, 9)
			Me.label1.Name = "label1"
			Me.label1.Size = New Size(413, 51)
			Me.label1.TabIndex = 0
			Me.label1.Text = resources.GetString("label1.Text")
			' 
			' btnCreatePdf
			' 
			Me.btnCreatePdf.FlatStyle = FlatStyle.Flat
			Me.btnCreatePdf.Location = New Point(5, 100)
			Me.btnCreatePdf.Name = "btnCreatePdf"
			Me.btnCreatePdf.Size = New Size(75, 32)
			Me.btnCreatePdf.TabIndex = 1
			Me.btnCreatePdf.Text = "Create PDF"
			Me.btnCreatePdf.UseVisualStyleBackColor = True
'			Me.btnCreatePdf.Click += New System.EventHandler(Me.btnCreatePdf_Click)
			' 
			' textBoxPdfFilePath
			' 
			Me.textBoxPdfFilePath.Location = New Point(5, 74)
			Me.textBoxPdfFilePath.Name = "textBoxPdfFilePath"
			Me.textBoxPdfFilePath.Size = New Size(338, 20)
			Me.textBoxPdfFilePath.TabIndex = 2
			' 
			' btnSelectFile
			' 
			Me.btnSelectFile.FlatStyle = FlatStyle.Flat
			Me.btnSelectFile.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.btnSelectFile.Location = New Point(349, 68)
			Me.btnSelectFile.Name = "btnSelectFile"
			Me.btnSelectFile.Size = New Size(66, 31)
			Me.btnSelectFile.TabIndex = 18
			Me.btnSelectFile.Text = "Browse"
			Me.btnSelectFile.UseVisualStyleBackColor = True
'			Me.btnSelectFile.Click += New System.EventHandler(Me.btnSelectFile_Click)
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(419, 135)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 19
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' PdfStamps
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(427, 144)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.btnSelectFile)
			Me.Controls.Add(Me.textBoxPdfFilePath)
			Me.Controls.Add(Me.btnCreatePdf)
			Me.Controls.Add(Me.label1)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "PdfStamps"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "PDF Stamps Demo"
'			Me.Load += New System.EventHandler(Me.PdfStamps_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label1 As Label
		Private WithEvents btnCreatePdf As Button
		Private textBoxPdfFilePath As TextBox
		Private WithEvents btnSelectFile As Button
		Private btnCancel As Button
	End Class
End Namespace

