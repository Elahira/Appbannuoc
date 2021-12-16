
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateNv = new System.Windows.Forms.DateTimePicker();
            this.cbGioitinh = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgNhanvien = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinhnv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datebirth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.txtTenNv = new System.Windows.Forms.TextBox();
            this.btnXemnv = new System.Windows.Forms.Button();
            this.btnSuanv = new System.Windows.Forms.Button();
            this.btnXoanv = new System.Windows.Forms.Button();
            this.btnThemnv = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.DateNv);
            this.panel1.Controls.Add(this.cbGioitinh);
            this.panel1.Controls.Add(this.dgNhanvien);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSdt);
            this.panel1.Controls.Add(this.txtTenNv);
            this.panel1.Controls.Add(this.btnXemnv);
            this.panel1.Controls.Add(this.btnSuanv);
            this.panel1.Controls.Add(this.btnXoanv);
            this.panel1.Controls.Add(this.btnThemnv);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1034, 514);
            this.panel1.TabIndex = 0;
            // 
            // DateNv
            // 
            this.DateNv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.DateNv.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateNv.Location = new System.Drawing.Point(792, 356);
            this.DateNv.Name = "DateNv";
            this.DateNv.Size = new System.Drawing.Size(116, 28);
            this.DateNv.TabIndex = 73;
            // 
            // cbGioitinh
            // 
            this.cbGioitinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbGioitinh.BackColor = System.Drawing.Color.Transparent;
            this.cbGioitinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGioitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGioitinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioitinh.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbGioitinh.FocusedState.Parent = this.cbGioitinh;
            this.cbGioitinh.Font = new System.Drawing.Font("Roboto", 12F);
            this.cbGioitinh.ForeColor = System.Drawing.Color.Black;
            this.cbGioitinh.HoverState.Parent = this.cbGioitinh;
            this.cbGioitinh.ItemHeight = 30;
            this.cbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbGioitinh.ItemsAppearance.Parent = this.cbGioitinh;
            this.cbGioitinh.Location = new System.Drawing.Point(792, 285);
            this.cbGioitinh.Name = "cbGioitinh";
            this.cbGioitinh.ShadowDecoration.Parent = this.cbGioitinh;
            this.cbGioitinh.Size = new System.Drawing.Size(109, 36);
            this.cbGioitinh.TabIndex = 72;
            // 
            // dgNhanvien
            // 
            this.dgNhanvien.AllowUserToAddRows = false;
            this.dgNhanvien.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgNhanvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNhanvien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgNhanvien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNhanvien.BackgroundColor = System.Drawing.Color.White;
            this.dgNhanvien.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgNhanvien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNhanvien.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNhanvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgNhanvien.ColumnHeadersHeight = 30;
            this.dgNhanvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idnv,
            this.tennv,
            this.gioitinhnv,
            this.datebirth,
            this.phone});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Cn", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNhanvien.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgNhanvien.EnableHeadersVisualStyles = false;
            this.dgNhanvien.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgNhanvien.Location = new System.Drawing.Point(16, 56);
            this.dgNhanvien.Name = "dgNhanvien";
            this.dgNhanvien.ReadOnly = true;
            this.dgNhanvien.RowHeadersVisible = false;
            this.dgNhanvien.RowTemplate.Height = 45;
            this.dgNhanvien.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNhanvien.Size = new System.Drawing.Size(638, 419);
            this.dgNhanvien.TabIndex = 70;
            this.dgNhanvien.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgNhanvien.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgNhanvien.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgNhanvien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgNhanvien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgNhanvien.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgNhanvien.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgNhanvien.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgNhanvien.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgNhanvien.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNhanvien.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgNhanvien.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgNhanvien.ThemeStyle.HeaderStyle.Height = 30;
            this.dgNhanvien.ThemeStyle.ReadOnly = true;
            this.dgNhanvien.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgNhanvien.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNhanvien.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNhanvien.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgNhanvien.ThemeStyle.RowsStyle.Height = 45;
            this.dgNhanvien.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgNhanvien.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgNhanvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NhanvienCell_Click);
            // 
            // idnv
            // 
            this.idnv.DataPropertyName = "IdNhanvien";
            this.idnv.HeaderText = "ID";
            this.idnv.Name = "idnv";
            this.idnv.ReadOnly = true;
            // 
            // tennv
            // 
            this.tennv.DataPropertyName = "Hoten";
            this.tennv.HeaderText = "Họ tên";
            this.tennv.Name = "tennv";
            this.tennv.ReadOnly = true;
            // 
            // gioitinhnv
            // 
            this.gioitinhnv.DataPropertyName = "Gioitinh";
            this.gioitinhnv.HeaderText = "Giới tính";
            this.gioitinhnv.Name = "gioitinhnv";
            this.gioitinhnv.ReadOnly = true;
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
            this.phone.HeaderText = "Số điện thoại";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(676, 428);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 19);
            this.label9.TabIndex = 68;
            this.label9.Text = "Số điện thoại:";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(698, 362);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 67;
            this.label8.Text = "Ngày sinh:";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(709, 296);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 66;
            this.label7.Text = "Giới tính:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(723, 229);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 65;
            this.label6.Text = "Họ tên:";
            // 
            // txtSdt
            // 
            this.txtSdt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSdt.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSdt.Location = new System.Drawing.Point(792, 426);
            this.txtSdt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(133, 27);
            this.txtSdt.TabIndex = 63;
            // 
            // txtTenNv
            // 
            this.txtTenNv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenNv.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNv.Location = new System.Drawing.Point(792, 225);
            this.txtTenNv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTenNv.Name = "txtTenNv";
            this.txtTenNv.Size = new System.Drawing.Size(181, 27);
            this.txtTenNv.TabIndex = 62;
            // 
            // btnXemnv
            // 
            this.btnXemnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXemnv.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemnv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemnv.ForeColor = System.Drawing.Color.Snow;
            this.btnXemnv.Location = new System.Drawing.Point(854, 122);
            this.btnXemnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemnv.Name = "btnXemnv";
            this.btnXemnv.Size = new System.Drawing.Size(87, 44);
            this.btnXemnv.TabIndex = 61;
            this.btnXemnv.Text = "Xem";
            this.btnXemnv.UseVisualStyleBackColor = false;
            this.btnXemnv.Click += new System.EventHandler(this.btnXemNv_Click);
            // 
            // btnSuanv
            // 
            this.btnSuanv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuanv.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuanv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanv.ForeColor = System.Drawing.Color.Snow;
            this.btnSuanv.Location = new System.Drawing.Point(854, 56);
            this.btnSuanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuanv.Name = "btnSuanv";
            this.btnSuanv.Size = new System.Drawing.Size(87, 44);
            this.btnSuanv.TabIndex = 60;
            this.btnSuanv.Text = "Sửa";
            this.btnSuanv.UseVisualStyleBackColor = false;
            this.btnSuanv.Click += new System.EventHandler(this.btnSuanv_Click);
            // 
            // btnXoanv
            // 
            this.btnXoanv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoanv.BackColor = System.Drawing.Color.Crimson;
            this.btnXoanv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoanv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanv.ForeColor = System.Drawing.Color.Snow;
            this.btnXoanv.Location = new System.Drawing.Point(761, 122);
            this.btnXoanv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoanv.Name = "btnXoanv";
            this.btnXoanv.Size = new System.Drawing.Size(87, 44);
            this.btnXoanv.TabIndex = 59;
            this.btnXoanv.Text = "Xóa";
            this.btnXoanv.UseVisualStyleBackColor = false;
            this.btnXoanv.Click += new System.EventHandler(this.btnXoanv_Click);
            // 
            // btnThemnv
            // 
            this.btnThemnv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemnv.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemnv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemnv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnv.ForeColor = System.Drawing.Color.Snow;
            this.btnThemnv.Location = new System.Drawing.Point(761, 56);
            this.btnThemnv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemnv.Name = "btnThemnv";
            this.btnThemnv.Size = new System.Drawing.Size(87, 44);
            this.btnThemnv.TabIndex = 58;
            this.btnThemnv.Text = "Thêm";
            this.btnThemnv.UseVisualStyleBackColor = false;
            this.btnThemnv.Click += new System.EventHandler(this.btnThemnv_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 23);
            this.label5.TabIndex = 56;
            this.label5.Text = "Danh sách nhân viên";
            // 
            // FormQuanlynv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 514);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Cn", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.TextBox txtTenNv;
        private System.Windows.Forms.Button btnXemnv;
        private System.Windows.Forms.Button btnSuanv;
        private System.Windows.Forms.Button btnXoanv;
        private System.Windows.Forms.Button btnThemnv;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgNhanvien;
        private System.Windows.Forms.DataGridViewTextBoxColumn idnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennv;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinhnv;
        private System.Windows.Forms.DataGridViewTextBoxColumn datebirth;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private Guna.UI2.WinForms.Guna2ComboBox cbGioitinh;
        private System.Windows.Forms.DateTimePicker DateNv;
    }
}