Option Strict On
Option Explicit On

Imports Microsoft.Win32
Imports System.Security.Permissions

Public NotInheritable Class Main

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

            lKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run")
            lReturn = lKey.GetValue("QuickRun", "").ToString
            lKey.Close()

            Return Not String.IsNullOrEmpty(lReturn)
        End Get
        Set(ByVal value As Boolean)
            Dim lKey As RegistryKey

            lKey = My.Computer.Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)

            If value Then
                lKey.SetValue("QuickRun", Application.ExecutablePath, RegistryValueKind.String)
            Else
                lKey.DeleteValue("QuickRun")
            End If

            lKey.Close()
        End Set
    End Property
End Class