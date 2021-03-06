Namespace EvoHtmlToPdfDemo
	Partial Public Class TableOfContentsAndBookmarks
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
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(TableOfContentsAndBookmarks))
			Me.label3 = New Label()
			Me.btnConvert = New Button()
			Me.lnkViewHtmlBook = New LinkLabel()
			Me.btnCancel = New Button()
			Me.SuspendLayout()
			' 
			' label3
			' 
			Me.label3.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.label3.Location = New Point(19, 11)
			Me.label3.Name = "label3"
			Me.label3.Size = New Size(542, 70)
			Me.label3.TabIndex = 11
			Me.label3.Text = resources.GetString("label3.Text")
			' 
			' btnConvert
			' 
			Me.btnConvert.FlatStyle = FlatStyle.Flat
			Me.btnConvert.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.btnConvert.Location = New Point(22, 96)
			Me.btnConvert.Name = "btnConvert"
			Me.btnConvert.Size = New Size(140, 27)
			Me.btnConvert.TabIndex = 10
			Me.btnConvert.Text = "Convert to PDF"
			Me.btnConvert.UseVisualStyleBackColor = True
'			Me.btnConvert.Click += New System.EventHandler(Me.btnConvert_Click)
			' 
			' lnkViewHtmlBook
			' 
			Me.lnkViewHtmlBook.AutoSize = True
			Me.lnkViewHtmlBook.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.lnkViewHtmlBook.Location = New Point(193, 103)
			Me.lnkViewHtmlBook.Name = "lnkViewHtmlBook"
			Me.lnkViewHtmlBook.Size = New Size(91, 13)
			Me.lnkViewHtmlBook.TabIndex = 12
			Me.lnkViewHtmlBook.TabStop = True
			Me.lnkViewHtmlBook.Text = "View HTML Book"
'			Me.lnkViewHtmlBook.LinkClicked += New System.Windows.Forms.LinkLabelLinkClickedEventHandler(Me.lnkViewHtmlBook_LinkClicked)
			' 
			' btnCancel
			' 
			Me.btnCancel.DialogResult = DialogResult.Cancel
			Me.btnCancel.FlatStyle = FlatStyle.Flat
			Me.btnCancel.Location = New Point(563, 120)
			Me.btnCancel.Name = "btnCancel"
			Me.btnCancel.Size = New Size(0, 0)
			Me.btnCancel.TabIndex = 13
			Me.btnCancel.TabStop = False
			Me.btnCancel.UseVisualStyleBackColor = True
			' 
			' TableOfContentsAndBookmarks
			' 
			Me.AutoScaleDimensions = New SizeF(6F, 13F)
			Me.AutoScaleMode = AutoScaleMode.Font
			Me.BackColor = Color.White
			Me.CancelButton = Me.btnCancel
			Me.ClientSize = New Size(577, 134)
			Me.Controls.Add(Me.btnCancel)
			Me.Controls.Add(Me.lnkViewHtmlBook)
			Me.Controls.Add(Me.label3)
			Me.Controls.Add(Me.btnConvert)
			Me.Font = New Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Pixel, (CByte(238)))
			Me.FormBorderStyle = FormBorderStyle.FixedSingle
			Me.Icon = (CType(resources.GetObject("$this.Icon"), Icon))
			Me.MaximizeBox = False
			Me.Name = "TableOfContentsAndBookmarks"
			Me.StartPosition = FormStartPosition.CenterParent
			Me.Text = "Create Table Of Contents and Bookmarks"
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		#End Region

		Private label3 As Label
		Private WithEvents btnConvert As Button
		Private WithEvents lnkViewHtmlBook As LinkLabel
		Private btnCancel As Button
	End Class
End Namespace

