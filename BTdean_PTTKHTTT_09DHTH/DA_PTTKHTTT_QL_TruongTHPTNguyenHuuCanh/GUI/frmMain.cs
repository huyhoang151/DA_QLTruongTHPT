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
    public partial class frmMain : Form
    {
        GiaoVien_BLL gv = new GiaoVien_BLL();
        
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            string quyen = "";
            foreach (DataRow dr in gv.getDataSDT(frmDangNhap.tendn).Rows)
            {
                quyen= dr["MaLoaiND"].ToString();
            }
            if (quyen=="LND01")
            {
                IsBGH();
            }
            else if (quyen =="LND02")
            {
                IsGiaoVien();
            }
            else if (quyen =="LND03")
            {
                IsGiaoVu();
            }
        }
        public void IsBGH()
        {
            //False
            btnDangNhap.Enabled = false;

            //True
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnQLNguoiDung.Enabled = true;
            btnQLManHinh.Enabled = true;
            btnThoat.Enabled = true;

            btnLopHoc.Enabled = true;
            btnKhoiHoc.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
            btnKetQua.Enabled = true;
            btnHocLuc.Enabled = true;
            btnHanhKiem.Enabled = true;
            btnDanhHieu.Enabled = true;
            btnHocSinh.Enabled = true;
            btnPhanLop.Enabled = true;
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;
            btnGiaoVien.Enabled = true;
            btnPhanCong.Enabled = true;

            btnTraCuuGV.Enabled = true;
            btnTraCuuHS.Enabled = true;

            btnHDSD.Enabled = true;
            btnThongTin.Enabled = true;
        }

        public void IsGiaoVien()
        {
            //True
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnThoat.Enabled = true;

            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;


            btnTraCuuHS.Enabled = true;
            btnTraCuuGV.Enabled = true;

            btnHDSD.Enabled = true;
            btnThongTin.Enabled = true;

            //False
            btnDangNhap.Enabled = false;
            btnQLNguoiDung.Enabled = false;
            btnQLManHinh.Enabled = false;
            btnLopHoc.Enabled = false;
            btnKhoiHoc.Enabled = false;
            btnHocKy.Enabled = false;
            btnNamHoc.Enabled = false;
            btnKetQua.Enabled = false;
            btnHocLuc.Enabled = false;
            btnDanhHieu.Enabled = false;
            btnHanhKiem.Enabled = false;
            btnHocSinh.Enabled = false;
            btnPhanLop.Enabled = false;
            btnTonGiao.Enabled = false;
            btnDanToc.Enabled = false;
            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;

        }

        public void IsGiaoVu()
        {
            //True
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnThoat.Enabled = true;
            btnQLManHinh.Enabled = true;
            btnLopHoc.Enabled = true;
            btnKhoiHoc.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            btnKetQua.Enabled = true;
            btnDanhHieu.Enabled = true;
            btnHocLuc.Enabled = true;
            btnHanhKiem.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
            btnHocSinh.Enabled = true;
            btnPhanLop.Enabled = true;
            btnTonGiao.Enabled = true;
            btnDanToc.Enabled = true;

            btnTraCuuGV.Enabled = true;
            btnTraCuuHS.Enabled = true;

            btnHDSD.Enabled = true;
            btnThongTin.Enabled = true;

            //False
            btnDangNhap.Enabled = false;
            btnQLNguoiDung.Enabled = false;

            btnGiaoVien.Enabled = false;
            btnPhanCong.Enabled = false;

        }

        private void btnGiaoVien_Click(object sender, EventArgs e)
        {
            this.panelContainer.Controls.Clear();
            frmQLGiaoVien frm = new frmQLGiaoVien();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnHocSinh_Click(object sender, EventArgs e)
        {
            this.panelContainer.Controls.Clear();
            frmQLHocSinh frm = new frmQLHocSinh();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnDiem_Click(object sender, EventArgs e)
        {
            this.panelContainer.Controls.Clear();
            frmDiemMonHoc frm = new frmDiemMonHoc();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnTraCuuHS_Click(object sender, EventArgs e)
        {
            this.panelContainer.Controls.Clear();
            frmTraCuuHocSinh frm = new frmTraCuuHocSinh();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnTraCuuGV_Click(object sender, EventArgs e)
        {
            this.panelContainer.Controls.Clear();
            frmTraCuuGiaoVien frm = new frmTraCuuGiaoVien();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }

        private void btnNamHoc_Click(object sender, EventArgs e)
        {
            this.panelContainer.Controls.Clear();
            frmNamHoc frm = new frmNamHoc();
            frm.TopLevel = false;
            panelContainer.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
    }
}
