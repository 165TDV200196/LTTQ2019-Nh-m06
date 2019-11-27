using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace bunifu.Class
{
    public partial class ucl_doanhthu : UserControl
    {
        public ucl_doanhthu()
        {
            InitializeComponent();
        }


        int a;
        private void btn_search_Click(object sender, EventArgs e)
        {
            int ngay1 = 0, thang1 = 0, nam1 = 0;
            Connec_doanhthu dt = new Connec_doanhthu();
            try
            {
                switch (a)
                {
                    case 0: ngay1 = Int32.Parse(txt_ngay.Text);
                        thang1 = Int32.Parse(txt_thang.Text);
                        nam1 = Int32.Parse(txt_nam.Text);
                        dt.alo(ngay1, thang1, nam1);
                        break;
                    case 1: ngay1 = Int32.Parse(txt_ngay.Text);
                        dt.alo1(ngay1);
                        break;
                    case 2: thang1 = Int32.Parse(txt_thang.Text);
                        dt.alo2(thang1);
                        break;
                    case 3: nam1 = Int32.Parse(txt_nam.Text);
                        dt.alo3(nam1);
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập thông tin!", "Thông báo");
            }
            dgv_doanhthu.DataSource = dt.table;
        }

        private void ucl_doanhthu_Load(object sender, EventArgs e)
        {
            an();
            txt_search.Enabled = false;
        }

        private void btn_chophepnhap_Click(object sender, EventArgs e)
        {
            nhapngaythang(true);
        }

        private void btn_timngay_Click(object sender, EventArgs e)
        {
            nhapngaythang(true);
            xoadulieu();
            txt_thang.Enabled = false;
            txt_nam.Enabled = false;
            a = 1;
        }

        private void btn_timthang_Click(object sender, EventArgs e)
        {
            nhapngaythang(true);
            xoadulieu();
            txt_nam.Enabled = false;
            txt_ngay.Enabled = false;
            a = 2;
        }

        private void btn_timnam_Click(object sender, EventArgs e)
        {
            nhapngaythang(true);
            xoadulieu();
            txt_thang.Enabled = false;
            txt_ngay.Enabled = false;
            a = 2;
        }

        private void btn_homnay_Click(object sender, EventArgs e)
        {
            nhapngaythang(false);
            String date = ngay + "/" + thang + "/" + nam;
            txt_search.Text = date;
            i = 1;
            an();
        }

        private void btn_namnay_Click(object sender, EventArgs e)
        {
            nhapngaythang(false);
            txt_search.Text = nam.ToString();
            i = 2;
            an();
        }

        private void btn_thangtruoc_Click(object sender, EventArgs e)
        {
            nhapngaythang(false);
            String date = (thang - 1).ToString() + "/" + nam.ToString();
            txt_search.Text = date;
            i = 3;
            an();
        }

        private void btn_namtruoc_Click(object sender, EventArgs e)
        {
            nhapngaythang(false);
            txt_search.Text = (nam - 1).ToString();
            i = 4;
            an();
        }
        void xoadulieu()
        {
            txt_ngay.Text="";
            txt_thang.Text="";
            txt_nam.Text="";
        }
        private void an()
        {
            Connec_doanhthu dt = new Connec_doanhthu();
            dt.Search(ngay, thang, nam, i);
            dgv_doanhthu.DataSource = dt.table;
        }
        int ngay = DateTime.Today.Day;
        int thang = DateTime.Today.Month;
        int nam = DateTime.Today.Year;
        int i = 0;
        void nhapngaythang(bool s)
        {
            txt_ngay.Enabled = s;
            txt_thang.Enabled = s;
            txt_nam.Enabled = s;
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
