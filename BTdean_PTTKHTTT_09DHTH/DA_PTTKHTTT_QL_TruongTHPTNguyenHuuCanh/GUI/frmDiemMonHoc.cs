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
    public partial class frmDiemMonHoc : Form
    {
        HocSinh_BLL hs = new HocSinh_BLL();
        LopHoc_BLL lh = new LopHoc_BLL();
        NamHoc_BLL nh = new NamHoc_BLL();
        HocKy_BLL hk = new HocKy_BLL();
        MonHoc_BLL mh = new MonHoc_BLL();
        DiemMonHoc_BLL dmh = new DiemMonHoc_BLL();
        public frmDiemMonHoc()
        {
            InitializeComponent();
        }

        private void frmDiemMonHoc_Load(object sender, EventArgs e)
        {
            //loadDGVHocSinh();
            LoadCBLop();
            LoadCBNamHoc();
            LoadCBHocKy();
            LoadCBMonHoc();
        }

        private void loadDGVHocSinh()
        {
            dgvHocSinh.DataSource = hs.getHSbangMaMNvaMaLH(cbNamHoc.SelectedValue.ToString(),cbLop.SelectedValue.ToString());
        }

        private void LoadCBHocKy()
        {
            cbHocKy.DataSource = hk.getData();
            cbHocKy.DisplayMember = hk.getData().Columns[1].ToString();
            cbHocKy.ValueMember = hk.getData().Columns[0].ToString();
        }

        private void LoadCBMonHoc()
        {
            cbMonHoc.DataSource = mh.getData();
            cbMonHoc.DisplayMember = mh.getData().Columns[1].ToString();
            cbMonHoc.ValueMember = mh.getData().Columns[0].ToString();
        }
        private void LoadCBLop()
        {
            cbLop.DataSource = lh.getData();
            cbLop.DisplayMember = lh.getData().Columns[1].ToString();
            cbLop.ValueMember = lh.getData().Columns[0].ToString();
        }

        private void LoadCBNamHoc()
        {
            cbNamHoc.DataSource = nh.getData();
            cbNamHoc.DisplayMember = nh.getData().Columns[1].ToString();
            cbNamHoc.ValueMember = nh.getData().Columns[0].ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            loadDGVHocSinh();
        }

        private void dgvHocSinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (e.RowIndex == -1) return;
                txtMaHocSinh.Text = dgvHocSinh.Rows[index].Cells[0].Value.ToString().Trim();
            }
            catch
            {
                MessageBox.Show("Không thể thực hiện thao tác này");
            }
        }

        private void dgvDiemMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = e.RowIndex;
                if (e.RowIndex == -1) return;
                txtDiemMieng.Text = dgvDiemMonHoc.Rows[index].Cells[4].Value.ToString().Trim();
                txtDiem15Phut.Text = dgvDiemMonHoc.Rows[index].Cells[5].Value.ToString().Trim();
                txtDiem45Phut.Text = dgvDiemMonHoc.Rows[index].Cells[6].Value.ToString().Trim();
                txtDiemThi.Text = dgvDiemMonHoc.Rows[index].Cells[7].Value.ToString().Trim();
                txtDiemTB.Text = dgvDiemMonHoc.Rows[index].Cells[8].Value.ToString().Trim();
                loadDGVDiem();
            }
            catch { MessageBox.Show("Không thể thực hiện thao tác này"); }
        }

        private void btnTinhDTB_Click(object sender, EventArgs e)
        {
            float diemmieng = float.Parse(txtDiemMieng.Text);
            float diem15 = float.Parse(txtDiem15Phut.Text);
            float diem45 = float.Parse(txtDiem45Phut.Text);
            float diemthi= float.Parse(txtDiemThi.Text);
            float diemtb = (diemmieng+diem15+(diem45*2)+(diemthi*3))/7;
            txtDiemTB.Text = diemtb.ToString("#.#");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Xác nhận nhập điểm", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (dmh.insertDMH(txtMaHocSinh.Text,cbMonHoc.SelectedValue.ToString(),cbNamHoc.SelectedValue.ToString(),
                    cbHocKy.SelectedValue.ToString(),float.Parse(txtDiemMieng.Text),float.Parse(txtDiem15Phut.Text),float.Parse(txtDiem45Phut.Text),
                    float.Parse(txtDiemThi.Text),float.Parse(txtDiemTB.Text),""))
                {
                    MessageBox.Show("Thêm thành công");
                    loadDGVDiem();

                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn muốn thay đổi thông tin điểm của học sinh này", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                if (dmh.updateDMH( float.Parse(txtDiemMieng.Text), float.Parse(txtDiem15Phut.Text), float.Parse(txtDiem45Phut.Text),
                    float.Parse(txtDiemThi.Text), float.Parse(txtDiemTB.Text), "",txtMaHocSinh.Text, cbMonHoc.SelectedValue.ToString(), cbNamHoc.SelectedValue.ToString(),
                    cbHocKy.SelectedValue.ToString()))
                {
                    MessageBox.Show("Cập nhập thành công");
                    loadDGVDiem();
                }
                else
                    MessageBox.Show("Thất bại");
            }
        }

        private void loadDGVDiem()
        {
            dgvDiemMonHoc.DataSource = dmh.getDataMaHS(txtMaHocSinh.Text);
        }

        private void btnShowDiem_Click(object sender, EventArgs e)
        {
            loadDGVDiem();
        }


    }
}
