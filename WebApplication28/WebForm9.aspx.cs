using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.IO;
using System.Data.SqlClient;
using System.Configuration;
namespace WebApplication28
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HttpCookie cookie = Request.Cookies["123"];
            if (cookie != null)
            {
                TextBox3.Text = cookie["UserId"];


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            MailMessage mail = new MailMessage(TextBox1.Text, TextBox3.Text);

            mail.Body = "your order is succesfully issued";

            mail.IsBodyHtml = false;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.EnableSsl = true;

            NetworkCredential networkcred = new NetworkCredential(TextBox1.Text, Label1.Text);
            smtp.UseDefaultCredentials = true;
            smtp.Credentials = networkcred;
            smtp.Port = 587;
            smtp.Send(mail);
            Response.Write("Book Successfully issued");
            
            

            Response.Redirect("WebForm10.aspx");
            {


            }
        }
        

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}