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
    public partial class WebForm18 : System.Web.UI.Page

    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.Visible = true;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

             try
                {
                    SqlConnection mycon = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString7"].ConnectionString);
                    mycon.Open();
                    string query = "SELECT * FROM inventory WHERE (bookname LIKE '%' + @bookname + '%' OR isbn  LIKE '%' + @isbn + '%')";
                    SqlCommand sqlCmd = new SqlCommand(query, mycon);
                    sqlCmd.Parameters.AddWithValue("@bookname", TextBox1.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@isbn", TextBox1.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    SqlDataAdapter sda = new SqlDataAdapter();
                    sda.SelectCommand = sqlCmd;
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "bookname");
                    sda.Fill(ds, "isbn");
                    GridView1.DataSource = ds;
                    GridView1.DataBind();
                    mycon.Close();
                }
                catch (Exception ex)
                {
                    Response.Write("error" + ex.ToString());
                }

                /* // Create sql connection

                 SqlConnection myconnection = new SqlConnection(ConfigurationManager.ConnectionStrings["PRO2ConnectionString7"].ConnectionString);

                 //open connection

                 myconnection.Open();

                 // Create sql querry

                 String querry = "SELECT * FROM inventory where bookname like '%" + TextBox1.Text + "%'";
                 // Create sql command

                 SqlCommand command = new SqlCommand(querry, myconnection);

                 //populate parameters in the command / querry




                 //execute querry
                 //this will insert data

                 command.ExecuteNonQuery();


                 SqlDataAdapter dataAdapter = new SqlDataAdapter();
                 dataAdapter.SelectCommand = command;


                 DataSet ds = new DataSet();
                 GridView1.Visible = false;
                 dataAdapter.Fill(ds, "bookname");

                 GridView1.Visible = true;
                 GridView1.DataSource = ds;
                 GridView1.DataBind();

                 //close connection

                 myconnection.Close();

             }
             catch (Exception ex)
             {
                 Response.Write("Error occured while entering a new student" + ex.ToString());


             }*/

            }



            }


        }

    