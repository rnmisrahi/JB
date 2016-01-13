<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="BookStoreApp.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            Code:
            <br /><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Name:
            <br /><asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            Author:
            <br /><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            Target group:
            <br /><asp:RadioButton ID="RadioButton1" runat="server" GroupName="target" />
            <br /><asp:RadioButton ID="RadioButton2" runat="server" GroupName="target"/>
            <br /><asp:RadioButton ID="RadioButton3" runat="server" GroupName="target"/>
        </p>
        <p>
            Category:
            <asp:DropDownList ID="DropDownList1" runat="server">
                <asp:ListItem Text="1" Value="" />
                <asp:ListItem Text="2" Value="" />
                <asp:ListItem Text="3" Value="" />
                <asp:ListItem Text="4" Value="" />
                <asp:ListItem Text="5" Value="" />
                <asp:ListItem Text="6" Value="" />
            </asp:DropDownList>
        </p>
        <p>
            Copies:
            <br /><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkIsActive" runat="server" /> Active
        </p>
        <p>
            <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
        </p>
    </div>
    </form>
</body>
</html>
