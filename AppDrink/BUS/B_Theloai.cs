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
            dg.DataSource = daotln.getTheLoais();
        }

        public void laydanhsachtheloaicb(ComboBox cb)
        {
            cb.DataSource = daotln.getTheLoais();
            cb.DisplayMember = "Tentheloai";
            
        }

        public int getmatheloai(String tenTheloai)
        {
            return daotln.getMatheloai(tenTheloai);
        }

        public bool themTheloai(TheLoai tl)
        {
            return daotln.themtheloai(tl);
        }

        public bool xoaTheloai(int matl)
        {
            return daotln.xoatheloai(matl);
        }

        public bool suaTheloai(TheLoai tl)
        {
            return daotln.suatheloai(tl);
        }
    }
}
