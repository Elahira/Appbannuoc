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

        public void loadTennv()
        {
            busnv.laytennvcb(cbTennv);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

        private void btnThanhtoan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tiến hành thanh toán đơn này?", "Thông báo", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                HoaDon hd = new HoaDon()
                {

                    NgayLap = DateTime.Now
                };
                
                if (bustt.thanhtoan(hd))
                {
                    MessageBox.Show("Thanh toán thành công!");
                }
                else
                    MessageBox.Show("Thanh toán không thành công");
            }

        }

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

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void dgMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumber.Text = "1";
        }

        private void cbTentl_SelectionChangeCommitted(object sender, EventArgs e)
        {
            busnuoc.sorttheotl(cbTentl.Text, dgMenu);
        }

        private void btnXemAll_Click(object sender, EventArgs e)
        {
            loadMenu();
        }

    }
}
