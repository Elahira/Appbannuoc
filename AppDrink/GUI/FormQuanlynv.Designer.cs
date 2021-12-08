
namespace AppDrink.GUI
{
    partial class FormQuanlynv
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DateNv);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cbGioitinh);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.txtTenNv);
            this.panel1.Controls.Add(this.btnXemnv);
            this.panel1.Controls.Add(this.btnSuanv);
            this.panel1.Controls.Add(this.btnXoanv);
            this.panel1.Controls.Add(this.btnThemnv);
            this.panel1.Controls.Add(this.dgNhanvien);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 488);
            this.panel1.TabIndex = 0;
            // 
            // DateNv
            // 
            this.DateNv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateNv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNv.Location = new System.Drawing.Point(822, 307);
            this.DateNv.Margin = new System.Windows.Forms.Padding(4);
            this.DateNv.Name = "DateNv";
            this.DateNv.Size = new System.Drawing.Size(120, 26);
            this.DateNv.TabIndex = 69;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(728, 372);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(728, 309);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(728, 246);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(728, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 65;
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
            this.cbGioitinh.Location = new System.Drawing.Point(815, 243);
            this.cbGioitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.Size = new System.Drawing.Size(75, 27);
            this.cbGioitinh.TabIndex = 64;
            // 
            // txtSdt
            // 
            this.txtSdt.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(844, 370);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(133, 27);
            this.txtSdt.TabIndex = 63;
            // 
            // txtTenNv
            // 
            this.txtTenNv.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNv.Location = new System.Drawing.Point(796, 179);
            this.txtTenNv.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(181, 27);
            this.txtTenNv.TabIndex = 62;
            // 
            // btnXemnv
            // 
            this.btnXemnv.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemnv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemnv.ForeColor = System.Drawing.Color.Snow;
            this.btnXemnv.Location = new System.Drawing.Point(854, 81);
            this.btnXemnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemnv.Name = "btnXemnv";
            this.btnXemnv.Size = new System.Drawing.Size(87, 42);
            this.btnXemnv.TabIndex = 61;
            this.btnXemnv.Text = "Xem";
            this.btnXemnv.UseVisualStyleBackColor = false;
            // 
            // btnSuanv
            // 
            this.btnSuanv.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuanv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanv.ForeColor = System.Drawing.Color.Snow;
            this.btnSuanv.Location = new System.Drawing.Point(854, 18);
            this.btnSuanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Size = new System.Drawing.Size(87, 42);
            this.btnSuanv.TabIndex = 60;
            this.btnSuanv.Text = "Sửa";
            this.btnSuanv.UseVisualStyleBackColor = false;
            // 
            // btnXoanv
            // 
            this.btnXoanv.BackColor = System.Drawing.Color.Crimson;
            this.btnXoanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoanv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanv.ForeColor = System.Drawing.Color.Snow;
            this.btnXoanv.Location = new System.Drawing.Point(761, 81);
            this.btnXoanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoanv.Name = "btnXoanv";
            this.btnXoanv.Size = new System.Drawing.Size(87, 42);
            this.btnXoanv.TabIndex = 59;
            this.btnXoanv.Text = "Xóa";
            this.btnXoanv.UseVisualStyleBackColor = false;
            // 
            // btnThemnv
            // 
            this.btnThemnv.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemnv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnv.ForeColor = System.Drawing.Color.Snow;
            this.btnThemnv.Location = new System.Drawing.Point(761, 18);
            this.btnThemnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Size = new System.Drawing.Size(87, 42);
            this.btnThemnv.TabIndex = 58;
            this.btnThemnv.Text = "Thêm";
            this.btnThemnv.UseVisualStyleBackColor = false;
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
            this.dgNhanvien.Location = new System.Drawing.Point(15, 55);
            this.dgNhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgNhanvien.Name = "dgNhanvien";
            this.dgNhanvien.ReadOnly = true;
            this.dgNhanvien.Size = new System.Drawing.Size(659, 395);
            this.dgNhanvien.TabIndex = 57;
            // 
            // idnv
            // 
            this.idnv.DataPropertyName = "IdNhanvien";
            this.idnv.HeaderText = "ID";
            this.idnv.Name = "idnv";
            this.idnv.ReadOnly = true;
            this.idnv.Width = 70;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "Hoten";
            this.tennv.HeaderText = "Họ tên";
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            this.tennv.Width = 220;
            // 
            // gioitinhnv
            // 
            this.gioitinhnv.DataPropertyName = "Gioitinh";
            this.gioitinhnv.HeaderText = "Giới tính";
            this.gioitinhnv.Name = "gioitinhnv";
            this.gioitinhnv.ReadOnly = true;
            this.gioitinhnv.Width = 90;
            // 
            // datebirth
            // 
            this.datebirth.DataPropertyName = "NgaySinh";
            this.datebirth.HeaderText = "Ngày sinh";
            this.datebirth.Name = "datebirth";
            this.datebirth.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.DataPropertyName = "DienThoai";
            this.phone.HeaderText = "số điện thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Danh sách nhân viên";
            // 
            // FormQuanlynv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 488);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanlynv";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.FormQuanlynv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanvien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker DateNv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbGioitinh;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.Button btnXemnv;
        private System.Windows.Forms.Button btnSuanv;
        private System.Windows.Forms.Button btnXoanv;
        private System.Windows.Forms.Button btnThemnv;
        private System.Windows.Forms.DataGridView dgNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.Label label5;
    }
}