Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Net
Imports Microsoft.WindowsAPICodePack.Taskbar
Imports Microsoft.WindowsAPICodePack.Shell
Imports System.Threading
Imports System.ComponentModel


Public Class frmMain
    Private browserButtons As List(Of PictureBox)
    Private browserTooltips As List(Of ToolTip)
    Private WithEvents backgroundWorker1 As System.ComponentModel.BackgroundWorker

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

    Private Declare Function DwmIsCompositionEnabled Lib "dwmapi" _
(ByRef pfEnabled As Long) As Long

    Function IsAeroEnabled() As Boolean
        Dim AeroState As Long
        On Error GoTo APImissing
        DwmIsCompositionEnabled(AeroState)
        IsAeroEnabled = CBool(AeroState)
APImissing:
    End Function

    Private Sub styleXP()
        'Me.ControlBox = False
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedSingle
        If Options.OS_Version = "Windows XP" Then
            Me.BackgroundImage = My.Resources.bgxp
        Else
            'Vista or Win 7 with Aero off
            Me.BackgroundImage = My.Resources.bg
        End If
        Me.BackgroundImageLayout = ImageLayout.Tile
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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

        If Not IsAeroEnabled() Then
            styleXP()
        End If

    End Sub

    Private Sub LaunchBrowserInfo(ByVal browserNumber As Integer)
        If BrowserConfig.ShowUrl = True And strShownUrl <> "" Then
            Me.Text = "Open " & BrowserConfig.GetBrowser(browserNumber).Name & " - " & strShownUrl
        Else
            Me.Text = "Open " & BrowserConfig.GetBrowser(browserNumber).Name
        End If
    End Sub

    Private Sub LaunchBrowserAndClose(ByVal browserNumber As Integer, Optional ByVal bClose As Boolean = True)
        If (Not LaunchBrowser(browserNumber)) Then
            MsgBox("The target browser does not exist in the target location.", MsgBoxStyle.Critical)
        Else
            If bClose then
                Me.Close()
            End If
        End If
    End Sub

    Private Function SetImage(ByRef BrowserChoice As Browser) As Image
        Select Case BrowserChoice.Image
            Case "Firefox"
                SetImage = My.Resources.Firefox
            Case "Flock"
                SetImage = My.Resources.Flock
            Case "Internet Explorer"
                SetImage = My.Resources.InternetExplorer
            Case "Google Chrome"
                SetImage = My.Resources.GoogleChrome
            Case "Opera"
                SetImage = My.Resources.Opera
            Case "Safari"
                SetImage = My.Resources.Safari
            Case Else
                If (Not String.IsNullOrEmpty(BrowserChoice.CustomImagePath)) Then
                    'handles absolute or relative paths, 
                    'Path.Combine(path1, path2): If path2 contains an absolute path, this method returns path2
                    Dim cImage As FileInfo = New FileInfo(Path.Combine(Application.StartupPath, BrowserChoice.CustomImagePath))
                    If (cImage.Exists) Then
                        Try
                            Select Case cImage.Extension.ToUpper
                                Case ".PNG"
                                    SetImage = Bitmap.FromFile(cImage.FullName)
                                Case ".ICO"
                                    SetImage = New Icon(cImage.FullName, New Size(75, 80)).ToBitmap()
                                Case Else
                                    'unexpected file format - set icon to error
                                    SetImage = My.Resources._53
                            End Select
                        Catch ex As Exception
                            'file specified not a valid image format - set icon to error
                            SetImage = My.Resources._53
                        End Try
                    Else
                        'file doesn't exist - set icon to error
                        SetImage = My.Resources._53
                    End If
                Else
                    'custom option chosen but no file specified - set icon to error
                    SetImage = My.Resources._53
                End If
        End Select
    End Function


    Public Sub InitializeMain()
        browserButtons = New List(Of PictureBox)
        browserButtons.Add(Nothing)
        browserButtons.Add(btnApp1)
        browserButtons.Add(btnApp2)
        browserButtons.Add(btnApp3)
        browserButtons.Add(btnApp4)
        browserButtons.Add(btnApp5)

        browserTooltips = New List(Of ToolTip)
        browserTooltips.Add(Nothing)
        browserTooltips.Add(btn1TT)
        browserTooltips.Add(btn2TT)
        browserTooltips.Add(btn3TT)
        browserTooltips.Add(btn4TT)
        browserTooltips.Add(btn5TT)

        If (BrowserConfig Is Nothing OrElse BrowserConfig.Browsers.Count = 0) Then
            'Force open Options screen
#If DEBUG Then
            ' this switch allows us to debug Options without having to attach to process due to UAC
            Options.ShowDialog()
