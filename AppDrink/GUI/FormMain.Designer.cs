
namespace AppDrink.GUI
{
    partial class FormMain
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnThongke = new FontAwesome.Sharp.IconButton();
            this.btnTheloai = new FontAwesome.Sharp.IconButton();
            this.btnNuoc = new FontAwesome.Sharp.IconButton();
            this.btnNhanvien = new FontAwesome.Sharp.IconButton();
            this.btnTaikhoan = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.TitleChild = new System.Windows.Forms.Label();
            this.iconCurrentChild = new FontAwesome.Sharp.IconPictureBox();
            this.iconBtnMenu = new FontAwesome.Sharp.IconButton();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(146)))), ((int)(((byte)(248)))));
            this.panelMenu.Controls.Add(this.iconButton1);
            this.panelMenu.Controls.Add(this.btnThongke);
            this.panelMenu.Controls.Add(this.btnTheloai);
            this.panelMenu.Controls.Add(this.btnNuoc);
            this.panelMenu.Controls.Add(this.btnNhanvien);
            this.panelMenu.Controls.Add(this.btnTaikhoan);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 582);
            this.panelMenu.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(93)))), ((int)(((byte)(186)))));
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(63)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 531);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 51);
            this.iconButton1.TabIndex = 3;
            this.iconButton1.Text = "Thoát";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.btnThoat);
            // 
            // btnThongke
            // 
            this.btnThongke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnThongke.FlatAppearance.BorderSize = 0;
            this.btnThongke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThongke.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.SeaShell;
            this.btnThongke.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnThongke.IconColor = System.Drawing.Color.SeaShell;
            this.btnThongke.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThongke.IconSize = 40;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.Location = new System.Drawing.Point(0, 360);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(200, 65);
            this.btnThongke.TabIndex = 5;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThongke.UseVisualStyleBackColor = true;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnTheloai
            // 
            this.btnTheloai.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTheloai.FlatAppearance.BorderSize = 0;
            this.btnTheloai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTheloai.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTheloai.ForeColor = System.Drawing.Color.SeaShell;
            this.btnTheloai.IconChar = FontAwesome.Sharp.IconChar.Tags;
            this.btnTheloai.IconColor = System.Drawing.Color.SeaShell;
            this.btnTheloai.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTheloai.IconSize = 40;
            this.btnTheloai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheloai.Location = new System.Drawing.Point(0, 295);
            this.btnTheloai.Name = "btnTheloai";
            this.btnTheloai.Size = new System.Drawing.Size(200, 65);
            this.btnTheloai.TabIndex = 4;
            this.btnTheloai.Text = "Danh mục";
            this.btnTheloai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTheloai.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTheloai.UseVisualStyleBackColor = true;
            this.btnTheloai.Click += new System.EventHandler(this.btnTheloai_Click);
            // 
            // btnNuoc
            // 
            this.btnNuoc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuoc.FlatAppearance.BorderSize = 0;
            this.btnNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuoc.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuoc.ForeColor = System.Drawing.Color.SeaShell;
            this.btnNuoc.IconChar = FontAwesome.Sharp.IconChar.Coffee;
            this.btnNuoc.IconColor = System.Drawing.Color.SeaShell;
            this.btnNuoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuoc.IconSize = 40;
            this.btnNuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuoc.Location = new System.Drawing.Point(0, 230);
            this.btnNuoc.Name = "btnNuoc";
            this.btnNuoc.Size = new System.Drawing.Size(200, 65);
            this.btnNuoc.TabIndex = 3;
            this.btnNuoc.Text = "Nước uống";
            this.btnNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuoc.UseVisualStyleBackColor = true;
            this.btnNuoc.Click += new System.EventHandler(this.btnNuoc_Click);
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanvien.FlatAppearance.BorderSize = 0;
            this.btnNhanvien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanvien.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.SeaShell;
            this.btnNhanvien.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnNhanvien.IconColor = System.Drawing.Color.SeaShell;
            this.btnNhanvien.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNhanvien.IconSize = 40;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.Location = new System.Drawing.Point(0, 165);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(200, 65);
            this.btnNhanvien.TabIndex = 2;
            this.btnNhanvien.Text = "Quản lý nhân viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click);
            // 
            // btnTaikhoan
            // 
            this.btnTaikhoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaikhoan.FlatAppearance.BorderSize = 0;
            this.btnTaikhoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaikhoan.Font = new System.Drawing.Font("Roboto Bk", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaikhoan.ForeColor = System.Drawing.Color.SeaShell;
            this.btnTaikhoan.IconChar = FontAwesome.Sharp.IconChar.AddressCard;
            this.btnTaikhoan.IconColor = System.Drawing.Color.SeaShell;
            this.btnTaikhoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTaikhoan.IconSize = 40;
            this.btnTaikhoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaikhoan.Location = new System.Drawing.Point(0, 100);
            this.btnTaikhoan.Name = "btnTaikhoan";
            this.btnTaikhoan.Size = new System.Drawing.Size(200, 65);
            this.btnTaikhoan.TabIndex = 1;
            this.btnTaikhoan.Text = "Quản lý tài khoản";
            this.btnTaikhoan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTaikhoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTaikhoan.UseVisualStyleBackColor = true;
            this.btnTaikhoan.Click += new System.EventHandler(this.btnTaikhoan_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(93)))), ((int)(((byte)(186)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::AppDrink.Properties.Resources.drinkicon1;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(146)))), ((int)(((byte)(248)))));
            this.panelTitle.Controls.Add(this.TitleChild);
            this.panelTitle.Controls.Add(this.iconCurrentChild);
            this.panelTitle.Controls.Add(this.iconBtnMenu);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(200, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(1096, 76);
            this.panelTitle.TabIndex = 1;
            this.panelTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitle_MouseDown);
            // 
            // TitleChild
            // 
            this.TitleChild.AutoSize = true;
            this.TitleChild.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleChild.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.TitleChild.Location = new System.Drawing.Point(56, 33);
            this.TitleChild.Name = "TitleChild";
            this.TitleChild.Size = new System.Drawing.Size(51, 19);
            this.TitleChild.TabIndex = 2;
            this.TitleChild.Text = "Home";
            // 
            // iconCurrentChild
            // 
            this.iconCurrentChild.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.iconCurrentChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(146)))), ((int)(((byte)(248)))));
            this.iconCurrentChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.iconCurrentChild.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChild.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.iconCurrentChild.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChild.IconSize = 41;
            this.iconCurrentChild.Location = new System.Drawing.Point(6, 21);
            this.iconCurrentChild.Name = "iconCurrentChild";
            this.iconCurrentChild.Size = new System.Drawing.Size(44, 41);
            this.iconCurrentChild.TabIndex = 1;
            this.iconCurrentChild.TabStop = false;
            // 
            // iconBtnMenu
            // 
            this.iconBtnMenu.BackColor = System.Drawing.Color.CornflowerBlue;
            this.iconBtnMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.iconBtnMenu.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnMenu.FlatAppearance.BorderSize = 0;
            this.iconBtnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnMenu.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconBtnMenu.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.iconBtnMenu.IconChar = FontAwesome.Sharp.IconChar.Store;
            this.iconBtnMenu.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(50)))), ((int)(((byte)(90)))));
            this.iconBtnMenu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnMenu.Location = new System.Drawing.Point(991, 0);
            this.iconBtnMenu.Name = "iconBtnMenu";
            this.iconBtnMenu.Size = new System.Drawing.Size(105, 76);
            this.iconBtnMenu.TabIndex = 0;
            this.iconBtnMenu.Text = "Menu";
            this.iconBtnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnMenu.UseVisualStyleBackColor = true;
            this.iconBtnMenu.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.AliceBlue;
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(200, 76);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1096, 506);
            this.panelDesktop.TabIndex = 2;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 582);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitle);
            this.Controls.Add(this.panelMenu);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnTaikhoan;
        private FontAwesome.Sharp.IconButton btnThongke;
        private FontAwesome.Sharp.IconButton btnTheloai;
        private FontAwesome.Sharp.IconButton btnNuoc;
        private FontAwesome.Sharp.IconButton btnNhanvien;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconBtnMenu;
        private System.Windows.Forms.Label TitleChild;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChild;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panelDesktop;
    }
}