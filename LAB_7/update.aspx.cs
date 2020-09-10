using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab7_app2
{
    public partial class update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using(DataClasses1DataContext context=new DataClasses1DataContext())
            {
                Student std = context.Students.SingleOrDefault(d => d.emailid == TextBox1.Text);
                TextBox2.Visible = true;
                TextBox3.Visible = true;
                TextBox4.Visible = true;
                TextBox5.Visible = true;
                TextBox6.Visible = true;
                TextBox7.Visible = true;
                TextBox2.Text = std.Id.ToString();
                TextBox3.Text = std.name.ToString();
                TextBox4.Text = std.sem.ToString();
                TextBox5.Text = std.cpi.ToString();
                TextBox6.Text = std.contactno.ToString();
                TextBox7.Text = std.emailid.ToString();
                Label1.Text = "ID:";
                Label2.Text = "Name:";
                Label3.Text = "Sem:";
                Label4.Text = "CPI:";
                Label5.Text = "Contact no:";
                Label6.Text = "Email ID:";
                Button2.Visible = true;
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            using (DataClasses1DataContext dbcontext = new DataClasses1DataContext())
            {
                Student std = dbcontext.Students.SingleOrDefault(s => s.Id ==Int32.Parse(TextBox2.Text));
                std.name = TextBox3.Text;
                std.sem = Int32.Parse(TextBox4.Text);
                std.cpi = Decimal.Parse(TextBox5.Text);
                std.contactno = Int64.Parse(TextBox6.Text);
                std.emailid = TextBox7.Text;
                dbcontext.SubmitChanges();
            }
            Response.Redirect("~/delete.aspx");
        }
    }
}