#Else
            openOptions()
#End If

        Else
            For index As Integer = 1 To 5
                If (BrowserConfig.GetBrowser(index).IsActive) Then
                    Me.Width = (index * 81) + 112
                    browserButtons(index).Visible = True
                    browserButtons(index).Image = SetImage(BrowserConfig.GetBrowser(index))
                Else
                    browserButtons(index).Visible = False
                End If
            Next
        End If

        If BrowserConfig.AutoUpdateCheck = True Then
            Dim ts As TimeSpan = New TimeSpan(DateTime.Now.Ticks - BrowserConfig.LastUpdateCheck.Ticks)
            If (ts.Days >= DaysBetweenUpdateCheck) Then
                CheckforUpdate("")
            End If
        End If

        btnOptions.Location = New Point(Me.Width - 33, 12)

        'Load url from parameter
        For i = 0 To My.Application.CommandLineArgs.Count - 1
            strUrl = My.Application.CommandLineArgs.Item(i).ToString
        Next i

        strShownUrl = strUrl

        If BrowserConfig.RevealUrl = True And Not String.IsNullOrEmpty(strUrl) Then
            Dim ShortenedHosts As String = "301url.com,6url.com,bit.ly,budurl.com,canurl.com,c-o.in,cli.gs,co.nr,cuttr.info,decenturl.com,dn.vc,doiop.com,dwarfurl.com,easyurl.net,elfurl.com,ff.im,fire.to,flq.us,freak.to,fype.com,gamerdna.com,gonext.org,is.gd,ix.lt,jive.to,kurl.us,lilurl.us,lnkurl.com,memurl.com,miklos.dk,miny.info,myurl.in,nanoref.com,notlong.com,ow.ly,pic.gd,piurl.com,plexp.com,qicute.com,qurlyq.com,readthisurl.com,redir.fr,redirx.com,shorl.com,shorterlink.com,shortlinks.co.uk,shorturl.com,shout.to,shrinkurl.us,shurl.net,simurl.com,smarturl.eu,snipurl.com,snurl.com,starturl.com,surl.co.uk,thurly.net,tighturl.com,tinylink.com,tinypic.com,tinyurl.com,traceurl.com,tr.im,tumblr.com,twurl.nl,url9.com,urlcut.com,urlcutter.com,urlhawk.com,urlpass.com,url-press.com,urlsmash.com,urlsn.com,urltea.com,url.ly,urly.local,yuarel.com,x.se,xaddr.com,xil.in,xrl.us,yatuc.com,yep.it,yweb.com"
            Dim uri As UriBuilder = New UriBuilder(strUrl)
            ShortenedHosts.Split(",").ToList()
            If ShortenedHosts.Contains(uri.Host.ToString) Then
                strShownUrl = "Unshortening " & strUrl & " ...."
                Me.Text = DefaultMessage & " - " & strShownUrl
                backgroundWorker1 = New BackgroundWorker()
                backgroundWorker1.RunWorkerAsync()
            End If
        End If

        If BrowserConfig.ShowUrl = True And Not String.IsNullOrEmpty(strUrl) Then
            Me.Text = DefaultMessage & " - " & strShownUrl
        Else
            Me.Text = DefaultMessage
        End If

        'If no URL is passed in, don't display context menu
        If (String.IsNullOrEmpty(strUrl)) Then
            For index As Integer = 1 To 5
                browserButtons(index).ContextMenuStrip = Nothing
            Next
        End If

        'Set up Tooltips
        For index As Integer = 1 To 5
            If BrowserConfig.GetBrowser(index).IsActive Then
                Dim strToolTip As String

                If BrowserConfig.ShowUrl = True And Not String.IsNullOrEmpty(strUrl) Then
                    strToolTip = String.Format("Open {0} in {1}.{2}Hotkeys: ({3}) or ({4}).", strUrl, BrowserConfig.GetBrowser(index).Name, vbCrLf, index, BrowserConfig.GetBrowser(index).Name.Substring(0, 1))
                Else
                    strToolTip = String.Format("Open {0}.{1}Hotkeys: ({2}) or ({3}).", BrowserConfig.GetBrowser(index).Name, vbCrLf, index, BrowserConfig.GetBrowser(index).Name.Substring(0, 1))
                End If
                browserTooltips(index).SetToolTip(browserButtons(index), strToolTip)
            End If
        Next
    End Sub

    Private Sub btnInfo_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.MouseEnter, btnInfo.MouseHover
        Me.Text = "About"
    End Sub

    Private Sub btnInfo_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.MouseLeave, btnOptions.MouseLeave
        If BrowserConfig.ShowUrl = True And Not String.IsNullOrEmpty(strUrl) Then
            Me.Text = DefaultMessage & " - " & strShownUrl
        Else
            Me.Text = DefaultMessage
        End If
    End Sub

    Private Sub btnOptions_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.MouseEnter, btnOptions.MouseHover
        Me.Text = "Options"
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
#If DEBUG Then
        Options.Show()
