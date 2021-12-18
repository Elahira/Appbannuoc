using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppDrink.BUS;

namespace AppDrink.GUI
{
    public partial class FormThongke : Form
    {
        B_Thongke busthongke = new B_Thongke();
        double tongdoanhthu = 0;
        public static string tennv;
        public static string datelap;
        public static int mahd;
        public static double tong;
        public FormThongke()
        {
            InitializeComponent();
            hienthidanhsach();
            tinhtongdoanhthu();
        }

        public void hienthidanhsach()
        {
            dgThongke.AutoGenerateColumns = false;
            busthongke.laydanhsachhoadon(dgThongke);
        }

        public void tinhtongdoanhthu()
        {
            for (int i = 0; i < dgThongke.Rows.Count; i++)
            {
                tongdoanhthu = tongdoanhthu + double.Parse(dgThongke.Rows[i].Cells["money"].Value.ToString());
            }
            lblDoanhthu.Text = tongdoanhthu.ToString();
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            busthongke.laydstheodate(dgThongke, fromDate.Value, toDate.Value);
            tongdoanhthu = 0;
            tinhtongdoanhthu();
            lblDoanhthu.Text = tongdoanhthu.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            dgThongke.DataSource = null;
            tongdoanhthu = 0;
            lblDoanhthu.Text = tongdoanhthu.ToString();
        }

        private void dgThongke_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            HoaDon hd = dgThongke.CurrentRow.DataBoundItem as HoaDon;
            tennv = hd.Tennv;
            datelap = hd.NgayLap.Value.ToShortDateString();
            mahd = hd.IdHoadon;
            tong = (double)hd.TongCong;
            Bill fb = new Bill();
            fb.ShowDialog();
        }
    }
}
