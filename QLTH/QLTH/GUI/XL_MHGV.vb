Imports BUS
Imports DTO

Partial Public Class MHChinh
    Private Sub tabGiaoVien_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabGiaoVien.Enter
        Dim giaoVienBUS As New GiaoVien_BUS
        Dim dsGiaoVien As ArrayList = giaoVienBUS.LayDsGiaoVien()
        Dim i As Integer = Gv_gridDSGiaoVien.Rows.Count
        Dim giaoVienDTO As GiaoVien_DTO = New GiaoVien_DTO
        While i < dsGiaoVien.Count
            giaoVienDTO = dsGiaoVien(i)
            Gv_gridDSGiaoVien.Rows.Add()
            Gv_gridDSGiaoVien.Rows(i).Cells("STT").Value = i
            Gv_gridDSGiaoVien.Rows(i).Cells("MaGiaoVien").Value = giaoVienDTO.MaGiaoVien
            Gv_gridDSGiaoVien.Rows(i).Cells("HoTenGiaoVien").Value = giaoVienDTO.HoTenGiaoVien
            Gv_gridDSGiaoVien.Rows(i).Cells("TenTat").Value = giaoVienDTO.TenTat
            Gv_gridDSGiaoVien.Rows(i).Cells("DiaChi").Value = giaoVienDTO.DiaChi
            Gv_gridDSGiaoVien.Rows(i).Cells("DienThoai").Value = giaoVienDTO.DienThoai
            i += 1
        End While


        'Mat Dinh ma Giao Vien Dau Tien Duoc Hien Thi Tenform
        If (dsGiaoVien.Count > 0) Then
            giaoVienDTO = dsGiaoVien(0)
            Dim MaGV As String = giaoVienDTO.MaGiaoVien
            giaoVienDTO = giaoVienBUS.TimKiem(MaGV)
            Gv_txtDiaChi.Text = giaoVienDTO.DiaChi
            Gv_txtDienThoai.Text = giaoVienDTO.DienThoai
            Gv_txtHoTenGiaoVien.Text = giaoVienDTO.HoTenGiaoVien
            Gv_txtMaGiaoVien.Text = giaoVienDTO.MaGiaoVien
            Gv_txtTenTat.Text = giaoVienDTO.TenTat


            Dim rangBuocGVBUS As New RangBuocGiaoVien_BUS
            Dim dsrangBuocGVDTO As ArrayList = rangBuocGVBUS.LayDsRangBuocGiaoVien(giaoVienDTO.MaGiaoVien)
            Dim rangBuocGVDTO As New RangBuocGiaoVien_DTO


            'Phan Lich Ranh
            i = Gv_gridLichRanh.Rows.Count
            While i < 10
                Gv_gridLichRanh.Rows.Add()
                Gv_gridLichRanh.Rows(i).Cells("GvLr_colSTT").Value = i + 1
                i += 1
            End While

            i = 0
            While i < dsrangBuocGVDTO.Count
                rangBuocGVDTO = dsrangBuocGVDTO(i)
                Dim Thu As Integer = rangBuocGVDTO.Thu
                Dim TietHoc As Integer = rangBuocGVDTO.TietHoc
                Dim TrangThai As Integer = rangBuocGVDTO.TrangThai


                TietHoc = TietHoc - 1 'Tuong Ung voi datagirdView dong thu nhat co so thu tu la 0
                Select Case Thu
                    Case 2
                        If (TrangThai = 1) Then
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthuhai").Value = "Bận"
                        Else
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthuhai").Value = "Rảnh"
                        End If
                    Case 3
                        If (TrangThai = 1) Then
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthuba").Value = "Bận"
                        Else
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthuba").Value = "Rảnh"
                        End If
                    Case 4
                        If (TrangThai = 1) Then
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthutu").Value = "Bận"
                        Else
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthutu").Value = "Rảnh"
                        End If
                    Case 5
                        If (TrangThai = 1) Then
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthunam").Value = "Bận"
                        Else
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthunam").Value = "Rảnh"
                        End If
                    Case 6
                        If (TrangThai = 1) Then
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthusau").Value = "Bận"
                        Else
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthusau").Value = "Rảnh"
                        End If
                    Case 7
                        If (TrangThai = 1) Then
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthubay").Value = "Bận"
                        Else
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthubay").Value = "Rảnh"
                        End If
                    Case 8
                        If (TrangThai = 1) Then
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colchunhat").Value = "Bận"
                        Else
                            Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colchunhat").Value = "Rảnh"
                        End If
                End Select
                i += 1
            End While
        End If
    End Sub


    Private Sub Gv_gridDSGiaoVien_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gv_gridDSGiaoVien.CellClick

        Dim i As Integer = Gv_gridDSGiaoVien.CurrentCell.RowIndex
        Dim MaGV As String = Gv_gridDSGiaoVien.Rows(i).Cells("MaGiaoVien").Value
        Dim GiaoVienBUS As New GiaoVien_BUS
        Dim GiaoVienDTO As GiaoVien_DTO = GiaoVienBUS.TimKiem(MaGV)
        Gv_txtDiaChi.Text = GiaoVienDTO.DiaChi
        Gv_txtDienThoai.Text = GiaoVienDTO.DienThoai
        Gv_txtHoTenGiaoVien.Text = GiaoVienDTO.HoTenGiaoVien
        Gv_txtMaGiaoVien.Text = GiaoVienDTO.MaGiaoVien
        Gv_txtTenTat.Text = GiaoVienDTO.TenTat

        'Phan Lich Ranh
        Dim rangBuocGVBUS As New RangBuocGiaoVien_BUS
        Dim dsrangBuocGVDTO As ArrayList = rangBuocGVBUS.LayDsRangBuocGiaoVien(MaGV)
        Dim rangBuocGVDTO As New RangBuocGiaoVien_DTO


        i = Gv_gridLichRanh.Rows.Count
        While i < 10
            Gv_gridLichRanh.Rows.Add()
            Gv_gridLichRanh.Rows(i).Cells("GvLr_colSTT").Value = i + 1
            i += 1
        End While

        i = 0
        While i < dsrangBuocGVDTO.Count
            rangBuocGVDTO = dsrangBuocGVDTO(i)
            Dim Thu As Integer = rangBuocGVDTO.Thu
            Dim TietHoc As Integer = rangBuocGVDTO.TietHoc
            Dim TrangThai As Integer = rangBuocGVDTO.TrangThai

            TietHoc = TietHoc - 1 'Tuong Ung voi datagirdView dong thu nhat co so thu tu la 0
            Select Case Thu
                Case 2
                    If (TrangThai = 1) Then
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthuhai").Value = "Bận"
                    Else
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthuhai").Value = "Rảnh"
                    End If
                Case 3
                    If (TrangThai = 1) Then
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthuba").Value = "Bận"
                    Else
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthuba").Value = "Rảnh"
                    End If
                Case 4
                    If (TrangThai = 1) Then
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthutu").Value = "Bận"
                    Else
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthutu").Value = "Rảnh"
                    End If
                Case 5
                    If (TrangThai = 1) Then
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthunam").Value = "Bận"
                    Else
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthunam").Value = "Rảnh"
                    End If
                Case 6
                    If (TrangThai = 1) Then
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthusau").Value = "Bận"
                    Else
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthusau").Value = "Rảnh"
                    End If
                Case 7
                    If (TrangThai = 1) Then
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthubay").Value = "Bận"
                    Else
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colthubay").Value = "Rảnh"
                    End If
                Case 8
                    If (TrangThai = 1) Then
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colchunhat").Value = "Bận"
                    Else
                        Gv_gridLichRanh.Rows(TietHoc).Cells("gvlr_colchunhat").Value = "Rảnh"
                    End If
            End Select
            i += 1
        End While
    End Sub

    Private Sub Gv_gridLichRanh_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Gv_gridLichRanh.CellClick
        If (e.RowIndex = -1) Then
            Return
        End If
        If (e.ColumnIndex = 0) Then
            Dim i As Integer = 1

            While i < Gv_gridLichRanh.Columns.Count
                If (Gv_gridLichRanh.Rows(e.RowIndex).Cells(i).Value = "Rảnh") Then
                    Gv_gridLichRanh.Rows(e.RowIndex).Cells(i).Value = "Bận"
                ElseIf Gv_gridLichRanh.Rows(e.RowIndex).Cells(i).Value = "Bận" Then
                    Gv_gridLichRanh.Rows(e.RowIndex).Cells(i).Value = "Rảnh"
                End If
                i += 1
            End While
            Gv_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.DarkMagenta
            Return
        End If
        Try
            If Gv_gridLichRanh.CurrentCell.Value = "Rảnh" Then
                Gv_gridLichRanh.CurrentCell.Value = "Bận"
            End If

            If Gv_gridLichRanh.CurrentCell.Value = "Bận" Then
                Gv_gridLichRanh.CurrentCell.Value = "BBXếp"
            End If

            If Gv_gridLichRanh.CurrentCell.Value = "BBXếp" Then
                Gv_gridLichRanh.CurrentCell.Value = "Rảnh"
            End If
        Catch ex As Exception

        End Try


        Gv_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.DarkMagenta
    End Sub

    Private Sub Gv_gridLichRanh_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Gv_gridLichRanh.ColumnHeaderMouseClick
        Dim Thu As Integer = e.ColumnIndex + 1
        Dim i As Integer = 0
        Select Case Thu
            Case 2
                i = 0
                While i < Gv_gridLichRanh.Rows.Count
                    If (Gv_gridLichRanh.Rows(i).Cells("gvlr_colthuhai").Value = "Rảnh") Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuHai").Value = "Bận"
                    ElseIf Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuHai").Value = "Bận" Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuHai").Value = "Rảnh"
                    End If
                    i += 1
                End While
            Case 3
                i = 0
                While i < Gv_gridLichRanh.Rows.Count
                    If (Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuBa").Value = "Rảnh") Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuBa").Value = "Bận"
                    ElseIf Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuBa").Value = "Bận" Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuBa").Value = "Rảnh"
                    End If
                    i += 1
                End While
            Case 4
                i = 0
                While i < Gv_gridLichRanh.Rows.Count
                    If (Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuTu").Value = "Rảnh") Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuTu").Value = "Bận"
                    ElseIf Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuTu").Value = "Bận" Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuTu").Value = "Rảnh"
                    End If
                    i += 1
                End While
            Case 5
                i = 0
                While i < Gv_gridLichRanh.Rows.Count
                    If (Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuNam").Value = "Rảnh") Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuNam").Value = "Bận"
                    ElseIf Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuNam").Value = "Bận" Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuNam").Value = "Rảnh"
                    End If
                    i += 1
                End While
            Case 6
                i = 0
                While i < Gv_gridLichRanh.Rows.Count
                    If (Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuSau").Value = "Rảnh") Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuSau").Value = "Bận"
                    ElseIf Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuSau").Value = "Bận" Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuSau").Value = "Rảnh"
                    End If
                    i += 1
                End While
            Case 7
                i = 0
                While i < Gv_gridLichRanh.Rows.Count
                    If (Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuBay").Value = "Rảnh") Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThubay").Value = "Bận"
                    ElseIf Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuBay").Value = "Bận" Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colThuBay").Value = "Rảnh"
                    End If
                    i += 1
                End While
            Case 8
                i = 0
                While i < Gv_gridLichRanh.Rows.Count
                    If (Gv_gridLichRanh.Rows(i).Cells("gvlr_colChuNhat").Value = "Rảnh") Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colChuNhat").Value = "Bận"
                    ElseIf Gv_gridLichRanh.Rows(i).Cells("gvlr_colChuNhat").Value = "Bận" Then
                        Gv_gridLichRanh.Rows(i).Cells("gvlr_colChuNhat").Value = "Rảnh"
                    End If
                    i += 1
                End While

        End Select


    End Sub

    Private Sub Gv_btnTrangThai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gv_btnTrangThai.Click
        If (Gv_btnTrangThai.Text = "Bận hết") Then
            Dim row As Integer = 0
            While row < Gv_gridLichRanh.Rows.Count
                Dim col As Integer = 1
                While col < Gv_gridLichRanh.Columns.Count
                    Gv_gridLichRanh.Rows(row).Cells(col).Value = "Bận"
                    col += 1
                End While
                row += 1
            End While
            Gv_btnTrangThai.Text = "Rảnh hết"
        Else
            Dim row As Integer = 0
            While row < Gv_gridLichRanh.Rows.Count
                Dim col As Integer = 1
                While col < Gv_gridLichRanh.Columns.Count
                    Gv_gridLichRanh.Rows(row).Cells(col).Value = "Rảnh"
                    col += 1
                End While
                row += 1
            End While
            Gv_btnTrangThai.Text = "Bận hết"
        End If


    End Sub

    Private Sub Gv_btnCapNhatDuLieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gv_btnCapNhatDuLieu.Click
        Try
            Dim GvDTO As New GiaoVien_DTO
            GvDTO.DiaChi = Gv_txtDiaChi.Text
            GvDTO.DienThoai = Gv_txtDienThoai.Text
            GvDTO.HoTenGiaoVien = Gv_txtHoTenGiaoVien.Text
            GvDTO.MaGiaoVien = Gv_txtMaGiaoVien.Text
            GvDTO.TenTat = Gv_txtMaGiaoVien.Text
            Dim GvBUS As New GiaoVien_BUS
            GvBUS.CapNhatGiaoVien(GvDTO)


            Dim RangBuocBUS As New RangBuocGiaoVien_BUS
            Dim row As Integer = 0
            While row < Gv_gridLichRanh.Rows.Count
                Dim col As Integer = 1
                While col < Gv_gridLichRanh.Columns.Count
                    Dim RangBuocGVDTO As New RangBuocGiaoVien_DTO
                    RangBuocGVDTO.MaGiaoVien = GvDTO.MaGiaoVien
                    RangBuocGVDTO.Thu = col + 1
                    RangBuocGVDTO.TietHoc = row + 1


                    If Gv_gridLichRanh.Rows(row).Cells(col).Value = "Rảnh" Then
                        RangBuocGVDTO.TrangThai = 0
                    Else
                        RangBuocGVDTO.TrangThai = 1
                    End If
                    RangBuocBUS.CapNhatRangBuocGiaoVien(RangBuocGVDTO)
                    col += 1
                End While
                row += 1
            End While

        Catch ex As Exception
            MessageBox.Show("Cập Nhạt Thất Bại")
            Return
        End Try
        MessageBox.Show("Cập Nhật Thành Công")
    End Sub

    Private Sub Gv_btnTaoGiaoVienMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gv_btnTaoGiaoVienMoi.Click
        If (MessageBox.Show("Bạn Có luu lại Những Thay Đổi hiện tại không", "LƯU LẠI", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes) Then
            Gv_btnCapNhatDuLieu_Click(Nothing, Nothing)
        End If
        Gv_txtDiaChi.Text = ""
        Gv_txtDienThoai.Text = ""
        Gv_txtHoTenGiaoVien.Text = ""
        Gv_txtTenTat.Text = ""
        Dim GvBUS As New GiaoVien_BUS
        Dim dsgv As ArrayList = GvBUS.LayDsGiaoVien()
        Dim Magv As Integer = dsgv.Count + 1
        Gv_txtMaGiaoVien.Text = "GV" + Magv.ToString()

        Dim row As Integer = 0
        While row < Gv_gridLichRanh.Rows.Count
            Dim col As Integer = 1
            While col < Gv_gridLichRanh.Columns.Count
                Gv_gridLichRanh.Rows(row).Cells(col).Value = "Rảnh"
                col += 1
            End While
            row += 1
        End While

        Dim GvDTO As New GiaoVien_DTO
        GvDTO.MaGiaoVien = Gv_txtMaGiaoVien.Text
        GvDTO.DienThoai = Gv_txtDienThoai.Text
        GvDTO.TenTat = Gv_txtTenTat.Text
        GvDTO.HoTenGiaoVien = Gv_txtHoTenGiaoVien.Text
        GvDTO.DiaChi = Gv_txtHoTenGiaoVien.Text
        GvBUS.Them(GvDTO)
    End Sub

    Private Sub Gv_btnXoaGiaoVienNay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gv_btnXoaGiaoVienNay.Click
        If (MessageBox.Show("Bạn Có Chắc Chắn Xóa Dữ Liệu Về Giáo Viên Này Không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) = Windows.Forms.DialogResult.Yes) Then
            Dim GvBus As New GiaoVien_BUS
            Dim GvDTO As New GiaoVien_DTO
            GvDTO.MaGiaoVien = Gv_txtMaGiaoVien.Text
            GvDTO.DienThoai = Gv_txtDienThoai.Text
            GvDTO.HoTenGiaoVien = Gv_txtHoTenGiaoVien.Text
            GvDTO.TenTat = Gv_txtTenTat.Text
            GvDTO.DiaChi = Gv_txtDiaChi.Text

            Dim RangBuocGVBUS As New RangBuocGiaoVien_BUS
            If (RangBuocGVBUS.DemSoRangBuocVoi1GiaoVien(GvDTO.MaGiaoVien) = 0) Then
                Try
                    GvBus.Xoa(GvDTO)
                Catch ex As Exception
                    MessageBox.Show("Khong delete duọc giáo viên này")
                End Try
            Else
                MessageBox.Show("Không delete được giáo viên này vì vướng ràng buộc giáo viên")
            End If
        End If
    End Sub

    Private Sub Gv_btnXuatRaTapTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gv_btnXuatRaTapTin.Click
        Using saveFileDialog As SaveFileDialog = GetExcelSaveFileDialog()
            If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim fileName As String = saveFileDialog.FileName
                ExcelGenerator.Generate(Gv_gridDSGiaoVien).Save(fileName)
                Process.Start(fileName)
            End If
        End Using
    End Sub

    Private Sub Gv_gridLichRanh_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Gv_gridLichRanh.CellFormatting
        If e.ColumnIndex = 0 Then
            Gv_gridLichRanh.Rows(e.RowIndex).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Gv_gridLichRanh.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.FromArgb(91, 178, 251)
            Gv_gridLichRanh.Rows(e.RowIndex).Cells(0).Style.ForeColor = Color.Red
        ElseIf e.ColumnIndex = 7 Then
            Gv_gridLichRanh.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.Red
        ElseIf 0 <= e.RowIndex AndAlso e.RowIndex <= 4 Then
            Gv_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.FromArgb(147, 202, 249)
        Else
            Gv_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.FromArgb(255, 254, 233)
        End If
    End Sub

    Private Sub Gv_gridDSGiaoVien_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Gv_gridDSGiaoVien.CellFormatting
        If e.ColumnIndex = 0 Then
            Gv_gridDSGiaoVien.Rows(e.RowIndex).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Gv_gridDSGiaoVien.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.FromArgb(91, 178, 251)
            Gv_gridDSGiaoVien.Rows(e.RowIndex).Cells(0).Style.ForeColor = Color.Red
        Else
            Gv_gridDSGiaoVien.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.FromArgb(208, 240, 251)
        End If
    End Sub
End Class
