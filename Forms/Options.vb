Option Strict On
Option Explicit On

Public Class Options

    Private Sub uiButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles uiButtonOK.Click
        DialogResult = System.Windows.Forms.DialogResult.OK
        Close()
    End Sub

    Private Sub uiButtonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles uiButtonCancel.Click
        DialogResult = System.Windows.Forms.DialogResult.Cancel
        Close()
    End Sub

    Private Sub uiCheckBoxAutoStart_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs) Handles uiCheckBoxAutoStart.CheckedChanged
        Settings.Item("AutoStart") = uiCheckBoxAutoStart.Checked.ToString
    End Sub

    Public Property Settings() As Dictionary(Of String, String)

    Private Sub Options_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        uiCheckBoxAutoStart.Checked = CBool(Settings.Item("AutoStart"))
    End Sub
End Class