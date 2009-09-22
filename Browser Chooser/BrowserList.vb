Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Xml.Serialization

Public Class BrowserList
    Private _defaultBrowser As Boolean
    Public Property DefaultBrowser() As Boolean
        Get
            Return _defaultBrowser
        End Get
        Set(ByVal value As Boolean)
            _defaultBrowser = value
        End Set
    End Property

    Private _showUrl As Boolean
    Public Property ShowUrl() As Boolean
        Get
            Return _showUrl
        End Get
        Set(ByVal value As Boolean)
            _showUrl = value
        End Set
    End Property

    Private _autoUpdateCheck As Boolean
    Public Property AutoUpdateCheck() As Boolean
        Get
            Return _autoUpdateCheck
        End Get
        Set(ByVal value As Boolean)
            _autoUpdateCheck = value
        End Set
    End Property

    Private _lastUpdateCheck As DateTime
    Public Property LastUpdateCheck() As DateTime
        Get
            Return _lastUpdateCheck
        End Get
        Set(ByVal value As DateTime)
            _lastUpdateCheck = value
        End Set
    End Property

    Private _intranetBrowser As Browser
    Public Property IntranetBrowser() As Browser
        Get
            Return _intranetBrowser
        End Get
        Set(ByVal value As Browser)
            _intranetBrowser = value
        End Set
    End Property

    Private _browsers As List(Of Browser) = New List(Of Browser)
    Public Property Browsers() As List(Of Browser)
        Get
            Return _browsers
        End Get
        Set(ByVal value As List(Of Browser))
            _browsers = value
        End Set
    End Property

    Public Function GetBrowser(ByVal browserNumber As Integer) As Browser
        Dim browser As Browser = Nothing
        If (Not Me.Browsers Is Nothing) Then
            browser = Me.Browsers.FirstOrDefault(Function(t) t.BrowserNumber = browserNumber)
        End If
        If (browser Is Nothing) Then
            browser = New Browser
        End If
        Return browser
    End Function

    Public Function GetBrowserByUrl(ByVal url As String) As Integer
        If BrowserConfig.IntranetBrowser IsNot Nothing Then
            If IsIntranetUrl(url) Then
                Return BrowserConfig.IntranetBrowser.BrowserNumber
            End If
        End If

        Dim b As Browser = Me.Browsers.FirstOrDefault(Function(c) c.Urls.Any(Function(w) url.ToUpper().Contains(w.Trim().ToUpper())))
        If (b Is Nothing) Then
            Return 0
        Else
            Return b.BrowserNumber
        End If
    End Function

    Public Sub Save(ByVal browserChooserConfigDirectory As String)
        Dim f As New IO.DirectoryInfo(browserChooserConfigDirectory)
        If Not f.Exists Then
            IO.Directory.CreateDirectory(browserChooserConfigDirectory)
        End If
        Dim xmlSerializer As New XmlSerializer(GetType(BrowserList))

        Using writer As Stream = New FileStream(Path.Combine(browserChooserConfigDirectory, BrowserChooserConfigFileName), FileMode.Create)
            Me.Browsers.Sort()
            xmlSerializer.Serialize(writer, Me)
            writer.Close()
        End Using
    End Sub

    Public Shared Function Load(ByVal browserChooserConfigDirectory As String) As BrowserList
        Dim serializer As New XmlSerializer(GetType(BrowserList))

        Dim blist As BrowserList

        Dim configPath As String = Path.Combine(browserChooserConfigDirectory, BrowserChooserConfigFileName)
        If (File.Exists(configPath)) Then
            Using writer As Stream = New FileStream(configPath, FileMode.Open)
                blist = DirectCast(serializer.Deserialize(writer), BrowserList)
                writer.Close()
            End Using
        Else
            blist = New BrowserList
        End If
        Return blist
    End Function
End Class