Imports DTO
Imports BUS
Imports System.Data
Imports System.Collections

Partial Public Class MHChinh

    Private Sub PCGD_rdPhanCongTheoBoMon_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_rdPhanCongTheoBoMon.CheckedChanged
        If (PCGD_rdPhanCongTheoBoMon.Checked) Then
            Dim p As New Point(vitriBanDauCuaGRPDSMH.X, vitriBanDauCuaGRPDSMH.Y - 124)
            PCGD_grpDSMH.Location = p
            PCGD_grpTTLH.Visible = False
            PCGD_grpDSLH.Visible = True
            PCGD_grpTTGV.Visible = True
            Gd_btnLopKeTruoc.Text = "Giáo viên kế trước"
            Gd_btnLopTiepTheo.Text = "Giáo viên tiếp theo"
            PCGD_cbTenGV.SelectedIndex = 1
        End If
    End Sub

    Private Sub PCGD_cbTenGV_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_cbTenGV.SelectedIndexChanged
        Dim index As Integer = PCGD_cbTenGV.SelectedIndex
        If (index > -1) Then
            PCGD_cbTenTat.SelectedIndex = index
            For i As Integer = 1 To PCGD_gridDSGiaoVien.Rows.Count
                If (PCGD_gridDSGiaoVien.Rows(i - 1).Cells(3).Value = luuDSMaGV(index)) Then
                    PCGD_gridDSGiaoVien.Rows(i - 1).Selected = True
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub PCGD_cbTenTat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_cbTenTat.SelectedIndexChanged
        Dim index As Integer = PCGD_cbTenTat.SelectedIndex
        If (index > -1) Then
            PCGD_cbTenGV.SelectedIndex = index
        End If
    End Sub

    Private Sub PCGD_clbDSLH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_clbDSLH.SelectedIndexChanged
        Dim index As Integer = PCGD_clbDSLH.SelectedIndex
        If (index > -1) Then
            If (PCGD_clbDSLH.GetItemChecked(index)) Then
                If (MessageBox.Show("Bạn có đồng ý xóa những phân công của lớp học này ? (lớp " & _
                    PCGD_clbDSLH.Items.Item(index) & ")", _
                    "Chú ý", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                    PCGD_clbDSLH.SetItemChecked(index, False)
                End If
            Else
                PCGD_clbDSLH.SetItemChecked(index, True)
            End If
            PCGD_clbDSLH.ClearSelected()
        End If
    End Sub


    Private Sub Gd_btnCapNhatDuLieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gd_btnCapNhatDuLieu.Click
        MessageBox.Show("Dữ liệu hợp lệ đã được cập nhật tự động khi bạn sửa đổi trực tiếp trên bảng")
    End Sub

    Private Sub PCGD_clbDSLH_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles PCGD_clbDSLH.ItemCheck
        Dim index As Integer = e.Index
        Dim tenLH As String = PCGD_clbDSLH.Items.Item(index)
        If (e.CurrentValue = CheckState.Checked And daHoanThanhGridPC) Then
            Dim pcBUS As New PhanCong_BUS
            daHoanThanhGridPC = False
            For i As Integer = PCGD_gridBangPhanCong.Rows.Count To 1 Step -1
                If (PCGD_gridBangPhanCong.Rows(i - 1).Cells(1).Value = tenLH) Then
                    Try
                        pcBUS.XoaPhanCong(PCGD_gridBangPhanCong.Rows(i - 1).Cells(9).Value)
                        PCGD_gridBangPhanCong.Rows.RemoveAt(i - 1)
                    Catch ex As Exception
                        MessageBox.Show("Lỗi: " & ex.Message)
                    End Try
                End If
            Next
            For j As Integer = 1 To PCGD_gridBangPhanCong.Rows.Count
                PCGD_gridBangPhanCong.Rows(j - 1).Cells(0).Value = j
            Next
            daHoanThanhGridPC = True
            vuaxoaPC = True
            csRowDangSua = -1
            Return
        End If

        If (e.CurrentValue = CheckState.Unchecked And daHoanThanhGridPC) Then
            Dim dongmoi As DataGridViewRow
            Dim cs As Integer = 1
            For i As Integer = 1 To PCGD_clbDSMH.Items.Count
                If (PCGD_clbDSLH.GetItemChecked(i - 1)) Then
                    dongmoi = New DataGridViewRow
                    dongmoi.CreateCells(PCGD_gridBangPhanCong)
                    dongmoi.Cells(0).Value = PCGD_gridBangPhanCong.Rows.Count + 1
                    dongmoi.Cells(1).Value = tenLH
                    dongmoi.Cells(4).Value = PCGD_gridDSGiaoVien.SelectedCells(3).Value
                    dongmoi.Cells(2).Value = PCGD_clbDSMH.Items.Item(i - 1)
                    dongmoi.Cells(9).Value = TaoMaPCMoi(cs)
                    cs = cs + 1
                    PCGD_gridBangPhanCong.Rows.Add(dongmoi)
                End If
            Next
        End If
    End Sub

    Private Sub Gd_btnXuatRaTapTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gd_btnXuatRaTapTin.Click
        Using saveFileDialog As SaveFileDialog = GetExcelSaveFileDialog()
            If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim fileName As String = saveFileDialog.FileName
                ExcelGenerator.Generate(PCGD_gridBangPhanCong).Save(fileName)
                Process.Start(fileName)
            End If
        End Using
    End Sub

End Class
