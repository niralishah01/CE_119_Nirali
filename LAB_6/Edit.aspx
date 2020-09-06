<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="StudentInfoApplication.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />
            Student ID:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Fetch" />
            <br />
            <asp:Label ID="Label8" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server" ReadOnly="True" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server" Visible="False"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text=""></asp:Label>
            <asp:TextBox ID="TextBox5" runat="server" Visible="False"></asp:TextBox>
        </div>
        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" Visible="False" />
        <br />
    </form>
</body>
</html>
