Imports BUS
Imports DTO

Partial Public Class MHChinh
    Private m_dataBus As New MonHoc_BUS

    Private Sub TKBLH_txtMaLopHoc_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TKBLH_txtMaLopHoc.TextChanged

    End Sub

    'Bảng Môn học
    Private m_dataTable As DataTable

    Private Sub MonHoc_TabLoad()
        'Me.Mh_gridDSMonHoc.DataSource = Me.m_dataBus.LayBang()
        Mh_gridDSMonHoc_Load()
    End Sub
#Region "Mh_gridDSMonHoc"
    Private Sub Mh_gridDSMonHoc_Load()
        Me.Mh_DocDSMH_Load()
        Me.Mh_gridDSMonHoc_Format()
        Mh_gridDSMonHoc_CellClick(Nothing, New System.Windows.Forms.DataGridViewCellEventArgs(0, 0))
    End Sub
    Private Sub Mh_DocDSMH_Load()
        Me.m_dataTable = m_dataBus.LayBang()

        Dim newTable As New DataTable()
        'newTable.Columns.Add("STT", System.Type.GetType("System.Int32"))
        newTable.Columns.Add("STT", System.Type.GetType("System.String"))
        newTable.Columns.Add("Tên Môn Học", System.Type.GetType("System.String"))
        newTable.Columns.Add("QĐSTHLTTT", System.Type.GetType("System.Int32"))
        newTable.Columns.Add("QĐSTHLTTĐ", System.Type.GetType("System.Int32"))

        For i As Int32 = 0 To Me.m_dataTable.Rows.Count - 1
            newTable.Rows.Add(Me.m_dataTable.Rows(i)(0), Me.m_dataTable.Rows(i)(1), Me.m_dataTable.Rows(i)(2), Me.m_dataTable.Rows(i)(3))
        Next

        Me.Mh_gridDSMonHoc.DataSource = newTable
    End Sub
    Private Sub Mh_gridDSMonHoc_Format()

        Me.Mh_gridDSMonHoc.Columns(0).Width = 50
        Me.Mh_gridDSMonHoc.Columns(1).Width = 100
        Me.Mh_gridDSMonHoc.Columns(2).Width = 80
        Me.Mh_gridDSMonHoc.Columns(3).Width = 80

        Dim STTCellStyle As New DataGridViewCellStyle()
        STTCellStyle.BackColor = Color.LightBlue
        STTCellStyle.ForeColor = Color.Red
        STTCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Mh_gridDSMonHoc.Columns(0).DefaultCellStyle = STTCellStyle

        Dim TenMonHocCellStyle As New DataGridViewCellStyle()
        TenMonHocCellStyle.BackColor = Color.Cyan
        TenMonHocCellStyle.ForeColor = Color.Black
        Me.Mh_gridDSMonHoc.Columns(1).DefaultCellStyle = TenMonHocCellStyle

        Dim ToiThieuCellStyle As New DataGridViewCellStyle()
        ToiThieuCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Mh_gridDSMonHoc.Columns(2).DefaultCellStyle = ToiThieuCellStyle

        Dim ToiDaCellStyle As New DataGridViewCellStyle()
        ToiDaCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Mh_gridDSMonHoc.Columns(3).DefaultCellStyle = ToiDaCellStyle

        'Dim DongChanCellStyle As New DataGridViewCellStyle
        'Dim DongLeCellStyle As New DataGridViewCellStyle
        'DongChanCellStyle.BackColor = Color.Yellow
        'DongLeCellStyle.BackColor = Color.Violet
        'For i As Int32 = 0 To Me.Mh_gridDSMonHoc.Rows.Count - 1
        '    If (i Mod 2 = 0) Then
        '        Me.Mh_gridDSMonHoc.Rows(i).DefaultCellStyle = DongChanCellStyle
        '    Else
        '        Me.Mh_gridDSMonHoc.Rows(i).DefaultCellStyle = DongLeCellStyle
        '    End If
        'Next

        Me.Mh_gridDSMonHoc.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'Me.Mh_gridDSMonHoc.ReadOnly = True
        'Me.Mh_gridDSMonHoc.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan

    End Sub
    Private Sub Mh_gridDSGV_Load(ByVal monHoc As String)
        Me.Mh_DocDSGV_Load(monHoc)
        Me.Mh_gridDSGV_Format()
    End Sub

    Private Sub Mh_DocDSGV_Load(ByVal monHoc As String)
        Dim oldTable As New DataTable
        oldTable = Me.m_dataBus.LayBangGiaoVien(monHoc)

        Dim newTable As New DataTable()

        newTable.Columns.Add("STT", System.Type.GetType("System.Int32"))
        newTable.Columns.Add("Tên Giáo Viên", System.Type.GetType("System.String"))
        newTable.Columns.Add("Tên tắt", System.Type.GetType("System.String"))
        newTable.Columns.Add("Các lớp học phụ trách", System.Type.GetType("System.String"))

        Dim strDsLopPhanCong As String
        Dim gvBus As New GiaoVien_BUS()
        For i As Int32 = 0 To oldTable.Rows.Count - 1
            'newTable.Rows.Add(i + 1, Me.m_dataTable.Rows(i)(1), Me.m_dataTable.Rows(i)(2), Me.m_dataTable.Rows(i)(3))
            strDsLopPhanCong = ""
            Dim l As ArrayList
            l = gvBus.LayDsLopDuocPhanCong(oldTable.Rows(i)(3))
            For j As Int32 = 0 To l.Count - 1
                If (j <> 0) Then
                    strDsLopPhanCong = strDsLopPhanCong & ", " & l(j)
                Else
                    strDsLopPhanCong = l(j)
                End If
            Next

            newTable.Rows.Add(i + 1, oldTable.Rows(i)(1), oldTable.Rows(i)(2), strDsLopPhanCong)
        Next

        Me.Mh_gridDSGiaoVien.DataSource = newTable
    End Sub
    Private Sub Mh_gridDSGV_Format()

        Me.Mh_gridDSGiaoVien.Columns(0).Width = 50
        Me.Mh_gridDSGiaoVien.Columns(1).Width = 125
        Me.Mh_gridDSGiaoVien.Columns(2).Width = 75
        Me.Mh_gridDSGiaoVien.Columns(3).Width = 180

        Dim STTCellStyle As New DataGridViewCellStyle()
        STTCellStyle.BackColor = Color.LightBlue
        STTCellStyle.ForeColor = Color.Red
        STTCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Mh_gridDSGiaoVien.Columns(0).DefaultCellStyle = STTCellStyle

        Dim TenGVCellStyle As New DataGridViewCellStyle()
        TenGVCellStyle.BackColor = Color.Cyan
        TenGVCellStyle.ForeColor = Color.Black
        TenGVCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Mh_gridDSGiaoVien.Columns(1).DefaultCellStyle = TenGVCellStyle

        Dim TenTatCellStyle As New DataGridViewCellStyle()
        TenTatCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        Me.Mh_gridDSGiaoVien.Columns(2).DefaultCellStyle = TenTatCellStyle

        Dim LopCellStyle As New DataGridViewCellStyle()
        LopCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        Me.Mh_gridDSGiaoVien.Columns(3).DefaultCellStyle = LopCellStyle

        'Dim DongChanCellStyle As New DataGridViewCellStyle
        'Dim DongLeCellStyle As New DataGridViewCellStyle
        'DongChanCellStyle.BackColor = Color.Yellow
        'DongLeCellStyle.BackColor = Color.Violet
        'For i As Int32 = 0 To Me.Mh_gridDSGiaoVien.Rows.Count - 1
        '    If (i Mod 2 = 0) Then
        '        Me.Mh_gridDSGiaoVien.Rows(i).DefaultCellStyle = DongChanCellStyle
        '    Else
        '        Me.Mh_gridDSGiaoVien.Rows(i).DefaultCellStyle = DongLeCellStyle
        '    End If
        'Next

        Me.Mh_gridDSGiaoVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'Me.Mh_gridDSGiaoVien.ReadOnly = True
        'Me.Mh_gridDSGiaoVien.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan

    End Sub
    Private Sub Mh_gridDSMonHoc_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Mh_gridDSMonHoc.CellClick
        Try
            Me.Mh_txtMaMonHoc.Text = Me.m_dataTable.Rows(e.RowIndex)(0)
            Me.Mh_txtTenMonHoc.Text = Me.m_dataTable.Rows(e.RowIndex)(1)
            Me.Mh_txtQDSoTHLienTiepToiThieu.Text = Me.m_dataTable.Rows(e.RowIndex)(2)
            Me.Mh_txtQDSoTHLienTiepToiDa.Text = Me.m_dataTable.Rows(e.RowIndex)(3)
            Mh_gridDSGV_Load(m_dataTable.Rows(e.RowIndex).Item(0))
        Catch ex As Exception
        End Try

    End Sub

