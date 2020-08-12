using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Request.QueryString["msg"]!=null)
            Label3.Text = Request.QueryString["msg"];
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname = TextBox1.Text;
            string passwd = TextBox2.Text;
            if(uname=="nirali" && passwd=="nps01")
            {
                Session["name"] = uname;
                Response.Redirect("~/home.aspx");
            }
            else
            {
                Label3.Text = "Invaid username or password";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/home.aspx");
        }
    }
}