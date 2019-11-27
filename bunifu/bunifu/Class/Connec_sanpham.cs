using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunifu
{
    class Connec_sanpham
    {
        SqlConnection connection;
        SqlCommand command;
        public DataTable table;
        string constr = Connection.constr;
        public void Search(String name)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "SELECT * FROM [tbl_sanpham] WHERE Tensanpham LIKE N'%" + name + "%'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
        void nhap(String tensp, double dongia)
        {
            command.Parameters.AddWithValue("tensp", tensp);
            command.Parameters.AddWithValue("dongia", dongia);
        }
        public void luusp(String tensp, double dongia, int i, int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "insert into tbl_sanpham (tensanpham,dongia)"
                                    + "values(@tensp,@dongia)";
            switch (i)
            {
                case 1: query = "insert into tbl_sanpham (tensanpham,dongia)"
                                    + "values(@tensp,@dongia)";
                    break;
                case 2: query = "update tbl_sanpham set tensanpham=@tensp,dongia=@dongia where MaSP=" + id + "";
                    break;
            }
            command = new SqlCommand(query, connection);
            nhap(tensp, dongia);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Deletesp(int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "delete from tbl_sanpham where MaHD=@ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
