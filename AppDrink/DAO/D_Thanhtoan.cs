using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDrink.DAO
{
    class D_Thanhtoan
    {
        AppbannuocEntities db = new AppbannuocEntities();

        //tạo đơn thanh toán
        public bool Thanhtoan(HoaDon hd)
        {
            {
                db.HoaDon.Add(hd);
                db.SaveChanges();
            }
            return true;
        }

        //tạo chi tiết hóa đơn
        public bool Chitiethd(ChiTiethd cthd)
        {
            {
                db.ChiTiethd.Add(cthd);
                db.SaveChanges();
            }
            return true;
        }

        //lấy mã hóa đơn
        public int getIdhd()
        {
            var id = (from hd in db.HoaDon
                     select new { hd.IdHoadon }).AsEnumerable();
            int hdid = id.LastOrDefault().IdHoadon;
            return hdid;
        }
    }
}
