<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WEbFormValidation.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<title>RangeValidator Control (General Reference)</title>

   <script runat="server">

      void ButtonClick(Object sender, EventArgs e)
      {

         if (Page.IsValid)
         {
            Label1.Text="Page is valid.";
         }
         else
         {
            Label1.Text="Page is not valid!!";
         }

      }

   </script>

</head>

<body>

   <form id="Form2" runat="server">

      <h3>RangeValidator Example</h3>

      Enter a number from 1 to 10:

      <br />

      <asp:TextBox id="TextBox1"
           runat="server"/>

      <br />

       <asp:RequiredFieldValidator id="work" runat="server" ControlToValidate="TextBox1" 
           EnableClientScript="false"
           Text="Enter something" />
<%--      <asp:RangeValidator id="Range1"
           ControlToValidate="TextBox1"
           MinimumValue="1"
           MaximumValue="10"
           Type="Integer"
           EnableClientScript="false"
           Text="The value must be from 1 to 10!"
           runat="server"/>--%>

      <p />

      <asp:Label id="Label1"
           runat="server"/>

      <p />

      <asp:Button id="Button1"
           Text="Submit"
           OnClick="ButtonClick"
           runat="server"/>
   </form>

</body>
</html>



