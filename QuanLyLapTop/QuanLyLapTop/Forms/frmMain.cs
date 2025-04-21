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
        //frmSanPham? sanPham = null;
        //frmKhachHang? khachHang = null;
        frmNhanVien? nhanVien = null;
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
    }
}
