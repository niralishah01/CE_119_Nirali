using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Configuration;

namespace StudentInfoApplication
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NIRALI P SHAH\source\repos\lab6\StudentInfoApplication\App_Data\Database1.mdf;Integrated Security=True");
               // SqlConnection conn = new SqlConnection();
                //conn.ConnectionString = WebConfigurationManager.ConnectionStrings["test"].ConnectionString;
            try
            {
                using (conn)
                {
                    string name = TextBox1.Text;
                    int sem = Int32.Parse(TextBox2.Text);
                    long mobile = Int64.Parse(TextBox3.Text);
                    string eid = TextBox4.Text;
                    string command = "insert into student(name,sem,mobile_no,emailID) values('" + name + "'," + sem + "," + mobile + ",'" + eid + "')";
                    SqlCommand cmd = new SqlCommand(command, conn);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                }
            }
            catch(Exception err)
            {
                Label1.Text="error message:" + err.Message;
            }
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Edit.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/delete.aspx");
        }
    }
}