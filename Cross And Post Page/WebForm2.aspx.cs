using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cross_And_Post_Page
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<font color='red'>Cross Page Submission.</font>");
            TextBox txtName = (TextBox)PreviousPage.FindControl("TextBox1");
            TextBox txtLocation = (TextBox)PreviousPage.FindControl("TextBox2");

            lblName.Text = "Welcome To WebForm3.aspx Page " + txtName.Text;
            lblLocation.Text = "Your Location: " + txtLocation.Text;
        }
    }
}