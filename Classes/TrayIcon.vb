Option Strict On
Option Explicit On

Public Class TrayIcon
    Private _XMLData As New Tools

    Private Sub uiExitToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles uiExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub uiRunToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles uiRunToolStripMenuItem.Click
        Dim lRunForm As New RunCommand

        lRunForm.Location = CalculatePosition(lRunForm)

        lRunForm.Show()
    End Sub

    Private Sub uiQuickRunToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles uiQuickRunToolStripMenuItem.Click
        Dim lRunForm As New RunTool

        lRunForm.Location = CalculatePosition(lRunForm)

        lRunForm.Show()
    End Sub

    Private Sub uiNotifyIcon_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles uiNotifyIcon.MouseDoubleClick
        If e.Button = MouseButtons.Left Then
            Me.uiQuickRunToolStripMenuItem.PerformClick()
        End If
    End Sub

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.uiAboutToolStripMenuItem.Enabled = False
    End Sub

    Private Sub uiOptionsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles uiOptionsToolStripMenuItem.Click
        Dim lOptions As New Options
        Dim lSettings As New StringDataBag

        lSettings.Value("AutoStart") = Main.AutoStart.ToString

        lOptions.Settings = lSettings
        lOptions.Location = CalculatePosition(lOptions)
        If lOptions.ShowDialog = DialogResult.OK Then
            Main.AutoStart = CBool(lSettings.Value("AutoStart"))
        End If
    End Sub

    Private Shared Function CalculatePosition(ByVal form As Form) As Point
        Return (New System.Drawing.Point(My.Computer.Screen.WorkingArea.Right - form.Width, My.Computer.Screen.WorkingArea.Bottom - form.Height))
    End Function

    Private Sub OpenDataFile()
        _XMLData.ReadXml(IO.Path.Combine(My.Application.Info.DirectoryPath, "Tools.xml"), XmlReadMode.IgnoreSchema)
    End Sub

    Private Sub CloseDataFile()
        _XMLData.WriteXml(IO.Path.Combine(My.Application.Info.DirectoryPath, "Tools.xml"))
        _XMLData.Dispose()
    End Sub

    Private Sub AddTool(ByVal name As String, ByVal path As String, ByVal icon As String, ByVal shortName As String)
        _XMLData.QuickRun.AddQuickRunRow(name, path, icon, shortName)
    End Sub
End Class