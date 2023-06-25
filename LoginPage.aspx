<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TheRideYouRentST10071160Final.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align  ="center">
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>&nbsp;</td></tr>
                <tr>
                    <td>Username:</td>
                    <td><asp:TextBox ID="txtusername" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Password:</td>
                    <td><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></td>
                </tr>
                <tr><td>&nbsp;</td></tr>
                <tr><td>
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                    </td></tr>
                <tr>
                    <td><asp:Button ID="btnnext" runat="server" Text="Log in" OnClick="btnnext_Click"/></td>
                    <td class="auto-style2">&nbsp;</td>
                    <td><asp:Button ID="btnexit" runat="server" Text="Exit" OnClick="btnexit_Click"/></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
