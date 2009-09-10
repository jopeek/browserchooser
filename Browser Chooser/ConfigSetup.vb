Imports System.IO

Public Class ConfigSetup

    Private Function GetRowValue(ByVal sLine As String) As String
        Dim i As Integer = sLine.IndexOf("=")
        If i <> -1 Then
            GetRowValue = sLine.Substring(0, i)
        Else
            GetRowValue = ""
        End If
    End Function

    'import config.ini file into new object/xml based format
    Public Function readConfig() As BrowserList
        Dim importedConfig As BrowserList = New BrowserList
        Try
            Dim Browser1 As Browser = New Browser With {.BrowserNumber = 1, .IsActive = True}
            Dim Browser2 As Browser = New Browser With {.BrowserNumber = 2, .IsActive = True}
            Dim Browser3 As Browser = New Browser With {.BrowserNumber = 3, .IsActive = True}
            Dim Browser4 As Browser = New Browser With {.BrowserNumber = 4, .IsActive = True}
            Dim Browser5 As Browser = New Browser With {.BrowserNumber = 5, .IsActive = True}

            Using sr As StreamReader = New StreamReader(ConfigFile.ToString)
                Dim sLine As String = sr.ReadLine

                Do While Not sLine Is Nothing
                    Select Case GetRowValue(sLine)
                        Case "DefaultBrowser"
                            importedConfig.DefaultBrowser = sLine.Substring(15, sLine.Length - 15)
                        Case "ShowURL"
                            importedConfig.ShowUrl = sLine.Substring(8, sLine.Length - 8)
                        Case "AutoUpdateCheck"
                            importedConfig.AutoUpdateCheck = sLine.Substring(16, sLine.Length - 16)
                        Case "Browser1Name"
                            Browser1.Name = sLine.Substring(13, sLine.Length - 13)
                        Case "Browser2Name"
                            Browser2.Name = sLine.Substring(13, sLine.Length - 13)
                        Case "Browser3Name"
                            Browser3.Name = sLine.Substring(13, sLine.Length - 13)
                        Case "Browser4Name"
                            Browser4.Name = sLine.Substring(13, sLine.Length - 13)
                        Case "Browser5Name"
                            Browser5.Name = sLine.Substring(13, sLine.Length - 13)

                        Case "Browser1Target"
                            Browser1.Target = sLine.Substring(15, sLine.Length - 15)
                        Case "Browser2Target"
                            Browser2.Target = sLine.Substring(15, sLine.Length - 15)
                        Case "Browser3Target"
                            Browser3.Target = sLine.Substring(15, sLine.Length - 15)
                        Case "Browser4Target"
                            Browser4.Target = sLine.Substring(15, sLine.Length - 15)
                        Case "Browser5Target"
                            Browser5.Target = sLine.Substring(15, sLine.Length - 15)

                        Case "Browser1Image"
                            Browser1.Image = sLine.Substring(14, sLine.Length - 14)
                        Case "Browser2Image"
                            Browser2.Image = sLine.Substring(14, sLine.Length - 14)
                        Case "Browser3Image"
                            Browser3.Image = sLine.Substring(14, sLine.Length - 14)
                        Case "Browser4Image"
                            Browser4.Image = sLine.Substring(14, sLine.Length - 14)
                        Case "Browser5Image"
                            Browser5.Image = sLine.Substring(14, sLine.Length - 14)

                    End Select
                    sLine = sr.ReadLine
                Loop
                sr.Close()
            End Using

            If (Not String.IsNullOrEmpty(Browser1.Name)) Then importedConfig.Browsers.Add(Browser1)
            If (Not String.IsNullOrEmpty(Browser2.Name)) Then importedConfig.Browsers.Add(Browser2)
            If (Not String.IsNullOrEmpty(Browser3.Name)) Then importedConfig.Browsers.Add(Browser3)
            If (Not String.IsNullOrEmpty(Browser4.Name)) Then importedConfig.Browsers.Add(Browser4)
            If (Not String.IsNullOrEmpty(Browser5.Name)) Then importedConfig.Browsers.Add(Browser5)

            importedConfig.Save(Application.StartupPath)

            'Remove existing config.ini
            If ConfigFile.Exists Then
                ConfigFile.Delete()
            End If

        Catch ex As Exception

        End Try
        Return importedConfig
    End Function
End Class