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
        public int id;
        
        public void laydanhsachtaikhoan(DataGridView dg)
        {
            dg.DataSource = daotk.GetTaiKhoans().ToList();
        }

        public bool checkloginadmin(string tk, string mk)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            list = daotk.GetTaiKhoanAdmin();
            foreach (var i in list)
            {
                if (i.Taikhoan == tk && i.Matkhau == mk)
                {
                    id = i.IdTK;
                    return true;
                }
            }
            return false;
        }

        public bool checkloginstaff(string tk, string mk)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            list = daotk.GetTaiKhoanStaff();
            foreach (var i in list)
            {
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
