using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Threading;			//  necessary for ThreadAbortException

public partial class Default_aspx : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
    }

	protected void btnServerTransfer_Click(object sender, EventArgs e)
	 {
		 Server.Transfer("TargetPage.aspx");
        
	 }

	protected void btnRedirect_Click(object sender, EventArgs e)
	 {
		 Response.Redirect("TargetPage.aspx");
	 }
 }