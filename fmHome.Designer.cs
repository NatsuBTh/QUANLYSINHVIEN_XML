namespace QuanLySinhVien
{
    partial class fmHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmHome));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnMinimize = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvSV = new System.Windows.Forms.ListView();
            this.MSSV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NAME = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SEX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DATE = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CLASS = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.INDUSTRY = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dtpkDate = new System.Windows.Forms.DateTimePicker();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.cbIndustry = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.btnAddSV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEditSV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDeleteSV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSearchSV = new Bunifu.Framework.UI.BunifuFlatButton();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label8 = new System.Windows.Forms.Label();
            this.lbID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.btnMinimize);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 40);
            this.panel1.TabIndex = 0;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.ImageActive = null;
            this.btnMinimize.Location = new System.Drawing.Point(687, 8);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 24);
            this.btnMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMinimize.TabIndex = 12;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Zoom = 10;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(723, 8);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 24);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 11;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(263, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ SINH VIÊN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(117, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lvSV);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(755, 261);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lvSV
            // 
            this.lvSV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.MSSV,
            this.NAME,
            this.SEX,
            this.DATE,
            this.CLASS,
            this.INDUSTRY});
            this.lvSV.Location = new System.Drawing.Point(6, 19);
            this.lvSV.Name = "lvSV";
            this.lvSV.Size = new System.Drawing.Size(743, 236);
            this.lvSV.TabIndex = 10;
            this.lvSV.UseCompatibleStateImageBehavior = false;
            this.lvSV.View = System.Windows.Forms.View.Details;
            this.lvSV.SelectedIndexChanged += new System.EventHandler(this.lvSV_SelectedIndexChanged);
            // 
            // MSSV
            // 
            this.MSSV.Text = "Mã Số Sinh Viên";
            this.MSSV.Width = 112;
            // 
            // NAME
            // 
            this.NAME.Text = "Họ Và Tên";
            this.NAME.Width = 158;
            // 
            // SEX
            // 
            this.SEX.Text = "Giới Tính";
            this.SEX.Width = 80;
            // 
            // DATE
            // 
            this.DATE.Text = "Ngày Sinh";
            this.DATE.Width = 112;
            // 
            // CLASS
            // 
            this.CLASS.Text = "Lớp";
            this.CLASS.Width = 66;
            // 
            // INDUSTRY
            // 
            this.INDUSTRY.Text = "Ngành Học";
            this.INDUSTRY.Width = 208;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(160, 93);
            this.txtMSSV.MaxLength = 10;
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(169, 20);
            this.txtMSSV.TabIndex = 0;
            this.txtMSSV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMSSV_KeyPress);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(160, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(169, 20);
            this.txtName.TabIndex = 1;
            this.txtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtName_KeyPress);
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbSex.Location = new System.Drawing.Point(160, 163);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(169, 21);
            this.cbSex.TabIndex = 2;
            // 
            // dtpkDate
            // 
            this.dtpkDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpkDate.Location = new System.Drawing.Point(561, 66);
            this.dtpkDate.Name = "dtpkDate";
            this.dtpkDate.Size = new System.Drawing.Size(169, 20);
            this.dtpkDate.TabIndex = 3;
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(561, 101);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(169, 20);
            this.txtClass.TabIndex = 4;
            this.txtClass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClass_KeyPress);
            // 
            // cbIndustry
            // 
            this.cbIndustry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIndustry.FormattingEnabled = true;
            this.cbIndustry.Items.AddRange(new object[] {
            "Công Nghệ Thông Tin",
            "Quản Trị Kinh Doanh",
            "Điện - Điện Tử",
            "Quản Trị Nhà Hàng - Khách Sạn"});
            this.cbIndustry.Location = new System.Drawing.Point(561, 136);
            this.cbIndustry.Name = "cbIndustry";
            this.cbIndustry.Size = new System.Drawing.Size(169, 21);
            this.cbIndustry.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mã Số Sinh Viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Họ Và Tên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Giới Tính";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(436, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ngày Sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(436, 139);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Ngành Học";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // btnAddSV
            // 
            this.btnAddSV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddSV.BackColor = System.Drawing.SystemColors.Control;
            this.btnAddSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddSV.BorderRadius = 0;
            this.btnAddSV.ButtonText = "Thêm";
            this.btnAddSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddSV.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddSV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddSV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddSV.Iconimage")));
            this.btnAddSV.Iconimage_right = null;
            this.btnAddSV.Iconimage_right_Selected = null;
            this.btnAddSV.Iconimage_Selected = null;
            this.btnAddSV.IconMarginLeft = 0;
            this.btnAddSV.IconMarginRight = 0;
            this.btnAddSV.IconRightVisible = true;
            this.btnAddSV.IconRightZoom = 0D;
            this.btnAddSV.IconVisible = true;
            this.btnAddSV.IconZoom = 60D;
            this.btnAddSV.IsTab = false;
            this.btnAddSV.Location = new System.Drawing.Point(96, 211);
            this.btnAddSV.Name = "btnAddSV";
            this.btnAddSV.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnAddSV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddSV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddSV.selected = false;
            this.btnAddSV.Size = new System.Drawing.Size(121, 48);
            this.btnAddSV.TabIndex = 12;
            this.btnAddSV.Text = "Thêm";
            this.btnAddSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnAddSV.Textcolor = System.Drawing.Color.Black;
            this.btnAddSV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSV.Click += new System.EventHandler(this.btnAddSV_Click);
            // 
            // btnEditSV
            // 
            this.btnEditSV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEditSV.BackColor = System.Drawing.SystemColors.Control;
            this.btnEditSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditSV.BorderRadius = 0;
            this.btnEditSV.ButtonText = "Sửa";
            this.btnEditSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSV.DisabledColor = System.Drawing.Color.Gray;
            this.btnEditSV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEditSV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEditSV.Iconimage")));
            this.btnEditSV.Iconimage_right = null;
            this.btnEditSV.Iconimage_right_Selected = null;
            this.btnEditSV.Iconimage_Selected = null;
            this.btnEditSV.IconMarginLeft = 0;
            this.btnEditSV.IconMarginRight = 0;
            this.btnEditSV.IconRightVisible = true;
            this.btnEditSV.IconRightZoom = 0D;
            this.btnEditSV.IconVisible = true;
            this.btnEditSV.IconZoom = 60D;
            this.btnEditSV.IsTab = false;
            this.btnEditSV.Location = new System.Drawing.Point(247, 211);
            this.btnEditSV.Name = "btnEditSV";
            this.btnEditSV.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnEditSV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnEditSV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEditSV.selected = false;
            this.btnEditSV.Size = new System.Drawing.Size(121, 48);
            this.btnEditSV.TabIndex = 13;
            this.btnEditSV.Text = "Sửa";
            this.btnEditSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEditSV.Textcolor = System.Drawing.Color.Black;
            this.btnEditSV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditSV.Click += new System.EventHandler(this.btnEditSV_Click);
            // 
            // btnDeleteSV
            // 
            this.btnDeleteSV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDeleteSV.BackColor = System.Drawing.SystemColors.Control;
            this.btnDeleteSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeleteSV.BorderRadius = 0;
            this.btnDeleteSV.ButtonText = "Xóa";
            this.btnDeleteSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSV.DisabledColor = System.Drawing.Color.Gray;
            this.btnDeleteSV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDeleteSV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDeleteSV.Iconimage")));
            this.btnDeleteSV.Iconimage_right = null;
            this.btnDeleteSV.Iconimage_right_Selected = null;
            this.btnDeleteSV.Iconimage_Selected = null;
            this.btnDeleteSV.IconMarginLeft = 0;
            this.btnDeleteSV.IconMarginRight = 0;
            this.btnDeleteSV.IconRightVisible = true;
            this.btnDeleteSV.IconRightZoom = 0D;
            this.btnDeleteSV.IconVisible = true;
            this.btnDeleteSV.IconZoom = 60D;
            this.btnDeleteSV.IsTab = false;
            this.btnDeleteSV.Location = new System.Drawing.Point(395, 211);
            this.btnDeleteSV.Name = "btnDeleteSV";
            this.btnDeleteSV.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnDeleteSV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDeleteSV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDeleteSV.selected = false;
            this.btnDeleteSV.Size = new System.Drawing.Size(121, 48);
            this.btnDeleteSV.TabIndex = 14;
            this.btnDeleteSV.Text = "Xóa";
            this.btnDeleteSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDeleteSV.Textcolor = System.Drawing.Color.Black;
            this.btnDeleteSV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSV.Click += new System.EventHandler(this.btnDeleteSV_Click);
            // 
            // btnSearchSV
            // 
            this.btnSearchSV.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSearchSV.BackColor = System.Drawing.SystemColors.Control;
            this.btnSearchSV.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchSV.BorderRadius = 0;
            this.btnSearchSV.ButtonText = "Tìm Kiếm";
            this.btnSearchSV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchSV.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchSV.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchSV.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearchSV.Iconimage")));
            this.btnSearchSV.Iconimage_right = null;
            this.btnSearchSV.Iconimage_right_Selected = null;
            this.btnSearchSV.Iconimage_Selected = null;
            this.btnSearchSV.IconMarginLeft = 0;
            this.btnSearchSV.IconMarginRight = 0;
            this.btnSearchSV.IconRightVisible = true;
            this.btnSearchSV.IconRightZoom = 0D;
            this.btnSearchSV.IconVisible = true;
            this.btnSearchSV.IconZoom = 60D;
            this.btnSearchSV.IsTab = false;
            this.btnSearchSV.Location = new System.Drawing.Point(545, 211);
            this.btnSearchSV.Name = "btnSearchSV";
            this.btnSearchSV.Normalcolor = System.Drawing.SystemColors.Control;
            this.btnSearchSV.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearchSV.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchSV.selected = false;
            this.btnSearchSV.Size = new System.Drawing.Size(121, 48);
            this.btnSearchSV.TabIndex = 15;
            this.btnSearchSV.Text = "Tìm Kiếm";
            this.btnSearchSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSearchSV.Textcolor = System.Drawing.Color.Black;
            this.btnSearchSV.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchSV.Click += new System.EventHandler(this.btnSearchSV_Click);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            this.ID.Width = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "ID";
            // 
            // lbID
            // 
            this.lbID.AutoSize = true;
            this.lbID.Location = new System.Drawing.Point(157, 69);
            this.lbID.Name = "lbID";
            this.lbID.Size = new System.Drawing.Size(0, 13);
            this.lbID.TabIndex = 17;
            // 
            // fmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(755, 541);
            this.Controls.Add(this.lbID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSearchSV);
            this.Controls.Add(this.btnDeleteSV);
            this.Controls.Add(this.btnEditSV);
            this.Controls.Add(this.btnAddSV);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbIndustry);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.dtpkDate);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fmHome";
            this.Load += new System.EventHandler(this.fmHome_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuImageButton btnMinimize;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private System.Windows.Forms.ListView lvSV;
        private System.Windows.Forms.ColumnHeader MSSV;
        private System.Windows.Forms.ColumnHeader NAME;
        private System.Windows.Forms.ColumnHeader SEX;
        private System.Windows.Forms.ColumnHeader DATE;
        private System.Windows.Forms.ColumnHeader CLASS;
        private System.Windows.Forms.ColumnHeader INDUSTRY;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIndustry;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.DateTimePicker dtpkDate;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtMSSV;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchSV;
        private Bunifu.Framework.UI.BunifuFlatButton btnDeleteSV;
        private Bunifu.Framework.UI.BunifuFlatButton btnEditSV;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddSV;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Label lbID;
        private System.Windows.Forms.Label label8;
    }
}