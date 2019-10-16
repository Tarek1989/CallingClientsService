Imports EsoftProject

Public Class Address : Implements IAddress

    Private _DellAddress1 As String
    Private _DellAddress2 As String
    Private _DelTown As String
    Private _DelCity As String
    Private _DelPostCode As String
    Private _DelCountry As String
    Private _PostalAddress1 As String
    Private _PostalAddress2 As String
    Private _PostalTown As String
    Private _PostalCity As String
    Private _PostalPostCode As String
    Private _PostalCountry As String
    Private _POBOX As String
    Private _POBOXPostCode As String
    Private _POBOXCity As String
    Private _WorkPhone As String
    Private _HomePhone As String
    Private _MobilePhone As String
    Private _Fax As String
    Private _Email As String
    Private _Url As String
    Private _CompanyRegNo As String
    Private _VatRegNo As String
    Private _Notes As String
    Private _Text1 As String
    Private _Text2 As String
    Private _Text3 As String
    Private _Text4 As String
    Private _Text5 As String
    Private _Text6 As String
    Private _Text7 As String
    Private _Text8 As String
    Private _Text9 As String
    Private _Text10 As String
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
    Private _LicenceNo As String
    Private _RegNoID As String



    Public Property DellAddress1 As String Implements IAddress.DellAddress1
        Get
            Return _DellAddress1
        End Get
        Set(value As String)
            _DellAddress1 = value
        End Set
    End Property

    Public Property DellAddress2 As String Implements IAddress.DellAddress2
        Get
            Return _DellAddress2
        End Get
        Set(value As String)
            _DellAddress2 = value
        End Set
    End Property

    Public Property DelTown As String Implements IAddress.DelTown
        Get
            Return _DelTown
        End Get
        Set(value As String)
            _DelTown = value
        End Set
    End Property

    Public Property DelCity As String Implements IAddress.DelCity
        Get
            Return _DelCity
        End Get
        Set(value As String)
            _DelCity = value
        End Set
    End Property

    Public Property DelPostCode As String Implements IAddress.DelPostCode
        Get
            Return _DelPostCode
        End Get
        Set(value As String)
            _DelPostCode = value
        End Set
    End Property

    Public Property DelCountry As String Implements IAddress.DelCountry
        Get
            Return _DelCountry
        End Get
        Set(value As String)
            _DelCountry = value
        End Set
    End Property

    Public Property PostalAddress1 As String Implements IAddress.PostalAddress1
        Get
            Return _PostalAddress1
        End Get
        Set(value As String)
            _PostalAddress1 = value
        End Set
    End Property

    Public Property PostalAddress2 As String Implements IAddress.PostalAddress2
        Get
            Return _PostalAddress2
        End Get
        Set(value As String)
            _PostalAddress2 = value
        End Set
    End Property

    Public Property PostalTown As String Implements IAddress.PostalTown
        Get
            Return _PostalTown
        End Get
        Set(value As String)
            _PostalTown = value
        End Set
    End Property

    Public Property PostalCity As String Implements IAddress.PostalCity
        Get
            Return _PostalCity
        End Get
        Set(value As String)
            _PostalCity = value
        End Set
    End Property

    Public Property PostalPostCode As String Implements IAddress.PostalPostCode
        Get
            Return _PostalPostCode
        End Get
        Set(value As String)
            _PostalPostCode = value
        End Set
    End Property

    Public Property PostalCountry As String Implements IAddress.PostalCountry
        Get
            Return _PostalCountry
        End Get
        Set(value As String)
            _PostalCountry = value
        End Set
    End Property

    Public Property POBOX As String Implements IAddress.POBOX
        Get
            Return _POBOX
        End Get
        Set(value As String)
            _POBOX = value
        End Set
    End Property

    Public Property POBOXPostCode As String Implements IAddress.POBOXPostCode
        Get
            Return _POBOXPostCode
        End Get
        Set(value As String)
            _POBOXPostCode = value
        End Set
    End Property

    Public Property POBOXCity As String Implements IAddress.POBOXCity
        Get
            Return _POBOXCity
        End Get
        Set(value As String)
            _POBOXCity = value
        End Set
    End Property

    Public Property WorkPhone As String Implements IAddress.WorkPhone
        Get
            Return _WorkPhone
        End Get
        Set(value As String)
            _WorkPhone = value
        End Set
    End Property

    Public Property HomePhone As String Implements IAddress.HomePhone
        Get
            Return _HomePhone
        End Get
        Set(value As String)
            _HomePhone = value
        End Set
    End Property

    Public Property MobilePhone As String Implements IAddress.MobilePhone
        Get
            Return _MobilePhone
        End Get
        Set(value As String)
            _MobilePhone = value
        End Set
    End Property

    Public Property Fax As String Implements IAddress.Fax
        Get
            Return _Fax
        End Get
        Set(value As String)
            _Fax = value
        End Set
    End Property

    Public Property Email As String Implements IAddress.Email
        Get
            Return _Email
        End Get
        Set(value As String)
            _Email = value
        End Set
    End Property

    Public Property Url As String Implements IAddress.Url
        Get
            Return _Url
        End Get
        Set(value As String)
            _Url = value
        End Set
    End Property

    Public Property CompanyRegNo As String Implements IAddress.CompanyRegNo
        Get
            Return _CompanyRegNo
        End Get
        Set(value As String)
            _CompanyRegNo = value
        End Set
    End Property

    Public Property VatRegNo As String Implements IAddress.VatRegNo
        Get
            Return _VatRegNo
        End Get
        Set(value As String)
            _VatRegNo = value
        End Set
    End Property

    Public Property Notes As String Implements IAddress.Notes
        Get
            Return _Notes
        End Get
        Set(value As String)
            _Notes = value
        End Set
    End Property

    Public Property Text1 As String Implements IAddress.Text1
        Get
            Return _Text1
        End Get
        Set(value As String)
            _Text1 = value
        End Set
    End Property

    Public Property Text2 As String Implements IAddress.Text2
        Get
            Return _Text2
        End Get
        Set(value As String)
            _Text2 = value
        End Set
    End Property

    Public Property Text3 As String Implements IAddress.Text3
        Get
            Return _Text3
        End Get
        Set(value As String)
            _Text3 = value
        End Set
    End Property

    Public Property Text4 As String Implements IAddress.Text4
        Get
            Return _Text4
        End Get
        Set(value As String)
            _Text4 = value
        End Set
    End Property

    Public Property Text5 As String Implements IAddress.Text5
        Get
            Return _Text5
        End Get
        Set(value As String)
            _Text5 = value
        End Set
    End Property

    Public Property Text6 As String Implements IAddress.Text6
        Get
            Return _Text6
        End Get
        Set(value As String)
            _Text6 = value
        End Set
    End Property

    Public Property Text7 As String Implements IAddress.Text7
        Get
            Return _Text7
        End Get
        Set(value As String)
            _Text7 = value
        End Set
    End Property

    Public Property Text8 As String Implements IAddress.Text8
        Get
            Return _Text8
        End Get
        Set(value As String)
            _Text8 = value
        End Set
    End Property

    Public Property Text9 As String Implements IAddress.Text9
        Get
            Return _Text9
        End Get
        Set(value As String)
            _Text9 = value
        End Set
    End Property

    Public Property Text10 As String Implements IAddress.Text10
        Get
            Return _Text10
        End Get
        Set(value As String)
            _Text10 = value
        End Set
    End Property

    Public Property Date1 As String Implements IAddress.Date1
        Get
            Return _Date1
        End Get
        Set(value As String)
            _Date1 = value
        End Set
    End Property

    Public Property Date2 As String Implements IAddress.Date2
        Get
            Return _Date2
        End Get
        Set(value As String)
            _Date2 = value
        End Set
    End Property

    Public Property Date3 As String Implements IAddress.Date3
        Get
            Return _Date3
        End Get
        Set(value As String)
            _Date3 = value
        End Set
    End Property

    Public Property Date4 As String Implements IAddress.Date4
        Get
            Return _Date4
        End Get
        Set(value As String)
            _Date4 = value
        End Set
    End Property

    Public Property Date5 As String Implements IAddress.Date5
        Get
            Return _Date5
        End Get
        Set(value As String)
            _Date5 = value
        End Set
    End Property

    Public Property Number1 As Decimal? Implements IAddress.Number1
        Get
            Return _Number1
        End Get
        Set(value As Decimal?)
            _Number1 = value
        End Set
    End Property

    Public Property Number2 As Decimal? Implements IAddress.Number2
        Get
            Return _Number2
        End Get
        Set(value As Decimal?)
            _Number2 = value
        End Set
    End Property

    Public Property Number3 As Decimal? Implements IAddress.Number3
        Get
            Return _Number3
        End Get
        Set(value As Decimal?)
            _Number3 = value
        End Set
    End Property

    Public Property Number4 As Decimal? Implements IAddress.Number4
        Get
            Return _Number4
        End Get
        Set(value As Decimal?)
            _Number4 = value
        End Set
    End Property

    Public Property Number5 As Decimal? Implements IAddress.Number5
        Get
            Return _Number5
        End Get
        Set(value As Decimal?)
            _Number5 = value
        End Set
    End Property

    Public Property LicenceNo As String Implements IAddress.LicenceNo
        Get
            Return _LicenceNo
        End Get
        Set(value As String)
            _LicenceNo = value
        End Set
    End Property

    Public Property RegNoID As String Implements IAddress.RegNoID
        Get
            Return _RegNoID
        End Get
        Set(value As String)
            _RegNoID = value
        End Set
    End Property
End Class
