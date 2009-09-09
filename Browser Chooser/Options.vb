Imports Microsoft.Win32
Imports System.IO



Public Class Options
    Public InstalledBrowsers As List(Of Browser)

    Private Sub LoadBrowsers()

        InstalledBrowsers = New List(Of Browser)
        InstalledBrowsers.Add(New Browser("Custom", ""))

        Dim programFiles As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles

        If IntPtr.Size = 8 Or Not String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")) Then
            programFiles = Environment.GetEnvironmentVariable("ProgramFiles(x86)")
        End If

        Dim appData As String = Directory.GetParent(My.Computer.FileSystem.SpecialDirectories.Temp).FullName

        ' Add Firefox
        Dim firefox As String = Path.Combine(programFiles, "Mozilla Firefox\firefox.exe")
        If File.Exists(firefox) Then
            InstalledBrowsers.Add(New Browser("Firefox", firefox))
        End If

        ' Add Google Chrome
        Dim chrome As String = Path.Combine(appData, "Google\Chrome\Application\chrome.exe")
        If File.Exists(chrome) Then
            InstalledBrowsers.Add(New Browser("Google Chrome", chrome))
        End If

        ' Add Internet Explorer
        Dim internetExplorer As String = Path.Combine(programFiles, "Internet Explorer\iexplore.exe")
        If File.Exists(internetExplorer) Then
            InstalledBrowsers.Add(New Browser("Internet Explorer", internetExplorer))
        End If

        ' Add Opera
        Dim opera As String = Path.Combine(programFiles, "Opera\opera.exe")
        If File.Exists(opera) Then
            InstalledBrowsers.Add(New Browser("Opera", opera))
        End If

        ' Add Safari
        Dim safari As String = Path.Combine(programFiles, "Safari\Safari.exe")
        If File.Exists(safari) Then
            InstalledBrowsers.Add(New Browser("Safari", safari))
        End If

    End Sub

    Private Sub btnBrowse1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser1.Click
        Browser1FileDialog.Filter = "Application | *.exe"
        Browser1FileDialog.ShowDialog()
        Browser1Target.Text = Browser1FileDialog.FileName.ToString
    End Sub

    Private Sub btnBrowse2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser2.Click
        Browser2FileDialog.Filter = "Application | *.exe"
        Browser2FileDialog.ShowDialog()
        Browser2Target.Text = Browser2FileDialog.FileName.ToString
    End Sub

    Private Sub btnBrowse3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser3.Click
        Browser3FileDialog.Filter = "Application | *.exe"
        Browser3FileDialog.ShowDialog()
        Browser3Target.Text = Browser3FileDialog.FileName.ToString
    End Sub

    Private Sub btnBrowse4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser4.Click
        Browser4FileDialog.Filter = "Application | *.exe"
        Browser4FileDialog.ShowDialog()
        Browser4Target.Text = Browser4FileDialog.FileName.ToString
    End Sub

    Private Sub btnBrowse5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser5.Click
        Browser5FileDialog.Filter = "Application | *.exe"
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
                    SetDefaultBrowserPath()
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
            sw.WriteLine("ShowURL=" & cbURL.Checked)
            Module1.showURL = cbURL.Checked
            sw.WriteLine("AutoUpdateCheck=" & cbAutoCheck.Checked)
            Module1.AutoUpdateCheck = cbAutoCheck.Checked

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

        'Me.Close()
        Process.Start(Application.ExecutablePath)
        System.Environment.Exit(-1)
        'frmMain.InitializeMain()

        'MsgBox("Please restart the application for the settings to take effect.")
    End Sub


    Private Sub Options_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Autodetect all present browsers
        LoadBrowsers()

        Browser1.DataSource = InstalledBrowsers.ToList()
        Browser1.DisplayMember = "Name"
        Browser1.ValueMember = "Path"
        Browser2.DataSource = InstalledBrowsers.ToList()
        Browser2.DisplayMember = "Name"
        Browser2.ValueMember = "Path"
        Browser3.DataSource = InstalledBrowsers.ToList()
        Browser3.DisplayMember = "Name"
        Browser3.ValueMember = "Path"
        Browser4.DataSource = InstalledBrowsers.ToList()
        Browser4.DisplayMember = "Name"
        Browser4.ValueMember = "Path"
        Browser5.DataSource = InstalledBrowsers.ToList()
        Browser5.DisplayMember = "Name"
        Browser5.ValueMember = "Path"

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

        'Select the correct items in the Browser dropdown
        Try
            SelectBrowser(Module1.Browser1Target, Module1.Browser1Image, Browser1)
            SelectBrowser(Module1.Browser2Target, Module1.Browser2Image, Browser2)
            SelectBrowser(Module1.Browser3Target, Module1.Browser3Image, Browser3)
            SelectBrowser(Module1.Browser4Target, Module1.Browser4Image, Browser4)
            SelectBrowser(Module1.Browser5Target, Module1.Browser5Image, Browser5)
        Catch ex As Exception

        End Try

        cbURL.Checked = Module1.showURL
        cbAutoCheck.Checked = Module1.AutoUpdateCheck

        Dim ConfigFile As New IO.FileInfo(Application.StartupPath & "\config.ini")
        If Not ConfigFile.Exists Then
            If MsgBox("Would you like to automatically check for updates?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                cbAutoCheck.Checked = True
                Module1.AutoUpdateCheck = True
            End If
        End If
    End Sub

    Private Sub SelectBrowser(ByVal BrowserPath As String, ByVal BrowserName As String, ByVal currentComboBox As ComboBox)
        Dim path As String = BrowserPath
        Dim comparer As New BrowserPredicate(path)
        Dim browser As Browser = InstalledBrowsers.Find(AddressOf comparer.ComparePaths)
        If browser IsNot Nothing Then
            currentComboBox.SelectedIndex = currentComboBox.FindString(BrowserName)
        End If
    End Sub

    Private Class BrowserPredicate
        Private _path As String
        Private _name As String

        Public Sub New(ByVal path As String)
            _path = path
        End Sub

        Public Function ComparePaths(ByVal obj As Browser) As Boolean
            Return (_path = obj.Path)
        End Function

        Public Function CompareNames(ByVal obj As Browser) As Boolean
            Return (_path = obj.Name)
        End Function
    End Class

    Private Sub Browser1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browser1.SelectedIndexChanged, Browser2.SelectedIndexChanged, Browser3.SelectedIndexChanged, Browser4.SelectedIndexChanged, Browser5.SelectedIndexChanged
        Dim SelectedComboBox As ComboBox = sender

        If SelectedComboBox.SelectedIndex > 0 Then
            Dim SelectedBrowser As Browser
            SelectedBrowser = SelectedComboBox.SelectedItem

            Select Case SelectedComboBox.Name
                Case "Browser1"
                    Browser1Name.Text = SelectedBrowser.Name
                    Browser1Target.Text = SelectedBrowser.Path
                    Browser1Image.SelectedIndex = Browser1Image.FindString(SelectedBrowser.Name)
                Case "Browser2"
                    Browser2Name.Text = SelectedBrowser.Name
                    Browser2Target.Text = SelectedBrowser.Path
                    Browser2Image.SelectedIndex = Browser2Image.FindString(SelectedBrowser.Name)
                Case "Browser3"
                    Browser3Name.Text = SelectedBrowser.Name
                    Browser3Target.Text = SelectedBrowser.Path
                    Browser3Image.SelectedIndex = Browser3Image.FindString(SelectedBrowser.Name)
                Case "Browser4"
                    Browser4Name.Text = SelectedBrowser.Name
                    Browser4Target.Text = SelectedBrowser.Path
                    Browser4Image.SelectedIndex = Browser4Image.FindString(SelectedBrowser.Name)
                Case "Browser5"
                    Browser5Name.Text = SelectedBrowser.Name
                    Browser5Target.Text = SelectedBrowser.Path
                    Browser5Image.SelectedIndex = Browser5Image.FindString(SelectedBrowser.Name)
                Case Else

            End Select
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'If ConfigFile.Exists Then
        '    Me.Close()
        'Else
        Process.Start(Application.ExecutablePath)
        System.Environment.Exit(-1)

        'End If
    End Sub

    Private Sub btnSetDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetDefault.Click

        MsgBox(SetDefaultBrowserPath())


    End Sub

    Public Function SetDefaultBrowserPath() As String
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
                MsgBox("An error may have occured registering the file extensions. You may want to check in the 'Default Programs' option in your start menu to confirm this worked." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Exclamation)
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

    Private Sub btnUpdateCheck_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdateCheck.Click

        frmMain.CheckforUpdate("verbose")


    End Sub
End Class