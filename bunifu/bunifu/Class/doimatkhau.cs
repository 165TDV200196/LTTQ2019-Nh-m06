using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace bunifu.Class
{
    public partial class doimatkhau : Form
    {
        public doimatkhau()
        {
            InitializeComponent();
        }
        String name;
        public doimatkhau(String usename)
            : this()
        {
            name = usename;
        }
        MD5 md = MD5.Create();
        private void btn_tieptuc_Click(object sender, EventArgs e)
        {
            String matkhaucu = txt_matkhaucu.TextName.Trim();
            if (matkhaucu.Equals("") == true)
            {
                txt_matkhaucu.Focus();
                return;
            }
            if (txt_matkhaumoi.TextName.Trim().Equals("") == true)
            {
                txt_matkhaumoi.Focus();
                return;
            }
            byte[] input = System.Text.Encoding.ASCII.GetBytes(matkhaucu);
            byte[] hast = md.ComputeHash(input);
            StringBuilder mkm = new StringBuilder();
            for (int i = 0; i < hast.Length; i++)
            {
                mkm.Append(hast[i].ToString());
            }
            matkhaucu = mkm.ToString();
            String query = "select count(*) from Account where username='" + name + "' and password ='" + matkhaucu + "'";
            Connection con = new Connection();
            con.ketnoi(query, 1);
            if (con.kn == 0)
            {
                lb_kcx.Show();
                return;
            }

            byte[] put = System.Text.Encoding.ASCII.GetBytes(txt_matkhaumoi.Text.Trim());
            byte[] hasta = md.ComputeHash(put);
            StringBuilder km = new StringBuilder();
            for (int i = 0; i < hasta.Length; i++)
            {
                km.Append(hasta[i].ToString());
            }

            string query1 = "update Account set password='" + km + "' where username = '" + name + "'";
            con.ketnoi(query1, 2);
            if (con.kn1 == 0)
            {
                lb_thanhcong.Show();
            }

        }

        private void doimatkhau_Load(object sender, EventArgs e)
        {
            lb_kcx.Hide();
            lb_thanhcong.Hide();
        }

        private void txt_matkhaucu_Load(object sender, EventArgs e)
        {
            if (txt_matkhaucu.TextName.Equals("") == true)
            {
                lb_kcx.Hide();
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
