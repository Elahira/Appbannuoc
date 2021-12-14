
namespace AppDrink.GUI
{
    partial class FormMenu
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbTentl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelTong = new Guna.UI2.WinForms.Guna2Panel();
            this.tien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.dgMenu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.namedrink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.panelTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.iconButton2);
            this.guna2Panel1.Controls.Add(this.cbTentl);
            this.guna2Panel1.Controls.Add(this.iconButton1);
            this.guna2Panel1.Controls.Add(this.panelTong);
            this.guna2Panel1.Controls.Add(this.dgMenu);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(819, 538);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cbTentl
            // 
            this.cbTentl.BackColor = System.Drawing.Color.Transparent;
            this.cbTentl.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTentl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTentl.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTentl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbTentl.FocusedState.Parent = this.cbTentl;
            this.cbTentl.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTentl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbTentl.HoverState.Parent = this.cbTentl;
            this.cbTentl.ItemHeight = 30;
            this.cbTentl.ItemsAppearance.Parent = this.cbTentl;
            this.cbTentl.Location = new System.Drawing.Point(74, 70);
            this.cbTentl.Name = "cbTentl";
            this.cbTentl.ShadowDecoration.Parent = this.cbTentl;
            this.cbTentl.Size = new System.Drawing.Size(168, 36);
            this.cbTentl.TabIndex = 23;
            this.cbTentl.SelectedIndexChanged += new System.EventHandler(this.cbTentl_SelectedIndexChanged);
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(427, 63);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(84, 43);
            this.iconButton2.TabIndex = 26;
            this.iconButton2.Text = "Xóa";
            this.iconButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(236)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(337, 63);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(84, 43);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.Text = "Thêm";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // panelTong
            // 
            this.panelTong.BackColor = System.Drawing.Color.White;
            this.panelTong.Controls.Add(this.tien);
            this.panelTong.Controls.Add(this.label2);
            this.panelTong.Controls.Add(this.btnThanhtoan);
            this.panelTong.Location = new System.Drawing.Point(328, 391);
            this.panelTong.Margin = new System.Windows.Forms.Padding(4);
            this.panelTong.Name = "panelTong";
            this.panelTong.ShadowDecoration.Parent = this.panelTong;
            this.panelTong.Size = new System.Drawing.Size(463, 119);
            this.panelTong.TabIndex = 17;
            // 
            // tien
            // 
            this.tien.AutoSize = true;
            this.tien.Location = new System.Drawing.Point(93, 15);
            this.tien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tien.Name = "tien";
            this.tien.Size = new System.Drawing.Size(33, 19);
            this.tien.TabIndex = 1;
            this.tien.Text = "tien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tổng cộng:";
            // 
            // btnThanhtoan
            // 
            this.btnThanhtoan.Animated = true;
            this.btnThanhtoan.CheckedState.Parent = this.btnThanhtoan;
            this.btnThanhtoan.CustomImages.Parent = this.btnThanhtoan;
            this.btnThanhtoan.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhtoan.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThanhtoan.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThanhtoan.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThanhtoan.DisabledState.Parent = this.btnThanhtoan;
            this.btnThanhtoan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThanhtoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThanhtoan.Font = new System.Drawing.Font("Roboto Cn", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnThanhtoan.ForeColor = System.Drawing.Color.White;
            this.btnThanhtoan.HoverState.Parent = this.btnThanhtoan;
            this.btnThanhtoan.Location = new System.Drawing.Point(0, 53);
            this.btnThanhtoan.Margin = new System.Windows.Forms.Padding(4);
            this.btnThanhtoan.Name = "btnThanhtoan";
            this.btnThanhtoan.ShadowDecoration.Parent = this.btnThanhtoan;
            this.btnThanhtoan.Size = new System.Drawing.Size(463, 66);
            this.btnThanhtoan.TabIndex = 12;
            this.btnThanhtoan.Text = "Thanh toán";
            // 
            // dgMenu
            // 
            this.dgMenu.AllowUserToAddRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgMenu.ColumnHeadersHeight = 21;
            this.dgMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namedrink,
            this.number,
            this.price});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMenu.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgMenu.EnableHeadersVisualStyles = false;
            this.dgMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgMenu.Location = new System.Drawing.Point(328, 113);
            this.dgMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.ReadOnly = true;
            this.dgMenu.RowHeadersVisible = false;
            this.dgMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMenu.Size = new System.Drawing.Size(463, 270);
            this.dgMenu.TabIndex = 16;
            this.dgMenu.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgMenu.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgMenu.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgMenu.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgMenu.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgMenu.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgMenu.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgMenu.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgMenu.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgMenu.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMenu.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgMenu.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgMenu.ThemeStyle.HeaderStyle.Height = 21;
            this.dgMenu.ThemeStyle.ReadOnly = true;
            this.dgMenu.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgMenu.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgMenu.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgMenu.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgMenu.ThemeStyle.RowsStyle.Height = 22;
            this.dgMenu.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgMenu.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // namedrink
            // 
            this.namedrink.HeaderText = "Nước";
            this.namedrink.Name = "namedrink";
            this.namedrink.ReadOnly = true;
            // 
            // number
            // 
            this.number.HeaderText = "Số lượng";
            this.number.Name = "number";
            this.number.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Thành tiền";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Cn", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumSlateBlue;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 33);
            this.label1.TabIndex = 15;
            this.label1.Text = "Thực đơn";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 538);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.ColorAngle = 0F;
            this.StateCommon.Header.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.StateCommon.Header.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(57)))));
            this.StateCommon.Header.Back.ColorAngle = 35F;
            this.StateCommon.Header.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.StateCommon.Header.Content.ShortText.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text = "FormMenu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.panelTong.ResumeLayout(false);
            this.panelTong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel panelTong;
        private System.Windows.Forms.Label tien;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnThanhtoan;
        private Guna.UI2.WinForms.Guna2DataGridView dgMenu;
        private System.Windows.Forms.DataGridViewTextBoxColumn namedrink;
        private System.Windows.Forms.DataGridViewTextBoxColumn number;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2ComboBox cbTentl;
    }
}