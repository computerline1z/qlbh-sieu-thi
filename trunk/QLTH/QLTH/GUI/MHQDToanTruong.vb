Imports BUS
Imports DTO

Public Class MHQDToanTruong
    Private DaSua As Boolean = False

    Private Sub MHQDToanTruong_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Đọc CSDL và lấy thông tin quy định toàn trường
        Dim QdBUS As New QuyDinh_BUS
        Dim QuyDinh As QuyDinh_DTO = QdBUS.LayQuyDinh()

        txtSoTietToiDaTrongNgay.Text = QuyDinh.SoTietToiDaTrongNgay.ToString()
        txtTietGay.Text = QuyDinh.TietGay.ToString()
        txtSoTietToiDaDuocHocTrongNgay.Text = QuyDinh.SoTietHocToiDaTrongNgay.ToString()

        DaSua = False
        btnCapNhatQuyDinh.Enabled = False
    End Sub

    Private Sub btnDong_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDong.Click
        If DaSua Then
            If MessageBox.Show("Quy định toàn trường đã được sửa. Bạn có muốn cập nhật không?", "Thông báo", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                Dim QuyDinh As New QuyDinh_DTO
                QuyDinh.SoTietToiDaTrongNgay = Byte.Parse(txtSoTietToiDaTrongNgay.Text)
                QuyDinh.TietGay = Byte.Parse(txtTietGay.Text)
                QuyDinh.SoTietHocToiDaTrongNgay = Integer.Parse(txtSoTietToiDaDuocHocTrongNgay.Text)

                Dim QdBus As New QuyDinh_BUS
                QdBus.CapNhat(QuyDinh)

                MessageBox.Show("Đã cập nhật quy định toàn trường.")
            End If
        End If

        Me.Close()
    End Sub

    Private Sub txtSoTietToiDaTrongNgay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoTietToiDaTrongNgay.TextChanged
        DaSua = True
        btnCapNhatQuyDinh.Enabled = True
    End Sub

    Private Sub txtTietGay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTietGay.TextChanged
        DaSua = True
        btnCapNhatQuyDinh.Enabled = True
    End Sub

    Private Sub txtSoTietToiDaDuocHocTrongNgay_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSoTietToiDaDuocHocTrongNgay.TextChanged
        DaSua = True
        btnCapNhatQuyDinh.Enabled = True
    End Sub

    Private Sub btnCapNhatQuyDinh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCapNhatQuyDinh.Click
        If DaSua Then
            Dim QuyDinh As New QuyDinh_DTO
            QuyDinh.SoTietToiDaTrongNgay = Byte.Parse(txtSoTietToiDaTrongNgay.Text)
            QuyDinh.TietGay = Byte.Parse(txtTietGay.Text)
            QuyDinh.SoTietHocToiDaTrongNgay = Integer.Parse(txtSoTietToiDaDuocHocTrongNgay.Text)

            Dim QdBus As New QuyDinh_BUS
            QdBus.CapNhat(QuyDinh)

            DaSua = False
            btnCapNhatQuyDinh.Enabled = False
            MessageBox.Show("Đã cập nhật quy định toàn trường.")
        End If
    End Sub
End Class