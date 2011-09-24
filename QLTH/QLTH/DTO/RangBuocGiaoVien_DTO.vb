
Public Class RangBuocGiaoVien_DTO

    Private _maRangBuocGiaoVien As String
    Property MaRangBuocGiaoVien() As String
        Get
            Return _maRangBuocGiaoVien
        End Get
        Set(ByVal value As String)
            _maRangBuocGiaoVien = value
        End Set
    End Property
    Private _maGiaoVien As String
    Property MaGiaoVien() As String
        Get
            Return _maGiaoVien
        End Get
        Set(ByVal value As String)
            _maGiaoVien = value
        End Set
    End Property
    Private _thu As Integer
    Property Thu() As Integer
        Get
            Return _thu
        End Get
        Set(ByVal value As Integer)
            _thu = value
        End Set
    End Property
    Private _tietHoc As Integer
    Property TietHoc() As Integer
        Get
            Return _tietHoc
        End Get
        Set(ByVal value As Integer)
            _tietHoc = value
        End Set
    End Property
    Private _trangThai As Integer
    Property TrangThai() As Integer
        Get
            Return _trangThai
        End Get
        Set(ByVal value As Integer)
            _trangThai = value
        End Set
    End Property
End Class
