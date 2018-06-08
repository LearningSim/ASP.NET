<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditCustomer.aspx.cs" Inherits="EditCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    	<table style="width:100%;">
			<tr>
				<td>
					<asp:Label ID="FirstName" runat="server" Text="First Name"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="firstNameField" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="LastName" runat="server" Text="Last Name"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="LastNameField" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="Address" runat="server" Text="Address"></asp:Label>
				</td>
				<td>
					<asp:TextBox ID="addressField" runat="server"></asp:TextBox>
				</td>
			</tr>
			<tr>
				<td>
					<asp:Label ID="Country" runat="server" Text="Country"></asp:Label>
				</td>
				<td>
					<asp:DropDownList ID="countries" runat="server">
					</asp:DropDownList>
				</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td>
					<asp:Button ID="saveBtn" runat="server" Text="Save" />
				</td>
			</tr>
		</table>
    
    </div>
    </form>
</body>
</html>
