using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDrink.DAO
{
    class D_Thongke
    {
        AppbannuocEntities db = new AppbannuocEntities();

        public List<HoaDon> GetdsHoadon()
        {
            List<HoaDon> dshd = new List<HoaDon>();
            var ds = from hd in db.HoaDon
                     join nv in db.NhanVien on hd.IdNhanvien equals nv.IdNhanvien
                     select new {hd.IdHoadon, hd.NgayLap, hd.TongCong, hd.NhanVien };
            foreach (var i in ds)
            {
                HoaDon hd = new HoaDon();
                hd.IdHoadon = i.IdHoadon;
                hd.NgayLap = i.NgayLap;
                hd.TongCong = i.TongCong;
                hd.Tennv = i.NhanVien.Hoten;
                dshd.Add(hd);
            }
            return dshd;
        }

        public List<HoaDon> GetdsHoadontheodate(DateTime fromdate, DateTime todate)
        {
            List<HoaDon> dshd = new List<HoaDon>();
            var ds = from hd in db.HoaDon
                     join nv in db.NhanVien on hd.IdNhanvien equals nv.IdNhanvien
                     where hd.NgayLap>=fromdate && hd.NgayLap<=todate
                     select new { hd.IdHoadon, hd.NgayLap, hd.TongCong, hd.NhanVien };
            foreach (var i in ds)
            {
                HoaDon hd = new HoaDon();
                hd.IdHoadon = i.IdHoadon;
                hd.NgayLap = i.NgayLap;
                hd.TongCong = i.TongCong;
                hd.Tennv = i.NhanVien.Hoten;
                dshd.Add(hd);
            }
            return dshd;
        }

        public List<ChiTiethd> GetCtHoadon(int mahd)
        {
            List<ChiTiethd> cthd = new List<ChiTiethd>();
            var ds = from ct in db.ChiTiethd
                     join nc in db.NuocUong on ct.IdNuoc equals nc.IdNuoc
                     where ct.IdHoadon == mahd
                     select new { ct.NuocUong, ct.Soluong, ct.Thanhtien };
            foreach (var i in ds)
            {
                ChiTiethd ct = new ChiTiethd();
                ct.Tennuoc = i.NuocUong.TenNuoc;
                ct.Soluong = i.Soluong;
                ct.Thanhtien = i.Thanhtien;
                cthd.Add(ct);
            }
            return cthd;
        }
    }
}