#Else
        openOptions()
#End If
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

    Public Sub CheckforUpdate(ByVal strMode As String)
        Try
            Dim client As WebClient = New WebClient()

            Dim strWebVersion As String
            'Switch for Portable
            'If (PortableMode) Then
            '    strWebVersion = client.DownloadString("http://www.janolepeek.com/bcport.txt")
            'Else
            strWebVersion = client.DownloadString("http://www.janolepeek.com/bclatest.txt")
            'End If

            Dim version As System.Version = New System.Version(strWebVersion)
            If version.CompareTo(My.Application.Info.Version) > -1 Then

                If MsgBox("A new version of Browser Chooser is available. Would you like to download it now?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

                    Download.ShowDialog()

                End If
            Else
                If strMode = "verbose" Then
                    MsgBox("You are running the current version of Browser Chooser!", MsgBoxStyle.Information)
                End If
            End If

            BrowserConfig.LastUpdateCheck = DateTime.Now
            Options.SaveConfig()
        Catch ex As Exception
            If strMode = "verbose" Then
                MsgBox("There was an error checking for the latest version." & vbCrLf & vbCrLf & ex.Message, MsgBoxStyle.Critical)
            End If
        End Try

    End Sub

    Private Sub AddUrlToAutoOpenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddUrlToAutoOpenToolStripMenuItem.Click
        If (Not String.IsNullOrEmpty(strUrl)) Then
            'create a new URI object in order to parse out the server portion
            'given a url like: http://www.google.com/test/browser.aspx?a=3&c=6, uri.Host should equal www.google.com
            Dim uri As UriBuilder = Nothing
            Try
                uri = New UriBuilder(strUrl)
            Catch ex As Exception
                MsgBox(String.Format("Error reading {0} as a valid URL.{1}{2}", strUrl, vbCrLf, ex.Message, MsgBoxStyle.Critical))
            End Try

            'get the browser button/picture box that triggered the context menu
            Dim cms As ContextMenuStrip = Nothing
            Dim browserButton As PictureBox = Nothing
            Try
                cms = DirectCast(sender, ToolStripMenuItem).Owner
                browserButton = DirectCast(cms.SourceControl, PictureBox)
            Catch ex As Exception
                MsgBox(String.Format("Unexpected Context Menu Error!{0}{1}", vbCrLf, ex.Message, MsgBoxStyle.Critical))
            End Try

            If (uri IsNot Nothing AndAlso browserButton IsNot Nothing) Then
                Select Case browserButton.Name
                    Case "btnApp1"
                        BrowserConfig.GetBrowser(1).Urls.Add(uri.Host)
                    Case "btnApp2"
                        BrowserConfig.GetBrowser(2).Urls.Add(uri.Host)
                    Case "btnApp3"
                        BrowserConfig.GetBrowser(3).Urls.Add(uri.Host)
                    Case "btnApp4"
                        BrowserConfig.GetBrowser(4).Urls.Add(uri.Host)
                    Case "btnApp5"
                        BrowserConfig.GetBrowser(5).Urls.Add(uri.Host)
                    Case Else
                        MsgBox(String.Format("Browser Not Configured For Auto Add Url.{0}Name={1}", vbCrLf, browserButton.Name, MsgBoxStyle.Information))
                End Select

                'save additions to the url list
                Options.SaveConfig()

                'not sure if this UAC approach is needed here but added it for consistency
                Process.Start(Application.ExecutablePath, strUrl)
                System.Environment.Exit(-1)

            End If
        End If
    End Sub

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        About.ShowDialog()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnApp_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.MouseHover, btnApp1.MouseEnter, btnApp2.MouseHover, btnApp2.MouseEnter, btnApp3.MouseHover, btnApp3.MouseEnter, btnApp4.MouseHover, btnApp4.MouseEnter, btnApp5.MouseHover, btnApp5.MouseEnter
        Dim browserIndex As Integer = browserButtons.IndexOf(sender)
        LaunchBrowserInfo(browserIndex)
    End Sub

    Private Sub btnApp_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.MouseLeave, btnApp2.MouseLeave, btnApp3.MouseLeave, btnApp4.MouseLeave, btnApp5.MouseLeave
        If BrowserConfig.ShowUrl = True And strShownUrl <> "" Then
            Me.Text = DefaultMessage & " - " & strShownUrl
        Else
            Me.Text = DefaultMessage
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnApp_Click(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles btnApp1.MouseClick, btnApp2.MouseClick, btnApp3.MouseClick, btnApp4.MouseClick, btnApp5.MouseClick
        Dim browserIndex As Integer = browserButtons.IndexOf(sender)

        If (My.Computer.Keyboard.CtrlKeyDown) And (e.Button = Windows.Forms.MouseButtons.Left) Then
            LaunchBrowserAndClose(browserIndex, False)
        ElseIf (e.Button = Windows.Forms.MouseButtons.Left) Then
            LaunchBrowserAndClose(browserIndex)
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Dim firstChar As String = e.KeyData.ToString()
        Dim bClose As Boolean = True

        If (My.Computer.Keyboard.CtrlKeyDown) Then
            bClose = False
        End If

        If e.KeyCode = Keys.O Then
            openOptions()
        End If

        If BrowserConfig.GetBrowser(1).IsActive = True AndAlso (e.KeyCode = Keys.D1 Or BrowserConfig.GetBrowser(1).Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) Then
            LaunchBrowserAndClose(1, bClose)
        ElseIf BrowserConfig.GetBrowser(2).IsActive = True AndAlso (e.KeyCode = Keys.D2 Or BrowserConfig.GetBrowser(2).Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) Then
            LaunchBrowserAndClose(2, bClose)
        ElseIf BrowserConfig.GetBrowser(3).IsActive = True AndAlso (e.KeyCode = Keys.D3 Or BrowserConfig.GetBrowser(3).Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) Then
            LaunchBrowserAndClose(3, bClose)
        ElseIf BrowserConfig.GetBrowser(4).IsActive = True AndAlso (e.KeyCode = Keys.D4 Or BrowserConfig.GetBrowser(4).Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) Then
            LaunchBrowserAndClose(4, bClose)
        ElseIf BrowserConfig.GetBrowser(5).IsActive = True AndAlso (e.KeyCode = Keys.D5 Or BrowserConfig.GetBrowser(5).Name.StartsWith(firstChar, StringComparison.InvariantCultureIgnoreCase)) Then
            LaunchBrowserAndClose(5, bClose)
        End If
    End Sub

    Private Sub backgroundWorker1_DoWork(ByVal sender As Object, ByVal e As DoWorkEventArgs) Handles backgroundWorker1.DoWork
        Dim request As WebRequest = WebRequest.Create(strUrl)
        Dim response As WebResponse = Nothing
        Try
            request.Method = WebRequestMethods.Http.Head
            response = request.GetResponse
        Catch ex As WebException
            request = WebRequest.Create(strUrl)
            request.Method = WebRequestMethods.Http.Get
            response = request.GetResponse
        End Try

        e.Result = response.ResponseUri.ToString
        strUrl = response.ResponseUri.ToString
        strShownUrl = response.ResponseUri.ToString
    End Sub

    Private Sub backgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As RunWorkerCompletedEventArgs) Handles backgroundWorker1.RunWorkerCompleted
        ' First, handle the case where an exception was thrown.
        If (e.Error IsNot Nothing) Then
            Me.Text = DefaultMessage & " - " & strUrl
        Else
            Me.Text = DefaultMessage & " - " & e.Result.ToString()
        End If
    End Sub

    Private Sub CopyUrlToClipboardToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CopyUrlToClipboardToolStripMenuItem.Click
        If Not String.IsNullOrEmpty(strUrl) Then
            My.Computer.Clipboard.SetText(strUrl)
        End If
    End Sub

    Private Sub AddJumpLists()
        ' create the jump lists
        If TaskbarManager.IsPlatformSupported Then

            Dim jumpList As JumpList = jumpList.CreateJumpList()

            For Each Browser In BrowserConfig.Browsers
                If Browser.IsActive Then
                    Dim target As String = NormalizeTarget(Browser.Target)

                    Dim strBrowser As String = target
                    Dim strParameters As String = ""

                    If target.Contains(".exe ") Then
                        strBrowser = target.Substring(0, InStr(target, ".exe") + 4)
                        strParameters = target.Substring(InStr(target, ".exe") + 4, target.Length - (InStr(target, ".exe") + 4)) & " "

                    End If

                    jumpList.AddUserTasks(New JumpListLink(NormalizeTarget(strBrowser), "Open " + Browser.Name) With {.IconReference = New IconReference(NormalizeTarget(strBrowser), 0), .Arguments = strParameters})
                End If
            Next

            ' Add our user tasks
            jumpList.Refresh()
        End If
    End Sub

    Private Sub frmMain_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        AddJumpLists()
    End Sub
End Class