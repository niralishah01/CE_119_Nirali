<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert.aspx.cs" Inherits="StudentInfoApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Insert</asp:LinkButton>
&nbsp;<asp:LinkButton ID="LinkButton2" runat="server" OnClick="LinkButton2_Click">Update</asp:LinkButton>
&nbsp;<asp:LinkButton ID="LinkButton3" runat="server" OnClick="LinkButton3_Click">Delete</asp:LinkButton>
            <br />

            <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
            <br />

            Student Info:<br />
            Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Sem:<asp:TextBox ID="TextBox2" runat="server" ></asp:TextBox>
            <br />
            Mobile No:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            EmailID:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
