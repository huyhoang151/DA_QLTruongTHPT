using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class NamHoc_BLL
    {
        NamHoc_DAL nh = new NamHoc_DAL();

        public NamHoc_BLL() { }

        public DataTable getData()
        {
            return nh.getData();
        }

        public bool insertNH(string maNH, string tenNH)
        {
            return nh.insertNH(maNH, tenNH);
        }
        public bool updateNH(string tenNH,string maNH)
        {
            return nh.updateNH(tenNH,maNH);
        }
        public bool deleteNH(string maGV)
        {
            return nh.deleteNH(maGV);
        }
        public int? getMaTuDong()
        {
            return nh.getMaTuDong();
        }

    }
}
