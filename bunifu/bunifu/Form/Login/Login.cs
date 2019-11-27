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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MD5 md = MD5.Create();
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string tk, mk;

            tk = "admin";//txt_taikhoan.Text.Trim(); //
            if (tk.Equals("") == true)
            {
                txt_taikhoan.Focus();
                return;
            }

            mk = "1";//txt_matkhau.Text.Trim(); //  
            if (mk.Equals("") == true)
            {
                txt_matkhau.Focus();
                return;
            }
            byte[] input = System.Text.Encoding.ASCII.GetBytes(mk);
            byte[] hast = md.ComputeHash(input);
            StringBuilder mkm = new StringBuilder();
            for (int i = 0; i < hast.Length; i++)
            {
                mkm.Append(hast[i].ToString());
            }
            Connection con = new Connection();
            mk = mkm.ToString();
            con.loadAccount(tk, mk);
            if (con.i == 1)
            {           
                home h = new home(tk);
                this.Hide();
                h.ShowDialog();
            }
            else
            {
                lb_saitkmk.Show();
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lb_taotaikhoan_Click(object sender, EventArgs e)
        {
            Taotaikhoan ttk = new Taotaikhoan();
            this.Hide();
            ttk.ShowDialog();
        }

        private void lb_quenmatkhau_Click(object sender, EventArgs e)
        {
            quenmatkhau qmk = new quenmatkhau();
            this.Hide();
            qmk.ShowDialog();
        }
        private void Login_Load(object sender, EventArgs e)
        {
            lb_saitkmk.Hide();
        }

        private void txt_matkhau_OnValueChanged(object sender, EventArgs e)
        {           
            txt_matkhau.isPassword = true;
        }
    }
}
