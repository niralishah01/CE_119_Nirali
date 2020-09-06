<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="product.aspx.cs" Inherits="orderingapp.product" %>

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
            Product Details:</p>
        <p>
            <asp:GridView ID="ProductGridView" runat="server">
            </asp:GridView>
        </p>
        <p>
            Select Products:<asp:ListBox ID="ListBox1" runat="server" SelectionMode="Multiple" DataSourceID="SqlDataSource1" DataTextField="pname" DataValueField="pname" ></asp:ListBox>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT [pname] FROM [product]"></asp:SqlDataSource>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Place Order" OnClick="Button1_Click" />
    </form>
</body>
</html>
