Imports DAO
Imports DTO
Public Class TKBToanTruong_BUS
    Public Function LayThoiKhoaBieu() As ArrayList
        Dim kq As ArrayList
        Try
            Dim tkbDAO As New TKBToanTruong_DAO
            kq = tkbDAO.LayThoiKhoaBieu()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function
    Public Function LayThoiKhoaBieuKhoi10() As ArrayList
        Dim kq As ArrayList
        Try
            Dim tkb10DAO As New TKBToanTruong_DAO
            kq = tkb10DAO.LayThoiKhoaBieuKhoi10()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function
    Public Function LayThoiKhoaBieuKhoi11() As ArrayList
        Dim kq As ArrayList
        Try
            Dim tkb11DAO As New TKBToanTruong_DAO
            kq = tkb11DAO.LayThoiKhoaBieuKhoi11()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function
    Public Function LayThoiKhoaBieuKhoi12() As ArrayList
        Dim kq As ArrayList
        Try
            Dim tkb12DAO As New TKBToanTruong_DAO
            kq = tkb12DAO.LayThoiKhoaBieuKhoi12()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

End Class
