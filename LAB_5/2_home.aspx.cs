using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["name"]!=null)
            {
                Label2.Text = Session["name"].ToString();
            }
            else
            {
                Response.Redirect("~/login.aspx?msg=First login here.");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach(ListItem item in ListBox1.Items)
            {
                if(item.Selected)
                {
                    Session["item"+i]= item.Value;
                    i++;
                }
            }
            Response.Redirect("~/order.aspx");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string category = RadioButtonList1.SelectedItem.Value;
            ListBox1.Items.Clear();
            if(category=="Electronics")
            {
                ListItem item1 = new ListItem("Laptop");
                Session["Laptop"] = 55000;
                ListItem item2 = new ListItem("SmartPhone");
                Session["SmartPhone"] = 15000;
                ListItem item3 = new ListItem("Pendrive");
                Session["Pendrive"] = 500;
                ListBox1.Items.Add(item1);
                ListBox1.Items.Add(item2);
                ListBox1.Items.Add(item3);
            }
            else if(category=="Books")
            {
                ListItem item1 = new ListItem("Wings Of Fire");
                Session["Wings Of Fire"] = 149;
                ListItem item2 = new ListItem("Satyana Prayogo");
                Session["Satyana Prayogo"] = 199;
                ListItem item3 = new ListItem("Totto Chan");
                Session["Totto Chan"] = 99;
                ListBox1.Items.Add(item1);
                ListBox1.Items.Add(item2);
                ListBox1.Items.Add(item3);
            }
        }
    }
}