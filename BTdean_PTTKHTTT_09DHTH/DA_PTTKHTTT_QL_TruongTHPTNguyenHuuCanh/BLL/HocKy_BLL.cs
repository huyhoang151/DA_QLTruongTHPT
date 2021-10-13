using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class HocKy_BLL
    {
        HocKy_DAL hk = new HocKy_DAL();

        public HocKy_BLL() { }

        public DataTable getData()
        {
            return hk.getData();
        }
    }
}
