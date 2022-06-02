<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblReportName = New System.Windows.Forms.Label()
        Me.groupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbPrinterFont = New System.Windows.Forms.TextBox()
        Me.cbPrintAsBitmap = New System.Windows.Forms.CheckBox()
        Me.nudFontScale = New System.Windows.Forms.NumericUpDown()
        Me.tbPageInit = New System.Windows.Forms.TextBox()
        Me.tbPrinterFinish = New System.Windows.Forms.TextBox()
        Me.tbCodePage = New System.Windows.Forms.TextBox()
        Me.tbPrinterInit = New System.Windows.Forms.TextBox()
        Me.cbDensity = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnShowReport = New System.Windows.Forms.Button()
        Me.btnDesignReport = New System.Windows.Forms.Button()
        Me.btnSelectReport = New System.Windows.Forms.Button()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.textEditor = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbPrinters = New System.Windows.Forms.ComboBox()
        Me.btnShowZPL = New System.Windows.Forms.Button()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.groupBox1.SuspendLayout()
        CType(Me.nudFontScale, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(18, 18)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(879, 700)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TabPage1.Controls.Add(Me.lblReportName)
        Me.TabPage1.Controls.Add(Me.groupBox1)
        Me.TabPage1.Controls.Add(Me.btnShowReport)
        Me.TabPage1.Controls.Add(Me.btnDesignReport)
        Me.TabPage1.Controls.Add(Me.btnSelectReport)
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage1.Size = New System.Drawing.Size(871, 667)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Reports"
        '
        'lblReportName
        '
        Me.lblReportName.AutoSize = True
        Me.lblReportName.Location = New System.Drawing.Point(248, 55)
        Me.lblReportName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReportName.Name = "lblReportName"
        Me.lblReportName.Size = New System.Drawing.Size(0, 20)
        Me.lblReportName.TabIndex = 12
        '
        'groupBox1
        '
        Me.groupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.groupBox1.Controls.Add(Me.tbPrinterFont)
        Me.groupBox1.Controls.Add(Me.cbPrintAsBitmap)
        Me.groupBox1.Controls.Add(Me.nudFontScale)
        Me.groupBox1.Controls.Add(Me.tbPageInit)
        Me.groupBox1.Controls.Add(Me.tbPrinterFinish)
        Me.groupBox1.Controls.Add(Me.tbCodePage)
        Me.groupBox1.Controls.Add(Me.tbPrinterInit)
        Me.groupBox1.Controls.Add(Me.cbDensity)
        Me.groupBox1.Controls.Add(Me.Label8)
        Me.groupBox1.Controls.Add(Me.Label7)
        Me.groupBox1.Controls.Add(Me.Label6)
        Me.groupBox1.Controls.Add(Me.Label5)
        Me.groupBox1.Controls.Add(Me.Label4)
        Me.groupBox1.Controls.Add(Me.Label3)
        Me.groupBox1.Controls.Add(Me.Label2)
        Me.groupBox1.Location = New System.Drawing.Point(54, 218)
        Me.groupBox1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBox1.Name = "groupBox1"
        Me.groupBox1.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.groupBox1.Size = New System.Drawing.Size(771, 394)
        Me.groupBox1.TabIndex = 11
        Me.groupBox1.TabStop = False
        Me.groupBox1.Text = "Zebra Printer Settings"
        '
        'tbPrinterFont
        '
        Me.tbPrinterFont.Location = New System.Drawing.Point(242, 309)
        Me.tbPrinterFont.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPrinterFont.Name = "tbPrinterFont"
        Me.tbPrinterFont.Size = New System.Drawing.Size(472, 26)
        Me.tbPrinterFont.TabIndex = 14
        '
        'cbPrintAsBitmap
        '
        Me.cbPrintAsBitmap.AutoSize = True
        Me.cbPrintAsBitmap.Checked = True
        Me.cbPrintAsBitmap.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPrintAsBitmap.Location = New System.Drawing.Point(242, 351)
        Me.cbPrintAsBitmap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbPrintAsBitmap.Name = "cbPrintAsBitmap"
        Me.cbPrintAsBitmap.Size = New System.Drawing.Size(144, 24)
        Me.cbPrintAsBitmap.TabIndex = 14
        Me.cbPrintAsBitmap.Text = "Print As Bitmap"
        Me.cbPrintAsBitmap.UseVisualStyleBackColor = True
        '
        'nudFontScale
        '
        Me.nudFontScale.DecimalPlaces = 2
        Me.nudFontScale.Increment = New Decimal(New Integer() {1, 0, 0, 131072})
        Me.nudFontScale.Location = New System.Drawing.Point(242, 269)
        Me.nudFontScale.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.nudFontScale.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.nudFontScale.Name = "nudFontScale"
        Me.nudFontScale.Size = New System.Drawing.Size(180, 26)
        Me.nudFontScale.TabIndex = 12
        Me.nudFontScale.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'tbPageInit
        '
        Me.tbPageInit.Location = New System.Drawing.Point(242, 229)
        Me.tbPageInit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPageInit.Name = "tbPageInit"
        Me.tbPageInit.Size = New System.Drawing.Size(472, 26)
        Me.tbPageInit.TabIndex = 11
        '
        'tbPrinterFinish
        '
        Me.tbPrinterFinish.Location = New System.Drawing.Point(242, 189)
        Me.tbPrinterFinish.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPrinterFinish.Name = "tbPrinterFinish"
        Me.tbPrinterFinish.Size = New System.Drawing.Size(472, 26)
        Me.tbPrinterFinish.TabIndex = 10
        '
        'tbCodePage
        '
        Me.tbCodePage.Location = New System.Drawing.Point(242, 149)
        Me.tbCodePage.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbCodePage.Name = "tbCodePage"
        Me.tbCodePage.Size = New System.Drawing.Size(472, 26)
        Me.tbCodePage.TabIndex = 9
        Me.tbCodePage.Text = "^CI28"
        '
        'tbPrinterInit
        '
        Me.tbPrinterInit.Location = New System.Drawing.Point(242, 109)
        Me.tbPrinterInit.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.tbPrinterInit.Name = "tbPrinterInit"
        Me.tbPrinterInit.Size = New System.Drawing.Size(472, 26)
        Me.tbPrinterInit.TabIndex = 8
        '
        'cbDensity
        '
        Me.cbDensity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbDensity.FormattingEnabled = True
        Me.cbDensity.Items.AddRange(New Object() {"6 dpmm(152 dpi)", "8 dpmm(203 dpi)", "12 dpmm(300 dpi)", "24 dpmm(600 dpi)"})
        Me.cbDensity.Location = New System.Drawing.Point(242, 68)
        Me.cbDensity.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbDensity.Name = "cbDensity"
        Me.cbDensity.Size = New System.Drawing.Size(200, 28)
        Me.cbDensity.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(56, 314)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 20)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Font"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 272)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 20)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Font Scale"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(56, 234)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Page Init"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(56, 194)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 20)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Printer Finish"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(56, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Code Page"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Printer Init"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(56, 68)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Density"
        '
        'btnShowReport
        '
        Me.btnShowReport.Enabled = False
        Me.btnShowReport.Location = New System.Drawing.Point(54, 131)
        Me.btnShowReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowReport.Name = "btnShowReport"
        Me.btnShowReport.Size = New System.Drawing.Size(184, 35)
        Me.btnShowReport.TabIndex = 11
        Me.btnShowReport.Text = "Show Report"
        Me.btnShowReport.UseVisualStyleBackColor = True
        '
        'btnDesignReport
        '
        Me.btnDesignReport.Enabled = False
        Me.btnDesignReport.Location = New System.Drawing.Point(54, 86)
        Me.btnDesignReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDesignReport.Name = "btnDesignReport"
        Me.btnDesignReport.Size = New System.Drawing.Size(184, 35)
        Me.btnDesignReport.TabIndex = 10
        Me.btnDesignReport.Text = "Design Report"
        Me.btnDesignReport.UseVisualStyleBackColor = True
        '
        'btnSelectReport
        '
        Me.btnSelectReport.Location = New System.Drawing.Point(54, 42)
        Me.btnSelectReport.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnSelectReport.Name = "btnSelectReport"
        Me.btnSelectReport.Size = New System.Drawing.Size(184, 35)
        Me.btnSelectReport.TabIndex = 8
        Me.btnSelectReport.Text = "Select Report"
        Me.btnSelectReport.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnLoad)
        Me.TabPage2.Controls.Add(Me.textEditor)
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TabPage2.Size = New System.Drawing.Size(871, 667)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ZPL text"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnLoad.Location = New System.Drawing.Point(644, 591)
        Me.btnLoad.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(170, 35)
        Me.btnLoad.TabIndex = 1
        Me.btnLoad.Text = "Load From File"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'textEditor
        '
        Me.textEditor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.textEditor.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.textEditor.Location = New System.Drawing.Point(4, 5)
        Me.textEditor.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.textEditor.Multiline = True
        Me.textEditor.Name = "textEditor"
        Me.textEditor.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.textEditor.Size = New System.Drawing.Size(863, 657)
        Me.textEditor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 763)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Select Printer"
        '
        'cbPrinters
        '
        Me.cbPrinters.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbPrinters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPrinters.FormattingEnabled = True
        Me.cbPrinters.Location = New System.Drawing.Point(132, 758)
        Me.cbPrinters.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbPrinters.Name = "cbPrinters"
        Me.cbPrinters.Size = New System.Drawing.Size(476, 28)
        Me.cbPrinters.TabIndex = 2
        '
        'btnShowZPL
        '
        Me.btnShowZPL.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnShowZPL.Location = New System.Drawing.Point(634, 746)
        Me.btnShowZPL.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnShowZPL.Name = "btnShowZPL"
        Me.btnShowZPL.Size = New System.Drawing.Size(123, 58)
        Me.btnShowZPL.TabIndex = 13
        Me.btnShowZPL.Text = "Show ZPL"
        Me.btnShowZPL.UseVisualStyleBackColor = True
        '
        'btnPrint
        '
        Me.btnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrint.Enabled = False
        Me.btnPrint.Location = New System.Drawing.Point(778, 746)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(112, 58)
        Me.btnPrint.TabIndex = 14
        Me.btnPrint.Text = "Print"
        Me.btnPrint.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 840)
        Me.Controls.Add(Me.btnPrint)
        Me.Controls.Add(Me.btnShowZPL)
        Me.Controls.Add(Me.cbPrinters)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MinimumSize = New System.Drawing.Size(928, 870)
        Me.Name = "Form1"
        Me.Text = "ZPL Printing Demo"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.groupBox1.ResumeLayout(False)
        Me.groupBox1.PerformLayout()
        CType(Me.nudFontScale, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnLoad As Button
    Private WithEvents textEditor As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents groupBox1 As GroupBox
    Private WithEvents cbPrintAsBitmap As CheckBox
    Friend WithEvents nudFontScale As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents btnShowReport As Button
    Private WithEvents btnDesignReport As Button
    Private WithEvents btnSelectReport As Button
    Friend WithEvents cbPrinters As ComboBox
    Private WithEvents btnShowZPL As Button
    Private WithEvents btnPrint As Button
    Private WithEvents tbPrinterFont As TextBox
    Private WithEvents tbPageInit As TextBox
    Private WithEvents tbPrinterFinish As TextBox
    Private WithEvents tbCodePage As TextBox
    Private WithEvents tbPrinterInit As TextBox
    Private WithEvents cbDensity As ComboBox
    Friend WithEvents lblReportName As Label
End Class
