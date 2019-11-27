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
    public partial class welcome : UserControl
    {
        public welcome()
        {
            InitializeComponent();
        }
        float chitieungay = 500000, chitieuthang = 15000000, chitieunam = 50000000;

        public void welcome_Load(object sender, EventArgs e)
        {
            display();
        }
        public void display()
        {
            showdoanhthu sdt = new showdoanhthu();
            sdt.tinhtien_ngay();
            float homnay = (sdt.c / chitieungay) * 100;
            if (homnay > 100)
            {
                ngay.Value = 100;
            }
            else
            {
                ngay.Value = (int)homnay;
            }
            sdt.tinhtien_thang();
            float thangnay = (sdt.b / chitieuthang) * 100;
            if (thangnay > 100)
            {
                thang.Value = 100;
            }
            else
            {
                thang.Value = (int)thangnay;
            }
            sdt.tinhtien_nam();
            float namnay = (sdt.a / chitieunam) * 100;
            if (namnay > 100)
            {
                nam.Value = 100;
            }
            else
            {
                nam.Value = (int)namnay;
            }
        }
    }
}
