Imports BUS
Imports DTO
Imports System.Collections

Partial Public Class MHChinh
    'Biến lưu trữ mã lớp học hiện hành
    Private _currMaLopHoc As String = ""
    'Biến lưu trữ danh sách lịch rãnh ứng với mã lớp học hiện hành
    Private _arrLichRanh As ArrayList = New ArrayList()
    'biến lưu trữ giá trị trạng thái của nút Lh_btnTrangThai
    'Nếu là false thì khi nhấn nút toàn bộ lịch rãnh sẽ chuyển sang bận và trạng thái này qua true
    'nếu là true thì khi nhấn toàn bộ lịch rãnh sẽ chuyễn sang rãnh và chế độ này ssang false
    Private _stateForBtnTrangThai As Boolean = False
    'biến xác định có sự thay đổi về thông tin lịch rãnh hay không
    Private _changeLichRanh As Boolean = False
    'biến xác định có thao tác tạo mới một lớp hay chưa
    Private _createNewClass As Boolean = False
    ' Danh sách các ô đã đổi màu
    Private ai As New ArrayList
    Private aj As New ArrayList

    Private Sub tabLopHoc_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabLopHoc.Enter
        'Sự kiện này sẽ mở tab đầu tiên, do đó sẽ khởi tạo những thông tin mặc định của tab đầu ngay đây
        Lh_rdTatCa.Checked = True
        'dat che do readonly cho 2 cot dau cua grid danh sách lớp học
        Lh_gridDSLopHoc.Columns(0).ReadOnly = True
        Lh_gridDSLopHoc.Columns(1).ReadOnly = True
        'Lấy tất cả những thông tin về lớp học đưa vào grid danh sách lớp học
        Lh_rdTatCa_CheckedChanged(Me, Nothing)

        'Tắt kích hoạt của nút xóa lớp học và nút cập nhật dữ liệu và nút bận hết
        Lh_btnTrangThai.Enabled = False
        Lh_btnCapNhatDuLieu.Enabled = False
        Lh_btnXoaLopHoc.Enabled = False
    End Sub

    'Hàm tạo dòng và cột cho grid Lịch rãnh
    Private Sub Lh_gridLichRanh_TaoMoi()
        For i As Integer = 1 To 10
            Dim row As DataGridViewRow = New DataGridViewRow
            Lh_gridLichRanh.Rows.Add(row)
            Lh_gridLichRanh.Rows(i - 1).Cells(0).Value = i.ToString()
        Next
    End Sub
    'chế độ mặc địch của grid lịch rãnh
    Private Sub Lh_gridLichRanh_MacDinh()
        For i As Integer = 0 To 9
            For j As Integer = 1 To 7
                Lh_gridLichRanh.Rows(i).Cells(j).Value = "Rãnh"
            Next
        Next
    End Sub

    Private Sub Lh_rdTatCa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_rdTatCa.CheckedChanged
        Dim arrLopHoc As ArrayList = New ArrayList()
        Dim lopHocBUS As LopHoc_BUS = New LopHoc_BUS()
        'Lấy danh sách tất cả các lớp học
        arrLopHoc = lopHocBUS.LayDsLop("all")
        'làm sạch dữ liệu trước đó
        Lh_gridDSLopHoc.Rows.Clear()
        For i As Integer = 0 To arrLopHoc.Count - 1
            Dim temp As Integer = i + 1
            Dim LopHocDTO As LopHoc_DTO = New LopHoc_DTO()
            LopHocDTO = arrLopHoc(i)
            'tạo 1 dòng phù hợp
            Dim rowi As String() = {temp.ToString(), LopHocDTO.MaLopHoc, LopHocDTO.TenLopHoc}
            'thêm dòng mới tạo vào trong grid dand sách lớp học
            Lh_gridDSLopHoc.Rows.Add(rowi)
        Next
        'Tắt kích hoạt nút tạo lớp học
        Lh_btnTaoLopHocMoi.Enabled = False
    End Sub

    Private Sub Lh_rdKhoi12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_rdKhoi12.CheckedChanged
        Dim arrLopHoc As ArrayList = New ArrayList()
        Dim lopHocBUS As LopHoc_BUS = New LopHoc_BUS()
        arrLopHoc = lopHocBUS.LayDsLop("K12")
        Lh_gridDSLopHoc.Rows.Clear()
        For i As Integer = 0 To arrLopHoc.Count - 1
            Dim temp As Integer = i + 1
            Dim LopHocDTO As LopHoc_DTO = New LopHoc_DTO()
            LopHocDTO = arrLopHoc(i)
            Dim rowi As String() = {temp.ToString(), LopHocDTO.MaLopHoc, LopHocDTO.TenLopHoc}
            Lh_gridDSLopHoc.Rows.Add(rowi)
        Next
        'Kích hoạt nút tạo lớp học
        Lh_btnTaoLopHocMoi.Enabled = True

    End Sub

    Private Sub Lh_rdKhoi11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_rdKhoi11.CheckedChanged
        Dim arrLopHoc As ArrayList = New ArrayList()
        Dim lopHocBUS As LopHoc_BUS = New LopHoc_BUS()
        arrLopHoc = lopHocBUS.LayDsLop("K11")
        Lh_gridDSLopHoc.Rows.Clear()
        For i As Integer = 0 To arrLopHoc.Count - 1
            Dim temp As Integer = i + 1
            Dim LopHocDTO As LopHoc_DTO = New LopHoc_DTO()
            LopHocDTO = arrLopHoc(i)
            Dim rowi As String() = {temp.ToString(), LopHocDTO.MaLopHoc, LopHocDTO.TenLopHoc}
            Lh_gridDSLopHoc.Rows.Add(rowi)
        Next
        'Kích hoạt nút tạo lớp học
        Lh_btnTaoLopHocMoi.Enabled = True
    End Sub

    Private Sub Lh_rdKhoi10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_rdKhoi10.CheckedChanged
        Dim arrLopHoc As ArrayList = New ArrayList()
        Dim lopHocBUS As LopHoc_BUS = New LopHoc_BUS()
        arrLopHoc = lopHocBUS.LayDsLop("K10")
        Lh_gridDSLopHoc.Rows.Clear()

        For i As Integer = 0 To arrLopHoc.Count - 1
            Dim temp As Integer = i + 1
            Dim LopHocDTO As LopHoc_DTO = New LopHoc_DTO()
            LopHocDTO = arrLopHoc(i)
            Dim rowi As String() = {temp.ToString(), LopHocDTO.MaLopHoc, LopHocDTO.TenLopHoc}
            Lh_gridDSLopHoc.Rows.Add(rowi)
        Next
        'Kích hoạt nút tạo lớp học
        Lh_btnTaoLopHocMoi.Enabled = True
    End Sub

    Private Sub Lh_gridDSLopHoc_ThayDoiGrid(ByVal RowIndex As Integer)
        ResetMauCuaBangLichRanhLH()

        Dim value As DataGridViewSelectedCellCollection
        value = Lh_gridDSLopHoc.SelectedCells
        'lấy mã lớp học
        _currMaLopHoc = Lh_gridDSLopHoc.Rows(RowIndex).Cells(1).Value
        'Kích hoạt nút xóa lớp học
        Lh_btnXoaLopHoc.Enabled = True
        'Kích hoạt nút Bận hết
        Lh_btnTrangThai.Enabled = True
        'Truy cập CSDL lấy thông tin liên quan mã lớp học này
        Dim LopHocBus As LopHoc_BUS = New LopHoc_BUS()
        Dim LopHocDTO As LopHoc_DTO = LopHocBus.TimKiem(_currMaLopHoc)
        Lh_txtMaLopHoc.Text = LopHocDTO.MaLopHoc
        Lh_txtTenLopHoc.Text = LopHocDTO.TenLopHoc
        Dim RangBuocLopHocBUS As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
        _arrLichRanh = RangBuocLopHocBUS.LayLichRanh(LopHocDTO.MaLopHoc)
        Dim RangBuocLopHocDTO As RangBuocLopHoc_DTO = New RangBuocLopHoc_DTO()

        For i As Integer = 0 To _arrLichRanh.Count - 1
            RangBuocLopHocDTO = _arrLichRanh(i)
            If (RangBuocLopHocDTO.TrangThai = 0) Then 'rãnh
                Lh_gridLichRanh.Rows(RangBuocLopHocDTO.TietHoc - 1).Cells(RangBuocLopHocDTO.Thu - 1).Value = "Rãnh"
            ElseIf (RangBuocLopHocDTO.TrangThai = 1) Then 'bận'
                Lh_gridLichRanh.Rows(RangBuocLopHocDTO.TietHoc - 1).Cells(RangBuocLopHocDTO.Thu - 1).Value = "Bận"
            ElseIf (RangBuocLopHocDTO.TrangThai = 2) Then 'bắt buộc xếp
                Lh_gridLichRanh.Rows(RangBuocLopHocDTO.TietHoc - 1).Cells(RangBuocLopHocDTO.Thu - 1).Value = "Bắt buộc xếp"
            End If

        Next
    End Sub

    Private Sub Lh_gridDSLopHoc_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lh_gridDSLopHoc.CellClick
        If Lh_gridLichRanh.RowCount = 0 Then
            'tạo dòng và cột cho grid Lịch rãnh
            Lh_gridLichRanh_TaoMoi()
            'dat che do mac dinh cho grid Lịch rãnh
            'Lh_gridLichRanh_MacDinh()
        End If

        If _changeLichRanh = False Then
            'Thay đổi trạng thái lịch rãnh
            Lh_gridDSLopHoc_ThayDoiGrid(e.RowIndex)
        Else
            Dim rsl As DialogResult = MessageBox.Show("Đã có sự thay đổi về lịch rãnh, bạn có muốn lưu lại không?", "Cảnh báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
            If rsl = Windows.Forms.DialogResult.Cancel Then
                Return
            ElseIf rsl = Windows.Forms.DialogResult.No Then
                'Thay đổi trạng thái lịch rãnh
                Lh_gridDSLopHoc_ThayDoiGrid(e.RowIndex)
                'chuyển lại trạng thái chưa thay đổi lịch rãnh
                _changeLichRanh = False
                'Tắt kích hoạt nút Lh_btnCapNhatDuLieu
                Lh_btnCapNhatDuLieu.Enabled = False
            Else
                Dim RangBuocLopHocBUS As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
                RangBuocLopHocBUS.CapNhatTrangThaiVaoCSDL(_arrLichRanh)
                'Xuất thông báo đã cập nhật xong
                MessageBox.Show("Đã cập nhật CSDL thành công", "Thành công", MessageBoxButtons.OK)
                'Thay đổi trạng thái lịch rãnh
                Lh_gridDSLopHoc_ThayDoiGrid(e.RowIndex)
                'chuyển lại trạng thái chưa thay đổi lịch rãnh
                _changeLichRanh = False
                'Tắt kích hoạt nút Lh_btnCapNhatDuLieu
                Lh_btnCapNhatDuLieu.Enabled = False
            End If
        End If


    End Sub

    Private Sub Lh_gridLichRanh_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Lh_gridLichRanh.CellFormatting
        If e.ColumnIndex = 0 Then
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.FromArgb(91, 178, 251)
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(0).Style.ForeColor = Color.Red
        ElseIf e.ColumnIndex = 7 Then
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(7).Style.BackColor = Color.Red
        ElseIf 0 <= e.RowIndex AndAlso e.RowIndex <= 4 Then
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.FromArgb(147, 202, 249)
        Else
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.BackColor = Color.FromArgb(255, 254, 233)
        End If
    End Sub

    Private Sub Lh_gridDSLopHoc_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lh_gridDSLopHoc.CellEndEdit
        'Truy cập CSDL lấy thông tin liên quan mã lớp học này
        Dim LopHocBus As LopHoc_BUS = New LopHoc_BUS()
        Dim LopHocDTO As LopHoc_DTO = LopHocBus.TimKiem(_currMaLopHoc)
        'sửa lại tên lớp học
        LopHocDTO.TenLopHoc = Lh_gridDSLopHoc.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        'cập nhật tên lớp học vô csdl
        LopHocBus.CapNhatLopHoc(LopHocDTO)
        'Xuat thông báo thành công
        MessageBox.Show("Đã cập nhật cơ sở dữ liệu thành công", "thành công", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Lh_txtTenLopHoc.Text = LopHocDTO.TenLopHoc
    End Sub

    Private Sub Lh_btnTrangThai_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_btnTrangThai.Click
        If _stateForBtnTrangThai = False Then
            'chuyển toàn bộ grid lịch rãnh sang chế độ bận
            For i As Integer = 0 To 9
                For j As Integer = 1 To 7
                    Lh_gridLichRanh.Rows(i).Cells(j).Value = "Bận"
                Next
            Next
            'Cập nhật trạng thái cho tất cả các ràng buộc đang có trong _arrLichRanh
            Dim RangBuocLopHocBUS As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
            RangBuocLopHocBUS.CapNhatTrangThai(_arrLichRanh, 1)
            'Chuyển dòng text trên button sanh chế độ rãnh hết
            Lh_btnTrangThai.Text = "Rãnh hết"
            'thiết lập lại trạng thái cho nút này
            _stateForBtnTrangThai = True
            'đặt chế độ đã có sự thay đổi trân lịch rãnh
            _changeLichRanh = True
            'Kích hoạt nút Lh_btnCapNhatDuLieu
            Lh_btnCapNhatDuLieu.Enabled = True
        Else
            'chuyển toàn bộ grid lịch rãnh sang chế độ rãnh
            For i As Integer = 0 To 9
                For j As Integer = 1 To 7
                    Lh_gridLichRanh.Rows(i).Cells(j).Value = "Rãnh"
                Next
            Next
            'Cập nhật trạng thái cho tất cả các ràng buộc đang có trong _arrLichRanh
            Dim RangBuocLopHocBUS As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
            RangBuocLopHocBUS.CapNhatTrangThai(_arrLichRanh, 0) 'tất cả đều rãnh
            'Chuyển dòng text trên button sanh chế độ rãnh hết
            Lh_btnTrangThai.Text = "Bận hết"
            'thiết lập lại trang thái cho nút này
            _stateForBtnTrangThai = False
            'đặt chế độ đã có sự thay đổi trân lịch rãnh
            _changeLichRanh = True
            'Kích hoạt nút Lh_btnCapNhatDuLieu
            Lh_btnCapNhatDuLieu.Enabled = True

        End If

    End Sub

    Private Sub Lh_btnCapNhatDuLieu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_btnCapNhatDuLieu.Click
        'Không phải trường hợp tạo lớp học mới
        If (_createNewClass = False) Then
            Dim RangBuocLopHocBUS As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
            RangBuocLopHocBUS.CapNhatTrangThaiVaoCSDL(_arrLichRanh)
            'Xuất thông báo đã cập nhật xong
            MessageBox.Show("Đã cập nhật CSDL thành công", "Thành công", MessageBoxButtons.OK)
            'chuyển lại trạng thái chưa thay đổi lịch rãnh
            _changeLichRanh = False
            'Tắt kích hoạt nút Lh_btnCapNhatDuLieu
            Lh_btnCapNhatDuLieu.Enabled = False
            'là trường hợp tạo lớp mới
        Else
            If Lh_txtTenLopHoc.Text = "" Then
                MessageBox.Show("Chưa nhập tên lớp học")
                Return
            End If
            'Tạo mã khối
            Dim MaKhoi As String = ""
            If Lh_rdKhoi10.Checked = True Then
                MaKhoi = "K10"
            ElseIf Lh_rdKhoi11.Checked = True Then
                MaKhoi = "K11"
            Else
                MaKhoi = "K12"
            End If

            'thêm lớp mới vào trong CSDL
            Dim LopHocBUS As LopHoc_BUS = New LopHoc_BUS()
            LopHocBUS.Them(Lh_txtMaLopHoc.Text, Lh_txtTenLopHoc.Text, MaKhoi)
            'thêm các ràng buộc lớp học liên quan vào trong CSDL
            Dim RangBuocLopHocBUS As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
            RangBuocLopHocBUS.Them(_arrLichRanh)

            'Thông báo tạo xong lớp mới
            MessageBox.Show("Việc tạo thêm lớp học mới hoàn thành", "Thành công", MessageBoxButtons.OK)
            _createNewClass = False
            _changeLichRanh = False
            Lh_btnCapNhatDuLieu.Enabled = False

            ' Ép sự kiện checkChange xảy ra
            If Lh_rdKhoi10.Checked = True Then
                Lh_rdKhoi11.Checked = True
                Lh_rdKhoi10.Checked = True
            ElseIf Lh_rdKhoi11.Checked = True Then
                Lh_rdKhoi10.Checked = True
                Lh_rdKhoi11.Checked = True
            Else
                Lh_rdKhoi10.Checked = True
                Lh_rdKhoi12.Checked = True
            End If
        End If
    End Sub

    Private Sub Lh_btnXoaLopHoc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_btnXoaLopHoc.Click
        'Xóa trong bảng phân công trước
        Dim PhanCongBUS As PhanCong_BUS = New PhanCong_BUS()
        PhanCongBUS.Xoa(_currMaLopHoc)
        'Xóa tiếp trong bảng ràng buộc lớp học
        Dim RangBuocLopHocBUS As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
        RangBuocLopHocBUS.Xoa(_currMaLopHoc)
        'Cuối cùng là xóa trong bảng lớp học
        Dim LopHocBUS As LopHoc_BUS = New LopHoc_BUS()
        LopHocBUS.Xoa(_currMaLopHoc)
        'Đưa _currMalopHoc về trạng thái ""
        _currMaLopHoc = ""
        Lh_txtMaLopHoc.Text = ""
        Lh_txtTenLopHoc.Text = ""
        'Sự kiện này sẽ mở tab đầu tiên, do đó sẽ khởi tạo những thông tin mặc định của tab đầu ngay đây
        Lh_rdTatCa.Checked = True
        'Lấy tất cả những thông tin về lớp học đưa vào grid danh sách lớp học
        Lh_rdTatCa_CheckedChanged(Me, Nothing)
        'dat che do mac dinh cho grid Lịch rãnh
        Lh_gridLichRanh_MacDinh()
        'Tắt kích hoạt của nút xóa lớp học và nút cập nhật dữ liệu và nút bận hết
        Lh_btnTrangThai.Enabled = False
        Lh_btnCapNhatDuLieu.Enabled = False
        Lh_btnXoaLopHoc.Enabled = False

    End Sub

    Private Sub Lh_btnTaoLopHocMoi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_btnTaoLopHocMoi.Click
        'thiết lập chế độ mặc định cho grid Lịch Rãnh
        Lh_gridLichRanh_MacDinh()
        'tạo mã lớp học mới
        Dim MaLopHocMoi As String
        Dim LopHocBUS As LopHoc_BUS = New LopHoc_BUS()
        MaLopHocMoi = LopHocBUS.TaoMaLopHocMoi()
        Lh_txtMaLopHoc.Text = MaLopHocMoi

        'xác định đã có thao tác tạo mới một lớp học
        _createNewClass = True

        'kích hoạt nút cập nhật dữ liệu
        Lh_btnCapNhatDuLieu.Enabled = True

        'lấy bảng lịch rãnh mặc định
        Dim RBLH As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
        If (_arrLichRanh IsNot Nothing) Then
            _arrLichRanh.Clear()
        End If

        _arrLichRanh = RBLH.TaoBangLichRanh(MaLopHocMoi)
    End Sub

    Private Sub Lh_gridLichRanh_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles Lh_gridLichRanh.CellClick
        Dim RangBuocLopHocBUS As RangBuocLopHoc_BUS = New RangBuocLopHoc_BUS()
        Dim TrangThai As String = Lh_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Value
        If TrangThai = "Rãnh" Then
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Bận"
            RangBuocLopHocBUS.CapNhatTrangThai(_arrLichRanh, e.RowIndex + 1, e.ColumnIndex + 1, 1)
            _changeLichRanh = True
            Lh_btnCapNhatDuLieu.Enabled = True
        ElseIf TrangThai = "Bận" Then
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Bắt buộc xếp"
            RangBuocLopHocBUS.CapNhatTrangThai(_arrLichRanh, e.RowIndex + 1, e.ColumnIndex + 1, 2)
            _changeLichRanh = True
            Lh_btnCapNhatDuLieu.Enabled = True
        ElseIf TrangThai = "Bắt buộc xếp" Then
            Lh_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "Rãnh"
            RangBuocLopHocBUS.CapNhatTrangThai(_arrLichRanh, e.RowIndex + 1, e.ColumnIndex + 1, 0)
            _changeLichRanh = True
            Lh_btnCapNhatDuLieu.Enabled = True
        End If

        Lh_gridLichRanh.Rows(e.RowIndex).Cells(e.ColumnIndex).Style.ForeColor = Color.FromArgb(45, 255, 150)

        ' Lưu lại những vị trí đã đổi màu
        ai.Add(e.RowIndex)
        aj.Add(e.ColumnIndex)
    End Sub

    Private Sub Lh_gridDSLopHoc_CellFormatting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles Lh_gridDSLopHoc.CellFormatting
        If e.ColumnIndex = 0 Then
            Lh_gridDSLopHoc.Rows(e.RowIndex).Cells(0).Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            Lh_gridDSLopHoc.Rows(e.RowIndex).Cells(0).Style.BackColor = Color.FromArgb(91, 178, 251)
            Lh_gridDSLopHoc.Rows(e.RowIndex).Cells(0).Style.ForeColor = Color.Red
        ElseIf e.ColumnIndex = 1 Then
            Lh_gridDSLopHoc.Rows(e.RowIndex).Cells(1).Style.BackColor = Color.FromArgb(207, 240, 251)
        End If
    End Sub

    Private Sub Lh_btnXuatRaTapTin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lh_btnXuatRaTapTin.Click
        Using saveFileDialog As SaveFileDialog = GetExcelSaveFileDialog()
            If (saveFileDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
                Dim fileName As String = saveFileDialog.FileName
                ExcelGenerator.Generate(Lh_gridDSLopHoc).Save(fileName)
                Process.Start(fileName)
            End If
        End Using
    End Sub

    Private Sub ResetMauCuaBangLichRanhLH()
        For i As Integer = 1 To 10
            For j As Integer = 1 To 7
                Lh_gridLichRanh.Rows(i - 1).Cells(j).Style.ForeColor = Color.Black
            Next
        Next
    End Sub
End Class
