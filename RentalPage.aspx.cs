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
    public partial class RentalPage : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM RentalST10071160;", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }

            txtRentalID.Text = "";
            txtCarID.Text = "";
            txtDriverID.Text = "";
            txtInspectorID.Text = "";
            txtRentalFee.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM RentalST10071160 WHERE Rental_ID = '" + txtRentalID.Text + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }

            txtRentalID.Text = "";
            txtCarID.Text = "";
            txtDriverID.Text = "";
            txtInspectorID.Text = "";
            txtRentalFee.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[RentalST10071160]
           ([Car_ID]
           ,[Driver_ID]
           ,[Inspector_ID]
           ,[Rental_Fee]
           ,[Start_Date]
           ,[End_Date])
     VALUES
           (" + txtCarID.Text + "," + txtDriverID.Text + "," + txtInspectorID.Text + "," + txtRentalFee.Text + ", '" + txtStartDate.Text + "', '" + txtEndDate.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data inserted succesfully");
            con.Close();

            txtRentalID.Text = "";
            txtCarID.Text = "";
            txtDriverID.Text = "";
            txtInspectorID.Text = "";
            txtRentalFee.Text = "";
            txtStartDate.Text = "";
            txtEndDate.Text = "";
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