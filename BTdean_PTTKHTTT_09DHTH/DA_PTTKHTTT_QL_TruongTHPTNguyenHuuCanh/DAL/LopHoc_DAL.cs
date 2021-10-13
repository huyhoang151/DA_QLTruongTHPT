using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class LopHoc_DAL
    {
        LopHocTableAdapter lh = new LopHocTableAdapter();

        public LopHoc_DAL() { }

        public DataTable getData()
        {
            return lh.GetData();
        }
    }
}
