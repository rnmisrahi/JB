<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Wiz1.aspx.cs" Inherits="Wizard.Wiz1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wizard One</title>
</head>
<body style="height: 228px">
    <form id="form1" runat="server">
    <div style="height: 409px; direction: ltr;">
    
        ID:
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="StudentId" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="StudentId" HeaderText="StudentId" ReadOnly="True" SortExpression="StudentId" />
                <asp:BoundField DataField="StudentName" HeaderText="StudentName" SortExpression="StudentName" />
                <asp:CheckBoxField DataField="LikesGirls" HeaderText="LikesGirls" SortExpression="LikesGirls" />
                <asp:BoundField DataField="Course" HeaderText="Course" SortExpression="Course" />
                <asp:CheckBoxField DataField="Hebrew" HeaderText="Hebrew" SortExpression="Hebrew" />
                <asp:BoundField DataField="Comments" HeaderText="Comments" SortExpression="Comments" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Wizard.Models.StudentContextConnectionString %>" SelectCommand="SELECT * FROM [Students]"></asp:SqlDataSource>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    
    </div>
    </form>
</body>
</html>
