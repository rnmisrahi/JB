<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Default_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Enter a number"></asp:Label>
        <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Submit" />
        <asp:RangeValidator ControlToValidate="txtValue" ErrorMessage="RangeValidator" ID="RangeValidator1"
            MaximumValue="20" MinimumValue="10" runat="server" Type="Integer" EnableViewState="False">Between 10 and 20 please</asp:RangeValidator>
    
    </div>
    </form>
</body>
</html>
