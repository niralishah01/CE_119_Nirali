<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="WebApplication3.order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Details</title>
    <style type="text/css">
        .auto-style1 {
            width: 53%;
        }
        .auto-style2 {
            width: 309px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Order Details" BackColor="Yellow" BorderColor="Black" BorderStyle="Dotted" Font-Bold="True" ForeColor="Blue"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Username:" Font-Bold="True" ForeColor="Maroon"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <br />
            <table class="auto-style1" border="1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Selected Items" Font-Bold="True" ForeColor="#006600"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label5" runat="server" Text="Cost" Font-Bold="True" ForeColor="#006600"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label12" runat="server" Text="Total Cost"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
    </form>
</body>
</html>
