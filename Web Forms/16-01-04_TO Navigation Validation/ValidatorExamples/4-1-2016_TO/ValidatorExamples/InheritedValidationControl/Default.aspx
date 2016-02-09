<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>
<%--<%@ Register TagPrefix="custom" Namespace="ValidationLibrary" %> --%>
<%@ Register TagPrefix="custom" Namespace="ValidationLibrary" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>

    <form id="form1" runat="server">
    <div>
        <label>Enter text</label>
        <asp:TextBox runat="server" ID="txtText" />
        <custom:LengthValidator 
            runat="server" 
            ControlToValidate="txtText"
            MinLength="4"
            MaxLength="8"
            Text="Length error: 4-8" ID="lengthVal"
            />        
        <br /><br />
        <asp:Button runat="server" Text="Submit"/>
        
    </div>
    </form>
</body>
</html>
