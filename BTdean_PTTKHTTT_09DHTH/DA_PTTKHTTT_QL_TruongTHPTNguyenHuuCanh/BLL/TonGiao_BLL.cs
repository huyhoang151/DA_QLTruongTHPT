using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;

namespace BLL
{
    public class TonGiao_BLL
    {
        TonGiao_DAL tg = new TonGiao_DAL();

        public TonGiao_BLL()
        { }
    
        public DataTable getData()
        {
            return tg.getData();
        }
    }
}
