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
using ComponentFactory.Krypton.Toolkit;

namespace AppDrink.GUI
{
    public partial class Bill : KryptonForm
    {
        AppbannuocEntities db = new AppbannuocEntities();
        B_Thongke busthongke = new B_Thongke();
        public Bill()
        {
            InitializeComponent();
            loadbill();
        }

        public void loadbill()
        {
            string ten = FormThongke.tennv;
            string ngaylap = FormThongke.datelap;
            double thanhtien = FormThongke.tong;
            int mahd = FormThongke.mahd;
            lblngaylap.Text = ngaylap;
            lblnguoilap.Text = ten;
            lbltong.Text = thanhtien.ToString();
            dgOrder.AutoGenerateColumns = false;
            busthongke.hienchitiethd(dgOrder, mahd);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
