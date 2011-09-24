Imports DTO
Imports System.Data.OleDb

Public Class Khoi_DAO
    Inherits DataProvider

    Public Function TimKhoi(ByVal maKhoi As String) As Khoi_DTO
        Dim kq As New Khoi_DTO
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT TenKhoi FROM KHOI WHERE MaKhoi=@MaKhoi"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaKhoi", DbType.String)
            dsThS(0).Value = maKhoi
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return Nothing
                Else
                    reader.Read()
                    kq.MaKhoi = maKhoi
                    kq.TenKhoi = reader("TenKhoi").ToString()
                End If
            End Using
            'Dong ket noi
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayMaKhoi(ByVal tenKhoi As String) As String
        Dim kq As String
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT MaKhoi FROM KHOI WHERE TenKhoi=@TenKhoi"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@TenKhoi", DbType.String)
            dsThS(0).Value = tenKhoi
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return ""
                Else
                    reader.Read()
                    kq = reader("MaKhoi").ToString()
                End If
            End Using
            'Dong ket noi
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

End Class
