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
    public partial class ucl_hoadon : UserControl
    {
        public ucl_hoadon()
        {
            InitializeComponent();
            txt_mahd.Enabled = false;
        }
        int i, index, id;
        private void ucl_hoadon_Load(object sender, EventArgs e)
        {
            setControls(true);
            Display();
            loadcombox();
        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            setControls(false);
            i = 1;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            String manv, makh, masp;
            String ngaythang, soluong;
            try
            {
                manv = cbo_manv.SelectedValue.ToString();
                makh = cbo_makh.SelectedValue.ToString();
                masp = cbo_sanpham.SelectedValue.ToString();
                soluong = txt_soluong.Text.Trim();
                if (soluong.Equals(""))
                {
                    txt_soluong.Focus();
                    return;
                }
                ngaythang = date.Value.ToString("yyyy-MM-dd");
            }
            catch
            {
                MessageBox.Show("Bạn chưa nhập thông tin hoặc sai định dạng !", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn lưu thông tin vừa nhập ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connec_hoadon hd = new Connec_hoadon();
            hd.luusp(manv, makh, ngaythang, masp, soluong, i, id);
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
            id = (int)dgv_hoadon.Rows[index].Cells[0].Value;
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            int id = (int)dgv_hoadon.Rows[index].Cells[0].Value;
            DialogResult dr = new System.Windows.Forms.DialogResult();
            dr = MessageBox.Show("Bạn có muốn xóa thông tin người dùng này ?", "thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == System.Windows.Forms.DialogResult.No) return;
            Connec_hoadon hd = new Connec_hoadon();
            hd.Deletesp(id);
            Display();
        }
        private void setControls(bool s)
        {
            btn_new.Enabled = s;
            btn_save.Enabled = !s;
            btn_cancel.Enabled = !s;
            btn_edit.Enabled = s;
            btn_delete.Enabled = s;

            //--------------------------------
            cbo_manv.Enabled = !s;
            date.Enabled = !s;
            txt_soluong.Enabled = !s;
            cbo_sanpham.Enabled = !s;
            cbo_makh.Enabled = !s;
        }
        private void loadcombox()
        {
            Connec_hoadon hd = new Connec_hoadon();
            hd.loadcombonv();
            hd.loadcombokh();
            hd.loadcombosp();
            cbo_manv.DataSource = hd.table1;
            cbo_makh.DataSource = hd.table2;
            cbo_sanpham.DataSource = hd.table3;
            cbo_makh.DisplayMember = "Tên khách hàng";
            cbo_makh.ValueMember = "MaKH";
            cbo_manv.DisplayMember = "Tên nhân viên";
            cbo_manv.ValueMember = "MaNV";
            cbo_sanpham.DisplayMember = "Tensanpham";
            cbo_sanpham.ValueMember = "MaSP";
        }
        private void Display()
        {
            Connec_hoadon hd = new Connec_hoadon();
            hd.Search(txt_search.Text);
            dgv_hoadon.DataSource = hd.table;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Connec_hoadon hd = new Connec_hoadon();
            hd.Search(txt_search.Text);
            Excel.Application exApp;
            Excel.Workbook exBook;
            Excel.Worksheet exSheet;
            Excel.Range exRange;
            exApp = new Excel.Application();
            exBook = (Excel.Workbook)(exApp.Workbooks.Add(true));
            exSheet = (Excel.Worksheet)exBook.ActiveSheet;
            int iRow = 8;
            exSheet.Cells[1, 2] = "Hóa đơn mua bán cửa hàng buôn bán vật liệu xây dựng";
            exSheet.Range["B1", "B1"].Font.Bold = true;
            exSheet.Range["B1", "I1"].MergeCells = true;
            exSheet.Range["B1", "I1"].Font.Size = 16;
            exSheet.Range["B1", "I1"].HorizontalAlignment = 3;
            exSheet.Range["A1", "K100"].Font.Name = "Times New Roman";
            exSheet.Range["A2", "K100"].Font.Size = 14;
            exSheet.Cells[7, 2] = "STT";
            exSheet.Cells[7, 3] = "Mã hóa đơn";
            exSheet.Cells[7, 4] = "Tên nhân viên";
            exSheet.Cells[7, 5] = "Tên khách hàng";
            exSheet.Cells[7, 6] = "Tên sản phẩm";
            exSheet.Cells[7, 7] = "Số lượng";
            exSheet.Cells[7, 8] = "Tổng tiền";
            exSheet.Cells[7, 9] = "Ngày bán";
            for (int i = 0; i < hd.table.Rows.Count; i++)
            {
                exSheet.Cells[iRow, 2] = (i+1).ToString();
                exSheet.Cells[iRow, 3] = hd.table.Rows[i]["Mã hóa đơn"].ToString();
                exSheet.Cells[iRow, 4] = hd.table.Rows[i]["Tên nhân viên"].ToString();
                exSheet.Cells[iRow, 5] = hd.table.Rows[i]["Tên khách hàng"].ToString();
                exSheet.Cells[iRow, 6] = hd.table.Rows[i]["Tên sản phẩm"].ToString();
                exSheet.Cells[iRow, 7] = hd.table.Rows[i]["Số lượng"].ToString();
                exSheet.Cells[iRow, 8] = hd.table.Rows[i]["Tổng tiền"].ToString();
                exSheet.Cells[iRow, 9] = hd.table.Rows[i]["Ngày bán"].ToString();
                iRow++;
            }
            exRange = exSheet.get_Range("B7", "I" + (iRow - 1).ToString());
            exRange.Borders.Color = Color.Black.ToArgb();
            exSheet.Range["B7"].ColumnWidth = 10.56;
            exSheet.Range["C7"].ColumnWidth = 10.56;
            exSheet.Range["D7"].ColumnWidth = 13.44;
            exSheet.Range["E7"].ColumnWidth = 14.56;
            exSheet.Range["F7"].ColumnWidth = 11.89;
            exSheet.Range["G7"].ColumnWidth = 10.11;
            exSheet.Range["H7"].ColumnWidth = 10.11;
            exSheet.Range["I7"].ColumnWidth = 15.56;

            exSheet.Range["B7", "I7"].Font.Bold = true;
            exSheet.Range["B2", "I" + (iRow - 1).ToString()].HorizontalAlignment = 3;
            exApp.UserControl = false;
            exApp.Visible = true;

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Connec_hoadon hd = new Connec_hoadon();
            hd.Search(txt_search.Text);
            dgv_hoadon.DataSource = hd.table;
        }

        private void dgv_hoadon_Click(object sender, EventArgs e)
        {
            index = dgv_hoadon.CurrentRow.Index;
            txt_mahd.Text = dgv_hoadon.Rows[index].Cells[0].Value.ToString();
            txt_soluong.Text = dgv_hoadon.Rows[index].Cells[4].Value.ToString();
        }
    }
}
