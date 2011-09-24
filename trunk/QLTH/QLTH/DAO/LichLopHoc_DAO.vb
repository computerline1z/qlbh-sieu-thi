Imports DTO
Imports System.Data.OleDb

Public Class LichLopHoc_DAO
    Inherits DataProvider

    Public Function LayLichHoc(ByVal maPC As String) As LichLopHoc_DTO
        Dim kq As New LichLopHoc_DTO
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT MaLichLopHoc, Thu, TietHocBatDau, SoTietHoc FROM LICHLOPHOC WHERE MaPhanCong=@MaPhanCong"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaPhanCong", DbType.String)
            dsThS(0).Value = maPC
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                If (reader.HasRows = False) Then
                    Return Nothing
                Else
                    reader.Read()
                    kq.MaLichLopHoc = reader("MaLichLopHoc").ToString()
                    kq.Thu = reader("Thu")
                    kq.TietHocBatDau = reader("TietHocBatDau")
                    kq.SoTietHoc = reader("SoTietHoc")
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

    Public Function LayDSLichHoc(ByVal maPC As String) As ArrayList
        Dim kq As New ArrayList
        Try
            'Mo ket noi
            Connect()
            'Chuan bi cau truy van
            Dim SqlQuery As String
            SqlQuery = "SELECT MaLichLopHoc, Thu, TietHocBatDau, SoTietHoc FROM LICHLOPHOC WHERE MaPhanCong=@MaPhanCong"
            Dim dsThS(0) As OleDbParameter
            dsThS(0) = New OleDbParameter("@MaPhanCong", DbType.String)
            dsThS(0).Value = maPC
            Dim llhDTO As LichLopHoc_DTO
            Using reader As OleDbDataReader = ExecuteQuery(SqlQuery, dsThS)
                Do While (reader.Read())
                    llhDTO = New LichLopHoc_DTO
                    llhDTO.MaPhanCong = maPC
                    llhDTO.MaLichLopHoc = reader("MaLichLopHoc").ToString()
                    llhDTO.Thu = reader("Thu")
                    llhDTO.TietHocBatDau = reader("TietHocBatDau")
                    llhDTO.SoTietHoc = reader("SoTietHoc")
                    kq.Add(llhDTO)
                Loop
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
