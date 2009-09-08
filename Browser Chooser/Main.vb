Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Diagnostics
Imports System.Net


Public Class frmMain

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure MARGINS
        Public cxLeftWidth As Integer
        Public cxRightWidth As Integer
        Public cyTopHeight As Integer
        Public cyButtomheight As Integer
    End Structure

    <DllImport("dwmapi.dll")> _
    Public Shared Function DwmExtendFrameIntoClientArea(ByVal hWnd As IntPtr, ByRef pMarinset As MARGINS) As Integer
    End Function

    Private strURL As String = ""
    Private strParameters As String = ""


    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        About.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnApp1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.MouseHover, btnApp1.MouseEnter
        If showURL = True And strURL <> "" Then
            Me.Text = "Open in " & Browser1Name & " - " & strURL
        Else
            Me.Text = "Open " & Browser1Name
        End If
    End Sub

    Private Sub btnApp1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnApp2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.MouseHover, btnApp2.MouseEnter
        If showURL = True And strURL <> "" Then
            Me.Text = "Open in " & Browser2Name & " - " & strURL
        Else
            Me.Text = "Open " & Browser2Name
        End If
    End Sub

    Private Sub btnApp2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnApp3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.MouseHover, btnApp3.MouseEnter
        If showURL = True And strURL <> "" Then
            Me.Text = "Open in " & Browser3Name & " - " & strURL
        Else
            Me.Text = "Open " & Browser3Name
        End If
    End Sub

    Private Sub btnApp3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnApp4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.MouseHover, btnApp4.MouseEnter
        If showURL = True And strURL <> "" Then
            Me.Text = "Open in " & Browser4Name & " - " & strURL
        Else
            Me.Text = "Open " & Browser4Name
        End If
    End Sub

    Private Sub btnApp4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnApp5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp5.MouseHover, btnApp5.MouseEnter
        If showURL = True And strURL <> "" Then
            Me.Text = "Open in " & Browser5Name & " - " & strURL
        Else
            Me.Text = "Open " & Browser5Name
        End If
    End Sub

    Private Sub btnApp5_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp5.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Public Function GetRowValue(ByVal sLine As String) As String
        Dim i As Integer = sLine.IndexOf("=")
        If i <> -1 Then
            GetRowValue = sLine.Substring(0, i)
        Else
            GetRowValue = ""
        End If
    End Function

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If My.Application.CommandLineArgs.Count > 0 Then
            If My.Application.CommandLineArgs(0) = "gooptions" Then
                'MsgBox(Options.SetDefaultBrowserPath())
                'Application.Exit()
                readConfig()
                Options.ShowDialog()
                Application.Exit()
            End If
        End If


        On Error Resume Next
        Dim margins As MARGINS = New MARGINS
        margins.cxLeftWidth = -1
        margins.cxRightWidth = -1
        margins.cyTopHeight = -1
        margins.cyButtomheight = -1
        'set all the four value -1 to apply glass effect to the whole window
        'set your own value to make specific part of the window glassy.
        Dim hwnd As IntPtr = Me.Handle
        Dim result As Integer = DwmExtendFrameIntoClientArea(hwnd, margins)

        InitializeMain()

        'Load url from parameter
        For i = 0 To My.Application.CommandLineArgs.Count - 1
            strURL = My.Application.CommandLineArgs.Item(i).ToString
        Next i
    End Sub

    Public Sub CheckforUpdate(ByVal strMode As String)

        Try

            Dim client As WebClient = New WebClient()

            Dim strWebVersion As String = client.DownloadString("http://www.janolepeek.com/bclatest.txt")

            If strWebVersion <> My.Application.Info.Version.ToString Then

                If MsgBox("A new version of Browser Checker is available. Would you like to download it now?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    Download.ShowDialog()

                End If
            Else
                If strMode = "verbose" Then
                    MsgBox("You are running the current version of Browser Chooser!", MsgBoxStyle.Information)
                End If
            End If

        Catch ex As Exception
            If strMode = "verbose" Then
                MsgBox("There was an error checking for the latest version." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End If
        End Try
        
    End Sub

    Public Sub readConfig()
        Try

            Using sr As StreamReader = New StreamReader(ConfigFile.ToString)
                Dim sLine As String = sr.ReadLine

                Do While Not sLine Is Nothing
                    Select Case GetRowValue(sLine)

                        Case "DefaultBrowser"
                            IsDefaultBrowser = sLine.Substring(15, sLine.Length - 15)
                        Case "ShowURL"
                            showURL = sLine.Substring(8, sLine.Length - 8)
                        Case "AutoUpdateCheck"
                            Module1.AutoUpdateCheck = sLine.Substring(16, sLine.Length - 16)
                        Case "Browser1Name"
                            Browser1Name = sLine.Substring(13, sLine.Length - 13)
                        Case "Browser2Name"
                            Browser2Name = sLine.Substring(13, sLine.Length - 13)
                        Case "Browser3Name"
                            Browser3Name = sLine.Substring(13, sLine.Length - 13)
                        Case "Browser4Name"
                            Browser4Name = sLine.Substring(13, sLine.Length - 13)
                        Case "Browser5Name"
                            Browser5Name = sLine.Substring(13, sLine.Length - 13)

                        Case "Browser1Target"
                            Browser1Target = sLine.Substring(15, sLine.Length - 15)
                        Case "Browser2Target"
                            Browser2Target = sLine.Substring(15, sLine.Length - 15)
                        Case "Browser3Target"
                            Browser3Target = sLine.Substring(15, sLine.Length - 15)
                        Case "Browser4Target"
                            Browser4Target = sLine.Substring(15, sLine.Length - 15)
                        Case "Browser5Target"
                            Browser5Target = sLine.Substring(15, sLine.Length - 15)

                        Case "Browser1Image"
                            Browser1Image = sLine.Substring(14, sLine.Length - 14)
                        Case "Browser2Image"
                            Browser2Image = sLine.Substring(14, sLine.Length - 14)
                        Case "Browser3Image"
                            Browser3Image = sLine.Substring(14, sLine.Length - 14)
                        Case "Browser4Image"
                            Browser4Image = sLine.Substring(14, sLine.Length - 14)
                        Case "Browser5Image"
                            Browser5Image = sLine.Substring(14, sLine.Length - 14)

                    End Select
                    sLine = sr.ReadLine
                Loop
                sr.Close()
            End Using

        Catch ex As Exception

        End Try
    End Sub

    Public Sub InitializeMain()
        'Check for configuration file
        Dim ConfigFile As New IO.FileInfo(Application.StartupPath & "\config.ini")
        If ConfigFile.Exists Then
            readConfig()

            If Browser1Image <> "" And Browser1Name <> "" And Browser1Target <> "" Then Browser1 = True Else Browser1 = False
            If Browser2Image <> "" And Browser2Name <> "" And Browser2Target <> "" Then Browser2 = True Else Browser2 = False
            If Browser3Image <> "" And Browser3Name <> "" And Browser3Target <> "" Then Browser3 = True Else Browser3 = False
            If Browser4Image <> "" And Browser4Name <> "" And Browser4Target <> "" Then Browser4 = True Else Browser4 = False
            If Browser5Image <> "" And Browser5Name <> "" And Browser5Target <> "" Then Browser5 = True Else Browser5 = False

        Else

            'Force open Options screen
            'Options.ShowDialog()

            MsgBox("No ocnfiguration file found! Now launching the Options screen to configure Browser Chooser.", MsgBoxStyle.Exclamation)
            openOptions()

        End If

        'Check for Update?

        If AutoUpdateCheck = True Then

            CheckforUpdate("")

        End If

        'Initialize browser buttons
        'If My.Settings.Browser1Disable And My.Settings.Browser2Disable And My.Settings.Browser3Disable And My.Settings.Browser4Disable And My.Settings.Browser5Disable Then
        '    lblEmpty.Visible = True
        'End If

        If Browser1 = True Then
            Me.Width = (1 * 81) + 112
            btnApp1.Visible = True
            Select Case Browser1Image
                Case "Firefox"
                    btnApp1.Image = My.Resources.Firefox
                Case "Internet Explorer"
                    btnApp1.Image = My.Resources.InternetExplorer
                Case "Google Chrome"
                    btnApp1.Image = My.Resources.GoogleChrome
                Case "Opera"
                    btnApp1.Image = My.Resources.Opera
                Case "Safari"
                    btnApp1.Image = My.Resources.Safari
            End Select
        Else
            btnApp1.Visible = False
        End If
        If Browser2 = True Then
            Me.Width = (2 * 81) + 112
            btnApp2.Visible = True
            Select Case Browser2Image
                Case "Firefox"
                    btnApp2.Image = My.Resources.Firefox
                Case "Internet Explorer"
                    btnApp2.Image = My.Resources.InternetExplorer
                Case "Google Chrome"
                    btnApp2.Image = My.Resources.GoogleChrome
                Case "Opera"
                    btnApp2.Image = My.Resources.Opera
                Case "Safari"
                    btnApp2.Image = My.Resources.Safari
            End Select
        Else
            btnApp2.Visible = False
        End If
        If Browser3 = True Then
            Me.Width = (3 * 81) + 112
            btnApp3.Visible = True
            Select Case Browser3Image
                Case "Firefox"
                    btnApp3.Image = My.Resources.Firefox
                Case "Internet Explorer"
                    btnApp3.Image = My.Resources.InternetExplorer
                Case "Google Chrome"
                    btnApp3.Image = My.Resources.GoogleChrome
                Case "Opera"
                    btnApp3.Image = My.Resources.Opera
                Case "Safari"
                    btnApp3.Image = My.Resources.Safari
            End Select
        Else
            btnApp3.Visible = False
        End If
        If Browser4 = True Then
            Me.Width = (4 * 81) + 112
            btnApp4.Visible = True
            Select Case Browser4Image
                Case "Firefox"
                    btnApp4.Image = My.Resources.Firefox
                Case "Internet Explorer"
                    btnApp4.Image = My.Resources.InternetExplorer
                Case "Google Chrome"
                    btnApp4.Image = My.Resources.GoogleChrome
                Case "Opera"
                    btnApp4.Image = My.Resources.Opera
                Case "Safari"
                    btnApp4.Image = My.Resources.Safari
            End Select
        Else
            btnApp4.Visible = False
        End If
        If Browser5 = True Then
            Me.Width = (5 * 81) + 112
            btnApp5.Visible = True
            Select Case Browser5Image
                Case "Firefox"
                    btnApp5.Image = My.Resources.Firefox
                Case "Internet Explorer"
                    btnApp5.Image = My.Resources.InternetExplorer
                Case "Google Chrome"
                    btnApp5.Image = My.Resources.GoogleChrome
                Case "Opera"
                    btnApp5.Image = My.Resources.Opera
                Case "Safari"
                    btnApp5.Image = My.Resources.Safari
            End Select
        Else
            btnApp5.Visible = False
        End If

        btnOptions.Location = New Point(Me.Width - 33, 12)
    End Sub

    Private Sub btnInfo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter, btnInfo.MouseHover
        Me.Text = "About"
    End Sub

    Private Sub btnInfo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnOptions_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.MouseEnter, btnOptions.MouseHover
        Me.Text = "Options"
    End Sub

    Private Sub btnOptions_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Text = "Close"
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        'Options.ShowDialog()
        openOptions()

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

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnApp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.Click
        If Browser1Target.Contains(".exe ") Then
            strParameters = Browser1Target.Substring(InStr(Browser1Target, ".exe") + 4, Browser1Target.Length - (InStr(Browser1Target, ".exe") + 4)) & " "
            If strURL <> "" Then
                Process.Start(Browser1Target.Substring(0, InStr(Browser1Target, ".exe") + 4), strParameters & """" & strURL & """")
            Else
                Process.Start(Browser1Target.Substring(0, InStr(Browser1Target, ".exe") + 4), strParameters)
            End If
        Else
            If strURL <> "" Then
                Process.Start(Browser1Target, """" & strURL & """")
            Else
                Process.Start(Browser1Target)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnApp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.Click
        If Browser2Target.Contains(".exe ") Then
            strParameters = Browser2Target.Substring(InStr(Browser2Target, ".exe") + 4, Browser2Target.Length - (InStr(Browser2Target, ".exe") + 4)) & " "
            If strURL <> "" Then
                Process.Start(Browser2Target.Substring(0, InStr(Browser2Target, ".exe") + 4), strParameters & """" & strURL & """")
            Else
                Process.Start(Browser2Target.Substring(0, InStr(Browser2Target, ".exe") + 4), strParameters)
            End If
        Else
            If strURL <> "" Then
                Process.Start(Browser2Target, """" & strURL & """")
            Else
                Process.Start(Browser2Target)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnApp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.Click
        If Browser3Target.Contains(".exe ") Then
            strParameters = Browser2Target.Substring(InStr(Browser3Target, ".exe") + 4, Browser3Target.Length - (InStr(Browser3Target, ".exe") + 4)) & " "
            If strURL <> "" Then
                Process.Start(Browser3Target.Substring(0, InStr(Browser3Target, ".exe") + 4), strParameters & """" & strURL & """")
            Else
                Process.Start(Browser3Target.Substring(0, InStr(Browser3Target, ".exe") + 4), strParameters)
            End If
        Else
            If strURL <> "" Then
                Process.Start(Browser3Target, """" & strURL & """")
            Else
                Process.Start(Browser3Target)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnApp4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.Click
        If Browser4Target.Contains(".exe ") Then
            strParameters = Browser4Target.Substring(InStr(Browser4Target, ".exe") + 4, Browser4Target.Length - (InStr(Browser4Target, ".exe") + 4)) & " "
            If strURL <> "" Then
                Process.Start(Browser4Target.Substring(0, InStr(Browser4Target, ".exe") + 4), strParameters & """" & strURL & """")
            Else
                Process.Start(Browser4Target.Substring(0, InStr(Browser4Target, ".exe") + 4), strParameters)
            End If
        Else
            If strURL <> "" Then
                Process.Start(Browser4Target, """" & strURL & """")
            Else
                Process.Start(Browser4Target)
            End If
        End If
        Me.Close()
    End Sub

    Private Sub btnApp5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp5.Click
        If Browser1Target.Contains(".exe ") Then
            strParameters = Browser5Target.Substring(InStr(Browser5Target, ".exe") + 4, Browser5Target.Length - (InStr(Browser5Target, ".exe") + 4)) & " "
            If strURL <> "" Then
                Process.Start(Browser5Target.Substring(0, InStr(Browser5Target, ".exe") + 4), strParameters & """" & strURL & """")
            Else
                Process.Start(Browser5Target.Substring(0, InStr(Browser5Target, ".exe") + 4), strParameters)
            End If
        Else
            If strURL <> "" Then
                Process.Start(Browser5Target, """" & strURL & """")
            Else
                Process.Start(Browser5Target)
            End If
        End If

        Me.Close()
    End Sub


    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Q Then
            MsgBox("test")
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim firstChar As String = e.KeyData.ToString()

        If (e.KeyCode = Keys.D1 Or Browser1Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) And Browser1 = True Then
            btnApp1_Click(sender, e)
        ElseIf (e.KeyCode = Keys.D2 Or Browser2Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) And Browser2 = True Then
            btnApp2_Click(sender, e)
        ElseIf (e.KeyCode = Keys.D3 Or Browser3Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) And Browser3 = True Then
            btnApp3_Click(sender, e)
        ElseIf (e.KeyCode = Keys.D4 Or Browser4Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) And Browser4 = True Then
            btnApp4_Click(sender, e)
        ElseIf (e.KeyCode = Keys.D5 Or Browser5Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) And Browser5 = True Then
            btnApp5_Click(sender, e)
        End If
    End Sub

    
End Class

