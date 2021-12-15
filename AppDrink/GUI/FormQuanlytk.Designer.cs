
namespace AppDrink.GUI
{
    partial class FormQuanlytk
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelChucnang = new System.Windows.Forms.Panel();
            this.dgTaikhoan = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Idtk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tkuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mkpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoatk = new System.Windows.Forms.Button();
            this.btnThemtk = new System.Windows.Forms.Button();
            this.btnXemtk = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSuatk = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMk = new System.Windows.Forms.TextBox();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.listCv = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panelChucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChucnang
            // 
            this.panelChucnang.BackColor = System.Drawing.Color.White;
            this.panelChucnang.Controls.Add(this.listCv);
            this.panelChucnang.Controls.Add(this.dgTaikhoan);
            this.panelChucnang.Controls.Add(this.label1);
            this.panelChucnang.Controls.Add(this.btnXoatk);
            this.panelChucnang.Controls.Add(this.btnThemtk);
            this.panelChucnang.Controls.Add(this.btnXemtk);
            this.panelChucnang.Controls.Add(this.label2);
            this.panelChucnang.Controls.Add(this.btnSuatk);
            this.panelChucnang.Controls.Add(this.label3);
            this.panelChucnang.Controls.Add(this.label4);
            this.panelChucnang.Controls.Add(this.txtMk);
            this.panelChucnang.Controls.Add(this.txtTk);
            this.panelChucnang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChucnang.Location = new System.Drawing.Point(0, 0);
            this.panelChucnang.Margin = new System.Windows.Forms.Padding(4);
            this.panelChucnang.Name = "panelChucnang";
            this.panelChucnang.Size = new System.Drawing.Size(969, 502);
            this.panelChucnang.TabIndex = 41;
            // 
            // dgTaikhoan
            // 
            this.dgTaikhoan.AllowUserToAddRows = false;
            this.dgTaikhoan.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgTaikhoan.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgTaikhoan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgTaikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTaikhoan.BackgroundColor = System.Drawing.Color.White;
            this.dgTaikhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTaikhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTaikhoan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTaikhoan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgTaikhoan.ColumnHeadersHeight = 30;
            this.dgTaikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Idtk,
            this.Tkuser,
            this.Mkpass,
            this.Cvtype});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTaikhoan.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgTaikhoan.EnableHeadersVisualStyles = false;
            this.dgTaikhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTaikhoan.Location = new System.Drawing.Point(16, 43);
            this.dgTaikhoan.Name = "dgTaikhoan";
            this.dgTaikhoan.ReadOnly = true;
            this.dgTaikhoan.RowHeadersVisible = false;
            this.dgTaikhoan.RowTemplate.Height = 45;
            this.dgTaikhoan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTaikhoan.Size = new System.Drawing.Size(594, 398);
            this.dgTaikhoan.TabIndex = 41;
            this.dgTaikhoan.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTaikhoan.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgTaikhoan.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgTaikhoan.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgTaikhoan.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgTaikhoan.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgTaikhoan.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTaikhoan.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgTaikhoan.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgTaikhoan.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTaikhoan.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgTaikhoan.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgTaikhoan.ThemeStyle.HeaderStyle.Height = 30;
            this.dgTaikhoan.ThemeStyle.ReadOnly = true;
            this.dgTaikhoan.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTaikhoan.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTaikhoan.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTaikhoan.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgTaikhoan.ThemeStyle.RowsStyle.Height = 45;
            this.dgTaikhoan.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTaikhoan.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgTaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tk_cellclick);
            // 
            // Idtk
            // 
            this.Idtk.DataPropertyName = "IdTK";
            this.Idtk.HeaderText = "ID";
            this.Idtk.Name = "Idtk";
            this.Idtk.ReadOnly = true;
            // 
            // Tkuser
            // 
            this.Tkuser.DataPropertyName = "Taikhoan";
            this.Tkuser.HeaderText = "Tài khoản";
            this.Tkuser.Name = "Tkuser";
            this.Tkuser.ReadOnly = true;
            // 
            // Mkpass
            // 
            this.Mkpass.DataPropertyName = "Matkhau";
            this.Mkpass.HeaderText = "Mật Khẩu";
            this.Mkpass.Name = "Mkpass";
            this.Mkpass.ReadOnly = true;
            // 
            // Cvtype
            // 
            this.Cvtype.DataPropertyName = "Chucvu";
            this.Cvtype.HeaderText = "Chức vụ";
            this.Cvtype.Name = "Cvtype";
            this.Cvtype.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Danh sách tài khoản";
            // 
            // btnXoatk
            // 
            this.btnXoatk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoatk.BackColor = System.Drawing.Color.Crimson;
            this.btnXoatk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoatk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoatk.ForeColor = System.Drawing.Color.Snow;
            this.btnXoatk.Location = new System.Drawing.Point(713, 104);
            this.btnXoatk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(87, 42);
            this.btnXoatk.TabIndex = 37;
            this.btnXoatk.Text = "Xóa";
            this.btnXoatk.UseVisualStyleBackColor = false;
            this.btnXoatk.Click += new System.EventHandler(this.btnXoatk_Click);
            // 
            // btnThemtk
            // 
            this.btnThemtk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemtk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemtk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemtk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemtk.ForeColor = System.Drawing.Color.Snow;
            this.btnThemtk.Location = new System.Drawing.Point(713, 43);
            this.btnThemtk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemtk.Name = "btnThemtk";
            this.btnThemtk.Size = new System.Drawing.Size(87, 42);
            this.btnThemtk.TabIndex = 31;
            this.btnThemtk.Text = "Thêm";
            this.btnThemtk.UseVisualStyleBackColor = false;
            this.btnThemtk.Click += new System.EventHandler(this.btnThemtk_Click);
            // 
            // btnXemtk
            // 
            this.btnXemtk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXemtk.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemtk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemtk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemtk.ForeColor = System.Drawing.Color.Snow;
            this.btnXemtk.Location = new System.Drawing.Point(802, 106);
            this.btnXemtk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemtk.Name = "btnXemtk";
            this.btnXemtk.Size = new System.Drawing.Size(87, 42);
            this.btnXemtk.TabIndex = 39;
            this.btnXemtk.Text = "Xem";
            this.btnXemtk.UseVisualStyleBackColor = false;
            this.btnXemtk.Click += new System.EventHandler(this.btnXemtk_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tài khoản:";
            // 
            // btnSuatk
            // 
            this.btnSuatk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuatk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuatk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuatk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuatk.ForeColor = System.Drawing.Color.Snow;
            this.btnSuatk.Location = new System.Drawing.Point(802, 43);
            this.btnSuatk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuatk.Name = "btnSuatk";
            this.btnSuatk.Size = new System.Drawing.Size(87, 42);
            this.btnSuatk.TabIndex = 38;
            this.btnSuatk.Text = "Sửa";
            this.btnSuatk.UseVisualStyleBackColor = false;
            this.btnSuatk.Click += new System.EventHandler(this.btnSuatk_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Chức vụ:";
            // 
            // txtMk
            // 
            this.txtMk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMk.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(734, 266);
            this.txtMk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(183, 30);
            this.txtMk.TabIndex = 36;
            // 
            // txtTk
            // 
            this.txtTk.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTk.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(734, 183);
            this.txtTk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(183, 30);
            this.txtTk.TabIndex = 35;
            // 
            // listCv
            // 
            this.listCv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listCv.BackColor = System.Drawing.Color.Transparent;
            this.listCv.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.listCv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCv.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listCv.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.listCv.FocusedState.Parent = this.listCv;
            this.listCv.Font = new System.Drawing.Font("Roboto", 12F);
            this.listCv.ForeColor = System.Drawing.Color.Black;
            this.listCv.HoverState.Parent = this.listCv;
            this.listCv.ItemHeight = 30;
            this.listCv.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.listCv.ItemsAppearance.Parent = this.listCv;
            this.listCv.Location = new System.Drawing.Point(734, 348);
            this.listCv.Name = "listCv";
            this.listCv.ShadowDecoration.Parent = this.listCv;
            this.listCv.Size = new System.Drawing.Size(140, 36);
            this.listCv.TabIndex = 42;
            // 
            // FormQuanlytk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 502);
            this.Controls.Add(this.panelChucnang);
            this.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanlytk";
            this.Text = "Quản lý tài khoản";
            this.Load += new System.EventHandler(this.FormQuanlytk_Load);
            this.panelChucnang.ResumeLayout(false);
            this.panelChucnang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaikhoan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChucnang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoatk;
        private System.Windows.Forms.Button btnThemtk;
        private System.Windows.Forms.Button btnXemtk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSuatk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtTk;
        private Guna.UI2.WinForms.Guna2DataGridView dgTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tkuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mkpass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cvtype;
        private Guna.UI2.WinForms.Guna2ComboBox listCv;
    }
}