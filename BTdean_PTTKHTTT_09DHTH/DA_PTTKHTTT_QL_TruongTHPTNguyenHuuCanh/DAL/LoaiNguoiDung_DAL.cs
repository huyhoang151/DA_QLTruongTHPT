using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.QL_TruongTHPTNguyenHuuCanhTableAdapters;
using System.Data;

namespace DAL
{
    public class LoaiNguoiDung_DAL
    {
        LoaiNguoiDungTableAdapter lnd = new LoaiNguoiDungTableAdapter();

        public LoaiNguoiDung_DAL() { }
        public DataTable getData()
        {
            return lnd.GetData();
        }
    }
}
