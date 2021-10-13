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
    public partial class frmDangNhap : Form
    {
        GiaoVien_BLL gv = new GiaoVien_BLL();
        public static string tendn;
        private int ImageNumber = 1;
        
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void Slider()
        {
            if (ImageNumber == 4)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"Images\{0}.jpg", ImageNumber);
            ImageNumber++;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Slider();
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                txtUsername.Text = "Type Your Username";
                txtUsername.ForeColor = Color.Gray;
            }
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Type Your Username")
            {
                txtUsername.Clear();
                txtUsername.ForeColor = Color.Black;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Type Your Password";
                txtPassword.ForeColor = Color.Gray;
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Type Your Password")
            {
                txtPassword.Clear();
                txtPassword.ForeColor = Color.Black;
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();         
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                int count = gv.getDataDangNhap(txtUsername.Text, txtPassword.Text).Rows.Count;
                //tendn = txtUsername.Text;
                if (txtUsername.Text == "Type Your Username" && txtPassword.Text == "Type Your Password")
                    MessageBox.Show("Yêu cầu nhập tài khoản và mật khẩu");
                else if (txtUsername.Text == "Type Your Username")
                    MessageBox.Show("Chưa nhập tài khoản");
                else if (txtPassword.Text == "Type Your Password")
                    MessageBox.Show("Chưa nhập mật khẩu");
                else if (count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    if (Program.main == null || Program.main.IsDisposed)
                        Program.main = new frmMain();
                    this.Visible = false;
                    tendn = txtUsername.Text;
                    Program.main.Show();
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");

            }
            catch
            {
                MessageBox.Show("Lỗi kết nối!!!");
            }         
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            panel1.Focus();
            
        }
    }
}
