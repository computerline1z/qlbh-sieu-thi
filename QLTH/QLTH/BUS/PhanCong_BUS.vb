Imports DTO
Imports DAO

Public Class PhanCong_BUS

    Public Function LayDSPhanCong(ByVal maGV As String, ByVal maMH As String) As ArrayList
        Dim kq As ArrayList
        Try
            Dim pcDAO As New PhanCong_DAO
            kq = pcDAO.LayDSPhanCong(maGV, maMH)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayDSPhanCongTheoLH(ByVal maLH As String) As ArrayList
        Dim kq As ArrayList
        Try
            Dim pcDAO As New PhanCong_DAO
            kq = pcDAO.LayDSPhanCongTheoLH(maLH)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function LayDSPhanCongTheoGV(ByVal maGV As String) As ArrayList
        Dim kq As ArrayList
        Try
            Dim pcDAO As New PhanCong_DAO
            kq = pcDAO.LayDSPhanCongTheoGV(maGV)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Function CapNhatPhanCong(ByVal pcDTO As PhanCong_DTO) As String
        Dim kq As String = ""
        Try
            If (pcDTO.MaPhanCong Is Nothing Or pcDTO.MaMonHoc Is Nothing Or _
                pcDTO.MaGiaoVien Is Nothing Or pcDTO.MaLopHoc Is Nothing) Then
                kq &= "Dữ liệu chưa đầy đủ"
                Return kq
            End If
            Dim ptrBUS As New PhuTrach_BUS
            If (Not ptrBUS.KiemTraTonTai(pcDTO.MaGiaoVien, pcDTO.MaMonHoc)) Then
                kq &= "Giáo viên không thể phụ trách môn học này."
                Return kq
            End If
            Dim mhBUS As New MonHoc_BUS
            Dim mhDTO As MonHoc_DTO = mhBUS.TimMonHoc(pcDTO.MaMonHoc)
            If (pcDTO.SoTietHocLienTiepToiThieu < mhDTO.QuiDinhSoTietHocLienTiepToiThieu Or _
                pcDTO.SoTietHocLienTiepToiDa > mhDTO.QuiDinhSoTietHocLienTiepToiDa) Then

                kq &= "Số tiết học liên tiếp không hợp lệ"
                Return kq
            End If

            If (pcDTO.SoBuoiHocToiThieu <= 0 Or pcDTO.SoBuoiHocToiThieu > 12 Or _
                pcDTO.SoBuoiHocToiThieu > pcDTO.SoBuoiHocToiDa Or _
                pcDTO.SoBuoiHocToiDa <= 0 Or pcDTO.SoBuoiHocToiDa > 12) Then
                kq &= "Số buổi học không hợp lệ"
                Return kq
            End If

            If (pcDTO.SoTietHocTuan <= 0 Or pcDTO.SoTietHocTuan > 60) Then
                kq &= "Số tiết học trong tuần không hợp lệ"
                Return kq
            End If

            If (pcDTO.SoBuoiHocToiThieu * pcDTO.SoTietHocLienTiepToiDa > pcDTO.SoTietHocTuan Or _
                pcDTO.SoBuoiHocToiDa * pcDTO.SoTietHocLienTiepToiThieu > pcDTO.SoTietHocTuan) Then
                kq &= "Mối quan hệ giữa các tiết học, buổi học và tổng tiết trong tuần không hợp lệ"
                Return kq
            End If
            Dim pcDAO As New PhanCong_DAO
            If (Not pcDAO.CapNhatPhanCong(pcDTO)) Then
                kq &= "Không thể cập nhật phân công này."
            End If
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Sub Xoa(ByVal MaLopHoc As String)
        Dim PhanCongDAO As PhanCong_DAO = New PhanCong_DAO()
        PhanCongDAO.Xoa(MaLopHoc)
    End Sub

    Public Function ThemVaoPhanCong(ByVal pcDTO As PhanCong_DTO) As String
        Dim kq As String = ""
        Try
            If (pcDTO.MaPhanCong Is Nothing Or pcDTO.MaMonHoc Is Nothing Or _
                pcDTO.MaGiaoVien Is Nothing Or pcDTO.MaLopHoc Is Nothing) Then
                kq &= "Dữ liệu chưa đầy đủ"
                Return kq
            End If
            Dim ptrBUS As New PhuTrach_BUS
            If (Not ptrBUS.KiemTraTonTai(pcDTO.MaGiaoVien, pcDTO.MaMonHoc)) Then
                kq &= "Giáo viên không thể phụ trách môn học này."
                Return kq
            End If
            Dim mhBUS As New MonHoc_BUS
            Dim mhDTO As MonHoc_DTO = mhBUS.TimMonHoc(pcDTO.MaMonHoc)
            If (pcDTO.SoTietHocLienTiepToiThieu < mhDTO.QuiDinhSoTietHocLienTiepToiThieu Or _
                pcDTO.SoTietHocLienTiepToiDa > mhDTO.QuiDinhSoTietHocLienTiepToiDa) Then

                kq &= "Số tiết học liên tiếp không hợp lệ"
                Return kq
            End If

            If (pcDTO.SoBuoiHocToiThieu <= 0 Or pcDTO.SoBuoiHocToiThieu > 12 Or _
                pcDTO.SoBuoiHocToiThieu > pcDTO.SoBuoiHocToiDa Or _
                pcDTO.SoBuoiHocToiDa <= 0 Or pcDTO.SoBuoiHocToiDa > 12) Then
                kq &= "Số buổi học không hợp lệ"
                Return kq
            End If

            If (pcDTO.SoTietHocTuan <= 0 Or pcDTO.SoTietHocTuan > 60) Then
                kq &= "Số tiết học trong tuần không hợp lệ"
                Return kq
            End If

            If (pcDTO.SoBuoiHocToiThieu * pcDTO.SoTietHocLienTiepToiDa > pcDTO.SoTietHocTuan Or _
                pcDTO.SoBuoiHocToiDa * pcDTO.SoTietHocLienTiepToiThieu > pcDTO.SoTietHocTuan) Then
                kq &= "Mối quan hệ giữa các tiết học, buổi học và tổng tiết trong tuần không hợp lệ"
                Return kq
            End If
            Dim pcDAO As New PhanCong_DAO
            pcDTO.MaPhanCong = pcDTO.MaPhanCong.Replace("MoiThem", "")
            If (Not pcDAO.ThemVaoPhanCong(pcDTO)) Then
                kq &= "Không thể thêm phân công này."
            End If
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

    Public Sub XoaPhanCong(ByVal maPC As String)
        Try
            Dim pcDAO As New PhanCong_DAO
            pcDAO.XoaPhanCong(maPC)
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
    End Sub

    Public Function LayMaCuoiCungCuaPhanCong() As String
        Dim kq As String = ""
        Try
            Dim pcDAO As New PhanCong_DAO
            kq = pcDAO.LayMaCuoiCungCuaPhanCong()
        Catch ex As Exception
            Throw New Exception("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function
End Class
