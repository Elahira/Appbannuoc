using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDrink.DAO;

namespace AppDrink.BUS
{
    class B_Thanhtoan
    {
        D_Thanhtoan daott = new D_Thanhtoan();

        public bool thanhtoan(HoaDon hd)
        {
            return daott.Thanhtoan(hd);
        }

        public bool chitiethd(ChiTiethd cthd)
        {
            return daott.Chitiethd(cthd);
        }

        public int getMahd()
        {
            return daott.getIdhd();
        }
    }
}
