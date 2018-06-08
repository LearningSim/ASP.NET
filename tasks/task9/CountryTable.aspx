<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CountryTable.aspx.cs" Inherits="CountryTable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
		<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="ID" DataSourceID="SqlDataSource1">
			<Columns>
				<asp:BoundField DataField="ID" HeaderText="ID" ReadOnly="True" SortExpression="ID" />
				<asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
				<asp:BoundField DataField="PhoneNoFormat" HeaderText="PhoneNoFormat" SortExpression="PhoneNoFormat" />
				<asp:BoundField DataField="DialingCountryCode" HeaderText="DialingCountryCode" SortExpression="DialingCountryCode" />
				<asp:BoundField DataField="InternationalDialingCode" HeaderText="InternationalDialingCode" SortExpression="InternationalDialingCode" />
				<asp:BoundField DataField="InternetTLD" HeaderText="InternetTLD" SortExpression="InternetTLD" />
			</Columns>
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
