using store3TN.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace store3TN.Data
{
    public class GetBinhLuan
    {
        static public List<BinhLuan> getAllBinhLuan()
        {
            SqlConnection conn = DBContext.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM BinhLuan", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<BinhLuan> list = new List<BinhLuan>();
            while (reader.Read())
            {
                BinhLuan bl = new BinhLuan();
                bl.MaBL = reader.GetInt32(0);
                try { bl.MaSP = reader.GetInt32(1); }
                catch { bl.MaSP = 0; }
                // try catch
                try { bl.MaTin = reader.GetInt32(2); }
                catch { bl.MaTin = 0; }
                bl.MaND = reader.GetInt32(3);
                bl.BLuan = reader.GetString(4);
                bl.NgayLap = reader.GetDateTime(5);
                list.Add(bl);
            }
            conn.Close();
            return list;
        }
        static public List<BinhLuan> getAllBLSP()
        {
            List<BinhLuan> list = GetBinhLuan.getAllBinhLuan();
            List<BinhLuan> listBLSP = new List<BinhLuan>();
            foreach (BinhLuan bl in list)
            {
                if (bl.MaSP != 0)
                {
                    listBLSP.Add(bl);
                }
            }
            return listBLSP;
        }
        static public List<BinhLuan> getAllTLBinhLuan()
        {
            SqlConnection conn = DBContext.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM TraLoiBinhLuan", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<BinhLuan> list = new List<BinhLuan>();
            while (reader.Read())
            {
                BinhLuan bl = new BinhLuan();
                bl.MaBL = reader.GetInt32(1);
                bl.MaSP = 0;
                bl.MaTin = 0;
                bl.MaND = reader.GetInt32(2);
                bl.BLuan = reader.GetString(3);
                bl.NgayLap = reader.GetDateTime(5);
                list.Add(bl);
            }
            conn.Close();
            return list;
        }
        static public Dictionary<int, List<BinhLuan>> TLBL()
        {
            List<BinhLuan> list = GetBinhLuan.getAllTLBinhLuan();
            Dictionary<int, List<BinhLuan>> dic = new Dictionary<int, List<BinhLuan>>();
            foreach (BinhLuan bl in list)
            {
                if (dic.ContainsKey(bl.MaBL))
                {
                    dic[bl.MaBL].Add(bl);
                }
                else
                {
                    List<BinhLuan> listBL = new List<BinhLuan>();
                    listBL.Add(bl);
                    dic.Add(bl.MaBL, listBL);
                }
            }
            return dic;
        }
    }
}