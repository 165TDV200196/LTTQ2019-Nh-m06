using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace bunifu
{
    class Connec_khohang
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter;
        public DataTable table,table1;
        string constr = Connection.constr;
        public void Search(String name)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "select kh.masp,sp.Tensanpham as [Tên sản phẩm],kh.Soluong as [Số lượng] from tbl_KhoHang kh join tbl_SanPham sp on kh.MaSP=sp.MaSP where sp.Tensanpham like N'%" + name + "%'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
        void nhap(int masp, int soluong)
        {
            command.Parameters.AddWithValue("masp", masp);
            command.Parameters.AddWithValue("soluong", soluong);
        }
        public void luusp(int masp, int soluong, int i, int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            try
            {
                String query = "insert into tbl_khohang (masp,soluong)"
                                        + "values(@masp,@soluong)";
                switch (i)
                {
                    case 1: query = "insert into tbl_khohang (masp,soluong)"
                                        + "values(@masp,@soluong)";
                        break;
                    case 2: query = "update tbl_khohang set soluong=@soluong where MaSP=@masp";
                        break;
                }
                command = new SqlCommand(query, connection);
                nhap(masp, soluong);
                command.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Lỗi trùng khóa chính hoặc khóa chính không tồn tại ! ", "Lỗi to rồi ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
        }
        public void Deletekh(int masp)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "delete from tbl_khohang where MaSP=" + masp;
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void displaycombo()
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select * from tbl_sanpham";
            command = new SqlCommand(query, connection);
            adapter = new SqlDataAdapter(command);
            table1 = new DataTable();
            adapter.Fill(table1);
            connection.Close();
        }
    }
}
