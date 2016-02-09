<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="CalculatorApp.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p>
            First: <br />
            <asp:TextBox ID="txtFirst" runat="server" AutoPostBack="True"></asp:TextBox>
        </p>
        <p>
            <asp:DropDownList ID="ddlOperation" runat="server">
                <asp:ListItem Text="+" Value="Add" />
                <asp:ListItem Text="-" Value="Sub" />
                <asp:ListItem Text="*" Value="Mul" />
                <asp:ListItem Text="/" Value="Div" />
            </asp:DropDownList>
        </p>
        <p>
            Second: <br />
            <asp:TextBox ID="txtSecond" runat="server" AutoPostBack="True" OnTextChanged="txtSecond_TextChanged"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" onclick="btnCalculate_Click"/>
        </p>
        <p>
            <asp:Label ID="lblResult" runat="server" Text=""></asp:Label>
        </p>
    </div>
        
    </form>
</body>
</html>
