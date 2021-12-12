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
    public partial class FormQuanlynv : Form
    {
        AppbannuocEntities db = new AppbannuocEntities();
        B_Nhanvien busnv = new B_Nhanvien();
        public FormQuanlynv()
        {
            InitializeComponent();
        }
        //load data
        private void FormQuanlynv_Load(object sender, EventArgs e)
        {
            hienthinhanvien();
        }

        //hiển thị nhân viên
        public void hienthinhanvien()
        {
            dgNhanvien.AutoGenerateColumns = false;
            busnv.laydanhsachnhanvien(dgNhanvien);
        }

        //xem danh sách nhân viên
        private void btnXemNv_Click(object sender, EventArgs e)
        {
            hienthinhanvien();
        }

        //thêm nhân viên mới
        private void btnThemnv_Click(object sender, EventArgs e)
        {
            if (txtTenNv.Text != "" && cbGioitinh.Text != "" && DateNv.Value != null && txtSdt.Text != "")
            {
                NhanVien nv = new NhanVien() { Hoten = txtTenNv.Text, Gioitinh = cbGioitinh.Text, NgaySinh = DateNv.Value, DienThoai = txtSdt.Text };
                if (busnv.themNhanvien(nv))
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                    MessageBox.Show("Thêm không thành công");
            }
            else
                MessageBox.Show("Xin hãy nhập đầy đủ thông tin");
        }

        //đổ dữ liệu row vào các box
        private void NhanvienCell_Click(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtTenNv.Text = dgNhanvien.Rows[index].Cells["tennv"].Value.ToString();
                cbGioitinh.Text = dgNhanvien.Rows[index].Cells["gioitinhnv"].Value.ToString();
                DateNv.Text = dgNhanvien.Rows[index].Cells["datebirth"].Value.ToString();
                txtSdt.Text = dgNhanvien.Rows[index].Cells["phone"].Value.ToString();
            }
        }

        //sửa thông tin nhân viên
        private void btnSuanv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa thông tin nhân viên này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                NhanVien nv = dgNhanvien.CurrentRow.DataBoundItem as NhanVien;
                nv.Hoten = txtTenNv.Text;
                nv.Gioitinh = cbGioitinh.Text;
                nv.NgaySinh = DateNv.Value;
                nv.DienThoai = txtSdt.Text;

                if (busnv.suaNhanvien(nv))
                {
                    MessageBox.Show("Sửa thành công!");
                }
                else
                    MessageBox.Show("Sửa không thành công");
            }
        }

        //xóa nhân viên
        private void btnXoanv_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa nhân viên này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                NhanVien nv = dgNhanvien.CurrentRow.DataBoundItem as NhanVien;
                int idnv = nv.IdNhanvien;
                if (busnv.xoaNhanvien(idnv))
                {
                    MessageBox.Show("Xóa thành công!");
                }
                else
                    MessageBox.Show("Xóa không thành công");
            }
        }
    }
}
