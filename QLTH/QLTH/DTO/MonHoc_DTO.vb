
Public Class MonHoc_DTO

#Region "Attributes"
    Private _maMonHoc As String
    Private _tenMonHoc As String
    Private _quiDinhSoTietHocLienTiepToiThieu As Integer
    Private _quiDinhSoTietHocLienTiepToiDa As Integer
#End Region

#Region "Properties"
    Public Property MaMonHoc() As String
        Get
            Return _maMonHoc
        End Get
        Set(ByVal value As String)
            _maMonHoc = value
        End Set
    End Property

    Public Property TenMonHoc() As String
        Get
            Return _tenMonHoc
        End Get
        Set(ByVal value As String)
            _tenMonHoc = value
        End Set
    End Property

    Public Property QuiDinhSoTietHocLienTiepToiThieu() As Integer
        Get
            Return _quiDinhSoTietHocLienTiepToiThieu
        End Get
        Set(ByVal value As Integer)
            _quiDinhSoTietHocLienTiepToiThieu = value
        End Set
    End Property

    Public Property QuiDinhSoTietHocLienTiepToiDa() As Integer
        Get
            Return _quiDinhSoTietHocLienTiepToiDa
        End Get
        Set(ByVal value As Integer)
            _quiDinhSoTietHocLienTiepToiDa = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        _maMonHoc = ""
        _tenMonHoc = ""
        _quiDinhSoTietHocLienTiepToiThieu = 0
        _quiDinhSoTietHocLienTiepToiDa = 0
    End Sub
#End Region

End Class
