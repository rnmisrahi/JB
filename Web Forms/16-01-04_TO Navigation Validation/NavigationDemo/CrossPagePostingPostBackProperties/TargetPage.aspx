<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TargetPage.aspx.cs" Inherits="TargetPage_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Target Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<h1>Target Page.</h1>
		
		Your favorite activity is
		 <asp:Label ID="lblActivity" runat="server" Text="unknown" />
		<br />
		<br />
		IsPostBack:		
		 <asp:Label ID="lblIsPostBack" runat="server" Text="not defined" />
		 <br />
		IsCrossPagePostBack:
		 <asp:Label ID="lblIsCrossPagePostBack" runat="server" Text="not defined" />
		 <br />
		PreviousPage:
		 <asp:Label ID="lblPreviousPage" runat="server" Text="not defined" />
		 <br />
		Previous Page IsPostBack:
		 <asp:Label ID="lblPreviousPageIsPostBack" runat="server" Text="not defined" />
		 <br />
		Previous Page IsCrossPagePostBack:
		 <asp:Label ID="lblPreviousPageIsCrossPagePostBack" runat="server" Text="not defined" />
    </div>
    </form>
</body>
</html>
