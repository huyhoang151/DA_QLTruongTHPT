using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class HocSinh_BLL
    {
        HocSinh_DAL hs = new HocSinh_DAL();

        public HocSinh_BLL() { }

        public DataTable getData()
        {
            return hs.getData();
        }

        public DataTable timKiemHSTheoMa(string maHS)
        {
            return hs.timKiemHSTheoMa(maHS);
        }

        public DataTable timKiemHSTheoTen(string tenHS)
        {
            return hs.timKiemHSTheoTen(tenHS);
        }

        public bool insertHS(string maHS, string tenHS, DateTime ngaySinh, string gioitinh, string noiSinh, string diaChi, string hoTenBo, string hoTenMe, string sdtLienHe, string maDT, string maTG, string maLH, string ghiChu)
        {
            return hs.insertHS(maHS, tenHS, ngaySinh, gioitinh, noiSinh, diaChi, hoTenBo, hoTenMe, sdtLienHe, maDT, maTG, maLH, ghiChu);
               
        }
        public bool updateHS(string tenHS, DateTime ngaySinh, string gioitinh, string noiSinh, string diaChi, string hoTenBo, string hoTenMe, string sdtLienHe, string maDT, string maTG, string maLH, string ghiChu, string maHS)
        {
            return hs.updateHS(tenHS, ngaySinh, gioitinh, noiSinh, diaChi, hoTenBo, hoTenMe, sdtLienHe, maDT, maTG, maLH, ghiChu, maHS);
        }

        public bool deleteHS(string maHS)
        {
            return hs.deleteHS(maHS);

        }

        public int? getMaTuDong()
        {
            return hs.getMaTuDong();
        }

        public DataTable getHSbangMaMNvaMaLH(string maMH, string maLH)
        {
            return hs.getHSbangMaMNvaMaLH(maMH, maLH);
        }
    }
}
