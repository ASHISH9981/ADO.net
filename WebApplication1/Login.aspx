<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Welcome</h1>
            <label>username</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
            <label>PassWord</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
        <br />
            <asp:Button ID="btnSubmit" runat="server" Text="Save" OnClick="btnSubmit_Click" />
        </div>

    </form>
</body>
</html>
