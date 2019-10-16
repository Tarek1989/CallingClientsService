Imports System.Data.SqlClient
Imports EsoftProject

Public MustInherit Class AccountDOA
    'Abstract class for account data object access
    'holds two methods get data and update. This becomes specific for derived class 
    ' The methods only deals with Account information. NO TRANSCATION !!!
    Enum DataTableType
        Invoice
        Expense
        Payment
    End Enum
    Public MustOverride Sub RetrieveAccData(ByVal AccID As Integer, ByVal dataTableType As DataTableType)
    Public MustOverride Sub UpdateAcc()
End Class
