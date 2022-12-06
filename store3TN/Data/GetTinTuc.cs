using Microsoft.Data.SqlClient;
using store3TN.Data;
using store3TN.Models;
using System.Collections.Generic;
namespace store3TN.Data
{
    public class GetTinTuc
    {
        static public List<TinTuc> getAllTinTuc()
        {
            SqlConnection conn = DBContext.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TinTuc", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<TinTuc> list = new List<TinTuc>();
            while (reader.Read())
            {
                TinTuc tt = new TinTuc();
                tt.MaTin = reader.GetInt32(0);
                tt.TieuDe = reader.GetString(1);
                tt.MoTaNgan = reader.GetString(2);
                tt.NoiDung = reader.GetString(3);
                tt.HinhAnh = reader.GetString(4);
                tt.NguoiTao = reader.GetString(5);
                tt.LuotXem = reader.GetInt32(6);
                tt.NgayDang = reader.GetDateTime(7);
                list.Add(tt);
            }
            conn.Close();
            return list;
        }
        static public List<TinTuc> getTinTucPhoBien()
        {
            SqlConnection conn = DBContext.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT TOP 3 * FROM TinTuc ORDER BY LuotXem DESC", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<TinTuc> list = new List<TinTuc>();
            while (reader.Read())
            {
                TinTuc tt = new TinTuc();
                tt.MaTin = reader.GetInt32(0);
                tt.TieuDe = reader.GetString(1);
                tt.MoTaNgan = reader.GetString(2);
                tt.NoiDung = reader.GetString(3);
                tt.HinhAnh = reader.GetString(4);
                tt.NguoiTao = reader.GetString(5);
                tt.LuotXem = reader.GetInt32(6);
                tt.NgayDang = reader.GetDateTime(7);
                list.Add(tt);
            }
            conn.Close();
            return list;
        }
    }
}