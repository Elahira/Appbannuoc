
namespace AppDrink.GUI
{
    partial class FormQuanlynuoc
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
            this.Idnuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNuocuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.cbLoainuoc);
            this.panel1.Controls.Add(this.txtGiatien);
            this.panel1.Controls.Add(this.txtTennuoc);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnXemnuoc);
            this.panel1.Controls.Add(this.btnSuanuoc);
            this.panel1.Controls.Add(this.btnXoanuoc);
            this.panel1.Controls.Add(this.btnThemnuoc);
            this.panel1.Controls.Add(this.dgNuocuong);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1003, 520);
            this.panel1.TabIndex = 0;
            // 
            // cbLoainuoc
            // 
            this.cbLoainuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoainuoc.FormattingEnabled = true;
            this.cbLoainuoc.Location = new System.Drawing.Point(743, 428);
            this.cbLoainuoc.Margin = new System.Windows.Forms.Padding(4);
            this.cbLoainuoc.Name = "cbLoainuoc";
            this.cbLoainuoc.Size = new System.Drawing.Size(110, 27);
            this.cbLoainuoc.TabIndex = 65;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatien.Location = new System.Drawing.Point(680, 325);
            this.txtGiatien.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(236, 30);
            this.txtGiatien.TabIndex = 64;
            // 
            // txtTennuoc
            // 
            this.txtTennuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennuoc.Location = new System.Drawing.Point(680, 222);
            this.txtTennuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTennuoc.Name = "txtTennuoc";
            this.txtTennuoc.Size = new System.Drawing.Size(236, 30);
            this.txtTennuoc.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(749, 380);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 23);
            this.label13.TabIndex = 62;
            this.label13.Text = "Loại nước:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(758, 277);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 61;
            this.label12.Text = "Giá tiền:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(726, 174);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 23);
            this.label11.TabIndex = 60;
            this.label11.Text = "Tên nước uống:";
            // 
            // btnXemnuoc
            // 
            this.btnXemnuoc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemnuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemnuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnXemnuoc.Location = new System.Drawing.Point(799, 112);
            this.btnXemnuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemnuoc.Name = "btnXemnuoc";
            this.btnXemnuoc.Size = new System.Drawing.Size(87, 38);
            this.btnXemnuoc.TabIndex = 59;
            this.btnXemnuoc.Text = "Xem";
            this.btnXemnuoc.UseVisualStyleBackColor = false;
            this.btnXemnuoc.Click += new System.EventHandler(this.btnXemnuoc_Click);
            // 
            // btnSuanuoc
            // 
            this.btnSuanuoc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuanuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnSuanuoc.Location = new System.Drawing.Point(799, 49);
            this.btnSuanuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSuanuoc.Name = "btnSuanuoc";
            this.btnSuanuoc.Size = new System.Drawing.Size(87, 38);
            this.btnSuanuoc.TabIndex = 58;
            this.btnSuanuoc.Text = "Sửa";
            this.btnSuanuoc.UseVisualStyleBackColor = false;
            this.btnSuanuoc.Click += new System.EventHandler(this.btnSuanuoc_Click);
            // 
            // btnXoanuoc
            // 
            this.btnXoanuoc.BackColor = System.Drawing.Color.Crimson;
            this.btnXoanuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnXoanuoc.Location = new System.Drawing.Point(706, 112);
            this.btnXoanuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoanuoc.Name = "btnXoanuoc";
            this.btnXoanuoc.Size = new System.Drawing.Size(87, 38);
            this.btnXoanuoc.TabIndex = 57;
            this.btnXoanuoc.Text = "Xóa";
            this.btnXoanuoc.UseVisualStyleBackColor = false;
            this.btnXoanuoc.Click += new System.EventHandler(this.btnXoanuoc_Click);
            // 
            // btnThemnuoc
            // 
            this.btnThemnuoc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemnuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnThemnuoc.Location = new System.Drawing.Point(706, 49);
            this.btnThemnuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemnuoc.Name = "btnThemnuoc";
            this.btnThemnuoc.Size = new System.Drawing.Size(87, 38);
            this.btnThemnuoc.TabIndex = 56;
            this.btnThemnuoc.Text = "Thêm";
            this.btnThemnuoc.UseVisualStyleBackColor = false;
            this.btnThemnuoc.Click += new System.EventHandler(this.btnThemnuoc_Click);
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
            this.dgNuocuong.Location = new System.Drawing.Point(22, 57);
            this.dgNuocuong.Margin = new System.Windows.Forms.Padding(4);
            this.dgNuocuong.Name = "dgNuocuong";
            this.dgNuocuong.ReadOnly = true;
            this.dgNuocuong.Size = new System.Drawing.Size(622, 405);
            this.dgNuocuong.TabIndex = 55;
            this.dgNuocuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NuocCell_Click);
            // 
            // Idnuoc
            // 
            this.Idnuoc.DataPropertyName = "IdNuoc";
            this.Idnuoc.HeaderText = "ID";
            this.Idnuoc.Name = "Idnuoc";
            this.Idnuoc.ReadOnly = true;
            this.Idnuoc.Width = 70;
            // 
            // tenNuoc
            // 
            this.tenNuoc.DataPropertyName = "TenNuoc";
            this.tenNuoc.HeaderText = "Tên nước uống";
            this.tenNuoc.Name = "tenNuoc";
            this.tenNuoc.ReadOnly = true;
            this.tenNuoc.Width = 150;
            // 
            // giaTien
            // 
            this.giaTien.DataPropertyName = "Gia";
            this.giaTien.HeaderText = "Giá tiền";
            this.giaTien.Name = "giaTien";
            this.giaTien.ReadOnly = true;
            this.giaTien.Width = 150;
            // 
            // loaiNuoc
            // 
            this.loaiNuoc.DataPropertyName = "Tentheloai";
            this.loaiNuoc.HeaderText = "Loại nước";
            this.loaiNuoc.Name = "loaiNuoc";
            this.loaiNuoc.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 9);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 23);
            this.label10.TabIndex = 54;
            this.label10.Text = "Danh sách nước uống";
            // 
            // FormQuanlynuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 520);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormQuanlynuoc";
            this.Text = "Nước uống";
            this.Load += new System.EventHandler(this.FormQuanlynuoc_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNuocuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbLoainuoc;
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.TextBox txtTennuoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXemnuoc;
        private System.Windows.Forms.Button btnSuanuoc;
        private System.Windows.Forms.Button btnXoanuoc;
        private System.Windows.Forms.Button btnThemnuoc;
        private System.Windows.Forms.DataGridView dgNuocuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Idnuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiNuoc;
        private System.Windows.Forms.Label label10;
    }
}