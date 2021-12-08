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
    public partial class FormQuanlytk : Form
    {
        AppbannuocEntities db = new AppbannuocEntities();
        B_Taikhoan bustk = new B_Taikhoan();
        public FormQuanlytk()
        {
            InitializeComponent();
        }

        //hiển thị tài khoản
        public void hienthitk()
        {
            dgTaikhoan.AutoGenerateColumns = false;
            bustk.laydanhsachtaikhoan(dgTaikhoan);
        }

        //hiển thị refresh lấy lại danh sách tài khoản
        private void btnXemtk_Click(object sender, EventArgs e)
        {
            hienthitk();
        }

        //form load danh sách data vào các datagrid
        private void FormQuanlytk_Load(object sender, EventArgs e)
        {
            hienthitk();
        }

        //đổ dữ liệu row vào các box
        private void tk_cellclick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtTk.Text = dgTaikhoan.Rows[index].Cells["Tkuser"].Value.ToString();
                txtMk.Text = dgTaikhoan.Rows[index].Cells["Mkpass"].Value.ToString();
                listCv.Text = dgTaikhoan.Rows[index].Cells["Cvtype"].Value.ToString();
            }
        }

        //thêm tài khoản
        private void btnThemtk_Click(object sender, EventArgs e)
        {
            if (txtTk.Text != "" && txtMk.Text != "" && listCv.Text != "")
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

        //xóa tài khoản
        private void btnXoatk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                TaiKhoan tk = dgTaikhoan.CurrentRow.DataBoundItem as TaiKhoan;
                int idtk = tk.IdTK;
                if (bustk.deltaikhoan(idtk))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
        }

        //sửa tài khoản
        private void btnSuatk_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa tài khoản này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                TaiKhoan tk = dgTaikhoan.CurrentRow.DataBoundItem as TaiKhoan;
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
    }
}
