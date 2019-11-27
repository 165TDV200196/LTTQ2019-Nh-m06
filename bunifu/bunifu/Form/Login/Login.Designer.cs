namespace bunifu
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_taikhoan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_matkhau = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_dangnhap = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_taotaikhoan = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lb_quenmatkhau = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton3 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton4 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton5 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lb_saitkmk = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_taikhoan
            // 
            this.txt_taikhoan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_taikhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_taikhoan.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_taikhoan.HintForeColor = System.Drawing.Color.White;
            this.txt_taikhoan.HintText = "Username";
            this.txt_taikhoan.isPassword = false;
            this.txt_taikhoan.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_taikhoan.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_taikhoan.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_taikhoan.LineThickness = 3;
            this.txt_taikhoan.Location = new System.Drawing.Point(303, 76);
            this.txt_taikhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_taikhoan.Name = "txt_taikhoan";
            this.txt_taikhoan.Size = new System.Drawing.Size(370, 44);
            this.txt_taikhoan.TabIndex = 1;
            this.txt_taikhoan.Tag = "";
            this.txt_taikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_matkhau.ForeColor = System.Drawing.Color.Gainsboro;
            this.txt_matkhau.HintForeColor = System.Drawing.Color.Snow;
            this.txt_matkhau.HintText = "••••••";
            this.txt_matkhau.isPassword = false;
            this.txt_matkhau.LineFocusedColor = System.Drawing.Color.Blue;
            this.txt_matkhau.LineIdleColor = System.Drawing.Color.Gray;
            this.txt_matkhau.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txt_matkhau.LineThickness = 3;
            this.txt_matkhau.Location = new System.Drawing.Point(303, 128);
            this.txt_matkhau.Margin = new System.Windows.Forms.Padding(4);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(370, 44);
            this.txt_matkhau.TabIndex = 2;
            this.txt_matkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_matkhau.OnValueChanged += new System.EventHandler(this.txt_matkhau_OnValueChanged);
            // 
            // btn_dangnhap
            // 
            this.btn_dangnhap.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_dangnhap.BackColor = System.Drawing.Color.Purple;
            this.btn_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dangnhap.BorderRadius = 0;
            this.btn_dangnhap.ButtonText = "Đăng nhập";
            this.btn_dangnhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangnhap.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dangnhap.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dangnhap.Iconimage = null;
            this.btn_dangnhap.Iconimage_right = null;
            this.btn_dangnhap.Iconimage_right_Selected = null;
            this.btn_dangnhap.Iconimage_Selected = null;
            this.btn_dangnhap.IconMarginLeft = 0;
            this.btn_dangnhap.IconMarginRight = 0;
            this.btn_dangnhap.IconRightVisible = true;
            this.btn_dangnhap.IconRightZoom = 0D;
            this.btn_dangnhap.IconVisible = true;
            this.btn_dangnhap.IconZoom = 90D;
            this.btn_dangnhap.IsTab = false;
            this.btn_dangnhap.Location = new System.Drawing.Point(303, 203);
            this.btn_dangnhap.Name = "btn_dangnhap";
            this.btn_dangnhap.Normalcolor = System.Drawing.Color.Purple;
            this.btn_dangnhap.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_dangnhap.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_dangnhap.selected = false;
            this.btn_dangnhap.Size = new System.Drawing.Size(370, 48);
            this.btn_dangnhap.TabIndex = 0;
            this.btn_dangnhap.Text = "Đăng nhập";
            this.btn_dangnhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dangnhap.Textcolor = System.Drawing.Color.White;
            this.btn_dangnhap.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangnhap.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(433, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(103, 38);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Login";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Silver;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(-2, -3);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(272, 302);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // lb_taotaikhoan
            // 
            this.lb_taotaikhoan.AutoSize = true;
            this.lb_taotaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.lb_taotaikhoan.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_taotaikhoan.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_taotaikhoan.Location = new System.Drawing.Point(320, 176);
            this.lb_taotaikhoan.Name = "lb_taotaikhoan";
            this.lb_taotaikhoan.Size = new System.Drawing.Size(112, 18);
            this.lb_taotaikhoan.TabIndex = 5;
            this.lb_taotaikhoan.Text = "Tạo tài khoản";
            this.lb_taotaikhoan.Click += new System.EventHandler(this.lb_taotaikhoan_Click);
            // 
            // lb_quenmatkhau
            // 
            this.lb_quenmatkhau.AutoSize = true;
            this.lb_quenmatkhau.BackColor = System.Drawing.Color.Transparent;
            this.lb_quenmatkhau.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_quenmatkhau.ForeColor = System.Drawing.Color.OrangeRed;
            this.lb_quenmatkhau.Location = new System.Drawing.Point(551, 176);
            this.lb_quenmatkhau.Name = "lb_quenmatkhau";
            this.lb_quenmatkhau.Size = new System.Drawing.Size(128, 18);
            this.lb_quenmatkhau.TabIndex = 5;
            this.lb_quenmatkhau.Text = "Quên mật khẩu ?";
            this.lb_quenmatkhau.Click += new System.EventHandler(this.lb_quenmatkhau_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(664, 10);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 35);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton2.TabIndex = 6;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.Location = new System.Drawing.Point(424, 257);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Size = new System.Drawing.Size(41, 36);
            this.bunifuImageButton3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton3.TabIndex = 7;
            this.bunifuImageButton3.TabStop = false;
            this.bunifuImageButton3.Zoom = 10;
            // 
            // bunifuImageButton4
            // 
            this.bunifuImageButton4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton4.Image")));
            this.bunifuImageButton4.ImageActive = null;
            this.bunifuImageButton4.Location = new System.Drawing.Point(471, 257);
            this.bunifuImageButton4.Name = "bunifuImageButton4";
            this.bunifuImageButton4.Size = new System.Drawing.Size(41, 36);
            this.bunifuImageButton4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton4.TabIndex = 7;
            this.bunifuImageButton4.TabStop = false;
            this.bunifuImageButton4.Zoom = 10;
            // 
            // bunifuImageButton5
            // 
            this.bunifuImageButton5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton5.Image")));
            this.bunifuImageButton5.ImageActive = null;
            this.bunifuImageButton5.Location = new System.Drawing.Point(518, 257);
            this.bunifuImageButton5.Name = "bunifuImageButton5";
            this.bunifuImageButton5.Size = new System.Drawing.Size(41, 36);
            this.bunifuImageButton5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton5.TabIndex = 7;
            this.bunifuImageButton5.TabStop = false;
            this.bunifuImageButton5.Zoom = 10;
            // 
            // lb_saitkmk
            // 
            this.lb_saitkmk.AutoSize = true;
            this.lb_saitkmk.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_saitkmk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_saitkmk.Location = new System.Drawing.Point(358, 65);
            this.lb_saitkmk.Name = "lb_saitkmk";
            this.lb_saitkmk.Size = new System.Drawing.Size(248, 18);
            this.lb_saitkmk.TabIndex = 8;
            this.lb_saitkmk.Text = "Sai Tên đăng nhập hặc mật khẩu";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(715, 297);
            this.Controls.Add(this.lb_saitkmk);
            this.Controls.Add(this.bunifuImageButton5);
            this.Controls.Add(this.bunifuImageButton4);
            this.Controls.Add(this.bunifuImageButton3);
            this.Controls.Add(this.bunifuImageButton2);
            this.Controls.Add(this.lb_quenmatkhau);
            this.Controls.Add(this.lb_taotaikhoan);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.btn_dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_taikhoan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_taikhoan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_matkhau;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dangnhap;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_taotaikhoan;
        private Bunifu.Framework.UI.BunifuCustomLabel lb_quenmatkhau;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton3;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton5;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton4;
        private System.Windows.Forms.Label lb_saitkmk;
    }
}