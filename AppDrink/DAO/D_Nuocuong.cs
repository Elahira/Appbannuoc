using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDrink.DAO
{
    class D_Nuocuong
    {
        AppbannuocEntities db = new AppbannuocEntities();

        //danh sách nước
        public List<NuocUong> GetNuocUongs()
        {
            List<NuocUong> dsnc = new List<NuocUong>();
            var ds = from nc in db.NuocUong
                     join tl in db.TheLoai on nc.IdTheloai equals tl.IdTheloai
                     select new { nc.IdNuoc, nc.TenNuoc, nc.Gia, nc.TheLoai};
            foreach (var i in ds)
            {
                NuocUong nc = new NuocUong();
                nc.IdNuoc = i.IdNuoc;
                nc.TenNuoc = i.TenNuoc;
                nc.Gia = i.Gia;
                nc.Tentheloai = i.TheLoai.Tentheloai;
                dsnc.Add(nc);
            }
            return dsnc;
        }


        //lọc sản phẩm theo thể loại
        public List<NuocUong> filtertheotl(String tentl)
        {
            List<NuocUong> dsnc = new List<NuocUong>();
            var ds = from nc in db.NuocUong
                     join tl in db.TheLoai on nc.IdTheloai equals tl.IdTheloai
                     where tl.Tentheloai==tentl
                     select new { nc.IdNuoc, nc.TenNuoc, nc.Gia, nc.TheLoai };
            foreach (var i in ds)
            {
                NuocUong nc = new NuocUong();
                nc.IdNuoc = i.IdNuoc;
                nc.TenNuoc = i.TenNuoc;
                nc.Gia = i.Gia;
                nc.Tentheloai = i.TheLoai.Tentheloai;
                dsnc.Add(nc);
            }
            return dsnc;
        }

        //chức năng thêm nước
        public bool themnuocuong(NuocUong themnuoc)
        {
            {
                db.NuocUong.Add(themnuoc);
                db.SaveChanges();
            }
            return true;
        }

        //chức năng xóa nước
        public bool xoanuocuong(int manuoc)
        {
            {
                NuocUong nc = db.NuocUong.Find(manuoc);
                db.NuocUong.Remove(nc);
                db.SaveChanges();
            }
            return true;
        }

        //chức năng sửa nước
        public bool suanuocuong(NuocUong suanuoc)
        {
            {
                NuocUong nc = db.NuocUong.Find(suanuoc.IdNuoc);
                nc.TenNuoc = suanuoc.TenNuoc;
                nc.Gia = suanuoc.Gia;
                nc.IdTheloai = suanuoc.IdTheloai;
                db.SaveChanges();
            }
            return true;
        }

        //lấy mã nước theo tên nước
        public int getManuoc(String tennuoc)
        {
            var nuoc = from nc in db.NuocUong
                      where nc.TenNuoc == tennuoc
                      select new { nc.IdNuoc };
            int mnc = nuoc.First().IdNuoc;
            return mnc;
        }
    }
}
