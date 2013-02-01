Option Strict On
Option Explicit On

Public Class RunCommand
    Private Sub uiButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles uiButtonOK.Click
        Dim lProcessInfo As New ProcessStartInfo() With
            {
                .FileName = uiTextBoxCommand.Text,
                .UseShellExecute = True,
                .ErrorDialog = True,
                .ErrorDialogParentHandle = Handle
            }

        Try
            Process.Start(lProcessInfo)
            Close()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub uiButtonCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles uiButtonCancel.Click
        DialogResult = DialogResult.Cancel
        Close()
    End Sub

    Private Sub uiComboBoxCommand_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs) Handles uiTextBoxCommand.KeyUp
        Select Case e.KeyCode
            Case Keys.Enter, Keys.Return
                e.Handled = True
                e.SuppressKeyPress = True
                uiButtonOK.PerformClick()
        End Select
    End Sub

    Private Sub uiButtonBrowse_Click(ByVal sender As Object, ByVal e As EventArgs) Handles uiButtonBrowse.Click
        If uiOpenFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            uiTextBoxCommand.Text = uiOpenFileDialog.FileName
        End If
    End Sub
End Class