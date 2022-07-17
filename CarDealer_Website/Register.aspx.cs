using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using CarDealer_Website.Classes;

namespace CarDealer_Website
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnRegister_Click(object sender, EventArgs e)
        {
            SqlCommand commRegister = new SqlCommand("INSERT INTO TableUser (UserMail,UserPassword) VALUES (@pmail,@ppassword)",SqlConnectionClass.conn);
            SqlConnectionClass.CheckConn();
            string newPassword = Sha256Converter.ComputeSha256Hash(tboxPassword.Text);
            commRegister.Parameters.AddWithValue("@pmail",tboxMail.Text);
            commRegister.Parameters.AddWithValue("@ppassword", newPassword);
            commRegister.ExecuteNonQuery();

        }
    }
}