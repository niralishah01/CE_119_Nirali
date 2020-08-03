using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string uname = TextBox1.Text;
            string password = TextBox2.Text;
            if(uname=="admin")
            {
                if(password =="admin")
                {
                    Server.Transfer("Home.aspx");
                }
                else
                {
                    Label1.Text = "Incorrect Credentials";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                Label1.Text = "Incorrect Credentials";
            }
        }
    }
}