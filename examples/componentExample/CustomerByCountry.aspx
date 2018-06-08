<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerByCountry.aspx.cs" Inherits="CustomerByCountry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
<form id="form1" runat="server">
	<div>

		<asp:DropDownList ID="countries" runat="server" AutoPostBack="True" OnSelectedIndexChanged="countries_SelectedIndexChanged">
		</asp:DropDownList>
		<asp:GridView ID="customerGrid" runat="server" AutoGenerateColumns="False" DataKeyNames="ID">
			<Columns>
				<asp:BoundField DataField="ID" HeaderText="ID" SortExpression="ID" Visible="False"/>
				<asp:BoundField DataField="FirstName" HeaderText="FirstName" SortExpression="FirstName"/>
				<asp:BoundField DataField="LastName" HeaderText="LastName" SortExpression="LastName"/>
				<asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address"/>
				<asp:BoundField DataField="Phone" HeaderText="Phone" SortExpression="Phone"/>
				<asp:BoundField DataField="City" HeaderText="City" SortExpression="City"/>
				<asp:BoundField DataField="State" HeaderText="State" SortExpression="State"/>
				<asp:BoundField DataField="Country" HeaderText="Country" SortExpression="Country"/>
				<asp:TemplateField>
					<ItemTemplate>
						<asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl='<%# string.Format("EditCustomer.aspx?id={0}", Eval("ID")) %>'>Edit</asp:HyperLink>
					</ItemTemplate>
				</asp:TemplateField>
			</Columns>
			<EmptyDataTemplate>
				<asp:Label ID="Label1" runat="server" Text="No customers"></asp:Label>
			</EmptyDataTemplate>
		</asp:GridView>
		<a href="EditCustomer.aspx">Add new Customer</a>
	</div>
</form>
</body>
</html>