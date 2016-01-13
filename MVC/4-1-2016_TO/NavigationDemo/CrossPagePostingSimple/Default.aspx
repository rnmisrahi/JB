<%@ Page Language="C#" AutoEventWireup="true"  
	CodeFile="Default.aspx.cs" 
	Inherits="Default_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Cross-Page Posting</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<h1>Cross-Page Posting</h1>
		 <asp:Button ID="btnServerTransfer" runat="server" 
			Text="Server.Transfer" 
			OnClick="btnServerTransfer_Click" />
		 <asp:Button ID="btnRedirect" runat="server" 
			Text="Response.Redirect" 
			OnClick="btnRedirect_Click" />
		 <asp:Button ID="btnCrossPage" runat="server" 
			Text="Cross-Page Post" 
			PostBackUrl="TargetPage.aspx" />
         <a href="TargetPage.aspx">Go to Target page</a>
    </div>
    </form>
</body>
</html>
