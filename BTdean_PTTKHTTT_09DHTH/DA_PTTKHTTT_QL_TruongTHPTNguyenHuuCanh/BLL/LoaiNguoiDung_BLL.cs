using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public class LoaiNguoiDung_BLL
    {
        LoaiNguoiDung_DAL lnd = new LoaiNguoiDung_DAL();

        public LoaiNguoiDung_BLL()      
        { }

        public DataTable getData()
        {
            return lnd.getData();
        }
    }
}
