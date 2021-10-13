using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class GiaoVien_BLL
    {
        GiaoVien_DAL gv = new GiaoVien_DAL();

        public GiaoVien_BLL() { }

        public DataTable getData()
        {
            return gv.getData();
        }


        public DataTable getDataDangNhap(string sdt, string mk)
        {
            return gv.getDataDangNhap(sdt, mk);
        }

        public DataTable getDataSDT(string sdt)
        {
            return gv.getDataSDT(sdt);
        }

        public DataTable timKiemGVTheoMa(string maGV)
        {
            return gv.timKiemGVTheoMa(maGV);
        }

        public DataTable timKiemGVTheoTen(string tenGV)
        {
            return gv.timKiemGVTheoTen(tenGV);
        }

        public bool insertGV(string maGV, string tenGV, string sdt, string diaChi, string matKhau, string ghiChu, string maLND, string maMH)
        {
            return gv.insertGV(maGV, tenGV, sdt, diaChi, matKhau, ghiChu, maLND, maMH);

        }
        public bool updateGV(string tenGV, string sdt, string diaChi, string matKhau, string ghiChu, string maLND, string maMH, string maGV)
        {
            return gv.updateGV(tenGV, sdt, diaChi, matKhau, ghiChu, maLND, maMH, maGV);
        }

        public bool deleteGV(string maGV)
        {
            return gv.deleteGV(maGV);
        }

        public int? getMaTuDong()
        {
            return gv.getMaTuDong();
        }
    }
}
