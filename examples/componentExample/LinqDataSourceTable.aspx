<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LinqDataSourceTable.aspx.cs" Inherits="LinqDataSourceTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="LinqDataSource1">
			<Columns>
				<asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
				<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
				<asp:BoundField DataField="PhoneNoFormat" HeaderText="PhoneNoFormat" SortExpression="PhoneNoFormat" />
				<asp:BoundField DataField="DialingCountryCode" HeaderText="DialingCountryCode" SortExpression="DialingCountryCode" />
				<asp:BoundField DataField="InternationalDialingCode" HeaderText="InternationalDialingCode" SortExpression="InternationalDialingCode" />
				<asp:BoundField DataField="InternetTLD" HeaderText="InternetTLD" SortExpression="InternetTLD" />
			</Columns>
		</asp:GridView>
		<asp:LinqDataSource ID="LinqDataSource1" runat="server" ContextTypeName="CustomerManagementLINQDataContext" EntityTypeName="" OrderBy="Name" TableName="Countries">
		</asp:LinqDataSource>
    
    </div>
    </form>
</body>
</html>
