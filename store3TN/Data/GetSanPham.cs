using store3TN.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace store3TN.Data
{
    public class GetSanPham
    {
        static public List<SanPham> getAllSanPham()
        {
            SqlConnection conn = DBContext.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<SanPham> list = new List<SanPham>();
            while (reader.Read())
            {
                SanPham sp = new SanPham();
                sp.MaSP = reader.GetInt32(0);
                sp.MaLSP = reader.GetInt32(1);
                sp.TenSP = reader.GetString(2);
                sp.TenSeries = reader.GetString(3);
                sp.ChiTiet = reader.GetString(4);
                sp.RAM = reader.GetString(5);
                sp.DungLuong = reader.GetString(6);
                sp.MauSac = reader.GetString(7);
                sp.GiaGoc = reader.GetInt32(8);
                sp.GiaBan = reader.GetInt32(9);
                sp.SoLuong = reader.GetInt32(10);
                sp.HinhAnh = reader.GetString(11);
                sp.MoTa = reader.GetString(12);
                sp.New = reader.GetInt32(13);
                sp.Hot = reader.GetInt32(14);
                sp.SoSao = reader.GetInt32(15);
                sp.SoDanhGia = reader.GetInt32(16);
                list.Add(sp);
            }
            conn.Close();
            return list;
        }
        static public List<SanPham> getAllSanPhamHot()
        {
            SqlConnection conn = DBContext.openConnection();            // select limit 9 * from SanPham where Hot = 1 order by MaSP desc
            SqlCommand cmd = new SqlCommand("SELECT TOP 9 * FROM SanPham WHERE Hot = 1 ORDER BY MaSP DESC", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<SanPham> list = new List<SanPham>();
            while (reader.Read())
            {
                SanPham sp = new SanPham();
                sp.MaSP = reader.GetInt32(0);
                sp.MaLSP = reader.GetInt32(1);
                sp.TenSP = reader.GetString(2);
                sp.TenSeries = reader.GetString(3);
                sp.ChiTiet = reader.GetString(4);
                sp.RAM = reader.GetString(5);
                sp.DungLuong = reader.GetString(6);
                sp.MauSac = reader.GetString(7);
                sp.GiaGoc = reader.GetInt32(8);
                sp.GiaBan = reader.GetInt32(9);
                sp.SoLuong = reader.GetInt32(10);
                sp.HinhAnh = reader.GetString(11);
                sp.MoTa = reader.GetString(12);
                sp.New = reader.GetInt32(13);
                sp.Hot = reader.GetInt32(14);
                sp.SoSao = reader.GetInt32(15);
                sp.SoDanhGia = reader.GetInt32(16);
                list.Add(sp);
            }
            conn.Close();
            return list;
        }
        static public Dictionary<string, int> getSoLuongSanPham()
        {
            SqlConnection conn = DBContext.openConnection();            // count number of SanPham in table SanPham where MaLSP = 1
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE MaLSP = 1", conn);
            int count1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE MaLSP = 2", conn);
            int count2 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE MaLSP = 3", conn);
            int count3 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE MaLSP = 4", conn);
            int count4 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE MaLSP = 5", conn);
            int count5 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE MaLSP = 6", conn);
            int count6 = (int)cmd.ExecuteScalar();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("Iphone", count1);
            dict.Add("Macbook", count2);
            dict.Add("Ipad", count3);
            dict.Add("AirPods", count4);
            dict.Add("Apple Watch", count5);
            dict.Add("Phụ kiện Laptop", count6);
            conn.Close();
            return dict;
        }
        static public Dictionary<string, int> getRAM()
        {
            SqlConnection conn = DBContext.openConnection();            // count number of SanPham in table SanPham where RAM = 4GB
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE RAM = '4GB'", conn);
            int count1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE RAM = '6GB'", conn);
            int count2 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE RAM = '8GB'", conn);
            int count3 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE RAM = '16GB'", conn);
            int count4 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE RAM = '32GB'", conn);
            int count5 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE RAM = '64GB'", conn);
            int count6 = (int)cmd.ExecuteScalar();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("4GB", count1);
            dict.Add("6GB", count2);
            dict.Add("8GB", count3);
            dict.Add("16GB", count4);
            dict.Add("32GB", count5);
            dict.Add("64GB", count6);
            conn.Close();
            return dict;
        }
        static public Dictionary<string, int> getDungLuong()
        {
            SqlConnection conn = DBContext.openConnection();
            // count number of SanPham in table SanPham where DungLuong = 64GB
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE DungLuong = '32GB'", conn);
            int count1 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE DungLuong = '64GB'", conn);
            int count2 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE DungLuong = '128GB'", conn);
            int count3 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE DungLuong = '256GB'", conn);
            int count4 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE DungLuong = '512GB'", conn);
            int count5 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE DungLuong = '1TB'", conn);
            int count6 = (int)cmd.ExecuteScalar();
            cmd = new SqlCommand("SELECT COUNT(*) FROM SanPham WHERE DungLuong = '2TB'", conn);
            int count7 = (int)cmd.ExecuteScalar();

            Dictionary<string, int> dict = new Dictionary<string, int>();
            dict.Add("32GB", count1);
            dict.Add("64GB", count2);
            dict.Add("128GB", count3);
            dict.Add("256GB", count4);
            dict.Add("512GB", count5);
            dict.Add("1TB", count6);
            dict.Add("2TB", count7);
            conn.Close();
            return dict;
        }
        static public SanPham getThongTinSanPham(int maSP)
        {
            SqlConnection conn = DBContext.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM SanPham WHERE MaSP = @maSP", conn);
            cmd.Parameters.AddWithValue("@maSP", maSP);
            SqlDataReader reader = cmd.ExecuteReader();
            SanPham sp = new SanPham();
            while (reader.Read())
            {
                sp.MaSP = reader.GetInt32(0);
                sp.MaLSP = reader.GetInt32(1);
                sp.TenSP = reader.GetString(2);
                sp.TenSeries = reader.GetString(3);
                sp.ChiTiet = reader.GetString(4);
                sp.RAM = reader.GetString(5);
                sp.DungLuong = reader.GetString(6);
                sp.MauSac = reader.GetString(7);
                sp.GiaGoc = reader.GetInt32(8);
                sp.GiaBan = reader.GetInt32(9);
                sp.SoLuong = reader.GetInt32(10);
                sp.HinhAnh = reader.GetString(11);
                sp.MoTa = reader.GetString(12);
                sp.New = reader.GetInt32(13);
                sp.Hot = reader.GetInt32(14);
                sp.SoSao = reader.GetInt32(15);
                sp.SoDanhGia = reader.GetInt32(16);
            }
            conn.Close();
            return sp;
        }

    }
}
