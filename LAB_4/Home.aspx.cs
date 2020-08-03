using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace WebApplication2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label1.Text = TextBox1.Text;
            Label2.Text = RadioButtonList1.SelectedValue;
            Label3.Text = " ";
            for (int i = 0; i < CheckBoxList1.Items.Count; i++)
            {
                if (CheckBoxList1.Items[i].Selected)
                {
                    Label3.Text += CheckBoxList1.Items[i].Text + " ,";
                }
            }
            Label4.Text = TextBox2.Text;
            Label5.Text = TextBox6.Text;
            Label6.Text = DropDownList3.SelectedValue;
            Label7.Text = DropDownList4.SelectedValue;
            Label8.Text = TextBox5.Text;
        }

        protected void DropDownList3_SelectedIndexChanged(object sender, EventArgs e)
        {
                string state = DropDownList3.SelectedItem.Value;
                ListItem city1, city2;
                if (state == "Gujarat")
                {
                    city1 = new ListItem("Ahmedabad");
                    city2 = new ListItem("Vadodara");
                    DropDownList4.Items.Clear();
                    DropDownList4.Items.Add(city1);
                    DropDownList4.Items.Add(city2);
                }
                else if (state == "Maharashtra")
                {
                    city1 = new ListItem("Mumbai");
                    city2 = new ListItem("Pune");
                    DropDownList4.Items.Clear();
                    DropDownList4.Items.Add(city1);
                    DropDownList4.Items.Add(city2);
                }
        }

        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            Regex r = new Regex("[AB][0-9]{9}");
            args.IsValid = false;
            if (r.IsMatch(TextBox5.Text))
            {
                args.IsValid = true;
            }
        }
    }
}