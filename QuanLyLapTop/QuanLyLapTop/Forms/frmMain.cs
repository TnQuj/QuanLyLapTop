using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyLapTop.Forms
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        frmLoaiSanPham? loaiSanPham = null;
        frmHangSanXuat? hangSanXuat = null;
        frmSanPham? sanPham = null;
        frmPhieuNhap? phieuNhap = null;
        frmKhachHang? khachHang = null;
        frmNhanVien? nhanVien = null;
        frmNhaCungCap? nhaCungCap = null;
        frmHoaDon? hoaDon = null;
        string hoVaTenNhanVien = "";
        private void frmMain_Load(object sender, EventArgs e)
        {

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
    }
}
