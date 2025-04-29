using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.ChartDrawing;
using QuanLyLapTop.Data;
using BC = BCrypt.Net.BCrypt;
namespace QuanLyLapTop.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        frmLoaiSanPham? loaiSanPham = null;
        frmHangSanXuat? hangSanXuat = null;
        frmSanPham? sanPham = null;
        frmPhieuNhap? phieuNhap = null;
        frmKhachHang? khachHang = null;
        frmNhanVien? nhanVien = null;
        frmNhaCungCap? nhaCungCap = null;
        frmDangNhap? dangNhap = null;
        frmHoaDon? hoaDon = null;
        string hoVaTenNhanVien = "";
        private void frmMain_Load(object sender, EventArgs e)
        {
            ChuaPhanQuyen();
            DangNhap();
        }

        private void mnuHangSanXuat_Click(object sender, EventArgs e)
        {
            if (hangSanXuat == null || hangSanXuat.IsDisposed)
            {
                hangSanXuat = new frmHangSanXuat();
                hangSanXuat.MdiParent = this;
                hangSanXuat.Show();
            }
            else
                hangSanXuat.Activate();
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            if (sanPham == null || sanPham.IsDisposed)
            {
                sanPham = new frmSanPham();
                sanPham.MdiParent = this;
                sanPham.Show();
            }
            else
                sanPham.Activate();
        }

        private void mnuPhieuNhap_Click(object sender, EventArgs e)
        {
            if (phieuNhap == null || phieuNhap.IsDisposed)
            {
                phieuNhap = new frmPhieuNhap();
                phieuNhap.MdiParent = this;
                phieuNhap.Show();
            }
            else
                phieuNhap.Activate();
        }

        private void mnuNhaCungCap_Click(object sender, EventArgs e)
        {
            if (nhaCungCap == null || nhaCungCap.IsDisposed)
            {
                nhaCungCap = new frmNhaCungCap();
                nhaCungCap.MdiParent = this;
                nhaCungCap.Show();
            }
            else
                nhaCungCap.Activate();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            if (khachHang == null || khachHang.IsDisposed)
            {
                khachHang = new frmKhachHang();
                khachHang.MdiParent = this;
                khachHang.Show();
            }
            else
                khachHang.Activate();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            if (nhanVien == null || nhanVien.IsDisposed)
            {
                nhanVien = new frmNhanVien();
                nhanVien.MdiParent = this;
                nhanVien.Show();
            }
            else
                nhanVien.Activate();
        }

        public void DangNhap()
        {
        LamLai:
            if (dangNhap == null || dangNhap.IsDisposed)
            {
                dangNhap = new frmDangNhap();
                if (dangNhap.ShowDialog() == DialogResult.OK)
                {
                    string tenDangNhap = dangNhap.txtTenDangNhap.Text;
                    string matKhau = dangNhap.txtMatKhau.Text;
                    if (tenDangNhap.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning); dangNhap.txtTenDangNhap.Focus();
                        goto LamLai;
                    }
                    else if (matKhau.Trim() == "")
                    {
                        MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        dangNhap.txtMatKhau.Focus();
                        goto LamLai;
                    }
                    else
                    {
                        var nhanVien = context.NhanVien.Where(x => x.TenDangNhap == tenDangNhap).SingleOrDefault();
                        if (nhanVien == null)
                        {
                            MessageBox.Show("Tên đăng nhập không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            dangNhap.txtTenDangNhap.Focus();
                            goto LamLai;
                        }
                        else
                        {
                            if (BC.Verify(matKhau, nhanVien.MatKhau))
                            {
                                hoVaTenNhanVien = nhanVien.HoVaTen;
                                if (nhanVien.QuyenHan == "admin")
                                    QuyenQuanLy();

                                else if (nhanVien.QuyenHan == "user")
                                    QuyenNhanVien();
                                else
                                    ChuaPhanQuyen();
                            }
                            else
                            {
                                MessageBox.Show("Mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                dangNhap.txtMatKhau.Focus();
                                goto LamLai;
                            }
                        }
                        MessageBox.Show("Đăng nhập thành công: " + hoVaTenNhanVien ,"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        public void ChuaPhanQuyen()
        {
            // Sáng đăng nhập
            mnuDangNhap.Enabled = true;
            // Mờ tất cả
            mnuDangXuat.Enabled = false;
            mnuDoiMatKhau.Enabled = false;
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhaCungCap.Enabled = false;
            mnuKhachHang.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuHoaDon.Enabled = false;
            mnuPhieuNhap.Enabled = false;
            mnuThongKe_SanPham.Enabled = false;
            mnuThongKe_DoanhThu.Enabled = false;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Chưa đăng nhập.";
        }

        public void QuyenQuanLy()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng quản lý không được phép
            // Sáng đăng xuất và các chức năng quản lý được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuLoaiSanPham.Enabled = true;
            mnuHangSanXuat.Enabled = true;
            mnuSanPham.Enabled = true;
            mnuNhaCungCap.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuNhanVien.Enabled = true;
            mnuPhieuNhap.Enabled=true;
            mnuHoaDon.Enabled = true;
            mnuThongKe_SanPham.Enabled = true;
            mnuThongKe_DoanhThu.Enabled = true;// Hiển thị thông tin trên thanh trạng thái
            mnuThongKe_HoaDon.Enabled = true;
            lblTrangThai.Text = "Quản lý: " + hoVaTenNhanVien;
        }

        public void QuyenNhanVien()
        {
            // Mờ đăng nhập
            mnuDangNhap.Enabled = false;
            // Mờ các chức năng nhân viên không được phép
            mnuLoaiSanPham.Enabled = false;
            mnuHangSanXuat.Enabled = false;
            mnuSanPham.Enabled = false;
            mnuNhanVien.Enabled = false;
            mnuPhieuNhap.Enabled = false;
            mnuNhaCungCap.Enabled= false;
            // Sáng đăng xuất và các chức năng nhân viên được phép
            mnuDangXuat.Enabled = true;
            mnuDoiMatKhau.Enabled = true;
            mnuKhachHang.Enabled = true;
            mnuHoaDon.Enabled = true;
            mnuThongKe_SanPham.Enabled = true;
            mnuThongKe_DoanhThu.Enabled = true;
            mnuThongKe_HoaDon.Enabled= true;
            // Hiển thị thông tin trên thanh trạng thái
            lblTrangThai.Text = "Nhân viên: " + hoVaTenNhanVien;
        }

        private void mnuDangNhap_Click(object sender, EventArgs e)
        {
            DangNhap();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            foreach(Form child in MdiChildren)
            {
                child.Close();
            }
            frmDangNhap dangNhap = new frmDangNhap();
            this.Show();
            ChuaPhanQuyen();
        }
    }
}
