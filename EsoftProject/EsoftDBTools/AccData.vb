Imports System.Data.SqlClient
Imports EsoftProject

Public Class AccData
    Inherits AccountDOA
    Implements IEsoftDB



    ' This class deals with Invoice Account information. NOT TRANSCACTION!
    ' For example
    ' Retrieve invoice account information
    ' Update invoice account information

    Private _accountDOAconnection As New SqlConnection
    Private _accountDOAcommand As New SqlCommand
    Private _accountDOADatareader As SqlDataReader
    Private _accountDOADatatable As New DataTable

    Public Property _SqlConnection As SqlConnection Implements IEsoftDB._SqlConnection
        Get
            Return _accountDOAconnection
        End Get
        Set(value As SqlConnection)
            _accountDOAconnection = value
        End Set
    End Property

    Public Property _SqlCommand As SqlCommand Implements IEsoftDB._SqlCommand
        Get
            Return _accountDOAcommand
        End Get
        Set(value As SqlCommand)
            _accountDOAcommand = value
        End Set
    End Property

    Public Property _SqlDatareader As SqlDataReader Implements IEsoftDB._SqlDatareader
        Get
            Return _accountDOADatareader
        End Get
        Set(value As SqlDataReader)
            _accountDOADatareader = value
        End Set
    End Property


    Public Property _Datatable As DataTable Implements IEsoftDB._Datatable
        Get
            Return _accountDOADatatable
        End Get
        Set(value As DataTable)
            _accountDOADatatable = value
        End Set
    End Property

    Public Sub ConnectToDB(DataAccessLayerMethod As IEsoftDB.DataAccessLayerMethod, AccID As Integer, dataTableType As DataTableType) Implements IEsoftDB.ConnectToDB
        Try
            Using _accountDOAconnection
                _accountDOAconnection.ConnectionString = "Server=xxxx;Database=xxxx;Trusted_Connection=true"
                _accountDOAconnection.Open()

                If _accountDOAconnection.State = ConnectionState.Closed Then
                    MsgBox("Connection failed")
                    Return
                End If

                Select Case DataAccessLayerMethod
                    Case IEsoftDB.DataAccessLayerMethod.Update
                        UpdateAcc()
                    Case IEsoftDB.DataAccessLayerMethod.GetData
                        RetrieveAccData(AccID, dataTableType)
                    Case Else
                        MsgBox("Error")
                End Select

                _accountDOADatareader.Close()
                _accountDOAcommand.Dispose()
                _accountDOAconnection.Close()
            End Using
        Catch ex As Exception

        End Try


    End Sub

    'Update Invoice Account
    Public Overrides Sub UpdateAcc()
        Throw New NotImplementedException()
    End Sub

    'Post / Create Invoice Account
    Public Overrides Sub RetrieveAccData(AccID As Integer, dataTableType As DataTableType)
        Try
            Select Case dataTableType
                Case DataTableType.Invoice
                    _accountDOAcommand.CommandText = ""'procedure for  Invoice acc
                Case DataTableType.Expense
                    _accountDOAcommand.CommandText = ""'procedure for  Expenses acc
                Case DataTableType.Payment
                    _accountDOAcommand.CommandText = "" 'procedure for  Payment acc
                Case Else
                    MsgBox("Error")
            End Select

            'Command for getting data for specific  account

            _accountDOAcommand.CommandType = CommandType.StoredProcedure
            _accountDOAcommand.Parameters.AddWithValue("@AccID", AccID)
            _accountDOAcommand.Connection = _accountDOAconnection

            _accountDOADatareader = _accountDOAcommand.ExecuteReader()
            While _accountDOADatareader.Read()
                For Each row In _accountDOADatareader
                    _accountDOADatatable.Rows.Add(row)
                Next
            End While

        Catch ex As Exception

        End Try
    End Sub
End Class
