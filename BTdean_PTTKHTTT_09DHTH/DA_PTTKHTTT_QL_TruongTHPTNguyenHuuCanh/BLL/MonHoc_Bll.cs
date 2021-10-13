using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class MonHoc_BLL
    {
        MonHoc_DAL mh = new MonHoc_DAL();

        public MonHoc_BLL() { }

        public DataTable getData()
        {
            return mh.getData();
        }
    }
}
