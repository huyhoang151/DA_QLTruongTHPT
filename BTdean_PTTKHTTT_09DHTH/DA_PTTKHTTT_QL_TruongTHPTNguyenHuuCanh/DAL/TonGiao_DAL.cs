using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class TonGiao_DAL
    {
        TonGiaoTableAdapter tg = new TonGiaoTableAdapter();

        public TonGiao_DAL()
        {

        } 

        public DataTable getData()
        {
            return tg.GetData();
        }
    }
}
