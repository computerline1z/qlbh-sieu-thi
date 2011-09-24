
Public Class Khoi_DTO

#Region "Attributes"
    Private _maKhoi As String
    Private _tenKhoi As String
#End Region

#Region "Properties"
    Public Property MaKhoi() As String
        Get
            Return _maKhoi
        End Get
        Set(ByVal value As String)
            _maKhoi = value
        End Set
    End Property

    Public Property TenKhoi() As String
        Get
            Return _tenKhoi
        End Get
        Set(ByVal value As String)
            _tenKhoi = value
        End Set
    End Property
#End Region

#Region "Constructors"
    Public Sub New()
        _maKhoi = ""
        _tenKhoi = ""
    End Sub
#End Region

End Class
