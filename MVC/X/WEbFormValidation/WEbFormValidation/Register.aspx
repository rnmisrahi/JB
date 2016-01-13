<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WEbFormValidation.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<script src="Scripts/jquery-ui-1.11.4.js"></script>
<script src="Scripts/jquery.unobtrusive-ajax.js"></script>
<body>
    <form id="form1" runat="server">
        <div style="height: 506px">

            <h2>Validation of several controls:</h2>

            <asp:Label ID="lblValidator" runat="server"></asp:Label>
            <table>
                <tr>
                    <td>ID</td>
                    <td>
                        <asp:TextBox ID="IDXX" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ControlToValidate="IDXX" ID="RV" runat="server"
                            SetFocusOnError="true" Display="Dynamic"
                            Text="Enter ID Please" EnableClientScript="False"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Name</td>
                    <td>
                        <asp:TextBox ID="Name" runat="server"  ></asp:TextBox>
                    </td>
                    <td>
                        <asp:RegularExpressionValidator
                            ID="RegularExpressionValidator1"
                            runat="server"
                            
                            ControlToValidate="Name"
                            EnableClientScript="false"
                            ClientValidationEnabled="true"
                            ValidationExpression="\w{2}\d{2}\w{2}"
                            Text="Has to have 2 alplha characters"
                            >

                        </asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td>Address</td>
                    <td>
                        <asp:TextBox ID="Address" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>DOB</td>
                    <td>
                        <asp:TextBox ID="DOBX" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Salary</td>
                    <td>
                        <asp:TextBox ID="Salary" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Salary" ValidateRequestMode="Enabled"
                            EnableClientScript="false"
                            Text="Enter Salary Please">                            
                        </asp:RequiredFieldValidator>


                    </td>
                </tr>
                <tr>
                    <td>Marital Status</td>
                    <td>
                        <asp:DropDownList ID="ddlStatus" runat="server" AutoPostBack="true">
                            <asp:ListItem Text="Select Marital Status" Value="-1" Selected="True"></asp:ListItem>
                            <asp:ListItem Text="Married" Value="0"></asp:ListItem>
                            <asp:ListItem Text="Single" Value="1"></asp:ListItem>
                            <asp:ListItem Text="Divorced" Value="2"></asp:ListItem>
                            <asp:ListItem Text="Widowed" Value="3"></asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator
                            ID="reqFieldStatus"
                            ControlToValidate="ddlStatus"
                            InitialValue="75"
                            Width="100%" runat="server" EnableClientScript="False">
                     Please choose a Status
                        </asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>Active</td>
                    <td>
                        <asp:CheckBox ID="Active" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />

                    </td>
                </tr>
            </table>

            <br />
            <br />
        </div>
    </form>
</body>
</html>
