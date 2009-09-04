Imports System.Runtime.InteropServices
Imports System.IO


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


    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        About.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnApp1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.MouseHover, btnApp1.MouseEnter
        Me.Text = "Open in " & Browser1Name
    End Sub

    Private Sub btnApp1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnApp2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.MouseHover, btnApp2.MouseEnter
        Me.Text = "Open in " & Browser2Name
    End Sub

    Private Sub btnApp2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnApp3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.MouseHover, btnApp3.MouseEnter
        Me.Text = "Open in " & Browser3Name
    End Sub

    Private Sub btnApp3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnApp4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.MouseHover, btnApp4.MouseEnter
        Me.Text = "Open in " & Browser4Name
    End Sub

    Private Sub btnApp4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.MouseLeave
        Me.Text = DefaultMessage
    End Sub

    Private Sub btnApp5_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp5.MouseHover, btnApp5.MouseEnter
        Me.Text = "Open in " & Browser5Name
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

    Public Sub InitializeMain()
        'Check for configuration file
        Dim ConfigFile As New IO.FileInfo(Application.StartupPath & "\config.ini")
        If ConfigFile.Exists Then
            Using sr As StreamReader = New StreamReader(ConfigFile.ToString)
                Dim sLine As String = sr.ReadLine

                Do While Not sLine Is Nothing
                    Select Case GetRowValue(sLine)

                        Case "DefaultBrowser"
                            IsDefaultBrowser = sLine.Substring(15, sLine.Length - 15)

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

            If Browser1Image <> "" And Browser1Name <> "" And Browser1Target <> "" Then Browser1 = True Else Browser1 = False
            If Browser2Image <> "" And Browser2Name <> "" And Browser2Target <> "" Then Browser2 = True Else Browser2 = False
            If Browser3Image <> "" And Browser3Name <> "" And Browser3Target <> "" Then Browser3 = True Else Browser3 = False
            If Browser4Image <> "" And Browser4Name <> "" And Browser4Target <> "" Then Browser4 = True Else Browser4 = False
            If Browser5Image <> "" And Browser5Name <> "" And Browser5Target <> "" Then Browser5 = True Else Browser5 = False

        Else

            'Force open Options screen
            Options.ShowDialog()

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
        Me.Text = "Choose a Browser"
    End Sub

    Private Sub btnOptions_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.MouseEnter, btnOptions.MouseHover
        Me.Text = "Options"
    End Sub

    Private Sub btnOptions_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.MouseLeave
        Me.Text = "Choose a Browser"
    End Sub

    Private Sub btnClose_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Text = "Close"
    End Sub

    Private Sub btnClose_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Text = "Choose a Browser"
    End Sub

    Private Sub btnOptions_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOptions.Click
        Options.ShowDialog()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()

    End Sub

    Private Sub btnApp1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.Click
        If strURL <> "" Then
            System.Diagnostics.Process.Start(Browser1Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(Browser1Target)
        End If

        Me.Close()
    End Sub

    Private Sub btnApp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.Click
        If strURL <> "" Then
            System.Diagnostics.Process.Start(Browser2Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(Browser2Target)
        End If
        Me.Close()
    End Sub

    Private Sub btnApp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.Click
        If strURL <> "" Then
            System.Diagnostics.Process.Start(Browser3Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(Browser3Target)
        End If
        Me.Close()
    End Sub

    Private Sub btnApp4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.Click
        If strURL <> "" Then
            System.Diagnostics.Process.Start(Browser4Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(Browser4Target)
        End If
        Me.Close()
    End Sub

    Private Sub btnApp5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp5.Click
        If strURL <> "" Then
            System.Diagnostics.Process.Start(Browser5Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(Browser5Target)
        End If
        Me.Close()
    End Sub


    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Q Then
            MsgBox("test")
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.D1 And Browser1 = True Then
            btnApp1_Click(sender, e)
        ElseIf e.KeyCode = Keys.D2 And Browser2 = True Then
            btnApp2_Click(sender, e)
        ElseIf e.KeyCode = Keys.D3 And Browser3 = True Then
            btnApp3_Click(sender, e)
        ElseIf e.KeyCode = Keys.D4 And Browser4 = True Then
            btnApp4_Click(sender, e)
        ElseIf e.KeyCode = Keys.D5 And Browser5 = True Then
            btnApp5_Click(sender, e)
        End If
    End Sub
End Class

