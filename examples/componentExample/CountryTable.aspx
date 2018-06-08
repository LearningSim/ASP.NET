<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CountryTable.aspx.cs" Inherits="CountryTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
	<style>
		.warning {
			display: block;
			padding: 8px;
			background-color: #FFEB3B;
			position: absolute;
		}
	</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1" AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None" PageSize="20">
			<AlternatingRowStyle BackColor="White" ForeColor="#284775" />
			<Columns>
				<asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" Visible="False" />
				<asp:TemplateField HeaderText="Name" SortExpression="Name">
					<EditItemTemplate>
						<asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Name") %>'></asp:TextBox>
						<asp:RequiredFieldValidator class="warning" ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Name required" ForeColor="Red" Display="Dynamic">Name can't be blank</asp:RequiredFieldValidator>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="Label1" runat="server" Text='<%# Bind("Name") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:TemplateField HeaderText="PhoneNoFormat" SortExpression="PhoneNoFormat">
					<EditItemTemplate>
						<asp:DropDownList ID="DropDownList1" runat="server" SelectedValue='<%# Bind("PhoneNoFormat") %>'>
							<asp:ListItem>##-###-##</asp:ListItem>
							<asp:ListItem>#(###)-###-##-##</asp:ListItem>
							<asp:ListItem>(0##) ### ####</asp:ListItem>
							<asp:ListItem></asp:ListItem>
						</asp:DropDownList>
					</EditItemTemplate>
					<ItemTemplate>
						<asp:Label ID="Label2" runat="server" Text='<%# Bind("PhoneNoFormat") %>'></asp:Label>
					</ItemTemplate>
				</asp:TemplateField>
				<asp:BoundField DataField="DialingCountryCode" HeaderText="DialingCountryCode" SortExpression="DialingCountryCode" />
				<asp:BoundField DataField="InternationalDialingCode" HeaderText="InternationalDialingCode" SortExpression="InternationalDialingCode" />
				<asp:BoundField DataField="InternetTLD" HeaderText="InternetTLD" SortExpression="InternetTLD" />
				<asp:CommandField ShowEditButton="True" />
				<asp:CommandField ShowDeleteButton="True" />
			</Columns>
			<EditRowStyle BackColor="#999999" />
			<FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
			<HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
			<PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
			<RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
			<SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
			<SortedAscendingCellStyle BackColor="#E9E7E2" />
			<SortedAscendingHeaderStyle BackColor="#506C8C" />
			<SortedDescendingCellStyle BackColor="#FFFDF8" />
			<SortedDescendingHeaderStyle BackColor="#6F8DAE" />
		</asp:GridView>
		<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:CustomerManagement %>" DeleteCommand="DELETE FROM [Countries] WHERE [ID] = @ID" InsertCommand="INSERT INTO [Countries] ([ID], [Name], [PhoneNoFormat], [DialingCountryCode], [InternationalDialingCode], [InternetTLD]) VALUES (@ID, @Name, @PhoneNoFormat, @DialingCountryCode, @InternationalDialingCode, @InternetTLD)" SelectCommand="SELECT * FROM [Countries] ORDER BY [Name]" UpdateCommand="UPDATE [Countries] SET [Name] = @Name, [PhoneNoFormat] = @PhoneNoFormat, [DialingCountryCode] = @DialingCountryCode, [InternationalDialingCode] = @InternationalDialingCode, [InternetTLD] = @InternetTLD WHERE [ID] = @ID">
			<DeleteParameters>
				<asp:Parameter Name="ID" Type="Object" />
			</DeleteParameters>
			<InsertParameters>
				<asp:Parameter Name="ID" Type="Object" />
				<asp:Parameter Name="Name" Type="String" />
				<asp:Parameter Name="PhoneNoFormat" Type="String" />
				<asp:Parameter Name="DialingCountryCode" Type="String" />
				<asp:Parameter Name="InternationalDialingCode" Type="String" />
				<asp:Parameter Name="InternetTLD" Type="String" />
			</InsertParameters>
			<UpdateParameters>
				<asp:Parameter Name="Name" Type="String" />
				<asp:Parameter Name="PhoneNoFormat" Type="String" />
				<asp:Parameter Name="DialingCountryCode" Type="String" />
				<asp:Parameter Name="InternationalDialingCode" Type="String" />
				<asp:Parameter Name="InternetTLD" Type="String" />
				<asp:Parameter Name="ID" Type="Object" />
			</UpdateParameters>
		</asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
