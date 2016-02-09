<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Default_aspx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<script language="javascript">
   function ClientValidator(source, args)
   {
      if (args.Value % 2 == 0 || args.Value==15)
         args.IsValid=true;
      else
          args.IsValid = false;
      return;
   }
</script>

    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:TextBox ID="txtValue" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Submit" />&nbsp;&nbsp;
        <asp:CustomValidator 
        ControlToValidate="txtValue" 
        ValidateEmptyText=false
        ID="CustomValidator1" runat="server" 
        OnServerValidate="ServerValidator" ClientValidationFunction="ClientValidator">
             Please enter an even number
        </asp:CustomValidator>
    
    </div>
    </form>
</body>
</html>
