
Public Class PhanCong_DTO

#Region "Attributes"
    Private _maPhanCong As String
    Private _maLopHoc As String
    Private _maMonHoc As String
    Private _maGiaoVien As String
    Private _soTietHocTuan As Integer
    Private _soTietHocLienTiepToiThieu As Integer
    Private _soTietHocLienTiepToiDa As Integer
    Private _soBuoiHocToiThieu As Integer
    Private _soBuoiHocToiDa As Integer
#End Region

#Region "Properties"
    Public Property MaPhanCong() As String
        Get
            Return _maPhanCong
        End Get
        Set(ByVal value As String)
            _maPhanCong = value
        End Set
    End Property

    Public Property MaLopHoc() As String
        Get
            Return _maLopHoc
        End Get
        Set(ByVal value As String)
            _maLopHoc = value
        End Set
    End Property

    Public Property MaMonHoc() As String
        Get
            Return _maMonHoc
        End Get
        Set(ByVal value As String)
            _maMonHoc = value
        End Set
    End Property

    Public Property MaGiaoVien() As String
        Get
            Return _maGiaoVien
        End Get
        Set(ByVal value As String)
            _maGiaoVien = value
        End Set
    End Property

    Public Property SoTietHocTuan() As Integer
        Get
            Return _soTietHocTuan
        End Get
        Set(ByVal value As Integer)
            _soTietHocTuan = value
        End Set
    End Property

    Public Property SoTietHocLienTiepToiThieu() As Integer
        Get
            Return _soTietHocLienTiepToiThieu
        End Get
        Set(ByVal value As Integer)
            _soTietHocLienTiepToiThieu = value
        End Set
    End Property

    Public Property SoTietHocLienTiepToiDa() As Integer
        Get
            Return _soTietHocLienTiepToiDa
        End Get
        Set(ByVal value As Integer)
            _soTietHocLienTiepToiDa = value
        End Set
    End Property

    Public Property SoBuoiHocToiThieu() As Integer
        Get
            Return _soBuoiHocToiThieu
        End Get
        Set(ByVal value As Integer)
            _soBuoiHocToiThieu = value
        End Set
    End Property

    Public Property SoBuoiHocToiDa() As Integer
        Get
            Return _soBuoiHocToiDa
        End Get
        Set(ByVal value As Integer)
            _soBuoiHocToiDa = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        _maPhanCong = ""
        _maLopHoc = ""
        _maMonHoc = ""
        _maGiaoVien = ""
        _soTietHocTuan = 0
        _soTietHocLienTiepToiThieu = 0
        _soTietHocLienTiepToiDa = 0
        _soBuoiHocToiThieu = 0
        _soBuoiHocToiDa = 0
    End Sub
#End Region

End Class
