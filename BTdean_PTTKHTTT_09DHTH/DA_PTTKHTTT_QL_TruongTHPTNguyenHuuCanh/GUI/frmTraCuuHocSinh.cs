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
    public partial class frmTraCuuHocSinh : Form
    {
        HocSinh_BLL hs = new HocSinh_BLL();
        public frmTraCuuHocSinh()
        {
            InitializeComponent();
        }

        private void frmTraCuuHocSinh_Load(object sender, EventArgs e)
        {
            LoadDGVHocSinh();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtTimKiem.Clear();
            cbTimKiem.SelectedIndex = -1;
            LoadDGVHocSinh();
        }
        private void LoadDGVHocSinh()
        {
            dgvHocSinh.DataSource = hs.getData();
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text != string.Empty || cbTimKiem.SelectedItem.ToString() != string.Empty)
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
    }
}
