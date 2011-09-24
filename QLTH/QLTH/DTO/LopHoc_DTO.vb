
Public Class LopHoc_DTO

#Region "Attributes"
    Private _maLopHoc As String
    Private _tenLopHoc As String
    Private _maKhoi As String
#End Region

#Region "Properties"
    Public Property MaLopHoc() As String
        Get
            Return _maLopHoc
        End Get
        Set(ByVal value As String)
            _maLopHoc = value
        End Set
    End Property

    Public Property TenLopHoc() As String
        Get
            Return _tenLopHoc
        End Get
        Set(ByVal value As String)
            _tenLopHoc = value
        End Set
    End Property

    Public Property MaKhoi() As String
        Get
            Return _maKhoi
        End Get
        Set(ByVal value As String)
            _maKhoi = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        _tenLopHoc = ""
        _maLopHoc = ""
        _maKhoi = ""
    End Sub
#End Region

End Class
