<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wizard2.aspx.cs" Inherits="Wizard.Wizard2" %>
<%@ PreviousPageType VirtualPath="~/Wizard1.aspx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
        <h2>Wizard 2</h2>

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
                    <td style="text-align: right">ID:</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" PlaceHolder="9-digit "></asp:TextBox>
                    </td>
                </tr>
                <tr hidden="hidden">
                    <td style="text-align: right">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" PlaceHolder="Enter Name"></asp:TextBox>
                    </td>
                </tr>
                <tr hidden="hidden">
                    <td style="text-align: right">Loves Girls:</td>
                    <td>
                        <asp:CheckBox ID="cbLovesGirls" runat="server" />
                    </td>
                    <td></td>
                </tr>



                <%--Second Page--%>
                <tr>
                    <td style="text-align: right">Course:</td>
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
                    <td>
                        <asp:RequiredFieldValidator runat="server"
                            InitialValue="Pick a Course"
                            Text="Select a course or select Not Sure"
                            Display="Dynamic"
                            ControlToValidate="ddlCourse">
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">I Speak Hebrew:</td>
                    <td>
                        <asp:CheckBox ID="cbHebrew" runat="server" />
                    </td>
                </tr>


                <%-- Third Page --%>
                <tr hidden="hidden">
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
                            Style="text-align: left; width: 95px;" OnClick="btnPrevious_Click" />
                    </td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnNext" runat="server" Text="Next"
                            PostBackUrl="~/Wizard3.aspx"
                            Style="text-align: right" />

                    </td>
                </tr>
            </table>
    
    </div>
    </form>
</body>
</html>
