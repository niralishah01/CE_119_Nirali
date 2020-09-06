using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentInfoApplication
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = TextBox1.Text;
            string email = TextBox2.Text;
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = WebConfigurationManager.ConnectionStrings["test"].ConnectionString;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NIRALI P SHAH\source\repos\lab6\StudentInfoApplication\App_Data\Database1.mdf;Integrated Security=True");
            try
            {
                using (conn)
                {
                    string command = "select * from student where name='" + name + "' and emailID='" + email + "';";
                    SqlCommand cmd1 = new SqlCommand(command, conn);
                    conn.Open();
                    SqlDataReader rdr = cmd1.ExecuteReader();
                    rdr.Read();
                    int sid = Int32.Parse(rdr["id"].ToString());
                    rdr.Close();
                    command = "delete from student where id=" + sid + ";";
                    SqlCommand cmd2 = new SqlCommand(command, conn);
                    rdr = cmd2.ExecuteReader();
                    Response.Redirect("~/Insert.aspx");
                }
            }
            catch (Exception err)
            {
                error.Text = "Error message: " + err.Message;
            }
        }
    }
}