using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunifu
{
    class Connec_khachhang
    {
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
        public void savekh(String fname, String lname, String Add, String email, String phone, String yob, String gender, int i, int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "";
            switch (i)
            {
                case 1: query = "insert into tbl_khachhang ([First name] ,[Last name],Address,Email,Phone,YOB,Gender)"
                        + "values(@FNAME,@LNAME,@ADD,@EMAIL,@PHONE,@YOB,@Gender)";
                    break;
                case 2: query = "update tbl_khachhang set [First name]=@FNAME,[Last name]=@LNAME,Address=@ADD,Email=@EMAIL,Phone=@PHONE,YOB=@YOB,Gender=@Gender where MaKH=" + id + " ";
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
            String query = "delete from tbl_khachhang where MaKH=@ID";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void EditNV(String fname, String lname, String Add, String email, String phone, String yob, String gender, int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "update tbl_khachhang set [First name]=@FNAME,[Last name]=@LNAME,Address=@ADD,Email=@EMAIL,Phone=@PHONE,YOB=@YOB,Gender=@Gender where MaKH=@id ";
            command = new SqlCommand(query, connection);
            nhap(fname, lname, Add, email, phone, yob, gender);
            command.Parameters.AddWithValue("id", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Search(String name, int i)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "SELECT * FROM [tbl_khachhang] WHERE [First name] LIKE N'%" + name + "%'";
            switch (i)
            {
                case 0:
                    query = "SELECT * FROM [tbl_khachhang] WHERE [First name] LIKE N'%" + name + "%'";
                    break;
                case 1:
                    query = "SELECT * FROM [tbl_khachhang] WHERE [Last name] LIKE N'%" + name + "%'";
                    break;
            }
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
    }
}
