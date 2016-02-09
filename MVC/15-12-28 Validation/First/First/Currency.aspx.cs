using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace First
{
    public partial class Currency : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnConvert_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtShekel.Text))
            {
                double shekel = double.Parse(txtShekel.Text);
                double dollar = shekel / 4;
                lblDollar.Text = dollar.ToString();
            }
        }
    }
}