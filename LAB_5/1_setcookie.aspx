<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="setcookie.aspx.cs" Inherits="WebApplication4.setcookie" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Get Student Info" Font-Bold="True"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="BirthDate"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="UserID"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="Semester"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="RollNo"></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            <br />
            <asp:Button ID="Button2" runat="server" Text="Get Cookie Info" OnClick="Button2_Click" Enabled="False" />
        </div>
    </form>
</body>
</html>