#End Region

    Private Sub Mh_gridDSMonHoc_ColumnHeaderMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles Mh_gridDSMonHoc.ColumnHeaderMouseClick
        Me.Mh_gridDSMonHoc.Columns(e.ColumnIndex).SortMode = DataGridViewColumnSortMode.Automatic
    End Sub



    Private Sub Mh_btnTaoMonHocMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mh_btnTaoMonHocMoi.Click
        'Me.m_dataTable.Rows[Me.m_dataTable.Rows.Count - 1][0]
        Dim strMaCu As String
        strMaCu = Me.m_dataTable.Rows.Item(Me.m_dataTable.Rows.Count - 1).Item(0)

        Dim strMaMoi As String
        strMaMoi = "MH" & (Int32.Parse(strMaCu.Substring(2)) + 1).ToString()

        Me.Mh_txtMaMonHoc.Text = strMaMoi
        Me.Mh_txtTenMonHoc.Text = ""
        Me.Mh_txtQDSoTHLienTiepToiThieu.Text = "1"
        Me.Mh_txtQDSoTHLienTiepToiDa.Text = "1"
    End Sub

    Private Sub Mh_btnCapNhatDuLieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mh_btnCapNhatDuLieu.Click
        Try
            Dim mhDTO As New MonHoc_DTO
            mhDTO.MaMonHoc = Me.Mh_txtMaMonHoc.Text
            mhDTO.TenMonHoc = Me.Mh_txtTenMonHoc.Text
            mhDTO.QuiDinhSoTietHocLienTiepToiDa = Int32.Parse(Me.Mh_txtQDSoTHLienTiepToiDa.Text)
            mhDTO.QuiDinhSoTietHocLienTiepToiThieu = Int32.Parse(Me.Mh_txtQDSoTHLienTiepToiThieu.Text)

            If (Me.m_dataBus.TimKiem(mhDTO.MaMonHoc).Count <> 0) Then
                Me.m_dataBus.CapNhat(mhDTO)
            Else
                Me.m_dataBus.Them(mhDTO)
            End If

            Me.Mh_gridDSMonHoc.DataSource = Nothing
            Mh_gridDSMonHoc_Load()
        Catch ex As Exception
        End Try

    End Sub

    Private Sub Mh_btnXoaMonHocNay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mh_btnXoaMonHocNay.Click
        Try
            Me.m_dataBus.Xoa(Me.Mh_txtMaMonHoc.Text)
        Catch ex As Exception
        End Try
        Mh_gridDSMonHoc_Load()
    End Sub

    Private Sub Mh_btnXuatRaTapTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Mh_btnXuatRaTapTin.Click
        Using saveFileDialog As SaveFileDialog = GetExcelSaveFileDialog()
            If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim fileName As String = saveFileDialog.FileName
                ExcelGenerator.Generate(Mh_gridDSMonHoc).Save(fileName)
                Process.Start(fileName)
            End If
        End Using
    End Sub


    Private Sub Mh_gridDSMonHoc_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Mh_gridDSMonHoc.CellEndEdit
        If e.ColumnIndex = 2 Or e.ColumnIndex = 3 Then
            Try
                Dim mhDTO As New MonHoc_DTO()
                mhDTO.MaMonHoc = Me.Mh_gridDSMonHoc.Rows(e.RowIndex).Cells(0).Value
                mhDTO.TenMonHoc = Me.Mh_gridDSMonHoc.Rows(e.RowIndex).Cells(1).Value
                mhDTO.QuiDinhSoTietHocLienTiepToiThieu = Int32.Parse(Me.Mh_gridDSMonHoc.Rows(e.RowIndex).Cells(2).Value)
                mhDTO.QuiDinhSoTietHocLienTiepToiDa = Int32.Parse(Me.Mh_gridDSMonHoc.Rows(e.RowIndex).Cells(3).Value)

                m_dataBus.CapNhat(mhDTO)
                Mh_gridDSMonHoc_Load()
            Catch ex As Exception
            End Try
        End If

    End Sub



    Private Sub Mh_gridDSMonHoc_CellBeginEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellCancelEventArgs) Handles Mh_gridDSMonHoc.CellBeginEdit
        If Not (e.ColumnIndex = 2 Or e.ColumnIndex = 3) Then
            e.Cancel = True
        End If
    End Sub
End Class
