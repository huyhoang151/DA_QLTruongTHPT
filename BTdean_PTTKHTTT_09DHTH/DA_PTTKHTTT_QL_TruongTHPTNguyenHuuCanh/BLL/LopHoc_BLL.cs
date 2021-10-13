using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class LopHoc_BLL
    {
        LopHoc_DAL lh = new LopHoc_DAL();

        public LopHoc_BLL() { }

        public DataTable getData()
        {
            return lh.getData();
        }
    }
}
