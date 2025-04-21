namespace QuanLyLapTop.Forms
{
    partial class frmLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiSanPham));
            btnXuat = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnTimKiem = new ToolStripButton();
            txtTuKhoa = new ToolStripTextBox();
            toolStripLabel1 = new ToolStripLabel();
            toolStrip = new ToolStrip();
            btnNhap = new ToolStripButton();
            dataGridView = new DataGridView();
            ID1 = new DataGridViewTextBoxColumn();
            TenLoaiSanPham = new DataGridViewTextBoxColumn();
            groupBox2 = new GroupBox();
            txtTenLoaiSanPham = new TextBox();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            btnThoat = new Button();
            btnLuu = new Button();
            btnHuyBo = new Button();
            btnSua = new Button();
            btnThem = new Button();
            btnXoa = new Button();
            toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnXuat
            // 
            btnXuat.Image = Properties.Resources.export2;
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(76, 28);
            btnXuat.Text = "Xuất...";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 31);
            // 
            // btnTimKiem
            // 
            btnTimKiem.Image = Properties.Resources.search;
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(62, 28);
            btnTimKiem.Text = "Tìm";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(160, 31);
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
            toolStrip.Size = new Size(486, 31);
            toolStrip.TabIndex = 0;
            // 
            // btnNhap
            // 
            btnNhap.Image = Properties.Resources.import2;
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(82, 28);
            btnNhap.Text = "Nhập...";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID1, TenLoaiSanPham });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(2, 53);
            dataGridView.Margin = new Padding(2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(486, 298);
            dataGridView.TabIndex = 1;
            // 
            // ID1
            // 
            ID1.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID1.DataPropertyName = "ID";
            ID1.HeaderText = "ID";
            ID1.MinimumWidth = 6;
            ID1.Name = "ID1";
            ID1.ReadOnly = true;
            ID1.Width = 50;
            // 
            // TenLoaiSanPham
            // 
            TenLoaiSanPham.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TenLoaiSanPham.DataPropertyName = "TenLoaiSanPham";
            TenLoaiSanPham.HeaderText = "Tên loại sản phẩm";
            TenLoaiSanPham.MinimumWidth = 8;
            TenLoaiSanPham.Name = "TenLoaiSanPham";
            TenLoaiSanPham.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Location = new Point(252, 0);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(490, 353);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách loại sản phẩm";
            // 
            // txtTenLoaiSanPham
            // 
            txtTenLoaiSanPham.Location = new Point(21, 65);
            txtTenLoaiSanPham.Margin = new Padding(2);
            txtTenLoaiSanPham.Name = "txtTenLoaiSanPham";
            txtTenLoaiSanPham.Size = new Size(214, 27);
            txtTenLoaiSanPham.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 43);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên loại sản phẩm (*):";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(groupBox3);
            groupBox1.Controls.Add(txtTenLoaiSanPham);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(248, 353);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin loại sản phẩm";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThoat);
            groupBox3.Controls.Add(btnLuu);
            groupBox3.Controls.Add(btnHuyBo);
            groupBox3.Controls.Add(btnSua);
            groupBox3.Controls.Add(btnThem);
            groupBox3.Controls.Add(btnXoa);
            groupBox3.Location = new Point(9, 128);
            groupBox3.Margin = new Padding(2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(2);
            groupBox3.Size = new Size(226, 199);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Công cụ";
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(112, 144);
            btnThoat.Margin = new Padding(2);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(100, 40);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(112, 84);
            btnLuu.Margin = new Padding(2);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(100, 40);
            btnLuu.TabIndex = 3;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(12, 144);
            btnHuyBo.Margin = new Padding(2);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(100, 40);
            btnHuyBo.TabIndex = 4;
            btnHuyBo.Text = "Hủy bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(112, 25);
            btnSua.Margin = new Padding(2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(12, 25);
            btnThem.Margin = new Padding(2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 40);
            btnThem.TabIndex = 0;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(12, 84);
            btnXoa.Margin = new Padding(2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // frmLoaiSanPham
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(742, 353);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmLoaiSanPham";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Loại Sản Phẩm";
            Load += frmLoaiSanPham_Load;
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ToolStripButton btnXuat;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnTimKiem;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripLabel toolStripLabel1;
        private ToolStrip toolStrip;
        private ToolStripButton btnNhap;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private TextBox txtTenLoaiSanPham;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Button btnLuu;
        private Button btnThem;
        private Button btnSua;
        private Button btnThoat;
        private Button btnXoa;
        private Button btnHuyBo;
        private DataGridViewTextBoxColumn ID1;
        private DataGridViewTextBoxColumn TenLoaiSanPham;
    }
}