Imports DTO
Imports System.Data.OleDb
Public Class RangBuocGiaoVien_DAO
    Inherits DataProvider
    Public Function LayDsRangBuocGiaoVien(ByVal MaGiaoVien As String) As ArrayList
        Dim toReturn As ArrayList = New ArrayList()
        'Mo ket noi CSDL
        Connect()
        Dim SqlQuery As String
        SqlQuery = "Select MaRangBuocGiaoVien, MaGiaoVien, Thu, TietHoc, TrangThai from RANGBUOCGIAOVIEN"
        If (MaGiaoVien.ToLower() <> "all") Then
            SqlQuery &= " Where MaGiaoVien = '" & MaGiaoVien & "'"
        End If
        Dim reader As OleDbDataReader
        reader = ExecuteQuery(SqlQuery)
        Dim rangBuocGiaoVienDTO As RangBuocGiaoVien_DTO
        Do While reader.Read()
            rangBuocGiaoVienDTO = New RangBuocGiaoVien_DTO
            rangBuocGiaoVienDTO.MaRangBuocGiaoVien = reader("MaRangBuocGiaoVien").ToString()
            rangBuocGiaoVienDTO.MaGiaoVien = reader("MaGiaoVien").ToString()
            rangBuocGiaoVienDTO.Thu = reader("Thu").ToString()
            rangBuocGiaoVienDTO.TietHoc = reader("TietHoc").ToString()
            rangBuocGiaoVienDTO.TrangThai = reader("TrangThai").ToString()
            toReturn.Add(rangBuocGiaoVienDTO)
        Loop
        'Dong ket noi CSDL
        DisConnect()
        Return toReturn
    End Function

    Public Sub CapNhatRangBuocGiaoVien(ByVal rangBuocGiaoVien_DTO As RangBuocGiaoVien_DTO)
        'mo ket noi CSDL
        Connect()
        'chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Update RANGBUOCGIAOVIEN set TrangThai = '" & rangBuocGiaoVien_DTO.TrangThai & "' "
        SqlQuery &= " Where Thu = " & rangBuocGiaoVien_DTO.Thu & " and "
        SqlQuery &= " TietHoc= " & rangBuocGiaoVien_DTO.TietHoc & " and "
        SqlQuery &= " MaGiaoVien = '" & rangBuocGiaoVien_DTO.MaGiaoVien & "'"
        'thuc thi cau truy van
        ExecuteNonQuery(SqlQuery)
        'dong ket noi CSDL
        DisConnect()
    End Sub

    Public Sub Them(ByVal rangBuocGiaoVienDTO As RangBuocGiaoVien_DTO)
        'Mo ket noi CSDL
        Connect()
        'Chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Insert into RANGBUOCGIAOVIEN (MaRangBuocGiaoVien, MaGiaoVien, Thu, TietHoc, TrangThai) "
        SqlQuery &= "Values ('" & rangBuocGiaoVienDTO.MaRangBuocGiaoVien & "', '"
        SqlQuery &= rangBuocGiaoVienDTO.MaRangBuocGiaoVien & "', '" & rangBuocGiaoVienDTO.MaGiaoVien & "', '"
        SqlQuery &= rangBuocGiaoVienDTO.Thu & "', '" & rangBuocGiaoVienDTO.TietHoc & "', '"
        SqlQuery &= rangBuocGiaoVienDTO.TrangThai & "')" 
        'Thuc thi cau truy van
        ExecuteNonQuery(SqlQuery)
        'Dong ket noi CSDL
        DisConnect()
    End Sub

    Public Sub Xoa(ByVal rangBuocGiaoVien As RangBuocGiaoVien_DTO)
        'mo ket noi
        Connect()
        'Chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Delete from RANGBUOCGIAOVIEN where MaRangBuocGiaoVien = '" & rangBuocGiaoVien.MaRangBuocGiaoVien & "'"
        ExecuteNonQuery(SqlQuery)
        'Dong ket noi
        DisConnect()
    End Sub

    Public Function DemSoRangBuocVoi1GiaoVien(ByVal MaGiaoVien As String) As Integer
        'mo ket noi
        Connect()
        'Chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Count MaRangBuocGiaoVien from RANGBUOCGIAOVIEN where MaRGiaoVien = '" & MaGiaoVien & "'"
        Dim kq As Integer = ExecuteScalar(SqlQuery)
        'Dong ket noi
        DisConnect()
        Return kq
    End Function



    Public Function TimKiem(ByVal MaRangBuocGiaoVien As String) As RangBuocGiaoVien_DTO
        Dim toReturn As RangBuocGiaoVien_DTO
        'Mo ket noi
        Connect()
        'Chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Select MaRangBuocGiaoVien, MaGiaoVien, Thu, TietHoc, TrangThai from RANGBUOCGIAOVIEN where MaRangBuocGiaoVien ='" & MaRangBuocGiaoVien & "'"
        Dim reader As OleDbDataReader
        reader = ExecuteQuery(SqlQuery)
        If (reader.HasRows = False) Then
            Return Nothing
        Else
            toReturn = New RangBuocGiaoVien_DTO
            reader.Read()
            toReturn.MaRangBuocGiaoVien = reader("MaRangBuocGiaoVien").ToString()
            toReturn.MaGiaoVien = reader("MaGiaoVien").ToString()
            toReturn.Thu = reader("Thu").ToString()
            toReturn.TietHoc = reader("TietHoc").ToString()
            toReturn.TrangThai = reader("TrangThai").ToString()

        End If
        'Dong ket noi
        DisConnect()
        Return toReturn
    End Function
End Class
