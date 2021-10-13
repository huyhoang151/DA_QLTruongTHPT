using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class HocKy_DAL
    {
        HocKyTableAdapter hk = new HocKyTableAdapter();

        public HocKy_DAL()
        {

        }

        public DataTable getData()
        {
            return hk.GetData();
        }
    }
}
