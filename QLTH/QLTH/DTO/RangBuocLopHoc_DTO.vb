Public Class RangBuocLopHoc_DTO

    Private _maRangBuocLopHoc As String
    Property MaRangBuocLopHoc() As String
        Get
            Return _maRangBuocLopHoc
        End Get
        Set(ByVal value As String)
            _maRangBuocLopHoc = value
        End Set
    End Property
    Private _maLopHoc As String
    Property MaLopHoc() As String
        Get
            Return _maLopHoc
        End Get
        Set(ByVal value As String)
            _maLopHoc = value
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
