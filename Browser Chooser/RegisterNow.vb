Imports System.Security.Principal
Imports System.Threading

Public Class RegisterNow
    Private Sub RegisterNow_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ad As AppDomain = Thread.GetDomain()
        ad.SetPrincipalPolicy(PrincipalPolicy.WindowsPrincipal)
        Dim user As WindowsPrincipal = Thread.CurrentPrincipal
        ' Decorate Activate Browser button with the BCM_SETSHIELD method if the user Is an non admin
        Dim ElevationRequired = False
        If (Not user.IsInRole(WindowsBuiltInRole.Administrator)) Then
            ElevationRequired = True
            Options.ElevateIcon_BCM_SETSHIELD(btnYes, True)
        Else
            Options.ElevateIcon_BCM_SETSHIELD(btnYes, False)
        End If
    End Sub

    Private Sub btnYes_Click(sender As Object, e As EventArgs) Handles btnYes.Click
        Dim pricipal As WindowsPrincipal = New WindowsPrincipal(WindowsIdentity.GetCurrent())
        Dim hasAdministrativeRight As Boolean = pricipal.IsInRole(WindowsBuiltInRole.Administrator)
        If (Not hasAdministrativeRight) Then
            Dim startInfo As ProcessStartInfo = New ProcessStartInfo()
            startInfo.UseShellExecute = True
            startInfo.WorkingDirectory = Environment.CurrentDirectory
            startInfo.FileName = Application.ExecutablePath
            startInfo.Arguments = "registerbrowser"
            startInfo.Verb = "runas"
            startInfo.CreateNoWindow = True
            Dim p As Process = Process.Start(startInfo)
            p.WaitForExit()
        Else
            MsgBox(Options.SetDefaultBrowserPath)
        End If
        Me.Close()
    End Sub

    Private Sub btnNo_Click(sender As Object, e As EventArgs) Handles btnNo.Click
        Me.Close()
    End Sub
End Class