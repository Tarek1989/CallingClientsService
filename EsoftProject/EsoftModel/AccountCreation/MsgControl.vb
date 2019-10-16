Imports EsoftProject

Public Class MsgControl : Implements IMsgControl

    Private _result As Integer
    Private _Message As String
    Private _MethodName As String
    Private _AppName As String
    Private _EsoftUser As String
    Private _User As String
    Private _Password As String
    Private _SystemDate As Date
    Private _GenList As List(Of List(Of String))
    Private _GenMsg1 As String
    Private _GenMsg2 As String
    Private _GenMsg3 As String

    Public Property result As Integer Implements IMsgControl.result
        Get
            Return _result
        End Get
        Set(value As Integer)
            _result = value
        End Set
    End Property

    Public Property Message As String Implements IMsgControl.Message
        Get
            Return _Message
        End Get
        Set(value As String)
            _Message = value
        End Set
    End Property

    Public Property MethodName As String Implements IMsgControl.MethodName
        Get
            Return _MethodName
        End Get
        Set(value As String)
            _MethodName = value
        End Set
    End Property

    Public Property AppName As String Implements IMsgControl.AppName
        Get
            Return _AppName
        End Get
        Set(value As String)
            _AppName = value
        End Set
    End Property

    Public Property EsoftUser As String Implements IMsgControl.EsoftUser
        Get
            Return _EsoftUser
        End Get
        Set(value As String)
            _EsoftUser = value
        End Set
    End Property

    Public Property User As String Implements IMsgControl.User
        Get
            Return _User
        End Get
        Set(value As String)
            _User = value
        End Set
    End Property

    Public Property Password As String Implements IMsgControl.Password
        Get
            Return _Password
        End Get
        Set(value As String)
            _Password = value
        End Set
    End Property

    Public Property SystemDate As Date Implements IMsgControl.SystemDate
        Get
            Return _SystemDate
        End Get
        Set(value As Date)
            _SystemDate = value
        End Set
    End Property

    Public Property GenList As List(Of List(Of String)) Implements IMsgControl.GenList
        Get
            Return _GenList
        End Get
        Set(value As List(Of List(Of String)))
            _GenList = value
        End Set
    End Property

    Public Property GenMsg1 As String Implements IMsgControl.GenMsg1
        Get
            Return _GenMsg1
        End Get
        Set(value As String)
            _GenMsg1 = value
        End Set
    End Property

    Public Property GenMsg2 As String Implements IMsgControl.GenMsg2
        Get
            Return _GenMsg2
        End Get
        Set(value As String)
            _GenMsg2 = value
        End Set
    End Property

    Public Property GenMsg3 As String Implements IMsgControl.GenMsg3
        Get
            Return _GenMsg3
        End Get
        Set(value As String)
            _GenMsg3 = value
        End Set
    End Property
End Class
