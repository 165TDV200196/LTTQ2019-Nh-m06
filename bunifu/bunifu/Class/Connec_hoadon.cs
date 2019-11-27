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
    class Connec_hoadon
    {
        SqlConnection connection;
        SqlCommand command;
        public DataTable table, table1, table2, table3;
        string constr = Connection.constr;
        public void Search(String name)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            string query = "select hd.MaHD as[Mã hóa đơn],(nv.[First name]+' '+nv.[Last name])as [Tên nhân viên]," +
                "(Kh.[First Name]+' '+kh.[Last Name]) as [Tên khách hàng] ,sp.Tensanpham as [Tên sản phẩm]," +
                " ct.Soluong as [Số lượng],(sp.Dongia*ct.Soluong)as [Tổng tiền],hd.Ngayban as [Ngày bán] from tbl_hoadon hd " +
                "join tbl_khachhang kh on hd.MaKH= kh.maKH " +
                "join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD " +
                "join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
                "join tbl_nhanvien nv on nv.MaNV=hd.MaNV  where kh.[Last Name] like N'%" + name + "%'";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
        void nhap(String manv, String makh, String ngaythang)
        {
            command.Parameters.AddWithValue("manv", manv);
            command.Parameters.AddWithValue("makh", makh);
            command.Parameters.AddWithValue("ngaythang", ngaythang);
        }
        public void luusp(String manv, String makh, String ngaythang, String masp, String soluong, int i, int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            switch (i)
            {
                case 1:
                    String query = "insert into tbl_HoaDon(manv,makh,Ngayban)" +
                               "values(@manv,@makh,@ngaythang)";
                    command = new SqlCommand(query, connection);
                    nhap(manv, makh, ngaythang);
                    command.ExecuteNonQuery();
                    demhoadon();
                    String query2 = "insert into tbl_CTHoaDon (MaHD,MaSP,soluong)values(" + s + "," + masp + "," + soluong + ")";
                    connection.Open();
                    command = new SqlCommand(query2, connection);
                    command.ExecuteNonQuery();
                    break;
                case 2:
                    String query1 = "update tbl_HoaDon set MaNV=@manv,MaKH=@makh,Ngayban=@ngaythang where MaHD=" + id + " " +
                    " Update tbl_CTHoaDon set MaSP=" + masp + ",Soluong=" + soluong + " where MaHD=" + id + "";
                    command = new SqlCommand(query1, connection);
                    nhap(manv, makh, ngaythang);
                    command.ExecuteNonQuery();
                    break;
            }

            connection.Close();
        }int s;
        public void demhoadon()
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select MAX(MaHD) from tbl_HoaDon ";
            command = new SqlCommand(query, connection);
            DataTable td = new DataTable();
            SqlDataAdapter a = new SqlDataAdapter(command);
            a.Fill(td);
            s = (int)td.Rows[0][0];
            connection.Close();
        }
        public void Deletesp(int id)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "delete from tbl_CTHoaDon where MaHD =@ID  delete from tbl_hoadon where Mahd=@ID ";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("ID", id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void loadcombonv()
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select manv,([First name]+' '+[Last name])as [Tên nhân viên]  from tbl_nhanvien";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table1 = new DataTable();
            adap.Fill(table1);
            connection.Close();
        }
        public void loadcombokh()
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select maKH,([First name]+' '+[Last name])as [Tên khách hàng]  from tbl_khachhang";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table2 = new DataTable();
            adap.Fill(table2);
            connection.Close();
        }
        public void loadcombosp()
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select * from tbl_SanPham";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table3 = new DataTable();
            adap.Fill(table3);
            connection.Close();
        }

    }
}
