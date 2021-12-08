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
    public partial class FormQuanlynuoc : Form
    {
        AppbannuocEntities db = new AppbannuocEntities();
        B_Theloai bustln = new B_Theloai();
        B_Nuocuong busnuoc = new B_Nuocuong();
        public FormQuanlynuoc()
        {
            InitializeComponent();
        }

        private void FormQuanlynuoc_Load(object sender, EventArgs e)
        {
            hienthinuocuong();
        }

        //quản lý nước uống

        public void hienthinuocuong()
        {
            dgNuocuong.AutoGenerateColumns = false;
            busnuoc.laydanhsachnuoc(dgNuocuong);
        }

        private void btnXemnuoc_Click(object sender, EventArgs e)
        {
            hienthinuocuong();
        }
        //thêm nước
        private void btnThemnuoc_Click(object sender, EventArgs e)
        {
            if (txtTennuoc.Text != "" && txtGiatien.Text != "" && cbLoainuoc.Text != "")
            {
                NuocUong nc = new NuocUong()
                {
                    TenNuoc = txtTennuoc.Text,
                    Gia = int.Parse(txtGiatien.Text),
                    IdTheloai = bustln.getmatheloai(cbLoainuoc.Text)
                };

                if (busnuoc.themNuoc(nc))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
        }

        private void btnSuanuoc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin nước uống này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                NuocUong nc = dgNuocuong.CurrentRow.DataBoundItem as NuocUong;
                nc.TenNuoc = txtTennuoc.Text;
                nc.Gia = int.Parse(txtGiatien.Text);
                nc.IdTheloai = bustln.getmatheloai(cbLoainuoc.Text);

                if (busnuoc.suaNuoc(nc))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
        }

        private void btnXoanuoc_Click(object sender, EventArgs e)
        {

        }

        private void NuocCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtTennuoc.Text = dgNuocuong.Rows[index].Cells["tenNuoc"].Value.ToString();
                txtGiatien.Text = dgNuocuong.Rows[index].Cells["giaTien"].Value.ToString();
                cbLoainuoc.Text = dgNuocuong.Rows[index].Cells["loaiNuoc"].Value.ToString();
            }
        }
    }
}
