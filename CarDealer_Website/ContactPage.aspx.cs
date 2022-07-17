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
    public partial class ContactPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            SqlCommand commAdd = new SqlCommand("INSERT INTO TableContact (ContactMessage,ContactMail,ContactName) VALUES (@pmsg,@pmail,@pname)",SqlConnectionClass.conn);
            SqlConnectionClass.CheckConn();
            commAdd.Parameters.AddWithValue("@pmsg",tboxMessage.Text);
            commAdd.Parameters.AddWithValue("@pmail", tboxMail.Text);
            commAdd.Parameters.AddWithValue("@pname", tboxName.Text);
            commAdd.ExecuteNonQuery();

        }
    }
}