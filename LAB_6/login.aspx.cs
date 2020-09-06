using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace orderingapp
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int uid = Int32.Parse(TextBox1.Text);
            String password = TextBox2.Text;
            
            try
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                //SqlConnection conn = new SqlConnection(@"Data Source=(Local DB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NIRALI P SHAH\source\repos\orderingapp\App_Data\Database1.mdf;Integrated Security=True");
                using (conn)
                {
                    String command = "select * from users where userid=" + uid + "and password='" + password + "';";
                    SqlCommand cmd = new SqlCommand(command, conn);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr != null)
                    {
                        rdr.Read();
                        Session["uid"] = rdr[0].ToString();
                        Response.Redirect("~/product.aspx");
                    }
                    else
                    {
                        Error.Text = "Invalid user";
                    }
                }
            }
            catch (Exception err)
            {
                Error.Text = "error message:" + err.Message;
            }
        }
    }
}