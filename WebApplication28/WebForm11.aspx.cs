using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication28
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm4.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("bookinventory.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("FirstPage.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("BookQuantity.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("charts.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteUser.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("usermanage.aspx");
        }
    }
}