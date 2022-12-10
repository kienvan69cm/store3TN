using store3TN.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace store3TN.Data
{
    public class GetNguoiDung
    {
        static public Dictionary<int, string> TenND()
        {
            SqlConnection conn = DBContext.openConnection();
            SqlCommand cmd = new SqlCommand("SELECT MaND, Ho, Ten FROM NguoiDung", conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Dictionary<int, string> list = new Dictionary<int, string>();
            while (reader.Read())
            {
                list.Add(reader.GetInt32(0), reader.GetString(1) + " " + reader.GetString(2));
            }
            conn.Close();
            return list;
        }
    }
}