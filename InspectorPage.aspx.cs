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
    public partial class InspectorPage : System.Web.UI.Page
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM InspectorST10071160;", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }

            txtInspectorID.Text = "";
            txtInspectorNo.Text = "";
            txtIName.Text = "";
            txtISurname.Text = "";
            txtIEmail.Text = "";
            txtIMobile.Text = "";
        }

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM InspectorST10071160 WHERE Inspector_ID = '" + txtInspectorID.Text + "';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    GridView1.DataSource = dr;
                    GridView1.DataBind();
                }
            }


            txtInspectorID.Text = "";
            txtInspectorNo.Text = "";
            txtIName.Text = "";
            txtISurname.Text = "";
            txtIEmail.Text = "";
            txtIMobile.Text = "";
        }

        protected void btnupdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"UPDATE[dbo].[InspectorST10071160]
   SET [Inspector_No] = '" + txtInspectorNo.Text + "',[I_Name] = '" + txtIName.Text + "',[I_Surname] = '"
                    + txtISurname.Text + "',[I_Email] = '" + txtIEmail.Text + "',[I_Mobile] = '" + txtIMobile.Text + "' WHERE [Inspector_ID]='" + txtInspectorID.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data updated succesfully");
            con.Close();

            txtInspectorID.Text = "";
            txtInspectorNo.Text = "";
            txtIName.Text = "";
            txtISurname.Text = "";
            txtIEmail.Text = "";
            txtIMobile.Text = "";
        }

        protected void btninsert_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[InspectorST10071160]
           ([Inspector_No]
           ,[I_Name]
           ,[I_Surname]
           ,[I_Email]
           ,[I_Mobile])
     VALUES
           ('" + txtInspectorNo.Text + "','" + txtIName.Text + "','" + txtISurname.Text + "', '" + txtIEmail.Text + "', '" + txtIMobile.Text + "')", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data inserted succesfully");
            con.Close();

            txtInspectorID.Text = "";
            txtInspectorNo.Text = "";
            txtIName.Text = "";
            txtISurname.Text = "";
            txtIEmail.Text = "";
            txtIMobile.Text = "";
        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=lab000000\\SQLEXPRESS;Initial Catalog=TheRideYouRentST10071160;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(@"DELETE FROM [dbo].[InspectorST10071160]
      WHERE [Inspector_ID]='" + txtInspectorID.Text + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            Response.Write("Data deleted succesfully");
            con.Close();

            txtInspectorID.Text = "";
            txtInspectorNo.Text = "";
            txtIName.Text = "";
            txtISurname.Text = "";
            txtIEmail.Text = "";
            txtIMobile.Text = "";
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