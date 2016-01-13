using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEbFormValidation
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ButtonClick(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                Label1.Text = "Page is Valid!";
            }
            else
            {
                Label1.Text = "Some of the required fields are empty";
            }
        }
    }
}