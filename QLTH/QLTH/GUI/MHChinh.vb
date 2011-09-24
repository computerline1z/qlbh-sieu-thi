Imports DTO
Imports BUS
Imports System.Data
Imports System.Collections

Public Class MHChinh

    Private Sub mnuTrogiupTacgia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuTrogiupTacgia.Click
        Dim frmAbout As New MHAbout
        frmAbout.ShowDialog()
    End Sub

    Private Sub MHChinh_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tabLopHoc.Select()
    End Sub

    Private Sub mnuThoat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThoat.Click
        End
    End Sub

    Private Sub btnLopHoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLopHoc.Click
        tabStripMain.SelectedIndex = 0
    End Sub

    Private Sub btnMonHoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMonHoc.Click
        tabStripMain.SelectedIndex = 1
    End Sub
    
    Private Sub btnGiaoVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGiaoVien.Click
        tabStripMain.SelectedIndex = 2
    End Sub

    Private Sub btnPCGD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPCGD.Click
        tabStripMain.SelectedIndex = 3
    End Sub

    Private Sub mnuQldlLophoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQldlLophoc.Click
        tabStripMain.SelectedIndex = 0
    End Sub

    Private Sub mnuQldlMonhoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQldlMonhoc.Click
        tabStripMain.SelectedIndex = 1
    End Sub

    Private Sub mnuQldlGiaoVien_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQldlGiaoVien.Click
        tabStripMain.SelectedIndex = 2
    End Sub

    Private Sub mnuQldlPcgd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuQldlPcgd.Click
        tabStripMain.SelectedIndex = 3
    End Sub

    Private Sub btnXepTKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnXepTKB.Click
        tabStripMain.SelectedIndex = 4
    End Sub

    Private Sub btnTKBLopHoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTKBLopHoc.Click
        tabStripMain.SelectedIndex = 5
    End Sub

    Private Sub btnLichDayGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLichDayGV.Click
        tabStripMain.SelectedIndex = 6
    End Sub

    Private Sub btnTKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTKB.Click
        tabStripMain.SelectedIndex = 7
    End Sub

    Private Sub mnuChucnangXepTKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChucnangXepTKB.Click
        tabStripMain.SelectedIndex = 4
    End Sub

    Private Sub mnuChucnangTKBLopHoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChucnangTKBLopHoc.Click
        tabStripMain.SelectedIndex = 5
    End Sub

    Private Sub mnuChucnangLichdayGV_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChucnangLichdayGV.Click
        tabStripMain.SelectedIndex = 6
    End Sub

    Private Sub mnuChucnangTKB_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuChucnangTKB.Click
        tabStripMain.SelectedIndex = 7
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        btnXepTKB.Visible = True
        btnTKBLopHoc.Visible = True
        btnLichDayGV.Visible = True
        btnTKB.Visible = True
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        btnXepTKB.Visible = False
        btnTKBLopHoc.Visible = False
        btnLichDayGV.Visible = False
        btnTKB.Visible = False
    End Sub

    Private Sub btnInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInfo.Click
        Dim frmAbout As New MHAbout
        frmAbout.ShowDialog()
    End Sub
    
    Private Sub mnuThayDoiQuyDinhToanTruong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuThayDoiQuyDinhToanTruong.Click
        Dim frmThayDoiQD As New MHQDToanTruong
        frmThayDoiQD.ShowDialog()
    End Sub

    'Tạo dialog xuất file exel
    Private Function GetExcelSaveFileDialog() As SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.CheckPathExists = True
        saveFileDialog.AddExtension = True
        saveFileDialog.ValidateNames = True
        saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
        saveFileDialog.DefaultExt = ".xls"
        saveFileDialog.Filter = "Microsoft Excel Workbook (*.xls)|*.xls"
        saveFileDialog.RestoreDirectory = True
        Return saveFileDialog
    End Function


    '-----------------------------------------------

    Private Sub tabTKB_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabTKB.Enter
        TKBTT_rdTatCa.Checked = True

    End Sub

    Private Sub NapThoiKhoaBieu(ByVal mode As Integer)

        Dim tkbBUS As New TKBToanTruong_BUS
        Dim tkb As ArrayList
        If mode = 0 Then
            tkb = tkbBUS.LayThoiKhoaBieu()
        Else
            If mode = 1 Then
                tkb = tkbBUS.LayThoiKhoaBieuKhoi10()
            Else
                If mode = 2 Then
                    tkb = tkbBUS.LayThoiKhoaBieuKhoi11()
                Else
                    tkb = tkbBUS.LayThoiKhoaBieuKhoi12()
                End If
            End If
        End If

        Dim index = 0
        Dim i = 0
        Dim tkbDTO As TKBToanTruong_DTO = New TKBToanTruong_DTO
        TKBTT_gridTKBToanTruong.Rows.Clear()
        While index < tkb.Count
            tkbDTO = tkb(index)
            TKBTT_gridTKBToanTruong.Rows.Add()
            Dim temp = 0    'các dòng hiện có trên lưới
            Dim restore = i
            Dim flag = True
            While temp < TKBTT_gridTKBToanTruong.Rows.Count
                If tkbDTO.TenLopHoc = TKBTT_gridTKBToanTruong.Rows(temp).Cells("tkbLopHoc").Value Then
                    i = temp
                    flag = False
                    Exit While
                End If
                temp += 1

            End While
            If flag = False Then
                'MessageBox.Show(temp.ToString())
                TKBTT_gridTKBToanTruong.Rows(restore).Visible = False
            End If



            Dim j = 0
            ' mặc đinh toàn bộ cell màu đỏ
            While j < 62

                TKBTT_gridTKBToanTruong.Rows(TKBTT_gridTKBToanTruong.Rows.Count - 1).Cells(j).Style.BackColor = Color.Red
                j += 1
            End While
            'Dim temp = 0    'các dòng hiện có trên lưới
            'Dim restore = i
            'While temp < TKBTT_gridTKBToanTruong.Rows.Count
            '    If tkbDTO.TenLopHoc = TKBTT_gridTKBToanTruong.Rows(temp).Cells("tkbLopHoc").Value Then
            '        i = temp
            '        Exit While
            '    End If
            '    temp += 1
            'End While
            '   TKBTT_gridTKBToanTruong.Rows(i).Cells("tkbStt").Value = (i + 1)
            '  TKBTT_gridTKBToanTruong.Rows(i).Cells("tkbStt").Style.BackColor = Color.FromArgb(96, 178, 246)
            TKBTT_gridTKBToanTruong.Rows(i).Cells("tkbLopHoc").Value = tkbDTO.TenLopHoc
            TKBTT_gridTKBToanTruong.Rows(i).Cells("tkbLopHoc").Style.BackColor = Color.FromArgb(208, 240, 252)
            Dim Chuoi = tkbDTO.MonHoc + "(" + tkbDTO.TenGiaoVien + ")"
            j = 0
            If tkbDTO.NgayHoc >= 2 And tkbDTO.NgayHoc <= 7 Then
                If tkbDTO.NgayHoc = 2 Then
                    While j < tkbDTO.SoTietHoc()
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(1 + tkbDTO.TietBatDau + j).Value = Chuoi
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(1 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(96, 178, 246)
                        If tkbDTO.TietBatDau >= 6 Then
                            TKBTT_gridTKBToanTruong.Rows(i).Cells(1 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(254, 254, 233)
                        End If
                        j += 1
                    End While
                End If
                If tkbDTO.NgayHoc = 3 Then
                    While j < tkbDTO.SoTietHoc()
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(11 + tkbDTO.TietBatDau + j).Value = Chuoi
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(11 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(96, 178, 246)
                        If tkbDTO.TietBatDau >= 6 Then
                            TKBTT_gridTKBToanTruong.Rows(i).Cells(11 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(254, 254, 233)
                        End If
                        j += 1
                    End While
                End If
                If tkbDTO.NgayHoc = 4 Then
                    While j < tkbDTO.SoTietHoc()
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(21 + tkbDTO.TietBatDau + j).Value = Chuoi
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(21 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(96, 178, 246)
                        If tkbDTO.TietBatDau >= 6 Then
                            TKBTT_gridTKBToanTruong.Rows(i).Cells(21 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(254, 254, 233)
                        End If
                        j += 1
                    End While
                End If
                If tkbDTO.NgayHoc = 5 Then
                    While j < tkbDTO.SoTietHoc()
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(31 + tkbDTO.TietBatDau + j).Value = Chuoi
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(31 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(96, 178, 246)
                        If tkbDTO.TietBatDau >= 6 Then
                            TKBTT_gridTKBToanTruong.Rows(i).Cells(31 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(254, 254, 233)
                        End If
                        j += 1
                    End While
                End If
                If tkbDTO.NgayHoc = 6 Then
                    While j < tkbDTO.SoTietHoc()
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(41 + tkbDTO.TietBatDau + j).Value = Chuoi
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(41 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(96, 178, 246)
                        If tkbDTO.TietBatDau >= 6 Then
                            TKBTT_gridTKBToanTruong.Rows(i).Cells(41 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(254, 254, 233)
                        End If
                        j += 1
                    End While
                End If
                If tkbDTO.NgayHoc = 7 Then
                    While j < tkbDTO.SoTietHoc()
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(51 + tkbDTO.TietBatDau + j).Value = Chuoi
                        TKBTT_gridTKBToanTruong.Rows(i).Cells(51 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(96, 178, 246)
                        If tkbDTO.TietBatDau >= 6 Then
                            TKBTT_gridTKBToanTruong.Rows(i).Cells(51 + tkbDTO.TietBatDau + j).Style.BackColor = Color.FromArgb(254, 254, 233)
                        End If
                        j += 1
                    End While
                End If
            Else
                MessageBox.Show("Du lieu loi")
            End If
            i = restore
            i += 1
            index += 1
        End While
        'làm chữa cháy
        TKBTT_gridTKBToanTruong.Columns(0).Visible = False
    End Sub

  
    Private Sub TKBTT_rdKhoi10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBTT_rdKhoi10.CheckedChanged
        NapThoiKhoaBieu(1)
    End Sub

    Private Sub TKBTT_rdKhoi11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBTT_rdKhoi11.CheckedChanged
        NapThoiKhoaBieu(2)
    End Sub

    Private Sub TKBTT_rdKhoi12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBTT_rdKhoi12.CheckedChanged
        NapThoiKhoaBieu(3)
    End Sub

    Private Sub TKBTT_rdTatCa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBTT_rdTatCa.CheckedChanged
        NapThoiKhoaBieu(0)
    End Sub

    Private Sub XTKB_btnXuatTapTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles XTKB_btnXuatTapTin.Click
        Using saveFileDialog As SaveFileDialog = GetExcelSaveFileDialog()
            If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim fileName As String = saveFileDialog.FileName
                ExcelGenerator.Generate(TKBTT_gridTKBToanTruong).Save(fileName)
                Process.Start(fileName)
            End If
        End Using
    End Sub

    Private Sub tabMonHoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabMonHoc.Enter
        Mh_gridDSMonHoc_Load()
    End Sub
End Class
