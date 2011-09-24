Imports DTO
Imports BUS
Imports System.Data
Imports System.Collections

Partial Public Class MHChinh
    Private vitriBanDauCuaGRPDSMH As Point
    Private daVaoTabPCGD As Boolean = False
    Private luuDSMaGV As New ArrayList
    Private daHoanThanhGridGV As Boolean = False
    Private daHoanThanhGridPC As Boolean = False
    Private csRowDangSua As Integer = -1
    Private currentpcDTO As New PhanCong_DTO
    Private moivaoTabPC As Boolean = False
    Private vuaxoaPC As Boolean = False

    Private Sub tabPcgd_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabPcgd.Enter
        If (Not daVaoTabPCGD) Then
            PCGD_rdKhoi11.Checked = True
            daVaoTabPCGD = True
            vitriBanDauCuaGRPDSMH = PCGD_grpDSMH.Location
        End If
        Try
            moivaoTabPC = True
            Dim gvBUS As New GiaoVien_BUS
            Dim dsGV As ArrayList = gvBUS.LayDsGiaoVien()
            PCGD_gridDSGiaoVien.Rows.Clear()
            PCGD_cbTenGV.Items.Clear()
            PCGD_cbTenTat.Items.Clear()
            luuDSMaGV.Clear()
            Dim ssTenGV As New SoSanhGV_DTO
            dsGV.Sort(ssTenGV)
            Dim tableGV As New DataTable
            Dim cot As New DataColumn("MaGV")
            tableGV.Columns.Add(cot)
            cot = New DataColumn("TenGV")
            tableGV.Columns.Add(cot)
            Dim dong As DataRow
            Dim gvDTO As GiaoVien_DTO
            daHoanThanhGridGV = False
            For i As Integer = 1 To dsGV.Count
                gvDTO = dsGV(i - 1)
                dong = tableGV.NewRow()
                PCGD_gridDSGiaoVien.Rows.Add()
                PCGD_gridDSGiaoVien.Rows(i - 1).Cells(0).Value = i
                PCGD_gridDSGiaoVien.Rows(i - 1).Cells(1).Value = gvDTO.HoTenGiaoVien
                dong("TenGV") = gvDTO.HoTenGiaoVien
                PCGD_cbTenGV.Items.Add(gvDTO.HoTenGiaoVien)
                PCGD_gridDSGiaoVien.Rows(i - 1).Cells(2).Value = gvDTO.TenTat
                PCGD_gridDSGiaoVien.Rows(i - 1).Cells(3).Value = gvDTO.MaGiaoVien
                dong("MaGV") = gvDTO.MaGiaoVien
                tableGV.Rows.Add(dong)
                PCGD_cbTenTat.Items.Add(gvDTO.TenTat)
                luuDSMaGV.Add(gvDTO.MaGiaoVien)
            Next
            Column_GV.DataSource = tableGV
            Column_GV.DisplayMember = "TenGV"
            Column_GV.ValueMember = "MaGV"
            daHoanThanhGridGV = True
            TaoDSMH()
            TaoDSLH()

            PCGD_rdKhoi10.Checked = True
            PCGD_cbTenLopHoc.SelectedIndex = 0
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub TaoDSMH()
        Dim mhBUS As New MonHoc_BUS
        Dim dsMH As ArrayList = mhBUS.LayDSTenMonHoc()
        PCGD_clbDSMH.Items.Clear()
        For i As Integer = 1 To dsMH.Count
            PCGD_clbDSMH.Items.Add(dsMH(i - 1), False)
        Next
    End Sub

    Private Sub TaoDSLH()
        Dim lhBUS As New LopHoc_BUS
        Dim dsLH As ArrayList = lhBUS.LayDSTenLop()
        PCGD_clbDSLH.Items.Clear()
        For i As Integer = 1 To dsLH.Count
            PCGD_clbDSLH.Items.Add(dsLH(i - 1), False)
        Next
    End Sub

    Private Sub PCGD_rdKhoi10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_rdKhoi10.CheckedChanged
        If (PCGD_rdKhoi10.Checked And daVaoTabPCGD) Then
            Try
                Dim lhBUS As New LopHoc_BUS
                Dim dsLH As ArrayList = lhBUS.LayDSLopHocTheoKhoi("Khoi 10")
                PCGD_cbTenLopHoc.Items.Clear()
                Dim lhDTO As LopHoc_DTO
                For i As Integer = 1 To dsLH.Count
                    lhDTO = dsLH(i - 1)
                    PCGD_cbTenLopHoc.Items.Add(lhDTO.TenLopHoc)
                Next
                PCGD_cbTenLopHoc.Items.Add(" ")
                If (dsLH.Count > 0) Then
                    PCGD_cbTenLopHoc.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PCGD_rdKhoi11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_rdKhoi11.CheckedChanged
        If (PCGD_rdKhoi11.Checked And daVaoTabPCGD) Then
            Try
                Dim lhBUS As New LopHoc_BUS
                Dim dsLH As ArrayList = lhBUS.LayDSLopHocTheoKhoi("Khoi 11")
                PCGD_cbTenLopHoc.Items.Clear()
                Dim lhDTO As LopHoc_DTO
                For i As Integer = 1 To dsLH.Count
                    lhDTO = dsLH(i - 1)
                    PCGD_cbTenLopHoc.Items.Add(lhDTO.TenLopHoc)
                Next
                PCGD_cbTenLopHoc.Items.Add(" ")
                If (dsLH.Count > 0) Then
                    PCGD_cbTenLopHoc.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PCGD_rdKhoi12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_rdKhoi12.CheckedChanged
        If (PCGD_rdKhoi12.Checked And daVaoTabPCGD) Then
            Try
                Dim lhBUS As New LopHoc_BUS
                Dim dsLH As ArrayList = lhBUS.LayDSLopHocTheoKhoi("Khoi 12")
                PCGD_cbTenLopHoc.Items.Clear()
                Dim lhDTO As LopHoc_DTO
                For i As Integer = 1 To dsLH.Count
                    lhDTO = dsLH(i - 1)
                    PCGD_cbTenLopHoc.Items.Add(lhDTO.TenLopHoc)
                Next
                PCGD_cbTenLopHoc.Items.Add(" ")
                If (dsLH.Count > 0) Then
                    PCGD_cbTenLopHoc.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PCGD_rdTatCa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_rdTatCa.CheckedChanged
        If (PCGD_rdTatCa.Checked And daVaoTabPCGD) Then
            Try
                Dim lhBUS As New LopHoc_BUS
                Dim dsLH As ArrayList = lhBUS.LayDSLopHocTheoKhoi("all")
                PCGD_cbTenLopHoc.Items.Clear()
                Dim lhDTO As LopHoc_DTO
                For i As Integer = 1 To dsLH.Count
                    lhDTO = dsLH(i - 1)
                    PCGD_cbTenLopHoc.Items.Add(lhDTO.TenLopHoc)
                Next
                PCGD_cbTenLopHoc.Items.Add(" ")
                If (dsLH.Count > 0) Then
                    PCGD_cbTenLopHoc.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub PCGD_cbTenLopHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_cbTenLopHoc.SelectedIndexChanged
        Dim index As Integer = PCGD_cbTenLopHoc.SelectedIndex
        If (index <> -1 And index < PCGD_cbTenLopHoc.Items.Count - 1) Then
            Try
                Dim tenLH As String = PCGD_cbTenLopHoc.Text
                Dim lhBUS As New LopHoc_BUS
                Dim maLH As String = lhBUS.LayMaLopHoc(tenLH)
                PCGD_txtMaLopHoc.Text = maLH
                CapNhatDSPhanCongTheoLH()
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub Gd_btnLopKeTruoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gd_btnLopKeTruoc.Click
        If (PCGD_rdPhanCongTheoLop.Checked) Then
            Dim index As Integer = PCGD_cbTenLopHoc.SelectedIndex
            If (index = 0) Then
                index = PCGD_cbTenLopHoc.Items.Count - 1
            End If
            index = index - 1
            PCGD_cbTenLopHoc.SelectedIndex = index
        End If

    End Sub

    Private Sub Gd_btnLopTiepTheo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gd_btnLopTiepTheo.Click
        If (PCGD_rdPhanCongTheoLop.Checked) Then
            Dim index As Integer = PCGD_cbTenLopHoc.SelectedIndex
            If (index = PCGD_cbTenLopHoc.Items.Count - 2) Then
                index = -1
            End If
            index = index + 1
            PCGD_cbTenLopHoc.SelectedIndex = index
        End If
    End Sub

    Private Sub PCGD_gridDSGiaoVien_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_gridDSGiaoVien.SelectionChanged
        If (moivaoTabPC) Then
            moivaoTabPC = False
            Return
        End If
        If (PCGD_gridDSGiaoVien.SelectedRows.Count > 0 And daHoanThanhGridGV And Not moivaoTabPC) Then
            Try
                Dim maGV As String = PCGD_gridDSGiaoVien.SelectedRows(0).Cells(3).Value
                CapNhatDSPhanCongTheoGV(maGV)
                PCGD_cbTenLopHoc.SelectedIndex = PCGD_cbTenLopHoc.Items.Count - 1
                Dim index As Integer = luuDSMaGV.IndexOf(maGV)
                PCGD_cbTenGV.SelectedIndex = index
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message.Replace("Lỗi: ", ""))
            End Try
        End If
    End Sub

    Private Sub CapNhatDSPhanCongTheoLH()
        Try
            Dim maLH As String = PCGD_txtMaLopHoc.Text
            Dim gvBUS As New GiaoVien_BUS
            Dim pcBUS As New PhanCong_BUS
            Dim dsPC As ArrayList = pcBUS.LayDSPhanCongTheoLH(maLH)
            Dim lhBUS As New LopHoc_BUS
            Dim mhBUS As New MonHoc_BUS

            daHoanThanhGridPC = False
            PCGD_gridBangPhanCong.Rows.Clear()
            For j As Integer = 1 To PCGD_clbDSMH.Items.Count
                PCGD_clbDSMH.SetItemChecked(j - 1, False)
            Next
            Dim index As Integer
            Dim pcDTO As PhanCong_DTO
            For i As Integer = 1 To dsPC.Count
                pcDTO = dsPC(i - 1)

                PCGD_gridBangPhanCong.Rows.Add()
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(0).Value = i
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(1).Value = lhBUS.LayTenLopHoc(pcDTO.MaLopHoc)
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(2).Value = mhBUS.LayTenMonHoc(pcDTO.MaMonHoc)
                index = PCGD_clbDSMH.Items.IndexOf(PCGD_gridBangPhanCong.Rows(i - 1).Cells(2).Value)
                PCGD_clbDSMH.SetItemChecked(index, True)
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(3).Value = pcDTO.SoTietHocTuan
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(4).Value = pcDTO.MaGiaoVien
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(5).Value = pcDTO.SoTietHocLienTiepToiThieu
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(6).Value = pcDTO.SoTietHocLienTiepToiDa
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(7).Value = pcDTO.SoBuoiHocToiThieu
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(8).Value = pcDTO.SoBuoiHocToiDa
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(9).Value = pcDTO.MaPhanCong
            Next
            PCGD_gridBangPhanCong.Columns(4).ReadOnly = False
            daHoanThanhGridPC = True
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub CapNhatDSPhanCongTheoGV(ByVal maGV As String)
        Try
            Dim gvBUS As New GiaoVien_BUS
            Dim pcBUS As New PhanCong_BUS
            Dim dsPC As ArrayList = pcBUS.LayDSPhanCongTheoGV(maGV)
            Dim lhBUS As New LopHoc_BUS
            Dim mhBUS As New MonHoc_BUS

            daHoanThanhGridPC = False
            PCGD_gridBangPhanCong.Rows.Clear()
            For j As Integer = 1 To PCGD_clbDSMH.Items.Count
                PCGD_clbDSMH.SetItemChecked(j - 1, False)
            Next
            For k As Integer = 1 To PCGD_clbDSLH.Items.Count
                PCGD_clbDSLH.SetItemChecked(k - 1, False)
            Next
            Dim index As Integer
            Dim pcDTO As PhanCong_DTO
            For i As Integer = 1 To dsPC.Count
                pcDTO = dsPC(i - 1)

                PCGD_gridBangPhanCong.Rows.Add()
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(0).Value = i
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(1).Value = lhBUS.LayTenLopHoc(pcDTO.MaLopHoc)
                index = PCGD_clbDSLH.Items.IndexOf(PCGD_gridBangPhanCong.Rows(i - 1).Cells(1).Value)
                PCGD_clbDSLH.SetItemChecked(index, True)
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(2).Value = mhBUS.LayTenMonHoc(pcDTO.MaMonHoc)
                index = PCGD_clbDSMH.Items.IndexOf(PCGD_gridBangPhanCong.Rows(i - 1).Cells(2).Value)
                PCGD_clbDSMH.SetItemChecked(index, True)
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(3).Value = pcDTO.SoTietHocTuan
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(4).Value = pcDTO.MaGiaoVien
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(5).Value = pcDTO.SoTietHocLienTiepToiThieu
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(6).Value = pcDTO.SoTietHocLienTiepToiDa
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(7).Value = pcDTO.SoBuoiHocToiThieu
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(8).Value = pcDTO.SoBuoiHocToiDa
                PCGD_gridBangPhanCong.Rows(i - 1).Cells(9).Value = pcDTO.MaPhanCong
            Next
            PCGD_gridBangPhanCong.Columns(4).ReadOnly = True
            daHoanThanhGridPC = True
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
    End Sub

    Private Sub PCGD_gridDSGiaoVien_Sorted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_gridDSGiaoVien.Sorted
        Dim sd As Integer = PCGD_gridDSGiaoVien.Rows.Count
        For i As Integer = 1 To sd
            PCGD_gridDSGiaoVien.Rows(i - 1).Cells(0).Value = i
        Next
    End Sub

    Private Sub PCGD_rdPhanCongTheoLop_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_rdPhanCongTheoLop.CheckedChanged
        If (PCGD_rdPhanCongTheoLop.Checked And daVaoTabPCGD) Then
            Dim p As New Point(vitriBanDauCuaGRPDSMH.X, vitriBanDauCuaGRPDSMH.Y)
            PCGD_grpDSMH.Location = p
            PCGD_grpTTLH.Visible = True
            PCGD_grpDSLH.Visible = False
            PCGD_grpTTGV.Visible = False
            Gd_btnLopKeTruoc.Text = "Lớp kế trước"
            Gd_btnLopTiepTheo.Text = "Lớp tiếp theo"
        End If
    End Sub

    Private Sub PCGD_clbDSMH_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_clbDSMH.SelectedIndexChanged
        Dim index As Integer = PCGD_clbDSMH.SelectedIndex
        If (index > -1) Then
            If (PCGD_clbDSMH.GetItemChecked(index)) Then
                If (MessageBox.Show("Bạn có đồng ý xóa những phân công của môn học này ? (môn " & _
                    PCGD_clbDSMH.Items.Item(index) & ")", _
                    "Chú ý", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes) Then
                    PCGD_clbDSMH.SetItemChecked(index, False)
                End If
            Else
                PCGD_clbDSMH.SetItemChecked(index, True)
            End If
            PCGD_clbDSMH.ClearSelected()
        End If
    End Sub


    Private Sub PCGD_gridBangPhanCong_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PCGD_gridBangPhanCong.SelectionChanged
        Try
            If (Not daHoanThanhGridPC) Then
                Return
            End If
            If (vuaxoaPC) Then
                vuaxoaPC = False
                Return
            End If
            If (csRowDangSua > -1) Then
                If (KiemTraCoEditPC()) Then
                    Dim mhBUS As New MonHoc_BUS
                    Dim lhBUS As New LopHoc_BUS
                    Dim capnhatPC As New PhanCong_DTO
                    capnhatPC.MaMonHoc = mhBUS.LayMaMonHoc(PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(2).Value)
                    capnhatPC.MaLopHoc = lhBUS.LayMaLopHoc(PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(1).Value)
                    capnhatPC.SoTietHocTuan = PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(3).Value
                    capnhatPC.MaGiaoVien = PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(4).Value
                    capnhatPC.SoTietHocLienTiepToiThieu = PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(5).Value
                    capnhatPC.SoTietHocLienTiepToiDa = PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(6).Value
                    capnhatPC.SoBuoiHocToiThieu = PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(7).Value
                    capnhatPC.SoBuoiHocToiDa = PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(8).Value
                    capnhatPC.MaPhanCong = PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(9).Value

                    Dim pcBUS As New PhanCong_BUS
                    Dim kq As String
                    If (capnhatPC.MaPhanCong.IndexOf("MoiThem") = -1) Then
                        kq = "CN" & pcBUS.CapNhatPhanCong(capnhatPC)
                    Else
                        kq = "CN" & pcBUS.ThemVaoPhanCong(capnhatPC)
                    End If

                    If (kq <> "CN") Then
                        PCGD_gridBangPhanCong.Rows(csRowDangSua).DefaultCellStyle.BackColor = Color.Red
                        Dim kqChon = MessageBox.Show(kq.Replace("CN", "") & vbCrLf & "(nhấn Abort để trở về mặc định, " & _
                                    "Retry để sửa lại và Ignore để bỏ qua)", "Lỗi cập nhật", MessageBoxButtons.AbortRetryIgnore)
                        If (kqChon = DialogResult.Abort) Then
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(2).Value = currentpcDTO.MaMonHoc
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(1).Value = currentpcDTO.MaLopHoc
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(3).Value = currentpcDTO.SoTietHocTuan
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(4).Value = currentpcDTO.MaGiaoVien
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(5).Value = currentpcDTO.SoTietHocLienTiepToiThieu
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(6).Value = currentpcDTO.SoTietHocLienTiepToiDa
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(7).Value = currentpcDTO.SoBuoiHocToiThieu
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(8).Value = currentpcDTO.SoBuoiHocToiDa
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(9).Value = currentpcDTO.MaPhanCong
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).DefaultCellStyle.BackColor = Color.DodgerBlue
                        End If
                        If (kqChon = DialogResult.Retry) Then
                            PCGD_gridBangPhanCong.Rows(csRowDangSua).Selected = True
                            Return
                        End If
                    Else
                        PCGD_gridBangPhanCong.Rows(csRowDangSua).DefaultCellStyle.BackColor = Color.DodgerBlue
                        MessageBox.Show("Đã cập nhật thành công")
                    End If
                End If
            End If
            If (PCGD_gridBangPhanCong.SelectedRows.Count > 0) Then
                csRowDangSua = PCGD_gridBangPhanCong.SelectedRows(0).Index
                currentpcDTO.MaMonHoc = PCGD_gridBangPhanCong.SelectedRows(0).Cells(2).Value
                currentpcDTO.MaLopHoc = PCGD_gridBangPhanCong.SelectedRows(0).Cells(1).Value
                currentpcDTO.SoTietHocTuan = PCGD_gridBangPhanCong.SelectedRows(0).Cells(3).Value
                currentpcDTO.MaGiaoVien = PCGD_gridBangPhanCong.SelectedRows(0).Cells(4).Value
                currentpcDTO.SoTietHocLienTiepToiThieu = PCGD_gridBangPhanCong.SelectedRows(0).Cells(5).Value
                currentpcDTO.SoTietHocLienTiepToiDa = PCGD_gridBangPhanCong.SelectedRows(0).Cells(6).Value
                currentpcDTO.SoBuoiHocToiThieu = PCGD_gridBangPhanCong.SelectedRows(0).Cells(7).Value
                currentpcDTO.SoBuoiHocToiDa = PCGD_gridBangPhanCong.SelectedRows(0).Cells(8).Value
                currentpcDTO.MaPhanCong = PCGD_gridBangPhanCong.SelectedRows(0).Cells(9).Value
            End If
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try

    End Sub

    Private Function KiemTraCoEditPC() As Boolean
        Dim kq As Boolean = False
        If (currentpcDTO.MaGiaoVien <> PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(4).Value) Then
            Return True
        End If
        If (currentpcDTO.SoTietHocTuan <> PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(3).Value) Then
            Return True
        End If
        If (currentpcDTO.SoTietHocLienTiepToiThieu <> PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(5).Value) Then
            Return True
        End If
        If (currentpcDTO.SoTietHocLienTiepToiDa <> PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(6).Value) Then
            Return True
        End If
        If (currentpcDTO.SoBuoiHocToiThieu <> PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(7).Value) Then
            Return True
        End If
        If (currentpcDTO.SoBuoiHocToiDa <> PCGD_gridBangPhanCong.Rows(csRowDangSua).Cells(8).Value) Then
            Return True
        End If
        Return kq
    End Function

    Private Sub PCGD_clbDSMH_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles PCGD_clbDSMH.ItemCheck
        Dim index As Integer = e.Index
        Dim tenMH As String = PCGD_clbDSMH.Items.Item(index)
        If (e.CurrentValue = CheckState.Checked And daHoanThanhGridPC) Then
            Dim pcBUS As New PhanCong_BUS
            daHoanThanhGridPC = False
            For i As Integer = PCGD_gridBangPhanCong.Rows.Count To 1 Step -1
                If (PCGD_gridBangPhanCong.Rows(i - 1).Cells(2).Value = tenMH) Then
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
            If (PCGD_rdPhanCongTheoLop.Checked) Then
                Dim dongmoi As New DataGridViewRow
                dongmoi.CreateCells(PCGD_gridBangPhanCong)
                dongmoi.Cells(0).Value = PCGD_gridBangPhanCong.Rows.Count + 1
                dongmoi.Cells(2).Value = tenMH
                dongmoi.Cells(4).Value = PCGD_gridDSGiaoVien.SelectedCells(3).Value
                If (PCGD_cbTenLopHoc.Text.Trim() <> "") Then
                    dongmoi.Cells(1).Value = PCGD_cbTenLopHoc.Text
                Else
                    Dim ptrBUS As New PhuTrach_BUS
                    Dim mhBUS As New MonHoc_BUS
                    If (Not ptrBUS.KiemTraTonTai(PCGD_gridDSGiaoVien.SelectedCells(3).Value, mhBUS.LayMaMonHoc(tenMH))) Then
                        MessageBox.Show("Giáo viên không thể phụ trách môn học này")
                        e.NewValue = CheckState.Unchecked
                        Return
                    End If
                    Dim cs As Integer = 0
                    For cs = 0 To PCGD_clbDSLH.Items.Count - 1
                        If (PCGD_clbDSLH.GetItemChecked(cs)) Then
                            Exit For
                        End If
                    Next
                    dongmoi.Cells(1).Value = PCGD_clbDSLH.Items(cs).value
                End If
                dongmoi.Cells(9).Value = TaoMaPCMoi(1)
                PCGD_gridBangPhanCong.Rows.Add(dongmoi)
            Else
                Dim ptrBUS As New PhuTrach_BUS
                Dim mhBUS As New MonHoc_BUS
                If (Not ptrBUS.KiemTraTonTai(PCGD_gridDSGiaoVien.SelectedCells(3).Value, mhBUS.LayMaMonHoc(tenMH))) Then
                    MessageBox.Show("Giáo viên không thể phụ trách môn học này")
                    e.NewValue = CheckState.Unchecked
                    Return
                End If
                Dim dongmoi As DataGridViewRow
                Dim cs As Integer = 1
                For i As Integer = 1 To PCGD_clbDSLH.Items.Count
                    If (PCGD_clbDSLH.GetItemChecked(i - 1)) Then
                        dongmoi = New DataGridViewRow
                        dongmoi.CreateCells(PCGD_gridBangPhanCong)
                        dongmoi.Cells(0).Value = PCGD_gridBangPhanCong.Rows.Count + 1
                        dongmoi.Cells(2).Value = tenMH
                        dongmoi.Cells(4).Value = PCGD_gridDSGiaoVien.SelectedCells(3).Value
                        dongmoi.Cells(1).Value = PCGD_clbDSLH.Items.Item(i - 1)
                        dongmoi.Cells(9).Value = TaoMaPCMoi(cs)
                        cs = cs + 1
                        PCGD_gridBangPhanCong.Rows.Add(dongmoi)
                    End If
                Next
            End If
        End If
    End Sub

    Private Function TaoMaPCMoi(ByVal congThem As Integer) As String
        Dim kq As String = ""
        Try
            Dim pcBUS As New PhanCong_BUS
            Dim macuoi As String = pcBUS.LayMaCuoiCungCuaPhanCong()
            Dim socuoi As Integer = macuoi.Replace("PC", "")
            socuoi = socuoi + congThem
            Dim chuyenChuoi As String = socuoi
            If (chuyenChuoi.Length = 1) Then
                chuyenChuoi = "000" & chuyenChuoi
            End If
            If (chuyenChuoi.Length = 2) Then
                chuyenChuoi = "00" & chuyenChuoi
            End If
            If (chuyenChuoi.Length = 3) Then
                chuyenChuoi = "0" & chuyenChuoi
            End If
            kq &= "MoiThemPC" & chuyenChuoi
        Catch ex As Exception
            MessageBox.Show("Lỗi: " & ex.Message)
        End Try
        Return kq
    End Function

End Class
