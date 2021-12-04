using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDrink.DAO
{
    class D_Theloai
    {
        AppbannuocEntities db = new AppbannuocEntities();

        public dynamic getTheLoais()
        {
            
            var dstl = db.TheLoai.Select(tl =>new
            {
                tl.IdTheloai,
                tl.Tentheloai
            }).ToList();
           
            return dstl;
        }

        //chức năng thêm thể loại
        public bool themtheloai(TheLoai themtln)
        {
            {
                db.TheLoai.Add(themtln);
                db.SaveChanges();
            }
            return true;
        }

        //chức năng xóa thể loại
        public bool xoatheloai(int matln)
        {
            {
                TheLoai tl = db.TheLoai.Find(matln);
                db.TheLoai.Remove(tl);
                db.SaveChanges();
            }
            return true;
        }

        //chức năng sửa thể loại
        public bool suatheloai(TheLoai suatl)
        {
            {
                TheLoai tl = db.TheLoai.Find(suatl.IdTheloai);
                tl.Tentheloai = suatl.Tentheloai;
                db.SaveChanges();
            }
            return true;
        }
    }
}
