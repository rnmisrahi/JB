<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CalculatorAdv.aspx.cs" Inherits="CalculatorApp.CalculatorAdv" %>

<%--Comment:
AutoEventWireup="true" includes all the events of the Page class--%>

<!DOCTYPE html>
 
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <h1>Calculator Adv</h1>
    <form id="form1" runat="server">
    <div>
        <p>
            First: <br />
            <asp:TextBox ID="txtFirst" runat="server" AutoPostBack="True"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" ControlToValidate="txtFirst" runat="server" ErrorMessage="RequiredFieldValidator"></asp:RequiredFieldValidator>
  
        </p>
        <p>
            <asp:DropDownList ID="ddlOperation" runat="server" AutoPostBack="True">
            </asp:DropDownList>
        </p>
        <p>
            Second: <br />
            <asp:TextBox ID="txtSecond" runat="server" AutoPostBack="True"></asp:TextBox>
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
