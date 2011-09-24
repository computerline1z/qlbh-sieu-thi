Imports DTO
Imports System.Data.OleDb

Public Class ThamSo_DAO
    Inherits DataProvider

    Public Function LayDuLieu() As ThamSo_DTO
        Dim kq As New ThamSo_DTO
        Try
            Connect()
            Dim strQ As String = "SELECT * FROM THAMSO"
            Using rd As OleDbDataReader = ExecuteQuery(strQ)
                While (rd.Read())
                    kq.SoTietToiDaDuocHocTrongNgay = rd("SoTietToiDaDuocHocTrongNgay")
                    kq.SoTietToiDaTrongNgay = rd("SoTietToiDaTrongNgay")
                    kq.TietGay = rd("TietGay")
                End While
            End Using
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Sub CapNhatDuLieu(ByVal dl As ThamSo_DTO)
        Try
            Connect()
            Dim strQ As String = "UPDATE THAMSO SET SoTietToiDaTrongNgay=@SoTietToiDaTrongNgay , " & _
                                "SoTietToiDaDuocHocTrongNgay=@SoTietToiDaDuocHocTrongNgay , " & _
                                "TietGay=@TietGay"
            Dim dsThs(2) As OleDbParameter
            dsThs(0) = New OleDbParameter("@SoTietToiDaTrongNgay", DbType.Int32)
            dsThs(0).Value = dl.SoTietToiDaTrongNgay
            dsThs(1) = New OleDbParameter("@SoTietToiDaDuocHocTrongNgay", DbType.Int32)
            dsThs(1).Value = dl.SoTietToiDaDuocHocTrongNgay
            dsThs(2) = New OleDbParameter("@TietGay", DbType.Int32)
            dsThs(2).Value = dl.TietGay
            ExecuteNonQuery(strQ, dsThs)
            DisConnect()
        Catch ex As Exception
            DisConnect()
            Throw New Exception("Lỗi kết nối CSDL: " & ex.Message)
        End Try
    End Sub

End Class
