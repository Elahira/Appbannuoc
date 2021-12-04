using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDrink.DAO;

namespace AppDrink.BUS
{
    class B_Theloai
    {
        D_Theloai daotln = new D_Theloai();

        public void laydanhsachtheloainuoc(DataGridView dg)
        {
            dg.DataSource = daotln.getTheLoais().ToList();
        }
    }
}
