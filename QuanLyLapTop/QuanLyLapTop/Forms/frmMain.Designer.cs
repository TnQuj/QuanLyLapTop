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
            mnuHangSanXuat = new ToolStripMenuItem();
            mnuNhaCungCap = new ToolStripMenuItem();
            mnuBaoCao_ThongKe = new ToolStripMenuItem();
            thôngKêSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            thôngKêDoanhThuToolStripMenuItem = new ToolStripMenuItem();
            thôngKêHóaĐơnToolStripMenuItem = new ToolStripMenuItem();
            mnuTroGiup = new ToolStripMenuItem();
            thôngTinPhầnMềmToolStripMenuItem = new ToolStripMenuItem();
            hướngDẫnSửDụngToolStripMenuItem = new ToolStripMenuItem();
            staStp_LienKet = new StatusStrip();
            lblTrangThai = new ToolStripStatusLabel();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            mnuLaptop.SuspendLayout();
            staStp_LienKet.SuspendLayout();
            SuspendLayout();
            // 
            // mnuLaptop
            // 
            mnuLaptop.BackColor = Color.MediumSpringGreen;
            mnuLaptop.ImageScalingSize = new Size(20, 20);
            mnuLaptop.Items.AddRange(new ToolStripItem[] { mnuHeThong, mnuQuanLy, toolStripMenuItem2, mnuBaoCao_ThongKe, mnuTroGiup });
            mnuLaptop.Location = new Point(0, 0);
            mnuLaptop.Name = "mnuLaptop";
            mnuLaptop.Size = new Size(982, 28);
            mnuLaptop.TabIndex = 0;
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
            mnuDangNhap.Name = "mnuDangNhap";
            mnuDangNhap.ShortcutKeys = Keys.Control | Keys.A;
            mnuDangNhap.Size = new Size(217, 26);
            mnuDangNhap.Text = "Đăng &nhập";
            // 
            // mnuDangXuat
            // 
            mnuDangXuat.Name = "mnuDangXuat";
            mnuDangXuat.Size = new Size(217, 26);
            mnuDangXuat.Text = "Đăng &xuất";
            // 
            // mnuDoiMatKhau
            // 
            mnuDoiMatKhau.Name = "mnuDoiMatKhau";
            mnuDoiMatKhau.Size = new Size(217, 26);
            mnuDoiMatKhau.Text = "Đổi &mật khẩu";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(214, 6);
            // 
            // mnuThoat
            // 
            mnuThoat.Name = "mnuThoat";
            mnuThoat.ShortcutKeys = Keys.Alt | Keys.F4;
            mnuThoat.Size = new Size(217, 26);
            mnuThoat.Text = "Thoát ";
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
            mnuPhieuNhap.Name = "mnuPhieuNhap";
            mnuPhieuNhap.ShortcutKeys = Keys.Control | Keys.N;
            mnuPhieuNhap.Size = new Size(227, 26);
            mnuPhieuNhap.Text = "&Nhập hàng...";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(224, 6);
            // 
            // mnuKhachHang
            // 
            mnuKhachHang.Name = "mnuKhachHang";
            mnuKhachHang.Size = new Size(227, 26);
            mnuKhachHang.Text = "&Khách hàng...";
            // 
            // mnuNhanVien
            // 
            mnuNhanVien.Name = "mnuNhanVien";
            mnuNhanVien.Size = new Size(227, 26);
            mnuNhanVien.Text = "&Nhân viên...";
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
            mnuHoaDon.Name = "mnuHoaDon";
            mnuHoaDon.Size = new Size(227, 26);
            mnuHoaDon.Text = "&Hóa đơn bán hàng...";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.DropDownItems.AddRange(new ToolStripItem[] { mnuSanPham, mnuHangSanXuat, mnuNhaCungCap });
            toolStripMenuItem2.Image = Properties.Resources.san_pham;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(109, 24);
            toolStripMenuItem2.Text = "&Sản phẩm";
            // 
            // mnuSanPham
            // 
            mnuSanPham.Name = "mnuSanPham";
            mnuSanPham.Size = new Size(237, 26);
            mnuSanPham.Text = "&Danh sách sản phẩm...";
            // 
            // mnuHangSanXuat
            // 
            mnuHangSanXuat.Name = "mnuHangSanXuat";
            mnuHangSanXuat.Size = new Size(237, 26);
            mnuHangSanXuat.Text = "&Hãng sản xuất...";
            mnuHangSanXuat.Click += mnuHangSanXuat_Click;
            // 
            // mnuNhaCungCap
            // 
            mnuNhaCungCap.Name = "mnuNhaCungCap";
            mnuNhaCungCap.Size = new Size(237, 26);
            mnuNhaCungCap.Text = "&Nhà cung cấp...";
            // 
            // mnuBaoCao_ThongKe
            // 
            mnuBaoCao_ThongKe.DropDownItems.AddRange(new ToolStripItem[] { thôngKêSảnPhẩmToolStripMenuItem, thôngKêDoanhThuToolStripMenuItem, thôngKêHóaĐơnToolStripMenuItem });
            mnuBaoCao_ThongKe.Image = (Image)resources.GetObject("mnuBaoCao_ThongKe.Image");
            mnuBaoCao_ThongKe.Name = "mnuBaoCao_ThongKe";
            mnuBaoCao_ThongKe.Size = new Size(172, 24);
            mnuBaoCao_ThongKe.Text = "&Báo cáo - Thống kê";
            // 
            // thôngKêSảnPhẩmToolStripMenuItem
            // 
            thôngKêSảnPhẩmToolStripMenuItem.Name = "thôngKêSảnPhẩmToolStripMenuItem";
            thôngKêSảnPhẩmToolStripMenuItem.Size = new Size(224, 26);
            thôngKêSảnPhẩmToolStripMenuItem.Text = "Thông kê &sản phẩm";
            // 
            // thôngKêDoanhThuToolStripMenuItem
            // 
            thôngKêDoanhThuToolStripMenuItem.Name = "thôngKêDoanhThuToolStripMenuItem";
            thôngKêDoanhThuToolStripMenuItem.Size = new Size(224, 26);
            thôngKêDoanhThuToolStripMenuItem.Text = "Thông kê &doanh thu";
            // 
            // thôngKêHóaĐơnToolStripMenuItem
            // 
            thôngKêHóaĐơnToolStripMenuItem.Name = "thôngKêHóaĐơnToolStripMenuItem";
            thôngKêHóaĐơnToolStripMenuItem.Size = new Size(224, 26);
            thôngKêHóaĐơnToolStripMenuItem.Text = "Thông kê &hóa đơn";
            // 
            // mnuTroGiup
            // 
            mnuTroGiup.DropDownItems.AddRange(new ToolStripItem[] { thôngTinPhầnMềmToolStripMenuItem, hướngDẫnSửDụngToolStripMenuItem });
            mnuTroGiup.Image = Properties.Resources.technical_support;
            mnuTroGiup.Name = "mnuTroGiup";
            mnuTroGiup.Size = new Size(99, 24);
            mnuTroGiup.Text = "&Trợ Giúp";
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            thôngTinPhầnMềmToolStripMenuItem.Size = new Size(298, 26);
            thôngTinPhầnMềmToolStripMenuItem.Text = "&Thông tin phần mềm...";
            // 
            // hướngDẫnSửDụngToolStripMenuItem
            // 
            hướngDẫnSửDụngToolStripMenuItem.Name = "hướngDẫnSửDụngToolStripMenuItem";
            hướngDẫnSửDụngToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.F11;
            hướngDẫnSửDụngToolStripMenuItem.Size = new Size(298, 26);
            hướngDẫnSửDụngToolStripMenuItem.Text = "&Hướng dẫn sử dụng...";
            // 
            // staStp_LienKet
            // 
            staStp_LienKet.BackColor = Color.MediumSpringGreen;
            staStp_LienKet.ImageScalingSize = new Size(20, 20);
            staStp_LienKet.Items.AddRange(new ToolStripItem[] { lblTrangThai, toolStripStatusLabel1, toolStripStatusLabel2 });
            staStp_LienKet.Location = new Point(0, 727);
            staStp_LienKet.Name = "staStp_LienKet";
            staStp_LienKet.Size = new Size(982, 26);
            staStp_LienKet.TabIndex = 1;
            staStp_LienKet.Text = "statusStrip1";
            // 
            // lblTrangThai
            // 
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(121, 20);
            lblTrangThai.Text = "Chưa đăng nhập.";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(651, 20);
            toolStripStatusLabel1.Spring = true;
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.IsLink = true;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(156, 20);
            toolStripStatusLabel2.Text = "© Khoa CNTT - ĐHAG";
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(982, 753);
            Controls.Add(staStp_LienKet);
            Controls.Add(mnuLaptop);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = mnuLaptop;
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LaptopVie";
            Load += frmMain_Load;
            mnuLaptop.ResumeLayout(false);
            mnuLaptop.PerformLayout();
            staStp_LienKet.ResumeLayout(false);
            staStp_LienKet.PerformLayout();
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
        private ToolStripMenuItem thôngKêSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem thôngKêDoanhThuToolStripMenuItem;
        private ToolStripMenuItem thôngKêHóaĐơnToolStripMenuItem;
        private ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
        private ToolStripMenuItem hướngDẫnSửDụngToolStripMenuItem;
        private StatusStrip staStp_LienKet;
        private ToolStripStatusLabel lblTrangThai;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
    }
}