Imports DTO
Imports System.Data.OleDb

Public Class QuyDinh_DAO
    Inherits DataProvider

    Public Function LayQuyDinh() As QuyDinh_DTO
        Dim Kq As New QuyDinh_DTO

        ' Kết nối CSDL
        Connect()

        ' Chuẩn bị câu truy vấn
        Dim cauTruyVan As String
        cauTruyVan = "select * from ThamSo"

        ' Thực thi truy vấn
        Dim reader As OleDb.OleDbDataReader = ExecuteQuery(cauTruyVan)

        ' Thao tác với dữ liệu đọc được
        reader.Read()
        Kq.SoTietToiDaTrongNgay = reader.GetByte(0)
        Kq.TietGay = reader.GetByte(1)
        Kq.SoTietHocToiDaTrongNgay = reader.GetInt16(2)

        ' Đóng kết nối
        DisConnect()
       
        Return Kq
    End Function

    Public Sub CapNhat(ByVal dl As QuyDinh_DTO)
        Try
            Connect()
            Dim strQ As String = "UPDATE THAMSO SET SoTietToiDaTrongNgay=@SoTietToiDaTrongNgay , " & _
                                "SoTietToiDaDuocHocTrongNgay=@SoTietToiDaDuocHocTrongNgay , " & _
                                "TietGay=@TietGay"
            Dim dsThs(2) As OleDbParameter
            dsThs(0) = New OleDbParameter("@SoTietToiDaTrongNgay", DbType.Byte)
            dsThs(0).Value = dl.SoTietToiDaTrongNgay
            dsThs(1) = New OleDbParameter("@SoTietToiDaDuocHocTrongNgay", DbType.Byte)
            dsThs(1).Value = dl.SoTietHocToiDaTrongNgay
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
