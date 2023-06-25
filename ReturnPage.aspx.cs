using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheRideYouRentST10071160Final
{
    public partial class ReturnPage : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SELECT Return_ID, Car_ID, Driver_ID, Inspector_ID, FineST10071160.Fine_ID, Return_Date, Elapsed_Date, FineST10071160.Fine_Amount FROM ReturnST10071160 INNER JOIN FineST10071160 ON FineST10071160.Fine_ID = ReturnST10071160.Fine_ID;", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }

            txtReturnID.Text = "";
            txtCarID.Text = "";
            txtDriverID.Text = "";
            txtInspectorID.Text = "";
            txtFineID.Text = "";
            txtReturnDate.Text = "";
            txtElapsedDate.Text = "";
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Return_ID, Car_ID, Driver_ID, Inspector_ID, FineST10071160.Fine_ID, Return_Date, Elapsed_Date, FineST10071160.Fine_Amount FROM ReturnST10071160 INNER JOIN FineST10071160 ON FineST10071160.Fine_ID = ReturnST10071160.Fine_ID WHERE ReturnST10071160.Return_ID = '" + txtReturnID.Text + "'; ", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }

            txtReturnID.Text = "";
            txtCarID.Text = "";
            txtDriverID.Text = "";
            txtInspectorID.Text = "";
            txtFineID.Text = "";
            txtReturnDate.Text = "";
            txtElapsedDate.Text = "";
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");

            SqlCommand scmd = new SqlCommand(@"INSERT INTO [dbo].[FineST10071160]
           ([Fine_Amount])
     VALUES
           (" + (Convert.ToInt32(txtElapsedDate.Text) * 500) + ")", con);

            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[ReturnST10071160]
           ([Car_ID]
           ,[Driver_ID]
           ,[Inspector_ID]
           ,[Fine_ID]
           ,[Return_Date]
           ,[Elapsed_Date])
     VALUES
           (" + txtCarID.Text + "," + txtDriverID.Text + "," + txtInspectorID.Text + "," + txtFineID.Text + ", '" + txtReturnDate.Text + "', " + txtElapsedDate.Text + ")", con);           

            con.Open();
            scmd.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            Response.Write("Data inserted succesfully");
            con.Close();

            txtReturnID.Text = "";
            txtCarID.Text = "";
            txtDriverID.Text = "";
            txtInspectorID.Text = "";
            txtFineID.Text = "";
            txtReturnDate.Text = "";
            txtElapsedDate.Text = "";
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