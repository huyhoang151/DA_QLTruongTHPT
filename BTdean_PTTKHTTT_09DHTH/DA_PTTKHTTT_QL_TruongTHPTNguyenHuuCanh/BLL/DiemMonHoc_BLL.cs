using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class DiemMonHoc_BLL
    {
        DiemMonHoc_DAL dmh = new DiemMonHoc_DAL();

        public DiemMonHoc_BLL() { }

        public DataTable getData()
        {
            return dmh.getData();
        }

        public bool insertDMH(string mahs,string mamh,string manh,string mahk,float diemmieng,float diem15p,float diem45p,float diemthi,float diemtb,string ghichu)
        {
            return dmh.insertDMH(mahs, mamh, manh, mahk, diemmieng, diem15p, diem45p, diemthi, diemtb, ghichu);
        }

        public bool updateDMH(float diemmieng, float diem15p, float diem45p, float diemthi, float diemtb, string ghichu,string mahs, string mamh, string manh, string mahk)
        {
            return dmh.updateDMH(diemmieng, diem15p, diem45p, diemthi, diemtb, ghichu, mahs, mamh, manh, mahk);
                
        }

        public DataTable getDataMaHS(string maHS)
        {
            return dmh.getDataMaHS(maHS);
        }
    }
}
