using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class Default_aspx : System.Web.UI.Page 
{
    // Page events are wired up automatically to methods 
    // with the following names:
    // Page_Load, Page_AbortTransaction, Page_CommitTransaction,
    // Page_DataBinding, Page_Disposed, Page_Error, Page_Init, 
    // Page_Init Complete, Page_Load, Page_LoadComplete, Page_PreInit
    // Page_PreLoad, Page_PreRender, Page_PreRenderComplete, 
    // Page_SaveStateComplete, Page_Unload

    protected void Page_Load(object sender, EventArgs e)
    {

    }
	protected void ServerValidator(object source, ServerValidateEventArgs e)
	{
		try
		{
            e.IsValid = false;  // Attn: this does not appear in the source code from the web site!!
			int evenNumber = Int32.Parse(e.Value);
			if (evenNumber % 2 == 0)
				e.IsValid = true;
		}
		catch (Exception)
		{
			// error handler here
		}
	}

}