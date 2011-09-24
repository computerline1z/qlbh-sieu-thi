Imports DTO
Imports DAO
Public Class GiaoVien_BUS

    Public Function LayDsLopDuocPhanCong(ByVal maGV As String) As IList
        Dim gv As New GiaoVien_DAO()
        Return gv.LayDsLopDuocPhanCong(maGV)
    End Function

    Public Function LayDsGiaoVien() As ArrayList
        Dim kq As ArrayList
        Try
            Dim gvDAO As New GiaoVien_DAO
            kq = gvDAO.LayDsGiaoVien()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Sub CapNhatGiaoVien(ByVal GiaoVienDTO As GiaoVien_DTO)
        Dim gvDAO As GiaoVien_DAO = New GiaoVien_DAO
        gvDAO.CapNhatGiaoVien(GiaoVienDTO)
    End Sub
    Public Sub Them(ByVal GiaoVienDTO As GiaoVien_DTO)
        Dim gvDAO As GiaoVien_DAO = New GiaoVien_DAO
        gvDAO.Them(GiaoVienDTO)
    End Sub

    Public Sub Xoa(ByVal GiaoVienDTO As GiaoVien_DTO)
        Dim gvDAO As GiaoVien_DAO = New GiaoVien_DAO
        gvDAO.Xoa(GiaoVienDTO)
    End Sub

    Public Function TimKiem(ByVal MaGiaoVien As String) As GiaoVien_DTO
        Dim gvDAO As New GiaoVien_DAO
        Return gvDAO.TimKiem(MaGiaoVien)
    End Function

    Public Function LayMaGiaoVien(ByVal tenGV As String, ByVal tenTat As String) As String
        Dim kq As String
        Try
            Dim gvDAO As New GiaoVien_DAO
            kq = gvDAO.LayMaGiaoVien(tenGV, tenTat)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayTenGiaoVien(ByVal maGV As String) As String
        Dim kq As String
        Try
            Dim gvDAO As New GiaoVien_DAO
            kq = gvDAO.LayTenGiaoVien(maGV)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function
End Class
