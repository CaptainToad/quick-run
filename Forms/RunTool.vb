Option Strict On
Option Explicit On

Public Class RunTool
    Private Const XML_DATA_FILE As String = "Tools.xml"
    Private ReadOnly _Tools As New Tools()
    Private _ToolsAutocomplete As CustomAutoCompleteCollection

    Private Sub uiButtonOK_Click(ByVal sender As Object, ByVal e As EventArgs) Handles uiButtonOK.Click
        Dim lProcessInfo As New ProcessStartInfo
        Dim lPath As String = _ToolsAutocomplete.GetValue(uiTextBoxCommand.Text, "path")

        If String.IsNullOrEmpty(lPath) Then
            uiErrorProvider.SetError(uiTextBoxCommand, "That QuickTool ID does not exist.")
            uiTextBoxCommand.Text = String.Empty
        End If

        With lProcessInfo
            .FileName = lPath
            .UseShellExecute = True
            .ErrorDialog = True
            .ErrorDialogParentHandle = Handle
        End With

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

    Private Sub QuickRun_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
        _Tools.ReadXml(XMLDataFilePath, XmlReadMode.IgnoreSchema)

        _ToolsAutocomplete = New CustomAutoCompleteCollection(_Tools.QuickRun.CreateDataReader, "shortname")
        uiTextBoxCommand.AutoCompleteCustomSource = _ToolsAutocomplete
    End Sub

    Private Shared Function XMLDataFilePath() As String
        Dim lReturn As String = IO.Path.Combine(My.Application.Info.DirectoryPath, XML_DATA_FILE)

        Return lReturn
    End Function
End Class