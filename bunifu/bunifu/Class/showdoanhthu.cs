using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace bunifu.Class
{
    class showdoanhthu
    {
        SqlConnection connection;
        SqlCommand command;
        public DataTable table;
        string constr = Connection.constr;
        public int a, b, c;
        public void tinhtien_nam()
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "create view tinhtiennam as select (sp.Dongia*ct.Soluong)as [Tổng tiền] " +
            "from tbl_hoadon hd join tbl_khachhang kh on hd.MaKH= kh.maKh " +
            "join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
            "join tbl_nhanvien nv on nv.MaNV=hd.MaNV where YEAR(Ngayban)=" + DateTime.Now.Year;
            
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            String ht = " select SUM([Tổng tiền]) from tinhtiennam";
            SqlCommand cm2 = new SqlCommand(ht, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cm2);
            table = new DataTable();
            adap.Fill(table);
            String xet;
            xet = table.Rows[0][0].ToString();
            if (xet.Equals(""))
            {
                a = 0;
            }
            else
            {
                a = Convert.ToInt32(xet);
            }
            String drop = "drop view tinhtiennam";
            SqlCommand cm = new SqlCommand(drop, connection);
            cm.ExecuteNonQuery();
        }
        public void tinhtien_thang()
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "create view tinhtienthang as select (sp.Dongia*ct.Soluong)as [Tổng tiền] " +
            "from tbl_hoadon hd join tbl_khachhang kh on hd.MaKH= kh.maKh " +
            "join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
            "join tbl_nhanvien nv on nv.MaNV=hd.MaNV where YEAR(Ngayban)=" + DateTime.Now.Year + " and MONTH(Ngayban)=" + DateTime.Now.Month;
            
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            String ht = " select SUM([Tổng tiền]) from tinhtienthang";
            SqlCommand cm2 = new SqlCommand(ht, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cm2);
            table = new DataTable();
            adap.Fill(table);
            String xet;
            xet = table.Rows[0][0].ToString();
            if (xet.Equals(""))
            {
                b = 0;
            }
            else
            {
                b = Convert.ToInt32(xet);
            }
            String drop = "drop view tinhtienthang";
            SqlCommand cm = new SqlCommand(drop, connection);
            cm.ExecuteNonQuery();
        }
        public void tinhtien_ngay()
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "create view tinhtienngay as select (sp.Dongia*ct.Soluong) as [Tổng tiền] " +
            "from tbl_hoadon hd join tbl_khachhang kh on hd.MaKH= kh.maKh " +
            "join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
            "join tbl_nhanvien nv on nv.MaNV=hd.MaNV where YEAR(Ngayban)=" + DateTime.Now.Year + " and MONTH(Ngayban)=" + DateTime.Now.Month + " and DAY(Ngayban)=" + DateTime.Now.Day;           
            command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
            String ht = " select SUM([Tổng tiền]) from tinhtienngay";
            SqlCommand cm2 = new SqlCommand(ht, connection);
            SqlDataAdapter adap = new SqlDataAdapter(cm2);
            table = new DataTable();
            adap.Fill(table);
            String xet ;
            xet= table.Rows[0][0].ToString();
            if(xet.Equals("")){
                c=0;
            }
            else
            {
                c = Convert.ToInt32(xet);
            }
            
            String drop = "drop view tinhtienngay";
            SqlCommand cm = new SqlCommand(drop, connection);
            cm.ExecuteNonQuery();
        }
    }
}
