Imports System.Data.OleDb
Imports DTO
Public Class RangBuocLopHoc_DAO
    Inherits DataProvider
    Public Function LayLichRanh(ByVal MaLop As String) As ArrayList
        Dim toReturn As ArrayList = New ArrayList()
        'ket noi CSDL
        Connect()
        'Tao cau truy van
        Dim SqlQuery As String
        SqlQuery = "Select MaRangBuocLopHoc, MaLopHoc, Thu, TietHoc, TrangThai From RangBuocLopHoc Where MaLopHoc = '" & MaLop & "'"
        Dim reader As OleDbDataReader
        reader = ExecuteQuery(SqlQuery)
        Dim rangBuocLopHoc As RangBuocLopHoc_DTO
        While (reader.Read())
            rangBuocLopHoc = New RangBuocLopHoc_DTO
            rangBuocLopHoc.MaRangBuocLopHoc = reader("MaRangBuocLopHoc").ToString()
            rangBuocLopHoc.MaLopHoc = reader("MaLopHoc").ToString()
            rangBuocLopHoc.Thu = Integer.Parse(reader("Thu").ToString())
            rangBuocLopHoc.TietHoc = Integer.Parse(reader("TietHoc").ToString())
            rangBuocLopHoc.TrangThai = Integer.Parse(reader("TrangThai").ToString())
            toReturn.Add(rangBuocLopHoc)
        End While
        DisConnect()
        Return toReturn
    End Function



    Public Sub CapNhatLichRanh(ByVal RangBuocLopHoc As RangBuocLopHoc_DTO)
        'Mo ket noi
        Connect()
        'tao cau truy van
        Dim SqlQuery As String
        SqlQuery = "Update RANGBUOCLOPHOC set TrangThai = " & RangBuocLopHoc.TrangThai
        SqlQuery &= " where MaRangBuocLopHoc = '" & RangBuocLopHoc.MaRangBuocLopHoc & "'"
        'thuc thi cau truy van
        ExecuteNonQuery(SqlQuery)
        'Dong ket noi
        DisConnect()
    End Sub

    Public Sub Them(ByVal RangBuocLopHoc As RangBuocLopHoc_DTO)
        'Mo ket noi CSDL
        Connect()
        'Chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Insert into RangBuocLopHoc (MaRangBuocLopHoc, MaLopHoc, Thu, TietHoc, TrangThai)"
        SqlQuery &= " Values ('" & RangBuocLopHoc.MaRangBuocLopHoc & "', "
        SqlQuery &= "'" & RangBuocLopHoc.MaLopHoc & "', "
        SqlQuery &= RangBuocLopHoc.Thu & ", " & RangBuocLopHoc.TietHoc & ", " & RangBuocLopHoc.TrangThai & ")"
        'Thuc thi
        ExecuteNonQuery(SqlQuery)
        'Dong ket noi CSDL
        DisConnect()
    End Sub

    Public Sub Xoa(ByVal RangBuocLopHoc As RangBuocLopHoc_DTO)
        'mo ket noi
        Connect()
        'Chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Delete from RangBuoclopHoc where MaRangBuocLopHoc = '" & RangBuocLopHoc.MaRangBuocLopHoc & "'"
        ExecuteNonQuery(SqlQuery)
        'Dong ket noi
        DisConnect()
    End Sub

    Public Sub Xoa(ByVal MaLopHoc As String)
        'mo ket noi
        Connect()
        'Chuan bi cau truy van
        Dim SqlQuery As String
        SqlQuery = "Delete from RangBuoclopHoc where MaLopHoc = '" & MaLopHoc & "'"
        ExecuteNonQuery(SqlQuery)
        'Dong ket noi
        DisConnect()
    End Sub
    Public Function LayMaRangBuocLopHocCuoi() As String
        Dim toReturn As String
        Connect()
        Dim SqlQuery As String
        SqlQuery = "SELECT  top 1  MaRangBuocLopHoc  From RangBuocLopHoc order by MaRangBuocLopHoc DESC"
        toReturn = ExecuteScalar(SqlQuery)
        DisConnect()
        Return toReturn
    End Function

End Class
