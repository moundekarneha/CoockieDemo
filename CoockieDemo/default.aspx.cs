using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CoockieDemo
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //string str = Request.Cookies["Mycookie"].Value;
                string str1 = Request.Cookies["Mycookie"]["val1"];
                string str2 = Request.Cookies["Mycookie"]["val2"];
                Response.Write(str1+"<br/>"+str2);
            }
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string str1 = Request.Cookies["Mycookie"]["val1"];
            string str2 = Request.Cookies["Mycookie"]["val2"];
            Response.Write(str1 + "<br/>" + str2);
        }
    }
}