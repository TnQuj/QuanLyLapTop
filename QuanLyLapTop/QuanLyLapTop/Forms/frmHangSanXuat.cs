using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyLapTop.Data;
namespace QuanLyLapTop.Forms
{
    public partial class frmHangSanXuat : Form
    {
        public frmHangSanXuat()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id;

        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = giaTri;
            btnXoa.Enabled = giaTri;
            btnSua.Enabled = giaTri;
            btnLuu.Enabled = !giaTri;
            btnHuyBo.Enabled = !giaTri;
            txtTenHangSanXuat.Enabled = !giaTri;
            cboQuocGia.Enabled = !giaTri;
        }
        private void frmHangSanXuat_Load(object sender, EventArgs e)
        {
            BatTatChucNang(true);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmHangSanXuat_Load(sender, e);
        }
    }
}
