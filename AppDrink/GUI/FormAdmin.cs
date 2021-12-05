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
        B_Nhanvien busnv = new B_Nhanvien();
        B_Thongke busthongke = new B_Thongke();
        B_Nuocuong busnuoc = new B_Nuocuong();
        B_Theloai bustln = new B_Theloai();
        public FormAdmin()
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
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            hienthitk();
            hienthinhanvien();
            hienthitheloai();
            hienthinuocuong();
            bustln.laydanhsachtheloaicb(cbLoainuoc);
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

        //quản lý nhân viên
        public void hienthinhanvien()
        {
            dgNhanvien.AutoGenerateColumns = false;
            busnv.laydanhsachnhanvien(dgNhanvien);
        }

        private void btnXemNv_Click(object sender, EventArgs e)
        {
            hienthinhanvien();
        }

        //thêm nhân viên mới
        private void btnThemnv_Click(object sender, EventArgs e)
        {
            if (txtTenNv.Text != "" && cbGioitinh.Text != "" && DateNv.Value != null && txtSdt.Text !="")
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
            if (txtTennuoc.Text !="" && txtGiatien.Text !="" && cbLoainuoc.Text !="")
            {
                NuocUong nc = new NuocUong() { 
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
            if (txtTentl.Text !="")
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

            bustln.laydanhsachtheloaicb(cbLoainuoc);
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
            bustln.laydanhsachtheloaicb(cbLoainuoc);
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
            bustln.laydanhsachtheloaicb(cbLoainuoc);
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
