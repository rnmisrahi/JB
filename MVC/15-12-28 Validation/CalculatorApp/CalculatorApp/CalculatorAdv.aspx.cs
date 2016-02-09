using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApp
{
    public partial class CalculatorAdv : System.Web.UI.Page
    {

        protected void Page_Prerender(object sender, EventArgs e)
        {
            //This is called every time the page is loaded. Right after it loads
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlOperation.Items.Add(new ListItem("+", "Add"));
                ddlOperation.Items.Add(new ListItem("-", "Sub"));
                ddlOperation.Items.Add(new ListItem("*", "Mul"));
                ddlOperation.Items.Add(new ListItem("/", "Div"));

            }
            else {
                Calculator();
            }

        }

        private void Calculator()
        {
            try
            {
                if (String.IsNullOrEmpty(txtFirst.Text) || String.IsNullOrEmpty(txtSecond.Text))
                {
                    lblResult.Text = "";
                    return;
                }


                int first = int.Parse(txtFirst.Text);
                int second = int.Parse(txtSecond.Text);
                int result = 0;
                switch (ddlOperation.SelectedItem.Value)
                {
                    case "Add":
                        result = first + second;
                        break;
                    case "Sub":
                        result = first - second;
                        break;
                    case "Mul":
                        result = first * second;
                        break;
                    case "Div":
                        result = first / second;
                        break;

                }
                lblResult.Text = result.ToString();
            }
            catch (Exception ex)
            {
                lblResult.Text = ex.Message;
            }

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            Calculator();
        }

        protected void txtSecond_TextChanged(object sender, EventArgs e)
        {
            Calculator();
        }
    }
}