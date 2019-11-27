namespace bunifu.Class
{
    partial class ucl_doanhthu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_search = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_nam = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_thang = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_ngay = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_namtruoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_thangtruoc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_timnam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_timthang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_namnay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_timngay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_homnay = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_chophepnhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_search = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dgv_doanhthu = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search.BorderRadius = 6;
            this.btn_search.ButtonText = "Search";
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.DisabledColor = System.Drawing.Color.Gray;
            this.btn_search.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_search.Iconimage = null;
            this.btn_search.Iconimage_right = null;
            this.btn_search.Iconimage_right_Selected = null;
            this.btn_search.Iconimage_Selected = null;
            this.btn_search.IconMarginLeft = 0;
            this.btn_search.IconMarginRight = 0;
            this.btn_search.IconRightVisible = true;
            this.btn_search.IconRightZoom = 0D;
            this.btn_search.IconVisible = true;
            this.btn_search.IconZoom = 90D;
            this.btn_search.IsTab = false;
            this.btn_search.Location = new System.Drawing.Point(609, 17);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_search.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_search.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_search.selected = false;
            this.btn_search.Size = new System.Drawing.Size(115, 34);
            this.btn_search.TabIndex = 88;
            this.btn_search.Text = "Search";
            this.btn_search.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search.Textcolor = System.Drawing.Color.Snow;
            this.btn_search.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(24, 21);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(50, 22);
            this.bunifuCustomLabel5.TabIndex = 94;
            this.bunifuCustomLabel5.Text = "Ngày";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_nam);
            this.groupBox1.Controls.Add(this.txt_thang);
            this.groupBox1.Controls.Add(this.txt_ngay);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel5);
            this.groupBox1.Location = new System.Drawing.Point(18, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(739, 61);
            this.groupBox1.TabIndex = 97;
            this.groupBox1.TabStop = false;
            // 
            // txt_nam
            // 
            this.txt_nam.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_nam.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_nam.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_nam.BorderThickness = 2;
            this.txt_nam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nam.ForeColor = System.Drawing.Color.Snow;
            this.txt_nam.isPassword = false;
            this.txt_nam.Location = new System.Drawing.Point(480, 14);
            this.txt_nam.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(101, 37);
            this.txt_nam.TabIndex = 95;
            this.txt_nam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_nam.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // txt_thang
            // 
            this.txt_thang.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_thang.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_thang.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_thang.BorderThickness = 2;
            this.txt_thang.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thang.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_thang.ForeColor = System.Drawing.Color.Snow;
            this.txt_thang.isPassword = false;
            this.txt_thang.Location = new System.Drawing.Point(289, 14);
            this.txt_thang.Margin = new System.Windows.Forms.Padding(4);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(101, 37);
            this.txt_thang.TabIndex = 95;
            this.txt_thang.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_thang.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // txt_ngay
            // 
            this.txt_ngay.BorderColorFocused = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_ngay.BorderColorIdle = System.Drawing.Color.Silver;
            this.txt_ngay.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_ngay.BorderThickness = 2;
            this.txt_ngay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_ngay.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_ngay.ForeColor = System.Drawing.Color.Snow;
            this.txt_ngay.isPassword = false;
            this.txt_ngay.Location = new System.Drawing.Point(86, 14);
            this.txt_ngay.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ngay.Name = "txt_ngay";
            this.txt_ngay.Size = new System.Drawing.Size(101, 37);
            this.txt_ngay.TabIndex = 95;
            this.txt_ngay.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ngay.OnValueChanged += new System.EventHandler(this.bunifuMetroTextbox1_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(420, 23);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(40, 22);
            this.bunifuCustomLabel2.TabIndex = 94;
            this.bunifuCustomLabel2.Text = "Năm";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(216, 23);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(60, 22);
            this.bunifuCustomLabel1.TabIndex = 94;
            this.bunifuCustomLabel1.Text = "Tháng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_namtruoc);
            this.groupBox2.Controls.Add(this.btn_thangtruoc);
            this.groupBox2.Controls.Add(this.btn_timnam);
            this.groupBox2.Controls.Add(this.btn_timthang);
            this.groupBox2.Controls.Add(this.btn_namnay);
            this.groupBox2.Controls.Add(this.btn_timngay);
            this.groupBox2.Controls.Add(this.btn_homnay);
            this.groupBox2.Controls.Add(this.btn_chophepnhap);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Gainsboro;
            this.groupBox2.Location = new System.Drawing.Point(18, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(738, 126);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm theo";
            // 
            // btn_namtruoc
            // 
            this.btn_namtruoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_namtruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_namtruoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_namtruoc.BorderRadius = 6;
            this.btn_namtruoc.ButtonText = "Năm trước";
            this.btn_namtruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_namtruoc.DisabledColor = System.Drawing.Color.Gray;
            this.btn_namtruoc.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_namtruoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_namtruoc.Iconimage = null;
            this.btn_namtruoc.Iconimage_right = null;
            this.btn_namtruoc.Iconimage_right_Selected = null;
            this.btn_namtruoc.Iconimage_Selected = null;
            this.btn_namtruoc.IconMarginLeft = 0;
            this.btn_namtruoc.IconMarginRight = 0;
            this.btn_namtruoc.IconRightVisible = true;
            this.btn_namtruoc.IconRightZoom = 0D;
            this.btn_namtruoc.IconVisible = true;
            this.btn_namtruoc.IconZoom = 90D;
            this.btn_namtruoc.IsTab = false;
            this.btn_namtruoc.Location = new System.Drawing.Point(555, 77);
            this.btn_namtruoc.Margin = new System.Windows.Forms.Padding(5);
            this.btn_namtruoc.Name = "btn_namtruoc";
            this.btn_namtruoc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_namtruoc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_namtruoc.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_namtruoc.selected = false;
            this.btn_namtruoc.Size = new System.Drawing.Size(147, 36);
            this.btn_namtruoc.TabIndex = 66;
            this.btn_namtruoc.Text = "Năm trước";
            this.btn_namtruoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_namtruoc.Textcolor = System.Drawing.Color.Snow;
            this.btn_namtruoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_namtruoc.Click += new System.EventHandler(this.btn_namtruoc_Click);
            // 
            // btn_thangtruoc
            // 
            this.btn_thangtruoc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_thangtruoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_thangtruoc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_thangtruoc.BorderRadius = 6;
            this.btn_thangtruoc.ButtonText = "Tháng trước";
            this.btn_thangtruoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_thangtruoc.DisabledColor = System.Drawing.Color.Gray;
            this.btn_thangtruoc.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thangtruoc.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_thangtruoc.Iconimage = null;
            this.btn_thangtruoc.Iconimage_right = null;
            this.btn_thangtruoc.Iconimage_right_Selected = null;
            this.btn_thangtruoc.Iconimage_Selected = null;
            this.btn_thangtruoc.IconMarginLeft = 0;
            this.btn_thangtruoc.IconMarginRight = 0;
            this.btn_thangtruoc.IconRightVisible = true;
            this.btn_thangtruoc.IconRightZoom = 0D;
            this.btn_thangtruoc.IconVisible = true;
            this.btn_thangtruoc.IconZoom = 90D;
            this.btn_thangtruoc.IsTab = false;
            this.btn_thangtruoc.Location = new System.Drawing.Point(380, 77);
            this.btn_thangtruoc.Margin = new System.Windows.Forms.Padding(5);
            this.btn_thangtruoc.Name = "btn_thangtruoc";
            this.btn_thangtruoc.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_thangtruoc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_thangtruoc.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_thangtruoc.selected = false;
            this.btn_thangtruoc.Size = new System.Drawing.Size(147, 36);
            this.btn_thangtruoc.TabIndex = 66;
            this.btn_thangtruoc.Text = "Tháng trước";
            this.btn_thangtruoc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_thangtruoc.Textcolor = System.Drawing.Color.Snow;
            this.btn_thangtruoc.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_thangtruoc.Click += new System.EventHandler(this.btn_thangtruoc_Click);
            // 
            // btn_timnam
            // 
            this.btn_timnam.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_timnam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_timnam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_timnam.BorderRadius = 6;
            this.btn_timnam.ButtonText = "Năm";
            this.btn_timnam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timnam.DisabledColor = System.Drawing.Color.Gray;
            this.btn_timnam.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timnam.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_timnam.Iconimage = null;
            this.btn_timnam.Iconimage_right = null;
            this.btn_timnam.Iconimage_right_Selected = null;
            this.btn_timnam.Iconimage_Selected = null;
            this.btn_timnam.IconMarginLeft = 0;
            this.btn_timnam.IconMarginRight = 0;
            this.btn_timnam.IconRightVisible = true;
            this.btn_timnam.IconRightZoom = 0D;
            this.btn_timnam.IconVisible = true;
            this.btn_timnam.IconZoom = 90D;
            this.btn_timnam.IsTab = false;
            this.btn_timnam.Location = new System.Drawing.Point(555, 22);
            this.btn_timnam.Margin = new System.Windows.Forms.Padding(5);
            this.btn_timnam.Name = "btn_timnam";
            this.btn_timnam.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_timnam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_timnam.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_timnam.selected = false;
            this.btn_timnam.Size = new System.Drawing.Size(147, 36);
            this.btn_timnam.TabIndex = 67;
            this.btn_timnam.Text = "Năm";
            this.btn_timnam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_timnam.Textcolor = System.Drawing.Color.Snow;
            this.btn_timnam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timnam.Click += new System.EventHandler(this.btn_timnam_Click);
            // 
            // btn_timthang
            // 
            this.btn_timthang.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_timthang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_timthang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_timthang.BorderRadius = 6;
            this.btn_timthang.ButtonText = "Tháng";
            this.btn_timthang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timthang.DisabledColor = System.Drawing.Color.Gray;
            this.btn_timthang.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timthang.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_timthang.Iconimage = null;
            this.btn_timthang.Iconimage_right = null;
            this.btn_timthang.Iconimage_right_Selected = null;
            this.btn_timthang.Iconimage_Selected = null;
            this.btn_timthang.IconMarginLeft = 0;
            this.btn_timthang.IconMarginRight = 0;
            this.btn_timthang.IconRightVisible = true;
            this.btn_timthang.IconRightZoom = 0D;
            this.btn_timthang.IconVisible = true;
            this.btn_timthang.IconZoom = 90D;
            this.btn_timthang.IsTab = false;
            this.btn_timthang.Location = new System.Drawing.Point(380, 22);
            this.btn_timthang.Margin = new System.Windows.Forms.Padding(5);
            this.btn_timthang.Name = "btn_timthang";
            this.btn_timthang.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_timthang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_timthang.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_timthang.selected = false;
            this.btn_timthang.Size = new System.Drawing.Size(147, 36);
            this.btn_timthang.TabIndex = 67;
            this.btn_timthang.Text = "Tháng";
            this.btn_timthang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_timthang.Textcolor = System.Drawing.Color.Snow;
            this.btn_timthang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timthang.Click += new System.EventHandler(this.btn_timthang_Click);
            // 
            // btn_namnay
            // 
            this.btn_namnay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_namnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_namnay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_namnay.BorderRadius = 6;
            this.btn_namnay.ButtonText = "Năm nay";
            this.btn_namnay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_namnay.DisabledColor = System.Drawing.Color.Gray;
            this.btn_namnay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_namnay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_namnay.Iconimage = null;
            this.btn_namnay.Iconimage_right = null;
            this.btn_namnay.Iconimage_right_Selected = null;
            this.btn_namnay.Iconimage_Selected = null;
            this.btn_namnay.IconMarginLeft = 0;
            this.btn_namnay.IconMarginRight = 0;
            this.btn_namnay.IconRightVisible = true;
            this.btn_namnay.IconRightZoom = 0D;
            this.btn_namnay.IconVisible = true;
            this.btn_namnay.IconZoom = 90D;
            this.btn_namnay.IsTab = false;
            this.btn_namnay.Location = new System.Drawing.Point(201, 77);
            this.btn_namnay.Margin = new System.Windows.Forms.Padding(5);
            this.btn_namnay.Name = "btn_namnay";
            this.btn_namnay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_namnay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_namnay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_namnay.selected = false;
            this.btn_namnay.Size = new System.Drawing.Size(147, 36);
            this.btn_namnay.TabIndex = 68;
            this.btn_namnay.Text = "Năm nay";
            this.btn_namnay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_namnay.Textcolor = System.Drawing.Color.Snow;
            this.btn_namnay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_namnay.Click += new System.EventHandler(this.btn_namnay_Click);
            // 
            // btn_timngay
            // 
            this.btn_timngay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_timngay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_timngay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_timngay.BorderRadius = 6;
            this.btn_timngay.ButtonText = "Ngày";
            this.btn_timngay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_timngay.DisabledColor = System.Drawing.Color.Gray;
            this.btn_timngay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timngay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_timngay.Iconimage = null;
            this.btn_timngay.Iconimage_right = null;
            this.btn_timngay.Iconimage_right_Selected = null;
            this.btn_timngay.Iconimage_Selected = null;
            this.btn_timngay.IconMarginLeft = 0;
            this.btn_timngay.IconMarginRight = 0;
            this.btn_timngay.IconRightVisible = true;
            this.btn_timngay.IconRightZoom = 0D;
            this.btn_timngay.IconVisible = true;
            this.btn_timngay.IconZoom = 90D;
            this.btn_timngay.IsTab = false;
            this.btn_timngay.Location = new System.Drawing.Point(201, 22);
            this.btn_timngay.Margin = new System.Windows.Forms.Padding(5);
            this.btn_timngay.Name = "btn_timngay";
            this.btn_timngay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_timngay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_timngay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_timngay.selected = false;
            this.btn_timngay.Size = new System.Drawing.Size(147, 36);
            this.btn_timngay.TabIndex = 69;
            this.btn_timngay.Text = "Ngày";
            this.btn_timngay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_timngay.Textcolor = System.Drawing.Color.Snow;
            this.btn_timngay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_timngay.Click += new System.EventHandler(this.btn_timngay_Click);
            // 
            // btn_homnay
            // 
            this.btn_homnay.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_homnay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_homnay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_homnay.BorderRadius = 6;
            this.btn_homnay.ButtonText = "Hôm nay";
            this.btn_homnay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_homnay.DisabledColor = System.Drawing.Color.Gray;
            this.btn_homnay.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homnay.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_homnay.Iconimage = null;
            this.btn_homnay.Iconimage_right = null;
            this.btn_homnay.Iconimage_right_Selected = null;
            this.btn_homnay.Iconimage_Selected = null;
            this.btn_homnay.IconMarginLeft = 0;
            this.btn_homnay.IconMarginRight = 0;
            this.btn_homnay.IconRightVisible = true;
            this.btn_homnay.IconRightZoom = 0D;
            this.btn_homnay.IconVisible = true;
            this.btn_homnay.IconZoom = 90D;
            this.btn_homnay.IsTab = false;
            this.btn_homnay.Location = new System.Drawing.Point(22, 77);
            this.btn_homnay.Margin = new System.Windows.Forms.Padding(5);
            this.btn_homnay.Name = "btn_homnay";
            this.btn_homnay.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_homnay.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_homnay.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_homnay.selected = false;
            this.btn_homnay.Size = new System.Drawing.Size(147, 36);
            this.btn_homnay.TabIndex = 70;
            this.btn_homnay.Text = "Hôm nay";
            this.btn_homnay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_homnay.Textcolor = System.Drawing.Color.Snow;
            this.btn_homnay.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homnay.Click += new System.EventHandler(this.btn_homnay_Click);
            // 
            // btn_chophepnhap
            // 
            this.btn_chophepnhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_chophepnhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_chophepnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_chophepnhap.BorderRadius = 6;
            this.btn_chophepnhap.ButtonText = "Ngày, tháng, năm";
            this.btn_chophepnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_chophepnhap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_chophepnhap.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chophepnhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_chophepnhap.Iconimage = null;
            this.btn_chophepnhap.Iconimage_right = null;
            this.btn_chophepnhap.Iconimage_right_Selected = null;
            this.btn_chophepnhap.Iconimage_Selected = null;
            this.btn_chophepnhap.IconMarginLeft = 0;
            this.btn_chophepnhap.IconMarginRight = 0;
            this.btn_chophepnhap.IconRightVisible = true;
            this.btn_chophepnhap.IconRightZoom = 0D;
            this.btn_chophepnhap.IconVisible = true;
            this.btn_chophepnhap.IconZoom = 90D;
            this.btn_chophepnhap.IsTab = false;
            this.btn_chophepnhap.Location = new System.Drawing.Point(22, 22);
            this.btn_chophepnhap.Margin = new System.Windows.Forms.Padding(4);
            this.btn_chophepnhap.Name = "btn_chophepnhap";
            this.btn_chophepnhap.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_chophepnhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_chophepnhap.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_chophepnhap.selected = false;
            this.btn_chophepnhap.Size = new System.Drawing.Size(147, 36);
            this.btn_chophepnhap.TabIndex = 71;
            this.btn_chophepnhap.Text = "Ngày, tháng, năm";
            this.btn_chophepnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_chophepnhap.Textcolor = System.Drawing.Color.Snow;
            this.btn_chophepnhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_chophepnhap.Click += new System.EventHandler(this.btn_chophepnhap_Click);
            // 
            // txt_search
            // 
            this.txt_search.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_search.ForeColor = System.Drawing.Color.Snow;
            this.txt_search.HintForeColor = System.Drawing.Color.Empty;
            this.txt_search.HintText = "";
            this.txt_search.isPassword = false;
            this.txt_search.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_search.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_search.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_search.LineThickness = 3;
            this.txt_search.Location = new System.Drawing.Point(34, 227);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(709, 42);
            this.txt_search.TabIndex = 99;
            this.txt_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgv_doanhthu
            // 
            this.dgv_doanhthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_doanhthu.Location = new System.Drawing.Point(34, 276);
            this.dgv_doanhthu.Name = "dgv_doanhthu";
            this.dgv_doanhthu.Size = new System.Drawing.Size(709, 206);
            this.dgv_doanhthu.TabIndex = 100;
            // 
            // ucl_doanhthu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.dgv_doanhthu);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucl_doanhthu";
            this.Size = new System.Drawing.Size(774, 499);
            this.Load += new System.EventHandler(this.ucl_doanhthu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_doanhthu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btn_search;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_search;
        private Bunifu.Framework.UI.BunifuFlatButton btn_namtruoc;
        private Bunifu.Framework.UI.BunifuFlatButton btn_thangtruoc;
        private Bunifu.Framework.UI.BunifuFlatButton btn_timnam;
        private Bunifu.Framework.UI.BunifuFlatButton btn_timthang;
        private Bunifu.Framework.UI.BunifuFlatButton btn_namnay;
        private Bunifu.Framework.UI.BunifuFlatButton btn_timngay;
        private Bunifu.Framework.UI.BunifuFlatButton btn_homnay;
        private Bunifu.Framework.UI.BunifuFlatButton btn_chophepnhap;
        private System.Windows.Forms.DataGridView dgv_doanhthu;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_ngay;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_nam;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_thang;
    }
}
