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
    public partial class FormQuanlytl : Form
    {
        AppbannuocEntities db = new AppbannuocEntities();
        B_Theloai bustln = new B_Theloai();
        public FormQuanlytl()
        {
            InitializeComponent();
        }

        private void FormQuanlytl_Load(object sender, EventArgs e)
        {
            hienthitheloai();
        }

        //quản lý danh mục thể loại
        public void hienthitheloai()
        {
            dgTheloainuoc.AutoGenerateColumns = false;
            bustln.laydanhsachtheloainuoc(dgTheloainuoc);
        }
        //xem danh sách thể loại
        private void btnXemloai_Click(object sender, EventArgs e)
        {
            hienthitheloai();
        }

        //thêm thể loại
        private void btnThemloai_Click(object sender, EventArgs e)
        {
            if (txtTentl.Text != "")
            {
                TheLoai tl = new TheLoai() { Tentheloai = txtTentl.Text };
                if (bustln.themTheloai(tl))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
 
        }

        //sửa thể loại
        private void btnSualoai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin thể loại này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                TheLoai tl = dgTheloainuoc.CurrentRow.DataBoundItem as TheLoai;
                tl.Tentheloai = txtTentl.Text;

                if (bustln.suaTheloai(tl))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
            
        }

        //xóa thể loại
        private void btnXoaloai_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa thể loại này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                TheLoai tl = dgTheloainuoc.CurrentRow.DataBoundItem as TheLoai;
                int idtl = tl.IdTheloai;
                if (bustln.xoaTheloai(idtl))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
        
        }

        private void CellTheloai_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtTentl.Text = dgTheloainuoc.Rows[index].Cells["theloainuoc"].Value.ToString();

            }
        }
    }
}
