Imports DTO
Imports DAO
Public Class RangBuocGiaoVien_BUS
    Public Function LayDsRangBuocGiaoVien(ByVal MaGiaoVien As String) As ArrayList
        Dim RangBuocgvDAO As RangBuocGiaoVien_DAO = New RangBuocGiaoVien_DAO
        Return RangBuocgvDAO.LayDsRangBuocGiaoVien(MaGiaoVien)
    End Function

    Public Sub CapNhatRangBuocGiaoVien(ByVal RangBuocGiaoVienDTO As RangBuocGiaoVien_DTO)
        Dim RangBuocgvDAO As RangBuocGiaoVien_DAO = New RangBuocGiaoVien_DAO
        RangBuocgvDAO.CapNhatRangBuocGiaoVien(RangBuocGiaoVienDTO)
    End Sub
    Public Sub Them(ByVal RangBuocGiaoVienDTO As RangBuocGiaoVien_DTO)
        Dim RangBuocgvDAO As RangBuocGiaoVien_DAO = New RangBuocGiaoVien_DAO
        RangBuocgvDAO.Them(RangBuocGiaoVienDTO)
    End Sub

    Public Sub Xoa(ByVal RangBuocGiaoVienDTO As RangBuocGiaoVien_DTO)
        Dim RangBuocgvDAO As RangBuocGiaoVien_DAO = New RangBuocGiaoVien_DAO
        RangBuocgvDAO.Xoa(RangBuocGiaoVienDTO)
    End Sub

    Public Function TimKiem(ByVal MaRangBuocGiaoVien As String) As RangBuocGiaoVien_DTO
        Dim RangBuocgvDAO As New RangBuocGiaoVien_DAO
        Return RangBuocgvDAO.TimKiem(MaRangBuocGiaoVien)
    End Function

    Public Function DemSoRangBuocVoi1GiaoVien(ByVal MaGiaoVien As String) As Integer
        Dim RangBuocgvDAO As New RangBuocGiaoVien_DAO
        Return RangBuocgvDAO.DemSoRangBuocVoi1GiaoVien(MaGiaoVien)
    End Function
End Class
