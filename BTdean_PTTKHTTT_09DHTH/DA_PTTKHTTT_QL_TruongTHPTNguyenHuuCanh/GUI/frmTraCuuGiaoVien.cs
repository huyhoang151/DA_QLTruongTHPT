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
    public partial class frmTraCuuGiaoVien : Form
    {
        GiaoVien_BLL gv = new GiaoVien_BLL();
        public frmTraCuuGiaoVien()
        {
            InitializeComponent();
        }

        private void frmTraCuuGiaoVien_Load(object sender, EventArgs e)
        {
            LoadDGVGiaoVien();
        }

        private void LoadDGVGiaoVien()
        {
            dgvGiaoVien.DataSource = gv.getData();
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

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cbTimKiem.SelectedIndex = -1;
            LoadDGVGiaoVien();
        }


    }
}
