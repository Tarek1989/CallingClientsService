Imports System.Data.SqlClient
Imports EsoftProject

Public Interface IEsoftDB
    Enum DataAccessLayerMethod
        GetData
        Update
    End Enum

    Property _SqlConnection As SqlConnection
    Property _SqlCommand As SqlCommand
    Property _SqlDatareader As SqlDataReader
    Property _Datatable As DataTable
    Sub ConnectToDB(ByVal DataAccessLayerMethod As DataAccessLayerMethod, ByVal AccID As Integer, ByVal dataTableType As AccountDOA.DataTableType)

End Interface
