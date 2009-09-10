Public Class Browser : Implements IComparable(Of Browser)

    Private _browserNumber As Integer
    Public Property BrowserNumber() As Integer
        Get
            Return _browserNumber
        End Get
        Set(ByVal value As Integer)
            _browserNumber = value
        End Set
    End Property

    Private _name As String
    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property

    Private _target As String
    Public Property Target() As String
        Get
            Return _target
        End Get
        Set(ByVal value As String)
            _target = value
        End Set
    End Property

    Private _image As String
    Public Property Image() As String
        Get
            Return _image
        End Get
        Set(ByVal value As String)
            _image = value
        End Set
    End Property

    Private _urls As List(Of String) = New List(Of String)
    Public Property Urls() As List(Of String)
        Get
            Return _urls
        End Get
        Set(ByVal value As List(Of String))
            _urls = value
        End Set
    End Property


    Public Function UrlsToString() As String
        If (Urls Is Nothing OrElse Urls.Count = 0) Then
            Return String.Empty
        Else
            Return String.Join(",", Urls.ToArray())
        End If
    End Function

    Public Shared Function StringToUrls(ByVal urlList As String) As List(Of String)
        If (String.IsNullOrEmpty(urlList)) Then
            Return New List(Of String)
        Else
            Return urlList.Split(",").ToList()
        End If
    End Function


    Private _isActive As Boolean = False
    Public Property IsActive() As Boolean
        Get
            Return _isActive
        End Get
        Set(ByVal value As Boolean)
            _isActive = value
        End Set
    End Property

    Function CompareTo(ByVal other As Browser) As Integer Implements IComparable(Of Browser).CompareTo
        Return BrowserNumber.CompareTo(other.BrowserNumber)
    End Function
End Class