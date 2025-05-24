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
using QuanLyLapTop.Reports;
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
                this.Close();
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
                    TenNhaCungCap = p.NhaCungCap.TenNhaCungCap,
                    p.NhanVienID,
                    HoVaTenNhanVien = p.NhanVien.HoVaTen,
                    p.NgayLap,
                    p.GhiChuPhieuNhap,
                    TongTienNhapHang = p.PhieuNhap_ChiTiet.Sum(r => (r.SoLuongNhap) * r.DonGiaNhap),
                }).ToList();
                dataGridView.DataSource = phieuNhap;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            BatTatChucNang();
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmPhieuNhap_ChiTiet chitiet = new frmPhieuNhap_ChiTiet(id))
                {
                    this.Close();
                    chitiet.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu nhập này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    PhieuNhap phieuNhap = context.PhieuNhap.Find(id)!;
                    if (phieuNhap != null)
                    {
                        //xóa phiếu nhập chi tiết 
                        //PhieuNhap_ChiTiet chitiet = context.PhieuNhap_ChiTiet.Where(x => x.PhieuNhapID == id).SingleOrDefault()!;
                        //context.PhieuNhap_ChiTiet.Remove(chitiet);

                        //xóa phiếu nhập
                        context.PhieuNhap.Remove(phieuNhap);
                        context.SaveChanges();

                        MessageBox.Show("Xóa phiếu nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    frmPhieuNhap_Load(sender, e);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
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
        private void btnInPhieuNhap_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow != null)
            {
                id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                using (frmInPhieuNhap inPhieuNhap = new frmInPhieuNhap(id))
                {
                    inPhieuNhap.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập để in", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var phieuNhap = context.PhieuNhap.Select(p => new
            {
                p.ID,
                p.NhaCungCapID,
                TenNhaCungCap = p.NhaCungCap.TenNhaCungCap,
                p.NhanVienID,
                HoVaTenNhanVien = p.NhanVien.HoVaTen,
                p.NgayLap,
                p.GhiChuPhieuNhap,
                TongTienNhapHang = p.PhieuNhap_ChiTiet.Sum(r => (r.SoLuongNhap) * r.DonGiaNhap),
            }).Where(p => p.HoVaTenNhanVien.Contains(txtTuKhoa.Text) || p.TenNhaCungCap.Contains(txtTuKhoa.Text) || p.NgayLap.ToString().Contains(txtTuKhoa.Text) || p.GhiChuPhieuNhap!.Contains(txtTuKhoa.Text)).ToList();
            dataGridView.DataSource = phieuNhap;
        }
        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnTimKiem_Click(sender, e);
            }
        }
    }
}
