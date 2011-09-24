Imports DTO
Imports DAO

Public Class QuyDinh_BUS
    Public Function LayQuyDinh() As QuyDinh_DTO
        Dim Kq As QuyDinh_DTO
        Dim QdDAO As New QuyDinh_DAO
        Kq = QdDAO.LayQuyDinh()

        Return Kq
    End Function

    Public Sub CapNhat(ByVal Qd As QuyDinh_DTO)
        Dim QdDAO As New QuyDinh_DAO
        QdDAO.CapNhat(Qd)
    End Sub
End Class
