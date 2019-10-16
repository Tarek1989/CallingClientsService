Imports EsoftProject

Public Class PostAccModel : Implements IPostAccData

    Public msgControl As New MsgControl

    Private _Company As String
    Private _Code As String
    Private _Name1 As String
    Private _Name2 As String
    Private _AccountType As String
    Private _AccountShort As String
    Private _Currency As String
    Private _DefaultVatCode As String
    Private _AccGroup1 As String
    Private _AccGroup2 As String
    Private _AccGroup3 As String
    Private _AccGroup4 As String
    Private _AccGroup5 As String
    Private _AccGroup6 As String
    Private _AccGroup7 As String
    Private _AccGroup8 As String
    Private _AccGroup9 As String
    Private _Text1 As String
    Private _Text2 As String
    Private _Text3 As String
    Private _Text4 As String
    Private _Text5 As String
    Private _Text6 As String
    Private _Text7 As String
    Private _Text8 As String
    Private _Text9 As String
    Private _Date1 As String
    Private _Date2 As String
    Private _Date3 As String
    Private _Date4 As String
    Private _Date5 As String
    Private _Number1 As Decimal?
    Private _Number2 As Decimal?
    Private _Number3 As Decimal?
    Private _Number4 As Decimal?
    Private _Number5 As Decimal?
    Private _ActiveAnalysis1 As Boolean
    Private _ActiveAnalysis2 As Boolean
    Private _ActiveAnalysis3 As Boolean
    Private _ActiveAnalysis4 As Boolean
    Private _ActiveAnalysis5 As Boolean
    Private _ActiveAnalysis6 As Boolean
    Private _ActiveAnalysis7 As Boolean
    Private _ActiveAnalysis8 As Boolean
    Private _ActiveAnalysis9 As Boolean
    Private _Notes As String
    Private _IBAN As String
    Private _SWIFT As String




    Public Property Company As String Implements IPostAccData.Company
        Get
            Return _Company
        End Get
        Set(value As String)
            _Company = value
        End Set
    End Property

    Public Property Code As String Implements IPostAccData.Code
        Get
            Return _Code
        End Get
        Set(value As String)
            _Code = value
        End Set
    End Property

    Public Property Name1 As String Implements IPostAccData.Name1
        Get
            Return _Name1
        End Get
        Set(value As String)
            _Name1 = value
        End Set
    End Property

    Public Property Name2 As String Implements IPostAccData.Name2
        Get
            Return _Name2
        End Get
        Set(value As String)
            _Name2 = value
        End Set
    End Property

    Public Property AccountType As String Implements IPostAccData.AccountType
        Get
            Return _AccountType
        End Get
        Set(value As String)
            _AccountType = value
        End Set
    End Property

    Public Property AccountShort As String Implements IPostAccData.AccountShort
        Get
            Return _AccountShort
        End Get
        Set(value As String)
            _AccountShort = value
        End Set
    End Property

    Public Property Currency As String Implements IPostAccData.Currency
        Get
            Return _Currency
        End Get
        Set(value As String)
            _Currency = value
        End Set
    End Property

    Public Property DefaultVatCode As String Implements IPostAccData.DefaultVatCode
        Get
            Return _DefaultVatCode
        End Get
        Set(value As String)
            _DefaultVatCode = value
        End Set
    End Property

    Public Property AccGroup1 As String Implements IPostAccData.AccGroup1
        Get
            Return _AccGroup1
        End Get
        Set(value As String)
            _AccGroup1 = value
        End Set
    End Property

    Public Property AccGroup2 As String Implements IPostAccData.AccGroup2
        Get
            Return _AccGroup2
        End Get
        Set(value As String)
            _AccGroup2 = value
        End Set
    End Property

    Public Property AccGroup3 As String Implements IPostAccData.AccGroup3
        Get
            Return _AccGroup3
        End Get
        Set(value As String)
            _AccGroup3 = value
        End Set
    End Property

    Public Property AccGroup4 As String Implements IPostAccData.AccGroup4
        Get
            Return _AccGroup4
        End Get
        Set(value As String)
            _AccGroup4 = value
        End Set
    End Property

    Public Property AccGroup5 As String Implements IPostAccData.AccGroup5
        Get
            Return _AccGroup5
        End Get
        Set(value As String)
            _AccGroup5 = value
        End Set
    End Property

    Public Property AccGroup6 As String Implements IPostAccData.AccGroup6
        Get
            Return _AccGroup6
        End Get
        Set(value As String)
            _AccGroup6 = value
        End Set
    End Property

    Public Property AccGroup7 As String Implements IPostAccData.AccGroup7
        Get
            Return _AccGroup7
        End Get
        Set(value As String)
            _AccGroup7 = value
        End Set
    End Property

    Public Property AccGroup8 As String Implements IPostAccData.AccGroup8
        Get
            Return _AccGroup8
        End Get
        Set(value As String)
            _AccGroup8 = value
        End Set
    End Property

    Public Property AccGroup9 As String Implements IPostAccData.AccGroup9
        Get
            Return _AccGroup9
        End Get
        Set(value As String)
            _AccGroup9 = value
        End Set
    End Property

    Public Property Text1 As String Implements IPostAccData.Text1
        Get
            Return _Text1
        End Get
        Set(value As String)
            _Text1 = value
        End Set
    End Property

    Public Property Text2 As String Implements IPostAccData.Text2
        Get
            Return _Text2
        End Get
        Set(value As String)
            _Text2 = value
        End Set
    End Property

    Public Property Text3 As String Implements IPostAccData.Text3
        Get
            Return _Text3
        End Get
        Set(value As String)
            _Text3 = value
        End Set
    End Property

    Public Property Text4 As String Implements IPostAccData.Text4
        Get
            Return _Text4
        End Get
        Set(value As String)
            _Text4 = value
        End Set
    End Property

    Public Property Text5 As String Implements IPostAccData.Text5
        Get
            Return _Text5
        End Get
        Set(value As String)
            _Text5 = value
        End Set
    End Property

    Public Property Text6 As String Implements IPostAccData.Text6
        Get
            Return _Text6
        End Get
        Set(value As String)
            _Text6 = value
        End Set
    End Property

    Public Property Text7 As String Implements IPostAccData.Text7
        Get
            Return _Text7
        End Get
        Set(value As String)
            _Text7 = value
        End Set
    End Property

    Public Property Text8 As String Implements IPostAccData.Text8
        Get
            Return _Text8
        End Get
        Set(value As String)
            _Text8 = value
        End Set
    End Property

    Public Property Text9 As String Implements IPostAccData.Text9
        Get
            Return _Text9
        End Get
        Set(value As String)
            _Text9 = value
        End Set
    End Property

    Public Property Date1 As String Implements IPostAccData.Date1
        Get
            Return _Date1
        End Get
        Set(value As String)
            _Date1 = value
        End Set
    End Property

    Public Property Date2 As String Implements IPostAccData.Date2
        Get
            Return _Date2
        End Get
        Set(value As String)
            _Date2 = value
        End Set
    End Property

    Public Property Date3 As String Implements IPostAccData.Date3
        Get
            Return _Date3
        End Get
        Set(value As String)
            _Date3 = value
        End Set
    End Property

    Public Property Date4 As String Implements IPostAccData.Date4
        Get
            Return _Date4
        End Get
        Set(value As String)
            _Date4 = value
        End Set
    End Property

    Public Property Date5 As String Implements IPostAccData.Date5
        Get
            Return _Date5
        End Get
        Set(value As String)
            _Date5 = value
        End Set
    End Property

    Public Property Number1 As Decimal? Implements IPostAccData.Number1
        Get
            Return _Number1
        End Get
        Set(value As Decimal?)
            _Number1 = value
        End Set
    End Property

    Public Property Number2 As Decimal? Implements IPostAccData.Number2
        Get
            Return _Number2
        End Get
        Set(value As Decimal?)
            _Number2 = value
        End Set
    End Property

    Public Property Number3 As Decimal? Implements IPostAccData.Number3
        Get
            Return _Number3
        End Get
        Set(value As Decimal?)
            _Number3 = value
        End Set
    End Property

    Public Property Number4 As Decimal? Implements IPostAccData.Number4
        Get
            Return _Number4
        End Get
        Set(value As Decimal?)
            _Number4 = value
        End Set
    End Property

    Public Property Number5 As Decimal? Implements IPostAccData.Number5
        Get
            Return _Number5
        End Get
        Set(value As Decimal?)
            _Number5 = value
        End Set
    End Property

    Public Property ActiveAnalysis1 As Boolean Implements IPostAccData.ActiveAnalysis1
        Get
            Return _ActiveAnalysis1
        End Get
        Set(value As Boolean)
            _ActiveAnalysis1 = value
        End Set
    End Property

    Public Property ActiveAnalysis2 As Boolean Implements IPostAccData.ActiveAnalysis2
        Get
            Return _ActiveAnalysis2
        End Get
        Set(value As Boolean)
            _ActiveAnalysis2 = value
        End Set
    End Property

    Public Property ActiveAnalysis3 As Boolean Implements IPostAccData.ActiveAnalysis3
        Get
            Return _ActiveAnalysis3
        End Get
        Set(value As Boolean)
            _ActiveAnalysis3 = value
        End Set
    End Property

    Public Property ActiveAnalysis4 As Boolean Implements IPostAccData.ActiveAnalysis4
        Get
            Return _ActiveAnalysis4
        End Get
        Set(value As Boolean)
            _ActiveAnalysis4 = value
        End Set
    End Property

    Public Property ActiveAnalysis5 As Boolean Implements IPostAccData.ActiveAnalysis5
        Get
            Return _ActiveAnalysis5
        End Get
        Set(value As Boolean)
            _ActiveAnalysis5 = value
        End Set
    End Property

    Public Property ActiveAnalysis6 As Boolean Implements IPostAccData.ActiveAnalysis6
        Get
            Return _ActiveAnalysis6
        End Get
        Set(value As Boolean)
            _ActiveAnalysis6 = value
        End Set
    End Property

    Public Property ActiveAnalysis7 As Boolean Implements IPostAccData.ActiveAnalysis7
        Get
            Return _ActiveAnalysis7
        End Get
        Set(value As Boolean)
            _ActiveAnalysis7 = value
        End Set
    End Property

    Public Property ActiveAnalysis8 As Boolean Implements IPostAccData.ActiveAnalysis8
        Get
            Return _ActiveAnalysis8
        End Get
        Set(value As Boolean)
            _ActiveAnalysis8 = value
        End Set
    End Property

    Public Property ActiveAnalysis9 As Boolean Implements IPostAccData.ActiveAnalysis9
        Get
            Return _ActiveAnalysis9
        End Get
        Set(value As Boolean)
            _ActiveAnalysis9 = value
        End Set
    End Property

    Public Property Notes As String Implements IPostAccData.Notes
        Get
            Return _Notes
        End Get
        Set(value As String)
            _Notes = value
        End Set
    End Property

    Public Property IBAN As String Implements IPostAccData.IBAN
        Get
            Return _IBAN
        End Get
        Set(value As String)
            _IBAN = value
        End Set
    End Property

    Public Property SWIFT As String Implements IPostAccData.SWIFT
        Get
            Return _SWIFT
        End Get
        Set(value As String)
            _SWIFT = value
        End Set
    End Property

    Public Address As New Address
End Class
