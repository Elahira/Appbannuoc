using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDrink.DAO
{
    class D_Taikhoan
    {
        AppbannuocEntities db = new AppbannuocEntities();


        public List<TaiKhoan> GetTaiKhoans()
        {
            List<TaiKhoan> dstk = new List<TaiKhoan>();
            var ds = from tk in db.TaiKhoan select tk;
            foreach(var i in ds)
            {
                TaiKhoan tk = new TaiKhoan();
                tk.IdTK = i.IdTK;
                tk.Taikhoan = i.Taikhoan;
                tk.Matkhau = i.Matkhau;
                tk.Chucvu = i.Chucvu;
                dstk.Add(tk);
            }
            return dstk;
        }

        public bool themtaikhoan(TaiKhoan addtk)
        {
            {
                db.TaiKhoan.Add(addtk);
                db.SaveChanges();
            }return true;
        }

        public bool xoataikhoan(int matk)
        {
            {
                TaiKhoan tk = db.TaiKhoan.Find(matk);
                db.TaiKhoan.Remove(tk);
                db.SaveChanges();
            }
            return true;
        }

        public bool suataikhoan(TaiKhoan edittk)
        {
            {
                TaiKhoan tk = db.TaiKhoan.Find(edittk.IdTK);
                tk.Taikhoan = edittk.Taikhoan;
                tk.Matkhau = edittk.Matkhau;
                tk.Chucvu = edittk.Chucvu;
                db.SaveChanges();
            }return true;
        }
    }
}
