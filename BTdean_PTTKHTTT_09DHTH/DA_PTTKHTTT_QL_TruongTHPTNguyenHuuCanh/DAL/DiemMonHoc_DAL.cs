using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class DiemMonHoc_DAL
    {
        DiemMonHocTableAdapter dmh = new DiemMonHocTableAdapter();

        public DiemMonHoc_DAL() { }

        public DataTable getData()
        {
            return dmh.GetData();
        }

        public bool insertDMH(string mahs,string mamh,string manh,string mahk,float diemmieng,float diem15p,float diem45p,float diemthi,float diemtb,string ghichu)
        {
            try
            {
                dmh.Insert(mahs, mamh, manh, mahk, diemmieng, diem15p, diem45p, diemthi, diemtb, ghichu);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateDMH(float diemmieng, float diem15p, float diem45p, float diemthi, float diemtb, string ghichu,string mahs, string mamh, string manh, string mahk)
        {
            try
            {
                dmh.UpdateDiemMonHoc(diemmieng, diem15p, diem45p, diemthi, diemtb, ghichu,mahs, mamh, manh, mahk);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getDataMaHS(string maHS)
        {
            return dmh.GetDataByMaHS(maHS);
        }
    }
}
