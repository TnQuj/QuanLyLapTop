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
    public partial class frmNhaCungCap : Form
    {
        public frmNhaCungCap()
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
            txtTenNhaCungCap.Enabled = giaTri;
            txtDienThoai.Enabled = giaTri;
            txtDiaChi.Enabled = giaTri;
        }
        private void frmNhaCungCap_Load(object sender, EventArgs e)
        {
            BatTatChucNang(false);
            dataGridView.AutoGenerateColumns = false;
            var ncc = context.NhaCungCap.ToList();
            dataGridView.DataSource = ncc;

            txtTenNhaCungCap.DataBindings.Clear();
            txtTenNhaCungCap.DataBindings.Add("Text", ncc, "TenNhaCungCap", false, DataSourceUpdateMode.Never);

            txtDienThoai.DataBindings.Clear();
            txtDienThoai.DataBindings.Add("Text", ncc, "DienThoai", false, DataSourceUpdateMode.Never);

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", ncc, "DiaChi", false, DataSourceUpdateMode.Never);

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            BatTatChucNang(true);
            id = 0;
            txtTenNhaCungCap.Clear();
            txtTenNhaCungCap.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
                    var ncc = context.NhaCungCap.Find(id)!;
                    if (ncc != null)
                    {
                        context.NhaCungCap.Remove(ncc);
                        context.SaveChanges();
                        MessageBox.Show("Xóa thành công");
                        frmNhaCungCap_Load(sender, e);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(dataGridView.CurrentRow?.Cells[0].Value?.ToString());
            BatTatChucNang(true);
            txtTenNhaCungCap.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtTenNhaCungCap.Text))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp");txtTenNhaCungCap.Focus();return;
            }
            else if (string.IsNullOrEmpty(txtDienThoai.Text))
            {
                MessageBox.Show("Vui lòng nhập điện thoại"); txtDienThoai.Focus(); return;
            }
            else if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ"); txtDiaChi.Focus(); return;
            }
            else
            {
                try
                {
                    if (id == 0)
                    {
                        NhaCungCap ncc = new NhaCungCap()
                        {
                            TenNhaCungCap = txtTenNhaCungCap.Text,
                            DienThoai = txtDienThoai.Text,
                            DiaChi = txtDiaChi.Text
                        };
                        context.NhaCungCap.Add(ncc);
                        context.SaveChanges();
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                    {
                        var ncc = context.NhaCungCap.Find(id)!;
                        if (ncc != null)
                        {
                            ncc.TenNhaCungCap = txtTenNhaCungCap.Text;
                            ncc.DienThoai = txtDienThoai.Text;
                            ncc.DiaChi = txtDiaChi.Text;
                            context.NhaCungCap.Update(ncc);
                            context.SaveChanges();
                            MessageBox.Show("Sửa thành công");
                        }
                    }
                    frmNhaCungCap_Load(sender, e);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
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
            frmNhaCungCap_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {

        }

        private void txtTuKhoa_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnNhap_Click(object sender, EventArgs e)
        {

        }

        private void btnXuat_Click(object sender, EventArgs e)
        {

        }
    }
}
