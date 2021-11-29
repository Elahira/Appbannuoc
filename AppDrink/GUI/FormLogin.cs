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
    public partial class FormLogin : Form
    {
        B_Taikhoan bustk = new B_Taikhoan();
        public FormLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTk.Text != "" && txtMk.Text != "")
            {
                if (bustk.checklogin(txtTk.Text, txtMk.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    FormAdmin f = new FormAdmin();
                    this.Hide();
                    f.ShowDialog();
                    this.Show();
                }
                else
                    MessageBox.Show("Sai thông tin đăng nhập");
            }
            else
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin đăng nhập");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void form_close(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void Enter_press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
