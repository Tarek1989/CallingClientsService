Public MustInherit Class JournalDOA
    Enum DataTableType
        Invoice
        Expense
        Payment
    End Enum
    Public MustOverride Sub RetrieveJournalData(ByVal AccID As Integer, ByVal dataTableType As DataTableType)
End Class
