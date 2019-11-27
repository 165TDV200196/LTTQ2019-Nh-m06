using bunifu.Class;
//using bunifu.Form.Home.user_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunifu
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }
        String name;
        public home(String usename)
            : this()
        {
            name = usename;
        }
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            if (slidemenu.Width == 41)
            {
                btn_menu.Location = new Point(201, 6);
                btn_logo.Hide();
                slidemenu.Visible = false;
                slidemenu.Width = 260;
                PanlAnimator.ShowSync(slidemenu);
                LogoAnimator.ShowSync(btn_logo);
            }
            else
            {
                btn_menu.Location = new Point(6, 6);
                slidemenu.Visible = false;
                slidemenu.Width = 41;
                pantanimator1.ShowSync(slidemenu);
                LogoAnimator.Hide(btn_logo);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hideucl();
            welcome1.Show();
            timer1.Start();
        }
        private void hideucl()
        {
            welcome1.Hide();
            ucl_khohang1.Hide();
            ucl_nv1.Hide();
            ucl_sanpham1.Hide();
            ucl_khachhang1.Hide();
            ucl_doanhthu1.Hide();
            ucl_hoadon1.Hide();
        }
        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            hideucl();
            ucl_sanpham1.Show();
            ucl_sanpham1.BringToFront();

        }
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            hideucl();
            ucl_nv1.Show();
            ucl_nv1.BringToFront();
        }
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            hideucl();
            ucl_khachhang1.Show();
            ucl_khachhang1.BringToFront();
        }

        private void bunifuFlatButton4_Click(object sender, EventArgs e)
        {
            hideucl();
            ucl_khohang1.Show();
            ucl_khohang1.BringToFront();
        }
        private void bunifuFlatButton6_Click(object sender, EventArgs e)
        {
            hideucl();
            ucl_doanhthu1.Show();
            ucl_doanhthu1.BringToFront();
        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            hideucl();
            ucl_hoadon1.Show();
            ucl_hoadon1.BringToFront();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            time.Text = DateTime.Now.Day.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Year.ToString() + " " + DateTime.Now.Hour.ToString() + ":" + DateTime.Now.Minute.ToString() + ":" + DateTime.Now.Second.ToString();
        }
        private void btn_logo_Click(object sender, EventArgs e)
        {
            welcome1.welcome_Load(sender, e);
            hideucl();
            welcome1.Show();

        }

        private void bunifuFlatButton7_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.Show();
        }
        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            doimatkhau dmk = new doimatkhau(name);
            dmk.Show();
        }

        //private void home_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.ExitThread();
        //}
    }
}
