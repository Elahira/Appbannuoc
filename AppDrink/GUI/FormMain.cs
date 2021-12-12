using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using ComponentFactory.Krypton.Toolkit;

namespace AppDrink.GUI
{
    public partial class FormMain : KryptonForm
    {
        private IconButton currentbtn;
        private Panel leftborbtn;
        private Form currentChildForm;
        public FormMain()
        {
            InitializeComponent();
            leftborbtn = new Panel();
            leftborbtn.Size = new Size(7, 65);
            panelMenu.Controls.Add(leftborbtn);
        }

        public struct RGBcolor
        {
            public static Color color1 = Color.FromArgb(103, 219, 70);
            public static Color color2 = Color.FromArgb(255, 90, 87);
            public static Color color3 = Color.FromArgb(255, 180, 79);
            public static Color color4 = Color.FromArgb(244, 115, 12);
            public static Color color5 = Color.FromArgb(244, 12, 176);
           
        }


        private void ActivateBtn(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                DisableBtn();
                currentbtn = (IconButton)senderBtn;
                currentbtn.BackColor = Color.FromArgb(0, 73, 168);
                currentbtn.ForeColor = color;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = color;
                leftborbtn.BackColor = color;
                leftborbtn.Location = new Point(0, currentbtn.Location.Y);
                leftborbtn.Visible = true;
                leftborbtn.BringToFront();
                iconCurrentChild.IconChar = currentbtn.IconChar;
                iconCurrentChild.IconColor = color;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            TitleChild.Text = childForm.Text;
        }

        private void DisableBtn()
        {
            if(currentbtn != null)
            {
                currentbtn.BackColor = Color.FromArgb(68, 146, 248);
                currentbtn.ForeColor = Color.SeaShell;
                currentbtn.TextAlign = ContentAlignment.MiddleCenter;
                currentbtn.IconColor = Color.SeaShell;
            }
        }

        private void btnTaikhoan_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.color1);
            OpenChildForm(new FormQuanlytk());
        }

        private void btnNhanvien_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.color2);
            OpenChildForm(new FormQuanlynv());
        }

        private void btnNuoc_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.color3);
            OpenChildForm(new FormQuanlynuoc());
        }

        private void btnTheloai_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.color4);
            OpenChildForm(new FormQuanlytl());
        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBcolor.color5);
            
        }

        private void reset()
        {
            DisableBtn();
            leftborbtn.Visible = false;
            iconCurrentChild.IconChar = IconChar.Home;
            iconCurrentChild.IconColor = Color.FromArgb(252, 50, 90);
            TitleChild.Text = "Home";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            reset();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnThoat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMenu(object sender, EventArgs e)
        {
            FormMenu fmenu = new FormMenu();
            this.Hide();
            fmenu.ShowDialog();
            this.Show();
        }
    }
}
