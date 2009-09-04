Module Module1

    Friend DefaultMessage As String = "Choose a Browser"

    Friend ConfigFile As New IO.FileInfo(Application.StartupPath & "\config.ini")

    Friend IsDefaultBrowser As Boolean = False

    Friend Browser1 As Boolean = False
    Friend Browser2 As Boolean = False
    Friend Browser3 As Boolean = False
    Friend Browser4 As Boolean = False
    Friend Browser5 As Boolean = False

    Friend Browser1Name As String = ""
    Friend Browser2Name As String = ""
    Friend Browser3Name As String = ""
    Friend Browser4Name As String = ""
    Friend Browser5Name As String = ""

    Friend Browser1Target As String = ""
    Friend Browser2Target As String = ""
    Friend Browser3Target As String = ""
    Friend Browser4Target As String = ""
    Friend Browser5Target As String = ""

    Friend Browser1Image As String = ""
    Friend Browser2Image As String = ""
    Friend Browser3Image As String = ""
    Friend Browser4Image As String = ""
    Friend Browser5Image As String = ""

End Module
