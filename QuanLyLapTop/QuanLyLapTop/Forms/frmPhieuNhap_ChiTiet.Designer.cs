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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuNhap_ChiTiet));
            button1 = new Button();
            btnXoa = new Button();
            btnHuy = new Button();
            btnInPhieuNhap = new Button();
            btnLapPhieuNhap = new Button();
            panel2 = new Panel();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            HoVaTenNhanVien = new DataGridViewTextBoxColumn();
            GiaNhap = new DataGridViewTextBoxColumn();
            SoLuong = new DataGridViewTextBoxColumn();
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
            panel1 = new Panel();
            groupBox3 = new GroupBox();
            cboNhaCungCao = new ComboBox();
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
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox1.SuspendLayout();
            toolStrip.SuspendLayout();
            panel1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top;
            button1.Location = new Point(2205, 32);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.Text = "Thoát";
            button1.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Anchor = AnchorStyles.Top;
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(877, 59);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Anchor = AnchorStyles.Top;
            btnHuy.ForeColor = Color.Red;
            btnHuy.Location = new Point(650, 22);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(94, 29);
            btnHuy.TabIndex = 2;
            btnHuy.Text = "Thoát";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnInPhieuNhap
            // 
            btnInPhieuNhap.Anchor = AnchorStyles.Top;
            btnInPhieuNhap.Location = new Point(472, 22);
            btnInPhieuNhap.Name = "btnInPhieuNhap";
            btnInPhieuNhap.Size = new Size(122, 29);
            btnInPhieuNhap.TabIndex = 1;
            btnInPhieuNhap.Text = "In hóa đơn...";
            btnInPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // btnLapPhieuNhap
            // 
            btnLapPhieuNhap.Anchor = AnchorStyles.Top;
            btnLapPhieuNhap.ForeColor = Color.Blue;
            btnLapPhieuNhap.Location = new Point(239, 22);
            btnLapPhieuNhap.Name = "btnLapPhieuNhap";
            btnLapPhieuNhap.Size = new Size(204, 29);
            btnLapPhieuNhap.TabIndex = 0;
            btnLapPhieuNhap.Text = "Lập phiếu nhập hàng...";
            btnLapPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Controls.Add(btnHuy);
            panel2.Controls.Add(btnInPhieuNhap);
            panel2.Controls.Add(btnLapPhieuNhap);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(982, 73);
            panel2.TabIndex = 12;
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, HoVaTenNhanVien, GiaNhap, SoLuong, ThanhTien });
            dataGridView.Location = new Point(3, 54);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 51;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(976, 269);
            dataGridView.TabIndex = 3;
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
            // HoVaTenNhanVien
            // 
            HoVaTenNhanVien.DataPropertyName = "HoVaTenNhanVien";
            HoVaTenNhanVien.HeaderText = "Tên sản phẩm";
            HoVaTenNhanVien.MinimumWidth = 6;
            HoVaTenNhanVien.Name = "HoVaTenNhanVien";
            HoVaTenNhanVien.ReadOnly = true;
            // 
            // GiaNhap
            // 
            GiaNhap.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            GiaNhap.DataPropertyName = "GiaNhap";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.ForeColor = Color.Blue;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            GiaNhap.DefaultCellStyle = dataGridViewCellStyle1;
            GiaNhap.HeaderText = "Giá nhập";
            GiaNhap.MinimumWidth = 6;
            GiaNhap.Name = "GiaNhap";
            GiaNhap.ReadOnly = true;
            GiaNhap.Width = 250;
            // 
            // SoLuong
            // 
            SoLuong.DataPropertyName = "SoLuong";
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.ForeColor = Color.Blue;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            SoLuong.DefaultCellStyle = dataGridViewCellStyle2;
            SoLuong.HeaderText = "Số lượng ";
            SoLuong.MinimumWidth = 6;
            SoLuong.Name = "SoLuong";
            SoLuong.ReadOnly = true;
            // 
            // ThanhTien
            // 
            ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.ForeColor = Color.Blue;
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            ThanhTien.DefaultCellStyle = dataGridViewCellStyle3;
            ThanhTien.HeaderText = "Thành tiền";
            ThanhTien.MinimumWidth = 6;
            ThanhTien.Name = "ThanhTien";
            ThanhTien.ReadOnly = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView);
            groupBox1.Controls.Add(toolStrip);
            groupBox1.Dock = DockStyle.Bottom;
            groupBox1.Location = new Point(0, 257);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(982, 323);
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
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 580);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 73);
            panel1.TabIndex = 14;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(cboNhaCungCao);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(cboNhanVien);
            groupBox3.Controls.Add(txtGhiChu);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label1);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.ForeColor = Color.Blue;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(982, 127);
            groupBox3.TabIndex = 15;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin phiếu nhập";
            // 
            // cboNhaCungCao
            // 
            cboNhaCungCao.FormattingEnabled = true;
            cboNhaCungCao.Items.AddRange(new object[] { "admin", "user" });
            cboNhaCungCao.Location = new Point(653, 27);
            cboNhaCungCao.Name = "cboNhaCungCao";
            cboNhaCungCao.Size = new Size(318, 28);
            cboNhaCungCao.TabIndex = 20;
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
            cboNhanVien.Items.AddRange(new object[] { "admin", "user" });
            cboNhanVien.Location = new Point(176, 27);
            cboNhanVien.Name = "cboNhanVien";
            cboNhanVien.Size = new Size(318, 28);
            cboNhanVien.TabIndex = 18;
            // 
            // txtGhiChu
            // 
            txtGhiChu.Location = new Point(176, 72);
            txtGhiChu.Name = "txtGhiChu";
            txtGhiChu.Size = new Size(795, 27);
            txtGhiChu.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(11, 75);
            label3.Name = "label3";
            label3.Size = new Size(159, 20);
            label3.TabIndex = 11;
            label3.Text = "Ghi chú phiếu nhập (*):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(72, 30);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 7;
            label1.Text = "Nhân viên (*):";
            // 
            // groupBox4
            // 
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
            groupBox4.Location = new Point(0, 127);
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
            btnXacNhanNhap.TabIndex = 5;
            btnXacNhanNhap.Text = "Xác nhận nhập...";
            btnXacNhanNhap.UseVisualStyleBackColor = true;
            // 
            // numSoLuong
            // 
            numSoLuong.Location = new Point(470, 61);
            numSoLuong.Name = "numSoLuong";
            numSoLuong.Size = new Size(141, 27);
            numSoLuong.TabIndex = 26;
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
            numGiaNhap.Name = "numGiaNhap";
            numGiaNhap.Size = new Size(142, 27);
            numGiaNhap.TabIndex = 24;
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
            cboSanPham.Items.AddRange(new object[] { "admin", "user" });
            cboSanPham.Location = new Point(12, 59);
            cboSanPham.Name = "cboSanPham";
            cboSanPham.Size = new Size(272, 28);
            cboSanPham.TabIndex = 22;
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
            // frmPhieuNhap_ChiTiet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 653);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(btnThoat);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmPhieuNhap_ChiTiet";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Phiếu nhập chi tiết";
            Load += frmPhieuNhap_ChiTiet_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            panel1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSoLuong).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGiaNhap).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button button1;
        private Button btnXoa;
        private Button btnHuy;
        private Button btnInPhieuNhap;
        private Button btnLapPhieuNhap;
        private Panel panel2;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn HoVaTenNhanVien;
        private DataGridViewTextBoxColumn GiaNhap;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn ThanhTien;
        private GroupBox groupBox1;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private Button btnThoat;
        private Panel panel1;
        private GroupBox groupBox3;
        private ComboBox cboNhaCungCao;
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
    }
}