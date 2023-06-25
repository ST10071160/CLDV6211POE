using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;


namespace TheRideYouRentST10071160Final
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        protected void btnnext_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM LoginST10071160 WHERE username = '" + txtusername.Text + "' AND password = '" + txtpassword.Text +"';", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows == true)
                {
                    Response.Redirect("MainPage.aspx");
                }
                else
                {
                    lblError.Text = "Error, username or password is incorrect";
                }
            }
            
        }
    }
}