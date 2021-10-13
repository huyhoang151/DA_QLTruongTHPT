using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class GiaoVien_DAL
    {
        GiaoVienTableAdapter gv = new GiaoVienTableAdapter();

        public GiaoVien_DAL() { }

        public DataTable getData()
        {
            return gv.GetData();
        }

        public DataTable getDataDangNhap(string sdt, string mk)
        {
            return gv.GetDataDangNhap(sdt, mk);
        }

        public DataTable getDataSDT(string sdt)
        {
            return gv.GetDataBySDT(sdt);
        }

        public DataTable timKiemGVTheoMa(string maGV)
        {
            return gv.TimKiemTheoMaGV(maGV);
        }

        public DataTable timKiemGVTheoTen(string tenGV)
        {
            return gv.TimKiemTheoTenGV(tenGV);
        }

        public bool insertGV(string maGV,string tenGV,string sdt,string diaChi,string matKhau,string ghiChu,string maLND,string maMH)
        {
            try
            {
                gv.Insert(maGV, tenGV, sdt, diaChi, matKhau, ghiChu, maLND, maMH);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateGV( string tenGV, string sdt, string diaChi, string matKhau, string ghiChu, string maLND, string maMH,string maGV)
        {
            try
            {
                gv.UpdateGV(tenGV, sdt, diaChi, matKhau, ghiChu, maLND, maMH, maGV);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteGV(string maGV)
        {
            try
            {
                gv.DeleteGV(maGV);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int? getMaTuDong()
        {
            return gv.MaTuDong();
        }
    }
}
