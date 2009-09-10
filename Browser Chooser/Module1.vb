Imports System.IO

Module Module1

    Friend DefaultMessage As String = "Choose a Browser"
    Friend strUrl As String

    Friend BrowserConfig As New BrowserList

    Friend ConfigFile As New IO.FileInfo(Application.StartupPath & "\config.ini")
    Friend Const BrowserChooserConfigFileName As String = "BrowserChooserConfig.xml"
	Friend AutoUpdateCheck As Boolean = False

    Public Sub Main()
        Application.EnableVisualStyles()
        If (ConfigFile.Exists) Then
            Dim importConfig As ConfigSetup = New ConfigSetup
            BrowserConfig = importConfig.readConfig()
        Else
            'Switch to make portable
            'BrowserConfig = BrowserList.Load(Application.StartupPath)
            BrowserConfig = BrowserList.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\BrowserChooser\")
        End If

        Dim cmdLineOption As String = ""
        If (My.Application.CommandLineArgs.Count > 0) Then
            cmdLineOption = My.Application.CommandLineArgs.Item(0)
            If (cmdLineOption = "gooptions") Then
                Application.Run(Options)
            Else
                strUrl = cmdLineOption
                Dim browserNumber As Integer = BrowserConfig.GetBrowserByUrl(strUrl)
                If (Not browserNumber = 0) Then
                    LaunchBrowser(browserNumber)
                Else
                    Application.Run(frmMain)
                End If
            End If
        Else
            Application.Run(frmMain)
        End If
    End Sub

    Private Sub openOptions()
        Dim myProcess As New Process
        myProcess.StartInfo.UseShellExecute = True
        myProcess.StartInfo.Verb = "runas"
        myProcess.StartInfo.FileName = Application.ExecutablePath
        myProcess.StartInfo.Arguments = "gooptions"
        myProcess.Start()
        System.Environment.Exit(-1)
    End Sub


    Function LaunchBrowser(ByVal browserNumber As Integer) As Boolean
        Dim target As String = BrowserConfig.GetBrowser(browserNumber).Target
        Dim strParameters As String = ""
        'check to see if the file exists
        If (File.Exists(target)) Or target.Contains(".exe ") Then
            If target.Contains(".exe ") Then
                strParameters = target.Substring(InStr(target, ".exe") + 4, target.Length - (InStr(target, ".exe") + 4)) & " "
                If strUrl <> "" Then
                    Process.Start(target.Substring(0, InStr(target, ".exe") + 4), strParameters & """" & strUrl & """")
                Else
                    Process.Start(target.Substring(0, InStr(target, ".exe") + 4), strParameters)
                End If
            Else
                If strUrl <> "" Then
                    Process.Start(target, """" & strUrl & """")
                Else
                    Process.Start(target)
                End If
            End If
            Return True
        End If
        'file doesn't exist so return false
        Return False
    End Function



End Module

