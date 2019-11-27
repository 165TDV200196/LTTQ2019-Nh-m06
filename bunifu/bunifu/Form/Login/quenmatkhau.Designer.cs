namespace bunifu
{
    partial class quenmatkhau
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
            AnimatorNS.Animation animation1 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quenmatkhau));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_quentaikhoan = new JMetroTextBox.JMetroTextBox();
            this.txt_cauhoi = new JMetroTextBox.JMetroTextBox();
            this.txt_traloi = new JMetroTextBox.JMetroTextBox();
            this.txt_matkhaucu = new JMetroTextBox.JMetroTextBox();
            this.btn_tieptuc = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_traloi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.animator = new AnimatorNS.Animator(this.components);
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.animator.SetDecoration(this.label2, AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(30, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Câu hỏi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.animator.SetDecoration(this.label3, AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(30, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trả lời";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.animator.SetDecoration(this.label4, AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(18, 241);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.animator.SetDecoration(this.label1, AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(30, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tài khoản";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.animator.SetDecoration(this.bunifuImageButton1, AnimatorNS.DecorationType.None);
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(338, 10);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(30, 30);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 12;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txt_quentaikhoan
            // 
            this.txt_quentaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.txt_quentaikhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_quentaikhoan.BorderRadius = 15;
            this.animator.SetDecoration(this.txt_quentaikhoan, AnimatorNS.DecorationType.None);
            this.txt_quentaikhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_quentaikhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_quentaikhoan.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_quentaikhoan.ForeColors = System.Drawing.Color.White;
            this.txt_quentaikhoan.IsPassword = false;
            this.txt_quentaikhoan.LineThickness = 2;
            this.txt_quentaikhoan.Location = new System.Drawing.Point(146, 69);
            this.txt_quentaikhoan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_quentaikhoan.MaxLength = 32767;
            this.txt_quentaikhoan.MouseOnHover = System.Drawing.Color.Red;
            this.txt_quentaikhoan.Name = "txt_quentaikhoan";
            this.txt_quentaikhoan.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_quentaikhoan.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_quentaikhoan.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_quentaikhoan.ReadOnly = false;
            this.txt_quentaikhoan.Size = new System.Drawing.Size(212, 39);
            this.txt_quentaikhoan.TabIndex = 0;
            this.txt_quentaikhoan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_quentaikhoan.TextName = "";
            // 
            // txt_cauhoi
            // 
            this.txt_cauhoi.BackColor = System.Drawing.Color.Transparent;
            this.txt_cauhoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_cauhoi.BorderRadius = 15;
            this.animator.SetDecoration(this.txt_cauhoi, AnimatorNS.DecorationType.None);
            this.txt_cauhoi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_cauhoi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_cauhoi.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_cauhoi.ForeColors = System.Drawing.Color.White;
            this.txt_cauhoi.IsPassword = false;
            this.txt_cauhoi.LineThickness = 2;
            this.txt_cauhoi.Location = new System.Drawing.Point(146, 121);
            this.txt_cauhoi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_cauhoi.MaxLength = 32767;
            this.txt_cauhoi.MouseOnHover = System.Drawing.Color.Red;
            this.txt_cauhoi.Name = "txt_cauhoi";
            this.txt_cauhoi.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cauhoi.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_cauhoi.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_cauhoi.ReadOnly = false;
            this.txt_cauhoi.Size = new System.Drawing.Size(212, 39);
            this.txt_cauhoi.TabIndex = 1;
            this.txt_cauhoi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_cauhoi.TextName = "";
            // 
            // txt_traloi
            // 
            this.txt_traloi.BackColor = System.Drawing.Color.Transparent;
            this.txt_traloi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_traloi.BorderRadius = 15;
            this.animator.SetDecoration(this.txt_traloi, AnimatorNS.DecorationType.None);
            this.txt_traloi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_traloi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_traloi.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_traloi.ForeColors = System.Drawing.Color.White;
            this.txt_traloi.IsPassword = false;
            this.txt_traloi.LineThickness = 2;
            this.txt_traloi.Location = new System.Drawing.Point(146, 176);
            this.txt_traloi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_traloi.MaxLength = 32767;
            this.txt_traloi.MouseOnHover = System.Drawing.Color.Red;
            this.txt_traloi.Name = "txt_traloi";
            this.txt_traloi.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_traloi.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_traloi.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_traloi.ReadOnly = false;
            this.txt_traloi.Size = new System.Drawing.Size(212, 39);
            this.txt_traloi.TabIndex = 2;
            this.txt_traloi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_traloi.TextName = "";
            // 
            // txt_matkhaucu
            // 
            this.txt_matkhaucu.BackColor = System.Drawing.Color.Transparent;
            this.txt_matkhaucu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txt_matkhaucu.BorderRadius = 15;
            this.animator.SetDecoration(this.txt_matkhaucu, AnimatorNS.DecorationType.None);
            this.txt_matkhaucu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.txt_matkhaucu.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_matkhaucu.Font_Size = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_matkhaucu.ForeColors = System.Drawing.Color.White;
            this.txt_matkhaucu.IsPassword = false;
            this.txt_matkhaucu.LineThickness = 2;
            this.txt_matkhaucu.Location = new System.Drawing.Point(146, 229);
            this.txt_matkhaucu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_matkhaucu.MaxLength = 32767;
            this.txt_matkhaucu.MouseOnHover = System.Drawing.Color.Red;
            this.txt_matkhaucu.Name = "txt_matkhaucu";
            this.txt_matkhaucu.OnCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_matkhaucu.OnFocusColor = System.Drawing.Color.Empty;
            this.txt_matkhaucu.OnFocusFontColor = System.Drawing.Color.White;
            this.txt_matkhaucu.ReadOnly = false;
            this.txt_matkhaucu.Size = new System.Drawing.Size(212, 39);
            this.txt_matkhaucu.TabIndex = 3;
            this.txt_matkhaucu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_matkhaucu.TextName = "";
            // 
            // btn_tieptuc
            // 
            this.btn_tieptuc.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_tieptuc.BackColor = System.Drawing.Color.Purple;
            this.btn_tieptuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tieptuc.BorderRadius = 0;
            this.btn_tieptuc.ButtonText = "Tiếp tục";
            this.btn_tieptuc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.btn_tieptuc, AnimatorNS.DecorationType.None);
            this.btn_tieptuc.DisabledColor = System.Drawing.Color.Gray;
            this.btn_tieptuc.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_tieptuc.Iconimage = null;
            this.btn_tieptuc.Iconimage_right = null;
            this.btn_tieptuc.Iconimage_right_Selected = null;
            this.btn_tieptuc.Iconimage_Selected = null;
            this.btn_tieptuc.IconMarginLeft = 0;
            this.btn_tieptuc.IconMarginRight = 0;
            this.btn_tieptuc.IconRightVisible = true;
            this.btn_tieptuc.IconRightZoom = 0D;
            this.btn_tieptuc.IconVisible = true;
            this.btn_tieptuc.IconZoom = 90D;
            this.btn_tieptuc.IsTab = false;
            this.btn_tieptuc.Location = new System.Drawing.Point(116, 321);
            this.btn_tieptuc.Name = "btn_tieptuc";
            this.btn_tieptuc.Normalcolor = System.Drawing.Color.Purple;
            this.btn_tieptuc.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_tieptuc.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_tieptuc.selected = false;
            this.btn_tieptuc.Size = new System.Drawing.Size(156, 48);
            this.btn_tieptuc.TabIndex = 13;
            this.btn_tieptuc.Text = "Tiếp tục";
            this.btn_tieptuc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_tieptuc.Textcolor = System.Drawing.Color.LightGray;
            this.btn_tieptuc.TextFont = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tieptuc.Click += new System.EventHandler(this.btn_tieptuc_Click);
            // 
            // btn_traloi
            // 
            this.btn_traloi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btn_traloi.BackColor = System.Drawing.Color.Purple;
            this.btn_traloi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_traloi.BorderRadius = 0;
            this.btn_traloi.ButtonText = "Xác nhận";
            this.btn_traloi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.animator.SetDecoration(this.btn_traloi, AnimatorNS.DecorationType.None);
            this.btn_traloi.DisabledColor = System.Drawing.Color.Gray;
            this.btn_traloi.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_traloi.Iconimage = null;
            this.btn_traloi.Iconimage_right = null;
            this.btn_traloi.Iconimage_right_Selected = null;
            this.btn_traloi.Iconimage_Selected = null;
            this.btn_traloi.IconMarginLeft = 0;
            this.btn_traloi.IconMarginRight = 0;
            this.btn_traloi.IconRightVisible = true;
            this.btn_traloi.IconRightZoom = 0D;
            this.btn_traloi.IconVisible = true;
            this.btn_traloi.IconZoom = 90D;
            this.btn_traloi.IsTab = false;
            this.btn_traloi.Location = new System.Drawing.Point(485, 321);
            this.btn_traloi.Name = "btn_traloi";
            this.btn_traloi.Normalcolor = System.Drawing.Color.Purple;
            this.btn_traloi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_traloi.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_traloi.selected = false;
            this.btn_traloi.Size = new System.Drawing.Size(156, 48);
            this.btn_traloi.TabIndex = 13;
            this.btn_traloi.Text = "Xác nhận";
            this.btn_traloi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_traloi.Textcolor = System.Drawing.Color.White;
            this.btn_traloi.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_traloi.Click += new System.EventHandler(this.btn_traloi_Click);
            // 
            // animator
            // 
            this.animator.AnimationType = AnimatorNS.AnimationType.HorizSlide;
            this.animator.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.animator.DefaultAnimation = animation1;
            // 
            // lb_trong
            // 
            this.lb_trong.AutoSize = true;
            this.animator.SetDecoration(this.lb_trong, AnimatorNS.DecorationType.None);
            this.lb_trong.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_trong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lb_trong.Location = new System.Drawing.Point(170, 47);
            this.lb_trong.Name = "lb_trong";
            this.lb_trong.Size = new System.Drawing.Size(160, 18);
            this.lb_trong.TabIndex = 14;
            this.lb_trong.Text = "Không được để trống";
            // 
            // quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(376, 418);
            this.Controls.Add(this.lb_trong);
            this.Controls.Add(this.btn_traloi);
            this.Controls.Add(this.btn_tieptuc);
            this.Controls.Add(this.txt_matkhaucu);
            this.Controls.Add(this.txt_traloi);
            this.Controls.Add(this.txt_cauhoi);
            this.Controls.Add(this.txt_quentaikhoan);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.animator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quenmatkhau";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quenmatkhau";
            this.Load += new System.EventHandler(this.quenmatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private JMetroTextBox.JMetroTextBox txt_matkhaucu;
        private JMetroTextBox.JMetroTextBox txt_traloi;
        private JMetroTextBox.JMetroTextBox txt_cauhoi;
        private JMetroTextBox.JMetroTextBox txt_quentaikhoan;
        private Bunifu.Framework.UI.BunifuFlatButton btn_traloi;
        private Bunifu.Framework.UI.BunifuFlatButton btn_tieptuc;
        private AnimatorNS.Animator animator;
        private System.Windows.Forms.Label lb_trong;
    }
}