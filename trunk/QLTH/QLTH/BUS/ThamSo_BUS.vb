Imports DTO
Imports DAO

Public Class ThamSo_BUS

    Public Function LayDuLieu() As ThamSo_DTO
        Dim kq As ThamSo_DTO
        Try
            Dim thsDAO As New ThamSo_DAO
            kq = thsDAO.LayDuLieu()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function
End Class