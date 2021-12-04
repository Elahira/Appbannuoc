
namespace AppDrink.GUI
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listCv = new System.Windows.Forms.ComboBox();
            this.btnXemtk = new System.Windows.Forms.Button();
            this.btnSuatk = new System.Windows.Forms.Button();
            this.btnXoatk = new System.Windows.Forms.Button();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemtk = new System.Windows.Forms.Button();
            this.dgTaikhoan = new System.Windows.Forms.DataGridView();
            this.Idtk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tkuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mkpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DateNv = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbGioitinh = new System.Windows.Forms.ComboBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.btnXemnv = new System.Windows.Forms.Button();
            this.btnSuanv = new System.Windows.Forms.Button();
            this.btnXoanv = new System.Windows.Forms.Button();
            this.btnThemnv = new System.Windows.Forms.Button();
            this.dgNhanvien = new System.Windows.Forms.DataGridView();
            this.idnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cbLoainuoc = new System.Windows.Forms.ComboBox();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.txtTennuoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXemnuoc = new System.Windows.Forms.Button();
            this.btnSuanuoc = new System.Windows.Forms.Button();
            this.btnXoanuoc = new System.Windows.Forms.Button();
            this.btnThemnuoc = new System.Windows.Forms.Button();
            this.dgNuocuong = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            
            this.appbannuocDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Idnuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nuocUongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.theLoaiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.theLoaiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaikhoan)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanvien)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNuocuong)).BeginInit();
            this.menuStrip1.SuspendLayout();
            
            ((System.ComponentModel.ISupportInitialize)(this.appbannuocDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuocUongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.theLoaiBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listCv);
            this.tabPage1.Controls.Add(this.btnXemtk);
            this.tabPage1.Controls.Add(this.btnSuatk);
            this.tabPage1.Controls.Add(this.btnXoatk);
            this.tabPage1.Controls.Add(this.txtMk);
            this.tabPage1.Controls.Add(this.txtTk);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnThemtk);
            this.tabPage1.Controls.Add(this.dgTaikhoan);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage1.Size = new System.Drawing.Size(1002, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quản lý tài khoản";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listCv
            // 
            this.listCv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCv.FormattingEnabled = true;
            this.listCv.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.listCv.Location = new System.Drawing.Point(728, 282);
            this.listCv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.listCv.Name = "listCv";
            this.listCv.Size = new System.Drawing.Size(102, 31);
            this.listCv.TabIndex = 28;
            // 
            // btnXemtk
            // 
            this.btnXemtk.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemtk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemtk.ForeColor = System.Drawing.Color.Snow;
            this.btnXemtk.Location = new System.Drawing.Point(815, 49);
            this.btnXemtk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXemtk.Name = "btnXemtk";
            this.btnXemtk.Size = new System.Drawing.Size(83, 37);
            this.btnXemtk.TabIndex = 27;
            this.btnXemtk.Text = "Xem";
            this.btnXemtk.UseVisualStyleBackColor = false;
            this.btnXemtk.Click += new System.EventHandler(this.btnXemtk_Click);
            // 
            // btnSuatk
            // 
            this.btnSuatk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuatk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuatk.ForeColor = System.Drawing.Color.Snow;
            this.btnSuatk.Location = new System.Drawing.Point(815, 6);
            this.btnSuatk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSuatk.Name = "btnSuatk";
            this.btnSuatk.Size = new System.Drawing.Size(83, 37);
            this.btnSuatk.TabIndex = 26;
            this.btnSuatk.Text = "Sửa";
            this.btnSuatk.UseVisualStyleBackColor = false;
            this.btnSuatk.Click += new System.EventHandler(this.btnSuatk_Click);
            // 
            // btnXoatk
            // 
            this.btnXoatk.BackColor = System.Drawing.Color.Crimson;
            this.btnXoatk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoatk.ForeColor = System.Drawing.Color.Snow;
            this.btnXoatk.Location = new System.Drawing.Point(728, 48);
            this.btnXoatk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(83, 37);
            this.btnXoatk.TabIndex = 25;
            this.btnXoatk.Text = "Xóa";
            this.btnXoatk.UseVisualStyleBackColor = false;
            this.btnXoatk.Click += new System.EventHandler(this.btnXoatk_Click);
            // 
            // txtMk
            // 
            this.txtMk.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(728, 210);
            this.txtMk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(164, 30);
            this.txtMk.TabIndex = 23;
            // 
            // txtTk
            // 
            this.txtTk.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(728, 138);
            this.txtTk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(164, 30);
            this.txtTk.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(625, 286);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 21;
            this.label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(628, 212);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 20;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(625, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 19;
            this.label2.Text = "Tài khoản:";
            // 
            // btnThemtk
            // 
            this.btnThemtk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemtk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemtk.ForeColor = System.Drawing.Color.Snow;
            this.btnThemtk.Location = new System.Drawing.Point(728, 6);
            this.btnThemtk.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThemtk.Name = "btnThemtk";
            this.btnThemtk.Size = new System.Drawing.Size(83, 37);
            this.btnThemtk.TabIndex = 18;
            this.btnThemtk.Text = "Thêm";
            this.btnThemtk.UseVisualStyleBackColor = false;
            this.btnThemtk.Click += new System.EventHandler(this.btnThemtk_Click);
            // 
            // dgTaikhoan
            // 
            this.dgTaikhoan.AllowUserToAddRows = false;
            this.dgTaikhoan.AllowUserToDeleteRows = false;
            this.dgTaikhoan.AllowUserToOrderColumns = true;
            this.dgTaikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idtk,
            this.Tkuser,
            this.Mkpass,
            this.Cvtype});
            this.dgTaikhoan.Location = new System.Drawing.Point(9, 48);
            this.dgTaikhoan.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgTaikhoan.Name = "dgTaikhoan";
            this.dgTaikhoan.Size = new System.Drawing.Size(575, 376);
            this.dgTaikhoan.TabIndex = 17;
            this.dgTaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tk_cellclick);
            // 
            // Idtk
            // 
            this.Idtk.DataPropertyName = "IdTk";
            this.Idtk.HeaderText = "ID";
            this.Idtk.Name = "Idtk";
            this.Idtk.Width = 80;
            // 
            // Tkuser
            // 
            this.Tkuser.DataPropertyName = "Taikhoan";
            this.Tkuser.HeaderText = "Tài khoản";
            this.Tkuser.Name = "Tkuser";
            this.Tkuser.Width = 150;
            // 
            // Mkpass
            // 
            this.Mkpass.DataPropertyName = "Matkhau";
            this.Mkpass.HeaderText = "Mật khẩu";
            this.Mkpass.Name = "Mkpass";
            this.Mkpass.Width = 150;
            // 
            // Cvtype
            // 
            this.Cvtype.DataPropertyName = "Chucvu";
            this.Cvtype.HeaderText = "Chức vụ";
            this.Cvtype.Name = "Cvtype";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 16;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DateNv);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.cbGioitinh);
            this.tabPage2.Controls.Add(this.txtSdt);
            this.tabPage2.Controls.Add(this.txtTenNv);
            this.tabPage2.Controls.Add(this.btnXemnv);
            this.tabPage2.Controls.Add(this.btnSuanv);
            this.tabPage2.Controls.Add(this.btnXoanv);
            this.tabPage2.Controls.Add(this.btnThemnv);
            this.tabPage2.Controls.Add(this.dgNhanvien);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage2.Size = new System.Drawing.Size(1002, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Quản lý nhân viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DateNv
            // 
            this.DateNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNv.Location = new System.Drawing.Point(776, 242);
            this.DateNv.Name = "DateNv";
            this.DateNv.Size = new System.Drawing.Size(118, 26);
            this.DateNv.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(659, 309);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 40;
            this.label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(670, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 39;
            this.label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(676, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 38;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(683, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 37;
            this.label6.Text = "Họ tên:";
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioitinh.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbGioitinh.FormattingEnabled = true;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.Location = new System.Drawing.Point(776, 178);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(69, 27);
            this.cbGioitinh.TabIndex = 36;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(776, 305);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(148, 27);
            this.txtSdt.TabIndex = 35;
            // 
            // txtTenNv
            // 
            this.txtTenNv.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNv.Location = new System.Drawing.Point(776, 114);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(206, 27);
            this.txtTenNv.TabIndex = 32;
            // 
            // btnXemnv
            // 
            this.btnXemnv.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemnv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemnv.ForeColor = System.Drawing.Color.Snow;
            this.btnXemnv.Location = new System.Drawing.Point(849, 50);
            this.btnXemnv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXemnv.Name = "btnXemnv";
            this.btnXemnv.Size = new System.Drawing.Size(83, 37);
            this.btnXemnv.TabIndex = 31;
            this.btnXemnv.Text = "Xem";
            this.btnXemnv.UseVisualStyleBackColor = false;
            this.btnXemnv.Click += new System.EventHandler(this.btnXemNv_Click);
            // 
            // btnSuanv
            // 
            this.btnSuanv.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuanv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanv.ForeColor = System.Drawing.Color.Snow;
            this.btnSuanv.Location = new System.Drawing.Point(849, 7);
            this.btnSuanv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Size = new System.Drawing.Size(83, 37);
            this.btnSuanv.TabIndex = 30;
            this.btnSuanv.Text = "Sửa";
            this.btnSuanv.UseVisualStyleBackColor = false;
            this.btnSuanv.Click += new System.EventHandler(this.btnSuanv_Click);
            // 
            // btnXoanv
            // 
            this.btnXoanv.BackColor = System.Drawing.Color.Crimson;
            this.btnXoanv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanv.ForeColor = System.Drawing.Color.Snow;
            this.btnXoanv.Location = new System.Drawing.Point(762, 50);
            this.btnXoanv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoanv.Name = "btnXoanv";
            this.btnXoanv.Size = new System.Drawing.Size(83, 37);
            this.btnXoanv.TabIndex = 29;
            this.btnXoanv.Text = "Xóa";
            this.btnXoanv.UseVisualStyleBackColor = false;
            this.btnXoanv.Click += new System.EventHandler(this.btnXoanv_Click);
            // 
            // btnThemnv
            // 
            this.btnThemnv.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemnv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnv.ForeColor = System.Drawing.Color.Snow;
            this.btnThemnv.Location = new System.Drawing.Point(762, 7);
            this.btnThemnv.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Size = new System.Drawing.Size(83, 37);
            this.btnThemnv.TabIndex = 28;
            this.btnThemnv.Text = "Thêm";
            this.btnThemnv.UseVisualStyleBackColor = false;
            this.btnThemnv.Click += new System.EventHandler(this.btnThemnv_Click);
            // 
            // dgNhanvien
            // 
            this.dgNhanvien.AllowUserToAddRows = false;
            this.dgNhanvien.AllowUserToDeleteRows = false;
            this.dgNhanvien.AllowUserToOrderColumns = true;
            this.dgNhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnv,
            this.tennv,
            this.gioitinhnv,
            this.datebirth,
            this.phone});
            this.dgNhanvien.Location = new System.Drawing.Point(11, 54);
            this.dgNhanvien.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgNhanvien.Name = "dgNhanvien";
            this.dgNhanvien.Size = new System.Drawing.Size(643, 372);
            this.dgNhanvien.TabIndex = 18;
            this.dgNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanvienCell_Click);
            // 
            // idnv
            // 
            this.idnv.DataPropertyName = "IdNhanvien";
            this.idnv.HeaderText = "ID";
            this.idnv.Name = "idnv";
            this.idnv.Width = 70;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "Hoten";
            this.tennv.HeaderText = "Họ tên";
            this.tennv.Name = "tennv";
            this.tennv.Width = 220;
            // 
            // gioitinhnv
            // 
            this.gioitinhnv.DataPropertyName = "Gioitinh";
            this.gioitinhnv.HeaderText = "Giới tính";
            this.gioitinhnv.Name = "gioitinhnv";
            this.gioitinhnv.Width = 90;
            // 
            // datebirth
            // 
            this.datebirth.DataPropertyName = "NgaySinh";
            this.datebirth.HeaderText = "Ngày sinh";
            this.datebirth.Name = "datebirth";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "DienThoai";
            this.phone.HeaderText = "số điện thoại";
            this.phone.Name = "phone";
            this.phone.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 7);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Danh sách nhân viên";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cbLoainuoc);
            this.tabPage3.Controls.Add(this.txtGiatien);
            this.tabPage3.Controls.Add(this.txtTennuoc);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btnXemnuoc);
            this.tabPage3.Controls.Add(this.btnSuanuoc);
            this.tabPage3.Controls.Add(this.btnXoanuoc);
            this.tabPage3.Controls.Add(this.btnThemnuoc);
            this.tabPage3.Controls.Add(this.dgNuocuong);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage3.Size = new System.Drawing.Size(1002, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Quản lý nước";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cbLoainuoc
            // 
            this.cbLoainuoc.FormattingEnabled = true;
            this.cbLoainuoc.Location = new System.Drawing.Point(740, 354);
            this.cbLoainuoc.Name = "cbLoainuoc";
            this.cbLoainuoc.Size = new System.Drawing.Size(148, 26);
            this.cbLoainuoc.TabIndex = 41;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatien.Location = new System.Drawing.Point(693, 261);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(243, 30);
            this.txtGiatien.TabIndex = 40;
            // 
            // txtTennuoc
            // 
            this.txtTennuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennuoc.Location = new System.Drawing.Point(693, 168);
            this.txtTennuoc.Name = "txtTennuoc";
            this.txtTennuoc.Size = new System.Drawing.Size(243, 30);
            this.txtTennuoc.TabIndex = 39;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(765, 311);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 23);
            this.label13.TabIndex = 38;
            this.label13.Text = "Loại nước:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(774, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 37;
            this.label12.Text = "Giá tiền:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(742, 125);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 23);
            this.label11.TabIndex = 36;
            this.label11.Text = "Tên nước uống:";
            // 
            // btnXemnuoc
            // 
            this.btnXemnuoc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemnuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemnuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnXemnuoc.Location = new System.Drawing.Point(819, 50);
            this.btnXemnuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXemnuoc.Name = "btnXemnuoc";
            this.btnXemnuoc.Size = new System.Drawing.Size(83, 37);
            this.btnXemnuoc.TabIndex = 35;
            this.btnXemnuoc.Text = "Xem";
            this.btnXemnuoc.UseVisualStyleBackColor = false;
            this.btnXemnuoc.Click += new System.EventHandler(this.btnXemnuoc_Click);
            // 
            // btnSuanuoc
            // 
            this.btnSuanuoc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuanuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnSuanuoc.Location = new System.Drawing.Point(819, 7);
            this.btnSuanuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnSuanuoc.Name = "btnSuanuoc";
            this.btnSuanuoc.Size = new System.Drawing.Size(83, 37);
            this.btnSuanuoc.TabIndex = 34;
            this.btnSuanuoc.Text = "Sửa";
            this.btnSuanuoc.UseVisualStyleBackColor = false;
            // 
            // btnXoanuoc
            // 
            this.btnXoanuoc.BackColor = System.Drawing.Color.Crimson;
            this.btnXoanuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnXoanuoc.Location = new System.Drawing.Point(732, 50);
            this.btnXoanuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnXoanuoc.Name = "btnXoanuoc";
            this.btnXoanuoc.Size = new System.Drawing.Size(83, 37);
            this.btnXoanuoc.TabIndex = 33;
            this.btnXoanuoc.Text = "Xóa";
            this.btnXoanuoc.UseVisualStyleBackColor = false;
            // 
            // btnThemnuoc
            // 
            this.btnThemnuoc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemnuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnThemnuoc.Location = new System.Drawing.Point(732, 7);
            this.btnThemnuoc.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnThemnuoc.Name = "btnThemnuoc";
            this.btnThemnuoc.Size = new System.Drawing.Size(83, 37);
            this.btnThemnuoc.TabIndex = 32;
            this.btnThemnuoc.Text = "Thêm";
            this.btnThemnuoc.UseVisualStyleBackColor = false;
            // 
            // dgNuocuong
            // 
            this.dgNuocuong.AllowUserToAddRows = false;
            this.dgNuocuong.AllowUserToDeleteRows = false;
            this.dgNuocuong.AllowUserToOrderColumns = true;
            this.dgNuocuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNuocuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idnuoc,
            this.tenNuoc,
            this.giaTien,
            this.loaiNuoc});
            this.dgNuocuong.Location = new System.Drawing.Point(6, 62);
            this.dgNuocuong.Name = "dgNuocuong";
            this.dgNuocuong.Size = new System.Drawing.Size(612, 386);
            this.dgNuocuong.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 23);
            this.label10.TabIndex = 0;
            this.label10.Text = "Danh sách nước uống";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tabPage4.Size = new System.Drawing.Size(1002, 455);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Danh mục";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem2,
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1010, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêToolStripMenuItem2
            // 
            this.thốngKêToolStripMenuItem2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.thốngKêToolStripMenuItem2.Name = "thốngKêToolStripMenuItem2";
            this.thốngKêToolStripMenuItem2.Size = new System.Drawing.Size(74, 21);
            this.thốngKêToolStripMenuItem2.Text = "Thống kê";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 21);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            
            // 
            // Idnuoc
            // 
            this.Idnuoc.DataPropertyName = "IdNuoc";
            this.Idnuoc.HeaderText = "ID";
            this.Idnuoc.Name = "Idnuoc";
            this.Idnuoc.Width = 70;
            // 
            // tenNuoc
            // 
            this.tenNuoc.DataPropertyName = "TenNuoc";
            this.tenNuoc.HeaderText = "Tên nước uống";
            this.tenNuoc.Name = "tenNuoc";
            this.tenNuoc.Width = 150;
            // 
            // giaTien
            // 
            this.giaTien.DataPropertyName = "Gia";
            this.giaTien.HeaderText = "Giá tiền";
            this.giaTien.Name = "giaTien";
            this.giaTien.Width = 150;
            // 
            // loaiNuoc
            // 
            this.loaiNuoc.DataPropertyName = "Tentheloai";
            this.loaiNuoc.HeaderText = "Loại nước";
            this.loaiNuoc.Name = "loaiNuoc";
            // 
            // nuocUongBindingSource
            // 
            this.nuocUongBindingSource.DataMember = "NuocUong";
            this.nuocUongBindingSource.DataSource = this.appbannuocDataSetBindingSource;
            // 
            
            // 
            // theLoaiBindingSource
            // 
            this.theLoaiBindingSource.DataMember = "TheLoai";
            this.theLoaiBindingSource.DataSource = this.appbannuocDataSetBindingSource;
            // 
            
            // 
            // theLoaiBindingSource1
            // 
            this.theLoaiBindingSource1.DataMember = "TheLoai";
            this.theLoaiBindingSource1.DataSource = this.appbannuocDataSetBindingSource;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 515);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormAdmin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaikhoan)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanvien)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNuocuong)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnXemtk;
        private System.Windows.Forms.Button btnSuatk;
        private System.Windows.Forms.Button btnXoatk;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemtk;
        private System.Windows.Forms.DataGridView dgTaikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox listCv;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgNhanvien;
        private System.Windows.Forms.Button btnXemnv;
        private System.Windows.Forms.Button btnSuanv;
        private System.Windows.Forms.Button btnXoanv;
        private System.Windows.Forms.Button btnThemnv;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tkuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mkpass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cvtype;
        private System.Windows.Forms.DateTimePicker DateNv;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgNuocuong;
        private System.Windows.Forms.Button btnXemnuoc;
        private System.Windows.Forms.Button btnSuanuoc;
        private System.Windows.Forms.Button btnXoanuoc;
        private System.Windows.Forms.Button btnThemnuoc;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTennuoc;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.ComboBox cbLoainuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idnuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiNuoc;
        private System.Windows.Forms.BindingSource appbannuocDataSetBindingSource;
        
        private System.Windows.Forms.BindingSource nuocUongBindingSource;
        
        private System.Windows.Forms.BindingSource theLoaiBindingSource;
        
        private System.Windows.Forms.BindingSource theLoaiBindingSource1;
    }
}