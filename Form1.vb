
Public Class Form1

    Dim configFileName As String = "config.xml"
    Dim configuration As New Config()
    Dim reportFileName As String = String.Empty
    Dim isPreparedReport As Boolean = False
    Dim preview As Boolean = False
    Public Sub LoadForm()
        cbDensity.SelectedIndex = 1
        For Each printer As String In PrinterSettings.InstalledPrinters
            cbPrinters.Items.Add(printer)
        Next
        If cbPrinters.Items.Count > 0 Then
            btnPrint.Enabled = True
            cbPrinters.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnSelectReport_Click(sender As Object, e As EventArgs) Handles btnSelectReport.Click

        Dim openDialog As New OpenFileDialog()

        openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath)
        openDialog.Filter = "Report File (*.frx)|*.frx|Prepared Report File (*.fpx)|*.fpx;"
        If openDialog.ShowDialog = DialogResult.OK Then
            reportFileName = openDialog.FileName
            lblReportName.Text = Path.GetFileName(reportFileName)
            isPreparedReport = Path.GetExtension(reportFileName) = ".fpx"

            btnDesignReport.Enabled = Not isPreparedReport
            btnShowReport.Enabled = True
        End If
    End Sub

    Private Sub btnDesignReport_Click(sender As Object, e As EventArgs) Handles btnDesignReport.Click
        If File.Exists(reportFileName) And Not isPreparedReport Then
            Dim report As New Report
            report = New Report()
            report.Load(reportFileName)
            report.Design()
        End If

    End Sub

    Private Sub btnShowReport_Click(sender As Object, e As EventArgs) Handles btnShowReport.Click
        If File.Exists(reportFileName) Then
            If (isPreparedReport) Then
                Dim report As New Report
                report = New Report()
                report.LoadPrepared(reportFileName)
                report.ShowPrepared()
            Else
                Dim report As New Report
                report = New Report()
                report.Load(reportFileName)
                report.Show()
            End If
        End If
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        Dim openDialog As New OpenFileDialog()
        openDialog.InitialDirectory = Path.GetDirectoryName(Application.ExecutablePath)
        openDialog.Filter = "ZPL File (*.zpl)|*.zpl|Text File (*.txt)|*.txt;"
        If openDialog.ShowDialog() = DialogResult.OK Then
            If File.Exists(openDialog.FileName) Then
                textEditor.Text = File.ReadAllText(openDialog.FileName)
            End If
        End If
    End Sub

    Private Sub btnShowZPL_Click(sender As Object, e As EventArgs) Handles btnShowZPL.Click
        preview = True
        btnPrint_Click(sender, e)
        preview = False
        TabControl1.SelectedIndex = 1

    End Sub
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        SaveConfig()
        If TabControl1.SelectedIndex = 0 Then
            If reportFileName = String.Empty Then
                btnSelectReport_Click(sender, e)
            End If
            If reportFileName IsNot String.Empty Then
                Dim report As New Report()
                Dim zplExport As New ZplExport()
                If isPreparedReport Then
                    report.LoadPrepared(reportFileName)
                Else
                    report.Load(reportFileName)
                    report.Prepare()
                End If
                Select Case cbDensity.SelectedIndex
                    Case 0
                        zplExport.Density = ZplExport.ZplDensity.d6_dpmm_152_dpi
                    Case 1
                        zplExport.Density = ZplExport.ZplDensity.d8_dpmm_203_dpi
                    Case 2
                        zplExport.Density = ZplExport.ZplDensity.d12_dpmm_300_dpi
                    Case 3
                        zplExport.Density = ZplExport.ZplDensity.d24_dpmm_600_dpi
                End Select

                zplExport.PrinterInit = tbPrinterInit.Text
                zplExport.PrinterFinish = tbPrinterFinish.Text
                zplExport.CodePage = tbCodePage.Text
                zplExport.PageInit = tbPageInit.Text
                zplExport.FontScale = nudFontScale.Value
                zplExport.PrinterFont = tbPrinterFont.Text
                zplExport.PrintAsBitmap = cbPrintAsBitmap.Checked

                Dim stream As New MemoryStream()
                report.Export(zplExport, stream)
                stream.Position = 0
                Dim buff(stream.Length) As Byte
                stream.Read(buff, 0, buff.Length)
                textEditor.Text = Encoding.UTF8.GetString(buff)
                If Not preview Then
                    stream.Position = 0
                    TextExportPrint.PrintStream(cbPrinters.Text, "FastReport", 1, stream)
                End If
            End If
        Else
            Dim stream As New MemoryStream()
            Dim utfTextBuff As Byte() = Encoding.UTF8.GetBytes(textEditor.Text)
            stream.Write(utfTextBuff, 0, utfTextBuff.Length)
            stream.Position = 0
            TextExportPrint.PrintStream(cbPrinters.Text, "FastReport", 1, stream)
        End If
    End Sub

    Private Sub SaveConfig()
        configuration.PrinterInit = tbPrinterInit.Text
        configuration.PrinterFinish = tbPrinterFinish.Text
        configuration.CodePage = tbCodePage.Text
        configuration.PageInit = tbPageInit.Text
        configuration.FontScale = nudFontScale.Value
        configuration.PrinterFont = tbPrinterFont.Text
        configuration.PrintAsBitmap = cbPrintAsBitmap.Checked

        Dim serializer As New XmlSerializer(GetType(Config))
        Using file As New FileStream(configFileName, FileMode.Create)
            serializer.Serialize(file, configuration)
        End Using
    End Sub

    Private Sub LoadConfig()
        If File.Exists(configFileName) Then
            Dim serializer As New XmlSerializer(GetType(Config))
            Using file As New FileStream(configFileName, FileMode.Open)
                configuration = TryCast(serializer.Deserialize(file), Config)
            End Using
            tbPrinterInit.Text = configuration.PrinterInit
            tbPrinterFinish.Text = configuration.PrinterFinish
            tbCodePage.Text = configuration.CodePage
            tbPageInit.Text = configuration.PageInit
            nudFontScale.Value = configuration.FontScale
            tbPrinterFont.Text = configuration.PrinterFont
            cbPrintAsBitmap.Checked = configuration.PrintAsBitmap
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadForm()
        LoadConfig()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        SaveConfig()
    End Sub
End Class
