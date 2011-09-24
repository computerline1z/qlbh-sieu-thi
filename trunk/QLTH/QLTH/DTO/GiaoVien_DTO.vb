
Public Class GiaoVien_DTO

#Region "Attributes"
    Private _maGiaoVien As String
    Private _hoTenGiaoVien As String
    Private _tenTat As String
    Private _diaChi As String
    Private _dienThoai As String
#End Region

#Region "Properties"
    Public Property MaGiaoVien() As String
        Get
            Return _maGiaoVien
        End Get
        Set(ByVal value As String)
            _maGiaoVien = value
        End Set
    End Property

    Public Property HoTenGiaoVien() As String
        Get
            Return _hoTenGiaoVien
        End Get
        Set(ByVal value As String)
            _hoTenGiaoVien = value
        End Set
    End Property

    Public Property TenTat() As String
        Get
            Return _tenTat
        End Get
        Set(ByVal value As String)
            _tenTat = value
        End Set
    End Property

    Public Property DiaChi() As String
        Get
            Return _diaChi
        End Get
        Set(ByVal value As String)
            _diaChi = value
        End Set
    End Property

    Public Property DienThoai() As String
        Get
            Return _dienThoai
        End Get
        Set(ByVal value As String)
            _dienThoai = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        _maGiaoVien = ""
        _hoTenGiaoVien = ""
        _tenTat = ""
        _diaChi = ""
        _dienThoai = ""
    End Sub
#End Region

End Class
