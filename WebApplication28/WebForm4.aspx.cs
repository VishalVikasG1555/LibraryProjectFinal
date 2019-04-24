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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection myConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString"].ConnectionString);
                myConnection.Open();
                String query = "insert into LOGIN (FirstName, LastName, UserId, Password, Role)values(@FirstName, @LastName, @UserId, @Password, @Role)";
                SqlCommand command = new SqlCommand(query, myConnection);
                command.Parameters.AddWithValue("@FirstName", TextBox1.Text);
                command.Parameters.AddWithValue("@LastName", TextBox2.Text);
                command.Parameters.AddWithValue("@UserId", TextBox3.Text);
                command.Parameters.AddWithValue("@Password", TextBox4.Text);
                command.Parameters.AddWithValue("@Role", DropDownList1.SelectedValue);
               
                command.ExecuteNonQuery();

                HttpCookie cookie = new HttpCookie("User");
                cookie["UserID"] = TextBox3.Text;
                cookie["Password"] = TextBox4.Text;
                cookie.Expires = DateTime.Now.AddDays(30);
                Response.Cookies.Add(cookie);


                Response.Redirect("UserDetEmail.aspx");
                myConnection.Close();
            }
            catch (Exception ex)
            {


              
                Response.Write("error connecting to login" + ex.ToString());
            }
            
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
