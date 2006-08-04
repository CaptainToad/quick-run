Option Strict On
Option Explicit On

Imports System.Windows.Forms

Public Class RunCommand
    Private Sub uiButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiButtonOK.Click
        Dim lProcessInfo As New ProcessStartInfo

        With lProcessInfo
            .FileName = Me.uiTextBoxCommand.Text
            .UseShellExecute = True
            .ErrorDialog = True
            .ErrorDialogParentHandle = Me.Handle
        End With

        Try
            Process.Start(lProcessInfo)
            Me.Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub uiButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiButtonCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub uiComboBoxCommand_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles uiTextBoxCommand.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Return
                e.Handled = True
                e.SuppressKeyPress = True
                Me.uiButtonOK.PerformClick()
        End Select
    End Sub

    Private Sub uiButtonBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiButtonBrowse.Click
        If Me.uiOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            Me.uiTextBoxCommand.Text = Me.uiOpenFileDialog.FileName
        End If
    End Sub
End Class