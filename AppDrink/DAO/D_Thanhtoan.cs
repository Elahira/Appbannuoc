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

        public bool Thanhtoan(HoaDon hd)
        {
            {
                db.HoaDon.Add(hd);
                db.SaveChanges();
            }
            return true;
        }
    }
}
