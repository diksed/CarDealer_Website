using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CarDealer_Website.Classes;
using System.Data;

namespace CarDealer_Website
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand commLogin = new SqlCommand("SELECT * FROM TableUser where UserMail=@pmail and UserPassword = @ppassword",SqlConnectionClass.conn);
            SqlConnectionClass.CheckConn();
            string shaPassword = Sha256Converter.ComputeSha256Hash(tboxPassword.Text);
            commLogin.Parameters.AddWithValue("@pmail", tboxMail.Text);
            commLogin.Parameters.AddWithValue("@ppassword", shaPassword);
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(commLogin);
            da.Fill(dt);
            if (dt.Rows.Count > 0)
                Response.Write("Successfully logged in!");
            else
            {
                Response.Write("Mail address or password is incorrect!");
            }
        }
    }
}