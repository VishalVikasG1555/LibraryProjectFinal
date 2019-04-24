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
    public partial class WebForm12 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString5"].ConnectionString);
                myConnection.Open();
                String query = "insert into inventory (bookname, authorname, isbn, quantity)values(@bookname, @authorname, @isbn, @quantity)";
                SqlCommand command = new SqlCommand(query, myConnection);
                command.Parameters.AddWithValue("@bookname", TextBox1.Text);
                command.Parameters.AddWithValue("@authorname", TextBox2.Text);
                command.Parameters.AddWithValue("@isbn", TextBox3.Text);
                command.Parameters.AddWithValue("@quantity", TextBox4.Text);
              
                command.ExecuteNonQuery();
                Response.Redirect("WebForm15.aspx");
                myConnection.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error connecting to inventory" + ex.ToString());
            }
        }
    }
    }
