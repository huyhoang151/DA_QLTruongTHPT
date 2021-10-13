using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class ManHinh_BLL
    {
        ManHinh_DAL mh = new ManHinh_DAL();

        public ManHinh_BLL(){}

        public DataTable getData()
        {
            return mh.getData();
        }
    }
}
