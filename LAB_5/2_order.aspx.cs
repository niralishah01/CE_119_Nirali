using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Schema;

namespace WebApplication3
{
    public partial class order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["name"]!=null)
            {
                Label3.Text = Session["name"].ToString();
                int cost = 0,total_cost=0;
                for(int i=0;i<3;i++)
                {
                    //Response.Write(i);
                    if(Session["item"+i]!=null)
                    {
                        switch(i)
                        {
                            case 0:
                                Label6.Text = Session["item"+i].ToString();
                                Label7.Text = Session[Label6.Text].ToString();
                                cost = Int32.Parse(Label7.Text);
                                break;
                            case 1:
                                Label8.Text = Session["item"+i].ToString();
                                Label9.Text = Session[Label8.Text].ToString();
                                cost = Int32.Parse(Label9.Text);
                                break;
                            case 2:
                                Label10.Text = Session["item"+i].ToString();
                                Label11.Text = Session[Label10.Text].ToString();
                                cost = Int32.Parse(Label11.Text);
                                break;

                        }
                        total_cost += cost;
                        //Response.Write(Session[i]);
                    }
                }
                Label13.Text = total_cost.ToString();
            }
            else
            {
                Response.Redirect("~/login.aspx?msg=First Login here");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("login.aspx?msg=First login here");
        }
    }
}