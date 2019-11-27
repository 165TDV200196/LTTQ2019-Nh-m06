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
    public partial class ucl_sanpham : UserControl
    {
        public ucl_sanpham()
        {
            InitializeComponent();
        }

        int i;
        int a;
        int index;



        private void display()
        {
            Connec_sanpham sp = new Connec_sanpham();
            String name = txt_search.Text;
            sp.Search(name);
            dgv_sanpham.DataSource = sp.table;
        }
        private void setControls(bool s)
        {
            btn_new.Enabled = s;
            btn_save.Enabled = !s;
            btn_cancel.Enabled = !s;
            btn_edit.Enabled = s;
            btn_delete.Enabled = s;

            //--------------------------------
            txt_tensanpham.Enabled = !s;
            txt_dongia.Enabled = !s;
        }

        private void ucl_sanpham_Load(object sender, EventArgs e)
        {
            setControls(true);
            display();
        }

        private void btn_new_Click_2(object sender, EventArgs e)
        {
            setControls(false);
            txt_tensanpham.Focus();
            i = 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String tensp;
            double dongia = 0;
            tensp = txt_tensanpham.Text.Trim();
            if (tensp.Equals(""))
            {
                MessageBox.Show("Không thông tin nào được bỏ trống!", "Lỗi bỏ trống giá trị!", MessageBoxButtons.OK);
                return;
            }
            try
            {
                dongia = Convert.ToDouble(txt_dongia.Text);

            }
            catch
            {
                MessageBox.Show("Đơn giá chưa nhập hoặc sai định dạng !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn lưu thông tin vừa nhập ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connec_sanpham sp = new Connec_sanpham();
            sp.luusp(tensp, dongia, i, a);
            display();
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
            a = (int)dgv_sanpham.Rows[index].Cells[0].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_sanpham.Rows[index].Cells[0].Value;
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa thông tin người dùng này ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connec_sanpham sp = new Connec_sanpham();
            sp.Deletesp(id);
            display();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Connec_sanpham sp = new Connec_sanpham();
            String name = txt_search.TextName;
            sp.Search(name);
            dgv_sanpham.DataSource = sp.table;
        }

        private void dgv_sanpham_Click_1(object sender, EventArgs e)
        {
            index = dgv_sanpham.CurrentCell.RowIndex;
            txt_tensanpham.Text = dgv_sanpham.Rows[index].Cells[1].Value.ToString();
            txt_dongia.Text = dgv_sanpham.Rows[index].Cells[2].Value.ToString();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
