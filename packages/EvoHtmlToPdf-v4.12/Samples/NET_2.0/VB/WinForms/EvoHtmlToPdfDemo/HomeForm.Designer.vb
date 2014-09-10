Namespace EvoHtmlToPdfDemo
	Partial Public Class HomeForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
            Me.splitContainer = New System.Windows.Forms.SplitContainer
            Me.groupBoxSelectSample = New System.Windows.Forms.GroupBox
            Me.lnkConvertHtmlString = New System.Windows.Forms.LinkLabel
            Me.lnkMainFeaturesDemo = New System.Windows.Forms.LinkLabel
            Me.lnkHtmlInHeaderFooter = New System.Windows.Forms.LinkLabel
            Me.lnkConvertMultipleURL = New System.Windows.Forms.LinkLabel
            Me.lnkSvgToPdf = New System.Windows.Forms.LinkLabel
            Me.lnkStampsDemo = New System.Windows.Forms.LinkLabel
            Me.lnkImageElement = New System.Windows.Forms.LinkLabel
            Me.lnkTextFonts = New System.Windows.Forms.LinkLabel
            Me.lnkPdfShapes = New System.Windows.Forms.LinkLabel
            Me.lnkHtmlToPdfElement = New System.Windows.Forms.LinkLabel
            Me.lnkAppendPrependPdf = New System.Windows.Forms.LinkLabel
            Me.lnkDigitalSignature = New System.Windows.Forms.LinkLabel
            Me.lnkPdfSecurity = New System.Windows.Forms.LinkLabel
            Me.lnkTableOfContents = New System.Windows.Forms.LinkLabel
            Me.lnkRepeatTableHead = New System.Windows.Forms.LinkLabel
            Me.lnkHtmlPdfLocation = New System.Windows.Forms.LinkLabel
            Me.pnlListBottomMargin = New System.Windows.Forms.Panel
            Me.pnlListRightMargin = New System.Windows.Forms.Panel
            Me.pnlListLeftMargin = New System.Windows.Forms.Panel
            Me.pnlListTopMargin = New System.Windows.Forms.Panel
            Me.pictureBox1 = New System.Windows.Forms.PictureBox
            Me.groupBoxSampleDetails = New System.Windows.Forms.GroupBox
            Me.pnlRunSample = New System.Windows.Forms.Panel
            Me.btnRunSample = New System.Windows.Forms.Button
            Me.pnlSampleDescription = New System.Windows.Forms.Panel
            Me.lblSampleDescription = New System.Windows.Forms.Label
            Me.pnlSampleDetailsTop = New System.Windows.Forms.Panel
            Me.pnlBottomMargin = New System.Windows.Forms.Panel
            Me.pnlTopMargin = New System.Windows.Forms.Panel
            Me.pnlRightMargin = New System.Windows.Forms.Panel
            Me.pnlLeftMargin = New System.Windows.Forms.Panel
            Me.splitContainer.Panel1.SuspendLayout()
            Me.splitContainer.Panel2.SuspendLayout()
            Me.splitContainer.SuspendLayout()
            Me.groupBoxSelectSample.SuspendLayout()
            Me.pnlListTopMargin.SuspendLayout()
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.groupBoxSampleDetails.SuspendLayout()
            Me.pnlRunSample.SuspendLayout()
            Me.pnlSampleDescription.SuspendLayout()
            Me.SuspendLayout()
            '
            'splitContainer
            '
            Me.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
            Me.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill
            Me.splitContainer.Location = New System.Drawing.Point(0, 0)
            Me.splitContainer.Name = "splitContainer"
            '
            'splitContainer.Panel1
            '
            Me.splitContainer.Panel1.BackColor = System.Drawing.Color.White
            Me.splitContainer.Panel1.Controls.Add(Me.groupBoxSelectSample)
            Me.splitContainer.Panel1.Controls.Add(Me.pnlListBottomMargin)
            Me.splitContainer.Panel1.Controls.Add(Me.pnlListRightMargin)
            Me.splitContainer.Panel1.Controls.Add(Me.pnlListLeftMargin)
            Me.splitContainer.Panel1.Controls.Add(Me.pnlListTopMargin)
            '
            'splitContainer.Panel2
            '
            Me.splitContainer.Panel2.BackColor = System.Drawing.Color.White
            Me.splitContainer.Panel2.Controls.Add(Me.groupBoxSampleDetails)
            Me.splitContainer.Panel2.Controls.Add(Me.pnlBottomMargin)
            Me.splitContainer.Panel2.Controls.Add(Me.pnlTopMargin)
            Me.splitContainer.Panel2.Controls.Add(Me.pnlRightMargin)
            Me.splitContainer.Panel2.Controls.Add(Me.pnlLeftMargin)
            Me.splitContainer.Size = New System.Drawing.Size(1008, 660)
            Me.splitContainer.SplitterDistance = 337
            Me.splitContainer.TabIndex = 0
            '
            'groupBoxSelectSample
            '
            Me.groupBoxSelectSample.BackColor = System.Drawing.Color.WhiteSmoke
            Me.groupBoxSelectSample.Controls.Add(Me.lnkConvertHtmlString)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkMainFeaturesDemo)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkHtmlInHeaderFooter)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkConvertMultipleURL)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkSvgToPdf)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkStampsDemo)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkImageElement)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkTextFonts)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkPdfShapes)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkHtmlToPdfElement)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkAppendPrependPdf)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkDigitalSignature)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkPdfSecurity)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkTableOfContents)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkRepeatTableHead)
            Me.groupBoxSelectSample.Controls.Add(Me.lnkHtmlPdfLocation)
            Me.groupBoxSelectSample.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBoxSelectSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.groupBoxSelectSample.Location = New System.Drawing.Point(11, 112)
            Me.groupBoxSelectSample.Name = "groupBoxSelectSample"
            Me.groupBoxSelectSample.Size = New System.Drawing.Size(311, 533)
            Me.groupBoxSelectSample.TabIndex = 4
            Me.groupBoxSelectSample.TabStop = False
            Me.groupBoxSelectSample.Text = "Select a Sample"
            '
            'lnkConvertHtmlString
            '
            Me.lnkConvertHtmlString.AutoSize = True
            Me.lnkConvertHtmlString.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkConvertHtmlString.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkConvertHtmlString.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkConvertHtmlString.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkConvertHtmlString.Location = New System.Drawing.Point(16, 63)
            Me.lnkConvertHtmlString.Name = "lnkConvertHtmlString"
            Me.lnkConvertHtmlString.Size = New System.Drawing.Size(206, 18)
            Me.lnkConvertHtmlString.TabIndex = 0
            Me.lnkConvertHtmlString.TabStop = True
            Me.lnkConvertHtmlString.Text = "Convert HTML Strings to PDF"
            '
            'lnkMainFeaturesDemo
            '
            Me.lnkMainFeaturesDemo.AutoSize = True
            Me.lnkMainFeaturesDemo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkMainFeaturesDemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkMainFeaturesDemo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkMainFeaturesDemo.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkMainFeaturesDemo.Location = New System.Drawing.Point(16, 33)
            Me.lnkMainFeaturesDemo.Name = "lnkMainFeaturesDemo"
            Me.lnkMainFeaturesDemo.Size = New System.Drawing.Size(207, 18)
            Me.lnkMainFeaturesDemo.TabIndex = 0
            Me.lnkMainFeaturesDemo.TabStop = True
            Me.lnkMainFeaturesDemo.Text = "HTML to PDF Features Demo"
            '
            'lnkHtmlInHeaderFooter
            '
            Me.lnkHtmlInHeaderFooter.AutoSize = True
            Me.lnkHtmlInHeaderFooter.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkHtmlInHeaderFooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkHtmlInHeaderFooter.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkHtmlInHeaderFooter.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkHtmlInHeaderFooter.Location = New System.Drawing.Point(16, 123)
            Me.lnkHtmlInHeaderFooter.Name = "lnkHtmlInHeaderFooter"
            Me.lnkHtmlInHeaderFooter.Size = New System.Drawing.Size(196, 18)
            Me.lnkHtmlInHeaderFooter.TabIndex = 0
            Me.lnkHtmlInHeaderFooter.TabStop = True
            Me.lnkHtmlInHeaderFooter.Text = "HTML in Header and Footer "
            '
            'lnkConvertMultipleURL
            '
            Me.lnkConvertMultipleURL.AutoSize = True
            Me.lnkConvertMultipleURL.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkConvertMultipleURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkConvertMultipleURL.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkConvertMultipleURL.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkConvertMultipleURL.Location = New System.Drawing.Point(16, 93)
            Me.lnkConvertMultipleURL.Name = "lnkConvertMultipleURL"
            Me.lnkConvertMultipleURL.Size = New System.Drawing.Size(207, 18)
            Me.lnkConvertMultipleURL.TabIndex = 0
            Me.lnkConvertMultipleURL.TabStop = True
            Me.lnkConvertMultipleURL.Text = "Convert Multiple URLs to PDF"
            '
            'lnkSvgToPdf
            '
            Me.lnkSvgToPdf.AutoSize = True
            Me.lnkSvgToPdf.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkSvgToPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkSvgToPdf.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkSvgToPdf.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkSvgToPdf.Location = New System.Drawing.Point(16, 483)
            Me.lnkSvgToPdf.Name = "lnkSvgToPdf"
            Me.lnkSvgToPdf.Size = New System.Drawing.Size(215, 18)
            Me.lnkSvgToPdf.TabIndex = 0
            Me.lnkSvgToPdf.TabStop = True
            Me.lnkSvgToPdf.Text = "SVG to PDF Conversion Demo"
            '
            'lnkStampsDemo
            '
            Me.lnkStampsDemo.AutoSize = True
            Me.lnkStampsDemo.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkStampsDemo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkStampsDemo.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkStampsDemo.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkStampsDemo.Location = New System.Drawing.Point(16, 453)
            Me.lnkStampsDemo.Name = "lnkStampsDemo"
            Me.lnkStampsDemo.Size = New System.Drawing.Size(252, 18)
            Me.lnkStampsDemo.TabIndex = 0
            Me.lnkStampsDemo.TabStop = True
            Me.lnkStampsDemo.Text = "PDF Stamps and Watermarks Demo"
            '
            'lnkImageElement
            '
            Me.lnkImageElement.AutoSize = True
            Me.lnkImageElement.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkImageElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkImageElement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkImageElement.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkImageElement.Location = New System.Drawing.Point(16, 363)
            Me.lnkImageElement.Name = "lnkImageElement"
            Me.lnkImageElement.Size = New System.Drawing.Size(159, 18)
            Me.lnkImageElement.TabIndex = 0
            Me.lnkImageElement.TabStop = True
            Me.lnkImageElement.Text = "Image Elements Demo"
            '
            'lnkTextFonts
            '
            Me.lnkTextFonts.AutoSize = True
            Me.lnkTextFonts.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkTextFonts.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkTextFonts.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkTextFonts.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkTextFonts.Location = New System.Drawing.Point(16, 333)
            Me.lnkTextFonts.Name = "lnkTextFonts"
            Me.lnkTextFonts.Size = New System.Drawing.Size(229, 18)
            Me.lnkTextFonts.TabIndex = 0
            Me.lnkTextFonts.TabStop = True
            Me.lnkTextFonts.Text = "Texts and True Type Fonts Demo"
            '
            'lnkPdfShapes
            '
            Me.lnkPdfShapes.AutoSize = True
            Me.lnkPdfShapes.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkPdfShapes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkPdfShapes.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkPdfShapes.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkPdfShapes.Location = New System.Drawing.Point(16, 393)
            Me.lnkPdfShapes.Name = "lnkPdfShapes"
            Me.lnkPdfShapes.Size = New System.Drawing.Size(193, 18)
            Me.lnkPdfShapes.TabIndex = 0
            Me.lnkPdfShapes.TabStop = True
            Me.lnkPdfShapes.Text = "PDF Graphic Shapes Demo"
            '
            'lnkHtmlToPdfElement
            '
            Me.lnkHtmlToPdfElement.AutoSize = True
            Me.lnkHtmlToPdfElement.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkHtmlToPdfElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkHtmlToPdfElement.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkHtmlToPdfElement.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkHtmlToPdfElement.Location = New System.Drawing.Point(16, 303)
            Me.lnkHtmlToPdfElement.Name = "lnkHtmlToPdfElement"
            Me.lnkHtmlToPdfElement.Size = New System.Drawing.Size(211, 18)
            Me.lnkHtmlToPdfElement.TabIndex = 0
            Me.lnkHtmlToPdfElement.TabStop = True
            Me.lnkHtmlToPdfElement.Text = "HTML to PDF Elements Demo"
            '
            'lnkAppendPrependPdf
            '
            Me.lnkAppendPrependPdf.AutoSize = True
            Me.lnkAppendPrependPdf.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkAppendPrependPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkAppendPrependPdf.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkAppendPrependPdf.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkAppendPrependPdf.Location = New System.Drawing.Point(16, 273)
            Me.lnkAppendPrependPdf.Name = "lnkAppendPrependPdf"
            Me.lnkAppendPrependPdf.Size = New System.Drawing.Size(229, 18)
            Me.lnkAppendPrependPdf.TabIndex = 0
            Me.lnkAppendPrependPdf.TabStop = True
            Me.lnkAppendPrependPdf.Text = "Append External PDF Documents"
            '
            'lnkDigitalSignature
            '
            Me.lnkDigitalSignature.AutoSize = True
            Me.lnkDigitalSignature.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkDigitalSignature.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkDigitalSignature.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkDigitalSignature.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkDigitalSignature.Location = New System.Drawing.Point(16, 423)
            Me.lnkDigitalSignature.Name = "lnkDigitalSignature"
            Me.lnkDigitalSignature.Size = New System.Drawing.Size(216, 18)
            Me.lnkDigitalSignature.TabIndex = 0
            Me.lnkDigitalSignature.TabStop = True
            Me.lnkDigitalSignature.Text = "Digital Signatures in PDF Demo"
            '
            'lnkPdfSecurity
            '
            Me.lnkPdfSecurity.AutoSize = True
            Me.lnkPdfSecurity.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkPdfSecurity.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkPdfSecurity.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkPdfSecurity.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkPdfSecurity.Location = New System.Drawing.Point(16, 243)
            Me.lnkPdfSecurity.Name = "lnkPdfSecurity"
            Me.lnkPdfSecurity.Size = New System.Drawing.Size(210, 18)
            Me.lnkPdfSecurity.TabIndex = 0
            Me.lnkPdfSecurity.TabStop = True
            Me.lnkPdfSecurity.Text = "PDF Security and Permissions"
            '
            'lnkTableOfContents
            '
            Me.lnkTableOfContents.AutoSize = True
            Me.lnkTableOfContents.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkTableOfContents.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkTableOfContents.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkTableOfContents.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkTableOfContents.Location = New System.Drawing.Point(16, 212)
            Me.lnkTableOfContents.Name = "lnkTableOfContents"
            Me.lnkTableOfContents.Size = New System.Drawing.Size(235, 18)
            Me.lnkTableOfContents.TabIndex = 0
            Me.lnkTableOfContents.TabStop = True
            Me.lnkTableOfContents.Text = "Table of Contents and Bookmarks"
            '
            'lnkRepeatTableHead
            '
            Me.lnkRepeatTableHead.AutoSize = True
            Me.lnkRepeatTableHead.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkRepeatTableHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkRepeatTableHead.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkRepeatTableHead.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkRepeatTableHead.Location = New System.Drawing.Point(16, 183)
            Me.lnkRepeatTableHead.Name = "lnkRepeatTableHead"
            Me.lnkRepeatTableHead.Size = New System.Drawing.Size(228, 18)
            Me.lnkRepeatTableHead.TabIndex = 0
            Me.lnkRepeatTableHead.TabStop = True
            Me.lnkRepeatTableHead.Text = "Repeat HTML Table Head in PDF"
            '
            'lnkHtmlPdfLocation
            '
            Me.lnkHtmlPdfLocation.AutoSize = True
            Me.lnkHtmlPdfLocation.BackColor = System.Drawing.Color.WhiteSmoke
            Me.lnkHtmlPdfLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkHtmlPdfLocation.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
            Me.lnkHtmlPdfLocation.LinkColor = System.Drawing.Color.DarkBlue
            Me.lnkHtmlPdfLocation.Location = New System.Drawing.Point(16, 153)
            Me.lnkHtmlPdfLocation.Name = "lnkHtmlPdfLocation"
            Me.lnkHtmlPdfLocation.Size = New System.Drawing.Size(225, 18)
            Me.lnkHtmlPdfLocation.TabIndex = 0
            Me.lnkHtmlPdfLocation.TabStop = True
            Me.lnkHtmlPdfLocation.Text = "HTML Elements Location in PDF"
            '
            'pnlListBottomMargin
            '
            Me.pnlListBottomMargin.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlListBottomMargin.Location = New System.Drawing.Point(11, 645)
            Me.pnlListBottomMargin.Name = "pnlListBottomMargin"
            Me.pnlListBottomMargin.Size = New System.Drawing.Size(311, 11)
            Me.pnlListBottomMargin.TabIndex = 3
            '
            'pnlListRightMargin
            '
            Me.pnlListRightMargin.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlListRightMargin.Location = New System.Drawing.Point(322, 112)
            Me.pnlListRightMargin.Name = "pnlListRightMargin"
            Me.pnlListRightMargin.Size = New System.Drawing.Size(11, 544)
            Me.pnlListRightMargin.TabIndex = 2
            '
            'pnlListLeftMargin
            '
            Me.pnlListLeftMargin.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlListLeftMargin.Location = New System.Drawing.Point(0, 112)
            Me.pnlListLeftMargin.Name = "pnlListLeftMargin"
            Me.pnlListLeftMargin.Size = New System.Drawing.Size(11, 544)
            Me.pnlListLeftMargin.TabIndex = 1
            '
            'pnlListTopMargin
            '
            Me.pnlListTopMargin.Controls.Add(Me.pictureBox1)
            Me.pnlListTopMargin.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlListTopMargin.Location = New System.Drawing.Point(0, 0)
            Me.pnlListTopMargin.Name = "pnlListTopMargin"
            Me.pnlListTopMargin.Size = New System.Drawing.Size(333, 112)
            Me.pnlListTopMargin.TabIndex = 0
            '
            'pictureBox1
            '
            Me.pictureBox1.Image = Global.My.Resources.Resources.logo
            Me.pictureBox1.Location = New System.Drawing.Point(11, 3)
            Me.pictureBox1.Name = "pictureBox1"
            Me.pictureBox1.Size = New System.Drawing.Size(311, 92)
            Me.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
            Me.pictureBox1.TabIndex = 0
            Me.pictureBox1.TabStop = False
            '
            'groupBoxSampleDetails
            '
            Me.groupBoxSampleDetails.Controls.Add(Me.pnlRunSample)
            Me.groupBoxSampleDetails.Controls.Add(Me.pnlSampleDescription)
            Me.groupBoxSampleDetails.Controls.Add(Me.pnlSampleDetailsTop)
            Me.groupBoxSampleDetails.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBoxSampleDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.groupBoxSampleDetails.Location = New System.Drawing.Point(11, 11)
            Me.groupBoxSampleDetails.Name = "groupBoxSampleDetails"
            Me.groupBoxSampleDetails.Size = New System.Drawing.Size(641, 634)
            Me.groupBoxSampleDetails.TabIndex = 4
            Me.groupBoxSampleDetails.TabStop = False
            Me.groupBoxSampleDetails.Text = "Sample Details"
            '
            'pnlRunSample
            '
            Me.pnlRunSample.Controls.Add(Me.btnRunSample)
            Me.pnlRunSample.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlRunSample.Location = New System.Drawing.Point(3, 51)
            Me.pnlRunSample.Name = "pnlRunSample"
            Me.pnlRunSample.Size = New System.Drawing.Size(635, 101)
            Me.pnlRunSample.TabIndex = 8
            '
            'btnRunSample
            '
            Me.btnRunSample.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnRunSample.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.btnRunSample.Image = Global.My.Resources.Resources.pdficon_20
            Me.btnRunSample.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
            Me.btnRunSample.Location = New System.Drawing.Point(3, 17)
            Me.btnRunSample.Name = "btnRunSample"
            Me.btnRunSample.Size = New System.Drawing.Size(157, 25)
            Me.btnRunSample.TabIndex = 7
            Me.btnRunSample.Text = "Run This Sample"
            Me.btnRunSample.TextAlign = System.Drawing.ContentAlignment.MiddleRight
            Me.btnRunSample.UseVisualStyleBackColor = True
            '
            'pnlSampleDescription
            '
            Me.pnlSampleDescription.AutoSize = True
            Me.pnlSampleDescription.Controls.Add(Me.lblSampleDescription)
            Me.pnlSampleDescription.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSampleDescription.Location = New System.Drawing.Point(3, 33)
            Me.pnlSampleDescription.Name = "pnlSampleDescription"
            Me.pnlSampleDescription.Size = New System.Drawing.Size(635, 18)
            Me.pnlSampleDescription.TabIndex = 7
            '
            'lblSampleDescription
            '
            Me.lblSampleDescription.AutoSize = True
            Me.lblSampleDescription.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblSampleDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lblSampleDescription.Location = New System.Drawing.Point(0, 0)
            Me.lblSampleDescription.Name = "lblSampleDescription"
            Me.lblSampleDescription.Size = New System.Drawing.Size(137, 18)
            Me.lblSampleDescription.TabIndex = 0
            Me.lblSampleDescription.Text = "Sample Description"
            '
            'pnlSampleDetailsTop
            '
            Me.pnlSampleDetailsTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSampleDetailsTop.Location = New System.Drawing.Point(3, 20)
            Me.pnlSampleDetailsTop.Name = "pnlSampleDetailsTop"
            Me.pnlSampleDetailsTop.Size = New System.Drawing.Size(635, 13)
            Me.pnlSampleDetailsTop.TabIndex = 6
            '
            'pnlBottomMargin
            '
            Me.pnlBottomMargin.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlBottomMargin.Location = New System.Drawing.Point(11, 645)
            Me.pnlBottomMargin.Name = "pnlBottomMargin"
            Me.pnlBottomMargin.Size = New System.Drawing.Size(641, 11)
            Me.pnlBottomMargin.TabIndex = 3
            '
            'pnlTopMargin
            '
            Me.pnlTopMargin.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlTopMargin.Location = New System.Drawing.Point(11, 0)
            Me.pnlTopMargin.Name = "pnlTopMargin"
            Me.pnlTopMargin.Size = New System.Drawing.Size(641, 11)
            Me.pnlTopMargin.TabIndex = 2
            '
            'pnlRightMargin
            '
            Me.pnlRightMargin.Dock = System.Windows.Forms.DockStyle.Right
            Me.pnlRightMargin.Location = New System.Drawing.Point(652, 0)
            Me.pnlRightMargin.Name = "pnlRightMargin"
            Me.pnlRightMargin.Size = New System.Drawing.Size(11, 656)
            Me.pnlRightMargin.TabIndex = 1
            '
            'pnlLeftMargin
            '
            Me.pnlLeftMargin.Dock = System.Windows.Forms.DockStyle.Left
            Me.pnlLeftMargin.Location = New System.Drawing.Point(0, 0)
            Me.pnlLeftMargin.Name = "pnlLeftMargin"
            Me.pnlLeftMargin.Size = New System.Drawing.Size(11, 656)
            Me.pnlLeftMargin.TabIndex = 0
            '
            'HomeForm
            '
            Me.ClientSize = New System.Drawing.Size(1008, 660)
            Me.Controls.Add(Me.splitContainer)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.Name = "HomeForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "EVO HTML to PDF Converter for .NET Demo"
            Me.splitContainer.Panel1.ResumeLayout(False)
            Me.splitContainer.Panel2.ResumeLayout(False)
            Me.splitContainer.ResumeLayout(False)
            Me.groupBoxSelectSample.ResumeLayout(False)
            Me.groupBoxSelectSample.PerformLayout()
            Me.pnlListTopMargin.ResumeLayout(False)
            CType(Me.pictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.groupBoxSampleDetails.ResumeLayout(False)
            Me.groupBoxSampleDetails.PerformLayout()
            Me.pnlRunSample.ResumeLayout(False)
            Me.pnlSampleDescription.ResumeLayout(False)
            Me.pnlSampleDescription.PerformLayout()
            Me.ResumeLayout(False)

        End Sub

		#End Region

		Private splitContainer As SplitContainer
		Private pnlTopMargin As Panel
		Private pnlRightMargin As Panel
		Private pnlLeftMargin As Panel
		Private groupBoxSelectSample As GroupBox
		Private WithEvents lnkMainFeaturesDemo As LinkLabel
		Private WithEvents lnkHtmlPdfLocation As LinkLabel
		Private pnlListBottomMargin As Panel
		Private pnlListRightMargin As Panel
		Private pnlListLeftMargin As Panel
		Private pnlListTopMargin As Panel
		Private groupBoxSampleDetails As GroupBox
		Private pnlRunSample As Panel
		Private WithEvents btnRunSample As Button
		Private pnlSampleDescription As Panel
		Private lblSampleDescription As Label
		Private pnlSampleDetailsTop As Panel
		Private pnlBottomMargin As Panel
		Private WithEvents lnkConvertMultipleURL As LinkLabel
		Private WithEvents lnkHtmlInHeaderFooter As LinkLabel
		Private WithEvents lnkRepeatTableHead As LinkLabel
		Private WithEvents lnkTableOfContents As LinkLabel
		Private WithEvents lnkAppendPrependPdf As LinkLabel
		Private WithEvents lnkHtmlToPdfElement As LinkLabel
		Private WithEvents lnkPdfShapes As LinkLabel
		Private WithEvents lnkPdfSecurity As LinkLabel
		Private WithEvents lnkDigitalSignature As LinkLabel
		Private WithEvents lnkTextFonts As LinkLabel
		Private WithEvents lnkStampsDemo As LinkLabel
		Private WithEvents lnkConvertHtmlString As LinkLabel
		Private WithEvents lnkImageElement As LinkLabel
		Private pictureBox1 As PictureBox
		Private WithEvents lnkSvgToPdf As LinkLabel
	End Class
End Namespace

