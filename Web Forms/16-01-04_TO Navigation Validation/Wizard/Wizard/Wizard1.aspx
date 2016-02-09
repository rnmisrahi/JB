<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wizard1.aspx.cs" Inherits="Wizard.Wizard1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wizard 1</title>
</head>
<body>

    <script src="Scripts/jquery-2.1.4.min.js"></script>
    <script src="Scripts/jquery.validate.unobtrusive.min.js"></script>

    <h2>Wizard 1</h2>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblData"></asp:Label>
                    </td>
                </tr>

                <%--First Page--%>
                <tr>
                    <td style="text-align: right">ID:</td>
                    <td>
                        <asp:TextBox ID="txtId" runat="server" PlaceHolder="9-digit "></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="StudentIdValidator" runat="server"
                            ControlToValidate="txtId"
                            Text="Required Field">
                            <asp:RegularExpressionValidator ID="RegularExpressionValidator1"
                                runat="server"
                                ControlToValidate="txtId"
                                Text="Field requires 9 digit"
                                ValidationExpression="\d{9}">
                            </asp:RegularExpressionValidator>
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">Name:</td>
                    <td>
                        <asp:TextBox ID="txtName" runat="server" PlaceHolder="Enter Name"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator ID="NameValidator" runat="server"
                            ControlToValidate="txtName"
                            Text="Name from 2 to 10 characters"
                            ValidationExpression=".{2,10}">

                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td style="text-align: right">Loves Girls:</td>
                    <td>
                        <asp:CheckBox ID="cbLovesGirls" runat="server" />
                    </td>
                    <td></td>
                </tr>



                <%--Second Page--%>
                <tr hidden ="hidden">
                    <td>Course:</td>
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
                <tr hidden="hidden">
                    <td>I Speak Hebrew:</td>
                    <td>
                        <asp:CheckBox ID="cbHebrew" runat="server" />
                    </td>
                </tr>


                <%-- Third Page --%>
                <tr hidden="hidden">
                    <td >
                        Comments:
                    </td>
                    <td >
                        <asp:TextBox runat="server" ID="txtComments" TextMode="MultiLine"></asp:TextBox>
                    </td>
                </tr>




                <%-- Buttons --%>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td></td>
                    <td>
                        <asp:Button ID="btnNext" runat="server" Text="Next"
                            Style="text-align: right" OnClick="btnNext_Click" />

                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
