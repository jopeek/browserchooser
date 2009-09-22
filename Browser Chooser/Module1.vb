Imports System.IO
Imports System.Reflection
Imports Microsoft.WindowsAPICodePack.Taskbar

Module Module1
    Friend Is64Bit As Boolean = False
    Friend PortableMode = False
    Friend DefaultMessage As String = "Choose a Browser"
    Friend strUrl As String
    Friend BrowserConfig As New BrowserList

    Friend ConfigFile As New IO.FileInfo(Application.StartupPath & "\config.ini")
    Friend Const BrowserChooserConfigFileName As String = "BrowserChooserConfig.xml"
    Friend Const DaysBetweenUpdateCheck As Integer = 3
    Friend AutoUpdateCheck As Boolean = False

    Function MyResolveEventHandler(ByVal sender As Object, ByVal args As ResolveEventArgs) As [Assembly]
        Dim parentAssembly As Assembly = Assembly.GetExecutingAssembly()

        Dim name = args.Name.Substring(0, args.Name.IndexOf(","c)) & ".dll"

        If name = "Microsoft.WindowsAPICodePack.dll" Or name = "Microsoft.WindowsAPICodePack.Shell.dll" Then
            Dim resourceName = parentAssembly.GetManifestResourceNames().First(Function(s) s.EndsWith(name))

            Using stream As Stream = parentAssembly.GetManifestResourceStream(resourceName)
                Dim block As Byte() = New Byte(stream.Length - 1) {}
                stream.Read(block, 0, block.Length)
                Return Assembly.Load(block)
            End Using
        End If

        Return GetType(Module1).Assembly
    End Function


    Public Sub Main()
        ' load the WindowsAPICodePack DLLs from the embedded resource allowing us to keep one tidy .exe and no dlls.
        Dim currentDomain As AppDomain = AppDomain.CurrentDomain
        AddHandler currentDomain.AssemblyResolve, AddressOf MyResolveEventHandler

        Application.EnableVisualStyles()

        ' set the 64bit flag if we are runnong on a 64 bit OS
        If IntPtr.Size = 8 Or Not String.IsNullOrEmpty(Environment.GetEnvironmentVariable("PROCESSOR_ARCHITEW6432")) Then
            Is64Bit = True
        End If

        ' set the portable mode flag if we detect a local config file
        If (File.Exists(Path.Combine(Application.StartupPath, BrowserChooserConfigFileName))) Then
            PortableMode = True
        End If

        If (ConfigFile.Exists) Then
            Dim importConfig As ConfigSetup = New ConfigSetup
            BrowserConfig = importConfig.readConfig()
            PortableMode = True
        Else
            'Switch to make portable
            If (PortableMode) Then
                BrowserConfig = BrowserList.Load(Application.StartupPath)
            Else
                BrowserConfig = BrowserList.Load(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\BrowserChooser\")
            End If
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
    Function NormalizeTarget(ByVal target As String) As String
        ' it's possible that in portable mode you have a path to an x86 folder and are running on a 32 bit system
        ' so the strBrowser will point to an invalid browser
        If Is64Bit Then
            Dim programFiles As String = My.Computer.FileSystem.SpecialDirectories.ProgramFiles

            If (target.StartsWith(programFiles)) Then
                If (target.StartsWith(Environment.GetEnvironmentVariable("ProgramFiles(x86)")) = False) Then
                    target = target.Replace(programFiles, Environment.GetEnvironmentVariable("ProgramFiles(x86)"))
                End If
            End If
        Else
            If (target.Contains("x86")) Then
                target = target.Replace(" (x86)", "")
            End If
        End If

        Return target
    End Function

    Function LaunchBrowser(ByVal browserNumber As Integer) As Boolean
        Dim target As String = NormalizeTarget(BrowserConfig.GetBrowser(browserNumber).Target)

        Dim strParameters As String = ""
        Dim strBrowser As String
        'check to see if the file exists
        If (File.Exists(target)) Or target.Contains(".exe ") Then
            If target.Contains(".exe ") Then
                strBrowser = target.Substring(0, InStr(target, ".exe") + 4)
                strParameters = target.Substring(InStr(target, ".exe") + 4, target.Length - (InStr(target, ".exe") + 4)) & " "

                If strUrl <> "" Then
                    Process.Start(strBrowser, strParameters & """" & strUrl & """")
                Else
                    Process.Start(strBrowser, strParameters)
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

    Function IsIntranetUrl(ByVal url As String) As Boolean
        Dim targetUri As Uri = New Uri(url)
        Dim domain As String = targetUri.Authority

        If domain.Contains(".") Then
            Return False
        End If

        Return True
    End Function
End Module