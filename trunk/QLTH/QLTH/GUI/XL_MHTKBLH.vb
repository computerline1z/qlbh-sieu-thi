Imports DTO
Imports BUS
Imports System.Data
Imports System.Collections

Partial Public Class MHChinh
    Private daVaoTabTKBLH As Boolean = False

    Private Sub tabTKBLopHoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabTKBLopHoc.Enter
        If (Not daVaoTabTKBLH) Then
            daVaoTabTKBLH = True
            For i As Integer = 1 To 10
                Dim dongmoi As New DataGridViewRow
                dongmoi.CreateCells(TKBLH_gridTKBLopHoc)
                dongmoi.Cells(0).Value = i
                TKBLH_gridTKBLopHoc.Rows.Add(dongmoi)
            Next
            TKBLH_rdKhoi10.Checked = True
        End If
        
    End Sub

    Private Sub TKBLH_rdKhoi10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBLH_rdKhoi10.CheckedChanged
        If (TKBLH_rdKhoi10.Checked And daVaoTabTKBLH) Then
            Try
                Dim lhBUS As New LopHoc_BUS
                Dim dsLH As ArrayList = lhBUS.LayDSLopHocTheoKhoi("Khoi 10")
                Dim tableLH As New DataTable
                Dim cot As New DataColumn("MaLH")
                tableLH.Columns.Add(cot)
                cot = New DataColumn("TenLH")
                tableLH.Columns.Add(cot)
                Dim dong As DataRow
                Dim lhDTO As LopHoc_DTO
                For i As Integer = 1 To dsLH.Count
                    lhDTO = dsLH(i - 1)
                    dong = tableLH.NewRow()
                    dong("MaLH") = lhDTO.MaLopHoc
                    dong("TenLH") = lhDTO.TenLopHoc
                    tableLH.Rows.Add(dong)
                Next
                TKBLH_cbTenLopHoc.DataSource = tableLH
                TKBLH_cbTenLopHoc.DisplayMember = "TenLH"
                TKBLH_cbTenLopHoc.ValueMember = "MaLH"
                If (dsLH.Count > 0) Then
                    TKBLH_cbTenLopHoc.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TKBLH_rdKhoi11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBLH_rdKhoi11.CheckedChanged
        If (TKBLH_rdKhoi11.Checked And daVaoTabTKBLH) Then
            Try
                Dim lhBUS As New LopHoc_BUS
                Dim dsLH As ArrayList = lhBUS.LayDSLopHocTheoKhoi("Khoi 11")
                Dim tableLH As New DataTable
                Dim cot As New DataColumn("MaLH")
                tableLH.Columns.Add(cot)
                cot = New DataColumn("TenLH")
                tableLH.Columns.Add(cot)
                Dim dong As DataRow
                Dim lhDTO As LopHoc_DTO
                For i As Integer = 1 To dsLH.Count
                    lhDTO = dsLH(i - 1)
                    dong = tableLH.NewRow()
                    dong("MaLH") = lhDTO.MaLopHoc
                    dong("TenLH") = lhDTO.TenLopHoc
                    tableLH.Rows.Add(dong)
                Next
                TKBLH_cbTenLopHoc.DataSource = tableLH
                TKBLH_cbTenLopHoc.DisplayMember = "TenLH"
                TKBLH_cbTenLopHoc.ValueMember = "MaLH"
                If (dsLH.Count > 0) Then
                    TKBLH_cbTenLopHoc.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TKBLH_rdKhoi12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBLH_rdKhoi12.CheckedChanged
        If (TKBLH_rdKhoi12.Checked And daVaoTabTKBLH) Then
            Try
                Dim lhBUS As New LopHoc_BUS
                Dim dsLH As ArrayList = lhBUS.LayDSLopHocTheoKhoi("Khoi 12")
                Dim tableLH As New DataTable
                Dim cot As New DataColumn("MaLH")
                tableLH.Columns.Add(cot)
                cot = New DataColumn("TenLH")
                tableLH.Columns.Add(cot)
                Dim dong As DataRow
                Dim lhDTO As LopHoc_DTO
                For i As Integer = 1 To dsLH.Count
                    lhDTO = dsLH(i - 1)
                    dong = tableLH.NewRow()
                    dong("MaLH") = lhDTO.MaLopHoc
                    dong("TenLH") = lhDTO.TenLopHoc
                    tableLH.Rows.Add(dong)
                Next
                TKBLH_cbTenLopHoc.DataSource = tableLH
                TKBLH_cbTenLopHoc.DisplayMember = "TenLH"
                TKBLH_cbTenLopHoc.ValueMember = "MaLH"
                If (dsLH.Count > 0) Then
                    TKBLH_cbTenLopHoc.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TKBLH_rdTatCa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBLH_rdTatCa.CheckedChanged
        If (TKBLH_rdTatCa.Checked And daVaoTabTKBLH) Then
            Try
                Dim lhBUS As New LopHoc_BUS
                Dim dsLH As ArrayList = lhBUS.LayDSLopHocTheoKhoi("all")
                Dim tableLH As New DataTable
                Dim cot As New DataColumn("MaLH")
                tableLH.Columns.Add(cot)
                cot = New DataColumn("TenLH")
                tableLH.Columns.Add(cot)
                Dim dong As DataRow
                Dim lhDTO As LopHoc_DTO
                For i As Integer = 1 To dsLH.Count
                    lhDTO = dsLH(i - 1)
                    dong = tableLH.NewRow()
                    dong("MaLH") = lhDTO.MaLopHoc
                    dong("TenLH") = lhDTO.TenLopHoc
                    tableLH.Rows.Add(dong)
                Next
                TKBLH_cbTenLopHoc.DataSource = tableLH
                TKBLH_cbTenLopHoc.DisplayMember = "TenLH"
                TKBLH_cbTenLopHoc.ValueMember = "MaLH"
                If (dsLH.Count > 0) Then
                    TKBLH_cbTenLopHoc.SelectedIndex = 0
                End If
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub TKBLH_cbTenLopHoc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBLH_cbTenLopHoc.SelectedIndexChanged
        Dim index As Integer = TKBLH_cbTenLopHoc.SelectedIndex
        If (index > -1) Then
            TKBLH_txtMaLopHoc.Text = TKBLH_cbTenLopHoc.SelectedItem("MaLH")
            Try
                ResetMauCuaBang()
                Dim pcBUS As New PhanCong_BUS
                Dim llhBUS As New LichLopHoc_BUS
                Dim llhDTO As LichLopHoc_DTO
                Dim gvDTO As New GiaoVien_DTO
                Dim gvBUS As New GiaoVien_BUS
                Dim mhBUS As New MonHoc_BUS
                Dim dsPC As ArrayList = pcBUS.LayDSPhanCongTheoLH(TKBLH_txtMaLopHoc.Text)
                Dim pcDTO As PhanCong_DTO
                For i As Integer = 1 To dsPC.Count
                    pcDTO = dsPC(i - 1)
                    Dim dsLLH As ArrayList = llhBUS.LayDSLichHoc(pcDTO.MaPhanCong)
                    For j As Integer = 1 To dsLLH.Count
                        llhDTO = dsLLH(j - 1)
                        Dim thu As Integer = llhDTO.Thu - 1
                        Dim tenMH As String = mhBUS.LayTenMonHoc(pcDTO.MaMonHoc)
                        tenMH &= " (" & gvBUS.TimKiem(pcDTO.MaGiaoVien).TenTat & ")"
                        For k As Integer = 1 To llhDTO.SoTietHoc
                            TKBLH_gridTKBLopHoc.Rows(k + llhDTO.TietHocBatDau - 2).Cells(thu).Value = tenMH
                            TKBLH_gridTKBLopHoc.Rows(k + llhDTO.TietHocBatDau - 2).Cells(thu).Style.BackColor = Color.White
                            TKBLH_gridTKBLopHoc.Rows(k + llhDTO.TietHocBatDau - 2).Cells(thu).Style.ForeColor = Color.Black
                        Next
                    Next
                Next
            Catch ex As Exception
                MessageBox.Show("Lỗi: " & ex.Message)
            End Try
        End If
    End Sub

    Private Sub ResetMauCuaBang()
        For i As Integer = 1 To 10
            For j As Integer = 1 To 7
                TKBLH_gridTKBLopHoc.Rows(i - 1).Cells(j).Style.BackColor = Color.Red
                TKBLH_gridTKBLopHoc.Rows(i - 1).Cells(j).Value = ""
            Next
        Next
    End Sub
End Class
