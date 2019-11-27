using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bunifu
{
    class Connec_doanhthu
    {
        SqlConnection connection;
        SqlCommand command;
        public DataTable table;
        string constr = Connection.constr;
        public void Search(int ngay, int thang, int nam, int i)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select hd.MaNV,hd.MaKH,ct.MaSP,sp.Tensanpham as [Tên sản phẩm] " +
                    ",ct.Soluong as [Số lượng],(sp.Dongia*ct.Soluong)as [Tổng tiền]" +
                    ",hd.Ngayban as [Ngày bán] from tbl_hoadon hd join tbl_khachhang kh on hd.MaKH= kh.maKh " +
                    " join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
                    "join tbl_nhanvien nv on nv.MaNV=hd.MaNV ";
            if (i == 0)
            {
                command = new SqlCommand(query, connection);
            }
            else
            {
                switch (i)
                {
                    case 1: String sql = query + "Where YEAR(Ngayban)=" + nam + " and MONTH(Ngayban)=" + thang + " and DAY(Ngayban)=" + ngay + "";
                        command = new SqlCommand(sql, connection);
                        break;
                    case 2: String sql1 = query + "Where YEAR(Ngayban)=" + nam + "";
                        command = new SqlCommand(sql1, connection);
                        break;
                    case 3: String sql2 = query + "Where YEAR(Ngayban)=" + nam + " and MONTH(Ngayban)=" + (thang - 1) + "";
                        command = new SqlCommand(sql2, connection);
                        break;
                    case 4: String sql3 = query + "Where YEAR(Ngayban)=" + (nam - 1) + "";
                        command = new SqlCommand(sql3, connection);
                        break;
                }
            }
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
        public void alo(int ngay, int thang, int nam)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select hd.MaNV,hd.MaKH,ct.MaSP,sp.Tensanpham as [Tên sản phẩm] " +
                    ",ct.Soluong as [Số lượng],(sp.Dongia*ct.Soluong)as [Tổng tiền]" +
                    ",hd.Ngayban as [Ngày bán] from tbl_hoadon hd join tbl_khachhang kh on hd.MaKH= kh.maKh " +
                    " join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
                    "join tbl_nhanvien nv on nv.MaNV=hd.MaNV where DAY(Ngayban)=" + ngay + " and MONTH(Ngayban)=" + thang +
                    " and YEAR(Ngayban)=" + nam + "";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
        public void alo1(int ngay)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select hd.MaNV,hd.MaKH,ct.MaSP,sp.Tensanpham as [Tên sản phẩm] " +
                    ",ct.Soluong as [Số lượng],(sp.Dongia*ct.Soluong)as [Tổng tiền]" +
                    ",hd.Ngayban as [Ngày bán] from tbl_hoadon hd join tbl_khachhang kh on hd.MaKH= kh.maKh " +
                    " join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
                    "join tbl_nhanvien nv on nv.MaNV=hd.MaNV Where DAY(Ngayban)=" + ngay + "";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
        public void alo2(int thang)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select hd.MaNV,hd.MaKH,ct.MaSP,sp.Tensanpham as [Tên sản phẩm] " +
                    ",ct.Soluong as [Số lượng],(sp.Dongia*ct.Soluong)as [Tổng tiền]" +
                    ",hd.Ngayban as [Ngày bán] from tbl_hoadon hd join tbl_khachhang kh on hd.MaKH= kh.maKh " +
                    " join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
                    "join tbl_nhanvien nv on nv.MaNV=hd.MaNV Where MONTH(Ngayban)=" + thang + "";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
        public void alo3(int nam)
        {
            connection = new SqlConnection(constr);
            connection.Open();
            String query = "select hd.MaNV,hd.MaKH,ct.MaSP,sp.Tensanpham as [Tên sản phẩm] " +
                    ",ct.Soluong as [Số lượng],(sp.Dongia*ct.Soluong)as [Tổng tiền]" +
                    ",hd.Ngayban as [Ngày bán] from tbl_hoadon hd join tbl_khachhang kh on hd.MaKH= kh.maKh " +
                    " join tbl_CTHoaDon ct on ct.MaHD=hd.MaHD join tbl_SanPham sp on sp.MaSP=ct.MaSP " +
                    "join tbl_nhanvien nv on nv.MaNV=hd.MaNV Where YEAR(Ngayban)=" + nam + "";
            command = new SqlCommand(query, connection);
            SqlDataAdapter adap = new SqlDataAdapter(command);
            table = new DataTable();
            adap.Fill(table);
        }
    }
}
