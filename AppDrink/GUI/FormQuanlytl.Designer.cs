
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgTheloainuoc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idtl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Theloainuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnXemloai = new System.Windows.Forms.Button();
            this.btnSualoai = new System.Windows.Forms.Button();
            this.btnXoaloai = new System.Windows.Forms.Button();
            this.txtTentl = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnThemloai = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTheloainuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.dgTheloainuoc);
            this.panel1.Controls.Add(this.btnXemloai);
            this.panel1.Controls.Add(this.btnSualoai);
            this.panel1.Controls.Add(this.btnXoaloai);
            this.panel1.Controls.Add(this.txtTentl);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnThemloai);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(919, 550);
            this.panel1.TabIndex = 0;
            // 
            // dgTheloainuoc
            // 
            this.dgTheloainuoc.AllowUserToAddRows = false;
            this.dgTheloainuoc.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgTheloainuoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgTheloainuoc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgTheloainuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTheloainuoc.BackgroundColor = System.Drawing.Color.White;
            this.dgTheloainuoc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTheloainuoc.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTheloainuoc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTheloainuoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgTheloainuoc.ColumnHeadersHeight = 30;
            this.dgTheloainuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtl,
            this.Theloainuoc});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTheloainuoc.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgTheloainuoc.EnableHeadersVisualStyles = false;
            this.dgTheloainuoc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTheloainuoc.Location = new System.Drawing.Point(18, 65);
            this.dgTheloainuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgTheloainuoc.Name = "dgTheloainuoc";
            this.dgTheloainuoc.ReadOnly = true;
            this.dgTheloainuoc.RowHeadersVisible = false;
            this.dgTheloainuoc.RowTemplate.Height = 45;
            this.dgTheloainuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTheloainuoc.Size = new System.Drawing.Size(554, 392);
            this.dgTheloainuoc.TabIndex = 56;
            this.dgTheloainuoc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTheloainuoc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgTheloainuoc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgTheloainuoc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgTheloainuoc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgTheloainuoc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgTheloainuoc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTheloainuoc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgTheloainuoc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgTheloainuoc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTheloainuoc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgTheloainuoc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgTheloainuoc.ThemeStyle.HeaderStyle.Height = 30;
            this.dgTheloainuoc.ThemeStyle.ReadOnly = true;
            this.dgTheloainuoc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgTheloainuoc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTheloainuoc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTheloainuoc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgTheloainuoc.ThemeStyle.RowsStyle.Height = 45;
            this.dgTheloainuoc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgTheloainuoc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgTheloainuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellTheloai_Click);
            // 
            // idtl
            // 
            this.idtl.DataPropertyName = "IdTheloai";
            this.idtl.HeaderText = "ID";
            this.idtl.Name = "idtl";
            this.idtl.ReadOnly = true;
            // 
            // Theloainuoc
            // 
            this.Theloainuoc.DataPropertyName = "Tentheloai";
            this.Theloainuoc.HeaderText = "Tên thể loại";
            this.Theloainuoc.Name = "Theloainuoc";
            this.Theloainuoc.ReadOnly = true;
            // 
            // btnXemloai
            // 
            this.btnXemloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXemloai.BackColor = System.Drawing.Color.OrangeRed;
            this.btnXemloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemloai.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXemloai.ForeColor = System.Drawing.Color.Snow;
            this.btnXemloai.Location = new System.Drawing.Point(734, 121);
            this.btnXemloai.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXemloai.Name = "btnXemloai";
            this.btnXemloai.Size = new System.Drawing.Size(87, 44);
            this.btnXemloai.TabIndex = 55;
            this.btnXemloai.Text = "Xem";
            this.btnXemloai.UseVisualStyleBackColor = false;
            this.btnXemloai.Click += new System.EventHandler(this.btnXemloai_Click);
            // 
            // btnSualoai
            // 
            this.btnSualoai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSualoai.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSualoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSualoai.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSualoai.ForeColor = System.Drawing.Color.Snow;
            this.btnSualoai.Location = new System.Drawing.Point(734, 65);
            this.btnSualoai.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnSualoai.Name = "btnSualoai";
            this.btnSualoai.Size = new System.Drawing.Size(87, 44);
            this.btnSualoai.TabIndex = 54;
            this.btnSualoai.Text = "Sửa";
            this.btnSualoai.UseVisualStyleBackColor = false;
            this.btnSualoai.Click += new System.EventHandler(this.btnSualoai_Click);
            // 
            // btnXoaloai
            // 
            this.btnXoaloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaloai.BackColor = System.Drawing.Color.Crimson;
            this.btnXoaloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaloai.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaloai.ForeColor = System.Drawing.Color.Snow;
            this.btnXoaloai.Location = new System.Drawing.Point(627, 119);
            this.btnXoaloai.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnXoaloai.Name = "btnXoaloai";
            this.btnXoaloai.Size = new System.Drawing.Size(87, 44);
            this.btnXoaloai.TabIndex = 53;
            this.btnXoaloai.Text = "Xóa";
            this.btnXoaloai.UseVisualStyleBackColor = false;
            this.btnXoaloai.Click += new System.EventHandler(this.btnXoaloai_Click);
            // 
            // txtTentl
            // 
            this.txtTentl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTentl.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTentl.Location = new System.Drawing.Point(627, 274);
            this.txtTentl.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTentl.Name = "txtTentl";
            this.txtTentl.Size = new System.Drawing.Size(195, 30);
            this.txtTentl.TabIndex = 52;
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(651, 241);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(131, 23);
            this.label16.TabIndex = 51;
            this.label16.Text = "Thể loại nước:";
            // 
            // btnThemloai
            // 
            this.btnThemloai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemloai.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemloai.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemloai.ForeColor = System.Drawing.Color.Snow;
            this.btnThemloai.Location = new System.Drawing.Point(627, 65);
            this.btnThemloai.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.btnThemloai.Name = "btnThemloai";
            this.btnThemloai.Size = new System.Drawing.Size(87, 44);
            this.btnThemloai.TabIndex = 50;
            this.btnThemloai.Text = "Thêm";
            this.btnThemloai.UseVisualStyleBackColor = false;
            this.btnThemloai.Click += new System.EventHandler(this.btnThemloai_Click);
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(14, 11);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(185, 23);
            this.label17.TabIndex = 48;
            this.label17.Text = "Danh mục thể loại nước";
            // 
            // FormQuanlytl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 550);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Roboto Cn", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Label label17;
        private Guna.UI2.WinForms.Guna2DataGridView dgTheloainuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtl;
        private System.Windows.Forms.DataGridViewTextBoxColumn Theloainuoc;
    }
}