Imports Microsoft.Win32
Imports System.IO

Public Class Options


    Private Sub btnBrowse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser1.Click
        Browser1FileDialog.ShowDialog()
        Browser1Target.Text = Browser1FileDialog.FileName.ToString
    End Sub

    Private Sub btnBrowse2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser2.Click
        Browser2FileDialog.ShowDialog()
        Browser2Target.Text = Browser2FileDialog.FileName.ToString
    End Sub

    Private Sub btnBrowse3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser3.Click
        Browser3FileDialog.ShowDialog()
        Browser3Target.Text = Browser3FileDialog.FileName.ToString
    End Sub

    Private Sub btnBrowse4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser4.Click
        Browser4FileDialog.ShowDialog()
        Browser4Target.Text = Browser4FileDialog.FileName.ToString
    End Sub

    Private Sub btnBrowse5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser5.Click
        Browser5FileDialog.ShowDialog()
        Browser5Target.Text = Browser5FileDialog.FileName.ToString
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save settings from textboxes
        Try
            'Offer to make default browser if not already
            If IsDefaultBrowser = False Then

                Dim Answer As MsgBoxResult = MsgBox("Browser Chooser is not currently set as your default browser. Would you like to make it so now?" & vbCrLf & "(Without being the default browser, Browser Chooser's usefullness rapidly declines...)", MsgBoxStyle.YesNo)

                If Answer = MsgBoxResult.Yes Then
                    IsDefaultBrowser = True
                Else
                    IsDefaultBrowser = False
                End If

            End If

            'Remove existing config.ini
            If ConfigFile.Exists Then
                ConfigFile.Delete()
            End If

            'Write settings to config.ini
            Dim sw As StreamWriter = New StreamWriter(ConfigFile.ToString)

            sw.WriteLine("DefaultBrowser=" & IsDefaultBrowser)

            sw.WriteLine("Browser1Name=" & Browser1Name.Text)
            sw.WriteLine("Browser1Target=" & Browser1Target.Text)
            sw.WriteLine("Browser1Image=" & Browser1Image.Text)

            sw.WriteLine("Browser2Name=" & Browser2Name.Text)
            sw.WriteLine("Browser2Target=" & Browser2Target.Text)
            sw.WriteLine("Browser2Image=" & Browser2Image.Text)

            sw.WriteLine("Browser3Name=" & Browser3Name.Text)
            sw.WriteLine("Browser3Target=" & Browser3Target.Text)
            sw.WriteLine("Browser3Image=" & Browser3Image.Text)

            sw.WriteLine("Browser4Name=" & Browser4Name.Text)
            sw.WriteLine("Browser4Target=" & Browser4Target.Text)
            sw.WriteLine("Browser4Image=" & Browser4Image.Text)

            sw.WriteLine("Browser5Name=" & Browser5Name.Text)
            sw.WriteLine("Browser5Target=" & Browser5Target.Text)
            sw.WriteLine("Browser5Image=" & Browser5Image.Text)

            sw.Close()

        Catch ex As Exception

            MsgBox("There was an error saving to the configuration file." & vbCrLf & ex.Message, MsgBoxStyle.Critical)

        End Try

        Me.Close()

        frmMain.InitializeMain()

        'MsgBox("Please restart the application for the settings to take effect.")
    End Sub


    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load settings into textboxes
        Browser1Name.Text = Module1.Browser1Name
        Browser2Name.Text = Module1.Browser2Name
        Browser3Name.Text = Module1.Browser3Name
        Browser4Name.Text = Module1.Browser4Name
        Browser5Name.Text = Module1.Browser5Name

        Browser1Target.Text = Module1.Browser1Target
        Browser2Target.Text = Module1.Browser2Target
        Browser3Target.Text = Module1.Browser3Target
        Browser4Target.Text = Module1.Browser4Target
        Browser5Target.Text = Module1.Browser5Target

        Browser1Image.SelectedItem = Module1.Browser1Image
        Browser2Image.SelectedItem = Module1.Browser2Image
        Browser3Image.SelectedItem = Module1.Browser3Image
        Browser4Image.SelectedItem = Module1.Browser4Image
        Browser5Image.SelectedItem = Module1.Browser5Image
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If ConfigFile.Exists Then
            Me.Close()
        Else
            Application.Exit()
        End If
    End Sub

    Private Sub btnSetDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDefault.Click
        MsgBox(SetDefaultBrowserPath)
    End Sub

    Private Function SetDefaultBrowserPath() As String
        Try
            Registry.LocalMachine.CreateSubKey("SOFTWARE\RegisteredApplications").SetValue("Browser Chooser", "Software\\Browser Chooser\\Capabilities", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities").SetValue("ApplicationName", "Browser Chooser", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities").SetValue("ApplicationIcon", Application.ExecutablePath & ",0", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities").SetValue("ApplicationDescription", "Small app that let's you choose what browser to open a url in. Visit my website for more information. www.janolepeek.com", RegistryValueKind.String)

            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\FileAssociations").SetValue(".xhtml", "BrowserChooserHTML", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\FileAssociations").SetValue(".xht", "BrowserChooserHTML", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\FileAssociations").SetValue(".shtml", "BrowserChooserHTML", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\FileAssociations").SetValue(".html", "BrowserChooserHTML", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\FileAssociations").SetValue(".htm", "BrowserChooserHTML", RegistryValueKind.String)

            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\StartMenu").SetValue("StartMenuInternet", "Browser Chooser.exe", RegistryValueKind.String)

            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\URLAssociations").SetValue("https", "BrowserChooserHTML", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\URLAssociations").SetValue("http", "BrowserChooserHTML", RegistryValueKind.String)
            Registry.LocalMachine.CreateSubKey("SOFTWARE\Browser Chooser\Capabilities\URLAssociations").SetValue("ftp", "BrowserChooserHTML", RegistryValueKind.String)

            Registry.ClassesRoot.CreateSubKey("BrowserChooserHTML").SetValue("", "Browser Chooser HTML", RegistryValueKind.String)
            Registry.ClassesRoot.CreateSubKey("BrowserChooserHTML").SetValue("URL Protocol", "", RegistryValueKind.String)

            Registry.ClassesRoot.CreateSubKey("BrowserChooserHTML\DefaultIcon").SetValue("", Application.ExecutablePath & ",0", RegistryValueKind.String)

            Registry.ClassesRoot.CreateSubKey("BrowserChooserHTML\shell\open\command").SetValue("", Application.ExecutablePath & " %1", RegistryValueKind.String)

            Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice").SetValue("Progid", "BrowserChooserHTML", Microsoft.Win32.RegistryValueKind.String)
            Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\Shell\Associations\UrlAssociations\https\UserChoice").SetValue("Progid", "BrowserChooserHTML", Microsoft.Win32.RegistryValueKind.String)
            Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\Shell\Associations\UrlAssociations\ftp\UserChoice").SetValue("Progid", "BrowserChooserHTML", Microsoft.Win32.RegistryValueKind.String)

            Try
                Registry.CurrentUser.DeleteSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.htm\UserChoice")
                Registry.CurrentUser.DeleteSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.html\UserChoice")
                Registry.CurrentUser.DeleteSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.shtml\UserChoice")
                Registry.CurrentUser.DeleteSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.xht\UserChoice")
                Registry.CurrentUser.DeleteSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.xhtml\UserChoice")

                Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.htm\UserChoice").SetValue("Progid", "BrowserChooserHTML", Microsoft.Win32.RegistryValueKind.String)
                Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.html\UserChoice").SetValue("Progid", "BrowserChooserHTML", Microsoft.Win32.RegistryValueKind.String)
                Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.shtml\UserChoice").SetValue("Progid", "BrowserChooserHTML", Microsoft.Win32.RegistryValueKind.String)
                Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.xht\UserChoice").SetValue("Progid", "BrowserChooserHTML", Microsoft.Win32.RegistryValueKind.String)
                Registry.CurrentUser.CreateSubKey("Software\Microsoft\Windows\CurrentVersion\Explorer\FileExts\.xhtml\UserChoice").SetValue("Progid", "BrowserChooserHTML", Microsoft.Win32.RegistryValueKind.String)
            Catch ex As Exception
                MsgBox("An error may have occured registering the file extensions. You may want to check in the 'Default Programs' option in your start menu to confirm this worked.", MsgBoxStyle.Exclamation)
            End Try

            

            


        Catch ex As Exception
            Return "Problem writing or reading Registry: " & vbCrLf & vbCrLf & ex.Message
            IsDefaultBrowser = False
        End Try

        IsDefaultBrowser = True

        Return "Default browser has been set to Browser Chooser."

    End Function

   
    Private Sub Browser1Target_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser1Target.TextChanged
        If Browser1Target.Text <> "" Then Panel2.Enabled = True Else Panel2.Enabled = False
    End Sub

    Private Sub Browser2Target_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser2Target.TextChanged
        If Browser2Target.Text <> "" Then Panel3.Enabled = True Else Panel3.Enabled = False
    End Sub

    Private Sub Browser3Target_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser3Target.TextChanged
        If Browser3Target.Text <> "" Then Panel4.Enabled = True Else Panel4.Enabled = False
    End Sub

    Private Sub Browser4Target_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser4Target.TextChanged
        If Browser4Target.Text <> "" Then Panel5.Enabled = True Else Panel5.Enabled = False
    End Sub
End Class