<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="Default_aspx" %>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.1//EN" "http://www.w3.org/TR/xhtml11/DTD/xhtml11.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Required Field Validation</title>
</head>
<body>
    <h3>
        <font face="Verdana">Bug Report</font>
    </h3>
    <form runat="server" ID="frmBugs">
        <div>
         <table bgcolor=gainsboro cellpadding=10>
            <tr valign="top">
               <td colspan=3 style="height: 58px">
                  <!-- Display error messages -->
                  <asp:Label ID="lblMsg" 
                  Text="Please report your bug here" 
                  ForeColor="red" Font-Name="Verdana" 
                  Font-Size="10" runat=server />
                  <br>
               </td>
            </tr>
            <tr>
               <td align=right>
                  <font face=Verdana size=2>Book</font>
               </td>
               <td>
               <!-- Drop down list with the books (must pick one) -->
                  <ASP:DropDownList id=ddlBooks runat=server>
                     <asp:ListItem>-- Please Pick A Book --</asp:ListItem>
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
                  </ASP:DropDownList>
               </td>
               <!-- Validator for the drop down -->
               <td align=center rowspan=1>
                  <asp:RequiredFieldValidator 
                  id="reqFieldBooks" 
                  ControlToValidate="ddlBooks" 
                  Display="Static" 
                  InitialValue="-- Please Pick A Book --" 
                  ErrorMessage = "You did not choose a book from the drop-down"
                  Width="100%" runat=server> * </asp:RequiredFieldValidator>
               </td>
            </tr>
            <tr>
               <td align=right>
               <!-- Radio buttons for the edition -->                  
                  <font face=Verdana size=2>Edition:</font>
               </td>
               <td>
                  <ASP:RadioButtonList id=rblEdition 
                  RepeatLayout="Flow" runat=server>
                     <asp:ListItem>1st</asp:ListItem>
                     <asp:ListItem>2nd</asp:ListItem>
                     <asp:ListItem>3rd</asp:ListItem>
                     <asp:ListItem>4th</asp:ListItem>
                  </ASP:RadioButtonList>
               </td>
               <!-- Validator for editions -->
               <td align=center rowspan=1>
                  <asp:RequiredFieldValidator 
                  id="reqFieldEdition" 
                  ControlToValidate="rblEdition" 
                  ErrorMessage = "You did not pick an edition"
                  Display="Static" 
                  InitialValue="" 
                  Width="100%" runat=server>*</asp:RequiredFieldValidator>
               </td>
            </tr>
            <tr>
               <td align=right style="HEIGHT: 97px">
                  <font face=Verdana size=2>Bug:</font>
               </td>
               <!-- Multi-line text for the bug entry -->               
               <td style="HEIGHT: 97px">
                  <ASP:TextBox id=txtBug runat=server width="183px" 
                  textmode="MultiLine" height="68px"/>
               </td>
               <!-- Validator for the text box-->               
               <td style="HEIGHT: 97px">
                  <asp:RequiredFieldValidator 
                  id="reqFieldBug" 
                  ControlToValidate="txtBug" 
                  ErrorMessage = "You must provide bug details"
                  Display="Static" 
                  Width="100%" runat=server>*</asp:RequiredFieldValidator>
               </td>
            </tr>
            <tr>
                <td align=right>
                <!-- Radio buttons for the error display -->                 
                    <font face=Verdana size=2>Display Errors</font>
                </td>
                <td>
                    <asp:DropDownList id="lstDisplay" 
                    AutoPostBack=true 
                    OnSelectedIndexChanged="lstDisplay_SelectedIndexChanged" 
                    runat=server >
                            <asp:ListItem Selected ="true">Summary</asp:ListItem>
                            <asp:ListItem>Msg. Box</asp:ListItem>
                    </asp:DropDownList>
                </td>
                <td>
                &nbsp;
                </td>
            </tr>

            <tr>
                <td align="right">
                        <font face=Verdana size=2>Display Report</font>
                </td>
                <td>
                    <asp:DropDownList id="lstFormat" 
                    AutoPostBack=true 
                    OnSelectedIndexChanged="lstFormat_SelectedIndexChanged"
                    runat=server >
                        <asp:ListItem>List</asp:ListItem>
                        <asp:ListItem Selected="true">Bulleted List</asp:ListItem>
                        <asp:ListItem>Single Paragraph</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
               <td>
               </td>
               <td>
                  <ASP:Button id=btnSubmit 
                  text="Submit Bug" runat=server OnClick="btnSubmit_Click" />
               </td>
               <td>
               </td>
            </tr>
         </table>
         <asp:ValidationSummary 
         ID="ValSum" runat="server" 
         DisplayMode="BulletList"
         HeaderText="The following errors were found: " ShowSummary="True" />

    </div>
    </form>
</body>
</html>
