<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainPage.aspx.cs" Inherits="TheRideYouRentST10071160Final.MainPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align  ="center">
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                
                <tr><td class="auto-style1">
                    &nbsp;</td>

                    <td></td>
                    <td>
                    <asp:Label ID="lblmain" runat="server" Text="The Ride You Rent"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style1"></td>
                    <td>&nbsp;</td>
                </tr>
                <tr><td class="auto-style1">&nbsp;</td></tr>
                <tr><td class="auto-style1">
                    
                    </td></tr>
                <tr>
                    <td class="auto-style1"><asp:Button ID="btncar" runat="server" Text="Car Table" OnClick="btncar_Click" Width="82px"/></td>
                    <td><asp:Button ID="btninspector" runat="server" Text="Inspector Table" OnClick="btninspector_Click"/></td>
                    <td><asp:Button ID="btndriver" runat="server" Text="Driver Table" OnClick="btndriver_Click" Width="118px"/></td>
                    <td><asp:Button ID="btnrental" runat="server" Text="Rental Table" OnClick="btnrental_Click"/></td>
                    <td><asp:Button ID="btnreturn" runat="server" Text="Return Table" OnClick="btnreturn_Click"/></td>
                    <td><asp:Button ID="btnexit" runat="server" Text="Exit" OnClick="btnexit_Click"/></td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
