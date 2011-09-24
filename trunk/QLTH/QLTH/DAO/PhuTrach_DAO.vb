Imports System.Data.OleDb
Imports DTO

Public Class PhuTrach_DAO
    Inherits DataProvider

    Public Function LayDSMonPhuTrach(ByVal maGV As String) As ArrayList
        Dim kq As New ArrayList
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "SELECT MaMonHoc, MaPhuTrach FROM PHUTRACH WHERE MaGiaoVien=@MaGiaoVien"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(0).Value = maGV
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                Dim ptDTO As PhuTrach_DTO
                Do While reader.Read()
                    ptDTO = New PhuTrach_DTO
                    ptDTO.MaGiaoVien = maGV
                    ptDTO.MaMonHoc = reader("MaMonHoc").ToString()
                    ptDTO.MaPhuTrach = reader("MaPhuTrach").ToString()
                    kq.Add(ptDTO)
                Loop
            End Using
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function KiemTraTonTai(ByVal maGV As String, ByVal maMH As String) As Boolean
        Dim kq As Boolean = False
        Try
            'Mo ket noi CSDL
            Connect()
            Dim SqlQuery As String
            SqlQuery = "SELECT * FROM PHUTRACH WHERE MaGiaoVien=@MaGiaoVien AND MaMonHoc=@MaMonHoc"
            Dim dsThS(1) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaGiaoVien", DbType.String)
            dsThS(0).Value = maGV
            dsThS(1) = New OleDbParameter("@MaMonHoc", DbType.String)
            dsThS(1).Value = maMH
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.Read()) Then
                    kq = True
                End If
            End Using
            'Dong ket noi CSDL
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

End Class
