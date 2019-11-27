using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bunifu
{
    public class Connec_nhanvien
    {
        public int i;
        SqlConnection connection;
        SqlCommand command;


        public DataTable table;
        string constr = Connection.constr;
        void nhap(String fname, String lname, String Add, String email, String phone, String yob, String gender)
        {
            command.Parameters.AddWithValue("FNAME", fname);
            command.Parameters.AddWithValue("LNAME", lname);
            command.Parameters.AddWithValue("ADD", Add);
            command.Parameters.AddWithValue("EMAIL", email);
            command.Parameters.AddWithValue("PHONE", phone);
            command.Parameters.AddWithValue("YOB", yob);
            command.Parameters.AddWithValue("Gender", gender);
        }
        public void save(String fname, String lname, String Add, String email, String phone, String yob, String gender, int a, int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "";
            switch (a)
            {
                case 1: query = "insert into tbl_nhanvien ([First name] ,[Last name],Address,Email,Phone,YOB,Gender)"
                             + "values(@FNAME,@LNAME,@ADD,@EMAIL,@PHONE,@YOB,@Gender)";
                    break;
                case 2: query = "update tbl_nhanvien set [First name]=@FNAME,[Last name]=@LNAME,Address=@ADD,Email=@EMAIL,Phone=@PHONE,YOB=@YOB,Gender=@Gender where MaNV=" + id + " ";
                    break;

            }
            command = new SqlCommand(query, connection);
            nhap(fname, lname, Add, email, phone, yob, gender);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void DeleteNV(int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "delete from tbl_nhanvien where MaNV=@ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Search(String name, int i)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "SELECT * FROM [tbl_nhanvien] WHERE [First name] LIKE N'%" + name + "%'";
            switch (i)
            {
                case 0:
                    query = "SELECT * FROM [tbl_nhanvien] WHERE [First name] LIKE N'%" + name + "%'";
                    break;
                case 1:
                    query = "SELECT * FROM [tbl_nhanvien] WHERE [Last name] LIKE N'%" + name + "%'";
                    break;
            }
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
    }
}
