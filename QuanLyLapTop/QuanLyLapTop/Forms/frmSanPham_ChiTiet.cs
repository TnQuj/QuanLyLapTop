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
    public partial class frmSanPham_ChiTiet : Form
    {
        public frmSanPham_ChiTiet()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id;

        public void BatTatChucNang(bool giaTri)
        {
            btnLuuSanPham.Enabled = giaTri;
            btnHuyBo.Enabled = giaTri;
            btnXoa.Enabled = !giaTri;
            btnSua.Enabled = !giaTri;
            btnXemChiTiet.Enabled = !giaTri;
            //txtTenSanPham.Enabled = giaTri;
            //txtCPU.Enabled = giaTri;
            //cboRAM.Enabled = giaTri;
            //cboTrongLuong.Enabled = giaTri;
            //cboHeDieuHanh.Enabled = giaTri;
            //txtGPU.Enabled = giaTri;
            //txtManHinh.Enabled = giaTri;
            //txtOCung.Enabled = giaTri;
            //txtPin.Enabled = giaTri;
        }

        public void getSanPham()
        {
            var sanPham = context.SanPham.ToList();
            cboSanPham.DataSource = sanPham;
            cboSanPham.DisplayMember = "TenSanPham";
            cboSanPham.ValueMember = "ID";
        }
        private void frmSanPham_ChiTiet_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            var spct = context.SanPham_ChiTiet
                .Select(x => new
                {
                    x.ID,
                    x.SanPhamID,
                    x.SanPham!.TenSanPham,
                    x.CPU,
                    x.RAM,
                    x.TrongLuong,
                    x.HeDieuHanh,
                    x.GPU,
                    x.ManHinh,
                    x.OCung,
                    x.Pin
                })
                .ToList();
            dataGridView.DataSource = spct;

            cboSanPham.DataBindings.Clear();
            cboSanPham.DataBindings.Add("SelectedValue", spct, "SanPhamID", false, DataSourceUpdateMode.Never);

            txtCPU.DataBindings.Clear();
            txtCPU.DataBindings.Add("Text", spct, "CPU", false, DataSourceUpdateMode.Never);

            cboRAM.DataBindings.Clear();
            cboRAM.DataBindings.Add("SelectedValue", spct, "RAM", false, DataSourceUpdateMode.Never);

            cboTrongLuong.DataBindings.Clear();
            cboTrongLuong.DataBindings.Add("SelectedValue", spct, "TrongLuong", false, DataSourceUpdateMode.Never);

            cboHeDieuHanh.DataBindings.Clear();
            cboHeDieuHanh.DataBindings.Add("SelectedValue", spct, "HeDieuHanh", false, DataSourceUpdateMode.Never);

            txtGPU.DataBindings.Clear();
            txtGPU.DataBindings.Add("Text", spct, "GPU", false, DataSourceUpdateMode.Never);

            txtManHinh.DataBindings.Clear();
            txtManHinh.DataBindings.Add("Text", spct, "ManHinh", false, DataSourceUpdateMode.Never);

            txtOCung.DataBindings.Clear();
            txtOCung.DataBindings.Add("Text", spct, "OCung", false, DataSourceUpdateMode.Never);

            txtPin.DataBindings.Clear();
            txtPin.DataBindings.Add("Text", spct, "Pin", false, DataSourceUpdateMode.Never);




        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
