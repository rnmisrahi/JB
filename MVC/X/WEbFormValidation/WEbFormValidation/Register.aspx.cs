using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEbFormValidation
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblValidator.Text = "Page is Valid!";
            }
            else
            {
                lblValidator.Text = "Some of the required fields are empty";
            }
        }

        protected void ValidateBtn_Click(object sender, EventArgs e)
        {
        }

        protected void btnValidate_Click(object sender, EventArgs e)
        {
            if (Page.IsValid)
            {
                lblValidator.Text = "Page is Valid.";
            }
            else
            {
                lblValidator.Text = "Page is InValid.";
            }

        }
    }
}