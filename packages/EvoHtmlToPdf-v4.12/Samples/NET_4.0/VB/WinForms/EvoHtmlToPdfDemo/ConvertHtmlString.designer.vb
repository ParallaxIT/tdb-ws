Namespace EvoHtmlToPdfDemo
	Partial Public Class ConvertHtmlString
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConvertHtmlString))
            Me.lblBaseUrl = New System.Windows.Forms.Label
            Me.textBoxBaseUrl = New System.Windows.Forms.TextBox
            Me.btnConvertMerge = New System.Windows.Forms.Button
            Me.label3 = New System.Windows.Forms.Label
            Me.btnCancel = New System.Windows.Forms.Button
            Me.lblHtmlString = New System.Windows.Forms.Label
            Me.textBoxHtmlString = New System.Windows.Forms.TextBox
            Me.SuspendLayout()
            '
            'lblBaseUrl
            '
            Me.lblBaseUrl.AutoSize = True
            Me.lblBaseUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.lblBaseUrl.Location = New System.Drawing.Point(12, 363)
            Me.lblBaseUrl.Name = "lblBaseUrl"
            Me.lblBaseUrl.Size = New System.Drawing.Size(258, 13)
            Me.lblBaseUrl.TabIndex = 0
            Me.lblBaseUrl.Text = "Base URL to resolve relative URLs in string:"
            '
            'textBoxBaseUrl
            '
            Me.textBoxBaseUrl.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxBaseUrl.Location = New System.Drawing.Point(15, 389)
            Me.textBoxBaseUrl.Name = "textBoxBaseUrl"
            Me.textBoxBaseUrl.Size = New System.Drawing.Size(682, 20)
            Me.textBoxBaseUrl.TabIndex = 1
            Me.textBoxBaseUrl.Text = "http://www.evopdf.com"
            '
            'btnConvertMerge
            '
            Me.btnConvertMerge.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnConvertMerge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.btnConvertMerge.Location = New System.Drawing.Point(15, 439)
            Me.btnConvertMerge.Name = "btnConvertMerge"
            Me.btnConvertMerge.Size = New System.Drawing.Size(140, 26)
            Me.btnConvertMerge.TabIndex = 2
            Me.btnConvertMerge.Text = "Convert"
            Me.btnConvertMerge.UseVisualStyleBackColor = True
            '
            'label3
            '
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label3.Location = New System.Drawing.Point(12, 9)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(685, 42)
            Me.label3.TabIndex = 3
            Me.label3.Text = resources.GetString("label3.Text")
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Location = New System.Drawing.Point(492, 54)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(0, 0)
            Me.btnCancel.TabIndex = 4
            Me.btnCancel.TabStop = False
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'lblHtmlString
            '
            Me.lblHtmlString.AutoSize = True
            Me.lblHtmlString.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.lblHtmlString.Location = New System.Drawing.Point(12, 63)
            Me.lblHtmlString.Name = "lblHtmlString"
            Me.lblHtmlString.Size = New System.Drawing.Size(145, 13)
            Me.lblHtmlString.TabIndex = 0
            Me.lblHtmlString.Text = "HTML String to Convert:"
            '
            'textBoxHtmlString
            '
            Me.textBoxHtmlString.Location = New System.Drawing.Point(15, 89)
            Me.textBoxHtmlString.MaxLength = 1024000
            Me.textBoxHtmlString.Multiline = True
            Me.textBoxHtmlString.Name = "textBoxHtmlString"
            Me.textBoxHtmlString.ScrollBars = System.Windows.Forms.ScrollBars.Both
            Me.textBoxHtmlString.Size = New System.Drawing.Size(682, 245)
            Me.textBoxHtmlString.TabIndex = 5
            Me.textBoxHtmlString.Text = resources.GetString("textBoxHtmlString.Text")
            '
            'ConvertHtmlString
            '
            Me.BackColor = System.Drawing.Color.White
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(709, 477)
            Me.Controls.Add(Me.textBoxHtmlString)
            Me.Controls.Add(Me.btnCancel)
            Me.Controls.Add(Me.label3)
            Me.Controls.Add(Me.btnConvertMerge)
            Me.Controls.Add(Me.textBoxBaseUrl)
            Me.Controls.Add(Me.lblHtmlString)
            Me.Controls.Add(Me.lblBaseUrl)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.Name = "ConvertHtmlString"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Convert a HTML String to PDF"
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private lblBaseUrl As Label
		Private textBoxBaseUrl As TextBox
		Private WithEvents btnConvertMerge As Button
		Private label3 As Label
		Private btnCancel As Button
		Private lblHtmlString As Label
		Private textBoxHtmlString As TextBox
	End Class
End Namespace

