Imports System.Data.SqlClient
Imports EsoftProject

Public Class JournalData
    Inherits JournalDOA
    Implements IEsoftDB

    ' This class deals with Invoice Journal Information
    ' For example
    ' Retrieve invoice journal information

    Private _JournalDOAconnection As New SqlConnection
    Private _JournalDOAcommand As New SqlCommand
    Private _JournalDOADatareader As SqlDataReader
    Private _JournalDOADatatable As New DataTable

    Public Property _SqlConnection As SqlConnection Implements IEsoftDB._SqlConnection
        Get
            Return _JournalDOAconnection
        End Get
        Set(value As SqlConnection)
            _JournalDOAconnection = value
        End Set
    End Property

    Public Property _SqlCommand As SqlCommand Implements IEsoftDB._SqlCommand
        Get
            Return _JournalDOAcommand
        End Get
        Set(value As SqlCommand)
            _JournalDOAcommand = value
        End Set
    End Property

    Public Property _SqlDatareader As SqlDataReader Implements IEsoftDB._SqlDatareader
        Get
            Return _JournalDOADatareader
        End Get
        Set(value As SqlDataReader)
            _JournalDOADatareader = value
        End Set
    End Property

    Public Property _Datatable As DataTable Implements IEsoftDB._Datatable
        Get
            Return _JournalDOADatatable
        End Get
        Set(value As DataTable)
            _JournalDOADatatable = value
        End Set
    End Property

    Public Overrides Sub RetrieveJournalData(AccID As Integer, dataTableType As DataTableType)
        Try

            Select Case dataTableType
                Case DataTableType.Invoice
                    _JournalDOAcommand.CommandText = ""'procedure for  Invoice acc
                Case DataTableType.Expense
                    _JournalDOAcommand.CommandText = ""'procedure for  Expenses acc
                Case DataTableType.Payment
                    _JournalDOAcommand.CommandText = "" 'procedure for  Payment acc
                Case Else
                    MsgBox("Error")
            End Select
            'Command for getting data for specific invoice account
            _JournalDOAcommand.CommandText = 'procedure for invoice journal
            _JournalDOAcommand.CommandType = CommandType.StoredProcedure
            _JournalDOAcommand.Parameters.AddWithValue("@AccID", AccID)
            _JournalDOAcommand.Connection = _JournalDOAconnection

            _JournalDOADatareader = _JournalDOAcommand.ExecuteReader()
            While _JournalDOADatareader.Read()
                For Each row In _JournalDOADatareader
                    _JournalDOADatatable.Rows.Add(row)
                Next
            End While

        Catch ex As Exception

        End Try
    End Sub


    Public Sub ConnectToDB(DataAccessLayerMethod As IEsoftDB.DataAccessLayerMethod, AccID As Integer, dataTableType As AccountDOA.DataTableType) Implements IEsoftDB.ConnectToDB
        Try
            Using _JournalDOAconnection
                _JournalDOAconnection.ConnectionString = "Server=moebiussql.moebius.com.cy;Database=esoft;Trusted_Connection=true"
                _JournalDOAconnection.Open()

                If _JournalDOAconnection.State = ConnectionState.Closed Then
                    MsgBox("Connection failed")
                    Return
                End If

                Select Case DataAccessLayerMethod
                    Case IEsoftDB.DataAccessLayerMethod.GetData
                        RetrieveJournalData(AccID, dataTableType)
                    Case Else
                        MsgBox("Error")
                End Select

                _JournalDOADatareader.Close()
                _JournalDOAcommand.Dispose()
                _JournalDOAconnection.Close()
            End Using
        Catch ex As Exception

        End Try
    End Sub


End Class
