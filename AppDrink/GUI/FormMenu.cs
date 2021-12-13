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
    public partial class FormMenu : KryptonForm
    {
        AppbannuocEntities db = new AppbannuocEntities();
        B_Theloai bustln = new B_Theloai();
        B_Nuocuong busnuoc = new B_Nuocuong();
        public FormMenu()
        {
            InitializeComponent();
            busnuoc.laydsnuocvaolist(listMenu);
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            busnuoc.laydsnuocvaolist(listMenu);
        }

        private void listMenu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
