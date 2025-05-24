namespace QuanLyLapTop.Forms
{
    partial class frmPhieuNhap_ChiTiet
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap_ChiTiet));
            btnXoa = new Button();
            btnHuy = new Button();
            btnInPhieuNhap = new Button();
            btnLapPhieuNhap = new Button();
            dataGridView = new DataGridView();
            SanPhamID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            DonGiaNhap = new DataGridViewTextBoxColumn();
            SoLuongNhap = new DataGridViewTextBoxColumn();
            ThanhTien = new DataGridViewTextBoxColumn();
            groupBox1 = new GroupBox();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            btnThoat = new Button();
            groupBox3 = new GroupBox();
            cboLoaiSanPham = new ComboBox();
            label7 = new Label();
            cboHangSanXuat = new ComboBox();
            label8 = new Label();
            cboNhaCungCap = new ComboBox();
            label2 = new Label();
            cboNhanVien = new ComboBox();
            txtGhiChu = new TextBox();
            label3 = new Label();
            label1 = new Label();
            groupBox4 = new GroupBox();
            btnXacNhanNhap = new Button();
            numSoLuong = new NumericUpDown();
            label6 = new Label();
            numGiaNhap = new NumericUpDown();
            label5 = new Label();
            cboSanPham = new ComboBox();
            label4 = new Label();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            toolStrip.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(877, 59);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.ForeColor = Color.Red;
            btnHuy.Location = new Point(651, 9);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 38);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Quay về...";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Anchor = AnchorStyles.Top;
            btnInPhieuNhap.Location = new Point(473, 9);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(122, 38);
            btnInPhieuNhap.TabIndex = 1;
            btnInPhieuNhap.Text = "In phiếu nhập...";
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            btnInPhieuNhap.Click += btnInPhieuNhap_Click;
            // 
            // btnLapPhieuNhap
            // 
            btnLapPhieuNhap.Anchor = AnchorStyles.Top;
            btnLapPhieuNhap.ForeColor = Color.Blue;
            btnLapPhieuNhap.Location = new Point(237, 9);
            btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            btnLapPhieuNhap.Size = new Size(204, 38);
            btnLapPhieuNhap.TabIndex = 0;
            btnLapPhieuNhap.Text = "Lưu phiếu nhập hàng...";
            btnLapPhieuNhap.UseVisualStyleBackColor = true;
            btnLapPhieuNhap.Click += btnLapPhieuNhap_Click;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { SanPhamID, TenSanPham, DonGiaNhap, SoLuongNhap, ThanhTien });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(3, 54);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(976, 253);
            dataGridView.TabIndex = 3;
            // 
            // SanPhamID
            // 
            SanPhamID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SanPhamID.DataPropertyName = "SanPhamID";
            SanPhamID.HeaderText = "ID";
            SanPhamID.MinimumWidth = 6;
            SanPhamID.Name = "SanPhamID";
            SanPhamID.ReadOnly = true;
            SanPhamID.Width = 30;
            // 
            // TenSanPham
            // 
            TenSanPham.DataPropertyName = "TenSanPham";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.NullValue = null;
            TenSanPham.DefaultCellStyle = dataGridViewCellStyle1;
            TenSanPham.HeaderText = "Tên sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            DonGiaNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DonGiaNhap.DataPropertyName = "DonGiaNhap";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.ForeColor = Color.Blue;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            DonGiaNhap.DefaultCellStyle = dataGridViewCellStyle2;
            DonGiaNhap.HeaderText = "Giá nhập";
            DonGiaNhap.MinimumWidth = 6;
            DonGiaNhap.Name = "DonGiaNhap";
            DonGiaNhap.ReadOnly = true;
            DonGiaNhap.Width = 250;
            // 
            // SoLuongNhap
            // 
            SoLuongNhap.DataPropertyName = "SoLuongNhap";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            SoLuongNhap.DefaultCellStyle = dataGridViewCellStyle3;
            SoLuongNhap.HeaderText = "Số lượng ";
            SoLuongNhap.MinimumWidth = 6;
            SoLuongNhap.Name = "SoLuongNhap";
            SoLuongNhap.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = Color.Blue;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle4;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Controls.Add(toolStrip);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.ForeColor = Color.Blue;
            groupBox1.Location = new Point(0, 286);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 310);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách phiếu nhập chi tiết";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip.Location = new Point(3, 23);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(976, 31);
            toolStrip.TabIndex = 2;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.ForeColor = SystemColors.ControlText;
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(73, 28);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(160, 31);
            // 
            // btnTimKiem
            // 
            btnTimKiem.ForeColor = SystemColors.ControlText;
            btnTimKiem.Image = Properties.Resources.search;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(62, 28);
            btnTimKiem.Text = "Tìm";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnNhap
            // 
            btnNhap.ForeColor = SystemColors.ControlText;
            btnNhap.Image = Properties.Resources.import2;
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(82, 28);
            btnNhap.Text = "Nhập...";
            // 
            // btnXuat
            // 
            btnXuat.ForeColor = SystemColors.ControlText;
            btnXuat.Image = Properties.Resources.export2;
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(76, 28);
            btnXuat.Text = "Xuất...";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top;
            btnThoat.Location = new Point(1638, 203);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonHighlight;
            groupBox3.Controls.Add(cboLoaiSanPham);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(cboHangSanXuat);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(cboNhaCungCap);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cboNhanVien);
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(982, 162);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin phiếu nhập";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(652, 75);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(318, 28);
            cboLoaiSanPham.TabIndex = 4;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlText;
            label7.Location = new Point(504, 78);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 23;
            label7.Text = "Loại sản phẩm (*):";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(175, 75);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(318, 28);
            cboHangSanXuat.TabIndex = 1;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(43, 78);
            label8.Name = "label8";
            label8.Size = new Size(126, 20);
            label8.TabIndex = 21;
            label8.Text = "Hãng sản xuất (*):";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(653, 27);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(318, 28);
            cboNhaCungCap.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(505, 30);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 19;
            label2.Text = " Nhà cung cấp (*):";
            // 
            // cboNhanVien
            // 
            cboNhanVien.FormattingEnabled = true;
            cboNhanVien.Location = new Point(176, 27);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(318, 28);
            cboNhanVien.TabIndex = 0;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(175, 122);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(795, 27);
            txtGhiChu.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(10, 125);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 11;
            label3.Text = "Ghi chú phiếu nhập (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(71, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 7;
            label1.Text = "Nhân viên (*):";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ButtonHighlight;
            groupBox4.Controls.Add(btnXacNhanNhap);
            groupBox4.Controls.Add(btnXoa);
            groupBox4.Controls.Add(numSoLuong);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(numGiaNhap);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(cboSanPham);
            groupBox4.Controls.Add(label4);
            groupBox4.Dock = DockStyle.Top;
            groupBox4.ForeColor = Color.Blue;
            groupBox4.Location = new Point(0, 162);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(982, 124);
            groupBox4.TabIndex = 16;
            groupBox4.TabStop = false;
            groupBox4.Text = "Thông tin phiếu nhập chi tiết";
            // 
            // btnXacNhanNhap
            // 
            btnXacNhanNhap.Anchor = AnchorStyles.Top;
            btnXacNhanNhap.ForeColor = Color.Green;
            btnXacNhanNhap.Location = new Point(665, 59);
            btnXacNhanNhap.Name = "btnXacNhanNhap";
            btnXacNhanNhap.Size = new Size(171, 29);
            btnXacNhanNhap.TabIndex = 3;
            btnXacNhanNhap.Text = "Xác nhận nhập...";
            btnXacNhanNhap.UseVisualStyleBackColor = true;
            btnXacNhanNhap.Click += btnXacNhanNhap_Click;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(470, 61);
            numSoLuong.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(141, 27);
            numSoLuong.TabIndex = 2;
            numSoLuong.ThousandsSeparator = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlText;
            label6.Location = new Point(470, 37);
            label6.Name = "label6";
            label6.Size = new Size(92, 20);
            label6.TabIndex = 25;
            label6.Text = "Số lượng (*):";
            // 
            // numGiaNhap
            // 
            numGiaNhap.Location = new Point(308, 61);
            numGiaNhap.Maximum = new decimal(new int[] { 1000000000, 0, 0, 0 });
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.Size = new Size(142, 27);
            numGiaNhap.TabIndex = 1;
            numGiaNhap.ThousandsSeparator = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(308, 37);
            label5.Name = "label5";
            label5.Size = new Size(91, 20);
            label5.TabIndex = 23;
            label5.Text = "Giá nhập (*):";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Location = new Point(12, 59);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(272, 28);
            cboSanPham.TabIndex = 0;
            cboSanPham.SelectionChangeCommitted += cboSanPham_SelectionChangeCommitted;
            cboSanPham.Leave += cboSanPham_Leave;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = SystemColors.ControlText;
            label4.Location = new Point(12, 36);
            label4.Name = "label4";
            label4.Size = new Size(98, 20);
            label4.TabIndex = 21;
            label4.Text = "Sản phẩm (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnHuy);
            groupBox2.Controls.Add(btnLapPhieuNhap);
            groupBox2.Controls.Add(btnInPhieuNhap);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 596);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(982, 57);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            // 
            // frmPhieuNhap_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(btnThoat);
            Controls.Add(groupBox1);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPhieuNhap_ChiTiet";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Phiếu nhập chi tiết";
            Load += frmPhieuNhap_ChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnXoa;
        private Button btnHuy;
        private Button btnInPhieuNhap;
        private Button btnLapPhieuNhap;
        private DataGridView dataGridView;
        private GroupBox groupBox1;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private Button btnThoat;
        private GroupBox groupBox3;
        private ComboBox cboNhaCungCap;
        private Label label2;
        private ComboBox cboNhanVien;
        private TextBox txtGhiChu;
        private Label label3;
        private Label label1;
        private GroupBox groupBox4;
        private Label label5;
        private ComboBox cboSanPham;
        private Label label4;
        private Button btnXacNhanNhap;
        private NumericUpDown numSoLuong;
        private Label label6;
        private NumericUpDown numGiaNhap;
        private DataGridViewTextBoxColumn SanPhamID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn ThanhTien;
        private ComboBox cboLoaiSanPham;
        private Label label7;
        private ComboBox cboHangSanXuat;
        private Label label8;
        private GroupBox groupBox2;
    }
}