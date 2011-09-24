Imports DTO
Imports DAO

Public Class LichLopHoc_BUS

    Public Function LayLichHoc(ByVal maPC As String) As LichLopHoc_DTO
        Dim kq As LichLopHoc_DTO
        Try
            Dim llhDAO As New LichLopHoc_DAO
            kq = llhDAO.LayLichHoc(maPC)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayDSLichHoc(ByVal maPC As String) As ArrayList
        Dim kq As ArrayList
        Try
            Dim llhDAO As New LichLopHoc_DAO
            kq = llhDAO.LayDSLichHoc(maPC)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

End Class
