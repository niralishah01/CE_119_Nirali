<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="order.aspx.cs" Inherits="orderingapp.order" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Error" runat="server" Text=""></asp:Label>
        </div>
        <p>
        <asp:Button ID="Button1" runat="server" Text="Logout" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
