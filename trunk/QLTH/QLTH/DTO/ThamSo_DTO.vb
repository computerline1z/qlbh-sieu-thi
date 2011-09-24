
Public Class ThamSo_DTO

#Region "Attributes"
    Private _soTietToiDaTrongNgay As Integer
    Private _soTietToiDaDuocHocTrongNgay As Integer
    Private _tietGay As Integer
#End Region

#Region "Properties"
    Public Property SoTietToiDaTrongNgay() As Integer
        Get
            Return _soTietToiDaTrongNgay
        End Get
        Set(ByVal value As Integer)
            _soTietToiDaTrongNgay = value
        End Set
    End Property

    Public Property SoTietToiDaDuocHocTrongNgay() As Integer
        Get
            Return _soTietToiDaDuocHocTrongNgay
        End Get
        Set(ByVal value As Integer)
            _soTietToiDaDuocHocTrongNgay = value
        End Set
    End Property

    Public Property TietGay() As Integer
        Get
            Return _tietGay
        End Get
        Set(ByVal value As Integer)
            _tietGay = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        _soTietToiDaTrongNgay = 0
        _soTietToiDaDuocHocTrongNgay = 0
        _tietGay = 0
    End Sub
#End Region

End Class
