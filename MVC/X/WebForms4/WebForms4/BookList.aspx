<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" Inherits="WebForms4.BookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 322px">
    
        <asp:GridView ID="GridView1" runat="server" border="2" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1">
            <Columns>
                <asp:BoundField DataField="BookId" HeaderText="BookId" SortExpression="BookId" />
                <asp:BoundField DataField="Title" HeaderText="Title" SortExpression="Title" />
                <asp:BoundField DataField="Editor" HeaderText="Editor" SortExpression="Editor" />
                <asp:BoundField DataField="Audience" HeaderText="Audience" SortExpression="Audience" />
                <asp:BoundField DataField="Category" HeaderText="Category" SortExpression="Category" />
                <asp:BoundField DataField="Copies" HeaderText="Copies" SortExpression="Copies" />
                <asp:CheckBoxField DataField="IsActive" HeaderText="IsActive" SortExpression="IsActive" />
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GridView1_GetBooks" TypeName="WebForms4.Models.BookRepository"></asp:ObjectDataSource>
    
    </div>
    </form>
</body>
</html>
