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
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] != null)
            {
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = WebConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
                try
                {
                    int uid = Int32.Parse(Session["uid"].ToString());
                    string command = "Select  pname, cost from [order] join [product] on [order].pid=[product].pid where [order].userid=" + uid + ";";
                    using (conn)
                    {
                        SqlCommand cmd = new SqlCommand(command, conn);
                        conn.Open();
                        SqlDataReader rdr = cmd.ExecuteReader();
                        int totalcost = 0;
                        Response.Write("Order Details:");
                        Response.Write("<table border='1px'><tr><td>Product Name</td><td>Price</td></tr>");
                        while(rdr.Read())
                        {
                            Response.Write("<tr><td>" + rdr["pname"].ToString() + "</td><td>" + rdr["cost"].ToString() + "</td></tr>");
                            totalcost += Int32.Parse(rdr["cost"].ToString());
                        }
                        Response.Write("</table>Final Amount:"+ totalcost.ToString());
                    }
                }
                catch (Exception err)
                {
                    Error.Text = err.Message;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Remove("uid");
            Response.Redirect("~/login.aspx");
        }
    }
}