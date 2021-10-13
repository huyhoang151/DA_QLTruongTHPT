using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class DanToc_DAL
    {
        DanTocTableAdapter dt = new DanTocTableAdapter();

        public DanToc_DAL() { }

        public DataTable getData()
        {
            return dt.GetData();
        }
    }
}
