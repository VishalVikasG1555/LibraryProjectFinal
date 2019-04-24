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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm7");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString"].ConnectionString);
            conn.Open();
            string query = "select count(*) from login where UserId ='" + TextBox1.Text + "'";
            SqlCommand command = new SqlCommand(query, conn);
            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            conn.Close();

            if (temp == 1)
            {
                conn.Open();
                string checkpassword = "select Password from login where UserId ='" + TextBox1.Text + "'";
                SqlCommand comm = new SqlCommand(checkpassword, conn);
                string Password = comm.ExecuteScalar().ToString().Replace(" ", "");
                if (Password == TextBox2.Text)
                { 
                    Session["New"] = TextBox1.Text;
                    Response.Write("password is Correct");


                    HttpCookie cookie = new HttpCookie("123");
                    cookie["UserId"] = TextBox1.Text;

                    cookie.Expires = DateTime.Now.AddDays(30);
                    Response.Cookies.Add(cookie);

                    Response.Redirect("WebForm5.aspx");
                }
                else
                {
                    Response.Write("Password is wrong");
                }



            }
            else
            {
                Response.Write("Username is not correct");
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)

        {

            Response.Redirect("FirstPage");
        }
    }
    }
