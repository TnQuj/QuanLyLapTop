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
    public partial class frmPhieuNhap : Form
    {
        public frmPhieuNhap()
        {
            InitializeComponent();
        }
        QLBHDbContext context = new QLBHDbContext();
        int id;

        public void BatTatChucNang()
        {
            btnInPhieuNhap.Enabled = dataGridView.Rows.Count > 0;
            btnSua.Enabled = dataGridView.Rows.Count > 0;
            btnXoa.Enabled = dataGridView.Rows.Count > 0;
        }

        private void btnLapPhieuNhap_Click(object sender, EventArgs e)
        {
            using (frmPhieuNhap_ChiTiet chitiet = new frmPhieuNhap_ChiTiet())
            {
                chitiet.ShowDialog();
            }
        }

        private void frmPhieuNhap_Load(object sender, EventArgs e)
        {
            dataGridView.AutoGenerateColumns = false;

            try
            {
                var phieuNhap = context.PhieuNhap.Select(p => new
                {
                    p.ID,
                    p.NhaCungCapID, 
                    p.NhaCungCap.TenNhaCungCap,
                    p.NhanVienID,
                    p.NhanVien.HoVaTen,
                    p.NgayLap,
                    p.GhiChuPhieuNhap,
                    TongTienPhieuNhap = p.PhieuNhapChiTiet.Sum(r => (r.SoLuongNhap) * r.DonGiaNhap),
                }).ToList();
                dataGridView.DataSource = phieuNhap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            finally
            {
                BatTatChucNang();
            }
        }
    }
}
