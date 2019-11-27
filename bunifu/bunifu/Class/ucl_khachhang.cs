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
    public partial class ucl_khachhang : UserControl
    {
        public ucl_khachhang()
        {
            InitializeComponent();
        }

        private void ucl_khachhang_Load(object sender, EventArgs e)
        {
            setControls(true);
            Connec_khachhang kh = new Connec_khachhang();
            display();
        }
        private void setControls(bool s)
        {
            btn_new.Enabled = s;
            btn_save.Enabled = !s;
            btn_cancel.Enabled = !s;
            btn_edit.Enabled = s;
            btn_delete.Enabled = s;
            //-------------
            txt_fullname.Enabled = !s;
            txt_email.Enabled = !s;
            txt_phone.Enabled = !s;
            txt_yob.Enabled = !s;
            txt_address.Enabled = !s;
            rbGenderfeMale.Enabled = !s;
            rbGenderMale.Enabled = !s;
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            setControls(false);
            a = 1;
            txt_fullname.Focus();
            txt_search.Enabled = false;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String fn, ln, add, email, phone;
            String yob, gender;
            int k = txt_fullname.Text.Trim().LastIndexOf(" ");
            fn = txt_fullname.Text.Substring(0,k);
            ln = txt_fullname.Text.Substring(k);
            add = txt_address.Text.Trim();
            email = txt_email.Text.Trim();
            phone = txt_phone.Text.Trim();
            yob = txt_yob.Text.Trim();
            gender = "1";
            if (fn.Equals("") || ln.Equals("") || add.Equals("") || email.Equals("") || phone.Equals("") || yob.Equals(""))
            {
                MessageBox.Show("Không thông tin nào được bỏ trống!", "Lỗi bỏ trống giá trị!", MessageBoxButtons.OK);
                return;
            }
            if (rbGenderfeMale.Checked == true)
            {
                gender = "0";
            }
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn lưu thông tin vừa nhập ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connec_khachhang kh = new Connec_khachhang();
            kh.savekh(fn, ln, add, email, phone, yob, gender, a, id);
            display();
            setControls(true);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            setControls(true);
            txt_search.Enabled = true;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            setControls(false);
            id = (int)dgv_khachhang.Rows[index].Cells[0].Value;
            a = 2;
            txt_search.Enabled = false;
        }
        int id, a;
        private void btn_delete_Click(object sender, EventArgs e)
        {
            id = (int)dgv_khachhang.Rows[index].Cells[0].Value;
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa thông tin người dùng này ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connec_khachhang kh = new Connec_khachhang();
            kh.DeleteNV(id);
            display();
        }
        int index,i;
        private void display()
        {
            String name = txt_search.Text;
            Connec_khachhang nv = new Connec_khachhang();
            nv.Search(name, i);
            dgv_khachhang.DataSource = nv.table;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                i = 0;

            }
            if (comboBox1.SelectedIndex == 1)
            {
                i = 1;

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            String name = txt_search.Text;
            Connec_khachhang nv = new Connec_khachhang();
            nv.Search(name, i);
            dgv_khachhang.DataSource = nv.table;
        }

        private void dgv_khachhang_Click(object sender, EventArgs e)
        {
            index = dgv_khachhang.CurrentRow.Index;
            txt_fullname.Text = dgv_khachhang.Rows[index].Cells[1].Value.ToString() + " " +
            dgv_khachhang.Rows[index].Cells[2].Value.ToString();
            txt_address.Text = dgv_khachhang.Rows[index].Cells[3].Value.ToString();
            txt_email.Text = dgv_khachhang.Rows[index].Cells[4].Value.ToString();
            txt_phone.Text = dgv_khachhang.Rows[index].Cells[5].Value.ToString();
            txt_yob.Text = dgv_khachhang.Rows[index].Cells[6].Value.ToString();
        }
    }
}
