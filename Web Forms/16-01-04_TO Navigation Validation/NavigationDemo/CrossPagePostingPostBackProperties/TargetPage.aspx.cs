using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class TargetPage_aspx : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
		 if (Page.PreviousPage != null)
		 {
			 DropDownList ddl = (DropDownList)Page.PreviousPage.FindControl("ddlFavoriteActivity");
			 if (ddl != null)
				 lblActivity.Text = ddl.SelectedItem.ToString() + " (late-bound)";
		 }

		 lblIsPostBack.Text = IsPostBack.ToString();
		 lblIsCrossPagePostBack.Text = IsCrossPagePostBack.ToString();
		 if (Page.PreviousPage != null)
		 {
			 lblPreviousPage.Text = Page.PreviousPage.Title;
			 lblPreviousPageIsPostBack.Text = Page.PreviousPage.IsPostBack.ToString();
			 lblPreviousPageIsCrossPagePostBack.Text = Page.PreviousPage.IsCrossPagePostBack.ToString();
		 }

    }
}
