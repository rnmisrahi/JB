using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculatorApp
{
    public partial class Calculator : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            int first = int.Parse(txtFirst.Text);
            int second = int.Parse(txtSecond.Text);
            int result=0;
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

        protected void txtSecond_TextChanged(object sender, EventArgs e)
        {
            //Calculator();
        }
    }
}