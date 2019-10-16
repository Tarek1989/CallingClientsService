Imports EsoftProject

Public Class PostJournalAccLinesModel : Implements IPostJournalAccLinesData

    Private _AccountCode As String
    Private _DocumentDate As Date
    Private _DueDate As Date
    Private _Currency As String
    Private _Rate As Decimal
    Private _BaseAmount As Decimal
    Private _ForeignAmount As Decimal
    Private _Sign As String
    Private _VatCode As String
    Private _VatRate As Decimal
    Private _VatAmount As Decimal
    Private _Details As String
    Private _Reference As String
    Private _OtherReference As String
    Private _Analysis1 As String
    Private _Analysis2 As String
    Private _Analysis3 As String
    Private _Analysis4 As String
    Private _Analysis5 As String
    Private _Analysis6 As String
    Private _Analysis7 As String
    Private _Analysis8 As String
    Private _Analysis9 As String
    Public Property AccountCode As String Implements IPostJournalAccLinesData.AccountCode
        Get
            Return _AccountCode
        End Get
        Set(value As String)
            _AccountCode = value
        End Set
    End Property

    Public Property DocumentDate As Date Implements IPostJournalAccLinesData.DocumentDate
        Get
            Return _DocumentDate
        End Get
        Set(value As Date)
            _DocumentDate = value
        End Set
    End Property

    Public Property DueDate As Date Implements IPostJournalAccLinesData.DueDate
        Get
            Return _DueDate
        End Get
        Set(value As Date)
            _DueDate = value
        End Set
    End Property

    Public Property Currency As String Implements IPostJournalAccLinesData.Currency
        Get
            Return _Currency
        End Get
        Set(value As String)
            _Currency = value
        End Set
    End Property

    Public Property Rate As Decimal Implements IPostJournalAccLinesData.Rate
        Get
            Return _Rate
        End Get
        Set(value As Decimal)
            _Rate = value
        End Set
    End Property

    Public Property BaseAmount As Decimal Implements IPostJournalAccLinesData.BaseAmount
        Get
            Return _BaseAmount
        End Get
        Set(value As Decimal)
            _BaseAmount = value
        End Set
    End Property

    Public Property ForeignAmount As Decimal Implements IPostJournalAccLinesData.ForeignAmount
        Get
            Return _ForeignAmount
        End Get
        Set(value As Decimal)
            _ForeignAmount = value
        End Set
    End Property

    Public Property Sign As String Implements IPostJournalAccLinesData.Sign
        Get
            Return _Sign
        End Get
        Set(value As String)
            _Sign = value
        End Set
    End Property

    Public Property VatCode As String Implements IPostJournalAccLinesData.VatCode
        Get
            Return _VatCode
        End Get
        Set(value As String)
            _VatCode = value
        End Set
    End Property

    Public Property VatRate As Decimal Implements IPostJournalAccLinesData.VatRate
        Get
            Return _VatRate
        End Get
        Set(value As Decimal)
            _VatRate = value
        End Set
    End Property

    Public Property VatAmount As Decimal Implements IPostJournalAccLinesData.VatAmount
        Get
            Return _VatAmount
        End Get
        Set(value As Decimal)
            _VatAmount = value
        End Set
    End Property

    Public Property Details As String Implements IPostJournalAccLinesData.Details
        Get
            Return _Details
        End Get
        Set(value As String)
            _Details = value
        End Set
    End Property

    Public Property Reference As String Implements IPostJournalAccLinesData.Reference
        Get
            Return _Reference
        End Get
        Set(value As String)
            _Reference = value
        End Set
    End Property

    Public Property OtherReference As String Implements IPostJournalAccLinesData.OtherReference
        Get
            Return _OtherReference
        End Get
        Set(value As String)
            _OtherReference = value
        End Set
    End Property

    Public Property Analysis1 As String Implements IPostJournalAccLinesData.Analysis1
        Get
            Return _Analysis1
        End Get
        Set(value As String)
            _Analysis1 = value
        End Set
    End Property

    Public Property Analysis2 As String Implements IPostJournalAccLinesData.Analysis2
        Get
            Return _Analysis2
        End Get
        Set(value As String)
            _Analysis1 = value
        End Set
    End Property

    Public Property Analysis3 As String Implements IPostJournalAccLinesData.Analysis3
        Get
            Return _Analysis3
        End Get
        Set(value As String)
            _Analysis3 = value
        End Set
    End Property

    Public Property Analysis4 As String Implements IPostJournalAccLinesData.Analysis4
        Get
            Return _Analysis4
        End Get
        Set(value As String)
            _Analysis4 = value
        End Set
    End Property

    Public Property Analysis5 As String Implements IPostJournalAccLinesData.Analysis5
        Get
            Return _Analysis5
        End Get
        Set(value As String)
            _Analysis5 = value
        End Set
    End Property

    Public Property Analysis6 As String Implements IPostJournalAccLinesData.Analysis6
        Get
            Return _Analysis6
        End Get
        Set(value As String)
            _Analysis6 = value
        End Set
    End Property

    Public Property Analysis7 As String Implements IPostJournalAccLinesData.Analysis7
        Get
            Return _Analysis7
        End Get
        Set(value As String)
            _Analysis7 = value
        End Set
    End Property

    Public Property Analysis8 As String Implements IPostJournalAccLinesData.Analysis8
        Get
            Return _Analysis8
        End Get
        Set(value As String)
            _Analysis8 = value
        End Set
    End Property

    Public Property Analysis9 As String Implements IPostJournalAccLinesData.Analysis9
        Get
            Return _Analysis9
        End Get
        Set(value As String)
            _Analysis9 = value
        End Set
    End Property
End Class
