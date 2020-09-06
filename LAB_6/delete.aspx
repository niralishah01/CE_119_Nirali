<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="StudentInfoApplication.delete" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="error" runat="server" Text=""></asp:Label>
            <br />
            name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            email:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
