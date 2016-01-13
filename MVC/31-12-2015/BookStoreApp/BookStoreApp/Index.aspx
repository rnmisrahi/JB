<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="BookStoreApp.Index" %>

<%@ Import Namespace="BookStoreApp.Models" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" style="align-content:center">
        <div align="center">
            <p>
                <a href="Register.aspx">New</a>
            </p>
            <table border="1">
                <tr>
                    <th>Code</th>
                    <th>Name</th>
                </tr>
                <% foreach (Book book in BookRepository.GetAll())
                    { %>
                <tr>
                    <td>
                        <%=book.BookCode %>
                    </td>
                    <td>
                        <%=book.BookName %>
                    </td>
                    <td>
                        <a href="Display.aspx?bookid=<%=book.BookName %>">Details</a>
                    </td>
                    <% } %>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
