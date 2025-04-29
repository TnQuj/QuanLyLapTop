using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyLapTop.Data;
namespace QuanLyLapTop.Forms
{
    public partial class frmSanPham_ChiTiet : Form
    {
        public frmSanPham_ChiTiet(int maSanPham = 0)
        {
            InitializeComponent();
            id = maSanPham;
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
            cboSanPham.DataBindings.Add("Text", spct, "TenSanPham", false, DataSourceUpdateMode.Never);

            txtCPU.DataBindings.Clear();
            txtCPU.DataBindings.Add("Text", spct, "CPU", false, DataSourceUpdateMode.Never);

            cboRAM.DataBindings.Clear();
            cboRAM.DataBindings.Add("Text", spct, "RAM", false, DataSourceUpdateMode.Never);

            cboTrongLuong.DataBindings.Clear();
            cboTrongLuong.DataBindings.Add("Text", spct, "TrongLuong", false, DataSourceUpdateMode.Never);

            cboHeDieuHanh.DataBindings.Clear();
            cboHeDieuHanh.DataBindings.Add("Text", spct, "HeDieuHanh", false, DataSourceUpdateMode.Never);

            txtGPU.DataBindings.Clear();
            txtGPU.DataBindings.Add("Text", spct, "GPU", false, DataSourceUpdateMode.Never);

            txtManHinh.DataBindings.Clear();
            txtManHinh.DataBindings.Add("Text", spct, "ManHinh", false, DataSourceUpdateMode.Never);

            txtOCung.DataBindings.Clear();
            txtOCung.DataBindings.Add("Text", spct, "OCung", false, DataSourceUpdateMode.Never);

            txtPin.DataBindings.Clear();
            txtPin.DataBindings.Add("Text", spct, "Pin", false, DataSourceUpdateMode.Never);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn quay lại trang chính không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                var mainForm = Application.OpenForms["frmMain"];
                if (mainForm != null)
                {
                    mainForm.Show();
                    mainForm.Activate();
                }
                else
                {
                    frmMain newMainForm = new frmMain();
                    newMainForm.Show();
                }
                this.Close(); // Close luôn form con
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            frmSanPham_ChiTiet_Load(sender, e);
        }

       
    }
}
