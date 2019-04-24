<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm8.aspx.cs" Inherits="WebApplication28.WebForm8" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1">
                <Columns>
                    <asp:BoundField DataField="AdminUserId" HeaderText="AdminUserId" SortExpression="AdminUserId" />
                    <asp:BoundField DataField="AdminPasssword" HeaderText="AdminPasssword" SortExpression="AdminPasssword" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PRO2ConnectionString3 %>" SelectCommand="SELECT * FROM [admin]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
