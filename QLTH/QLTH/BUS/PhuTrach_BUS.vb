Imports DTO
Imports DAO

Public Class PhuTrach_BUS
    Public Function LayDSMonPhuTrach(ByVal maGV As String) As ArrayList
        Dim kq As ArrayList
        Try
            Dim ptDAO As New PhuTrach_DAO
            kq = ptDAO.LayDSMonPhuTrach(maGV)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        
        Return kq
    End Function

    Public Function KiemTraTonTai(ByVal maGV As String, ByVal maMH As String) As Boolean
        Dim kq As Boolean
        Try
            Dim ptDAO As New PhuTrach_DAO
            kq = ptDAO.KiemTraTonTai(maGV, maMH)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function
End Class
