using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;

namespace DAL
{
    public class MonHoc_DAL
    {
        MonHocTableAdapter mh = new MonHocTableAdapter();

        public MonHoc_DAL() { }

        public DataTable getData()
        {
            return mh.GetData();
        }
    }
}
