<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Untitled Page</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table>
            <tr>
                <td>
                    <asp:Label runat="server">Name, g1 </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtName" runat="server" Style="position: static"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="txtName" ErrorMessage="RequiredFieldValidator" Style="position: static"
                        ValidationGroup="g1"></asp:RequiredFieldValidator>
                    <asp:RangeValidator></asp:RangeValidator>
                    <asp:ValidationSummary DisplayMode=""/>
                    <asp:CompareValidator></asp:CompareValidator>
                    <asp:RegularExpressionValidator></asp:RegularExpressionValidator>
                    <asp:DynamicValidator />
                    <asp:CustomValidator></asp:CustomValidator>
                    <asp:CustomValidator></asp:CustomValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server">Number (type), g1 </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtNumber" runat="server" Style="position: static"></asp:TextBox>
                </td>
                <td>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToValidate="txtNumber" ErrorMessage="CompareValidator" Operator="DataTypeCheck"
                        Style="position: static" Type="Currency" ValidationGroup="g1"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server">Val1 (10-30), g2 </asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtVal1" runat="server" Style="position: static"></asp:TextBox>
                </td>
                <td>
                    <asp:RangeValidator ID="RangeValidator1" runat="server" 
                        ControlToValidate="txtVal1" ErrorMessage="RangeValidator" MaximumValue="30" MinimumValue="10"
                        Style="position: static" Type="Integer" ValidationGroup="g2"></asp:RangeValidator>&nbsp;<br />
                </td>
                <td>
                    <tr>
                        <td>
                            <asp:Label ID="Label3" runat="server">Val2 (100-200), Empty group </asp:Label>
                        </td>
                        <td>
                            <asp:TextBox ID="txtVal2" runat="server" Style="position: static"></asp:TextBox>&nbsp;
                        </td>
                        <td>
                            <asp:RangeValidator ID="RangeValidator2" runat="server" 
                                ControlToValidate="txtVal2" ErrorMessage="RangeValidator" MaximumValue="200" MinimumValue="100"
                                Style="position: static" Type="Integer"></asp:RangeValidator>
                        </td>
                        </tr>
        </table>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Style="position: static" Text="Validate g1"
            ValidationGroup="g1" CausesValidation="True" />
        <asp:Button ID="Button2" runat="server" Style="position: static" Text="Validate g2"
            ValidationGroup="g2" />
        <asp:Button ID="Button3" runat="server" Style="position: static" Text="Validate Empty group" /><br />
        <asp:Button ID="btnValidateAll" runat="server" Style="position: static" Text="Validate All"
            OnClick="btnValidateAll_Click" CausesValidation="False" />
        <br />
        <br />
        <br />
        <asp:ListBox ID="lstValidators" runat="server" Style="position: static"></asp:ListBox>
    </div>
    </form>
</body>
</html>
