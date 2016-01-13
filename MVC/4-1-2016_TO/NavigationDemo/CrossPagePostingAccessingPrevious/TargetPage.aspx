<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TargetPage.aspx.cs" Inherits="TargetPage_aspx" %>
<%@ PreviousPageType  VirtualPath="~/Default.aspx" %>  

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
    
    </div>
    </form>
</body>
</html>
