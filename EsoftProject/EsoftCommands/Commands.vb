Imports Newtonsoft
Imports Newtonsoft.Json

Public Class Commands

    'This function is to create the Json file to be sent to service
    'In this class the data is coming from INVOICE ACC DATA and INVOICE JOURNAL TRANS

    Public Function PostAcc() As String
        Dim _PostAccData As New PostAccModel
        'Msgcontrol
        _PostAccData.msgControl.result = 0
        _PostAccData.msgControl.Message = "Corresponding success and error message"
        _PostAccData.msgControl.MethodName = ""
        _PostAccData.msgControl.AppName = ""
        _PostAccData.msgControl.EsoftUser = ""
        _PostAccData.msgControl.User = ""
        _PostAccData.msgControl.Password = ""
        _PostAccData.msgControl.SystemDate = DateAndTime.Now
        _PostAccData.msgControl.GenList = Nothing
        _PostAccData.msgControl.GenMsg1 = ""
        _PostAccData.msgControl.GenMsg2 = ""
        _PostAccData.msgControl.GenMsg3 = ""
        'Account
        _PostAccData.Company = "ZZZ"
        _PostAccData.Code = "2"
        _PostAccData.Name1 = "PostAccSucc"
        _PostAccData.Name2 = "PostAccSucc"
        _PostAccData.AccountType = "320"
        _PostAccData.AccountShort = ""
        _PostAccData.Currency = "EUR"
        _PostAccData.DefaultVatCode = ""
        _PostAccData.AccGroup1 = ""
        _PostAccData.AccGroup2 = ""
        _PostAccData.AccGroup3 = ""
        _PostAccData.AccGroup4 = ""
        _PostAccData.AccGroup5 = ""
        _PostAccData.AccGroup6 = ""
        _PostAccData.AccGroup7 = ""
        _PostAccData.AccGroup8 = ""
        _PostAccData.AccGroup9 = ""
        _PostAccData.Text1 = ""
        _PostAccData.Text2 = ""
        _PostAccData.Text3 = ""
        _PostAccData.Text4 = ""
        _PostAccData.Text5 = ""
        _PostAccData.Text6 = ""
        _PostAccData.Text7 = ""
        _PostAccData.Text8 = ""
        _PostAccData.Text9 = ""
        _PostAccData.Date1 = DateAndTime.Now.ToString()
        _PostAccData.Date2 = DateAndTime.Now.ToString()
        _PostAccData.Date3 = DateAndTime.Now.ToString()
        _PostAccData.Date4 = DateAndTime.Now.ToString()
        _PostAccData.Date5 = DateAndTime.Now.ToString()
        _PostAccData.Number1 = 0.0
        _PostAccData.Number2 = 0.0
        _PostAccData.Number3 = 0.0
        _PostAccData.Number4 = 0.0
        _PostAccData.Number5 = 0.0
        _PostAccData.ActiveAnalysis1 = "true"
        _PostAccData.ActiveAnalysis2 = "true"
        _PostAccData.ActiveAnalysis3 = "true"
        _PostAccData.ActiveAnalysis4 = "true"
        _PostAccData.ActiveAnalysis5 = "true"
        _PostAccData.ActiveAnalysis6 = "true"
        _PostAccData.ActiveAnalysis7 = "true"
        _PostAccData.ActiveAnalysis8 = "true"
        _PostAccData.ActiveAnalysis9 = "true"
        _PostAccData.Notes = ""
        _PostAccData.IBAN = ""
        _PostAccData.SWIFT = ""
        'Address
        _PostAccData.Address.DellAddress1 = ""
        _PostAccData.Address.DellAddress2 = ""
        _PostAccData.Address.DelTown = ""
        _PostAccData.Address.DelCity = ""
        _PostAccData.Address.DelPostCode = ""
        _PostAccData.Address.DelCountry = ""
        _PostAccData.Address.PostalAddress1 = ""
        _PostAccData.Address.PostalAddress2 = ""
        _PostAccData.Address.PostalTown = ""
        _PostAccData.Address.PostalCity = ""
        _PostAccData.Address.PostalPostCode = ""
        _PostAccData.Address.PostalCountry = ""
        _PostAccData.Address.POBOX = ""
        _PostAccData.Address.POBOXCity = ""
        _PostAccData.Address.WorkPhone = ""
        _PostAccData.Address.HomePhone = ""
        _PostAccData.Address.MobilePhone = ""
        _PostAccData.Address.Fax = ""
        _PostAccData.Address.Email = ""
        _PostAccData.Address.Url = ""
        _PostAccData.Address.CompanyRegNo = ""
        _PostAccData.Address.VatRegNo = ""
        _PostAccData.Address.Notes = ""
        _PostAccData.Address.Text1 = ""
        _PostAccData.Address.Text2 = ""
        _PostAccData.Address.Text3 = ""
        _PostAccData.Address.Text4 = ""
        _PostAccData.Address.Text5 = ""
        _PostAccData.Address.Text6 = ""
        _PostAccData.Address.Text7 = ""
        _PostAccData.Address.Text8 = ""
        _PostAccData.Address.Text9 = ""
        _PostAccData.Address.Text10 = ""
        _PostAccData.Address.Date1 = ""
        _PostAccData.Address.Date2 = ""
        _PostAccData.Address.Date3 = ""
        _PostAccData.Address.Date4 = ""
        _PostAccData.Address.Date5 = ""
        _PostAccData.Address.Number1 = 0
        _PostAccData.Address.Number2 = 0
        _PostAccData.Address.Number3 = 0
        _PostAccData.Address.Number4 = 0
        _PostAccData.Address.Number5 = 0
        _PostAccData.Address.LicenceNo = ""
        _PostAccData.Address.RegNoID = ""


        Dim JsonPostInvoiceAccInfo As String = JsonConvert.SerializeObject(_PostAccData)
        Return JsonPostInvoiceAccInfo

    End Function

    Public Function PostJournal() As String
        Dim _PostJournal As New PostJournalModel
        'msgControl
        _PostJournal.msgControl.result = 0
        _PostJournal.msgControl.Message = "Corresponding success and error message"
        _PostJournal.msgControl.MethodName = ""
        _PostJournal.msgControl.AppName = ""
        _PostJournal.msgControl.EsoftUser = ""
        _PostJournal.msgControl.User = ""
        _PostJournal.msgControl.Password = ""
        _PostJournal.msgControl.SystemDate = DateAndTime.Now
        _PostJournal.msgControl.GenList = Nothing
        _PostJournal.msgControl.GenMsg1 = ""
        _PostJournal.msgControl.GenMsg2 = ""
        _PostJournal.msgControl.GenMsg3 = ""
        'Header
        _PostJournal.Company = "ZZZ"
        _PostJournal.TranType = "PUR"
        _PostJournal.PostYear = 0.0
        _PostJournal.PostPeriod = 0.0
        _PostJournal.TotalAmount = 0.0
        'TransLines
        For Each item In NumberOfInvLines()
            _PostJournal.accTranLines.Add(item)
        Next

        Dim JsonPostInvoiceJournalHeader As String = JsonConvert.SerializeObject(_PostJournal)

        Return JsonPostInvoiceJournalHeader
    End Function

    Private Function NumberOfInvLines() As List(Of PostJournalAccLinesModel)
        Dim _PostJournalAccLinesModel As New PostJournalAccLinesModel()
        Dim _NumberOfJournalLines As New List(Of PostJournalAccLinesModel)


        For i = 0 To 2

            _PostJournalAccLinesModel.AccountCode = "2"
            _PostJournalAccLinesModel.DocumentDate = DateTime.Now
            _PostJournalAccLinesModel.DueDate = DateTime.Now
            _PostJournalAccLinesModel.Currency = "EUR"
            _PostJournalAccLinesModel.Rate = 0.0
            _PostJournalAccLinesModel.BaseAmount = 10.0
            _PostJournalAccLinesModel.ForeignAmount = 0.0
            _PostJournalAccLinesModel.Sign = ""
            _PostJournalAccLinesModel.VatCode = ""
            _PostJournalAccLinesModel.Details = ""
            _PostJournalAccLinesModel.Reference = ""
            _PostJournalAccLinesModel.OtherReference = ""
            _PostJournalAccLinesModel.Analysis1 = ""
            _PostJournalAccLinesModel.Analysis2 = ""
            _PostJournalAccLinesModel.Analysis3 = ""
            _PostJournalAccLinesModel.Analysis4 = ""
            _PostJournalAccLinesModel.Analysis5 = ""
            _PostJournalAccLinesModel.Analysis6 = ""
            _PostJournalAccLinesModel.Analysis8 = ""
            _PostJournalAccLinesModel.Analysis9 = ""
            _NumberOfJournalLines.Add(_PostJournalAccLinesModel)

        Next
        Return _NumberOfJournalLines
    End Function
End Class
