using store3TN.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
namespace store3TN.Data
{
    public class DBContext
    {
        static public SqlConnection openConnection()
        {
            SqlConnection conn = new SqlConnection("Data Source=KIENVAN69CM;Initial Catalog=store3TN;Integrated Security=True");
            conn.Open();
            return conn;
        }
    }
}
