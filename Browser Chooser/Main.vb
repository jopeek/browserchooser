Imports System.Runtime.InteropServices


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

    'Testing code starts here
    'Private Browser1Name As String = My.Settings.Browser1Name
    'Private Browser1Target As String = "C:\Documents and Settings\jpeek\Local Settings\Application Data\Google\Chrome\Application\chrome.exe"
    'Private Browser1Image As String = "Google Chrome"
    'Private Browser1Disable As Boolean = False

    'Private Browser2Name As String = My.Settings.Browser2Name
    'Private Browser2Target As String = "c:\Program Files\Mozilla Firefox\firefox.exe"
    'Private Browser2Image As String = "Firefox"
    'Private Browser2Disable As Boolean = False

    'Private Browser3Name As String = My.Settings.Browser3Name
    'Private Browser3Target As String = "c:\Program Files\Internet Explorer\iexplore.exe"
    'Private Browser3Image As String = "Internet Explorer"
    'Private Browser3Disable As Boolean = False

    'Private Browser4Name As String = My.Settings.Browser4Name
    'Private Browser4Target As String = "c:\Program Files\Internet Explorer\iexplore.exe"
    'Private Browser4Image As String = "Safari"
    'Private Browser4Disable As Boolean = False
    'Testing code ends here

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        About.ShowDialog()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()

    End Sub

    Private Sub btnApp1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.MouseHover, btnApp1.MouseEnter
        Me.Text = "Open in " & My.Settings.Browser1Name
    End Sub

    Private Sub btnApp1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp1.MouseLeave
        Me.Text = "Choose a Browser"
    End Sub

    Private Sub btnApp2_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.MouseHover, btnApp2.MouseEnter
        Me.Text = "Open in " & My.Settings.Browser2Name
    End Sub

    Private Sub btnApp2_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.MouseLeave
        Me.Text = "Choose a Browser"
    End Sub

    Private Sub btnApp3_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.MouseHover, btnApp3.MouseEnter
        Me.Text = "Open in " & My.Settings.Browser3Name
    End Sub

    Private Sub btnApp3_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.MouseLeave
        Me.Text = "Choose a Browser"
    End Sub

    Private Sub btnApp4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.MouseHover, btnApp4.MouseEnter
        Me.Text = "Open in " & My.Settings.Browser4Name
    End Sub

    Private Sub btnApp4_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.MouseLeave
        Me.Text = "Choose a Browser"
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

        'Initialize browser buttons
        If My.Settings.Browser1Disable And My.Settings.Browser2Disable And My.Settings.Browser3Disable And My.Settings.Browser4Disable Then
            lblEmpty.Visible = True
        End If

        If My.Settings.Browser1Disable = False Then
            btnApp1.Visible = True
            Select Case My.Settings.Browser1Image
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
        End If
        If My.Settings.Browser2Disable = False Then
            btnApp2.Visible = True
            Select Case My.Settings.Browser2Image
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
        End If
        If My.Settings.Browser3Disable = False Then
            btnApp3.Visible = True
            Select Case My.Settings.Browser3Image
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
        End If
        If My.Settings.Browser4Disable = False Then
            btnApp4.Visible = True
            Select Case My.Settings.Browser4Image
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
        End If

        'Load url from parameter
        For i = 0 To My.Application.CommandLineArgs.Count - 1
            strURL = My.Application.CommandLineArgs.Item(i).ToString
        Next i
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
            System.Diagnostics.Process.Start(My.Settings.Browser1Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(My.Settings.Browser1Target)
        End If

        Me.Close()
    End Sub

    Private Sub btnApp2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp2.Click
        If strURL <> "" Then
            System.Diagnostics.Process.Start(My.Settings.Browser2Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(My.Settings.Browser2Target)
        End If
        Me.Close()
    End Sub

    Private Sub btnApp3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp3.Click
        If strURL <> "" Then
            System.Diagnostics.Process.Start(My.Settings.Browser3Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(My.Settings.Browser3Target)
        End If
        Me.Close()
    End Sub

    Private Sub btnApp4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApp4.Click
        If strURL <> "" Then
            System.Diagnostics.Process.Start(My.Settings.Browser4Target, """" & strURL & """")
        Else
            System.Diagnostics.Process.Start(My.Settings.Browser4Target)
        End If
        Me.Close()
    End Sub


    Private Sub TextBox1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Q Then
            MsgBox("test")
        End If
    End Sub

    Private Sub frmMain_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.D1 And My.Settings.Browser1Disable = False Then
            btnApp1_Click(sender, e)
        ElseIf e.KeyCode = Keys.D2 And My.Settings.Browser2Disable = False Then
            btnApp2_Click(sender, e)
        ElseIf e.KeyCode = Keys.D3 And My.Settings.Browser3Disable = False Then
            btnApp3_Click(sender, e)
        ElseIf e.KeyCode = Keys.D4 And My.Settings.Browser4Disable = False Then
            btnApp4_Click(sender, e)
        End If
    End Sub


End Class

