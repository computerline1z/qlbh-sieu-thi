Imports DTO
Imports DAO

Public Class Khoi_BUS
    Public Function LayMaKhoi(ByVal tenKhoi As String) As String
        Dim kq As String
        Try
            Dim khoiDAO As New Khoi_DAO
            kq = khoiDAO.LayMaKhoi(tenKhoi)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function
End Class
