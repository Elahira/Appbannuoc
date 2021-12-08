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

        //chức năng đăng nhập
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtTk.Text != "" && txtMk.Text != "")
            {
                if (bustk.checkloginadmin(txtTk.Text, txtMk.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    FormMain fm = new FormMain();
                    
                    this.Hide();
                    fm.ShowDialog();
                    this.Show();
                    
                }

                else if (bustk.checkloginstaff(txtTk.Text, txtMk.Text))
                {
                    MessageBox.Show("Đăng nhập thành công");
                    FormStaff fs = new FormStaff();
                    
                    this.Hide();
                    fs.ShowDialog();
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

        //khi đóng chương trình sẽ hiện form thông báo hỏi có muốn đóng chương trình không ok=>đóng, cancel=>hủy và trả lại giao diện login
        private void form_close(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát chương trình?","thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        //xử lý nhấn nút Enter để login
        private void Enter_press(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
