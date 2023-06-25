using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace TheRideYouRentST10071160Final
{
    public partial class CarPage : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM CarST10071160;", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }

            txtCarID.Text = "";
            txtCarNo.Text = "";
            txtCarMake.Text = "";
            txtCarModel.Text = "";
            txtBodyType.Text = "";
            txtKmTravelled.Text = "";
            txtServiceKm.Text = "";
            txtAvailable.Text = "";
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"UPDATE[dbo].[CarST10071160]
   SET [Car_No] = '" + txtCarNo.Text + "',[Car_Make] = '" + txtCarMake.Text + "',[Car_Model] = '" 
                    + txtCarModel.Text + "',[Body_Type] = '" + txtBodyType.Text + "',[Km_Travelled] = '" + txtKmTravelled.Text + "',[Service_Km] = " 
                    + txtServiceKm.Text + ",[Available] = '" + txtAvailable.Text + "' WHERE [Car_ID]='" + txtCarID.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data updated succesfully");
            con.Close();

            txtCarID.Text = "";
            txtCarNo.Text = "";
            txtCarMake.Text = "";
            txtCarModel.Text = "";
            txtBodyType.Text = "";
            txtKmTravelled.Text = "";
            txtServiceKm.Text = "";
            txtAvailable.Text = "";
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[CarST10071160]
           ([Car_No]
           ,[Car_Make]
           ,[Car_Model]
           ,[Body_Type]
           ,[Km_Travelled]
           ,[Service_Km]
           ,[Available])
     VALUES
           ('" + txtCarNo.Text + "','" + txtCarMake.Text + "','" + txtCarModel.Text + "', '" + txtBodyType.Text + "', " + txtKmTravelled.Text + ", " + txtServiceKm.Text + ", '" + txtAvailable.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data inserted succesfully");
            con.Close();

            txtCarID.Text = "";
            txtCarNo.Text = "";
            txtCarMake.Text = "";
            txtCarModel.Text = "";
            txtBodyType.Text = "";
            txtKmTravelled.Text = "";
            txtServiceKm.Text = "";
            txtAvailable.Text = "";
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[CarST10071160]
      WHERE [Car_ID]='" + txtCarID.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data deleted succesfully");
            con.Close();


            txtCarID.Text = "";
            txtCarNo.Text = "";
            txtCarMake.Text = "";
            txtCarModel.Text = "";
            txtBodyType.Text = "";
            txtKmTravelled.Text = "";
            txtServiceKm.Text = "";
            txtAvailable.Text = "";
        }

        protected void btnhome_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainPage.aspx");
        }

        protected void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM CarST10071160 WHERE Car_ID = '" + txtCarID.Text + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }


            txtCarID.Text = "";
            txtCarNo.Text = "";
            txtCarMake.Text = "";
            txtCarModel.Text = "";
            txtBodyType.Text = "";
            txtKmTravelled.Text = "";
            txtServiceKm.Text = "";
            txtAvailable.Text = "";
        }
    }
}