Imports DTO
Imports System.Data
Imports System.Data.OleDb



Public Class DataProvider

    Protected connectionString As String
    Protected connection As OleDbConnection
    Protected adapter As OleDbDataAdapter
    Protected command As OleDbCommand

    Sub New()
        connectionString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = PTNK.mdb"
    End Sub

    Public Sub Connect()
        connection = New OleDbConnection(connectionString)
        connection.Open()
    End Sub

    Public Sub DisConnect()
        connection.Close()
    End Sub

    Public Function ExecuteQuery(ByVal SQLString As String) As IDataReader
        command = New OleDbCommand(SQLString, connection)
        Return command.ExecuteReader()
    End Function

    Public Function ExecuteQuery(ByVal SQLString As String, ByVal dsThS As OleDbParameter()) As IDataReader
        command = New OleDbCommand(SQLString, connection)
        command.Parameters.AddRange(dsThS)
        Return command.ExecuteReader()
    End Function

    Public Function ExecuteQueryToTable(ByVal SQLString As String) As DataTable
        Dim ds As New DataSet
        adapter = New OleDbDataAdapter(SQLString, connection)
        adapter.Fill(ds)
        Return ds.Tables(0)
    End Function
   
    Public Sub ExecuteNonQuery(ByVal SQLString As String)
        command = New OleDbCommand(SQLString, connection)
        command.ExecuteNonQuery()
    End Sub

    Public Function ExecuteNonQuery(ByVal SQLString As String, ByVal dsThS As OleDbParameter()) As Integer
        command = New OleDbCommand(SQLString, connection)
        command.Parameters.AddRange(dsThS)
        Return command.ExecuteNonQuery()
    End Function

    Public Function ExecuteScalar(ByVal SQLString As String) As Object
        command = New OleDbCommand(SQLString, connection)
        Return command.ExecuteScalar()
    End Function
End Class
