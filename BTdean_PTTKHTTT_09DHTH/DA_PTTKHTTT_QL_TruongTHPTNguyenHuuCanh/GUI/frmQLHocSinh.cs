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
    public partial class frmQLHocSinh : Form
    {
        HocSinh_BLL hs = new HocSinh_BLL();
        DanToc_BLL dt = new DanToc_BLL();
        TonGiao_BLL tg = new TonGiao_BLL();
        LopHoc_BLL lh = new LopHoc_BLL();
        public frmQLHocSinh()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != "" || cbTimKiem.SelectedItem.ToString() != "")
            {
                try
                {
                    if (cbTimKiem.SelectedItem.ToString() == "Mã Học Sinh")
                    {
                        dgvHocSinh.DataSource = hs.timKiemHSTheoMa(txtTimKiem.Text);
                    }
                    if (cbTimKiem.SelectedItem.ToString() == "Tên Học Sinh")
                    {
                        dgvHocSinh.DataSource = hs.timKiemHSTheoTen(txtTimKiem.Text);
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

        private void frmQLHocSinh_Load(object sender, EventArgs e)
        {
            LoadDGVHocSinh();
            LoadCBLopHoc();
            LoadCBTonGiao();
            LoadCBDanToc();
        }

        private void LoadDGVHocSinh()
        {
            dgvHocSinh.DataSource = hs.getData();
        }

        private void LoadCBDanToc()
        {
            cbDanToc.DataSource = dt.getData();
            cbDanToc.DisplayMember = dt.getData().Columns[1].ToString();
            cbDanToc.ValueMember = dt.getData().Columns[0].ToString();
        }

        private void LoadCBTonGiao()
        {
            cbTonGiao.DataSource = tg.getData();
            cbTonGiao.DisplayMember = tg.getData().Columns[1].ToString();
            cbTonGiao.ValueMember = tg.getData().Columns[0].ToString();
        }

        private void LoadCBLopHoc()
        {
            cbLopHoc.DataSource = lh.getData();
            cbLopHoc.DisplayMember = lh.getData().Columns[1].ToString();
            cbLopHoc.ValueMember = lh.getData().Columns[0].ToString();
        }

        private void chkMaTuTang_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaTuTang.Checked == true)
            {
                int coso = int.Parse(hs.getMaTuDong().ToString());
                coso++;
                if (coso < 10)
                    txtMaHS.Text = "HS00" + coso.ToString();
                else if (coso < 100)
                    txtMaHS.Text = "HS0" + coso.ToString();
                else
                    txtMaHS.Text = "HS" + coso.ToString();
                txtMaHS.Enabled = false;
            }
            else
            {
                txtMaHS.Clear();
                txtMaHS.Enabled = true;

            }
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;

            txtMaHS.Text = dgvHocSinh.Rows[index].Cells[0].Value.ToString().Trim();
            txtTenHS.Text = dgvHocSinh.Rows[index].Cells[1].Value.ToString().Trim();
            dtpNgaySinh.Text = dgvHocSinh.Rows[index].Cells[2].Value.ToString().Trim();
            cbGioiTinh.Text = dgvHocSinh.Rows[index].Cells[3].Value.ToString().Trim();
            txtNoiSinh.Text = dgvHocSinh.Rows[index].Cells[4].Value.ToString().Trim();
            txtDiaChi.Text = dgvHocSinh.Rows[index].Cells[5].Value.ToString().Trim();
            txtHoTenBo.Text = dgvHocSinh.Rows[index].Cells[6].Value.ToString().Trim();
            txtHoTenMe.Text = dgvHocSinh.Rows[index].Cells[7].Value.ToString().Trim();
            txtSDT.Text = dgvHocSinh.Rows[index].Cells[8].Value.ToString().Trim();
            cbDanToc.SelectedValue = dgvHocSinh.Rows[index].Cells[9].Value.ToString().Trim();
            cbTonGiao.SelectedValue = dgvHocSinh.Rows[index].Cells[10].Value.ToString().Trim();
            cbLopHoc.SelectedValue = dgvHocSinh.Rows[index].Cells[11].Value.ToString().Trim();
            txtGhiChu.Text = dgvHocSinh.Rows[index].Cells[12].Value.ToString().Trim();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận thêm học sinh", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (hs.insertHS(txtMaHS.Text, txtTenHS.Text, dtpNgaySinh.Value,cbGioiTinh.Text,
                    txtNoiSinh.Text, txtDiaChi.Text, txtHoTenBo.Text,txtHoTenMe.Text,txtSDT.Text,
                    cbDanToc.SelectedValue.ToString(), cbTonGiao.SelectedValue.ToString(),
                    cbLopHoc.SelectedValue.ToString(),txtGhiChu.Text))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadDGVHocSinh();

                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa học sinh", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                hs.deleteHS(dgvHocSinh.CurrentRow.Cells[0].Value.ToString());
                LoadDGVHocSinh();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thay đổi thông tin học sinh này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (hs.updateHS(txtTenHS.Text, dtpNgaySinh.Value,cbGioiTinh.Text,
                    txtNoiSinh.Text, txtDiaChi.Text, txtHoTenBo.Text,txtHoTenMe.Text,txtSDT.Text,
                    cbDanToc.SelectedValue.ToString(), cbTonGiao.SelectedValue.ToString(),
                    cbLopHoc.SelectedValue.ToString(),txtGhiChu.Text,txtMaHS.Text))
                {
                    MessageBox.Show("Cập nhập thành công");
                    LoadDGVHocSinh();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaHS.Clear();
            txtTenHS.Clear();
            txtNoiSinh.Clear();
            txtDiaChi.Clear();
            txtHoTenBo.Clear();
            txtHoTenMe.Clear();
            txtGhiChu.Clear();
            txtSDT.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            cbGioiTinh.SelectedIndex = -1;
            cbDanToc.SelectedIndex = -1;
            cbLopHoc.SelectedIndex = -1;
            cbTonGiao.SelectedIndex = -1;
        }
    }
}
