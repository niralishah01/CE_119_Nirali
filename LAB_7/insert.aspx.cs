using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_app2
{
    public partial class insert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext dbcontext=new DataClasses1DataContext())
            {
                Student std = new Student
                {
                    name = TextBox1.Text,
                    sem = Int32.Parse(TextBox2.Text),
                    cpi = Decimal.Parse(TextBox3.Text),
                    contactno = Int64.Parse(TextBox4.Text),
                    emailid=TextBox5.Text
                };
                dbcontext.Students.InsertOnSubmit(std);
                dbcontext.SubmitChanges();
            }
            Response.Redirect("~/update.aspx");
        }
    }
}