namespace QuanLyLapTop.Forms
{
    partial class frmHangSanXuat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHangSanXuat));
            label1 = new Label();
            dataGridView = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            TenHangSanXuat = new DataGridViewTextBoxColumn();
            QuocGia = new DataGridViewTextBoxColumn();
            HinhAnh = new DataGridViewImageColumn();
            groupBox2 = new GroupBox();
            toolStrip = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            txtTuKhoa = new ToolStripTextBox();
            btnTimKiem = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            btnNhap = new ToolStripButton();
            btnXuat = new ToolStripButton();
            txtTenHangSanXuat = new TextBox();
            groupBox1 = new GroupBox();
            picHinhAnh = new PictureBox();
            cboQuocGia = new ComboBox();
            btnThoat = new Button();
            btnHuyBo = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            btnLuu = new Button();
            btnSua = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            groupBox2.SuspendLayout();
            toolStrip.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên hãng sản xuất (*):";
            // 
            // dataGridView
            // 
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { ID, TenHangSanXuat, QuocGia, HinhAnh });
            dataGridView.Dock = DockStyle.Fill;
            dataGridView.Location = new Point(2, 49);
            dataGridView.Margin = new Padding(2);
            dataGridView.MultiSelect = false;
            dataGridView.Name = "dataGridView";
            dataGridView.ReadOnly = true;
            dataGridView.RowHeadersVisible = false;
            dataGridView.RowHeadersWidth = 62;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.Size = new Size(404, 402);
            dataGridView.TabIndex = 1;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.MinimumWidth = 8;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // TenHangSanXuat
            // 
            TenHangSanXuat.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            TenHangSanXuat.DataPropertyName = "TenHangSanXuat";
            TenHangSanXuat.FillWeight = 273.7226F;
            TenHangSanXuat.HeaderText = "Tên hãng sản xuất";
            TenHangSanXuat.MinimumWidth = 8;
            TenHangSanXuat.Name = "TenHangSanXuat";
            TenHangSanXuat.ReadOnly = true;
            TenHangSanXuat.Width = 160;
            // 
            // QuocGia
            // 
            QuocGia.DataPropertyName = "QuocGia";
            QuocGia.FillWeight = 13.1387014F;
            QuocGia.HeaderText = "Quốc Gia";
            QuocGia.MinimumWidth = 6;
            QuocGia.Name = "QuocGia";
            QuocGia.ReadOnly = true;
            QuocGia.Resizable = DataGridViewTriState.True;
            QuocGia.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // HinhAnh
            // 
            HinhAnh.DataPropertyName = "HinhAnh";
            HinhAnh.FillWeight = 13.1387014F;
            HinhAnh.HeaderText = "Hình ảnh";
            HinhAnh.MinimumWidth = 6;
            HinhAnh.Name = "HinhAnh";
            HinhAnh.ReadOnly = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView);
            groupBox2.Controls.Add(toolStrip);
            groupBox2.Dock = DockStyle.Right;
            groupBox2.Location = new Point(374, 0);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(408, 453);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh sách hãng sản xuất";
            // 
            // toolStrip
            // 
            toolStrip.ImageScalingSize = new Size(24, 24);
            toolStrip.Items.AddRange(new ToolStripItem[] { toolStripLabel1, txtTuKhoa, btnTimKiem, toolStripSeparator1, btnNhap, btnXuat });
            toolStrip.Location = new Point(2, 22);
            toolStrip.Name = "toolStrip";
            toolStrip.Size = new Size(404, 27);
            toolStrip.TabIndex = 0;
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(73, 24);
            toolStripLabel1.Text = "Tìm kiếm:";
            // 
            // txtTuKhoa
            // 
            txtTuKhoa.BorderStyle = BorderStyle.FixedSingle;
            txtTuKhoa.Name = "txtTuKhoa";
            txtTuKhoa.Size = new Size(160, 27);
            // 
            // btnTimKiem
            // 
            btnTimKiem.ImageTransparentColor = Color.Magenta;
            btnTimKiem.Name = "btnTimKiem";
            btnTimKiem.Size = new Size(38, 24);
            btnTimKiem.Text = "Tìm";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // btnNhap
            // 
            btnNhap.ImageTransparentColor = Color.Magenta;
            btnNhap.Name = "btnNhap";
            btnNhap.Size = new Size(58, 24);
            btnNhap.Text = "Nhập...";
            // 
            // btnXuat
            // 
            btnXuat.ImageTransparentColor = Color.Magenta;
            btnXuat.Name = "btnXuat";
            btnXuat.Size = new Size(52, 24);
            btnXuat.Text = "Xuất...";
            // 
            // txtTenHangSanXuat
            // 
            txtTenHangSanXuat.Location = new Point(160, 34);
            txtTenHangSanXuat.Margin = new Padding(2);
            txtTenHangSanXuat.Name = "txtTenHangSanXuat";
            txtTenHangSanXuat.Size = new Size(189, 27);
            txtTenHangSanXuat.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(picHinhAnh);
            groupBox1.Controls.Add(cboQuocGia);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(btnHuyBo);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTenHangSanXuat);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(377, 453);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin hãng sản xuất";
            // 
            // picHinhAnh
            // 
            picHinhAnh.Enabled = false;
            picHinhAnh.Location = new Point(20, 128);
            picHinhAnh.Name = "picHinhAnh";
            picHinhAnh.Size = new Size(329, 146);
            picHinhAnh.TabIndex = 9;
            picHinhAnh.TabStop = false;
            picHinhAnh.Visible = false;
            // 
            // cboQuocGia
            // 
            cboQuocGia.FormattingEnabled = true;
            cboQuocGia.Location = new Point(159, 80);
            cboQuocGia.Name = "cboQuocGia";
            cboQuocGia.Size = new Size(190, 28);
            cboQuocGia.TabIndex = 1;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(20, 384);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(150, 40);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuyBo
            // 
            btnHuyBo.Location = new Point(207, 384);
            btnHuyBo.Name = "btnHuyBo";
            btnHuyBo.Size = new Size(150, 40);
            btnHuyBo.TabIndex = 6;
            btnHuyBo.Text = "Hủy Bỏ";
            btnHuyBo.UseVisualStyleBackColor = true;
            btnHuyBo.Click += btnHuyBo_Click;
            // 
            // btnXoa
            // 
            btnXoa.ForeColor = Color.Red;
            btnXoa.Location = new Point(207, 292);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(150, 40);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(20, 291);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(150, 40);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnLuu
            // 
            btnLuu.ForeColor = Color.Blue;
            btnLuu.Location = new Point(207, 338);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(150, 40);
            btnLuu.TabIndex = 5;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(20, 338);
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
            label2.Location = new Point(65, 88);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 8;
            label2.Text = "Quốc Gia(*):";
            // 
            // frmHangSanXuat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 453);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmHangSanXuat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hãng Sản Xuất";
            Load += frmHangSanXuat_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            toolStrip.ResumeLayout(false);
            toolStrip.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picHinhAnh).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private DataGridView dataGridView;
        private GroupBox groupBox2;
        private TextBox txtTenHangSanXuat;
        private GroupBox groupBox1;
        private Label label2;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn TenHangSanXuat;
        private DataGridViewTextBoxColumn QuocGia;
        private DataGridViewImageColumn HinhAnh;
        private Button btnSua;
        private Button btnThem;
        private Button btnLuu;
        private ComboBox cboQuocGia;
        private Button btnHuyBo;
        private Button btnXoa;
        private Button btnThoat;
        private ToolStrip toolStrip;
        private ToolStripLabel toolStripLabel1;
        private ToolStripTextBox txtTuKhoa;
        private ToolStripButton btnTimKiem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton btnNhap;
        private ToolStripButton btnXuat;
        private PictureBox picHinhAnh;
    }
}