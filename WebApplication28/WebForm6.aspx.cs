using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace WebApplication28
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }


        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("ISBN");
            cookie["ISBN"] = TextBox3.Text;
           
            cookie.Expires = DateTime.Now.AddDays(30);
            Response.Cookies.Add(cookie);


            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString5"].ConnectionString);
            con.Open();
            string query = "update inventory Set quantity=quantity-1 where isbn = '" + TextBox3.Text + "'";
            SqlCommand com = new SqlCommand(query, con);
            com.ExecuteNonQuery();
            con.Close();

            Response.Redirect("WebForm14");
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection mycon = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString7"].ConnectionString);
                mycon.Open();
                string query = "SELECT * FROM inventory WHERE (bookname LIKE '%' + @bookname + '%' OR isbn  LIKE '%' + @isbn + '%')";
                SqlCommand sqlCmd = new SqlCommand(query, mycon);
                sqlCmd.Parameters.AddWithValue("@bookname", TextBox5.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@isbn", TextBox5.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                SqlDataAdapter sda = new SqlDataAdapter();
                sda.SelectCommand = sqlCmd;
                DataSet ds = new DataSet();
                sda.Fill(ds, "bookname");
                sda.Fill(ds, "isbn");
                GridView2.DataSource = ds;
                GridView2.DataBind();
                mycon.Close();
            }
            catch (Exception ex)
            {
                Response.Write("error" + ex.ToString());
            }

        }
    }
}