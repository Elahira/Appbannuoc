using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppDrink.DAO
{
    class D_Nhanvien
    {
        AppbannuocEntities db = new AppbannuocEntities();

        //lấy data nhân viên
        public List<NhanVien> GetNhanViens()
        {
            List<NhanVien> dsnv = new List<NhanVien>();
            var ds = from nv in db.NhanVien select nv;
            foreach (var i in ds)
            {
                NhanVien nv = new NhanVien();
                nv.IdNhanvien = i.IdNhanvien;
                nv.Hoten = i.Hoten;
                nv.Gioitinh = i.Gioitinh;
                nv.NgaySinh = i.NgaySinh;
                nv.DienThoai = i.DienThoai;
                dsnv.Add(nv);
            }
            return dsnv;
        }

        //thêm thông tin nhân viên mới
        public bool themnhanvien(NhanVien addnv)
        {
            {
                db.NhanVien.Add(addnv);
                db.SaveChanges();
            }
            return true;
        }

        //chức năng xóa nhân viên
        public bool xoanhanvien(int manv)
        {
            {
                NhanVien nv = db.NhanVien.Find(manv);
                db.NhanVien.Remove(nv);
                db.SaveChanges();
            }
            return true;
        }

        //chức năng sửa thông tin nhân viên
        public bool suanhanvien(NhanVien suanv)
        {
            {
                NhanVien nv = db.NhanVien.Find(suanv.IdNhanvien);
                nv.Hoten = suanv.Hoten;
                nv.Gioitinh = suanv.Gioitinh;
                nv.NgaySinh = suanv.NgaySinh;
                nv.DienThoai = suanv.DienThoai;
                db.SaveChanges();
            }
            return true;
        }

        public int getManv(String tennv)
        {
            var dsnv = from nv in db.NhanVien
                       where nv.Hoten == tennv
                       select new { nv.IdNhanvien };
            int mnv = dsnv.First().IdNhanvien;
            return mnv;
        }
    }
}
