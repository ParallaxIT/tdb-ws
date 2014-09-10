Namespace EvoHtmlToPdfDemo
	Partial Public Class MainFeaturesForm
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFeaturesForm))
            Me.pnlHeader = New System.Windows.Forms.Panel()
            Me.label27 = New System.Windows.Forms.Label()
            Me.label26 = New System.Windows.Forms.Label()
            Me.pnlContent = New System.Windows.Forms.Panel()
            Me.pnlSettingsPanel = New System.Windows.Forms.Panel()
            Me.pnlPDFSettings = New System.Windows.Forms.Panel()
            Me.pnlFooterOptions = New System.Windows.Forms.Panel()
            Me.groupBoxPDFFooterOptions = New System.Windows.Forms.GroupBox()
            Me.cbShowFooterOnFirstPage = New System.Windows.Forms.CheckBox()
            Me.cbShowFooterOnEvenPages = New System.Windows.Forms.CheckBox()
            Me.cbShowFooterOnOddPages = New System.Windows.Forms.CheckBox()
            Me.label19 = New System.Windows.Forms.Label()
            Me.checkBox1 = New System.Windows.Forms.CheckBox()
            Me.cbDrawFooterLine = New System.Windows.Forms.CheckBox()
            Me.label23 = New System.Windows.Forms.Label()
            Me.ddlFooterLineColor = New System.Windows.Forms.ComboBox()
            Me.label51 = New System.Windows.Forms.Label()
            Me.label49 = New System.Windows.Forms.Label()
            Me.textBoxFooterHeight = New System.Windows.Forms.TextBox()
            Me.pnlHeaderOptions = New System.Windows.Forms.Panel()
            Me.groupBoxPDFHeaderOptions = New System.Windows.Forms.GroupBox()
            Me.cbShowHeaderOnEvenPages = New System.Windows.Forms.CheckBox()
            Me.cbShowHeaderOnFirstPage = New System.Windows.Forms.CheckBox()
            Me.cbShowHeaderOnOddPages = New System.Windows.Forms.CheckBox()
            Me.label18 = New System.Windows.Forms.Label()
            Me.label36 = New System.Windows.Forms.Label()
            Me.textBoxHeaderHeight = New System.Windows.Forms.TextBox()
            Me.ddlHeaderLineColor = New System.Windows.Forms.ComboBox()
            Me.label22 = New System.Windows.Forms.Label()
            Me.label35 = New System.Windows.Forms.Label()
            Me.cbDrawHeaderLine = New System.Windows.Forms.CheckBox()
            Me.pnlDocumentOptions = New System.Windows.Forms.Panel()
            Me.groupBoxPDFDocumentOptions = New System.Windows.Forms.GroupBox()
            Me.ddlPdfSubset = New System.Windows.Forms.ComboBox()
            Me.label71 = New System.Windows.Forms.Label()
            Me.label13 = New System.Windows.Forms.Label()
            Me.label17 = New System.Windows.Forms.Label()
            Me.label15 = New System.Windows.Forms.Label()
            Me.label10 = New System.Windows.Forms.Label()
            Me.textBoxRightMargin = New System.Windows.Forms.TextBox()
            Me.textBoxTopMargin = New System.Windows.Forms.TextBox()
            Me.textBoxBottomMargin = New System.Windows.Forms.TextBox()
            Me.textBoxLeftMargin = New System.Windows.Forms.TextBox()
            Me.label16 = New System.Windows.Forms.Label()
            Me.cbShowHeader = New System.Windows.Forms.CheckBox()
            Me.cbShowFooter = New System.Windows.Forms.CheckBox()
            Me.label14 = New System.Windows.Forms.Label()
            Me.label12 = New System.Windows.Forms.Label()
            Me.label11 = New System.Windows.Forms.Label()
            Me.cbAvoidImageBreak = New System.Windows.Forms.CheckBox()
            Me.ddlCompression = New System.Windows.Forms.ComboBox()
            Me.ddlPageOrientation = New System.Windows.Forms.ComboBox()
            Me.ddlPageFormat = New System.Windows.Forms.ComboBox()
            Me.label9 = New System.Windows.Forms.Label()
            Me.label28 = New System.Windows.Forms.Label()
            Me.label8 = New System.Windows.Forms.Label()
            Me.label21 = New System.Windows.Forms.Label()
            Me.label7 = New System.Windows.Forms.Label()
            Me.label5 = New System.Windows.Forms.Label()
            Me.pnlImgeOptions = New System.Windows.Forms.Panel()
            Me.ddlImageFormat = New System.Windows.Forms.ComboBox()
            Me.label4 = New System.Windows.Forms.Label()
            Me.pnlCommonSettings = New System.Windows.Forms.Panel()
            Me.pnlWebPageLoaded = New System.Windows.Forms.Panel()
            Me.groupBox2 = New System.Windows.Forms.GroupBox()
            Me.label74 = New System.Windows.Forms.Label()
            Me.textBoxNavigationTimeout = New System.Windows.Forms.TextBox()
            Me.label75 = New System.Windows.Forms.Label()
            Me.textBoxConversionDelay = New System.Windows.Forms.TextBox()
            Me.label30 = New System.Windows.Forms.Label()
            Me.textBoxPassword = New System.Windows.Forms.TextBox()
            Me.label73 = New System.Windows.Forms.Label()
            Me.label59 = New System.Windows.Forms.Label()
            Me.textBoxUsername = New System.Windows.Forms.TextBox()
            Me.label72 = New System.Windows.Forms.Label()
            Me.label29 = New System.Windows.Forms.Label()
            Me.groupBoxCommonSettings = New System.Windows.Forms.GroupBox()
            Me.pnlWebPageSize = New System.Windows.Forms.Panel()
            Me.textBoxWebPageHeight = New System.Windows.Forms.TextBox()
            Me.textBoxWebPageWidth = New System.Windows.Forms.TextBox()
            Me.label3 = New System.Windows.Forms.Label()
            Me.label1 = New System.Windows.Forms.Label()
            Me.label2 = New System.Windows.Forms.Label()
            Me.lblPageWidth = New System.Windows.Forms.Label()
            Me.pnlWebPageSizeControl = New System.Windows.Forms.Panel()
            Me.lblWebPageSize = New System.Windows.Forms.Label()
            Me.pnlControlPanel = New System.Windows.Forms.Panel()
            Me.groupBox1 = New System.Windows.Forms.GroupBox()
            Me.cbEmbedFonts = New System.Windows.Forms.CheckBox()
            Me.cbJpegCompression = New System.Windows.Forms.CheckBox()
            Me.cbAutoSizePdfPage = New System.Windows.Forms.CheckBox()
            Me.cbFitWidth = New System.Windows.Forms.CheckBox()
            Me.cbBookmarks = New System.Windows.Forms.CheckBox()
            Me.cbScriptsEnabled = New System.Windows.Forms.CheckBox()
            Me.cbLiveLinks = New System.Windows.Forms.CheckBox()
            Me.lnkBtnSettings = New System.Windows.Forms.LinkLabel()
            Me.radioConvertToImage = New System.Windows.Forms.RadioButton()
            Me.radioButtonConvertToPdf = New System.Windows.Forms.RadioButton()
            Me.textBoxWebPageURL = New System.Windows.Forms.TextBox()
            Me.lblEnterURL = New System.Windows.Forms.Label()
            Me.errorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
            Me.pnlConvertCommand = New System.Windows.Forms.Panel()
            Me.btnCancel = New System.Windows.Forms.Button()
            Me.btnConvert = New System.Windows.Forms.Button()
            Me.pnlHeader.SuspendLayout()
            Me.pnlContent.SuspendLayout()
            Me.pnlSettingsPanel.SuspendLayout()
            Me.pnlPDFSettings.SuspendLayout()
            Me.pnlFooterOptions.SuspendLayout()
            Me.groupBoxPDFFooterOptions.SuspendLayout()
            Me.pnlHeaderOptions.SuspendLayout()
            Me.groupBoxPDFHeaderOptions.SuspendLayout()
            Me.pnlDocumentOptions.SuspendLayout()
            Me.groupBoxPDFDocumentOptions.SuspendLayout()
            Me.pnlImgeOptions.SuspendLayout()
            Me.pnlCommonSettings.SuspendLayout()
            Me.pnlWebPageLoaded.SuspendLayout()
            Me.groupBox2.SuspendLayout()
            Me.groupBoxCommonSettings.SuspendLayout()
            Me.pnlWebPageSize.SuspendLayout()
            Me.pnlWebPageSizeControl.SuspendLayout()
            Me.pnlControlPanel.SuspendLayout()
            Me.groupBox1.SuspendLayout()
            CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlConvertCommand.SuspendLayout()
            Me.SuspendLayout()
            '
            'pnlHeader
            '
            Me.pnlHeader.BackColor = System.Drawing.Color.White
            Me.pnlHeader.Controls.Add(Me.label27)
            Me.pnlHeader.Controls.Add(Me.label26)
            Me.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeader.Location = New System.Drawing.Point(0, 0)
            Me.pnlHeader.Name = "pnlHeader"
            Me.pnlHeader.Size = New System.Drawing.Size(724, 96)
            Me.pnlHeader.TabIndex = 0
            '
            'label27
            '
            Me.label27.AutoSize = True
            Me.label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label27.Location = New System.Drawing.Point(175, 9)
            Me.label27.Name = "label27"
            Me.label27.Size = New System.Drawing.Size(371, 17)
            Me.label27.TabIndex = 1
            Me.label27.Text = "EVO HTML to PDF Converter Main Features Demo"
            '
            'label26
            '
            Me.label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label26.Location = New System.Drawing.Point(12, 43)
            Me.label26.Name = "label26"
            Me.label26.Size = New System.Drawing.Size(708, 39)
            Me.label26.TabIndex = 0
            Me.label26.Text = resources.GetString("label26.Text")
            '
            'pnlContent
            '
            Me.pnlContent.AutoScroll = True
            Me.pnlContent.AutoSize = True
            Me.pnlContent.Controls.Add(Me.pnlSettingsPanel)
            Me.pnlContent.Controls.Add(Me.pnlControlPanel)
            Me.pnlContent.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlContent.Location = New System.Drawing.Point(0, 96)
            Me.pnlContent.MaximumSize = New System.Drawing.Size(720, 560)
            Me.pnlContent.Name = "pnlContent"
            Me.pnlContent.Size = New System.Drawing.Size(720, 560)
            Me.pnlContent.TabIndex = 1
            '
            'pnlSettingsPanel
            '
            Me.pnlSettingsPanel.AutoSize = True
            Me.pnlSettingsPanel.Controls.Add(Me.pnlPDFSettings)
            Me.pnlSettingsPanel.Controls.Add(Me.pnlImgeOptions)
            Me.pnlSettingsPanel.Controls.Add(Me.pnlCommonSettings)
            Me.pnlSettingsPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlSettingsPanel.Location = New System.Drawing.Point(0, 129)
            Me.pnlSettingsPanel.Name = "pnlSettingsPanel"
            Me.pnlSettingsPanel.Size = New System.Drawing.Size(703, 762)
            Me.pnlSettingsPanel.TabIndex = 1
            Me.pnlSettingsPanel.Visible = False
            '
            'pnlPDFSettings
            '
            Me.pnlPDFSettings.AutoSize = True
            Me.pnlPDFSettings.Controls.Add(Me.pnlFooterOptions)
            Me.pnlPDFSettings.Controls.Add(Me.pnlHeaderOptions)
            Me.pnlPDFSettings.Controls.Add(Me.pnlDocumentOptions)
            Me.pnlPDFSettings.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlPDFSettings.Location = New System.Drawing.Point(0, 228)
            Me.pnlPDFSettings.Name = "pnlPDFSettings"
            Me.pnlPDFSettings.Size = New System.Drawing.Size(703, 534)
            Me.pnlPDFSettings.TabIndex = 2
            '
            'pnlFooterOptions
            '
            Me.pnlFooterOptions.Controls.Add(Me.groupBoxPDFFooterOptions)
            Me.pnlFooterOptions.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlFooterOptions.Location = New System.Drawing.Point(0, 415)
            Me.pnlFooterOptions.Name = "pnlFooterOptions"
            Me.pnlFooterOptions.Size = New System.Drawing.Size(703, 119)
            Me.pnlFooterOptions.TabIndex = 2
            Me.pnlFooterOptions.Visible = False
            '
            'groupBoxPDFFooterOptions
            '
            Me.groupBoxPDFFooterOptions.BackColor = System.Drawing.Color.White
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.cbShowFooterOnFirstPage)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.cbShowFooterOnEvenPages)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.cbShowFooterOnOddPages)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.label19)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.checkBox1)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.cbDrawFooterLine)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.label23)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.ddlFooterLineColor)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.label51)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.label49)
            Me.groupBoxPDFFooterOptions.Controls.Add(Me.textBoxFooterHeight)
            Me.groupBoxPDFFooterOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBoxPDFFooterOptions.Location = New System.Drawing.Point(0, 0)
            Me.groupBoxPDFFooterOptions.Name = "groupBoxPDFFooterOptions"
            Me.groupBoxPDFFooterOptions.Size = New System.Drawing.Size(703, 119)
            Me.groupBoxPDFFooterOptions.TabIndex = 0
            Me.groupBoxPDFFooterOptions.TabStop = False
            '
            'cbShowFooterOnFirstPage
            '
            Me.cbShowFooterOnFirstPage.AutoSize = True
            Me.cbShowFooterOnFirstPage.Checked = True
            Me.cbShowFooterOnFirstPage.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbShowFooterOnFirstPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbShowFooterOnFirstPage.Location = New System.Drawing.Point(35, 93)
            Me.cbShowFooterOnFirstPage.Name = "cbShowFooterOnFirstPage"
            Me.cbShowFooterOnFirstPage.Size = New System.Drawing.Size(118, 17)
            Me.cbShowFooterOnFirstPage.TabIndex = 67
            Me.cbShowFooterOnFirstPage.Text = "Show on First Page"
            Me.cbShowFooterOnFirstPage.UseVisualStyleBackColor = True
            '
            'cbShowFooterOnEvenPages
            '
            Me.cbShowFooterOnEvenPages.AutoSize = True
            Me.cbShowFooterOnEvenPages.Checked = True
            Me.cbShowFooterOnEvenPages.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbShowFooterOnEvenPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbShowFooterOnEvenPages.Location = New System.Drawing.Point(323, 93)
            Me.cbShowFooterOnEvenPages.Name = "cbShowFooterOnEvenPages"
            Me.cbShowFooterOnEvenPages.Size = New System.Drawing.Size(129, 17)
            Me.cbShowFooterOnEvenPages.TabIndex = 69
            Me.cbShowFooterOnEvenPages.Text = "Show on Even Pages"
            Me.cbShowFooterOnEvenPages.UseVisualStyleBackColor = True
            '
            'cbShowFooterOnOddPages
            '
            Me.cbShowFooterOnOddPages.AutoSize = True
            Me.cbShowFooterOnOddPages.Checked = True
            Me.cbShowFooterOnOddPages.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbShowFooterOnOddPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbShowFooterOnOddPages.Location = New System.Drawing.Point(173, 93)
            Me.cbShowFooterOnOddPages.Name = "cbShowFooterOnOddPages"
            Me.cbShowFooterOnOddPages.Size = New System.Drawing.Size(124, 17)
            Me.cbShowFooterOnOddPages.TabIndex = 68
            Me.cbShowFooterOnOddPages.Text = "Show on Odd Pages"
            Me.cbShowFooterOnOddPages.UseVisualStyleBackColor = True
            '
            'label19
            '
            Me.label19.AutoSize = True
            Me.label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label19.Location = New System.Drawing.Point(12, 16)
            Me.label19.Name = "label19"
            Me.label19.Size = New System.Drawing.Size(122, 13)
            Me.label19.TabIndex = 7
            Me.label19.Text = "PDF Footer Options:"
            '
            'checkBox1
            '
            Me.checkBox1.AutoSize = True
            Me.checkBox1.Checked = True
            Me.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked
            Me.checkBox1.Location = New System.Drawing.Point(35, 386)
            Me.checkBox1.Name = "checkBox1"
            Me.checkBox1.Size = New System.Drawing.Size(107, 17)
            Me.checkBox1.TabIndex = 5
            Me.checkBox1.Text = "Draw Footer Line"
            Me.checkBox1.UseVisualStyleBackColor = True
            '
            'cbDrawFooterLine
            '
            Me.cbDrawFooterLine.AutoSize = True
            Me.cbDrawFooterLine.Checked = True
            Me.cbDrawFooterLine.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbDrawFooterLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbDrawFooterLine.Location = New System.Drawing.Point(324, 70)
            Me.cbDrawFooterLine.Name = "cbDrawFooterLine"
            Me.cbDrawFooterLine.Size = New System.Drawing.Size(107, 17)
            Me.cbDrawFooterLine.TabIndex = 5
            Me.cbDrawFooterLine.Text = "Draw Footer Line"
            Me.cbDrawFooterLine.UseVisualStyleBackColor = True
            '
            'label23
            '
            Me.label23.AutoSize = True
            Me.label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label23.Location = New System.Drawing.Point(31, 69)
            Me.label23.Name = "label23"
            Me.label23.Size = New System.Drawing.Size(90, 13)
            Me.label23.TabIndex = 8
            Me.label23.Text = "Footer Line Color:"
            '
            'ddlFooterLineColor
            '
            Me.ddlFooterLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ddlFooterLineColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.ddlFooterLineColor.FormattingEnabled = True
            Me.ddlFooterLineColor.Location = New System.Drawing.Point(147, 68)
            Me.ddlFooterLineColor.Name = "ddlFooterLineColor"
            Me.ddlFooterLineColor.Size = New System.Drawing.Size(121, 21)
            Me.ddlFooterLineColor.TabIndex = 6
            '
            'label51
            '
            Me.label51.AutoSize = True
            Me.label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label51.Location = New System.Drawing.Point(32, 47)
            Me.label51.Name = "label51"
            Me.label51.Size = New System.Drawing.Size(71, 13)
            Me.label51.TabIndex = 22
            Me.label51.Text = "Footer Height"
            '
            'label49
            '
            Me.label49.AutoSize = True
            Me.label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label49.Location = New System.Drawing.Point(274, 49)
            Me.label49.Name = "label49"
            Me.label49.Size = New System.Drawing.Size(16, 13)
            Me.label49.TabIndex = 7
            Me.label49.Text = "pt"
            '
            'textBoxFooterHeight
            '
            Me.textBoxFooterHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxFooterHeight.Location = New System.Drawing.Point(147, 42)
            Me.textBoxFooterHeight.Name = "textBoxFooterHeight"
            Me.textBoxFooterHeight.Size = New System.Drawing.Size(121, 20)
            Me.textBoxFooterHeight.TabIndex = 18
            Me.textBoxFooterHeight.Text = "40"
            '
            'pnlHeaderOptions
            '
            Me.pnlHeaderOptions.Controls.Add(Me.groupBoxPDFHeaderOptions)
            Me.pnlHeaderOptions.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlHeaderOptions.Location = New System.Drawing.Point(0, 289)
            Me.pnlHeaderOptions.Name = "pnlHeaderOptions"
            Me.pnlHeaderOptions.Size = New System.Drawing.Size(703, 126)
            Me.pnlHeaderOptions.TabIndex = 1
            Me.pnlHeaderOptions.Visible = False
            '
            'groupBoxPDFHeaderOptions
            '
            Me.groupBoxPDFHeaderOptions.BackColor = System.Drawing.Color.White
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.cbShowHeaderOnEvenPages)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.cbShowHeaderOnFirstPage)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.cbShowHeaderOnOddPages)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.label18)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.label36)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.textBoxHeaderHeight)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.ddlHeaderLineColor)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.label22)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.label35)
            Me.groupBoxPDFHeaderOptions.Controls.Add(Me.cbDrawHeaderLine)
            Me.groupBoxPDFHeaderOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBoxPDFHeaderOptions.Location = New System.Drawing.Point(0, 0)
            Me.groupBoxPDFHeaderOptions.Name = "groupBoxPDFHeaderOptions"
            Me.groupBoxPDFHeaderOptions.Size = New System.Drawing.Size(703, 126)
            Me.groupBoxPDFHeaderOptions.TabIndex = 0
            Me.groupBoxPDFHeaderOptions.TabStop = False
            '
            'cbShowHeaderOnEvenPages
            '
            Me.cbShowHeaderOnEvenPages.AutoSize = True
            Me.cbShowHeaderOnEvenPages.Checked = True
            Me.cbShowHeaderOnEvenPages.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbShowHeaderOnEvenPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbShowHeaderOnEvenPages.Location = New System.Drawing.Point(324, 92)
            Me.cbShowHeaderOnEvenPages.Name = "cbShowHeaderOnEvenPages"
            Me.cbShowHeaderOnEvenPages.Size = New System.Drawing.Size(129, 17)
            Me.cbShowHeaderOnEvenPages.TabIndex = 68
            Me.cbShowHeaderOnEvenPages.Text = "Show on Even Pages"
            Me.cbShowHeaderOnEvenPages.UseVisualStyleBackColor = True
            '
            'cbShowHeaderOnFirstPage
            '
            Me.cbShowHeaderOnFirstPage.AutoSize = True
            Me.cbShowHeaderOnFirstPage.Checked = True
            Me.cbShowHeaderOnFirstPage.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbShowHeaderOnFirstPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbShowHeaderOnFirstPage.Location = New System.Drawing.Point(32, 93)
            Me.cbShowHeaderOnFirstPage.Name = "cbShowHeaderOnFirstPage"
            Me.cbShowHeaderOnFirstPage.Size = New System.Drawing.Size(118, 17)
            Me.cbShowHeaderOnFirstPage.TabIndex = 67
            Me.cbShowHeaderOnFirstPage.Text = "Show on First Page"
            Me.cbShowHeaderOnFirstPage.UseVisualStyleBackColor = True
            '
            'cbShowHeaderOnOddPages
            '
            Me.cbShowHeaderOnOddPages.AutoSize = True
            Me.cbShowHeaderOnOddPages.Checked = True
            Me.cbShowHeaderOnOddPages.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbShowHeaderOnOddPages.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbShowHeaderOnOddPages.Location = New System.Drawing.Point(173, 93)
            Me.cbShowHeaderOnOddPages.Name = "cbShowHeaderOnOddPages"
            Me.cbShowHeaderOnOddPages.Size = New System.Drawing.Size(124, 17)
            Me.cbShowHeaderOnOddPages.TabIndex = 67
            Me.cbShowHeaderOnOddPages.Text = "Show on Odd Pages"
            Me.cbShowHeaderOnOddPages.UseVisualStyleBackColor = True
            '
            'label18
            '
            Me.label18.AutoSize = True
            Me.label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label18.Location = New System.Drawing.Point(12, 16)
            Me.label18.Name = "label18"
            Me.label18.Size = New System.Drawing.Size(127, 13)
            Me.label18.TabIndex = 4
            Me.label18.Text = "PDF Header Options:"
            '
            'label36
            '
            Me.label36.AutoSize = True
            Me.label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label36.Location = New System.Drawing.Point(31, 43)
            Me.label36.Name = "label36"
            Me.label36.Size = New System.Drawing.Size(79, 13)
            Me.label36.TabIndex = 22
            Me.label36.Text = "Header Height:"
            '
            'textBoxHeaderHeight
            '
            Me.textBoxHeaderHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxHeaderHeight.Location = New System.Drawing.Point(148, 40)
            Me.textBoxHeaderHeight.Name = "textBoxHeaderHeight"
            Me.textBoxHeaderHeight.Size = New System.Drawing.Size(120, 20)
            Me.textBoxHeaderHeight.TabIndex = 18
            Me.textBoxHeaderHeight.Text = "40"
            '
            'ddlHeaderLineColor
            '
            Me.ddlHeaderLineColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ddlHeaderLineColor.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.ddlHeaderLineColor.FormattingEnabled = True
            Me.ddlHeaderLineColor.Location = New System.Drawing.Point(148, 66)
            Me.ddlHeaderLineColor.Name = "ddlHeaderLineColor"
            Me.ddlHeaderLineColor.Size = New System.Drawing.Size(121, 21)
            Me.ddlHeaderLineColor.TabIndex = 2
            '
            'label22
            '
            Me.label22.AutoSize = True
            Me.label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label22.Location = New System.Drawing.Point(29, 69)
            Me.label22.Name = "label22"
            Me.label22.Size = New System.Drawing.Size(95, 13)
            Me.label22.TabIndex = 5
            Me.label22.Text = "Header Line Color:"
            '
            'label35
            '
            Me.label35.AutoSize = True
            Me.label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label35.Location = New System.Drawing.Point(266, 43)
            Me.label35.Name = "label35"
            Me.label35.Size = New System.Drawing.Size(16, 13)
            Me.label35.TabIndex = 7
            Me.label35.Text = "pt"
            '
            'cbDrawHeaderLine
            '
            Me.cbDrawHeaderLine.AutoSize = True
            Me.cbDrawHeaderLine.Checked = True
            Me.cbDrawHeaderLine.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbDrawHeaderLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbDrawHeaderLine.Location = New System.Drawing.Point(324, 69)
            Me.cbDrawHeaderLine.Name = "cbDrawHeaderLine"
            Me.cbDrawHeaderLine.Size = New System.Drawing.Size(112, 17)
            Me.cbDrawHeaderLine.TabIndex = 3
            Me.cbDrawHeaderLine.Text = "Draw Header Line"
            Me.cbDrawHeaderLine.UseVisualStyleBackColor = True
            '
            'pnlDocumentOptions
            '
            Me.pnlDocumentOptions.Controls.Add(Me.groupBoxPDFDocumentOptions)
            Me.pnlDocumentOptions.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlDocumentOptions.Location = New System.Drawing.Point(0, 0)
            Me.pnlDocumentOptions.Name = "pnlDocumentOptions"
            Me.pnlDocumentOptions.Size = New System.Drawing.Size(703, 289)
            Me.pnlDocumentOptions.TabIndex = 0
            '
            'groupBoxPDFDocumentOptions
            '
            Me.groupBoxPDFDocumentOptions.BackColor = System.Drawing.Color.White
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.ddlPdfSubset)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label71)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label13)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label17)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label15)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label10)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.textBoxRightMargin)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.textBoxTopMargin)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.textBoxBottomMargin)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.textBoxLeftMargin)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label16)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.cbShowHeader)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.cbShowFooter)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label14)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label12)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label11)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.cbAvoidImageBreak)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.ddlCompression)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.ddlPageOrientation)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.ddlPageFormat)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label9)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label28)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label8)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label21)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label7)
            Me.groupBoxPDFDocumentOptions.Controls.Add(Me.label5)
            Me.groupBoxPDFDocumentOptions.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBoxPDFDocumentOptions.Location = New System.Drawing.Point(0, 0)
            Me.groupBoxPDFDocumentOptions.Name = "groupBoxPDFDocumentOptions"
            Me.groupBoxPDFDocumentOptions.Size = New System.Drawing.Size(703, 289)
            Me.groupBoxPDFDocumentOptions.TabIndex = 0
            Me.groupBoxPDFDocumentOptions.TabStop = False
            '
            'ddlPdfSubset
            '
            Me.ddlPdfSubset.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ddlPdfSubset.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.ddlPdfSubset.FormattingEnabled = True
            Me.ddlPdfSubset.Location = New System.Drawing.Point(471, 75)
            Me.ddlPdfSubset.Name = "ddlPdfSubset"
            Me.ddlPdfSubset.Size = New System.Drawing.Size(121, 21)
            Me.ddlPdfSubset.TabIndex = 37
            '
            'label71
            '
            Me.label71.AutoSize = True
            Me.label71.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label71.Location = New System.Drawing.Point(336, 78)
            Me.label71.Name = "label71"
            Me.label71.Size = New System.Drawing.Size(77, 13)
            Me.label71.TabIndex = 38
            Me.label71.Text = "PDF Standard:"
            '
            'label13
            '
            Me.label13.AutoSize = True
            Me.label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label13.Location = New System.Drawing.Point(283, 195)
            Me.label13.Name = "label13"
            Me.label13.Size = New System.Drawing.Size(35, 13)
            Me.label13.TabIndex = 21
            Me.label13.Text = "Right:"
            '
            'label17
            '
            Me.label17.AutoSize = True
            Me.label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label17.Location = New System.Drawing.Point(283, 224)
            Me.label17.Name = "label17"
            Me.label17.Size = New System.Drawing.Size(29, 13)
            Me.label17.TabIndex = 24
            Me.label17.Text = "Top:"
            '
            'label15
            '
            Me.label15.AutoSize = True
            Me.label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label15.Location = New System.Drawing.Point(61, 221)
            Me.label15.Name = "label15"
            Me.label15.Size = New System.Drawing.Size(43, 13)
            Me.label15.TabIndex = 23
            Me.label15.Text = "Bottom:"
            '
            'label10
            '
            Me.label10.AutoSize = True
            Me.label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label10.Location = New System.Drawing.Point(61, 195)
            Me.label10.Name = "label10"
            Me.label10.Size = New System.Drawing.Size(28, 13)
            Me.label10.TabIndex = 22
            Me.label10.Text = "Left:"
            '
            'textBoxRightMargin
            '
            Me.textBoxRightMargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxRightMargin.Location = New System.Drawing.Point(323, 192)
            Me.textBoxRightMargin.Name = "textBoxRightMargin"
            Me.textBoxRightMargin.Size = New System.Drawing.Size(104, 20)
            Me.textBoxRightMargin.TabIndex = 20
            Me.textBoxRightMargin.Text = "0"
            '
            'textBoxTopMargin
            '
            Me.textBoxTopMargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxTopMargin.Location = New System.Drawing.Point(323, 221)
            Me.textBoxTopMargin.Name = "textBoxTopMargin"
            Me.textBoxTopMargin.Size = New System.Drawing.Size(104, 20)
            Me.textBoxTopMargin.TabIndex = 19
            Me.textBoxTopMargin.Text = "0"
            '
            'textBoxBottomMargin
            '
            Me.textBoxBottomMargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxBottomMargin.Location = New System.Drawing.Point(109, 218)
            Me.textBoxBottomMargin.Name = "textBoxBottomMargin"
            Me.textBoxBottomMargin.Size = New System.Drawing.Size(104, 20)
            Me.textBoxBottomMargin.TabIndex = 17
            Me.textBoxBottomMargin.Text = "0"
            '
            'textBoxLeftMargin
            '
            Me.textBoxLeftMargin.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxLeftMargin.Location = New System.Drawing.Point(109, 192)
            Me.textBoxLeftMargin.Name = "textBoxLeftMargin"
            Me.textBoxLeftMargin.Size = New System.Drawing.Size(104, 20)
            Me.textBoxLeftMargin.TabIndex = 18
            Me.textBoxLeftMargin.Text = "0"
            '
            'label16
            '
            Me.label16.AutoSize = True
            Me.label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label16.Location = New System.Drawing.Point(433, 224)
            Me.label16.Name = "label16"
            Me.label16.Size = New System.Drawing.Size(16, 13)
            Me.label16.TabIndex = 12
            Me.label16.Text = "pt"
            '
            'cbShowHeader
            '
            Me.cbShowHeader.AutoSize = True
            Me.cbShowHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbShowHeader.Location = New System.Drawing.Point(178, 137)
            Me.cbShowHeader.Name = "cbShowHeader"
            Me.cbShowHeader.Size = New System.Drawing.Size(91, 17)
            Me.cbShowHeader.TabIndex = 5
            Me.cbShowHeader.Text = "Show Header"
            Me.cbShowHeader.UseVisualStyleBackColor = True
            '
            'cbShowFooter
            '
            Me.cbShowFooter.AutoSize = True
            Me.cbShowFooter.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbShowFooter.Location = New System.Drawing.Point(64, 137)
            Me.cbShowFooter.Name = "cbShowFooter"
            Me.cbShowFooter.Size = New System.Drawing.Size(86, 17)
            Me.cbShowFooter.TabIndex = 6
            Me.cbShowFooter.Text = "Show Footer"
            Me.cbShowFooter.UseVisualStyleBackColor = True
            '
            'label14
            '
            Me.label14.AutoSize = True
            Me.label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label14.Location = New System.Drawing.Point(219, 221)
            Me.label14.Name = "label14"
            Me.label14.Size = New System.Drawing.Size(16, 13)
            Me.label14.TabIndex = 3
            Me.label14.Text = "pt"
            '
            'label12
            '
            Me.label12.AutoSize = True
            Me.label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label12.Location = New System.Drawing.Point(433, 195)
            Me.label12.Name = "label12"
            Me.label12.Size = New System.Drawing.Size(16, 13)
            Me.label12.TabIndex = 4
            Me.label12.Text = "pt"
            '
            'label11
            '
            Me.label11.AutoSize = True
            Me.label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label11.Location = New System.Drawing.Point(219, 195)
            Me.label11.Name = "label11"
            Me.label11.Size = New System.Drawing.Size(16, 13)
            Me.label11.TabIndex = 7
            Me.label11.Text = "pt"
            '
            'cbAvoidImageBreak
            '
            Me.cbAvoidImageBreak.AutoSize = True
            Me.cbAvoidImageBreak.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbAvoidImageBreak.Location = New System.Drawing.Point(34, 259)
            Me.cbAvoidImageBreak.Name = "cbAvoidImageBreak"
            Me.cbAvoidImageBreak.Size = New System.Drawing.Size(121, 17)
            Me.cbAvoidImageBreak.TabIndex = 10
            Me.cbAvoidImageBreak.Text = "Avoid Images Break"
            Me.cbAvoidImageBreak.UseVisualStyleBackColor = True
            '
            'ddlCompression
            '
            Me.ddlCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ddlCompression.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.ddlCompression.FormattingEnabled = True
            Me.ddlCompression.Location = New System.Drawing.Point(147, 71)
            Me.ddlCompression.Name = "ddlCompression"
            Me.ddlCompression.Size = New System.Drawing.Size(121, 21)
            Me.ddlCompression.TabIndex = 11
            '
            'ddlPageOrientation
            '
            Me.ddlPageOrientation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlPageOrientation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.ddlPageOrientation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ddlPageOrientation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.ddlPageOrientation.FormattingEnabled = True
            Me.ddlPageOrientation.Location = New System.Drawing.Point(471, 43)
            Me.ddlPageOrientation.Name = "ddlPageOrientation"
            Me.ddlPageOrientation.Size = New System.Drawing.Size(121, 21)
            Me.ddlPageOrientation.TabIndex = 8
            '
            'ddlPageFormat
            '
            Me.ddlPageFormat.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
            Me.ddlPageFormat.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.ddlPageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ddlPageFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.ddlPageFormat.FormattingEnabled = True
            Me.ddlPageFormat.Items.AddRange(New Object() {"A0", "A1", "A2", "A3", "A4", "A5", "A6", "A7", "A8", "A9", "A10", "B0", "B1", "B2", "B3", "B4", "B5", "ArchA", "ArchB", "ArchC", "ArchD", "ArchE", "Flsa", "HalfLetter", "Ledger", "Legal", "Letter", "Letter11x17", "Note"})
            Me.ddlPageFormat.Location = New System.Drawing.Point(148, 44)
            Me.ddlPageFormat.Name = "ddlPageFormat"
            Me.ddlPageFormat.Size = New System.Drawing.Size(121, 21)
            Me.ddlPageFormat.TabIndex = 8
            '
            'label9
            '
            Me.label9.AutoSize = True
            Me.label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label9.Location = New System.Drawing.Point(31, 167)
            Me.label9.Name = "label9"
            Me.label9.Size = New System.Drawing.Size(99, 13)
            Me.label9.TabIndex = 16
            Me.label9.Text = "Document Margins:"
            '
            'label28
            '
            Me.label28.AutoSize = True
            Me.label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label28.Location = New System.Drawing.Point(336, 47)
            Me.label28.Name = "label28"
            Me.label28.Size = New System.Drawing.Size(113, 13)
            Me.label28.TabIndex = 13
            Me.label28.Text = "PDF Page Orientation:"
            '
            'label8
            '
            Me.label8.AutoSize = True
            Me.label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label8.Location = New System.Drawing.Point(31, 111)
            Me.label8.Name = "label8"
            Me.label8.Size = New System.Drawing.Size(99, 13)
            Me.label8.TabIndex = 15
            Me.label8.Text = "Header and Footer:"
            '
            'label21
            '
            Me.label21.AutoSize = True
            Me.label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label21.Location = New System.Drawing.Point(31, 47)
            Me.label21.Name = "label21"
            Me.label21.Size = New System.Drawing.Size(82, 13)
            Me.label21.TabIndex = 13
            Me.label21.Text = "PDF Page Size:"
            '
            'label7
            '
            Me.label7.AutoSize = True
            Me.label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label7.Location = New System.Drawing.Point(31, 75)
            Me.label7.Name = "label7"
            Me.label7.Size = New System.Drawing.Size(94, 13)
            Me.label7.TabIndex = 14
            Me.label7.Text = "PDF Compression:"
            '
            'label5
            '
            Me.label5.AutoSize = True
            Me.label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label5.Location = New System.Drawing.Point(12, 16)
            Me.label5.Name = "label5"
            Me.label5.Size = New System.Drawing.Size(143, 13)
            Me.label5.TabIndex = 9
            Me.label5.Text = "PDF Document Options:"
            '
            'pnlImgeOptions
            '
            Me.pnlImgeOptions.BackColor = System.Drawing.Color.White
            Me.pnlImgeOptions.Controls.Add(Me.ddlImageFormat)
            Me.pnlImgeOptions.Controls.Add(Me.label4)
            Me.pnlImgeOptions.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlImgeOptions.Location = New System.Drawing.Point(0, 186)
            Me.pnlImgeOptions.Name = "pnlImgeOptions"
            Me.pnlImgeOptions.Size = New System.Drawing.Size(703, 42)
            Me.pnlImgeOptions.TabIndex = 1
            Me.pnlImgeOptions.Visible = False
            '
            'ddlImageFormat
            '
            Me.ddlImageFormat.BackColor = System.Drawing.Color.White
            Me.ddlImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
            Me.ddlImageFormat.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.ddlImageFormat.FormattingEnabled = True
            Me.ddlImageFormat.Location = New System.Drawing.Point(136, 10)
            Me.ddlImageFormat.Name = "ddlImageFormat"
            Me.ddlImageFormat.Size = New System.Drawing.Size(121, 21)
            Me.ddlImageFormat.TabIndex = 0
            '
            'label4
            '
            Me.label4.AutoSize = True
            Me.label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label4.Location = New System.Drawing.Point(15, 13)
            Me.label4.Name = "label4"
            Me.label4.Size = New System.Drawing.Size(87, 13)
            Me.label4.TabIndex = 0
            Me.label4.Text = "Image Format:"
            '
            'pnlCommonSettings
            '
            Me.pnlCommonSettings.AutoSize = True
            Me.pnlCommonSettings.Controls.Add(Me.pnlWebPageLoaded)
            Me.pnlCommonSettings.Controls.Add(Me.groupBoxCommonSettings)
            Me.pnlCommonSettings.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlCommonSettings.Location = New System.Drawing.Point(0, 0)
            Me.pnlCommonSettings.Name = "pnlCommonSettings"
            Me.pnlCommonSettings.Size = New System.Drawing.Size(703, 186)
            Me.pnlCommonSettings.TabIndex = 0
            '
            'pnlWebPageLoaded
            '
            Me.pnlWebPageLoaded.Controls.Add(Me.groupBox2)
            Me.pnlWebPageLoaded.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlWebPageLoaded.Location = New System.Drawing.Point(0, 111)
            Me.pnlWebPageLoaded.Name = "pnlWebPageLoaded"
            Me.pnlWebPageLoaded.Size = New System.Drawing.Size(703, 75)
            Me.pnlWebPageLoaded.TabIndex = 1
            '
            'groupBox2
            '
            Me.groupBox2.BackColor = System.Drawing.Color.White
            Me.groupBox2.Controls.Add(Me.label74)
            Me.groupBox2.Controls.Add(Me.textBoxNavigationTimeout)
            Me.groupBox2.Controls.Add(Me.label75)
            Me.groupBox2.Controls.Add(Me.textBoxConversionDelay)
            Me.groupBox2.Controls.Add(Me.label30)
            Me.groupBox2.Controls.Add(Me.textBoxPassword)
            Me.groupBox2.Controls.Add(Me.label73)
            Me.groupBox2.Controls.Add(Me.label59)
            Me.groupBox2.Controls.Add(Me.textBoxUsername)
            Me.groupBox2.Controls.Add(Me.label72)
            Me.groupBox2.Controls.Add(Me.label29)
            Me.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBox2.Location = New System.Drawing.Point(0, 0)
            Me.groupBox2.Name = "groupBox2"
            Me.groupBox2.Size = New System.Drawing.Size(703, 75)
            Me.groupBox2.TabIndex = 11
            Me.groupBox2.TabStop = False
            '
            'label74
            '
            Me.label74.AutoSize = True
            Me.label74.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label74.Location = New System.Drawing.Point(237, 42)
            Me.label74.Name = "label74"
            Me.label74.Size = New System.Drawing.Size(117, 13)
            Me.label74.TabIndex = 44
            Me.label74.Text = "Navigation Timeout"
            '
            'textBoxNavigationTimeout
            '
            Me.textBoxNavigationTimeout.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxNavigationTimeout.Location = New System.Drawing.Point(374, 39)
            Me.textBoxNavigationTimeout.Name = "textBoxNavigationTimeout"
            Me.textBoxNavigationTimeout.Size = New System.Drawing.Size(46, 20)
            Me.textBoxNavigationTimeout.TabIndex = 43
            Me.textBoxNavigationTimeout.Text = "60"
            '
            'label75
            '
            Me.label75.AutoSize = True
            Me.label75.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label75.Location = New System.Drawing.Point(425, 42)
            Me.label75.Name = "label75"
            Me.label75.Size = New System.Drawing.Size(24, 13)
            Me.label75.TabIndex = 42
            Me.label75.Text = "sec"
            '
            'textBoxConversionDelay
            '
            Me.textBoxConversionDelay.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxConversionDelay.Location = New System.Drawing.Point(148, 39)
            Me.textBoxConversionDelay.Name = "textBoxConversionDelay"
            Me.textBoxConversionDelay.Size = New System.Drawing.Size(36, 20)
            Me.textBoxConversionDelay.TabIndex = 1
            Me.textBoxConversionDelay.Text = "2"
            '
            'label30
            '
            Me.label30.AutoSize = True
            Me.label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.label30.Location = New System.Drawing.Point(15, 16)
            Me.label30.Name = "label30"
            Me.label30.Size = New System.Drawing.Size(93, 13)
            Me.label30.TabIndex = 21
            Me.label30.Text = "Authentication:"
            '
            'textBoxPassword
            '
            Me.textBoxPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxPassword.Location = New System.Drawing.Point(404, 13)
            Me.textBoxPassword.Name = "textBoxPassword"
            Me.textBoxPassword.Size = New System.Drawing.Size(104, 20)
            Me.textBoxPassword.TabIndex = 20
            '
            'label73
            '
            Me.label73.AutoSize = True
            Me.label73.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label73.Location = New System.Drawing.Point(190, 42)
            Me.label73.Name = "label73"
            Me.label73.Size = New System.Drawing.Size(24, 13)
            Me.label73.TabIndex = 0
            Me.label73.Text = "sec"
            '
            'label59
            '
            Me.label59.AutoSize = True
            Me.label59.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label59.Location = New System.Drawing.Point(340, 16)
            Me.label59.Name = "label59"
            Me.label59.Size = New System.Drawing.Size(56, 13)
            Me.label59.TabIndex = 17
            Me.label59.Text = "Password:"
            '
            'textBoxUsername
            '
            Me.textBoxUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxUsername.Location = New System.Drawing.Point(219, 13)
            Me.textBoxUsername.Name = "textBoxUsername"
            Me.textBoxUsername.Size = New System.Drawing.Size(104, 20)
            Me.textBoxUsername.TabIndex = 19
            '
            'label72
            '
            Me.label72.AutoSize = True
            Me.label72.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label72.Location = New System.Drawing.Point(16, 42)
            Me.label72.Name = "label72"
            Me.label72.Size = New System.Drawing.Size(110, 13)
            Me.label72.TabIndex = 0
            Me.label72.Text = "Conversion Delay:"
            '
            'label29
            '
            Me.label29.AutoSize = True
            Me.label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label29.Location = New System.Drawing.Point(145, 16)
            Me.label29.Name = "label29"
            Me.label29.Size = New System.Drawing.Size(58, 13)
            Me.label29.TabIndex = 18
            Me.label29.Text = "Username:"
            '
            'groupBoxCommonSettings
            '
            Me.groupBoxCommonSettings.AutoSize = True
            Me.groupBoxCommonSettings.BackColor = System.Drawing.Color.White
            Me.groupBoxCommonSettings.Controls.Add(Me.pnlWebPageSize)
            Me.groupBoxCommonSettings.Controls.Add(Me.pnlWebPageSizeControl)
            Me.groupBoxCommonSettings.Dock = System.Windows.Forms.DockStyle.Top
            Me.groupBoxCommonSettings.Location = New System.Drawing.Point(0, 0)
            Me.groupBoxCommonSettings.Name = "groupBoxCommonSettings"
            Me.groupBoxCommonSettings.Size = New System.Drawing.Size(703, 111)
            Me.groupBoxCommonSettings.TabIndex = 0
            Me.groupBoxCommonSettings.TabStop = False
            '
            'pnlWebPageSize
            '
            Me.pnlWebPageSize.Controls.Add(Me.textBoxWebPageHeight)
            Me.pnlWebPageSize.Controls.Add(Me.textBoxWebPageWidth)
            Me.pnlWebPageSize.Controls.Add(Me.label3)
            Me.pnlWebPageSize.Controls.Add(Me.label1)
            Me.pnlWebPageSize.Controls.Add(Me.label2)
            Me.pnlWebPageSize.Controls.Add(Me.lblPageWidth)
            Me.pnlWebPageSize.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlWebPageSize.Location = New System.Drawing.Point(3, 40)
            Me.pnlWebPageSize.Name = "pnlWebPageSize"
            Me.pnlWebPageSize.Size = New System.Drawing.Size(697, 68)
            Me.pnlWebPageSize.TabIndex = 7
            '
            'textBoxWebPageHeight
            '
            Me.textBoxWebPageHeight.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxWebPageHeight.Location = New System.Drawing.Point(153, 38)
            Me.textBoxWebPageHeight.Name = "textBoxWebPageHeight"
            Me.textBoxWebPageHeight.Size = New System.Drawing.Size(104, 20)
            Me.textBoxWebPageHeight.TabIndex = 1
            Me.textBoxWebPageHeight.Text = "0"
            '
            'textBoxWebPageWidth
            '
            Me.textBoxWebPageWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxWebPageWidth.Location = New System.Drawing.Point(153, 10)
            Me.textBoxWebPageWidth.Name = "textBoxWebPageWidth"
            Me.textBoxWebPageWidth.Size = New System.Drawing.Size(104, 20)
            Me.textBoxWebPageWidth.TabIndex = 1
            Me.textBoxWebPageWidth.Text = "1024"
            '
            'label3
            '
            Me.label3.AutoSize = True
            Me.label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label3.Location = New System.Drawing.Point(261, 41)
            Me.label3.Name = "label3"
            Me.label3.Size = New System.Drawing.Size(18, 13)
            Me.label3.TabIndex = 0
            Me.label3.Text = "px"
            '
            'label1
            '
            Me.label1.AutoSize = True
            Me.label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label1.Location = New System.Drawing.Point(261, 13)
            Me.label1.Name = "label1"
            Me.label1.Size = New System.Drawing.Size(18, 13)
            Me.label1.TabIndex = 0
            Me.label1.Text = "px"
            '
            'label2
            '
            Me.label2.AutoSize = True
            Me.label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.label2.Location = New System.Drawing.Point(28, 41)
            Me.label2.Name = "label2"
            Me.label2.Size = New System.Drawing.Size(106, 13)
            Me.label2.TabIndex = 0
            Me.label2.Text = "HTML viewer height:"
            '
            'lblPageWidth
            '
            Me.lblPageWidth.AutoSize = True
            Me.lblPageWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lblPageWidth.Location = New System.Drawing.Point(28, 13)
            Me.lblPageWidth.Name = "lblPageWidth"
            Me.lblPageWidth.Size = New System.Drawing.Size(102, 13)
            Me.lblPageWidth.TabIndex = 0
            Me.lblPageWidth.Text = "HTML viewer width:"
            '
            'pnlWebPageSizeControl
            '
            Me.pnlWebPageSizeControl.Controls.Add(Me.lblWebPageSize)
            Me.pnlWebPageSizeControl.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlWebPageSizeControl.Location = New System.Drawing.Point(3, 16)
            Me.pnlWebPageSizeControl.Name = "pnlWebPageSizeControl"
            Me.pnlWebPageSizeControl.Size = New System.Drawing.Size(697, 24)
            Me.pnlWebPageSizeControl.TabIndex = 6
            '
            'lblWebPageSize
            '
            Me.lblWebPageSize.AutoSize = True
            Me.lblWebPageSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.lblWebPageSize.Location = New System.Drawing.Point(12, 7)
            Me.lblWebPageSize.Name = "lblWebPageSize"
            Me.lblWebPageSize.Size = New System.Drawing.Size(106, 13)
            Me.lblWebPageSize.TabIndex = 3
            Me.lblWebPageSize.Text = "Html Viewer Size:"
            '
            'pnlControlPanel
            '
            Me.pnlControlPanel.Controls.Add(Me.groupBox1)
            Me.pnlControlPanel.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlControlPanel.Location = New System.Drawing.Point(0, 0)
            Me.pnlControlPanel.Name = "pnlControlPanel"
            Me.pnlControlPanel.Size = New System.Drawing.Size(703, 129)
            Me.pnlControlPanel.TabIndex = 0
            '
            'groupBox1
            '
            Me.groupBox1.BackColor = System.Drawing.Color.White
            Me.groupBox1.Controls.Add(Me.cbEmbedFonts)
            Me.groupBox1.Controls.Add(Me.cbJpegCompression)
            Me.groupBox1.Controls.Add(Me.cbAutoSizePdfPage)
            Me.groupBox1.Controls.Add(Me.cbFitWidth)
            Me.groupBox1.Controls.Add(Me.cbBookmarks)
            Me.groupBox1.Controls.Add(Me.cbScriptsEnabled)
            Me.groupBox1.Controls.Add(Me.cbLiveLinks)
            Me.groupBox1.Controls.Add(Me.lnkBtnSettings)
            Me.groupBox1.Controls.Add(Me.radioConvertToImage)
            Me.groupBox1.Controls.Add(Me.radioButtonConvertToPdf)
            Me.groupBox1.Controls.Add(Me.textBoxWebPageURL)
            Me.groupBox1.Controls.Add(Me.lblEnterURL)
            Me.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.groupBox1.Location = New System.Drawing.Point(0, 0)
            Me.groupBox1.Name = "groupBox1"
            Me.groupBox1.Size = New System.Drawing.Size(703, 129)
            Me.groupBox1.TabIndex = 0
            Me.groupBox1.TabStop = False
            '
            'cbEmbedFonts
            '
            Me.cbEmbedFonts.AutoSize = True
            Me.cbEmbedFonts.BackColor = System.Drawing.Color.White
            Me.cbEmbedFonts.Checked = True
            Me.cbEmbedFonts.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbEmbedFonts.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbEmbedFonts.Location = New System.Drawing.Point(184, 103)
            Me.cbEmbedFonts.Name = "cbEmbedFonts"
            Me.cbEmbedFonts.Size = New System.Drawing.Size(85, 17)
            Me.cbEmbedFonts.TabIndex = 12
            Me.cbEmbedFonts.Text = "Embed fonts"
            Me.cbEmbedFonts.UseVisualStyleBackColor = False
            '
            'cbJpegCompression
            '
            Me.cbJpegCompression.AutoSize = True
            Me.cbJpegCompression.Checked = True
            Me.cbJpegCompression.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbJpegCompression.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbJpegCompression.Location = New System.Drawing.Point(544, 76)
            Me.cbJpegCompression.Name = "cbJpegCompression"
            Me.cbJpegCompression.Size = New System.Drawing.Size(116, 17)
            Me.cbJpegCompression.TabIndex = 12
            Me.cbJpegCompression.Text = "JPEG Compression"
            Me.cbJpegCompression.UseVisualStyleBackColor = True
            '
            'cbAutoSizePdfPage
            '
            Me.cbAutoSizePdfPage.AutoSize = True
            Me.cbAutoSizePdfPage.Checked = True
            Me.cbAutoSizePdfPage.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbAutoSizePdfPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbAutoSizePdfPage.Location = New System.Drawing.Point(416, 101)
            Me.cbAutoSizePdfPage.Name = "cbAutoSizePdfPage"
            Me.cbAutoSizePdfPage.Size = New System.Drawing.Size(123, 17)
            Me.cbAutoSizePdfPage.TabIndex = 12
            Me.cbAutoSizePdfPage.Text = "Auto Size PDF Page"
            Me.cbAutoSizePdfPage.UseVisualStyleBackColor = True
            '
            'cbFitWidth
            '
            Me.cbFitWidth.AutoSize = True
            Me.cbFitWidth.Checked = True
            Me.cbFitWidth.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbFitWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbFitWidth.Location = New System.Drawing.Point(294, 101)
            Me.cbFitWidth.Name = "cbFitWidth"
            Me.cbFitWidth.Size = New System.Drawing.Size(68, 17)
            Me.cbFitWidth.TabIndex = 12
            Me.cbFitWidth.Text = "Fit Width"
            Me.cbFitWidth.UseVisualStyleBackColor = True
            '
            'cbBookmarks
            '
            Me.cbBookmarks.AutoSize = True
            Me.cbBookmarks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbBookmarks.Location = New System.Drawing.Point(294, 76)
            Me.cbBookmarks.Name = "cbBookmarks"
            Me.cbBookmarks.Size = New System.Drawing.Size(79, 17)
            Me.cbBookmarks.TabIndex = 11
            Me.cbBookmarks.Text = "Bookmarks"
            Me.cbBookmarks.UseVisualStyleBackColor = True
            '
            'cbScriptsEnabled
            '
            Me.cbScriptsEnabled.AutoSize = True
            Me.cbScriptsEnabled.Checked = True
            Me.cbScriptsEnabled.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbScriptsEnabled.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbScriptsEnabled.Location = New System.Drawing.Point(416, 76)
            Me.cbScriptsEnabled.Name = "cbScriptsEnabled"
            Me.cbScriptsEnabled.Size = New System.Drawing.Size(76, 17)
            Me.cbScriptsEnabled.TabIndex = 10
            Me.cbScriptsEnabled.Text = "JavaScript"
            Me.cbScriptsEnabled.UseVisualStyleBackColor = True
            '
            'cbLiveLinks
            '
            Me.cbLiveLinks.AutoSize = True
            Me.cbLiveLinks.Checked = True
            Me.cbLiveLinks.CheckState = System.Windows.Forms.CheckState.Checked
            Me.cbLiveLinks.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.cbLiveLinks.Location = New System.Drawing.Point(184, 78)
            Me.cbLiveLinks.Name = "cbLiveLinks"
            Me.cbLiveLinks.Size = New System.Drawing.Size(70, 17)
            Me.cbLiveLinks.TabIndex = 10
            Me.cbLiveLinks.Text = "Live links"
            Me.cbLiveLinks.UseVisualStyleBackColor = True
            '
            'lnkBtnSettings
            '
            Me.lnkBtnSettings.AutoSize = True
            Me.lnkBtnSettings.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.lnkBtnSettings.Location = New System.Drawing.Point(12, 80)
            Me.lnkBtnSettings.Name = "lnkBtnSettings"
            Me.lnkBtnSettings.Size = New System.Drawing.Size(136, 13)
            Me.lnkBtnSettings.TabIndex = 8
            Me.lnkBtnSettings.TabStop = True
            Me.lnkBtnSettings.Text = "More Converter Settings >>"
            '
            'radioConvertToImage
            '
            Me.radioConvertToImage.AutoSize = True
            Me.radioConvertToImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.radioConvertToImage.Location = New System.Drawing.Point(140, 48)
            Me.radioConvertToImage.Name = "radioConvertToImage"
            Me.radioConvertToImage.Size = New System.Drawing.Size(105, 17)
            Me.radioConvertToImage.TabIndex = 7
            Me.radioConvertToImage.Text = "Convert to image"
            Me.radioConvertToImage.UseVisualStyleBackColor = True
            '
            'radioButtonConvertToPdf
            '
            Me.radioButtonConvertToPdf.AutoSize = True
            Me.radioButtonConvertToPdf.Checked = True
            Me.radioButtonConvertToPdf.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.radioButtonConvertToPdf.Location = New System.Drawing.Point(15, 48)
            Me.radioButtonConvertToPdf.Name = "radioButtonConvertToPdf"
            Me.radioButtonConvertToPdf.Size = New System.Drawing.Size(98, 17)
            Me.radioButtonConvertToPdf.TabIndex = 6
            Me.radioButtonConvertToPdf.TabStop = True
            Me.radioButtonConvertToPdf.Text = "Convert to PDF"
            Me.radioButtonConvertToPdf.UseVisualStyleBackColor = True
            '
            'textBoxWebPageURL
            '
            Me.textBoxWebPageURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.textBoxWebPageURL.Location = New System.Drawing.Point(238, 13)
            Me.textBoxWebPageURL.Name = "textBoxWebPageURL"
            Me.textBoxWebPageURL.Size = New System.Drawing.Size(447, 20)
            Me.textBoxWebPageURL.TabIndex = 5
            Me.textBoxWebPageURL.Text = "http://www.evopdf.com"
            '
            'lblEnterURL
            '
            Me.lblEnterURL.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, CType(0, Byte))
            Me.lblEnterURL.Location = New System.Drawing.Point(15, 16)
            Me.lblEnterURL.Name = "lblEnterURL"
            Me.lblEnterURL.Size = New System.Drawing.Size(217, 29)
            Me.lblEnterURL.TabIndex = 4
            Me.lblEnterURL.Text = "Enter Web Page URL or File Path:"
            '
            'errorProvider
            '
            Me.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
            Me.errorProvider.ContainerControl = Me
            '
            'pnlConvertCommand
            '
            Me.pnlConvertCommand.BackColor = System.Drawing.Color.White
            Me.pnlConvertCommand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.pnlConvertCommand.Controls.Add(Me.btnCancel)
            Me.pnlConvertCommand.Controls.Add(Me.btnConvert)
            Me.pnlConvertCommand.Dock = System.Windows.Forms.DockStyle.Top
            Me.pnlConvertCommand.Location = New System.Drawing.Point(0, 656)
            Me.pnlConvertCommand.Name = "pnlConvertCommand"
            Me.pnlConvertCommand.Size = New System.Drawing.Size(724, 55)
            Me.pnlConvertCommand.TabIndex = 3
            '
            'btnCancel
            '
            Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnCancel.Location = New System.Drawing.Point(708, 40)
            Me.btnCancel.Name = "btnCancel"
            Me.btnCancel.Size = New System.Drawing.Size(0, 0)
            Me.btnCancel.TabIndex = 2
            Me.btnCancel.TabStop = False
            Me.btnCancel.UseVisualStyleBackColor = True
            '
            'btnConvert
            '
            Me.btnConvert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.btnConvert.Location = New System.Drawing.Point(293, 15)
            Me.btnConvert.Name = "btnConvert"
            Me.btnConvert.Size = New System.Drawing.Size(118, 27)
            Me.btnConvert.TabIndex = 0
            Me.btnConvert.Text = "Convert"
            Me.btnConvert.UseVisualStyleBackColor = True
            '
            'MainFeaturesForm
            '
            Me.AutoSize = True
            Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
            Me.CancelButton = Me.btnCancel
            Me.ClientSize = New System.Drawing.Size(724, 715)
            Me.Controls.Add(Me.pnlConvertCommand)
            Me.Controls.Add(Me.pnlContent)
            Me.Controls.Add(Me.pnlHeader)
            Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, CType(238, Byte))
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MaximizeBox = False
            Me.MinimumSize = New System.Drawing.Size(730, 33)
            Me.Name = "MainFeaturesForm"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "EVO HTML to PDF Converter Main Features Demo"
            Me.pnlHeader.ResumeLayout(False)
            Me.pnlHeader.PerformLayout()
            Me.pnlContent.ResumeLayout(False)
            Me.pnlContent.PerformLayout()
            Me.pnlSettingsPanel.ResumeLayout(False)
            Me.pnlSettingsPanel.PerformLayout()
            Me.pnlPDFSettings.ResumeLayout(False)
            Me.pnlFooterOptions.ResumeLayout(False)
            Me.groupBoxPDFFooterOptions.ResumeLayout(False)
            Me.groupBoxPDFFooterOptions.PerformLayout()
            Me.pnlHeaderOptions.ResumeLayout(False)
            Me.groupBoxPDFHeaderOptions.ResumeLayout(False)
            Me.groupBoxPDFHeaderOptions.PerformLayout()
            Me.pnlDocumentOptions.ResumeLayout(False)
            Me.groupBoxPDFDocumentOptions.ResumeLayout(False)
            Me.groupBoxPDFDocumentOptions.PerformLayout()
            Me.pnlImgeOptions.ResumeLayout(False)
            Me.pnlImgeOptions.PerformLayout()
            Me.pnlCommonSettings.ResumeLayout(False)
            Me.pnlCommonSettings.PerformLayout()
            Me.pnlWebPageLoaded.ResumeLayout(False)
            Me.groupBox2.ResumeLayout(False)
            Me.groupBox2.PerformLayout()
            Me.groupBoxCommonSettings.ResumeLayout(False)
            Me.pnlWebPageSize.ResumeLayout(False)
            Me.pnlWebPageSize.PerformLayout()
            Me.pnlWebPageSizeControl.ResumeLayout(False)
            Me.pnlWebPageSizeControl.PerformLayout()
            Me.pnlControlPanel.ResumeLayout(False)
            Me.groupBox1.ResumeLayout(False)
            Me.groupBox1.PerformLayout()
            CType(Me.errorProvider, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlConvertCommand.ResumeLayout(False)
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

		#End Region

		Private pnlHeader As Panel
		Private pnlContent As Panel
		Private pnlControlPanel As Panel
		Private pnlSettingsPanel As Panel
		Private pnlPDFSettings As Panel
		Private pnlImgeOptions As Panel
		Private pnlCommonSettings As Panel
		Private ddlImageFormat As ComboBox
		Private label4 As Label
		Private pnlFooterOptions As Panel
		Private pnlHeaderOptions As Panel
		Private pnlDocumentOptions As Panel
		Private label26 As Label
		Private label27 As Label
		Private groupBoxPDFDocumentOptions As GroupBox
		Private label13 As Label
		Private label17 As Label
		Private label15 As Label
		Private label10 As Label
		Private textBoxRightMargin As TextBox
		Private textBoxTopMargin As TextBox
		Private textBoxBottomMargin As TextBox
		Private textBoxLeftMargin As TextBox
		Private label16 As Label
		Private WithEvents cbShowHeader As CheckBox
		Private WithEvents cbShowFooter As CheckBox
		Private label14 As Label
		Private label12 As Label
		Private label11 As Label
		Private ddlCompression As ComboBox
		Private ddlPageFormat As ComboBox
		Private label9 As Label
		Private label8 As Label
		Private label21 As Label
		Private label7 As Label
		Private label5 As Label
		Private groupBox1 As GroupBox
		Private WithEvents lnkBtnSettings As LinkLabel
		Private WithEvents radioConvertToImage As RadioButton
		Private textBoxWebPageURL As TextBox
		Private lblEnterURL As Label
		Private groupBoxCommonSettings As GroupBox
		Private pnlWebPageSize As Panel
		Private textBoxWebPageHeight As TextBox
		Private textBoxWebPageWidth As TextBox
		Private label3 As Label
		Private label1 As Label
		Private label2 As Label
		Private lblPageWidth As Label
		Private pnlWebPageSizeControl As Panel
		Private lblWebPageSize As Label
		Private errorProvider As ErrorProvider
		Private pnlConvertCommand As Panel
		Private WithEvents btnConvert As Button
		Private WithEvents radioButtonConvertToPdf As RadioButton
		Private pnlWebPageLoaded As Panel
		Private groupBox2 As GroupBox
		Private cbAvoidImageBreak As CheckBox
		Private ddlPageOrientation As ComboBox
		Private label28 As Label
		Private cbLiveLinks As CheckBox
        Private label30 As Label
		Private textBoxPassword As TextBox
		Private label59 As Label
		Private textBoxUsername As TextBox
		Private label29 As Label
		Private cbScriptsEnabled As CheckBox
		Private cbFitWidth As CheckBox
		Private cbBookmarks As CheckBox
		Private cbEmbedFonts As CheckBox
		Private cbJpegCompression As CheckBox
		Private ddlPdfSubset As ComboBox
		Private label71 As Label
		Private textBoxConversionDelay As TextBox
		Private label73 As Label
		Private label72 As Label
		Private cbAutoSizePdfPage As CheckBox
		Private label74 As Label
		Private textBoxNavigationTimeout As TextBox
		Private label75 As Label
		Private groupBoxPDFHeaderOptions As GroupBox
		Private cbShowHeaderOnEvenPages As CheckBox
		Private cbShowHeaderOnFirstPage As CheckBox
		Private cbShowHeaderOnOddPages As CheckBox
		Private label18 As Label
		Private label36 As Label
		Private textBoxHeaderHeight As TextBox
		Private ddlHeaderLineColor As ComboBox
		Private label22 As Label
		Private label35 As Label
		Private cbDrawHeaderLine As CheckBox
		Private groupBoxPDFFooterOptions As GroupBox
		Private cbShowFooterOnFirstPage As CheckBox
		Private cbShowFooterOnEvenPages As CheckBox
		Private cbShowFooterOnOddPages As CheckBox
		Private label19 As Label
		Private checkBox1 As CheckBox
		Private cbDrawFooterLine As CheckBox
		Private label23 As Label
		Private ddlFooterLineColor As ComboBox
		Private label51 As Label
		Private label49 As Label
		Private textBoxFooterHeight As TextBox
		Private btnCancel As Button
	End Class
End Namespace

