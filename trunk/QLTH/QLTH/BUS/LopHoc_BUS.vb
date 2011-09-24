Imports DTO
Imports DAO

Public Class LopHoc_BUS
    Public Function LayDSLopHocTheoKhoi(ByVal tenKhoi As String) As ArrayList
        Dim kq As New ArrayList()
        Try
            Dim khoiBUS As New Khoi_BUS
            Dim maKhoi As String = khoiBUS.LayMaKhoi(tenKhoi)
            If (maKhoi = "") Then
                maKhoi = "all"
            End If
            Dim lhDAO As New LopHoc_DAO
            kq = lhDAO.LayDsLop(maKhoi)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayDSTenLop() As ArrayList
        Dim kq As ArrayList
        Try
            Dim lhDAO As New LopHoc_DAO
            kq = lhDAO.LayDSTenLop()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayMaLopHoc(ByVal tenLH As String) As String
        Dim kq As String
        Try
            Dim lhDAO As New LopHoc_DAO
            kq = lhDAO.LayMaLopHoc(tenLH)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayTenLopHoc(ByVal maLH As String) As String
        Dim kq As String
        Try
            Dim lhDAO As New LopHoc_DAO
            kq = lhDAO.LayTenLopHoc(maLH)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayDsLop(ByVal makhoi As String) As ArrayList
        Dim LopHocDAO As LopHoc_DAO = New LopHoc_DAO()
        Return LopHocDAO.LayDsLop(makhoi)
    End Function

    Public Sub CapNhatLopHoc(ByVal lopHocDTO As LopHoc_DTO)
        Dim LopHocDAO As LopHoc_DAO = New LopHoc_DAO()
        LopHocDAO.CapNhatLopHoc(lopHocDTO)
    End Sub

    Public Sub Them(ByVal lopHocDTO As LopHoc_DTO)
        Dim LopHocDAO As LopHoc_DAO = New LopHoc_DAO()
        LopHocDAO.Them(lopHocDTO)
    End Sub

    Public Sub Them(ByVal MaLopHoc As String, ByVal TenLopHoc As String, ByVal MaKhoi As String)
        Dim LopHocDTO As LopHoc_DTO = New LopHoc_DTO()
        LopHocDTO.MaLopHoc = MaLopHoc
        LopHocDTO.TenLopHoc = TenLopHoc
        LopHocDTO.MaKhoi = MaKhoi
        Them(LopHocDTO)
    End Sub

    Public Sub Xoa(ByVal lopHocDTO As LopHoc_DTO)
        Dim LopHocDAO As LopHoc_DAO = New LopHoc_DAO()
        LopHocDAO.Xoa(lopHocDTO)
    End Sub
    Public Sub xoa(ByVal MaLopHoc As String)
        Dim LopHocDAO As LopHoc_DAO = New LopHoc_DAO()
        LopHocDAO.Xoa(MaLopHoc)
    End Sub

    Public Function TimKiem(ByVal MaLopHoc As String) As LopHoc_DTO
        Dim LopHocDAO As LopHoc_DAO = New LopHoc_DAO()
        Return LopHocDAO.TimKiem(MaLopHoc)
    End Function

    Public Function LayMaLopHocCuoi() As String
        Dim LopHocDAO As LopHoc_DAO = New LopHoc_DAO
        Return LopHocDAO.LayMaLopHocCuoi()
    End Function
    Public Function TaoMaLopHocMoi() As String
        'Lấy mã lớp học cuối trong CSDL
        Dim MaLopHocCuoi As String

        MaLopHocCuoi = LayMaLopHocCuoi()
        'Tính ra mã lớp học mới
        Dim strTemp As String
        strTemp = MaLopHocCuoi.Substring(2)
        Dim intTemp As Integer = Integer.Parse(strTemp) + 1
        Dim MaLopHocMoi As String = "LH" & intTemp.ToString()
        Return MaLopHocMoi
    End Function
End Class
