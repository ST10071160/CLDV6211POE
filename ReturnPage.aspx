<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnPage.aspx.cs" Inherits="TheRideYouRentST10071160Final.ReturnPage" %>

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
                    <td>Return_ID</td>
                    <td><asp:TextBox ID="txtReturnID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Car_ID</td>
                    <td><asp:TextBox ID="txtCarID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Driver_ID</td>
                    <td><asp:TextBox ID="txtDriverID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Inspector_ID</td>
                    <td><asp:TextBox ID="txtInspectorID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Fine_ID</td>
                    <td><asp:TextBox ID="txtFineID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Return_Date</td>
                    <td><asp:TextBox ID="txtReturnDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Elapsed_Date</td>
                    <td><asp:TextBox ID="txtElapsedDate" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td><asp:Button ID="btnretrieve" runat="server" Text="Retrieve" OnClick="btnretrieve_Click" Width="79px" /></td>
                    <td>
                        <asp:Button ID="btnsearch" runat="server" Text="Search" OnClick="btnsearch_Click" Width="127px" />
                    </td>
                    <td><asp:Button ID="btninsert" runat="server" Text="Insert" OnClick="btninsert_Click" /></td>
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
