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
    public partial class AddCars : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                SqlCommand commListBrands = new SqlCommand("Select * from TableBrand", SqlConnectionClass.conn);
                SqlConnectionClass.CheckConn();
                SqlDataReader dr = commListBrands.ExecuteReader();
                combobox.DataTextField = "BrandName";
                combobox.DataValueField = "BrandID";
                combobox.DataSource = dr;
                combobox.DataBind();
                dr.Close();
            }
        }

        protected void buttonSend_Click(object sender, EventArgs e)
        {
            SqlCommand commAdd = new SqlCommand("INSERT INTO TableCar (CarModel,CarBrandID,CarFuelType,CarDescription,CarContact,CarDealer,CarPhoto,CarPrice) values (@pmodel,@pbrand,@pfuel,@pdescription,@pcontact,@pdealer,@pphoto,@pprice)",SqlConnectionClass.conn);
            SqlConnectionClass.CheckConn();
            commAdd.Parameters.AddWithValue("@pmodel", tboxModel.Text);
            commAdd.Parameters.AddWithValue("@pbrand", Convert.ToInt32(combobox.SelectedValue));
            commAdd.Parameters.AddWithValue("@pfuel", tboxFuel.Text);
            commAdd.Parameters.AddWithValue("@pdescription", tboxDescription.Text);
            commAdd.Parameters.AddWithValue("@pcontact", tboxContact.Text);
            commAdd.Parameters.AddWithValue("@pdealer", tboxDealer.Text);
            commAdd.Parameters.AddWithValue("@pphoto", tboxPhoto.Text);
            commAdd.Parameters.AddWithValue("@pprice", tboxPrice.Text);
            commAdd.ExecuteNonQuery();
        }
    }
}