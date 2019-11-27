using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunifu
{
    public partial class Taotaikhoan : Form
    {
        public Taotaikhoan()
        {
            InitializeComponent();
        }
        MD5 md = MD5.Create();
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Hide();
            lg.ShowDialog();
        }

        private void btn_dangky_Click(object sender, EventArgs e)
        {
            String usename = txt_newtendangnhap.TextName.Trim();
            String pass = txt_newMatkhau.TextName.Trim();
            String nhaplai = txt_Nhaplaimk.TextName.Trim();
            String cauhoi = txt_cauhoi.TextName.Trim();
            String traloi = txt_traloi.TextName.Trim();

            if (traloi.Equals("")|| cauhoi.Equals("")|| usename.Equals("")|| nhaplai.Equals("")|| pass.Equals(""))
            {
                lb_trong.Text = "Không được để trống";
                lb_trong.Show();
                return;
            }

            if (nhaplai.Equals(pass) == false)
            {
                lb_trong.Text = "Mật khẩu không khớp nhau";
                lb_trong.Show();
                return;
            }
            byte[] input = System.Text.Encoding.ASCII.GetBytes(nhaplai);
            byte[] hast = md.ComputeHash(input);
            StringBuilder mkm = new StringBuilder();
            for (int i = 0; i < hast.Length; i++)
            {
                mkm.Append(hast[i].ToString());
            }
            Connection con = new Connection();
            nhaplai = mkm.ToString();
            byte[] input1 = System.Text.Encoding.ASCII.GetBytes(traloi);
            byte[] hast1 = md.ComputeHash(input1);
            StringBuilder traloi1 = new StringBuilder();
            for (int i = 0; i < hast1.Length; i++)
            {
               traloi1.Append(hast1[i].ToString());
            }
            traloi = traloi1.ToString();
            con.taotaikhoan(usename, nhaplai, cauhoi, traloi);
        }

        private void Taotaikhoan_Load(object sender, EventArgs e)
        {
            lb_trong.Hide();
        }
    }
}
