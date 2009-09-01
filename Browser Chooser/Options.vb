Imports Microsoft.Win32

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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Save settings from textboxes
        My.Settings.Browser1Disable = Browser1Disable.Checked
        My.Settings.Browser2Disable = Browser2Disable.Checked
        My.Settings.Browser3Disable = Browser3Disable.Checked
        My.Settings.Browser4Disable = Browser4Disable.Checked

        My.Settings.Browser1Name = Browser1Name.Text
        My.Settings.Browser2Name = Browser2Name.Text
        My.Settings.Browser3Name = Browser3Name.Text
        My.Settings.Browser4Name = Browser4Name.Text

        My.Settings.Browser1Target = Browser1Target.Text
        My.Settings.Browser2Target = Browser2Target.Text
        My.Settings.Browser3Target = Browser3Target.Text
        My.Settings.Browser4Target = Browser4Target.Text

        My.Settings.Browser1Image = Browser1Image.SelectedItem
        My.Settings.Browser2Image = Browser2Image.SelectedItem
        My.Settings.Browser3Image = Browser3Image.SelectedItem
        My.Settings.Browser4Image = Browser4Image.SelectedItem

        Me.Close()
        MsgBox("Please restart the application for the settings to take effect.")
    End Sub


    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Load settings into textboxes
        Browser1Name.Text = My.Settings.Browser1Name
        Browser2Name.Text = My.Settings.Browser2Name
        Browser3Name.Text = My.Settings.Browser3Name
        Browser4Name.Text = My.Settings.Browser4Name

        Browser1Target.Text = My.Settings.Browser1Target
        Browser2Target.Text = My.Settings.Browser2Target
        Browser3Target.Text = My.Settings.Browser3Target
        Browser4Target.Text = My.Settings.Browser4Target

        Browser1Image.SelectedItem = My.Settings.Browser1Image
        Browser2Image.SelectedItem = My.Settings.Browser2Image
        Browser3Image.SelectedItem = My.Settings.Browser3Image
        Browser4Image.SelectedItem = My.Settings.Browser4Image

        Browser1Disable.Checked = My.Settings.Browser1Disable
        Browser2Disable.Checked = My.Settings.Browser2Disable
        Browser3Disable.Checked = My.Settings.Browser3Disable
        Browser4Disable.Checked = My.Settings.Browser4Disable
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
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
        End Try
        Return "Default browser has been set to Browser Chooser."

    End Function

    Private Sub Browser1Disable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser1Disable.CheckedChanged
        If Browser1Disable.Checked = False Then
            If Browser1Name.Text = "" Or Browser1Target.Text = "" Or Browser1Image.SelectedItem = "" Then
                MsgBox("You must fill in all the fields!", MsgBoxStyle.Exclamation)
                Browser1Disable.Checked = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Browser2Disable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser2Disable.CheckedChanged
        If Browser2Disable.Checked = False Then
            If Browser2Name.Text = "" Or Browser2Target.Text = "" Or Browser2Image.SelectedItem = "" Then
                MsgBox("You must fill in all the fields!", MsgBoxStyle.Exclamation)
                Browser2Disable.Checked = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Browser3Disable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser3Disable.CheckedChanged
        If Browser3Disable.Checked = False Then
            If Browser3Name.Text = "" Or Browser3Target.Text = "" Or Browser3Image.SelectedItem = "" Then
                MsgBox("You must fill in all the fields!", MsgBoxStyle.Exclamation)
                Browser3Disable.Checked = True
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Browser4Disable_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser4Disable.CheckedChanged
        If Browser4Disable.Checked = False Then
            If Browser4Name.Text = "" Or Browser4Target.Text = "" Or Browser4Image.SelectedItem = "" Then
                MsgBox("You must fill in all the fields!", MsgBoxStyle.Exclamation)
                Browser4Disable.Checked = True
                Exit Sub
            End If
        End If
    End Sub
End Class