<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="testsearch.aspx.cs" Inherits="WebApplication28.testsearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <asp:TextBox ID="SearchByTagTB" runat="server"></asp:TextBox>
        <asp:Button ID="SearchByTagButton" runat="server" Text="SEARCH"
            onclick="SearchByTagButton_Click" /><br />
        <asp:GridView ID="gvPatients" runat="server"></asp:GridView>
 
    <form id="form1" runat="server">
        <div>
        </div>
    </form>
</body>
</html>
