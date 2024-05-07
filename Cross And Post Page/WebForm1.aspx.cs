using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cross_And_Post_Page
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Response.Write("This Is A First Or Get Request");   
            }
            else
            {
                Response.Write("This Is A Post Back Request");
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("<script>alert('This Is A Post Back Request')</script>");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Write("");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Write("");
        }
    }
}