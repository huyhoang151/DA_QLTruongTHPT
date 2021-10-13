using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI
{
    public partial class frmQLGiaoVien : Form
    {
        GiaoVien_BLL gv = new GiaoVien_BLL();
        LoaiNguoiDung_BLL lnd = new LoaiNguoiDung_BLL();
        MonHoc_BLL mh = new MonHoc_BLL();
        public frmQLGiaoVien()
        {
            InitializeComponent();
        }

        private void frmQLGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDGVGiaoVien();
            LoadCBChucVu();
            LoadCBChuyenMon();
        }

        private void LoadDGVGiaoVien()
        {
            dgvGiaoVien.DataSource = gv.getData();
        }

        private void LoadCBChucVu()
        {
            cbChucVu.DataSource = lnd.getData();
            cbChucVu.DisplayMember = lnd.getData().Columns[1].ToString();
            cbChucVu.ValueMember = lnd.getData().Columns[0].ToString();
        }

        private void LoadCBChuyenMon()
        {
            cbChuyenMon.DataSource = mh.getData();
            cbChuyenMon.DisplayMember = mh.getData().Columns[1].ToString();
            cbChuyenMon.ValueMember = mh.getData().Columns[0].ToString();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "" || cbTimKiem.SelectedItem.ToString() != "")
            {
                try
                {
                    if (cbTimKiem.SelectedItem.ToString() == "Mã Giáo Viên")
                    {
                        dgvGiaoVien.DataSource = gv.timKiemGVTheoMa(txtTimKiem.Text);
                    }
                    if (cbTimKiem.SelectedItem.ToString() == "Tên Giáo Viên")
                    {
                        dgvGiaoVien.DataSource = gv.timKiemGVTheoTen(txtTimKiem.Text);
                    }

                }
                catch (Exception)
                {
                    MessageBox.Show("Lỗi chưa tìm kiếm được! Vui lòng thử lại!", "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin cần tìm kiếm!", "Cảnh Báo!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận thêm giáo viên", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (gv.insertGV(txtMaGV.Text, txtHoTenGV.Text, txtSDT.Text, txtDiaChi.Text, txtMatKhau.Text, txtGhiChu.Text, cbChucVu.SelectedValue.ToString(), cbChuyenMon.SelectedValue.ToString()))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDGVGiaoVien();
                    
                }
                else
                    MessageBox.Show("Thất bại");
            }
            
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa giáo viên", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                gv.deleteGV(dgvGiaoVien.CurrentRow.Cells[0].Value.ToString());
                LoadDGVGiaoVien();
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thay đổi thông tin giáo viên này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (gv.updateGV(txtHoTenGV.Text, txtSDT.Text, txtDiaChi.Text, txtMatKhau.Text, txtGhiChu.Text, cbChucVu.SelectedValue.ToString(), cbChuyenMon.SelectedValue.ToString(), txtMaGV.Text))
                {
                    MessageBox.Show("Cập nhập thành công");
                    LoadDGVGiaoVien();
                }
                else
                    MessageBox.Show("Thất bại");
            }
           
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaGV.Clear();
            txtHoTenGV.Clear();
            txtDiaChi.Clear();
            txtGhiChu.Clear();
            txtMatKhau.Clear();
            txtSDT.Clear();
            cbChucVu.SelectedIndex = -1;
            cbChuyenMon.SelectedIndex = -1;

        }

        private void chkMaTuDong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaTuDong.Checked == true)
            {
                int coso = int.Parse(gv.getMaTuDong().ToString());
                coso++;
                if (coso < 10)
                    txtMaGV.Text = "GV00" + coso.ToString();
                else if (coso < 100)
                    txtMaGV.Text = "GV0" + coso.ToString();
                else
                    txtMaGV.Text = "GV" + coso.ToString();
                txtMaGV.Enabled = false;
            }
            else
            {
                txtMaGV.Clear();
                txtMaGV.Enabled = true;

            }
            
        }

        private void dgvGiaoVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;
            txtMaGV.Text = dgvGiaoVien.Rows[index].Cells[0].Value.ToString().Trim();
            txtHoTenGV.Text = dgvGiaoVien.Rows[index].Cells[1].Value.ToString().Trim();
            txtSDT.Text = dgvGiaoVien.Rows[index].Cells[2].Value.ToString().Trim();
            txtDiaChi.Text = dgvGiaoVien.Rows[index].Cells[3].Value.ToString().Trim();
            txtMatKhau.Text = dgvGiaoVien.Rows[index].Cells[4].Value.ToString().Trim();
            txtGhiChu.Text = dgvGiaoVien.Rows[index].Cells[5].Value.ToString().Trim();
            cbChucVu.SelectedValue = dgvGiaoVien.Rows[index].Cells[6].Value.ToString().Trim();
            cbChuyenMon.SelectedValue = dgvGiaoVien.Rows[index].Cells[7].Value.ToString().Trim();
        } 

       
    }
}
