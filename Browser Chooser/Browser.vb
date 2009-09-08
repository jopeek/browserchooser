Public Class Browser
    Private nameValue As String
    Public Property Name() As String
        Get
            Return nameValue
        End Get
        Set(ByVal value As String)
            nameValue = value
        End Set
    End Property
    Private pathValue As String
    Public Property Path() As String
        Get
            Return pathValue
        End Get
        Set(ByVal value As String)
            pathValue = value
        End Set
    End Property


    Public Sub New()

    End Sub
    Public Sub New(ByVal Name As String, ByVal Path As String)
        MyClass.nameValue = Name
        MyClass.pathValue = Path
    End Sub

    Public Overrides Function ToString() As String
        Return Name
    End Function
End Class