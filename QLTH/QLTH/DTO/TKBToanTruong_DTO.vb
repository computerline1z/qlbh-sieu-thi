Public Class TKBToanTruong_DTO
#Region "Attribute"
    Private _maLichLopHoc As String
    Private _lopHoc As String
    Private _monHoc As String
    Private _tenGiaoVien As String
    Private _ngayHoc As Integer
    Private _tietBatDau As Integer
    Private _soTietHoc As Integer
#End Region
#Region "Properties"
    Public Property TenLopHoc() As String
        Get
            Return _lopHoc
        End Get
        Set(ByVal value As String)
            _lopHoc = value
        End Set
    End Property
    Public Property MaLichLopHoc() As String
        Get
            Return _maLichLopHoc
        End Get
        Set(ByVal value As String)
            _maLichLopHoc = value
        End Set
    End Property

    Public Property MonHoc() As String
        Get
            Return _monHoc
        End Get
        Set(ByVal value As String)
            _monHoc = value
        End Set
    End Property

    Public Property TenGiaoVien() As String
        Get
            Return _tenGiaoVien
        End Get
        Set(ByVal value As String)
            _tenGiaoVien = value
        End Set
    End Property

    Public Property NgayHoc() As Integer
        Get
            Return _ngayHoc
        End Get
        Set(ByVal value As Integer)
            _ngayHoc = value
        End Set
    End Property

    Public Property TietBatDau() As Integer
        Get
            Return _tietBatDau
        End Get
        Set(ByVal value As Integer)
            _tietBatDau = value
        End Set
    End Property
    Public Property SoTietHoc() As Integer
        Get
            Return _soTietHoc
        End Get
        Set(ByVal value As Integer)
            _soTietHoc = value
        End Set
    End Property
#End Region
End Class
