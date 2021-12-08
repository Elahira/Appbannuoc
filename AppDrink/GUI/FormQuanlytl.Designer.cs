
namespace AppDrink.GUI
{
    partial class FormQuanlytl
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
            this.btnXemloai = new System.Windows.Forms.Button();
            this.btnSualoai = new System.Windows.Forms.Button();
            this.btnXoaloai = new System.Windows.Forms.Button();
            this.txtTentl = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnThemloai = new System.Windows.Forms.Button();
            this.dgTheloainuoc = new System.Windows.Forms.DataGridView();
            this.idtl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.theloainuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheloainuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnXemloai);
            this.panel1.Controls.Add(this.btnSualoai);
            this.panel1.Controls.Add(this.btnXoaloai);
            this.panel1.Controls.Add(this.txtTentl);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnThemloai);
            this.panel1.Controls.Add(this.dgTheloainuoc);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(817, 484);
            this.panel1.TabIndex = 0;
            // 
            // btnXemloai
            // 
            this.btnXemloai.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemloai.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemloai.ForeColor = System.Drawing.Color.Snow;
            this.btnXemloai.Location = new System.Drawing.Point(644, 172);
            this.btnXemloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXemloai.Name = "btnXemloai";
            this.btnXemloai.Size = new System.Drawing.Size(81, 43);
            this.btnXemloai.TabIndex = 55;
            this.btnXemloai.Text = "Xem";
            this.btnXemloai.UseVisualStyleBackColor = false;
            this.btnXemloai.Click += new System.EventHandler(this.btnXemloai_Click);
            // 
            // btnSualoai
            // 
            this.btnSualoai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSualoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSualoai.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSualoai.ForeColor = System.Drawing.Color.Snow;
            this.btnSualoai.Location = new System.Drawing.Point(644, 109);
            this.btnSualoai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSualoai.Name = "btnSualoai";
            this.btnSualoai.Size = new System.Drawing.Size(81, 43);
            this.btnSualoai.TabIndex = 54;
            this.btnSualoai.Text = "Sửa";
            this.btnSualoai.UseVisualStyleBackColor = false;
            this.btnSualoai.Click += new System.EventHandler(this.btnSualoai_Click);
            // 
            // btnXoaloai
            // 
            this.btnXoaloai.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaloai.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaloai.ForeColor = System.Drawing.Color.Snow;
            this.btnXoaloai.Location = new System.Drawing.Point(549, 171);
            this.btnXoaloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoaloai.Name = "btnXoaloai";
            this.btnXoaloai.Size = new System.Drawing.Size(81, 43);
            this.btnXoaloai.TabIndex = 53;
            this.btnXoaloai.Text = "Xóa";
            this.btnXoaloai.UseVisualStyleBackColor = false;
            this.btnXoaloai.Click += new System.EventHandler(this.btnXoaloai_Click);
            // 
            // txtTentl
            // 
            this.txtTentl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentl.Location = new System.Drawing.Point(549, 281);
            this.txtTentl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTentl.Name = "txtTentl";
            this.txtTentl.Size = new System.Drawing.Size(174, 30);
            this.txtTentl.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(571, 254);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 23);
            this.label16.TabIndex = 51;
            this.label16.Text = "Thể loại nước:";
            // 
            // btnThemloai
            // 
            this.btnThemloai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemloai.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemloai.ForeColor = System.Drawing.Color.Snow;
            this.btnThemloai.Location = new System.Drawing.Point(549, 109);
            this.btnThemloai.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThemloai.Name = "btnThemloai";
            this.btnThemloai.Size = new System.Drawing.Size(81, 43);
            this.btnThemloai.TabIndex = 50;
            this.btnThemloai.Text = "Thêm";
            this.btnThemloai.UseVisualStyleBackColor = false;
            this.btnThemloai.Click += new System.EventHandler(this.btnThemloai_Click);
            // 
            // dgTheloainuoc
            // 
            this.dgTheloainuoc.AllowUserToAddRows = false;
            this.dgTheloainuoc.AllowUserToDeleteRows = false;
            this.dgTheloainuoc.AllowUserToOrderColumns = true;
            this.dgTheloainuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTheloainuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtl,
            this.theloainuoc});
            this.dgTheloainuoc.Location = new System.Drawing.Point(12, 53);
            this.dgTheloainuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgTheloainuoc.Name = "dgTheloainuoc";
            this.dgTheloainuoc.ReadOnly = true;
            this.dgTheloainuoc.Size = new System.Drawing.Size(473, 375);
            this.dgTheloainuoc.TabIndex = 49;
            this.dgTheloainuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellTheloai_Click);
            // 
            // idtl
            // 
            this.idtl.DataPropertyName = "IdTheloai";
            this.idtl.HeaderText = "ID";
            this.idtl.Name = "idtl";
            this.idtl.ReadOnly = true;
            // 
            // theloainuoc
            // 
            this.theloainuoc.DataPropertyName = "TenTheLoai";
            this.theloainuoc.HeaderText = "Tên thể loại";
            this.theloainuoc.Name = "theloainuoc";
            this.theloainuoc.ReadOnly = true;
            this.theloainuoc.Width = 120;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(12, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 23);
            this.label17.TabIndex = 48;
            this.label17.Text = "Danh mục thể loại nước";
            // 
            // FormQuanlytl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 484);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormQuanlytl";
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.FormQuanlytl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheloainuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnXemloai;
        private System.Windows.Forms.Button btnSualoai;
        private System.Windows.Forms.Button btnXoaloai;
        private System.Windows.Forms.TextBox txtTentl;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnThemloai;
        private System.Windows.Forms.DataGridView dgTheloainuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn theloainuoc;
        private System.Windows.Forms.Label label17;
    }
}