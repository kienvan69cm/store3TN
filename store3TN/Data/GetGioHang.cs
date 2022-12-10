using store3TN.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace store3TN.Data
{
    public class GetGioHang
    {
        static public GioHang getGioHang(int MaND)
        {
            SqlConnection conn = DBContext.openConnection();
            // select * from GioHang where MaND = MaND
            SqlCommand cmd = new SqlCommand("SELECT * FROM GioHang WHERE MaND = @MaND", conn);
            cmd.Parameters.AddWithValue("@MaND", MaND);
            SqlDataReader reader = cmd.ExecuteReader();
            GioHang gioHang = new GioHang();
            gioHang.ListSanPham = new List<int>();
            gioHang.ListSoLuong = new List<int>();
            while (reader.Read())
            {
                // split string to list int
                string[] listSanPham = reader.GetString(1).Split(',');
                string[] listSoLuong = reader.GetString(2).Split(',');
                for (int i = 0; i < listSanPham.Length; i++)
                {
                    gioHang.ListSanPham.Add(int.Parse(listSanPham[i]));
                    gioHang.ListSoLuong.Add(int.Parse(listSoLuong[i]));
                }
            }
            conn.Close();
            return gioHang;
        }
    }
}