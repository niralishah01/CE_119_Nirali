<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication2.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Full Name"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
           ErrorMessage="Full Name is required" ControlToValidate="TextBox1" Display="Dynamic"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Age"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True"></asp:TextBox>
        <asp:RangeValidator ID="RangeValidator1" runat="server" 
            ErrorMessage="Age must be 18 to 50" MaximumValue="50" MinimumValue="18" ControlToValidate="TextBox2" Display="Dynamic" ForeColor="Red"></asp:RangeValidator>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label4" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="Password and Confirm password must match" ControlToValidate="TextBox4" ControlToCompare="TextBox3" Display="Dynamic"></asp:CompareValidator>
        <br />
        <asp:Label ID="Label5" runat="server" Text="Gender"></asp:Label>
&nbsp;<asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem>Male</asp:ListItem>
            <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label6" runat="server" Text="Mobile No"></asp:Label>
        <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
            ErrorMessage="Mobile No must be of 10 digit" ValidationExpression="\d{10}" Display="Dynamic" ControlToValidate="TextBox5"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="Label7" runat="server" Text="Hobbies"></asp:Label>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem>Reading</asp:ListItem>
            <asp:ListItem>Drawing</asp:ListItem>
            <asp:ListItem>Singing</asp:ListItem>
            <asp:ListItem>Dancing</asp:ListItem>
        </asp:CheckBoxList>
        <asp:Label ID="Label8" runat="server" Text="State"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList3" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList3_SelectedIndexChanged">
            <asp:ListItem Value="Sl">Select</asp:ListItem>
            <asp:ListItem Value="Gujarat">Gujarat</asp:ListItem>
            <asp:ListItem Value="Maharashtra">Maharashtra</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label9" runat="server" Text="City"></asp:Label>
        <asp:DropDownList ID="DropDownList4" runat="server">
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label10" runat="server" Text="PAN Number"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
       <!-- <asp:CustomValidator ID="CustomValidator1" runat="server" ErrorMessage="Should be 10 digit and start with letter 'B' or 'A'" Display="Dynamic" ControlToValidate="TextBox6" OnServerValidate="CustomValidator1_ServerValidate"></asp:CustomValidator>-->
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
    </form>
</body>
</html>
