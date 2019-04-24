using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication28
{
    public partial class WebForm17 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString6"].ConnectionString);
            con.Open();

            string query = "declare @temp int = '"+int.Parse(TextBox2.Text)+"' update inventory Set quantity=quantity+@temp where isbn = '" + TextBox1.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();
            Response.Redirect("bookinventory.aspx");

        }
    }
}