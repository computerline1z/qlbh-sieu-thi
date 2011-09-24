Imports DTO
Imports DAO

Public Class MonHoc_BUS

    Public Function LayTenMonHoc(ByVal MaMH As String) As String
        Dim kq As String
        Try
            Dim mhDAO As New MonHoc_DAO
            kq = mhDAO.LayTenMonHoc(MaMH)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayMaMonHoc(ByVal tenMH As String) As String
        Dim kq As String
        Try
            Dim mhDAO As New MonHoc_DAO
            kq = mhDAO.LayMaMonHoc(tenMH)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayDSTenMonHoc() As ArrayList
        Dim kq As ArrayList
        Try
            Dim mhDAO As New MonHoc_DAO
            kq = mhDAO.LayDSTenMonHoc()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function TimMonHoc(ByVal MaMH As String) As MonHoc_DTO
        Dim kq As MonHoc_DTO
        Try
            Dim mhDAO As New MonHoc_DAO
            kq = mhDAO.TimMonHoc(MaMH)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Sub Them(ByVal mhDTO As MonHoc_DTO)
        Dim mhDAO As New MonHoc_DAO
        mhDAO.Them(mhDTO)
    End Sub
    Public Sub Xoa(ByVal maMonHoc As String)
        Dim mhDAO As New MonHoc_DAO
        mhDAO.Xoa(maMonHoc)
    End Sub
    Public Sub CapNhat(ByVal mhDTO As MonHoc_DTO)
        Dim mhDAO As New MonHoc_DAO
        mhDAO.CapNhat(mhDTO)
    End Sub
    Public Function TimKiem(ByVal maMonHoc As String) As IList
        Dim mhDAO As New MonHoc_DAO
        Return mhDAO.TimKiem(maMonHoc)
    End Function
    Public Function DemSoMonHoc() As Integer

    End Function
    Public Function LayBang() As DataTable
        Dim mhDAO As New MonHoc_DAO
        Return mhDAO.LayBang()
    End Function
    Public Function LayBangGiaoVien(ByVal monHoc As String) As DataTable
        Dim mhDAO As New MonHoc_DAO
        Return mhDAO.LayBangGiaoVienDay(monHoc)
    End Function
   
End Class
