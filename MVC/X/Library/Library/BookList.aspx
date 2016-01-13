<%@ Page Title="Book List" Language="C#" AutoEventWireup="true" CodeBehind="BookList.aspx.cs" 
    Inherits="Library.BookList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book List</title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 412px">
    
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="LinqDataSource1">
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
        <asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="Library.Models.BookRepository" EntityTypeName="" OrderBy="Title" Select="new (BookId, Title, Editor, Audience, Category, Copies, IsActive)" TableName="Books">
        </asp:LinqDataSource>
        <br />
        <a href="Library.aspx"  name="Add Book">Add another book</a> 
        <br />
    
    </div>
    </form>
</body>
</html>
