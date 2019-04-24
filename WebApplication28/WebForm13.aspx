<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm13.aspx.cs" Inherits="WebApplication28.WebForm13" %>

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
                    <asp:BoundField DataField="bookname" HeaderText="bookname" SortExpression="bookname" />
                    <asp:BoundField DataField="authorname" HeaderText="authorname" SortExpression="authorname" />
                    <asp:BoundField DataField="isbn" HeaderText="isbn" SortExpression="isbn" />
                    <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PRO2ConnectionString5 %>" SelectCommand="SELECT * FROM [inventory]"></asp:SqlDataSource>
        </div>
    </form>
</body>
</html>
