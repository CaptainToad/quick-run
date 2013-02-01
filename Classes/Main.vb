Option Strict On
Option Explicit On

Imports Microsoft.Win32
Imports System.Security.Permissions

Public NotInheritable Class Main
    Private Const CURRENT_USER_RUN As String = "Software\Microsoft\Windows\CurrentVersion\Run"
    Private Const QUICKRUN As String = "QuickRun"

    Private Sub New()
        '
    End Sub

    <STAThread()> _
    Public Shared Sub Main()
        Dim lTrayIcon As New TrayIcon

        Application.EnableVisualStyles()
        Application.Run(lTrayIcon)
    End Sub

    Friend Shared Property AutoStart() As Boolean
        Get
            Dim lKey As RegistryKey
            Dim lReturn As String

            lKey = My.Computer.Registry.CurrentUser.OpenSubKey(CURRENT_USER_RUN)
            lReturn = lKey.GetValue(QUICKRUN, "").ToString
            lKey.Close()

            Return Not String.IsNullOrEmpty(lReturn)
        End Get
        Set(ByVal value As Boolean)
            Dim lKey As RegistryKey = My.Computer.Registry.CurrentUser.OpenSubKey(CURRENT_USER_RUN, True)

            If value Then
                lKey.SetValue(QUICKRUN, Application.ExecutablePath, RegistryValueKind.String)
            Else
                If lKey.GetValue(QUICKRUN) IsNot Nothing Then
                    lKey.DeleteValue(QUICKRUN)
                End If
            End If

            lKey.Close()
        End Set
    End Property
End Class