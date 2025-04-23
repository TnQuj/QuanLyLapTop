namespace QuanLyLapTop.Forms
{
    partial class frmSanPham_ChiTiet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSanPham_ChiTiet));
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenSanPham = new DataGridViewTextBoxColumn();
            CPU = new DataGridViewTextBoxColumn();
            RAM = new DataGridViewTextBoxColumn();
            OCung = new DataGridViewTextBoxColumn();
            ManHinh = new DataGridViewTextBoxColumn();
            GPU = new DataGridViewTextBoxColumn();
            Pin = new DataGridViewTextBoxColumn();
            TrongLuong = new DataGridViewTextBoxColumn();
            HeDieuHanh = new DataGridViewTextBoxColumn();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            staStp_LienKet = new StatusStrip();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            groupBox2 = new GroupBox();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            label1 = new Label();
            label3 = new Label();
            txtCPU = new TextBox();
            cboTrongLuong = new ComboBox();
            groupBox3 = new GroupBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXemChiTiet = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnLuuSanPham = new Button();
            label2 = new Label();
            label7 = new Label();
            txtOCung = new TextBox();
            label4 = new Label();
            txtManHinh = new TextBox();
            label5 = new Label();
            txtGPU = new TextBox();
            label6 = new Label();
            txtPin = new TextBox();
            label8 = new Label();
            groupBox1 = new GroupBox();
            cboSanPham = new ComboBox();
            label9 = new Label();
            cboHeDieuHanh = new ComboBox();
            cboRAM = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            staStp_LienKet.SuspendLayout();
            groupBox2.SuspendLayout();
            toolStrip.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenSanPham, CPU, RAM, OCung, ManHinh, GPU, Pin, TrongLuong, HeDieuHanh });
            dataGridView.Location = new Point(0, 53);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(982, 224);
            dataGridView.TabIndex = 1;
            dataGridView.CellContentClick += dataGridView_CellContentClick;
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
            TenSanPham.HeaderText = "Tên sản phẩm ";
            TenSanPham.MinimumWidth = 6;
            TenSanPham.Name = "TenSanPham";
            TenSanPham.ReadOnly = true;
            TenSanPham.Width = 150;
            // 
            // CPU
            // 
            CPU.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            CPU.DataPropertyName = "CPU";
            CPU.HeaderText = "CPU";
            CPU.MinimumWidth = 6;
            CPU.Name = "CPU";
            CPU.ReadOnly = true;
            CPU.Width = 125;
            // 
            // RAM
            // 
            RAM.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            RAM.DataPropertyName = "RAM";
            RAM.HeaderText = "RAM";
            RAM.MinimumWidth = 6;
            RAM.Name = "RAM";
            RAM.ReadOnly = true;
            RAM.Width = 90;
            // 
            // OCung
            // 
            OCung.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            OCung.DataPropertyName = "OCung";
            OCung.HeaderText = "Ổ cứng";
            OCung.MinimumWidth = 6;
            OCung.Name = "OCung";
            OCung.ReadOnly = true;
            OCung.Width = 90;
            // 
            // ManHinh
            // 
            ManHinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ManHinh.DataPropertyName = "ManHinh";
            ManHinh.HeaderText = "Màn hình";
            ManHinh.MinimumWidth = 6;
            ManHinh.Name = "ManHinh";
            ManHinh.ReadOnly = true;
            ManHinh.Resizable = DataGridViewTriState.True;
            ManHinh.SortMode = DataGridViewColumnSortMode.NotSortable;
            ManHinh.Width = 120;
            // 
            // GPU
            // 
            GPU.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            GPU.DataPropertyName = "GPU";
            GPU.HeaderText = "GPU";
            GPU.MinimumWidth = 6;
            GPU.Name = "GPU";
            GPU.ReadOnly = true;
            GPU.Width = 130;
            // 
            // Pin
            // 
            Pin.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Pin.DataPropertyName = "Pin";
            Pin.HeaderText = "Pin";
            Pin.MinimumWidth = 6;
            Pin.Name = "Pin";
            Pin.ReadOnly = true;
            Pin.Width = 70;
            // 
            // TrongLuong
            // 
            TrongLuong.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TrongLuong.DataPropertyName = "TrongLuong";
            TrongLuong.HeaderText = "Kgam";
            TrongLuong.MinimumWidth = 6;
            TrongLuong.Name = "TrongLuong";
            TrongLuong.ReadOnly = true;
            TrongLuong.Width = 60;
            // 
            // HeDieuHanh
            // 
            HeDieuHanh.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HeDieuHanh.DataPropertyName = "HeDieuHanh";
            HeDieuHanh.HeaderText = "Hệ điều hành";
            HeDieuHanh.MinimumWidth = 6;
            HeDieuHanh.Name = "HeDieuHanh";
            HeDieuHanh.ReadOnly = true;
            HeDieuHanh.Width = 130;
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(684, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(121, 20);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // staStp_LienKet
            // 
            staStp_LienKet.BackColor = Color.MediumSpringGreen;
            staStp_LienKet.ImageScalingSize = new Size(20, 20);
            staStp_LienKet.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, toolStripStatusLabel2 });
            staStp_LienKet.Location = new Point(3, 280);
            staStp_LienKet.Name = "staStp_LienKet";
            staStp_LienKet.Size = new Size(976, 26);
            staStp_LienKet.TabIndex = 5;
            staStp_LienKet.Text = "statusStrip1";
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.IsLink = true;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(156, 20);
            toolStripStatusLabel2.Text = "© Khoa CNTT - ĐHAG";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Controls.Add(staStp_LienKet);
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 244);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(982, 309);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách sản phẩm chi tiết";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip.Location = new Point(3, 23);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(976, 31);
            toolStrip.TabIndex = 6;
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
            // 
            // btnTimKiem
            // 
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm (*):";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(113, 82);
            label3.Name = "label3";
            label3.Size = new Size(39, 20);
            label3.TabIndex = 2;
            label3.Text = "CPU:";
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(158, 78);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(212, 27);
            txtCPU.TabIndex = 1;
            // 
            // cboTrongLuong
            // 
            cboTrongLuong.FormattingEnabled = true;
            cboTrongLuong.Items.AddRange(new object[] { "admin", "user" });
            cboTrongLuong.Location = new Point(814, 73);
            cboTrongLuong.Name = "cboTrongLuong";
            cboTrongLuong.Size = new Size(98, 28);
            cboTrongLuong.TabIndex = 7;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.MediumSeaGreen;
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnHuyBo);
            groupBox3.Controls.Add(btnXemChiTiet);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnLuuSanPham);
            groupBox3.Location = new Point(0, 155);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(979, 74);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(788, 20);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(669, 20);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 40);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            // 
            // btnXemChiTiet
            // 
            btnXemChiTiet.ForeColor = Color.ForestGreen;
            btnXemChiTiet.Location = new Point(508, 20);
            btnXemChiTiet.Name = "btnXemChiTiet";
            btnXemChiTiet.Size = new Size(144, 40);
            btnXemChiTiet.TabIndex = 3;
            btnXemChiTiet.Text = "Xem chi tiết...";
            btnXemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(389, 20);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(270, 20);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnLuuSanPham
            // 
            btnLuuSanPham.ForeColor = Color.Blue;
            btnLuuSanPham.Location = new Point(90, 20);
            btnLuuSanPham.Name = "btnLuuSanPham";
            btnLuuSanPham.Size = new Size(161, 40);
            btnLuuSanPham.TabIndex = 0;
            btnLuuSanPham.Text = "Lưu sản phẩm... ";
            btnLuuSanPham.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 35);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 15;
            label2.Text = "RAM:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(428, 78);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 17;
            label7.Text = "Ổ cứng:";
            // 
            // txtOCung
            // 
            txtOCung.Location = new Point(494, 75);
            txtOCung.Name = "txtOCung";
            txtOCung.Size = new Size(154, 27);
            txtOCung.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(735, 33);
            label4.Name = "label4";
            label4.Size = new Size(73, 20);
            label4.TabIndex = 19;
            label4.Text = "Màn hình:";
            // 
            // txtManHinh
            // 
            txtManHinh.Location = new Point(814, 29);
            txtManHinh.Name = "txtManHinh";
            txtManHinh.Size = new Size(98, 27);
            txtManHinh.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(112, 125);
            label5.Name = "label5";
            label5.Size = new Size(40, 20);
            label5.TabIndex = 21;
            label5.Text = "GPU:";
            // 
            // txtGPU
            // 
            txtGPU.Location = new Point(158, 122);
            txtGPU.Name = "txtGPU";
            txtGPU.Size = new Size(212, 27);
            txtGPU.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(456, 121);
            label6.Name = "label6";
            label6.Size = new Size(32, 20);
            label6.TabIndex = 23;
            label6.Text = "Pin:";
            // 
            // txtPin
            // 
            txtPin.Location = new Point(494, 119);
            txtPin.Name = "txtPin";
            txtPin.Size = new Size(154, 27);
            txtPin.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(715, 76);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 25;
            label8.Text = "Trọng lượng:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboSanPham);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(cboHeDieuHanh);
            groupBox1.Controls.Add(cboRAM);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtPin);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtGPU);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtManHinh);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtOCung);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(cboTrongLuong);
            groupBox1.Controls.Add(txtCPU);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 244);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin sản phẩm chi tiết";
            // 
            // cboSanPham
            // 
            cboSanPham.FormattingEnabled = true;
            cboSanPham.Items.AddRange(new object[] { "admin", "user" });
            cboSanPham.Location = new Point(158, 34);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(212, 28);
            cboSanPham.TabIndex = 29;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(708, 120);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 28;
            label9.Text = "Hệ điều hành:";
            // 
            // cboHeDieuHanh
            // 
            cboHeDieuHanh.FormattingEnabled = true;
            cboHeDieuHanh.Items.AddRange(new object[] { "admin", "user" });
            cboHeDieuHanh.Location = new Point(814, 117);
            cboHeDieuHanh.Name = "cboHeDieuHanh";
            cboHeDieuHanh.Size = new Size(98, 28);
            cboHeDieuHanh.TabIndex = 8;
            // 
            // cboRAM
            // 
            cboRAM.FormattingEnabled = true;
            cboRAM.Items.AddRange(new object[] { "admin", "user" });
            cboRAM.Location = new Point(494, 31);
            cboRAM.Name = "cboRAM";
            cboRAM.Size = new Size(154, 28);
            cboRAM.TabIndex = 3;
            // 
            // frmSanPham_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 553);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmSanPham_ChiTiet";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sản phẩm chi tiết";
            Load += frmSanPham_ChiTiet_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            staStp_LienKet.ResumeLayout(false);
            staStp_LienKet.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel lblTrangThai;
        private StatusStrip staStp_LienKet;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private GroupBox groupBox2;
        private Label label1;
        private Label label3;
        private TextBox txtCPU;
        private ComboBox cboTrongLuong;
        private GroupBox groupBox3;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnSua;
        private Label label2;
        private Label label7;
        private TextBox txtOCung;
        private Label label4;
        private TextBox txtManHinh;
        private Label label5;
        private TextBox txtGPU;
        private Label label6;
        private TextBox txtPin;
        private Label label8;
        private GroupBox groupBox1;
        private Label label9;
        private ComboBox cboHeDieuHanh;
        private ComboBox cboRAM;
        private Button btnXemChiTiet;
        private Button btnLuuSanPham;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenSanPham;
        private DataGridViewTextBoxColumn CPU;
        private DataGridViewTextBoxColumn RAM;
        private DataGridViewTextBoxColumn OCung;
        private DataGridViewTextBoxColumn ManHinh;
        private DataGridViewTextBoxColumn GPU;
        private DataGridViewTextBoxColumn Pin;
        private DataGridViewTextBoxColumn TrongLuong;
        private DataGridViewTextBoxColumn HeDieuHanh;
        private ComboBox cboSanPham;
    }
}