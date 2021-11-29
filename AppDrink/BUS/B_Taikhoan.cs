using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDrink.DAO;

namespace AppDrink.BUS
{
    class B_Taikhoan
    {
        D_Taikhoan daotk = new D_Taikhoan();

        public void laydanhsachtaikhoan(DataGridView dg)
        {
            dg.DataSource = daotk.GetTaiKhoans().ToList();
        }

        public bool checklogin(string tk, string mk)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            list = daotk.GetTaiKhoans();
            foreach(var i in list){
                if (i.Taikhoan == tk && i.Matkhau == mk)
                {
                    return true;
                }
            }
            return false;
        }

        public bool addtaikhoan(TaiKhoan tk)
        {
            return daotk.themtaikhoan(tk);
        }

        public bool deltaikhoan(int matk)
        {
            return daotk.xoataikhoan(matk);
        }

        public bool edittaikhoan(TaiKhoan tk)
        {
            return daotk.suataikhoan(tk);
        }
    }
}
