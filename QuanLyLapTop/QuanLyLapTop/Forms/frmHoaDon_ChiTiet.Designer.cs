namespace QuanLyLapTop.Forms
{
    partial class frmHoaDon_ChiTiet
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoaDon_ChiTiet));
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaBan = new DataGridViewTextBoxColumn();
            GiaSauKhiGiam = new DataGridViewTextBoxColumn();
            SoLuongBan = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            numSoLuongBan = new NumericUpDown();
            numDonGiaBan = new NumericUpDown();
            cboSanPham = new ComboBox();
            btnXoa = new Button();
            btnXacNhanBan = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            btnThoat = new Button();
            btnInHoaDon = new Button();
            btnLuuHoaDon = new Button();
            groupBox3 = new GroupBox();
            cboHinhThucThanhToan = new ComboBox();
            label9 = new Label();
            txtGhiChuHoaDon = new TextBox();
            cboKhachHang = new ComboBox();
            cboNhanVien = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            txtGiamGia = new TextBox();
            txtGiaSauKhiGiam = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).BeginInit();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 252);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(982, 401);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin chi tiết hóa đơn";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToOrderColumns = true;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, DonGiaBan, GiaSauKhiGiam, SoLuongBan, ThanhTien });
            dataGridView.Cursor = Cursors.Hand;
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 54);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(976, 344);
            dataGridView.TabIndex = 1;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Visible = false;
            ID.Width = 30;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            // 
            // DonGiaBan
            // 
            DonGiaBan.DataPropertyName = "DonGiaBan";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            DonGiaBan.DefaultCellStyle = dataGridViewCellStyle4;
            DonGiaBan.HeaderText = "Đơn giá bán";
            DonGiaBan.MinimumWidth = 6;
            DonGiaBan.Name = "DonGiaBan";
            // 
            // GiaSauKhiGiam
            // 
            GiaSauKhiGiam.DataPropertyName = "GiaSauKhiGiam";
            GiaSauKhiGiam.HeaderText = "Giá khuyến mãi";
            GiaSauKhiGiam.MinimumWidth = 6;
            GiaSauKhiGiam.Name = "GiaSauKhiGiam";
            // 
            // SoLuongBan
            // 
            SoLuongBan.DataPropertyName = "SoLuongBan";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle5.Format = "N2";
            dataGridViewCellStyle5.NullValue = null;
            SoLuongBan.DefaultCellStyle = dataGridViewCellStyle5;
            SoLuongBan.HeaderText = "Số lượng bán";
            SoLuongBan.MinimumWidth = 6;
            SoLuongBan.Name = "SoLuongBan";
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle6.BackColor = Color.AliceBlue;
            dataGridViewCellStyle6.ForeColor = Color.Blue;
            dataGridViewCellStyle6.Format = "C2";
            dataGridViewCellStyle6.NullValue = "#,0 \"VND\"";
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1 });
            toolStrip.Location = new Point(3, 23);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(976, 31);
            toolStrip.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(73, 28);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(160, 31);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = (Image)resources.GetObject("btnTimKiem.Image");
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(62, 28);
            btnTimKiem.Text = "Tìm";
            btnTimKiem.Click += btnTimKiem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // numSoLuongBan
            // 
            numSoLuongBan.Location = new Point(461, 50);
            numSoLuongBan.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSoLuongBan.Name = "numSoLuongBan";
            numSoLuongBan.Size = new Size(169, 27);
            numSoLuongBan.TabIndex = 9;
            numSoLuongBan.ThousandsSeparator = true;
            // 
            // numDonGiaBan
            // 
            numDonGiaBan.Location = new Point(244, 51);
            numDonGiaBan.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numDonGiaBan.Name = "numDonGiaBan";
            numDonGiaBan.Size = new Size(208, 27);
            numDonGiaBan.TabIndex = 8;
            numDonGiaBan.ThousandsSeparator = true;
            // 
            // cboSanPham
            // 
            cboSanPham.Cursor = Cursors.Hand;
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(31, 50);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(204, 28);
            cboSanPham.TabIndex = 6;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(875, 96);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 33);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnXacNhanBan
            // 
            btnXacNhanBan.BackColor = Color.Lime;
            btnXacNhanBan.ForeColor = Color.ForestGreen;
            btnXacNhanBan.Location = new Point(688, 96);
            btnXacNhanBan.Name = "btnXacNhanBan";
            btnXacNhanBan.Size = new Size(155, 35);
            btnXacNhanBan.TabIndex = 6;
            btnXacNhanBan.Text = "Xác nhận bán...";
            btnXacNhanBan.UseVisualStyleBackColor = false;
            btnXacNhanBan.Click += btnXacNhanBan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(461, 27);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 5;
            label6.Text = "Số lượng bán(*):";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(244, 27);
            label5.Name = "label5";
            label5.Size = new Size(135, 20);
            label5.TabIndex = 4;
            label5.Text = "Đơn giá bán(VND):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(31, 27);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Sản phẩm(*):";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(629, 4);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(110, 36);
            btnThoat.TabIndex = 12;
            btnThoat.Text = "Quay về...";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnInHoaDon
            // 
            btnInHoaDon.Anchor = AnchorStyles.Top;
            btnInHoaDon.Location = new Point(461, 4);
            btnInHoaDon.Name = "btnInHoaDon";
            btnInHoaDon.Size = new Size(110, 36);
            btnInHoaDon.TabIndex = 11;
            btnInHoaDon.Text = "In hóa đơn...";
            btnInHoaDon.UseVisualStyleBackColor = true;
            btnInHoaDon.Click += btnInHoaDon_Click;
            // 
            // btnLuuHoaDon
            // 
            btnLuuHoaDon.Anchor = AnchorStyles.Top;
            btnLuuHoaDon.BackColor = Color.FromArgb(128, 128, 255);
            btnLuuHoaDon.ForeColor = Color.Blue;
            btnLuuHoaDon.Location = new Point(244, 4);
            btnLuuHoaDon.Name = "btnLuuHoaDon";
            btnLuuHoaDon.Size = new Size(194, 36);
            btnLuuHoaDon.TabIndex = 10;
            btnLuuHoaDon.Text = "Lưu hóa đơn...";
            btnLuuHoaDon.UseVisualStyleBackColor = false;
            btnLuuHoaDon.Click += btnLuuHoaDon_Click;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(cboHinhThucThanhToan);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(txtGhiChuHoaDon);
            groupBox3.Controls.Add(cboKhachHang);
            groupBox3.Controls.Add(cboNhanVien);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label12);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(982, 110);
            groupBox3.TabIndex = 7;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin hóa đơn";
            // 
            // cboHinhThucThanhToan
            // 
            cboHinhThucThanhToan.Cursor = Cursors.Hand;
            cboHinhThucThanhToan.FormattingEnabled = true;
            cboHinhThucThanhToan.Location = new Point(709, 70);
            cboHinhThucThanhToan.Name = "cboHinhThucThanhToan";
            cboHinhThucThanhToan.Size = new Size(217, 28);
            cboHinhThucThanhToan.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(510, 73);
            label9.Name = "label9";
            label9.Size = new Size(167, 20);
            label9.TabIndex = 6;
            label9.Text = "Hình thức thanh toán(*):";
            // 
            // txtGhiChuHoaDon
            // 
            txtGhiChuHoaDon.Cursor = Cursors.IBeam;
            txtGhiChuHoaDon.Location = new Point(197, 70);
            txtGhiChuHoaDon.Name = "txtGhiChuHoaDon";
            txtGhiChuHoaDon.Size = new Size(271, 27);
            txtGhiChuHoaDon.TabIndex = 5;
            // 
            // cboKhachHang
            // 
            cboKhachHang.Cursor = Cursors.Hand;
            cboKhachHang.FormattingEnabled = true;
            cboKhachHang.Location = new Point(709, 31);
            cboKhachHang.Name = "cboKhachHang";
            cboKhachHang.Size = new Size(217, 28);
            cboKhachHang.TabIndex = 4;
            // 
            // cboNhanVien
            // 
            cboNhanVien.Cursor = Cursors.Hand;
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(197, 31);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(271, 28);
            cboNhanVien.TabIndex = 3;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(57, 73);
            label10.Name = "label10";
            label10.Size = new Size(120, 20);
            label10.TabIndex = 1;
            label10.Text = "Ghi chú hóa đơn:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(572, 34);
            label11.Name = "label11";
            label11.Size = new Size(105, 20);
            label11.TabIndex = 2;
            label11.Text = "Khách hàng(*):";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(58, 34);
            label12.Name = "label12";
            label12.Size = new Size(119, 20);
            label12.TabIndex = 0;
            label12.Text = "Nhân viên lập(*):";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(txtGiaSauKhiGiam);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(numSoLuongBan);
            groupBox1.Controls.Add(btnXacNhanBan);
            groupBox1.Controls.Add(numDonGiaBan);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(cboSanPham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.FlatStyle = FlatStyle.System;
            groupBox1.Location = new Point(0, 110);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 142);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hóa đơn chi tiết";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(31, 104);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(204, 27);
            txtGiamGia.TabIndex = 13;
            // 
            // txtGiaSauKhiGiam
            // 
            txtGiaSauKhiGiam.Location = new Point(244, 104);
            txtGiaSauKhiGiam.Name = "txtGiaSauKhiGiam";
            txtGiaSauKhiGiam.Size = new Size(208, 27);
            txtGiaSauKhiGiam.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 81);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 11;
            label2.Text = "Giá khuyến mãi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 81);
            label1.Name = "label1";
            label1.Size = new Size(94, 20);
            label1.TabIndex = 10;
            label1.Text = "Giảm giá(%):";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnThoat);
            groupBox4.Controls.Add(btnInHoaDon);
            groupBox4.Controls.Add(btnLuuHoaDon);
            groupBox4.Dock = DockStyle.Bottom;
            groupBox4.Location = new Point(0, 608);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(982, 45);
            groupBox4.TabIndex = 9;
            groupBox4.TabStop = false;
            // 
            // frmHoaDon_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(groupBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmHoaDon_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hóa đơn chi tiết";
            Load += frmHoaDon_ChiTiet_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuongBan).EndInit();
            ((System.ComponentModel.ISupportInitialize)numDonGiaBan).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private NumericUpDown numSoLuongBan;
        private NumericUpDown numDonGiaBan;
        private ComboBox cboSanPham;
        private Button btnXoa;
        private Button btnXacNhanBan;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button btnThoat;
        private Button btnInHoaDon;
        private Button btnLuuHoaDon;
        private GroupBox groupBox3;
        private ComboBox cboHinhThucThanhToan;
        private Label label9;
        private TextBox txtGhiChuHoaDon;
        private ComboBox cboKhachHang;
        private ComboBox cboNhanVien;
        private Label label10;
        private Label label11;
        private Label label12;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private GroupBox groupBox1;
        private GroupBox groupBox4;
        private TextBox txtGiamGia;
        private TextBox txtGiaSauKhiGiam;
        private Label label2;
        private Label label1;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaBan;
        private DataGridViewTextBoxColumn GiaSauKhiGiam;
        private DataGridViewTextBoxColumn SoLuongBan;
        private DataGridViewTextBoxColumn ThanhTien;
    }
}