<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MHQDToanTruong
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MHQDToanTruong))
        Me.Label32 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtSoTietToiDaTrongNgay = New System.Windows.Forms.TextBox
        Me.txtTietGay = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtSoTietToiDaDuocHocTrongNgay = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCapNhatQuyDinh = New System.Windows.Forms.Button
        Me.btnDong = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Verdana", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.Location = New System.Drawing.Point(29, 9)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(601, 48)
        Me.Label32.TabIndex = 5
        Me.Label32.Text = "QUY ĐỊNH TOÀN TRƯỜNG"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSoTietToiDaDuocHocTrongNgay)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTietGay)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtSoTietToiDaTrongNgay)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(146, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(360, 111)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(71, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Số tiết tối đa trong ngày:"
        '
        'txtSoTietToiDaTrongNgay
        '
        Me.txtSoTietToiDaTrongNgay.Location = New System.Drawing.Point(244, 22)
        Me.txtSoTietToiDaTrongNgay.Name = "txtSoTietToiDaTrongNgay"
        Me.txtSoTietToiDaTrongNgay.Size = New System.Drawing.Size(42, 20)
        Me.txtSoTietToiDaTrongNgay.TabIndex = 1
        '
        'txtTietGay
        '
        Me.txtTietGay.Location = New System.Drawing.Point(244, 51)
        Me.txtTietGay.Name = "txtTietGay"
        Me.txtTietGay.Size = New System.Drawing.Size(42, 20)
        Me.txtTietGay.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(71, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tiết gãy:"
        '
        'txtSoTietToiDaDuocHocTrongNgay
        '
        Me.txtSoTietToiDaDuocHocTrongNgay.Location = New System.Drawing.Point(244, 81)
        Me.txtSoTietToiDaDuocHocTrongNgay.Name = "txtSoTietToiDaDuocHocTrongNgay"
        Me.txtSoTietToiDaDuocHocTrongNgay.Size = New System.Drawing.Size(42, 20)
        Me.txtSoTietToiDaDuocHocTrongNgay.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Số tiết tối đa được học trong ngày:"
        '
        'btnCapNhatQuyDinh
        '
        Me.btnCapNhatQuyDinh.Enabled = False
        Me.btnCapNhatQuyDinh.Image = CType(resources.GetObject("btnCapNhatQuyDinh.Image"), System.Drawing.Image)
        Me.btnCapNhatQuyDinh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCapNhatQuyDinh.Location = New System.Drawing.Point(183, 210)
        Me.btnCapNhatQuyDinh.Name = "btnCapNhatQuyDinh"
        Me.btnCapNhatQuyDinh.Size = New System.Drawing.Size(146, 27)
        Me.btnCapNhatQuyDinh.TabIndex = 7
        Me.btnCapNhatQuyDinh.Text = "Cập nhật quy định"
        Me.btnCapNhatQuyDinh.UseVisualStyleBackColor = True
        '
        'btnDong
        '
        Me.btnDong.Image = CType(resources.GetObject("btnDong.Image"), System.Drawing.Image)
        Me.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnDong.Location = New System.Drawing.Point(360, 210)
        Me.btnDong.Name = "btnDong"
        Me.btnDong.Size = New System.Drawing.Size(146, 27)
        Me.btnDong.TabIndex = 8
        Me.btnDong.Text = "Đóng"
        Me.btnDong.UseVisualStyleBackColor = True
        '
        'MHQDToanTruong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(642, 250)
        Me.Controls.Add(Me.btnDong)
        Me.Controls.Add(Me.btnCapNhatQuyDinh)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label32)
        Me.Name = "MHQDToanTruong"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quy dinh toan truong"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSoTietToiDaDuocHocTrongNgay As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTietGay As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtSoTietToiDaTrongNgay As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCapNhatQuyDinh As System.Windows.Forms.Button
    Friend WithEvents btnDong As System.Windows.Forms.Button
End Class
