namespace QuanLyLapTop.Forms
{
    partial class frmSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham));
            toolStripLabel1 = new ToolStripLabel();
            groupBox3 = new GroupBox();
            btnSanPhamChiTiet = new Button();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnLuu = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStrip = new ToolStrip();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            cboHangSanXuat = new ComboBox();
            txtGiaBan = new TextBox();
            txtTenSanPham = new TextBox();
            label6 = new Label();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            GiaBan = new DataGridViewTextBoxColumn();
            SoLuongTon = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            TenLoaiSanPham = new DataGridViewTextBoxColumn();
            TenNhaCungCap = new DataGridViewTextBoxColumn();
            NgayNhap = new DataGridViewTextBoxColumn();
            MoTa = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtGiamGia = new TextBox();
            label10 = new Label();
            cboNhaCungCap = new ComboBox();
            label9 = new Label();
            cboLoaiSanPham = new ComboBox();
            label8 = new Label();
            txtMoTa = new TextBox();
            label7 = new Label();
            picHinhAnh = new PictureBox();
            dateNgayNhap = new DateTimePicker();
            label2 = new Label();
            label4 = new Label();
            groupBox3.SuspendLayout();
            toolStrip.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(73, 28);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.MediumSeaGreen;
            groupBox3.BackgroundImageLayout = ImageLayout.None;
            groupBox3.Controls.Add(btnSanPhamChiTiet);
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnHuyBo);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Location = new Point(0, 197);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(1232, 89);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // btnSanPhamChiTiet
            // 
            btnSanPhamChiTiet.ForeColor = Color.Lime;
            btnSanPhamChiTiet.Location = new Point(885, 24);
            btnSanPhamChiTiet.Name = "btnSanPhamChiTiet";
            btnSanPhamChiTiet.Size = new Size(219, 40);
            btnSanPhamChiTiet.TabIndex = 5;
            btnSanPhamChiTiet.Text = "Sản phẩm chi tiết...";
            btnSanPhamChiTiet.UseVisualStyleBackColor = true;
            btnSanPhamChiTiet.Click += btnSanPhamChiTiet_Click;
            // 
            // btnThoat
            // 
            btnThoat.ForeColor = Color.Red;
            btnThoat.Location = new Point(82, 24);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(147, 40);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Quay về...";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(646, 24);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 40);
            btnHuyBo.TabIndex = 3;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(524, 24);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 40);
            btnLuu.TabIndex = 2;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(402, 24);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(281, 24);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 0;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(160, 31);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.search;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(62, 28);
            btnTimKiem.Text = "Tìm";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip.Location = new Point(3, 23);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(1226, 31);
            toolStrip.TabIndex = 2;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnNhap
            // 
            btnNhap.Image = Properties.Resources.import2;
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(82, 28);
            btnNhap.Text = "Nhập...";
            // 
            // btnXuat
            // 
            btnXuat.Image = Properties.Resources.export2;
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(76, 28);
            btnXuat.Text = "Xuất...";
            // 
            // cboHangSanXuat
            // 
            cboHangSanXuat.FormattingEnabled = true;
            cboHangSanXuat.Location = new Point(706, 37);
            cboHangSanXuat.Name = "cboHangSanXuat";
            cboHangSanXuat.Size = new Size(246, 28);
            cboHangSanXuat.TabIndex = 4;
            // 
            // txtGiaBan
            // 
            txtGiaBan.Location = new Point(159, 73);
            txtGiaBan.Name = "txtGiaBan";
            txtGiaBan.Size = new Size(342, 27);
            txtGiaBan.TabIndex = 1;
            // 
            // txtTenSanPham
            // 
            txtTenSanPham.Location = new Point(159, 34);
            txtTenSanPham.Name = "txtTenSanPham";
            txtTenSanPham.Size = new Size(342, 27);
            txtTenSanPham.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(574, 38);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 5;
            label6.Text = "Hãng sản xuất (*):";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 298);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1232, 455);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách nhân viên";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, GiaBan, SoLuongTon, TenHangSanXuat, TenLoaiSanPham, TenNhaCungCap, NgayNhap, MoTa, HinhAnh });
            dataGridView.Location = new Point(3, 53);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(1229, 402);
            dataGridView.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 30;
            // 
            // TenSanPham
            // 
            TenSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TenSanPham.DataPropertyName = "TenSanPham";
            TenSanPham.HeaderText = "Sản phẩm";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            TenSanPham.Width = 150;
            // 
            // GiaBan
            // 
            GiaBan.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            GiaBan.DataPropertyName = "GiaBan";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.ForeColor = Color.Red;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            GiaBan.DefaultCellStyle = dataGridViewCellStyle1;
            GiaBan.HeaderText = "Giá bán";
            GiaBan.MinimumWidth = 6;
            GiaBan.Name = "GiaBan";
            GiaBan.ReadOnly = true;
            GiaBan.Width = 125;
            // 
            // SoLuongTon
            // 
            SoLuongTon.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            SoLuongTon.DataPropertyName = "SoLuongTon";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SoLuongTon.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuongTon.HeaderText = "SL";
            SoLuongTon.MinimumWidth = 6;
            SoLuongTon.Name = "SoLuongTon";
            SoLuongTon.ReadOnly = true;
            SoLuongTon.Width = 60;
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.HeaderText = "HSX";
            TenHangSanXuat.MinimumWidth = 6;
            TenHangSanXuat.Name = "TenHangSanXuat";
            TenHangSanXuat.ReadOnly = true;
            TenHangSanXuat.Width = 80;
            // 
            // TenLoaiSanPham
            // 
            TenLoaiSanPham.DataPropertyName = "TenLoaiSanPham";
            TenLoaiSanPham.HeaderText = "Loại sản phẩm";
            TenLoaiSanPham.MinimumWidth = 6;
            TenLoaiSanPham.Name = "TenLoaiSanPham";
            TenLoaiSanPham.ReadOnly = true;
            // 
            // TenNhaCungCap
            // 
            TenNhaCungCap.DataPropertyName = "TenNhaCungCap";
            TenNhaCungCap.HeaderText = "Nhà cung cấp";
            TenNhaCungCap.MinimumWidth = 6;
            TenNhaCungCap.Name = "TenNhaCungCap";
            TenNhaCungCap.ReadOnly = true;
            // 
            // NgayNhap
            // 
            NgayNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            NgayNhap.DataPropertyName = "NgayNhap";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            NgayNhap.DefaultCellStyle = dataGridViewCellStyle3;
            NgayNhap.HeaderText = "Ngày nhập";
            NgayNhap.MinimumWidth = 6;
            NgayNhap.Name = "NgayNhap";
            NgayNhap.ReadOnly = true;
            NgayNhap.Width = 130;
            // 
            // MoTa
            // 
            MoTa.DataPropertyName = "MoTa";
            MoTa.HeaderText = "Mô tả";
            MoTa.MinimumWidth = 6;
            MoTa.Name = "MoTa";
            MoTa.ReadOnly = true;
            // 
            // HinhAnh
            // 
            HinhAnh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            HinhAnh.Width = 125;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 37);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtGiamGia);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cboNhaCungCap);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboLoaiSanPham);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtMoTa);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(dateNgayNhap);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(cboHangSanXuat);
            groupBox1.Controls.Add(txtGiaBan);
            groupBox1.Controls.Add(txtTenSanPham);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1232, 298);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm";
            // 
            // txtGiamGia
            // 
            txtGiamGia.Location = new Point(706, 150);
            txtGiamGia.Name = "txtGiamGia";
            txtGiamGia.Size = new Size(246, 27);
            txtGiamGia.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(608, 153);
            label10.Name = "label10";
            label10.Size = new Size(92, 20);
            label10.TabIndex = 16;
            label10.Text = "Giảm giá (*):";
            // 
            // cboNhaCungCap
            // 
            cboNhaCungCap.FormattingEnabled = true;
            cboNhaCungCap.Location = new Point(706, 112);
            cboNhaCungCap.Name = "cboNhaCungCap";
            cboNhaCungCap.Size = new Size(246, 28);
            cboNhaCungCap.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(577, 116);
            label9.Name = "label9";
            label9.Size = new Size(123, 20);
            label9.TabIndex = 14;
            label9.Text = "Nhà cung cấp (*):";
            // 
            // cboLoaiSanPham
            // 
            cboLoaiSanPham.FormattingEnabled = true;
            cboLoaiSanPham.Location = new Point(706, 73);
            cboLoaiSanPham.Name = "cboLoaiSanPham";
            cboLoaiSanPham.Size = new Size(246, 28);
            cboLoaiSanPham.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(572, 77);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 12;
            label8.Text = "Loại sản phẩm (*):";
            // 
            // txtMoTa
            // 
            txtMoTa.Location = new Point(159, 153);
            txtMoTa.Name = "txtMoTa";
            txtMoTa.Size = new Size(342, 27);
            txtMoTa.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(82, 156);
            label7.Name = "label7";
            label7.Size = new Size(71, 20);
            label7.TabIndex = 10;
            label7.Text = "Mô tả (*):";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Image = Properties.Resources.no_image;
            picHinhAnh.Location = new Point(1021, 34);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(140, 143);
            picHinhAnh.SizeMode = PictureBoxSizeMode.StretchImage;
            picHinhAnh.TabIndex = 8;
            picHinhAnh.TabStop = false;
            picHinhAnh.Click += picHinhAnh_Click;
            // 
            // dateNgayNhap
            // 
            dateNgayNhap.Location = new Point(159, 111);
            dateNgayNhap.Name = "dateNgayNhap";
            dateNgayNhap.Size = new Size(342, 27);
            dateNgayNhap.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 76);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 6;
            label2.Text = "Giá bán (*):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 114);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 3;
            label4.Text = "Ngày nhập (*):";
            // 
            // frmSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 753);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản Phẩm";
            Load += frmSanPham_Load;
            groupBox3.ResumeLayout(false);
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ToolStripLabel toolStripLabel1;
        private GroupBox groupBox3;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnLuu;
        private Button btnXoa;
        private Button btnSua;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStrip toolStrip;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private ComboBox cboHangSanXuat;
        private TextBox txtGiaBan;
        private TextBox txtTenSanPham;
        private Label label6;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private Label label4;
        private DateTimePicker dateNgayNhap;
        private TextBox txtMoTa;
        private Label label7;
        private PictureBox picHinhAnh;
        private ComboBox cboNhaCungCap;
        private Label label9;
        private ComboBox cboLoaiSanPham;
        private Label label8;
        private TextBox txtGiamGia;
        private Label label10;
        private Button btnSanPhamChiTiet;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn GiaBan;
        private DataGridViewTextBoxColumn SoLuongTon;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn TenLoaiSanPham;
        private DataGridViewTextBoxColumn TenNhaCungCap;
        private DataGridViewTextBoxColumn NgayNhap;
        private DataGridViewTextBoxColumn MoTa;
        private DataGridViewTextBoxColumn HinhAnh;
    }
}