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

        public dynamic getNuocUongs()
        {
            var ds = db.NuocUong.Select(s => new
            {
                s.IdNuoc,
                s.TenNuoc,
                s.Gia,
                s.TheLoai.Tentheloai
            }).ToList();
            return ds;
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
                nc.TheLoai.Tentheloai = suanuoc.TheLoai.Tentheloai;
                db.SaveChanges();
            }
            return true;
        }
    }
}
