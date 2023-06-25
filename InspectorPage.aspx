<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InspectorPage.aspx.cs" Inherits="TheRideYouRentST10071160Final.InspectorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <div>
            <table align  ="center">
                <tr>
                    <td>Inspector_ID</td>
                    <td><asp:TextBox ID="txtInspectorID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Inspector_No</td>
                    <td><asp:TextBox ID="txtInspectorNo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>I_Name</td>
                    <td><asp:TextBox ID="txtIName" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>I_Surname</td>
                    <td><asp:TextBox ID="txtISurname" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>I_Email</td>
                    <td><asp:TextBox ID="txtIEmail" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>I_Mobile</td>
                    <td><asp:TextBox ID="txtIMobile" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnretrieve" runat="server" Text="Retrieve" OnClick="btnretrieve_Click" /></td>
                    <td>
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" />
                        <asp:Button ID="btnupdate" runat="server" Text="Update" OnClick="btnupdate_Click" /><asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" /><asp:Button ID="btndelete" runat="server" Text="Delete" OnClick="btndelete_Click"/></td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnhome" runat="server" Text="Home" Width="69px" OnClick="btnhome_Click" />
                    </td>
                    <td>
                        <asp:Button ID="btnexit" runat="server" Text="Exit" OnClick="btnexit_Click" />
                    </td>
                </tr>
            </table>
        </div>
        <tr><td>&nbsp;</td></tr>
        <tr><td>&nbsp;</td></tr>
        <tr><td>&nbsp;</td></tr>
        <asp:GridView ID="GridView1" runat="server" align  ="center">
        </asp:GridView>
    </form>
</body>
</html>
