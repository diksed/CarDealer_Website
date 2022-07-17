using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace CarDealer_Website.Classes
{
    public class SqlConnectionClass
    {
        public static SqlConnection conn = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarDealer;Integrated Security=True");
        public static void CheckConn()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
                conn.Open();
            else
            {

            }
        }
    }
}