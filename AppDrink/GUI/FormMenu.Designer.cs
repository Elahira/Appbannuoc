
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.guna2TextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.listMenu = new System.Windows.Forms.ListBox();
            this.panelTong = new Guna.UI2.WinForms.Guna2Panel();
            this.tien = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThanhtoan = new Guna.UI2.WinForms.Guna2Button();
            this.dgMenu = new Guna.UI2.WinForms.Guna2DataGridView();
            this.namedrink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTentl = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.panelTong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.Controls.Add(this.cbTentl);
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.listMenu);
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
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.iconButton2);
            this.guna2Panel2.Controls.Add(this.iconButton1);
            this.guna2Panel2.Controls.Add(this.guna2TextBox1);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.txtName);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.txtPrice);
            this.guna2Panel2.Location = new System.Drawing.Point(328, 29);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(463, 174);
            this.guna2Panel2.TabIndex = 22;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(43)))), ((int)(((byte)(84)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(361, 113);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(84, 43);
            this.iconButton2.TabIndex = 26;
            this.iconButton2.Text = "Xóa";
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(43)))), ((int)(((byte)(236)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(239, 113);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(84, 43);
            this.iconButton1.TabIndex = 25;
            this.iconButton1.Text = "Thêm";
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // guna2TextBox1
            // 
            this.guna2TextBox1.BorderColor = System.Drawing.Color.Black;
            this.guna2TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox1.DefaultText = "";
            this.guna2TextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.DisabledState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.FocusedState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            this.guna2TextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox1.HoverState.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Location = new System.Drawing.Point(9, 127);
            this.guna2TextBox1.Name = "guna2TextBox1";
            this.guna2TextBox1.PasswordChar = '\0';
            this.guna2TextBox1.PlaceholderText = "test";
            this.guna2TextBox1.SelectedText = "";
            this.guna2TextBox1.ShadowDecoration.Parent = this.guna2TextBox1;
            this.guna2TextBox1.Size = new System.Drawing.Size(206, 29);
            this.guna2TextBox1.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(77, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 23;
            this.label5.Text = "Số lượng:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(308, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 19);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tổng giá:";
            // 
            // txtName
            // 
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.Parent = this.txtName;
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.FocusedState.Parent = this.txtName;
            this.txtName.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.HoverState.Parent = this.txtName;
            this.txtName.Location = new System.Drawing.Point(9, 41);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "test";
            this.txtName.SelectedText = "";
            this.txtName.ShadowDecoration.Parent = this.txtName;
            this.txtName.Size = new System.Drawing.Size(206, 29);
            this.txtName.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tên nước:";
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.Parent = this.txtPrice;
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.FocusedState.Parent = this.txtPrice;
            this.txtPrice.Font = new System.Drawing.Font("Roboto Cn", 9.75F);
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.HoverState.Parent = this.txtPrice;
            this.txtPrice.Location = new System.Drawing.Point(239, 41);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "test";
            this.txtPrice.SelectedText = "";
            this.txtPrice.ShadowDecoration.Parent = this.txtPrice;
            this.txtPrice.Size = new System.Drawing.Size(206, 29);
            this.txtPrice.TabIndex = 20;
            // 
            // listMenu
            // 
            this.listMenu.FormattingEnabled = true;
            this.listMenu.ItemHeight = 19;
            this.listMenu.Location = new System.Drawing.Point(19, 127);
            this.listMenu.Name = "listMenu";
            this.listMenu.Size = new System.Drawing.Size(278, 346);
            this.listMenu.TabIndex = 18;
            this.listMenu.SelectedIndexChanged += new System.EventHandler(this.listMenu_SelectedIndexChanged);
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
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgMenu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgMenu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMenu.BackgroundColor = System.Drawing.Color.White;
            this.dgMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgMenu.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgMenu.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgMenu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgMenu.ColumnHeadersHeight = 21;
            this.dgMenu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namedrink,
            this.number,
            this.price});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Roboto Cn", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgMenu.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgMenu.EnableHeadersVisualStyles = false;
            this.dgMenu.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgMenu.Location = new System.Drawing.Point(328, 210);
            this.dgMenu.Margin = new System.Windows.Forms.Padding(4);
            this.dgMenu.Name = "dgMenu";
            this.dgMenu.ReadOnly = true;
            this.dgMenu.RowHeadersVisible = false;
            this.dgMenu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMenu.Size = new System.Drawing.Size(463, 173);
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
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
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
        private System.Windows.Forms.ListBox listMenu;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbTentl;
    }
}