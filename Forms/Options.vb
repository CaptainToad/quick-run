Option Strict On
Option Explicit On

Imports System.Windows.Forms

Public Class Options
    Private _Settings As StringDataBag

    Private Sub uiButtonOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiButtonOK.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub uiButtonCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiButtonCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub uiCheckBoxAutoStart_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uiCheckBoxAutoStart.CheckedChanged
        _Settings.Value("AutoStart") = Me.uiCheckBoxAutoStart.Checked.ToString
    End Sub

    Public Property Settings() As StringDataBag
        Get
            Return _Settings
        End Get
        Set(ByVal value As StringDataBag)
            _Settings = value
        End Set
    End Property

    Private Sub Options_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.uiCheckBoxAutoStart.Checked = CBool(_Settings.Value("AutoStart"))
    End Sub
End Class