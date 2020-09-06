<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="orderingapp.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Error" runat="server" Text=""></asp:Label>
            :</div>
        <p>
            UserID:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            Password:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
