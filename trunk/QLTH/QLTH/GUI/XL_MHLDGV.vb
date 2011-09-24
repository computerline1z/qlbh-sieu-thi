Imports DTO
Imports BUS
Imports System.Data
Imports System.Collections

Partial Public Class MHChinh

    Private dsMaGVChoCBTenGV As New ArrayList
    Private dsMaMHChoCBMonPTr As New ArrayList

    Private Sub tabLichDayGV_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabLichDayGV.Enter
        Try
            Dim gvBUS As New GiaoVien_BUS
            Dim dsGV As ArrayList = gvBUS.LayDsGiaoVien()
            Dim dsTenGV As New ArrayList
            LDGV_gridDSGiaoVien.Rows.Clear()
            Ldgv_cbTenGiaoVien.Items.Clear()
            Dim ssTenGV As New SoSanhGV_DTO
            dsGV.Sort(ssTenGV)
            dsMaGVChoCBTenGV.Clear()
            Dim gvDTO As GiaoVien_DTO
            For i As Integer = 1 To dsGV.Count
                gvDTO = dsGV(i - 1)
                LDGV_gridDSGiaoVien.Rows.Add()
                LDGV_gridDSGiaoVien.Rows(i - 1).Cells(0).Value = i
                LDGV_gridDSGiaoVien.Rows(i - 1).Cells(1).Value = gvDTO.HoTenGiaoVien
                LDGV_gridDSGiaoVien.Rows(i - 1).Cells(2).Value = gvDTO.TenTat
                LDGV_gridDSGiaoVien.Rows(i - 1).Cells(3).Value = gvDTO.MaGiaoVien
                dsTenGV.Add(gvDTO.HoTenGiaoVien)
                dsMaGVChoCBTenGV.Add(gvDTO.MaGiaoVien)
            Next
            If (dsGV.Count > 0) Then
                Ldgv_cbTenGiaoVien.Items.AddRange(dsTenGV.ToArray())
                Ldgv_cbTenGiaoVien.SelectedIndex = 0
            End If
            Ldgv_gridLichDay.Rows.Clear()
            For i As Integer = 1 To 10
                Ldgv_gridLichDay.Rows.Add()
                Ldgv_gridLichDay.Rows(i - 1).Cells(0).Value = i
                For j As Integer = 1 To 7
                    Ldgv_gridLichDay.Rows(i - 1).Cells(j).Style.BackColor = Color.Red
                    Ldgv_gridLichDay.Rows(i - 1).Height = 30
                Next
            Next
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message.Replace("Lỗi: ", ""))
        End Try
    End Sub

    Private Sub LDGV_gridDSGiaoVien_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDGV_gridDSGiaoVien.Sorted
        Dim sd As Integer = LDGV_gridDSGiaoVien.Rows.Count
        For i As Integer = 1 To sd
            LDGV_gridDSGiaoVien.Rows(i - 1).Cells(0).Value = i
        Next
    End Sub

    Private Sub LDGV_gridDSGiaoVien_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LDGV_gridDSGiaoVien.SelectionChanged
        If (LDGV_gridDSGiaoVien.SelectedRows.Count > 0) Then
            Try
                Dim maGV As String = LDGV_gridDSGiaoVien.SelectedRows(0).Cells(3).Value
                Dim index As Integer = dsMaGVChoCBTenGV.IndexOf(maGV)
                Ldgv_cbTenGiaoVien.SelectedIndex = index
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message.Replace("Lỗi: ", ""))
            End Try
            
        End If
    End Sub

    Private Sub Ldgv_cbTenGiaoVien_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ldgv_cbTenGiaoVien.SelectedIndexChanged
        Dim index As Integer = Ldgv_cbTenGiaoVien.SelectedIndex
        If (index > -1) Then
            Try
                Dim gvBUS As New GiaoVien_BUS
                Dim gvDTO As GiaoVien_DTO = gvBUS.TimKiem(dsMaGVChoCBTenGV(index))
                Ldgv_txtMaGiaoVien.Text = gvDTO.MaGiaoVien
                Ldgv_txtTenTat.Text = gvDTO.TenTat
                Dim ptBUS As New PhuTrach_BUS
                'Lấy danh sách môn học giáo viên phụ trách
                Dim dsPTr As ArrayList = ptBUS.LayDSMonPhuTrach(gvDTO.MaGiaoVien)
                dsMaMHChoCBMonPTr.Clear()
                Ldgv_cbMonPhuTrach.Items.Clear()
                Dim ptDTO As PhuTrach_DTO
                Dim mhBUS As New MonHoc_BUS
                For i As Integer = 1 To dsPTr.Count
                    ptDTO = dsPTr(i - 1)
                    dsMaMHChoCBMonPTr.Add(ptDTO.MaMonHoc)
                    Ldgv_cbMonPhuTrach.Items.Add(mhBUS.LayTenMonHoc(ptDTO.MaMonHoc))
                Next
                If (dsPTr.Count > 0) Then
                    Ldgv_cbMonPhuTrach.SelectedIndex = 0
                End If
                'Lấy danh sách phân công của giáo viên với môn học đó
                Dim pcBUS As New PhanCong_BUS
                Dim dsPC As ArrayList = pcBUS.LayDSPhanCong(gvDTO.MaGiaoVien, dsMaMHChoCBMonPTr(0))
                Dim tongTiet As Integer = 0
                Dim pcDTO As New PhanCong_DTO
                For j As Integer = 1 To dsPC.Count
                    pcDTO = dsPC(j - 1)
                    tongTiet += pcDTO.SoTietHocTuan
                Next
                If (dsPC.Count > 0) Then
                    Ldgv_txtTongSoTietDay.Text = tongTiet
                    Ldgv_txtSoBuoiDayToiDa.Text = pcDTO.SoBuoiHocToiDa
                    Ldgv_txtSoTietDayToiThieu.Text = pcDTO.SoBuoiHocToiThieu
                Else
                    Ldgv_txtTongSoTietDay.Text = ""
                    Ldgv_txtSoBuoiDayToiDa.Text = ""
                    Ldgv_txtSoTietDayToiThieu.Text = ""
                End If

                XayDungGridLichHoc(dsPC)
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message.Replace("Lỗi: ", ""))
            End Try
            
        End If
    End Sub

    Private Sub Ldgv_btnGiaoVienKeTruoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ldgv_btnGiaoVienKeTruoc.Click
        Dim index As Integer = Ldgv_cbTenGiaoVien.SelectedIndex
        If (index > 0) Then
            index = index - 1
        Else
            index = dsMaGVChoCBTenGV.Count - 1
        End If
        Ldgv_cbTenGiaoVien.SelectedIndex = index
    End Sub

    Private Sub Ldgv_btnGiaoVienTiepTheo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ldgv_btnGiaoVienTiepTheo.Click
        Dim index As Integer = Ldgv_cbTenGiaoVien.SelectedIndex
        If (index < dsMaGVChoCBTenGV.Count - 1) Then
            index = index + 1
        Else
            index = 0
        End If
        Ldgv_cbTenGiaoVien.SelectedIndex = index
    End Sub

    Private Sub Ldgv_cbMonPhuTrach_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ldgv_cbMonPhuTrach.SelectedIndexChanged
        Dim index As Integer = Ldgv_cbMonPhuTrach.SelectedIndex
        If (index > -1) Then
            Try
                'Lấy danh sách phân công của giáo viên với môn học đó
                Dim pcBUS As New PhanCong_BUS
                Dim dsPC As ArrayList = pcBUS.LayDSPhanCong(Ldgv_txtMaGiaoVien.Text, dsMaMHChoCBMonPTr(index))
                Dim tongTiet As Integer = 0
                Dim pcDTO As New PhanCong_DTO
                For j As Integer = 1 To dsPC.Count
                    pcDTO = dsPC(j - 1)
                    tongTiet += pcDTO.SoTietHocTuan
                Next
                If (dsPC.Count > 0) Then
                    Ldgv_txtTongSoTietDay.Text = tongTiet
                    Ldgv_txtSoBuoiDayToiDa.Text = pcDTO.SoBuoiHocToiDa
                    Ldgv_txtSoTietDayToiThieu.Text = pcDTO.SoBuoiHocToiThieu
                Else
                    Ldgv_txtTongSoTietDay.Text = ""
                    Ldgv_txtSoBuoiDayToiDa.Text = ""
                    Ldgv_txtSoTietDayToiThieu.Text = ""
                End If

                XayDungGridLichHoc(dsPC)
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message.Replace("Lỗi: ", ""))
            End Try

        End If
    End Sub

    Private Sub XayDungGridLichHoc(ByVal dsPC As ArrayList)
        Dim pcDTO As PhanCong_DTO
        Dim llhDTO As LichLopHoc_DTO
        Dim llhBUS As New LichLopHoc_BUS
        Dim lhBUS As New LopHoc_BUS
        ResetMauCuaBangLDGV()

        For i As Integer = 1 To dsPC.Count
            pcDTO = dsPC(i - 1)
            llhDTO = llhBUS.LayLichHoc(pcDTO.MaPhanCong)
            If (llhDTO Is Nothing) Then
                Continue For
            End If
            Dim tenLH As String = lhBUS.LayTenLopHoc(pcDTO.MaLopHoc)
            Dim tenMH As String = Ldgv_cbMonPhuTrach.Text
            tenLH &= "(" & tenMH & ")"
            Dim thu As Integer = llhDTO.Thu - 1
            Dim tietBD As Integer = llhDTO.TietHocBatDau
            Dim soTiet As Integer = llhDTO.SoTietHoc

            For j As Integer = 1 To soTiet
                Ldgv_gridLichDay.Rows(tietBD + j - 1).Cells(thu).Value = tenLH
                Ldgv_gridLichDay.Rows(tietBD + j - 1).Cells(thu).Style.BackColor = Color.White
            Next
        Next
    End Sub

    Private Sub Ldgv_btnXuatRaTapTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ldgv_btnXuatRaTapTin.Click
        Using saveFileDialog As SaveFileDialog = GetExcelSaveFileDialog()
            If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim fileName As String = saveFileDialog.FileName
                ExcelGenerator.Generate(Ldgv_gridLichDay).Save(fileName)
                Process.Start(fileName)
            End If
        End Using
    End Sub

    Private Sub ResetMauCuaBangLDGV()
        If (Ldgv_gridLichDay.Rows.Count <> 10) Then
            Return
        End If
        For i As Integer = 1 To 10
            For j As Integer = 1 To 7
                Ldgv_gridLichDay.Rows(i - 1).Cells(j).Style.BackColor = Color.Red
                Ldgv_gridLichDay.Rows(i - 1).Cells(j).Value = ""
            Next
        Next
    End Sub
End Class
