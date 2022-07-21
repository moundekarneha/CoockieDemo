using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace CoockieDemo
{
    public partial class CoockiePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn1_Click(object sender, EventArgs e)
        {
            HttpCookie cookie = new HttpCookie("Mycookie");
            cookie["val1"] = txt1.Text;
            cookie["val2"] = txt2.Text;
           // cookie.Value = txt1.Text;
            cookie.Expires= DateTime.Now.AddSeconds(30);
            Response.Cookies.Add(cookie);
            Response.Redirect("default.aspx");
        }
    }
}