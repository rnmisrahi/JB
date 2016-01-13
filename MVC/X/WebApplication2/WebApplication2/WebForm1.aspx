<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Required Field Validation</title>
</head>
<body>
    <h3>
        <font face="Verdana">Bug Report</font>
    </h3>
    <form runat="server" id="frmBugs">
        <div align="center">
            <table bgcolor="gainsboro" cellpadding="10" style="height: 281px">
                <tr valign="top">
                    <td colspan="3">
                        <!-- Display error messages -->
                        <asp:Label ID="lblMsg"
                            Text="Please report your bug here"
                            ForeColor="red" Font-Name="Verdana"
                            Font-Size="10" runat="server" />
                        <br>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <font face="Verdana" size="2">Book</font>
                    </td>
                    <td style="width: 290px">
                        <!-- Drop down list with the books (must pick one) -->
                        <asp:DropDownList ID="ddlBooks" runat="server">
                            <asp:ListItem Value="75">-- Please Pick A Book --</asp:ListItem>
                            <asp:ListItem>Programming ASP.NET</asp:ListItem>
                            <asp:ListItem>Programming .NET Windows Applications</asp:ListItem>
                            <asp:ListItem>Programming C#</asp:ListItem>
                            <asp:ListItem>Programming Visual Basic 2005</asp:ListItem>
                            <asp:ListItem>
                        Teach Yourself C++ In 21 Days
                            </asp:ListItem>
                            <asp:ListItem>
                        Teach Yourself C++ In 24 Hours
                            </asp:ListItem>
                            <asp:ListItem>TY C++ In 10 Minutes</asp:ListItem>
                            <asp:ListItem>TY More C++ In 21 Days</asp:ListItem>
                            <asp:ListItem>C++ Unleashed</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <!-- Validator for the drop down -->
                    <td align="center" rowspan="1">
                        <asp:RequiredFieldValidator
                            ID="reqFieldBooks"
                            ControlToValidate="ddlBooks"
                            InitialValue="75"
                            Width="100%" runat="server" EnableClientScript="False">
                     Please choose a book
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right">
                        <!-- Radio buttons for the edition -->
                        <font face="Verdana" size="2">Edition:</font>
                    </td>
                    <td style="width: 290px">
                        <asp:RadioButtonList ID="rblEdition"
                            RepeatLayout="Table" runat="server">
                            <asp:ListItem>1st</asp:ListItem>
                            <asp:ListItem>2nd</asp:ListItem>
                            <asp:ListItem>3rd</asp:ListItem>
                            <asp:ListItem>4th</asp:ListItem>
                        </asp:RadioButtonList>
                    </td>
                    <!-- Validator for editions -->
                    <td align="middle" rowspan="1">
                        <asp:RequiredFieldValidator
                            ID="reqFieldEdition"
                            ControlToValidate="rblEdition"
                            Display="Static"
                            Width="100%" runat="server" EnableClientScript="False">
                     Please pick an edition
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="height: 97px">
                        <font face="Verdana" size="2">Bug:</font>
                    </td>
                    <!-- Multi-line text for the bug entry -->
                    <td style="height: 97px; width: 290px;">
                        <asp:TextBox ID="txtBug" runat="server" Width="183px"
                            TextMode="MultiLine" Height="68px" />
                    </td>
                    <!-- Validator for the text box-->
                    <td style="height: 97px">
                        <asp:RequiredFieldValidator
                            ID="reqFieldBug"
                            ControlToValidate="txtBug"
                            Width="100%" runat="server" EnableClientScript="False">
                     Please provide bug details
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td style="width: 290px">
                        <asp:Button ID="btnSubmit"
                            Text="Submit Bug" runat="server" OnClick="btnSubmit_Click" />
                    </td>
                    <td></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
