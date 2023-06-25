using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheRideYouRentST10071160Final
{
    public partial class DriverPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnretrieve_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DriverST10071160;", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }

            txtDriverID.Text = "";
            txtDName.Text = "";
            txtDSurname.Text = "";
            txtStreetAddress.Text = "";
            txtProvinceAddress.Text = "";
            txtDEmail.Text = "";
            txtDMobile.Text = "";
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM DriverST10071160 WHERE Driver_ID = '" + txtDriverID.Text + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }

            txtDriverID.Text = "";
            txtDName.Text = "";
            txtDSurname.Text = "";
            txtStreetAddress.Text = "";
            txtProvinceAddress.Text = "";
            txtDEmail.Text = "";
            txtDMobile.Text = "";
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"UPDATE[dbo].[DriverST10071160]
   SET [D_Name] = '" + txtDName.Text + "',[D_Surname] = '" + txtDSurname.Text + "',[Street_Address] = '"
                    + txtStreetAddress.Text + "',[Province_Address] = '" + txtProvinceAddress.Text + "',[D_Email] = '" + txtDEmail.Text + "',[D_Mobile] = '" + txtDMobile.Text + "' WHERE [Driver_ID]='" + txtDriverID.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data updated succesfully");
            con.Close();
            
            txtDriverID.Text = "";
            txtDName.Text = "";
            txtDSurname.Text = "";
            txtStreetAddress.Text = "";
            txtProvinceAddress.Text = "";
            txtDEmail.Text = "";
            txtDMobile.Text = "";
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[DriverST10071160]
           ([D_Name]
           ,[D_Surname]
           ,[Street_Address]
           ,[Province_Address]
           ,[D_Email]
           ,[D_Mobile])
     VALUES
           ('" + txtDName.Text + "','" + txtDSurname.Text + "','" + txtStreetAddress.Text + "','" + txtProvinceAddress.Text + "', '" + txtDEmail.Text + "', '" + txtDMobile.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data inserted succesfully");
            con.Close();

            txtDriverID.Text = "";
            txtDName.Text = "";
            txtDSurname.Text = "";
            txtStreetAddress.Text = "";
            txtProvinceAddress.Text = "";
            txtDEmail.Text = "";
            txtDMobile.Text = "";
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[DriverST10071160]
      WHERE [Driver_ID]='" + txtDriverID.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data deleted succesfully");
            con.Close();

            txtDriverID.Text = "";
            txtDName.Text = "";
            txtDSurname.Text = "";
            txtStreetAddress.Text = "";
            txtProvinceAddress.Text = "";
            txtDEmail.Text = "";
            txtDMobile.Text = "";
        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }

        protected void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}