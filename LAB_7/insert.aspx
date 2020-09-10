<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="insert.aspx.cs" Inherits="Lab7_app2.insert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student Details:<br />
            Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Sem:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            cpi:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            contactno:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            emailid:<asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
