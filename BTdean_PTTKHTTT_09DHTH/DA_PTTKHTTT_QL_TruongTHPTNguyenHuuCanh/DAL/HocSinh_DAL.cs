using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class HocSinh_DAL
    {
        HocSinhTableAdapter hs = new HocSinhTableAdapter();

        public HocSinh_DAL() { }

        public DataTable getData()
        {
            return hs.GetData();
        }

        public DataTable timKiemHSTheoMa(string maHS)
        {
            return hs.TimKiemTheoMaHS(maHS);
        }

        public DataTable timKiemHSTheoTen(string tenHS)
        {
            return hs.TimKiemTheoTenHS(tenHS);
        }

        public bool insertHS(string maHS, string tenHS,DateTime ngaySinh, string gioitinh,string noiSinh, string diaChi, string hoTenBo, string hoTenMe, string sdtLienHe, string maDT,string maTG,string maLH,string ghiChu)
        {
            try
            {
                hs.Insert(maHS,tenHS,ngaySinh,gioitinh,noiSinh,diaChi,hoTenBo,hoTenMe,sdtLienHe,maDT,maTG,maLH,ghiChu);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updateHS(string tenHS, DateTime ngaySinh, string gioitinh, string noiSinh, string diaChi, string hoTenBo, string hoTenMe, string sdtLienHe, string maDT, string maTG, string maLH, string ghiChu, string maHS)
        {
            try
            {
                hs.UpdateHS(tenHS, ngaySinh, gioitinh, noiSinh, diaChi, hoTenBo, hoTenMe, sdtLienHe, maDT, maTG, maLH, ghiChu,maHS);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool deleteHS(string maHS)
        {
            try
            {
                hs.DeleteHS(maHS);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int? getMaTuDong()
        {
            return hs.MaTuDong();
        }

        public DataTable getHSbangMaMNvaMaLH(string maMH, string maLH)
        {
            return hs.GetDataByMaMHvaMaLop(maMH, maLH);
        }
    }
}
