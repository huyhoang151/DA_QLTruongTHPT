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
    public partial class frmNamHoc : Form
    {
        NamHoc_BLL nh = new NamHoc_BLL();
        public frmNamHoc()
        {
            InitializeComponent();
        }

        private void frmNamHoc_Load(object sender, EventArgs e)
        {
            LoadNamHoc();
        }

        private void LoadNamHoc()
        {
            dgvNamHoc.DataSource = nh.getData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận Năm học", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (nh.insertNH(txtMaNH.Text, txtNamHoc.Text))
                {
                    MessageBox.Show("Thêm thành công");
                    LoadNamHoc();

                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void chkMaTuDong_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMaTuDong.Checked == true)
            {
                int coso = int.Parse(nh.getMaTuDong().ToString());
                coso++;
                if (coso < 10)
                    txtMaNH.Text = "NH00" + coso.ToString();
                else if (coso < 100)
                    txtMaNH.Text = "NH0" + coso.ToString();
                else
                    txtMaNH.Text = "GV" + coso.ToString();
                txtMaNH.Enabled = false;
            }
            else
            {
                txtMaNH.Clear();
                txtMaNH.Enabled = true;
            }
        }

        private void dgvNamHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (e.RowIndex == -1) return;
            txtMaNH.Text = dgvNamHoc.Rows[index].Cells[0].Value.ToString().Trim();
            txtNamHoc.Text = dgvNamHoc.Rows[index].Cells[1].Value.ToString().Trim();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn xóa Năm học", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                nh.deleteNH(dgvNamHoc.CurrentRow.Cells[0].Value.ToString());
                LoadNamHoc();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thay đổi thông tin năm học này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (nh.updateNH(txtNamHoc.Text, txtMaNH.Text))
                {
                    MessageBox.Show("Cập nhập thành công");
                    LoadNamHoc();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }
    }
}
