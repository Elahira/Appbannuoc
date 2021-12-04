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
        public dynamic GetNhanViens()
        {
            var dsnv = db.NhanVien.Select(nv => new
            {
                nv.IdNhanvien,
                nv.Hoten,
                nv.Gioitinh,
                nv.NgaySinh,
                nv.DienThoai
            }).ToList();
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
    }
}
