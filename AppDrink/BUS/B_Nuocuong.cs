using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDrink.DAO;

namespace AppDrink.BUS
{
    class B_Nuocuong
    {
        D_Nuocuong daonuoc = new D_Nuocuong();

        public void laydanhsachnuoc(DataGridView dg)
        {
            dg.DataSource = daonuoc.GetNuocUongs().ToList();
        }

        public bool themNuoc(NuocUong nc)
        {
            return daonuoc.themnuocuong(nc);
        }

        public bool suaNuoc(NuocUong nc)
        {
            return daonuoc.suanuocuong(nc);
        }

        public bool xoaNuoc(int manuoc)
        {
            return daonuoc.xoanuocuong(manuoc);
        }
    }
}
