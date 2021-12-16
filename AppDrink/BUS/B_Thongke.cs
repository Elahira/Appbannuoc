using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppDrink.DAO;
using System.Windows.Forms;

namespace AppDrink.BUS
{
    class B_Thongke
    {
        D_Thongke daothongke = new D_Thongke();

        public void laydanhsachhoadon(DataGridView dg)
        {
            dg.DataSource = daothongke.GetdsHoadon().ToList();
        }

        public void laydstheodate(DataGridView dg, DateTime fromdate, DateTime todate)
        {
            dg.DataSource = daothongke.GetdsHoadontheodate(fromdate,todate).ToList();
        }
    }
}
