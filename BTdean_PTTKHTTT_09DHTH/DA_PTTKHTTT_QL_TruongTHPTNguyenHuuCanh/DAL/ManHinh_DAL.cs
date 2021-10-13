using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;

namespace DAL
{
    public class ManHinh_DAL
    {
        ManHinh_DAL mh = new ManHinh_DAL();

        public ManHinh_DAL() { }

        public DataTable getData()
        {
            return mh.getData();
        }
    }
}
