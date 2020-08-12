using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class setcookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie student = new HttpCookie("student");
            student["name"] = TextBox1.Text;
            student["bday"] = TextBox2.Text;
            student["uid"] = TextBox3.Text;
            student["sem"] = TextBox4.Text;
            student["rollno"] = TextBox5.Text;
            student.Expires = System.DateTime.Now.AddHours(3);
            Response.Cookies.Add(student);
            Label8.Text = "Cookie is set";
            Button2.Enabled = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("retrievefromcookie.aspx");
        }
    }
}