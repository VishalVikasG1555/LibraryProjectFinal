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
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString3"].ConnectionString);
            conn.Open();
            string query = "select count(*) from admin where AdminUserId ='" + TextBox1.Text + "'";
            SqlCommand command = new SqlCommand(query, conn);
            int temp = Convert.ToInt32(command.ExecuteScalar().ToString());
            conn.Close();

            if (temp == 1)
            {
                conn.Open();
                string checkpassword = "select AdminPasssword from admin where AdminUserId ='" + TextBox1.Text + "'";
                SqlCommand comm = new SqlCommand(checkpassword, conn);
                string AdminPasssword = comm.ExecuteScalar().ToString().Replace(" ", "");
                if (AdminPasssword == TextBox2.Text)
                {
                    Session["New"] = TextBox1.Text;
                    Response.Write("password is Correct");
                    Response.Redirect("WebForm11.aspx");
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
    }
    }
