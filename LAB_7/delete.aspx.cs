using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_app2
{
    public partial class delete : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext dbcontext=new DataClasses1DataContext())
            {
                Student std = dbcontext.Students.SingleOrDefault(s => s.emailid == TextBox1.Text);
                dbcontext.Students.DeleteOnSubmit(std);
                dbcontext.SubmitChanges();    
            }
            Response.Redirect("show.aspx");
        }
    }
}