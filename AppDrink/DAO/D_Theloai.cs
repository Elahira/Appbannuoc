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

            var dstl = (from tl in db.TheLoai select tl).ToList();
            return dstl;
        }
        //lấy id thể loại dựa vào tên thể loại
        public int getMatheloai(String tentheloai)
        {
            var tln = from tl in db.TheLoai
                      where tl.Tentheloai == tentheloai
                      select new { tl.IdTheloai };
            int mtl = tln.First().IdTheloai;
            return mtl;
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
