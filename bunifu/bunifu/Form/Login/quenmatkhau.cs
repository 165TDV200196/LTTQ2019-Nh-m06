using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
namespace bunifu
{
    public partial class quenmatkhau : Form
    {
        public quenmatkhau()
        {
            InitializeComponent();
        }

        private void quenmatkhau_Load(object sender, EventArgs e)
        {
            label2.Hide();
            lb_trong.Hide();
            label3.Hide();
            label4.Hide();
            txt_cauhoi.Hide();
            txt_traloi.Hide();
            txt_matkhaucu.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            String tentaikhoan = txt_quentaikhoan.TextName.Trim();
            if (tentaikhoan.Equals("") == true)
            {
                lb_trong.Text = "Không được để trống";
                lb_trong.Location = new Point(170, 47);
                lb_trong.Show();
                return;
            }
            Connection con = new Connection();
            con.quenmatkhau(tentaikhoan);
            if (con.b == 1)
            {

                animator.ShowSync(txt_cauhoi);
                animator.ShowSync(label2);
                animator.ShowSync(txt_traloi);
                animator.ShowSync(label3);
                btn_tieptuc.Hide();
                //label2.Location = new Point(30, 136);
                //txt_cauhoi.Location = new Point(146, 125);
                //label3.Location = new Point(30, 188);
                //txt_traloi.Location = new Point(146, 180);
                //btn_tieptuc.Location = new Point(425, 233);
                btn_traloi.Location = new Point(116, 321);
                con.traloi(tentaikhoan);
                txt_cauhoi.TextName = con.cauhoi;
            }
            else
            {
                lb_trong.Text = "Sai tên tài khoản";
                lb_trong.Location = new Point(170, 47);
                lb_trong.Show();
                return;
            }
        }
        MD5 md = MD5.Create();
        string traloi1;
        private void btn_traloi_Click(object sender, EventArgs e)
        {
            String tentaikhoan = txt_quentaikhoan.TextName;
            traloi1 = txt_traloi.TextName.Trim();
            if (traloi1.Equals("")==true)
            {
                lb_trong.Text = "Không được để trống";
                lb_trong.Location = new Point(173, 162);
                lb_trong.Show();
                return;
            }
            Connection con = new Connection();
            con.quenmatkhau(tentaikhoan);
            con.traloi(tentaikhoan);
            byte[] input1 = System.Text.Encoding.ASCII.GetBytes(traloi1);
            byte[] hast1 = md.ComputeHash(input1);
            StringBuilder traloi2 = new StringBuilder();
            for (int i = 0; i < hast1.Length; i++)
            {
                traloi2.Append(hast1[i].ToString());
            }
            String traloi3 = traloi2.ToString();
            if (traloi3.Equals(con.Atraloi) == true)
            {
                lb_trong.Hide();
                animator.ShowSync(label4);
                animator.ShowSync(txt_matkhaucu);
                con.resetmk(tentaikhoan);
                txt_matkhaucu.TextName = con.matkhau;
                btn_traloi.Enabled = false;
                txt_matkhaucu.Enabled = false;
            }
            else
            {
                lb_trong.Text = "Trả lời sai";
                lb_trong.Location = new Point(173, 162);
                lb_trong.Show();
                return;
            }
        }
    }
}
