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

        public List<TheLoai> getTheLoais()
        {
            List<TheLoai> dstln = new List<TheLoai>();
            var ds = from tln in db.TheLoai select tln;
            foreach (var i in ds)
            {
                TheLoai tln = new TheLoai();
                tln.IdTheloai = i.IdTheloai;
                tln.Tentheloai = i.Tentheloai;
                dstln.Add(tln);
            }
            return dstln;
        }
    }
}
