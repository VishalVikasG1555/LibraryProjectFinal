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
    public partial class DeleteUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString"].ConnectionString);
                myConnection.Open();
                String query = "delete from LOGIN where UserId = @UserId";
                SqlCommand command = new SqlCommand(query, myConnection);
                command.Parameters.AddWithValue("@UserId", TextBox1.Text);
              
                command.ExecuteNonQuery();

               


                Response.Redirect("Deletednew.aspx");
                myConnection.Close();
            }
            catch (Exception ex)
            {



                Response.Write("error connecting to login" + ex.ToString());
            }

        }
    }
}