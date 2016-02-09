<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Default_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Zip code (5-4)"></asp:Label>
        <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Submit" />&nbsp;
        <asp:RegularExpressionValidator 
        ControlToValidate="txtValue" 
        ErrorMessage="RegularExpressionValidator"
        SetFocusOnError=true
        ID="RegularExpressionValidator1" runat="server" 
        ValidationExpression="\d{5}-\d{4}">Please enter a valid 5-4 digit zip code</asp:RegularExpressionValidator>
    
    </div>
    </form>
</body>
</html>
