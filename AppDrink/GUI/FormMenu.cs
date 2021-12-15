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
        B_Nhanvien busnv = new B_Nhanvien();
        B_Thanhtoan bustt = new B_Thanhtoan();
        double total = 0;
        double thanhtien = 0;
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            loadMenu();
            loadtheloai();
            loadTennv();
        }

        public void loadtheloai()
        {
            bustln.laydanhsachtheloaicb(cbTentl);
        }

        public void loadMenu()
        {
            dgMenu.AutoGenerateColumns = false;
            busnuoc.laydanhsachnuoc(dgMenu);
        }

        //lấy danh sách tên nhân viên
        public void loadTennv()
        {
            busnv.laytennvcb(cbTennv);
        }

        //thoát giao diện menu bán hàng
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //thêm sản phẩm vào giỏ hàng
        private void btnThem_Click(object sender, EventArgs e)
        {
            NuocUong nc = dgMenu.CurrentRow.DataBoundItem as NuocUong;
            String ten = nc.TenNuoc;
            int soluong = int.Parse(txtNumber.Text);
            thanhtien = (double)nc.Gia * soluong;
            this.dgOrder.Rows.Add(ten,soluong,thanhtien);
            total = total + thanhtien;
            lbltotal.Text = total.ToString();
        }

        //thanh toán sản phẩm
        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tiến hành thanh toán đơn hàng này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                HoaDon hd = new HoaDon()
                {
                    IdNhanvien = busnv.getmanv(cbTennv.Text),
                    NgayLap = DateTime.Now,
                    TongCong = total
                };
                if (bustt.thanhtoan(hd))
                {
                    themvaochitiethd();
                    MessageBox.Show("Thanh toán thành công!");
                    lbltotal.Text = "0";
                    dgOrder.Rows.Clear();
                }
                else
                    MessageBox.Show("Thanh toán không thành công");
            }

        }
        //xóa sản phẩm khỏi giỏ hàng và giảm tổng số tiền
        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewCell oneCell in dgOrder.SelectedCells)
            {
                if (oneCell.Selected)
                {
                    thanhtien = (double)dgOrder.Rows[oneCell.RowIndex].Cells["price"].Value;
                    dgOrder.Rows.RemoveAt(oneCell.RowIndex);
                    total = total - thanhtien;
                    lbltotal.Text = total.ToString();
                }             
            }
        }
        //xác nhận input phím là số thì nhập vào ô txtNumber
        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        //khi trỏ từng sản phẩm thì số lượng reset về 1
        private void dgMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumber.Text = "1";
        }

        //filter sản phẩm theo thể loại
        private void cbTentl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            busnuoc.filtertheotl(cbTentl.Text, dgMenu);
        }

        //hiển thị tất cả sản phẩm
        private void btnXemAll_Click(object sender, EventArgs e)
        {
            loadMenu();
        }

        //tạo chi tiết hóa đơn
        public void themvaochitiethd()
        {
            
            for (int i = 0; i < dgOrder.Rows.Count; i++)
            {
                ChiTiethd cthd = new ChiTiethd()
                {
                    IdNuoc = busnuoc.getmanuoc(dgOrder.Rows[i].Cells["namedrink"].Value.ToString()),
                    Soluong = int.Parse(dgOrder.Rows[i].Cells["number"].Value.ToString()),
                    Thanhtien = double.Parse(dgOrder.Rows[i].Cells["price"].Value.ToString()),
                    IdHoadon = bustt.getMahd()
            };
                bustt.chitiethd(cthd);
            }
        }

    }
}
