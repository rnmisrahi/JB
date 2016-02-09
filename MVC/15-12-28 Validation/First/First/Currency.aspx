<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Currency.aspx.cs" Inherits="First.Currency" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="sm1" runat="server">
                <Scripts>
                    <asp:ScriptReference Name="jquery" />
                </Scripts>
            </asp:ScriptManager>
            <p>
                Shekel:
                <br />
                <asp:RangeValidator ControlToValidate="txtShekel" Text="Value Over 100 not valid" MaximumValue="100" ID="RangeValidator1" runat="server" ErrorMessage="RangeValidator" OnDataBinding="btnConvert_Click"></asp:RangeValidator>
<%--                <asp:RequiredFieldValidator ControlToValidate="txtShekel" runat="server" ErrorMessage="Enter a Value" />--%>
                <asp:TextBox ID="txtShekel" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Button ID="btnConvert" runat="server" Text="Convert" OnClick="btnConvert_Click" />
            </p>
            <p>
                Dollar:
                <asp:Label ID="lblDollar" runat="server" Text=""></asp:Label>
            </p>
        </div>
    </form>
</body>
</html>
