
Public Class LichLopHoc_DTO

#Region "Attributes"
    Private _maLichLopHoc As String
    Private _maPhanCong As String
    Private _thu As Integer
    Private _tietHocBatDau As Integer
    Private _soTietHoc As Integer
#End Region

#Region "Properties"
    Public Property MaLichLopHoc() As String
        Get
            Return _maLichLopHoc
        End Get
        Set(ByVal value As String)
            _maLichLopHoc = value
        End Set
    End Property

    Public Property MaPhanCong() As String
        Get
            Return _maPhanCong
        End Get
        Set(ByVal value As String)
            _maPhanCong = value
        End Set
    End Property

    Public Property Thu() As Integer
        Get
            Return _thu
        End Get
        Set(ByVal value As Integer)
            _thu = value
        End Set
    End Property

    Public Property TietHocBatDau() As Integer
        Get
            Return _tietHocBatDau
        End Get
        Set(ByVal value As Integer)
            _tietHocBatDau = value
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

#Region "Constructors"
    Public Sub New()
        _maLichLopHoc = ""
        _maPhanCong = ""
        _thu = 0
        _tietHocBatDau = 0
        _soTietHoc = 0
    End Sub
#End Region
End Class
