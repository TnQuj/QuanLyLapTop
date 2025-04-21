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
    public partial class frmLoaiSanPham : Form
    {
        public frmLoaiSanPham()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id;
        public void BatTatChucNang(bool giaTri)
        {
            btnThem.Enabled = !giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnLuu.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            txtTenLoaiSanPham.Enabled = giaTri;
        }
        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            var lsp = context.LoaiSanPham.ToList();
            dataGridView.DataSource = lsp;

            txtTenLoaiSanPham.DataBindings.Clear();
            txtTenLoaiSanPham.DataBindings.Add("Text", lsp, "TenLoaiSanPham", false, DataSourceUpdateMode.Never);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            txtTenLoaiSanPham.Clear();
            txtTenLoaiSanPham.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham_Load(sender, e);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {

        }
    }
}
