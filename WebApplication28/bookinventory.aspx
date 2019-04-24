<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bookinventory.aspx.cs" Inherits="WebApplication28.bookinventory" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            font-size: medium;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" Height="444px" Width="601px">
                <Columns>
                    <asp:BoundField DataField="bookname" HeaderText="bookname" SortExpression="bookname" />
                    <asp:BoundField DataField="authorname" HeaderText="authorname" SortExpression="authorname" />
                    <asp:BoundField DataField="isbn" HeaderText="isbn" SortExpression="isbn" />
                    <asp:BoundField DataField="quantity" HeaderText="quantity" SortExpression="quantity" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PRO2ConnectionString5 %>" SelectCommand="SELECT * FROM [inventory]"></asp:SqlDataSource>
        </div>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" OnClick="Button1_Click" Text="Back" Width="103px" />
            </strong>
        </p>
    </form>
</body>
</html>
