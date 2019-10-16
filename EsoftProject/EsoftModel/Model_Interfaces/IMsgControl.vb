Public Interface IMsgControl
    Property result As Integer
    Property Message As String
    Property MethodName As String
    Property AppName As String

    Property EsoftUser As String

    Property User As String
    Property Password As String
    Property SystemDate As Date

    Property GenList As List(Of List(Of String))
    Property GenMsg1 As String
    Property GenMsg2 As String
    Property GenMsg3 As String
End Interface
