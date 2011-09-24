
Public Class PhuTrach_DTO

#Region "Attributes"
    Private _maPhuTrach As String
    Private _maGiaoVien As String
    Private _maMonHoc As String
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

    Public Property MaPhuTrach() As String
        Get
            Return _maPhuTrach
        End Get
        Set(ByVal value As String)
            _maPhuTrach = value
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
#End Region

#Region "Constructors"
    Public Sub New()
        _maPhuTrach = ""
        _maGiaoVien = ""
        _maMonHoc = ""
    End Sub
#End Region

End Class
