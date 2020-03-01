<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome</h1>
            <label>FirstName</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <label>LastName</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
            <label>EmailId</label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
            <label>Address</label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
            <label>PinCode</label>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox><br />
            <label>password</label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox><br />
            <label>ConfirmPassword</label>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox><br />
        <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
        </div>

    </form>
</body>
</html>
