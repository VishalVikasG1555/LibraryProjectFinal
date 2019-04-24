using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication28
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            HttpCookie cookie = Request.Cookies["ISBN"];
            if (cookie != null)
            {
                TextBox3.Text = cookie["ISBN"];
              
                
            }
            TextBox1.Text = DateTime.Now.ToString("yyyy/11/dd");
            TextBox2.Text = DateTime.Now.ToString("2018/12/14");
        } 

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm9.aspx");
        }
    }
}