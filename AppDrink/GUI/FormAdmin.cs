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
    public partial class FormAdmin : Form
    {
        AppbannuocEntities db = new AppbannuocEntities();
        B_Taikhoan bustk = new B_Taikhoan();
        public FormAdmin()
        {
            InitializeComponent();
        }

        public void hienthi()
        {
            bustk.laydanhsachtaikhoan(dataTaikhoan);
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            hienthi();
        }

        private void FormQuanlyTK_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void tk_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtTk.Text = dataTaikhoan.Rows[index].Cells["Tkuser"].Value.ToString();
                txtMk.Text = dataTaikhoan.Rows[index].Cells["Mkpass"].Value.ToString();
                listCv.Text = dataTaikhoan.Rows[index].Cells["Cvtype"].Value.ToString();
            }
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            themtaikhoan();
        }

        public void themtaikhoan()
        {
            if (txtTk.Text != "" && txtMk.Text != "" && listCv.Text !="")
            {
                TaiKhoan tk = new TaiKhoan() { Taikhoan = txtTk.Text, Matkhau = txtMk.Text, Chucvu = listCv.Text };
                if (bustk.addtaikhoan(tk))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                TaiKhoan tk = dataTaikhoan.CurrentRow.DataBoundItem as TaiKhoan;
                int idtk = tk.IdTK;
                if (bustk.deltaikhoan(idtk))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                TaiKhoan tk = dataTaikhoan.CurrentRow.DataBoundItem as TaiKhoan;
                tk.Taikhoan = txtTk.Text;
                tk.Matkhau = txtMk.Text;
                tk.Chucvu = listCv.Text;
                
                if (bustk.edittaikhoan(tk))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
