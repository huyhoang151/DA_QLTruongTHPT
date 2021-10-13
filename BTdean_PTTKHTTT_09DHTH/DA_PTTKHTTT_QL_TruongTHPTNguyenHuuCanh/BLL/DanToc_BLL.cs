using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class DanToc_BLL
    {
        DanToc_DAL dt = new DanToc_DAL();

        public DanToc_BLL() { }

        public DataTable getData()
        {
            return dt.getData();
        }
    }
}
