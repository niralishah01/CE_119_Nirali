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
    public partial class Edit : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int sid =Int32.Parse( TextBox1.Text);
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NIRALI P SHAH\source\repos\lab6\StudentInfoApplication\App_Data\Database1.mdf;Integrated Security=True");
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = WebConfigurationManager.ConnectionStrings["test"].ConnectionString;
            try
            {
                using (conn)
                {
                    string command = "Select * from student where id=" + sid;
                    SqlCommand cmd = new SqlCommand(command, conn);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        if (Int32.Parse(rdr[0].ToString()) == sid)
                        {
                            Label8.Text = "Student ID:";
                            TextBox6.Visible = true;
                            TextBox6.Text = rdr[0].ToString();
                            Label4.Text = "Name:";
                            TextBox2.Visible = true;
                            TextBox2.Text = rdr["name"].ToString();
                            Label5.Text = "Semester:";
                            TextBox3.Visible = true;
                            TextBox3.Text = rdr["sem"].ToString();
                            Label6.Text = "mobile no:";
                            TextBox4.Visible = true;
                            TextBox4.Text = rdr["mobile_no"].ToString();
                            Label7.Text = "email ID";
                            TextBox5.Visible = true;
                            TextBox5.Text = rdr["emailID"].ToString();
                            Button2.Visible = true;
                            break;
                        }
                    }
                    rdr.Close();
                }
            }
            catch(Exception er)
            {
                Label1.Text = "Error message:" + er.Message;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(TextBox6.Text);
            string name = TextBox2.Text;
            int sem = Int32.Parse(TextBox3.Text);
            long mobile = Int64.Parse(TextBox4.Text);
            string email = TextBox5.Text;
            //SqlConnection conn = new SqlConnection();
            //conn.ConnectionString = WebConfigurationManager.ConnectionStrings["test"].ConnectionString;
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\NIRALI P SHAH\source\repos\lab6\StudentInfoApplication\App_Data\Database1.mdf;Integrated Security=True");
            try
            {
                using (conn)
                {
                    string command = "update student set name='" + name + "',sem=" + sem + ",mobile_no=" + mobile + ",emailID='" + email + "'where id=" + id;                  
                    SqlCommand cmd = new SqlCommand(command, conn);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    Response.Redirect("~/Insert.aspx");
                }
            }
            catch(Exception err)
            {
                Label1.Text = "Error message: " + err.Message;
            }
        }
    }
}