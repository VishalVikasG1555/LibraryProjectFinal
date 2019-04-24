<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="charts.aspx.cs" Inherits="WebApplication28.charts" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
            font-size: medium;
        }
        .auto-style2 {
            width: 324px;
            height: 288px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style2">
            <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource2" Height="395px" Width="634px">
                <series>
                    <asp:Series Name="Series1" XValueMember="bookname" YValueMembers="quantity">
                    </asp:Series>
                </series>
                <chartareas>
                    <asp:ChartArea Name="ChartArea1">
                    </asp:ChartArea>
                </chartareas>
            </asp:Chart>
            <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:PRO2ConnectionString5 %>" SelectCommand="SELECT [bookname], [quantity] FROM [inventory]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PRO2ConnectionString5 %>" SelectCommand="SELECT [quantity], [isbn] FROM [inventory]"></asp:SqlDataSource>
            <strong>
            <asp:Button ID="Button1" runat="server" CssClass="auto-style1" Height="28px" OnClick="Button1_Click" Text="Go Back " Width="177px" />
            </strong>
        </div>
    </form>
</body>
</html>
