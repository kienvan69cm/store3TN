using store3TN.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace store3TN.Data
{
    public class GetDanhGia
    {
        static public List<DanhGia> getAllDanhGia()
        {
            SqlConnection conn = DBContext.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM DanhGia", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<DanhGia> list = new List<DanhGia>();
            while (reader.Read())
            {
                DanhGia dg = new DanhGia();
                dg.MaSP = reader.GetInt32(0);
                dg.MaND = reader.GetInt32(1);
                dg.SoSao = reader.GetInt32(2);
                dg.NoiDung = reader.GetString(3);
                dg.NgayDanhGia = reader.GetDateTime(4);
                list.Add(dg);
            }
            conn.Close();
            return list;
        }
        static public Dictionary<int, Dictionary<int, int>> SLDanhGia()
        {
            Dictionary<int, Dictionary<int, int>> list = new Dictionary<int, Dictionary<int, int>>();
            List<DanhGia> DanhGia = GetDanhGia.getAllDanhGia();
            foreach (DanhGia dg in DanhGia)
            {
                if (list.ContainsKey(dg.MaSP))
                {
                    if (list[dg.MaSP].ContainsKey(dg.SoSao))
                    {
                        list[dg.MaSP][dg.SoSao]++;
                    }
                    else
                    {
                        list[dg.MaSP].Add(dg.SoSao, 1);
                    }
                }
                else
                {
                    Dictionary<int, int> temp = new Dictionary<int, int>();
                    temp.Add(dg.SoSao, 1);
                    list.Add(dg.MaSP, temp);
                }
                for (int i = 1; i <= 5; i++)
                {
                    if (!list[dg.MaSP].ContainsKey(i))
                    {
                        list[dg.MaSP].Add(i, 0);
                    }
                }
            }
            return list;
        }
    }
}