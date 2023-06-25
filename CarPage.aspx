 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarPage.aspx.cs" Inherits="TheRideYouRentST10071160Final.CarPage" %>

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
                    <td>Car_ID</td>
                    <td><asp:TextBox ID="txtCarID" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Car_No</td>
                    <td><asp:TextBox ID="txtCarNo" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Car_Make</td>
                    <td><asp:TextBox ID="txtCarMake" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Car_Model</td>
                    <td><asp:TextBox ID="txtCarModel" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Body_Type</td>
                    <td><asp:TextBox ID="txtBodyType" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Km_Travelled</td>
                    <td><asp:TextBox ID="txtKmTravelled" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Service_Km</td>
                    <td><asp:TextBox ID="txtServiceKm" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Available</td>
                    <td><asp:TextBox ID="txtAvailable" runat="server"></asp:TextBox></td>
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
