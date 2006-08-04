Option Strict On
Option Explicit On

Imports System.Windows.Forms

Public Class RunTool
    Private Const XML_DATA_FILE As String = "Tools.xml"
    Private _Tools As New Tools
    Private _ToolsAutocomplete As CustomAutoCompleteCollection

    Private Sub uiButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiButtonOK.Click
        Dim lProcessInfo As New ProcessStartInfo
        Dim lPath As String

        lPath = _ToolsAutocomplete.GetValue(Me.uiTextBoxCommand.Text, "path")

        If String.IsNullOrEmpty(lPath) Then
            Me.uiErrorProvider.SetError(Me.uiTextBoxCommand, "That QuickTool ID does not exist.")
            Me.uiTextBoxCommand.Text = String.Empty
        End If

        With lProcessInfo
            .FileName = lPath
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

    Private Sub QuickRun_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _Tools.ReadXml(XMLDataFilePath, XmlReadMode.IgnoreSchema)

        _ToolsAutocomplete = New CustomAutoCompleteCollection(_Tools.QuickRun.CreateDataReader, "shortname")
        Me.uiTextBoxCommand.AutoCompleteCustomSource = _ToolsAutocomplete
    End Sub

    Private Function XMLDataFilePath() As String
        Dim lReturn As String

        lReturn = IO.Path.Combine(My.Application.Info.DirectoryPath, XML_DATA_FILE)

        Return lReturn
    End Function
End Class