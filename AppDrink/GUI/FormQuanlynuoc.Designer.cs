
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbLoainuoc = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dgNuocuong = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loaiNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtGiatien = new System.Windows.Forms.TextBox();
            this.txtTennuoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnXemnuoc = new System.Windows.Forms.Button();
            this.btnSuanuoc = new System.Windows.Forms.Button();
            this.btnXoanuoc = new System.Windows.Forms.Button();
            this.btnThemnuoc = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgNuocuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.cbLoainuoc);
            this.panel1.Controls.Add(this.dgNuocuong);
            this.panel1.Controls.Add(this.txtGiatien);
            this.panel1.Controls.Add(this.txtTennuoc);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.btnXemnuoc);
            this.panel1.Controls.Add(this.btnSuanuoc);
            this.panel1.Controls.Add(this.btnXoanuoc);
            this.panel1.Controls.Add(this.btnThemnuoc);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1014, 597);
            this.panel1.TabIndex = 0;
            // 
            // cbLoainuoc
            // 
            this.cbLoainuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbLoainuoc.BackColor = System.Drawing.Color.Transparent;
            this.cbLoainuoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoainuoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoainuoc.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoainuoc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbLoainuoc.FocusedState.Parent = this.cbLoainuoc;
            this.cbLoainuoc.Font = new System.Drawing.Font("Roboto", 12F);
            this.cbLoainuoc.ForeColor = System.Drawing.Color.Black;
            this.cbLoainuoc.HoverState.Parent = this.cbLoainuoc;
            this.cbLoainuoc.ItemHeight = 30;
            this.cbLoainuoc.ItemsAppearance.Parent = this.cbLoainuoc;
            this.cbLoainuoc.Location = new System.Drawing.Point(760, 497);
            this.cbLoainuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbLoainuoc.Name = "cbLoainuoc";
            this.cbLoainuoc.ShadowDecoration.Parent = this.cbLoainuoc;
            this.cbLoainuoc.Size = new System.Drawing.Size(175, 36);
            this.cbLoainuoc.TabIndex = 67;
            // 
            // dgNuocuong
            // 
            this.dgNuocuong.AllowUserToAddRows = false;
            this.dgNuocuong.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgNuocuong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNuocuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgNuocuong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNuocuong.BackgroundColor = System.Drawing.Color.White;
            this.dgNuocuong.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgNuocuong.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNuocuong.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgNuocuong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgNuocuong.ColumnHeadersHeight = 30;
            this.dgNuocuong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgNuocuong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNuoc,
            this.tenNuoc,
            this.giaTien,
            this.loaiNuoc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgNuocuong.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgNuocuong.EnableHeadersVisualStyles = false;
            this.dgNuocuong.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgNuocuong.Location = new System.Drawing.Point(17, 58);
            this.dgNuocuong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgNuocuong.Name = "dgNuocuong";
            this.dgNuocuong.ReadOnly = true;
            this.dgNuocuong.RowHeadersVisible = false;
            this.dgNuocuong.RowTemplate.Height = 45;
            this.dgNuocuong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNuocuong.Size = new System.Drawing.Size(668, 482);
            this.dgNuocuong.TabIndex = 66;
            this.dgNuocuong.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgNuocuong.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgNuocuong.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgNuocuong.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgNuocuong.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgNuocuong.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgNuocuong.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgNuocuong.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgNuocuong.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgNuocuong.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNuocuong.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgNuocuong.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgNuocuong.ThemeStyle.HeaderStyle.Height = 30;
            this.dgNuocuong.ThemeStyle.ReadOnly = true;
            this.dgNuocuong.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgNuocuong.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgNuocuong.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgNuocuong.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgNuocuong.ThemeStyle.RowsStyle.Height = 45;
            this.dgNuocuong.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgNuocuong.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgNuocuong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NuocCell_Click);
            // 
            // idNuoc
            // 
            this.idNuoc.DataPropertyName = "IdNuoc";
            this.idNuoc.FillWeight = 90F;
            this.idNuoc.HeaderText = "ID";
            this.idNuoc.Name = "idNuoc";
            this.idNuoc.ReadOnly = true;
            // 
            // tenNuoc
            // 
            this.tenNuoc.DataPropertyName = "TenNuoc";
            this.tenNuoc.HeaderText = "Nước";
            this.tenNuoc.Name = "tenNuoc";
            this.tenNuoc.ReadOnly = true;
            // 
            // giaTien
            // 
            this.giaTien.DataPropertyName = "Gia";
            this.giaTien.HeaderText = "Giá";
            this.giaTien.Name = "giaTien";
            this.giaTien.ReadOnly = true;
            // 
            // loaiNuoc
            // 
            this.loaiNuoc.DataPropertyName = "Tentheloai";
            this.loaiNuoc.HeaderText = "Loại nước";
            this.loaiNuoc.Name = "loaiNuoc";
            this.loaiNuoc.ReadOnly = true;
            // 
            // txtGiatien
            // 
            this.txtGiatien.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGiatien.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiatien.Location = new System.Drawing.Point(729, 392);
            this.txtGiatien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtGiatien.Name = "txtGiatien";
            this.txtGiatien.Size = new System.Drawing.Size(220, 30);
            this.txtGiatien.TabIndex = 64;
            // 
            // txtTennuoc
            // 
            this.txtTennuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTennuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTennuoc.Location = new System.Drawing.Point(729, 268);
            this.txtTennuoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTennuoc.Name = "txtTennuoc";
            this.txtTennuoc.Size = new System.Drawing.Size(220, 30);
            this.txtTennuoc.TabIndex = 63;
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(793, 459);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 23);
            this.label13.TabIndex = 62;
            this.label13.Text = "Loại nước:";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(803, 334);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 23);
            this.label12.TabIndex = 61;
            this.label12.Text = "Giá tiền:";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(767, 210);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 23);
            this.label11.TabIndex = 60;
            this.label11.Text = "Tên nước uống:";
            // 
            // btnXemnuoc
            // 
            this.btnXemnuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXemnuoc.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemnuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemnuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemnuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnXemnuoc.Location = new System.Drawing.Point(837, 112);
            this.btnXemnuoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXemnuoc.Name = "btnXemnuoc";
            this.btnXemnuoc.Size = new System.Drawing.Size(87, 44);
            this.btnXemnuoc.TabIndex = 59;
            this.btnXemnuoc.Text = "Xem";
            this.btnXemnuoc.UseVisualStyleBackColor = false;
            this.btnXemnuoc.Click += new System.EventHandler(this.btnXemnuoc_Click);
            // 
            // btnSuanuoc
            // 
            this.btnSuanuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuanuoc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuanuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuanuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuanuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnSuanuoc.Location = new System.Drawing.Point(837, 58);
            this.btnSuanuoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSuanuoc.Name = "btnSuanuoc";
            this.btnSuanuoc.Size = new System.Drawing.Size(87, 44);
            this.btnSuanuoc.TabIndex = 58;
            this.btnSuanuoc.Text = "Sửa";
            this.btnSuanuoc.UseVisualStyleBackColor = false;
            this.btnSuanuoc.Click += new System.EventHandler(this.btnSuanuoc_Click);
            // 
            // btnXoanuoc
            // 
            this.btnXoanuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoanuoc.BackColor = System.Drawing.Color.Crimson;
            this.btnXoanuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoanuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoanuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnXoanuoc.Location = new System.Drawing.Point(744, 112);
            this.btnXoanuoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXoanuoc.Name = "btnXoanuoc";
            this.btnXoanuoc.Size = new System.Drawing.Size(87, 44);
            this.btnXoanuoc.TabIndex = 57;
            this.btnXoanuoc.Text = "Xóa";
            this.btnXoanuoc.UseVisualStyleBackColor = false;
            this.btnXoanuoc.Click += new System.EventHandler(this.btnXoanuoc_Click);
            // 
            // btnThemnuoc
            // 
            this.btnThemnuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemnuoc.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemnuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemnuoc.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemnuoc.ForeColor = System.Drawing.Color.Snow;
            this.btnThemnuoc.Location = new System.Drawing.Point(744, 58);
            this.btnThemnuoc.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnThemnuoc.Name = "btnThemnuoc";
            this.btnThemnuoc.Size = new System.Drawing.Size(87, 44);
            this.btnThemnuoc.TabIndex = 56;
            this.btnThemnuoc.Text = "Thêm";
            this.btnThemnuoc.UseVisualStyleBackColor = false;
            this.btnThemnuoc.Click += new System.EventHandler(this.btnThemnuoc_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 10);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(168, 23);
            this.label10.TabIndex = 54;
            this.label10.Text = "Danh sách nước uống";
            // 
            // FormQuanlynuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 597);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.TextBox txtGiatien;
        private System.Windows.Forms.TextBox txtTennuoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnXemnuoc;
        private System.Windows.Forms.Button btnSuanuoc;
        private System.Windows.Forms.Button btnXoanuoc;
        private System.Windows.Forms.Button btnThemnuoc;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2DataGridView dgNuocuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn loaiNuoc;
        private Guna.UI2.WinForms.Guna2ComboBox cbLoainuoc;
    }
}