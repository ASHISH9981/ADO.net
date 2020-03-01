<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search.aspx.cs" Inherits="WebApplication1.Search" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
          <div>
            <h1>Welcome</h1>
            <label>Name</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
        <br />
            <asp:Button  ID="btnSubmit" runat="server" Text="search" onClick="btnSubmit_Click" />
        </div>
        <div>
            <asp:GridView ID="dgvResult" runat="server"></asp:GridView>        </div>
    </form>
</body>
</html>
