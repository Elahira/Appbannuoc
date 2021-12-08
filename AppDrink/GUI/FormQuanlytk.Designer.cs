
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
            this.panelChucnang = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTaikhoan = new System.Windows.Forms.DataGridView();
            this.Idtk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tkuser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mkpass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cvtype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelChucnang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaikhoan)).BeginInit();
            this.SuspendLayout();
            // 
            // listCv
            // 
            this.listCv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listCv.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCv.FormattingEnabled = true;
            this.listCv.Items.AddRange(new object[] {
            "admin",
            "staff"});
            this.listCv.Location = new System.Drawing.Point(738, 349);
            this.listCv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listCv.Name = "listCv";
            this.listCv.Size = new System.Drawing.Size(107, 31);
            this.listCv.TabIndex = 40;
            // 
            // btnXemtk
            // 
            this.btnXemtk.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemtk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemtk.ForeColor = System.Drawing.Color.Snow;
            this.btnXemtk.Location = new System.Drawing.Point(802, 106);
            this.btnXemtk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemtk.Name = "btnXemtk";
            this.btnXemtk.Size = new System.Drawing.Size(83, 44);
            this.btnXemtk.TabIndex = 39;
            this.btnXemtk.Text = "Xem";
            this.btnXemtk.UseVisualStyleBackColor = false;
            this.btnXemtk.Click += new System.EventHandler(this.btnXemtk_Click);
            // 
            // btnSuatk
            // 
            this.btnSuatk.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuatk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuatk.ForeColor = System.Drawing.Color.Snow;
            this.btnSuatk.Location = new System.Drawing.Point(802, 43);
            this.btnSuatk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuatk.Name = "btnSuatk";
            this.btnSuatk.Size = new System.Drawing.Size(83, 44);
            this.btnSuatk.TabIndex = 38;
            this.btnSuatk.Text = "Sửa";
            this.btnSuatk.UseVisualStyleBackColor = false;
            this.btnSuatk.Click += new System.EventHandler(this.btnSuatk_Click);
            // 
            // btnXoatk
            // 
            this.btnXoatk.BackColor = System.Drawing.Color.Crimson;
            this.btnXoatk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoatk.ForeColor = System.Drawing.Color.Snow;
            this.btnXoatk.Location = new System.Drawing.Point(713, 104);
            this.btnXoatk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoatk.Name = "btnXoatk";
            this.btnXoatk.Size = new System.Drawing.Size(83, 44);
            this.btnXoatk.TabIndex = 37;
            this.btnXoatk.Text = "Xóa";
            this.btnXoatk.UseVisualStyleBackColor = false;
            this.btnXoatk.Click += new System.EventHandler(this.btnXoatk_Click);
            // 
            // txtMk
            // 
            this.txtMk.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMk.Location = new System.Drawing.Point(734, 266);
            this.txtMk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMk.Name = "txtMk";
            this.txtMk.Size = new System.Drawing.Size(183, 30);
            this.txtMk.TabIndex = 36;
            // 
            // txtTk
            // 
            this.txtTk.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTk.Location = new System.Drawing.Point(734, 183);
            this.txtTk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(183, 30);
            this.txtTk.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(631, 355);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Chức vụ:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 23);
            this.label3.TabIndex = 33;
            this.label3.Text = "Mật khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(627, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 23);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tài khoản:";
            // 
            // btnThemtk
            // 
            this.btnThemtk.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemtk.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemtk.ForeColor = System.Drawing.Color.Snow;
            this.btnThemtk.Location = new System.Drawing.Point(713, 43);
            this.btnThemtk.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemtk.Name = "btnThemtk";
            this.btnThemtk.Size = new System.Drawing.Size(83, 44);
            this.btnThemtk.TabIndex = 31;
            this.btnThemtk.Text = "Thêm";
            this.btnThemtk.UseVisualStyleBackColor = false;
            this.btnThemtk.Click += new System.EventHandler(this.btnThemtk_Click);
            // 
            // panelChucnang
            // 
            this.panelChucnang.BackColor = System.Drawing.Color.White;
            this.panelChucnang.Controls.Add(this.label1);
            this.panelChucnang.Controls.Add(this.dgTaikhoan);
            this.panelChucnang.Controls.Add(this.btnXoatk);
            this.panelChucnang.Controls.Add(this.listCv);
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
            this.panelChucnang.Size = new System.Drawing.Size(969, 486);
            this.panelChucnang.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 29;
            this.label1.Text = "Danh sách tài khoản";
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
            this.dgTaikhoan.Location = new System.Drawing.Point(12, 52);
            this.dgTaikhoan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgTaikhoan.Name = "dgTaikhoan";
            this.dgTaikhoan.ReadOnly = true;
            this.dgTaikhoan.Size = new System.Drawing.Size(603, 367);
            this.dgTaikhoan.TabIndex = 30;
            this.dgTaikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tk_cellclick);
            // 
            // Idtk
            // 
            this.Idtk.DataPropertyName = "IdTk";
            this.Idtk.HeaderText = "ID";
            this.Idtk.Name = "Idtk";
            this.Idtk.ReadOnly = true;
            this.Idtk.Width = 80;
            // 
            // Tkuser
            // 
            this.Tkuser.DataPropertyName = "Taikhoan";
            this.Tkuser.HeaderText = "Tài khoản";
            this.Tkuser.Name = "Tkuser";
            this.Tkuser.ReadOnly = true;
            this.Tkuser.Width = 150;
            // 
            // Mkpass
            // 
            this.Mkpass.DataPropertyName = "Matkhau";
            this.Mkpass.HeaderText = "Mật khẩu";
            this.Mkpass.Name = "Mkpass";
            this.Mkpass.ReadOnly = true;
            this.Mkpass.Width = 150;
            // 
            // Cvtype
            // 
            this.Cvtype.DataPropertyName = "Chucvu";
            this.Cvtype.HeaderText = "Chức vụ";
            this.Cvtype.Name = "Cvtype";
            this.Cvtype.ReadOnly = true;
            // 
            // FormQuanlytk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 486);
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

        private System.Windows.Forms.ComboBox listCv;
        private System.Windows.Forms.Button btnXemtk;
        private System.Windows.Forms.Button btnSuatk;
        private System.Windows.Forms.Button btnXoatk;
        private System.Windows.Forms.TextBox txtMk;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemtk;
        private System.Windows.Forms.Panel panelChucnang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTaikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idtk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tkuser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mkpass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cvtype;
    }
}