namespace bunifu
{
    partial class Taotaikhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Taotaikhoan));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_dangky = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_newtendangnhap = new JMetroTextBox.JMetroTextBox();
            this.txt_newMatkhau = new JMetroTextBox.JMetroTextBox();
            this.txt_Nhaplaimk = new JMetroTextBox.JMetroTextBox();
            this.txt_cauhoi = new JMetroTextBox.JMetroTextBox();
            this.txt_traloi = new JMetroTextBox.JMetroTextBox();
            this.lb_trong = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(42, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(42, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(19, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(42, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Câu hỏi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label5.Location = new System.Drawing.Point(35, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Câu trả lời";
            // 
            // btn_dangky
            // 
            this.btn_dangky.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_dangky.BackColor = System.Drawing.Color.Purple;
            this.btn_dangky.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_dangky.BorderRadius = 0;
            this.btn_dangky.ButtonText = "Tạo tài khoản";
            this.btn_dangky.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dangky.DisabledColor = System.Drawing.Color.Gray;
            this.btn_dangky.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_dangky.Iconimage = null;
            this.btn_dangky.Iconimage_right = null;
            this.btn_dangky.Iconimage_right_Selected = null;
            this.btn_dangky.Iconimage_Selected = null;
            this.btn_dangky.IconMarginLeft = 0;
            this.btn_dangky.IconMarginRight = 0;
            this.btn_dangky.IconRightVisible = true;
            this.btn_dangky.IconRightZoom = 0D;
            this.btn_dangky.IconVisible = true;
            this.btn_dangky.IconZoom = 90D;
            this.btn_dangky.IsTab = false;
            this.btn_dangky.Location = new System.Drawing.Point(126, 342);
            this.btn_dangky.Name = "btn_dangky";
            this.btn_dangky.Normalcolor = System.Drawing.Color.Purple;
            this.btn_dangky.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_dangky.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_dangky.selected = false;
            this.btn_dangky.Size = new System.Drawing.Size(128, 47);
            this.btn_dangky.TabIndex = 5;
            this.btn_dangky.Text = "Tạo tài khoản";
            this.btn_dangky.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_dangky.Textcolor = System.Drawing.Color.White;
            this.btn_dangky.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dangky.Click += new System.EventHandler(this.btn_dangky_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(336, 13);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 3;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txt_newtendangnhap
            // 
            this.txt_newtendangnhap.BackColor = System.Drawing.Color.Transparent;
            this.txt_newtendangnhap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_newtendangnhap.BorderRadius = 15;
            this.txt_newtendangnhap.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_newtendangnhap.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_newtendangnhap.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_newtendangnhap.ForeColors = System.Drawing.Color.White;
            this.txt_newtendangnhap.IsPassword = false;
            this.txt_newtendangnhap.LineThickness = 2;
            this.txt_newtendangnhap.Location = new System.Drawing.Point(161, 56);
            this.txt_newtendangnhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_newtendangnhap.MaxLength = 32767;
            this.txt_newtendangnhap.MouseOnHover = System.Drawing.Color.Red;
            this.txt_newtendangnhap.Name = "txt_newtendangnhap";
            this.txt_newtendangnhap.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_newtendangnhap.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_newtendangnhap.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_newtendangnhap.ReadOnly = false;
            this.txt_newtendangnhap.Size = new System.Drawing.Size(212, 39);
            this.txt_newtendangnhap.TabIndex = 0;
            this.txt_newtendangnhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_newtendangnhap.TextName = "";
            // 
            // txt_newMatkhau
            // 
            this.txt_newMatkhau.BackColor = System.Drawing.Color.Transparent;
            this.txt_newMatkhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_newMatkhau.BorderRadius = 15;
            this.txt_newMatkhau.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_newMatkhau.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_newMatkhau.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_newMatkhau.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_newMatkhau.IsPassword = true;
            this.txt_newMatkhau.LineThickness = 2;
            this.txt_newMatkhau.Location = new System.Drawing.Point(161, 109);
            this.txt_newMatkhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_newMatkhau.MaxLength = 32767;
            this.txt_newMatkhau.MouseOnHover = System.Drawing.Color.Red;
            this.txt_newMatkhau.Name = "txt_newMatkhau";
            this.txt_newMatkhau.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_newMatkhau.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_newMatkhau.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_newMatkhau.ReadOnly = false;
            this.txt_newMatkhau.Size = new System.Drawing.Size(212, 39);
            this.txt_newMatkhau.TabIndex = 1;
            this.txt_newMatkhau.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_newMatkhau.TextName = "";
            // 
            // txt_Nhaplaimk
            // 
            this.txt_Nhaplaimk.BackColor = System.Drawing.Color.Transparent;
            this.txt_Nhaplaimk.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_Nhaplaimk.BorderRadius = 15;
            this.txt_Nhaplaimk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_Nhaplaimk.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nhaplaimk.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nhaplaimk.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_Nhaplaimk.IsPassword = true;
            this.txt_Nhaplaimk.LineThickness = 2;
            this.txt_Nhaplaimk.Location = new System.Drawing.Point(162, 161);
            this.txt_Nhaplaimk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Nhaplaimk.MaxLength = 32767;
            this.txt_Nhaplaimk.MouseOnHover = System.Drawing.Color.Red;
            this.txt_Nhaplaimk.Name = "txt_Nhaplaimk";
            this.txt_Nhaplaimk.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nhaplaimk.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_Nhaplaimk.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_Nhaplaimk.ReadOnly = false;
            this.txt_Nhaplaimk.Size = new System.Drawing.Size(212, 39);
            this.txt_Nhaplaimk.TabIndex = 2;
            this.txt_Nhaplaimk.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_Nhaplaimk.TextName = "";
            // 
            // txt_cauhoi
            // 
            this.txt_cauhoi.BackColor = System.Drawing.Color.Transparent;
            this.txt_cauhoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_cauhoi.BorderRadius = 15;
            this.txt_cauhoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_cauhoi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_cauhoi.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_cauhoi.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_cauhoi.IsPassword = false;
            this.txt_cauhoi.LineThickness = 2;
            this.txt_cauhoi.Location = new System.Drawing.Point(162, 216);
            this.txt_cauhoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cauhoi.MaxLength = 32767;
            this.txt_cauhoi.MouseOnHover = System.Drawing.Color.Red;
            this.txt_cauhoi.Name = "txt_cauhoi";
            this.txt_cauhoi.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cauhoi.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_cauhoi.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_cauhoi.ReadOnly = false;
            this.txt_cauhoi.Size = new System.Drawing.Size(212, 39);
            this.txt_cauhoi.TabIndex = 3;
            this.txt_cauhoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cauhoi.TextName = "";
            // 
            // txt_traloi
            // 
            this.txt_traloi.BackColor = System.Drawing.Color.Transparent;
            this.txt_traloi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_traloi.BorderRadius = 15;
            this.txt_traloi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_traloi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_traloi.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_traloi.ForeColors = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_traloi.IsPassword = false;
            this.txt_traloi.LineThickness = 2;
            this.txt_traloi.Location = new System.Drawing.Point(161, 271);
            this.txt_traloi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_traloi.MaxLength = 32767;
            this.txt_traloi.MouseOnHover = System.Drawing.Color.Red;
            this.txt_traloi.Name = "txt_traloi";
            this.txt_traloi.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_traloi.OnFocusColor = System.Drawing.Color.Transparent;
            this.txt_traloi.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_traloi.ReadOnly = false;
            this.txt_traloi.Size = new System.Drawing.Size(212, 39);
            this.txt_traloi.TabIndex = 4;
            this.txt_traloi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_traloi.TextName = "";
            // 
            // lb_trong
            // 
            this.lb_trong.AutoSize = true;
            this.lb_trong.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_trong.Location = new System.Drawing.Point(114, 34);
            this.lb_trong.Name = "lb_trong";
            this.lb_trong.Size = new System.Drawing.Size(160, 18);
            this.lb_trong.TabIndex = 0;
            this.lb_trong.Text = "Không được để trống";
            // 
            // Taotaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(385, 418);
            this.Controls.Add(this.txt_traloi);
            this.Controls.Add(this.txt_cauhoi);
            this.Controls.Add(this.txt_Nhaplaimk);
            this.Controls.Add(this.txt_newMatkhau);
            this.Controls.Add(this.txt_newtendangnhap);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.btn_dangky);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_trong);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Taotaikhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Taotaikhoan";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Taotaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_dangky;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private JMetroTextBox.JMetroTextBox txt_newtendangnhap;
        private JMetroTextBox.JMetroTextBox txt_traloi;
        private JMetroTextBox.JMetroTextBox txt_cauhoi;
        private JMetroTextBox.JMetroTextBox txt_Nhaplaimk;
        private JMetroTextBox.JMetroTextBox txt_newMatkhau;
        private System.Windows.Forms.Label lb_trong;
    }
}