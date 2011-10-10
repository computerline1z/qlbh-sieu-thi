namespace quan_ly_ban_hang_sieu_thi
{
    partial class ucChuongTrinhKM
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDen = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.dtpNgayAD = new System.Windows.Forms.DateTimePicker();
            this.grbTimKiemKM = new System.Windows.Forms.GroupBox();
            this.btnThemLoaiKM = new System.Windows.Forms.Button();
            this.grbThoiGianApDung = new System.Windows.Forms.GroupBox();
            this.dtpNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblTenHang = new System.Windows.Forms.Label();
            this.grbMatHangKM = new System.Windows.Forms.GroupBox();
            this.dgvMatHangKM = new System.Windows.Forms.DataGridView();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.grbTimKiemKM.SuspendLayout();
            this.grbThoiGianApDung.SuspendLayout();
            this.grbMatHangKM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangKM)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDen
            // 
            this.lblDen.AutoSize = true;
            this.lblDen.Location = new System.Drawing.Point(20, 45);
            this.lblDen.Name = "lblDen";
            this.lblDen.Size = new System.Drawing.Size(30, 15);
            this.lblDen.TabIndex = 0;
            this.lblDen.Text = "Đến";
            // 
            // lblTu
            // 
            this.lblTu.AutoSize = true;
            this.lblTu.Location = new System.Drawing.Point(26, 24);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(23, 15);
            this.lblTu.TabIndex = 0;
            this.lblTu.Text = "Từ";
            // 
            // dtpNgayAD
            // 
            this.dtpNgayAD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayAD.Location = new System.Drawing.Point(56, 17);
            this.dtpNgayAD.Name = "dtpNgayAD";
            this.dtpNgayAD.Size = new System.Drawing.Size(130, 21);
            this.dtpNgayAD.TabIndex = 5;
            // 
            // grbTimKiemKM
            // 
            this.grbTimKiemKM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grbTimKiemKM.Controls.Add(this.btnInsert);
            this.grbTimKiemKM.Controls.Add(this.btnThemLoaiKM);
            this.grbTimKiemKM.Controls.Add(this.grbThoiGianApDung);
            this.grbTimKiemKM.Controls.Add(this.txtTenHang);
            this.grbTimKiemKM.Controls.Add(this.label1);
            this.grbTimKiemKM.Controls.Add(this.comboBox3);
            this.grbTimKiemKM.Controls.Add(this.label3);
            this.grbTimKiemKM.Controls.Add(this.comboBox1);
            this.grbTimKiemKM.Controls.Add(this.lblTenHang);
            this.grbTimKiemKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbTimKiemKM.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTimKiemKM.Location = new System.Drawing.Point(3, 3);
            this.grbTimKiemKM.Name = "grbTimKiemKM";
            this.grbTimKiemKM.Size = new System.Drawing.Size(794, 86);
            this.grbTimKiemKM.TabIndex = 3;
            this.grbTimKiemKM.TabStop = false;
            this.grbTimKiemKM.Text = "Tạo chương trình khuyến mãi";
            // 
            // btnThemLoaiKM
            // 
            this.btnThemLoaiKM.Location = new System.Drawing.Point(527, 22);
            this.btnThemLoaiKM.Name = "btnThemLoaiKM";
            this.btnThemLoaiKM.Size = new System.Drawing.Size(31, 22);
            this.btnThemLoaiKM.TabIndex = 3;
            this.btnThemLoaiKM.Text = "+";
            this.btnThemLoaiKM.UseVisualStyleBackColor = true;
            this.btnThemLoaiKM.Click += new System.EventHandler(this.btnThemLoaiKM_Click);
            // 
            // grbThoiGianApDung
            // 
            this.grbThoiGianApDung.Controls.Add(this.dtpNgayHetHan);
            this.grbThoiGianApDung.Controls.Add(this.dtpNgayAD);
            this.grbThoiGianApDung.Controls.Add(this.lblDen);
            this.grbThoiGianApDung.Controls.Add(this.lblTu);
            this.grbThoiGianApDung.Dock = System.Windows.Forms.DockStyle.Right;
            this.grbThoiGianApDung.Location = new System.Drawing.Point(586, 17);
            this.grbThoiGianApDung.Name = "grbThoiGianApDung";
            this.grbThoiGianApDung.Size = new System.Drawing.Size(205, 66);
            this.grbThoiGianApDung.TabIndex = 4;
            this.grbThoiGianApDung.TabStop = false;
            this.grbThoiGianApDung.Text = "Thời gian áp dụng";
            // 
            // dtpNgayHetHan
            // 
            this.dtpNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHetHan.Location = new System.Drawing.Point(56, 45);
            this.dtpNgayHetHan.Name = "dtpNgayHetHan";
            this.dtpNgayHetHan.Size = new System.Drawing.Size(130, 21);
            this.dtpNgayHetHan.TabIndex = 6;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(89, 59);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(201, 21);
            this.txtTenHang.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hàng";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(296, 22);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(225, 23);
            this.comboBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(238, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại KM";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(89, 23);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(127, 23);
            this.comboBox1.TabIndex = 0;
            // 
            // lblTenHang
            // 
            this.lblTenHang.AutoSize = true;
            this.lblTenHang.Location = new System.Drawing.Point(15, 61);
            this.lblTenHang.Name = "lblTenHang";
            this.lblTenHang.Size = new System.Drawing.Size(59, 15);
            this.lblTenHang.TabIndex = 0;
            this.lblTenHang.Text = "Tên hàng";
            // 
            // grbMatHangKM
            // 
            this.grbMatHangKM.Controls.Add(this.dgvMatHangKM);
            this.grbMatHangKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbMatHangKM.Location = new System.Drawing.Point(3, 95);
            this.grbMatHangKM.Name = "grbMatHangKM";
            this.grbMatHangKM.Size = new System.Drawing.Size(794, 362);
            this.grbMatHangKM.TabIndex = 2;
            this.grbMatHangKM.TabStop = false;
            this.grbMatHangKM.Text = "Mặt hàng khuyến mãi ";
            // 
            // dgvMatHangKM
            // 
            this.dgvMatHangKM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMatHangKM.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dgvMatHangKM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHangKM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHang,
            this.TenHang,
            this.DVT,
            this.LoaiKM});
            this.dgvMatHangKM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatHangKM.Location = new System.Drawing.Point(3, 16);
            this.dgvMatHangKM.Name = "dgvMatHangKM";
            this.dgvMatHangKM.Size = new System.Drawing.Size(788, 343);
            this.dgvMatHangKM.TabIndex = 0;
            // 
            // MaHang
            // 
            this.MaHang.HeaderText = "Mã hàng";
            this.MaHang.Name = "MaHang";
            // 
            // TenHang
            // 
            this.TenHang.HeaderText = "Tên hàng";
            this.TenHang.Name = "TenHang";
            // 
            // DVT
            // 
            this.DVT.HeaderText = "Đơn vị tính";
            this.DVT.Name = "DVT";
            // 
            // LoaiKM
            // 
            this.LoaiKM.HeaderText = "Loại KM";
            this.LoaiKM.Name = "LoaiKM";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.grbMatHangKM, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.grbTimKiemKM, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlButton, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 500);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Image = global::quan_ly_ban_hang_sieu_thi.Properties.Resources.delete_Icon;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(632, 5);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(65, 25);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.Text = "&Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnLuu);
            this.pnlButton.Controls.Add(this.btnXoa);
            this.pnlButton.Controls.Add(this.btnTimKiem);
            this.pnlButton.Controls.Add(this.btnSua);
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButton.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlButton.Location = new System.Drawing.Point(3, 463);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(794, 34);
            this.pnlButton.TabIndex = 4;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Image = global::quan_ly_ban_hang_sieu_thi.Properties.Resources.add_icon;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(483, 5);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(65, 25);
            this.btnTimKiem.TabIndex = 7;
            this.btnTimKiem.Text = "  &Thêm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Image = global::quan_ly_ban_hang_sieu_thi.Properties.Resources.icon_edit;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(554, 5);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(65, 25);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "&Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Image = global::quan_ly_ban_hang_sieu_thi.Properties.Resources.save_icon;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(703, 5);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(65, 25);
            this.btnLuu.TabIndex = 7;
            this.btnLuu.Text = "&Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(527, 52);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(31, 25);
            this.btnInsert.TabIndex = 7;
            this.btnInsert.Text = ">>";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // ucChuongTrinhKM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ucChuongTrinhKM";
            this.Size = new System.Drawing.Size(800, 500);
            this.grbTimKiemKM.ResumeLayout(false);
            this.grbTimKiemKM.PerformLayout();
            this.grbThoiGianApDung.ResumeLayout(false);
            this.grbThoiGianApDung.PerformLayout();
            this.grbMatHangKM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHangKM)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.pnlButton.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTimKiemKM;
        private System.Windows.Forms.DateTimePicker dtpNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtpNgayAD;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblDen;
        private System.Windows.Forms.GroupBox grbMatHangKM;
        private System.Windows.Forms.DataGridView dgvMatHangKM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTenHang;
        private System.Windows.Forms.GroupBox grbThoiGianApDung;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.Button btnThemLoaiKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn DVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiKM;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnLuu;

    }
}
