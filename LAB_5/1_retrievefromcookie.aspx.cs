using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class retrievefromcookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "";
            Label2.Text = "";
            Label3.Text = "";
            Label4.Text = "";
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            Label10.Text = "";
            Label11.Text = "";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie ck = Request.Cookies["student"];
            if (ck != null)
            {
                Label1.Text = "Student Info";
                Label2.Text = "Name: ";
                Label3.Text = ck["name"].ToString();
                Label4.Text = "BirthDate: ";
                Label5.Text = ck["bday"].ToString();
                Label6.Text = "UserID: ";
                Label7.Text = ck["uid"].ToString();
                Label8.Text = "Semester: ";
                Label9.Text = ck["sem"].ToString();
                Label10.Text = "Roll No: ";
                Label11.Text = ck["rollno"].ToString();
            }
            else
            {
                Label1.Text = "Cookies are not available";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Cookies["student"].Expires = System.DateTime.Now.AddMinutes(-5);
            Label1.Text = "Cookie is deleted";
        }
    }
}