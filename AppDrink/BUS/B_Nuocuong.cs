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
            dg.DataSource = daonuoc.getNuocUongs();
        }
    }
}
