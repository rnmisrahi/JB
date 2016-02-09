<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wizard3.aspx.cs" Inherits="Wizard.Wizard3" %>
<%@ PreviousPageType VirtualPath="~/Wizard2.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <h2>Wizard 3</h2>

    <form id="form1" runat="server">
    <div>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblData"></asp:Label>
                    </td>
                </tr>

                <%--First Page--%>
                <tr hidden="hidden">
                    <td style="text-align: right" hidden="hidden">ID:</td>
                    <td hidden="hidden">
                        <asp:TextBox ID="txtId" runat="server" PlaceHolder="9-digit "></asp:TextBox>
                    </td>
                </tr>
                <tr hidden="hidden">
                    <td style="text-align: right" hidden="hidden">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" PlaceHolder="Enter Name"></asp:TextBox>
                    </td>
                </tr>
                <tr hidden="hidden">
                    <td style="text-align: right" hidden="hidden">Loves Girls:</td>
                    <td hidden="hidden">
                        <asp:CheckBox ID="cbLovesGirls" runat="server" />
                    </td>
                    <td></td>
                </tr>



                <%--Second Page--%>
                <tr hidden="hidden">
                    <td style="text-align: right" hidden="hidden">Course:</td>
                    <td>
                        <asp:DropDownList ID="ddlCourse" runat="server"
                            ToolTip="Select the Course you prefer">
                            <asp:ListItem Text="Pick a Course"></asp:ListItem>
                            <asp:ListItem Text="Jewish History"></asp:ListItem>
                            <asp:ListItem Text="MVC"></asp:ListItem>
                            <asp:ListItem Text="Are Crabs Really Immortal"></asp:ListItem>
                            <asp:ListItem Text="Terrorism"></asp:ListItem>
                            <asp:ListItem Text="Not Sure"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right" hidden="hidden">I Speak Hebrew:</td>
                    <td hidden="hidden">
                        <asp:CheckBox ID="cbHebrew" runat="server" />
                    </td>
                </tr>


                <%-- Third Page --%>
                <tr>
                    <td>
                        Comments:
                    </td>
                    <td>
                        <asp:TextBox runat="server" ID="txtComments" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>




                <%-- Buttons --%>
                <tr>
                    <td>
                        <asp:Button ID="btnPrevious" runat="server"
                            Text="Previous"
                            Style="text-align: left"
                            PostBackUrl="~/Wizard2.aspx" />
                    </td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnNext" runat="server" Text="Next"
                            Style="text-align: right" PostBackUrl="~/Default3.aspx" />

                    </td>
                </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
