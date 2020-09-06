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
    public partial class product : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            /*SqlConnection conn = new SqlConnection(@"Data Source=(Local DB)\MSSQLLocalDB;
			 AttachDbFilename=C:\Users\NIRALI P SHAH\source\repos\orderingapp\App_Data\Database1.mdf 
			 Integrated Security=True");*/
            try
            {
                using (conn)
                {
                    String command = "select * from product ;";
                    SqlCommand cmd = new SqlCommand(command, conn);
                    conn.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    ProductGridView.DataSource = rdr;
                    ProductGridView.DataBind();
                    /*while (rdr.Read())
                    {
                        ListItem item = new ListItem(rdr["pname"].ToString());
                        //item.Text = rdr["pname"].ToString();
                        //Response.Write("text=" + item.Text);
                        ListBox1.Items.Add(item);
                    }*/
                }
            }
            catch (Exception err)
            {
                Error.Text = "error message:" + err.Message;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            try
            {
                using (conn)
                {
                    String command = "delete from [order] where [order].userid=" + Int32.Parse(Session["uid"].ToString()) + ";";
                    conn.Open();
                    SqlCommand cmd1 = new SqlCommand(command, conn);
                    SqlDataReader rdr = cmd1.ExecuteReader();
                    rdr.Close();

                    foreach (ListItem item in ListBox1.Items)
                    {
                        //Response.Write(item.Value);
                        if (item.Selected)
                        {
                          
                            //conn.Close();
                            command = "select * from product where pname='" + item.Value + "';";
                            SqlCommand cmd = new SqlCommand(command, conn);
                            //conn.Open();
                            rdr = cmd.ExecuteReader();
                            rdr.Read();
                            int pid = Int32.Parse(rdr[0].ToString());
                            int uid = Int32.Parse(Session["uid"].ToString());
                            rdr.Close();
                            //conn.Close();
                            command = "insert into [order](userid,pid) values(" + uid + "," + pid + ");";
                            SqlCommand cmd2 = new SqlCommand(command, conn);
                            //conn.Open();
                            rdr = cmd2.ExecuteReader();
                            //Response.Write("added successfully");
                            rdr.Close();
                        }
                    }
                }
            }
            catch (Exception err)
            {
                Error.Text = err.Message;
            }
            Response.Redirect("~/order.aspx");
        }
    }
}