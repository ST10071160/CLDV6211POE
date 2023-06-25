using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TheRideYouRentST10071160Final
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btncar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CarPage.aspx");
        }

        protected void btninspector_Click(object sender, EventArgs e)
        {
            Response.Redirect("InspectorPage.aspx");
        }

        protected void btndriver_Click(object sender, EventArgs e)
        {
            Response.Redirect("DriverPage.aspx");
        }

        protected void btnrental_Click(object sender, EventArgs e)
        {
            Response.Redirect("RentalPage.aspx");
        }

        protected void btnreturn_Click(object sender, EventArgs e)
        {
            Response.Redirect("ReturnPage.aspx");
        }

        protected void btnexit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}