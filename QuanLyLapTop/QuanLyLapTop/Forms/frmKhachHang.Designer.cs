namespace QuanLyLapTop.Forms
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            lblTrangThai = new ToolStripStatusLabel();
            staStp_LienKet = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            txtDienThoai = new TextBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            label2 = new Label();
            txtHoVaTen = new TextBox();
            btnXuat = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnTimKiem = new ToolStripButton();
            txtTuKhoa = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip = new ToolStrip();
            btnNhap = new ToolStripButton();
            groupBox2 = new GroupBox();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTen = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtDiaChi = new TextBox();
            label3 = new Label();
            staStp_LienKet.SuspendLayout();
            toolStrip.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.IsLink = true;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(156, 20);
            toolStripStatusLabel2.Text = "© Khoa CNTT - ĐHAG";
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
            staStp_LienKet.Location = new Point(0, 427);
            staStp_LienKet.Name = "staStp_LienKet";
            staStp_LienKet.Size = new Size(882, 26);
            staStp_LienKet.TabIndex = 7;
            staStp_LienKet.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(590, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // txtDienThoai
            // 
            txtDienThoai.Location = new Point(23, 132);
            txtDienThoai.Margin = new Padding(2);
            txtDienThoai.Name = "txtDienThoai";
            txtDienThoai.Size = new Size(331, 27);
            txtDienThoai.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(20, 356);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(207, 356);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(150, 40);
            btnHuyBo.TabIndex = 8;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(207, 264);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 263);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 3;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(207, 310);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(20, 310);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(150, 40);
            btnSua.TabIndex = 4;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 110);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 8;
            label2.Text = "Số điện thoại (*):";
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(23, 65);
            txtHoVaTen.Margin = new Padding(2);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(334, 27);
            txtHoVaTen.TabIndex = 0;
            // 
            // btnXuat
            // 
            btnXuat.Image = (Image)resources.GetObject("btnXuat.Image");
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(76, 28);
            btnXuat.Text = "Xuất...";
            btnXuat.Click += btnXuat_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
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
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(160, 31);
            txtTuKhoa.KeyDown += txtTuKhoa_KeyDown;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(73, 28);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip.Location = new Point(2, 22);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(497, 31);
            toolStrip.TabIndex = 0;
            // 
            // btnNhap
            // 
            btnNhap.Image = (Image)resources.GetObject("btnNhap.Image");
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(82, 28);
            btnNhap.Text = "Nhập...";
            btnNhap.Click += btnNhap_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(381, 0);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(501, 425);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách khách hàng";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTen, DienThoai, DiaChi });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(2, 53);
            dataGridView.Margin = new Padding(2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(497, 370);
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
            ID.Width = 40;
            // 
            // HoVaTen
            // 
            HoVaTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            HoVaTen.DataPropertyName = "HoVaTen";
            HoVaTen.FillWeight = 273.7226F;
            HoVaTen.HeaderText = "Họ và tên";
            HoVaTen.MinimumWidth = 8;
            HoVaTen.Name = "HoVaTen";
            HoVaTen.ReadOnly = true;
            HoVaTen.Width = 160;
            // 
            // DienThoai
            // 
            DienThoai.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            DienThoai.DataPropertyName = "DienThoai";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            DienThoai.DefaultCellStyle = dataGridViewCellStyle1;
            DienThoai.FillWeight = 13.1387014F;
            DienThoai.HeaderText = "Điện thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            DienThoai.Resizable = DataGridViewTriState.True;
            DienThoai.SortMode = DataGridViewColumnSortMode.NotSortable;
            DienThoai.Width = 120;
            // 
            // DiaChi
            // 
            DiaChi.DataPropertyName = "DiaChi";
            DiaChi.HeaderText = "Địa chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 20);
            label1.TabIndex = 0;
            label1.Text = "Họ và tên (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtDienThoai);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtHoVaTen);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(377, 425);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin khách hàng";
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(23, 203);
            txtDiaChi.Margin = new Padding(2);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(331, 27);
            txtDiaChi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 181);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(78, 20);
            label3.TabIndex = 11;
            label3.Text = "Địa chỉ (*):";
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 453);
            Controls.Add(staStp_LienKet);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Khách Hàng";
            Load += frmKhachHang_Load;
            staStp_LienKet.ResumeLayout(false);
            staStp_LienKet.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripStatusLabel lblTrangThai;
        private StatusStrip staStp_LienKet;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TextBox txtDienThoai;
        private Button btnThoat;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThem;
        private Button btnLuu;
        private Button btnSua;
        private Label label2;
        private TextBox txtHoVaTen;
        private ToolStripButton btnXuat;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnTimKiem;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip;
        private ToolStripButton btnNhap;
        private GroupBox groupBox2;
        private DataGridView dataGridView;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtDiaChi;
        private Label label3;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTen;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
    }
}