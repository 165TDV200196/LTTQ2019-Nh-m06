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
    public partial class ucl_khohang : UserControl
    {
        public ucl_khohang()
        {
            InitializeComponent();

        }
        int i, a, index;
        private void btn_new_Click(object sender, EventArgs e)
        {
            setControls(false);
            i = 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int masp = 0;
            int soluong = 0;
            try
            {
                masp = (int)comboBox1.SelectedValue;
                soluong = Int32.Parse(txt_soluong.Text);
            }
            catch
            {
                MessageBox.Show("Đơn giá chưa nhập hoặc sai định dạng !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn lưu thông tin vừa nhập ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connec_khohang kh = new Connec_khohang();
            kh.luusp(masp, soluong, i, a);
            Display();
            setControls(true);
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            setControls(true);
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            setControls(false);
            i = 2;
            a = (int)dgv_khohang.Rows[index].Cells[0].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_khohang.Rows[index].Cells[0].Value;
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa thông tin người dùng này ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connec_khohang kh = new Connec_khohang();
            kh.Deletekh(id);
            Display();
        }
        private void Display()
        {
            Connec_khohang kh = new Connec_khohang();
            String name = txt_search.Text;
            kh.Search(name);
            dgv_khohang.DataSource = kh.table;
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Connec_khohang kh = new Connec_khohang();
            String name = txt_search.TextName;
            kh.Search(name);
            dgv_khohang.DataSource = kh.table;
        }
        private void setControls(bool s)
        {
            btn_new.Enabled = s;
            btn_save.Enabled = !s;
            btn_cancel.Enabled = !s;
            btn_edit.Enabled = s;
            btn_delete.Enabled = s;

            //--------------------------------
            comboBox1.Enabled = !s;
            txt_soluong.Enabled = !s;
        }

        private void dgv_khohang_Click(object sender, EventArgs e)
        {
            index = dgv_khohang.CurrentRow.Index;
            comboBox1.SelectedValue = dgv_khohang.Rows[index].Cells[0].Value;
            txt_soluong.Text = dgv_khohang.Rows[index].Cells[2].Value.ToString();
        }

        private void ucl_khohang_Load(object sender, EventArgs e)
        {
            setControls(true);
            Display();
            Connec_khohang kh = new Connec_khohang();
            kh.displaycombo();
            comboBox1.DataSource = kh.table1;
            comboBox1.DisplayMember = "Tensanpham";
            comboBox1.ValueMember = "MaSP";

        }
    }
}
