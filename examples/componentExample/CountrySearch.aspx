<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CountrySearch.aspx.cs" Inherits="CountrySearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style>
		#searchField {
			float: left;
			margin-right: 8px;
		}
		#countryList {
			overflow: hidden;
			min-width: 100px;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
    	<asp:TextBox ID="searchField" runat="server" AutoPostBack="True" OnTextChanged="searchField_TextChanged"></asp:TextBox>
		<asp:ListBox ID="countryList" runat="server"></asp:ListBox>
    <div>
    
    </div>
    </form>
</body>
</html>
