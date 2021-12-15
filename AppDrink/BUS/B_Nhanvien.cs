using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDrink.DAO;

namespace AppDrink.BUS
{
    class B_Nhanvien
    {
        D_Nhanvien daonv = new D_Nhanvien();

        public void laydanhsachnhanvien(DataGridView dg)
        {
            dg.DataSource = daonv.GetNhanViens().ToList();
        }

        public void laytennvcb(ComboBox cb)
        {
            cb.DataSource = daonv.GetNhanViens().ToList();
            cb.DisplayMember = "Hoten";
        }

        public bool themNhanvien(NhanVien nv)
        {
            return daonv.themnhanvien(nv);
        }

        public bool xoaNhanvien(int idnv)
        {
            return daonv.xoanhanvien(idnv);
        }

        public bool suaNhanvien(NhanVien nv)
        {
            return daonv.suanhanvien(nv);
        }
    }
}
