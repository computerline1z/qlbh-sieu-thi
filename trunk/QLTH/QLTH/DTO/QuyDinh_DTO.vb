Public Class QuyDinh_DTO
    Private _soTietToiDaTrongNgay As Byte
    Private _tietGay As Byte
    Private _soTietHocToiDaTrongNgay As Integer

    Public Property SoTietToiDaTrongNgay() As Integer
        Get
            Return _soTietToiDaTrongNgay
        End Get
        Set(ByVal value As Integer)
            _soTietToiDaTrongNgay = value
        End Set
    End Property

    Public Property SoTietHocToiDaTrongNgay() As Integer
        Get
            Return _soTietHocToiDaTrongNgay
        End Get
        Set(ByVal value As Integer)
            _soTietHocToiDaTrongNgay = value
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
End Class
