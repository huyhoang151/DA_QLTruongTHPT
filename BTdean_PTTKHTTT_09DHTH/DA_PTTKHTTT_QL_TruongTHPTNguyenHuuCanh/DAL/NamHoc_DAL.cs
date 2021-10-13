using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class NamHoc_DAL
    {
        NamHocTableAdapter nh = new NamHocTableAdapter();

        public NamHoc_DAL() { }

        public DataTable getData()
        {
            return nh.GetData();
        }

        public bool insertNH(string maNH, string tenNH){
            try
            {
                nh.Insert(maNH, tenNH);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateNH(string tenNH, string maNH)
        {
            try
            {
                nh.UpdateNH(tenNH, maNH);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteNH(string maNH)
        {
            try
            {
                nh.DeleteQuery(maNH);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public int? getMaTuDong()
        {
            return nh.MaTuDong();
        }
    }
}
