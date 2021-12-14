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
            loadtheloai();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            loadtheloai();
        }

        private void cbTentl_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void loadtheloai()
        {
            bustln.laydanhsachtheloaicb(cbTentl);
        }
    }
}
