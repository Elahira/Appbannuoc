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

        public List<NuocUong> getNuocUongs()
        {
            List<NuocUong> dsnuoc = new List<NuocUong>();
            var ds = from nc in db.NuocUong
                     join tl in db.TheLoai on nc.IdTheloai equals tl.IdTheloai
                     select new {nc.IdNuoc,nc.TenNuoc,nc.Gia,tl.Tentheloai };
            foreach (var i in ds)
            {
                NuocUong nuoc = new NuocUong();
                nuoc.IdNuoc = i.IdNuoc;
                nuoc.TenNuoc = i.TenNuoc;
                nuoc.Gia = i.Gia;
                
                dsnuoc.Add(nuoc); 
            }
            return dsnuoc;
        }
    }
}
