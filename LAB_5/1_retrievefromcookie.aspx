<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="retrievefromcookie.aspx.cs" Inherits="WebApplication4.retrievefromcookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Button ID="Button2" runat="server" Text="Get Info from cookie" OnClick="Button2_Click"/>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True"></asp:Label>
            <br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text=""></asp:Label>
            <asp:Label ID="Label11" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Delete Cookie" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
