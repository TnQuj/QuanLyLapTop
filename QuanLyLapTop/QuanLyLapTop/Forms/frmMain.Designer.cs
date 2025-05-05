namespace QuanLyLapTop.Forms
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            mnuLaptop = new MenuStrip();
            mnuHeThong = new ToolStripMenuItem();
            mnuDangNhap = new ToolStripMenuItem();
            mnuDangXuat = new ToolStripMenuItem();
            mnuDoiMatKhau = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            mnuThoat = new ToolStripMenuItem();
            mnuQuanLy = new ToolStripMenuItem();
            mnuPhieuNhap = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            mnuKhachHang = new ToolStripMenuItem();
            mnuNhanVien = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripSeparator4 = new ToolStripSeparator();
            mnuHoaDon = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            mnuSanPham = new ToolStripMenuItem();
            toolStripSeparator5 = new ToolStripSeparator();
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuNhaCungCap = new ToolStripMenuItem();
            mnuLoaiSanPham = new ToolStripMenuItem();
            mnuBaoCao_ThongKe = new ToolStripMenuItem();
            mnuThongKe_SanPham = new ToolStripMenuItem();
            mnuThongKe_DoanhThu = new ToolStripMenuItem();
            mnuThongKe_HoaDon = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            mnuThongTin_PhanMem = new ToolStripMenuItem();
            mnuHuongDan = new ToolStripMenuItem();
            staStp_LienKet = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            pictureBox1 = new PictureBox();
            mnuLaptop.SuspendLayout();
            staStp_LienKet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // mnuLaptop
            // 
            mnuLaptop.BackColor = Color.MediumSpringGreen;
            mnuLaptop.ImageScalingSize = new Size(20, 20);
            mnuLaptop.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, toolStripMenuItem2, mnuBaoCao_ThongKe, mnuTroGiup });
            mnuLaptop.Location = new Point(0, 0);
            mnuLaptop.Name = "mnuLaptop";
            mnuLaptop.Padding = new Padding(0, 10, 0, 10);
            mnuLaptop.Size = new Size(1482, 44);
            mnuLaptop.TabIndex = 1;
            mnuLaptop.Text = "menuStrip1";
            // 
            // mnuHeThong
            // 
            mnuHeThong.DropDownItems.AddRange(new ToolStripItem[] { mnuDangNhap, mnuDangXuat, mnuDoiMatKhau, toolStripSeparator1, mnuThoat });
            mnuHeThong.Image = Properties.Resources.software;
            mnuHeThong.Name = "mnuHeThong";
            mnuHeThong.Size = new Size(105, 24);
            mnuHeThong.Text = "&Hệ thống";
            // 
            // mnuDangNhap
            // 
            mnuDangNhap.Image = Properties.Resources.dang_nhap;
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.ShortcutKeys = Keys.Control | Keys.A;
            mnuDangNhap.Size = new Size(217, 26);
            mnuDangNhap.Text = "Đăng &nhập";
            mnuDangNhap.Click += mnuDangNhap_Click;
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Image = Properties.Resources.dang_xuat;
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(217, 26);
            mnuDangXuat.Text = "Đăng &xuất";
            mnuDangXuat.Click += mnuDangXuat_Click;
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Image = Properties.Resources.doi_mat_khau;
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(217, 26);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu";
            mnuDoiMatKhau.Click += mnuDoiMatKhau_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(214, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Image = Properties.Resources.thoat;
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(217, 26);
            mnuThoat.Text = "Thoát ";
            mnuThoat.Click += mnuThoat_Click;
            // 
            // mnuQuanLy
            // 
            mnuQuanLy.DropDownItems.AddRange(new ToolStripItem[] { mnuPhieuNhap, toolStripSeparator2, mnuKhachHang, mnuNhanVien, toolStripSeparator3, toolStripSeparator4, mnuHoaDon });
            mnuQuanLy.Image = Properties.Resources.data_management;
            mnuQuanLy.Name = "mnuQuanLy";
            mnuQuanLy.Size = new Size(93, 24);
            mnuQuanLy.Text = "&Quản lý";
            // 
            // mnuPhieuNhap
            // 
            mnuPhieuNhap.Image = Properties.Resources.conveyor;
            mnuPhieuNhap.Name = "mnuPhieuNhap";
            mnuPhieuNhap.ShortcutKeys = Keys.Control | Keys.N;
            mnuPhieuNhap.Size = new Size(227, 26);
            mnuPhieuNhap.Text = "&Nhập hàng...";
            mnuPhieuNhap.Click += mnuPhieuNhap_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(224, 6);
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Image = Properties.Resources.khach_hang;
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(227, 26);
            mnuKhachHang.Text = "&Khách hàng...";
            mnuKhachHang.Click += mnuKhachHang_Click;
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Image = Properties.Resources.nhan_vien;
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(227, 26);
            mnuNhanVien.Text = "&Nhân viên...";
            mnuNhanVien.Click += mnuNhanVien_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(224, 6);
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(224, 6);
            // 
            // mnuHoaDon
            // 
            mnuHoaDon.Image = Properties.Resources.hoa_don;
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(227, 26);
            mnuHoaDon.Text = "&Hóa đơn bán hàng...";
            mnuHoaDon.Click += mnuHoaDon_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { mnuSanPham, toolStripSeparator5, mnuHangSanXuat, mnuNhaCungCap, mnuLoaiSanPham });
            toolStripMenuItem2.Image = Properties.Resources.san_pham;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(109, 24);
            toolStripMenuItem2.Text = "&Sản phẩm";
            // 
            // mnuSanPham
            // 
            mnuSanPham.Image = Properties.Resources.box_add;
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(197, 26);
            mnuSanPham.Text = "&Kho sản phẩm...";
            mnuSanPham.Click += mnuSanPham_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new Size(194, 6);
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Image = Properties.Resources.hang_san_xuat;
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(197, 26);
            mnuHangSanXuat.Text = "&Hãng sản xuất...";
            mnuHangSanXuat.Click += mnuHangSanXuat_Click;
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.Image = Properties.Resources.truck_red;
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(197, 26);
            mnuNhaCungCap.Text = "&Nhà cung cấp...";
            mnuNhaCungCap.Click += mnuNhaCungCap_Click;
            // 
            // mnuLoaiSanPham
            // 
            mnuLoaiSanPham.Image = Properties.Resources.product2;
            mnuLoaiSanPham.Name = "mnuLoaiSanPham";
            mnuLoaiSanPham.Size = new Size(197, 26);
            mnuLoaiSanPham.Text = "&Loại sản phẩm...";
            mnuLoaiSanPham.Click += mnuLoaiSanPham_Click;
            // 
            // mnuBaoCao_ThongKe
            // 
            mnuBaoCao_ThongKe.DropDownItems.AddRange(new ToolStripItem[] { mnuThongKe_SanPham, mnuThongKe_DoanhThu, mnuThongKe_HoaDon });
            mnuBaoCao_ThongKe.Image = (Image)resources.GetObject("mnuBaoCao_ThongKe.Image");
            mnuBaoCao_ThongKe.Name = "mnuBaoCao_ThongKe";
            mnuBaoCao_ThongKe.Size = new Size(172, 24);
            mnuBaoCao_ThongKe.Text = "&Báo cáo - Thống kê";
            // 
            // mnuThongKe_SanPham
            // 
            mnuThongKe_SanPham.Image = Properties.Resources.thong_ke_san_pham;
            mnuThongKe_SanPham.Name = "mnuThongKe_SanPham";
            mnuThongKe_SanPham.Size = new Size(224, 26);
            mnuThongKe_SanPham.Text = "Thông kê &sản phẩm";
            mnuThongKe_SanPham.Click += mnuThongKe_SanPham_Click;
            // 
            // mnuThongKe_DoanhThu
            // 
            mnuThongKe_DoanhThu.Image = Properties.Resources.thong_ke_doanh_thu;
            mnuThongKe_DoanhThu.Name = "mnuThongKe_DoanhThu";
            mnuThongKe_DoanhThu.Size = new Size(224, 26);
            mnuThongKe_DoanhThu.Text = "Thông kê &doanh thu";
            // 
            // mnuThongKe_HoaDon
            // 
            mnuThongKe_HoaDon.Image = Properties.Resources.hoa_don1;
            mnuThongKe_HoaDon.Name = "mnuThongKe_HoaDon";
            mnuThongKe_HoaDon.Size = new Size(224, 26);
            mnuThongKe_HoaDon.Text = "Thông kê &hóa đơn";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { mnuThongTin_PhanMem, mnuHuongDan });
            mnuTroGiup.Image = Properties.Resources.technical_support;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(99, 24);
            mnuTroGiup.Text = "&Trợ Giúp";
            // 
            // mnuThongTin_PhanMem
            // 
            mnuThongTin_PhanMem.Image = Properties.Resources.thong_tin_phan_mem;
            mnuThongTin_PhanMem.Name = "mnuThongTin_PhanMem";
            mnuThongTin_PhanMem.Size = new Size(298, 26);
            mnuThongTin_PhanMem.Text = "&Thông tin phần mềm...";
            // 
            // mnuHuongDan
            // 
            mnuHuongDan.Image = Properties.Resources.huong_dan_su_dung;
            mnuHuongDan.Name = "mnuHuongDan";
            mnuHuongDan.ShortcutKeys = Keys.Control | Keys.F11;
            mnuHuongDan.Size = new Size(298, 26);
            mnuHuongDan.Text = "&Hướng dẫn sử dụng...";
            // 
            // staStp_LienKet
            // 
            staStp_LienKet.BackColor = Color.MediumSpringGreen;
            staStp_LienKet.Font = new Font("Times New Roman", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            staStp_LienKet.ImageScalingSize = new Size(20, 20);
            staStp_LienKet.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, toolStripStatusLabel2 });
            staStp_LienKet.Location = new Point(0, 928);
            staStp_LienKet.Name = "staStp_LienKet";
            staStp_LienKet.Size = new Size(1482, 25);
            staStp_LienKet.TabIndex = 1;
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(119, 19);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(1180, 19);
            toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.IsLink = true;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(168, 19);
            toolStripStatusLabel2.Text = "© Khoa CNTT - ĐHAG";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.header;
            pictureBox1.Location = new Point(0, 44);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1482, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1482, 953);
            Controls.Add(pictureBox1);
            Controls.Add(staStp_LienKet);
            Controls.Add(mnuLaptop);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mnuLaptop;
            MaximizeBox = false;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaptopVie";
            WindowState = FormWindowState.Maximized;
            Load += frmMain_Load;
            mnuLaptop.ResumeLayout(false);
            mnuLaptop.PerformLayout();
            staStp_LienKet.ResumeLayout(false);
            staStp_LienKet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuLaptop;
        private ToolStripMenuItem mnuHeThong;
        private ToolStripMenuItem mnuDangNhap;
        private ToolStripMenuItem mnuDangXuat;
        private ToolStripMenuItem mnuDoiMatKhau;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem mnuThoat;
        private ToolStripMenuItem mnuQuanLy;
        private ToolStripMenuItem mnuBaoCao_ThongKe;
        private ToolStripMenuItem mnuTroGiup;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem mnuKhachHang;
        private ToolStripMenuItem mnuNhanVien;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem mnuPhieuNhap;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem mnuHoaDon;
        private ToolStripMenuItem mnuSanPham;
        private ToolStripMenuItem mnuHangSanXuat;
        private ToolStripMenuItem mnuNhaCungCap;
        private ToolStripMenuItem mnuThongKe_SanPham;
        private ToolStripMenuItem mnuThongKe_DoanhThu;
        private ToolStripMenuItem mnuThongKe_HoaDon;
        private ToolStripMenuItem mnuThongTin_PhanMem;
        private ToolStripMenuItem mnuHuongDan;
        private StatusStrip staStp_LienKet;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private PictureBox pictureBox1;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripMenuItem mnuLoaiSanPham;
    }
}