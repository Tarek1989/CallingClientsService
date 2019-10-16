Imports EsoftProject

Public Class PostJournalModel : Implements IPostJournalDataHeader

    Public msgControl As New MsgControl

    Private _Company As String
    Private _TranType As String
    Private _PostYear As Integer
    Private _PostPeriod As Integer
    Private _TotalAmount As Integer


    Public Property Company As String Implements IPostJournalDataHeader.Company
        Get
            Return _Company
        End Get
        Set(value As String)
            _Company = value
        End Set
    End Property

    Public Property TranType As String Implements IPostJournalDataHeader.TranType
        Get
            Return _TranType
        End Get
        Set(value As String)
            _TranType = value
        End Set
    End Property

    Public Property PostYear As Integer Implements IPostJournalDataHeader.PostYear
        Get
            Return _PostYear
        End Get
        Set(value As Integer)
            _PostYear = value
        End Set
    End Property

    Public Property PostPeriod As Integer Implements IPostJournalDataHeader.PostPeriod
        Get
            Return _PostPeriod
        End Get
        Set(value As Integer)
            _PostPeriod = value
        End Set
    End Property

    Public Property TotalAmount As Decimal Implements IPostJournalDataHeader.TotalAmount
        Get
            Return _TotalAmount
        End Get
        Set(value As Decimal)
            _TotalAmount = value
        End Set
    End Property

    Public accTranLines As New List(Of PostJournalAccLinesModel)

End Class
