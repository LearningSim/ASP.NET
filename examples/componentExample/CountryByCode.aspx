<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CountryByCode.aspx.cs" Inherits="CountryByCode" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:TextBox ID="isoCodeField" runat="server"></asp:TextBox>
		<asp:Button ID="searchBtn" runat="server" Text="Search" OnClick="searchBtn_Click" />
		<br/>
    	<asp:Label ID="countryName" runat="server" Text="Label"></asp:Label>
    
    </div>
    </form>
</body>
</html>
