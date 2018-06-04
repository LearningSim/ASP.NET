<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Validation.aspx.cs" Inherits="Validation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
	<style type="text/css">
		#warnings{
			background-color:#ffd65a;
			border: 2px solid #ff9800;
		}
		#form1{
			max-width: 800px;
			margin: auto;
		}
	</style>
</head>
<body>
	<form id="form1" runat="server">
		<div>
			<div id="warnings">
				<asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
			</div>
			<table>
				<tr>
					<td>&nbsp;
                    <asp:Label ID="Label1" runat="server" Text="Логин:"></asp:Label>
					</td>
					<td>&nbsp;
                    <asp:TextBox ID="loginField" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server"
							ControlToValidate="loginField" ErrorMessage="Пустое имя" ForeColor="Red">*</asp:RequiredFieldValidator>
					</td>
				</tr>
				<tr>
					<td>&nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Пароль:"></asp:Label>
					</td>
					<td>&nbsp;
                    <asp:TextBox ID="passField" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
							ControlToValidate="passField" ErrorMessage="Пароль пустой" ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
						<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server"
							ControlToValidate="passField" ErrorMessage="Пароль короче 6 символов"
							ForeColor="Red" ValidationExpression=".{6,}" Display="Dynamic">*</asp:RegularExpressionValidator>
						<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server"
							ControlToValidate="passField" ErrorMessage="В пароле отсутствуют буквы"
							ForeColor="Red" ValidationExpression=".*[a-zA-Z]+.*" Display="Dynamic">*</asp:RegularExpressionValidator>
						<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server"
							ControlToValidate="passField" ErrorMessage="В пароле отсутствуют цифры"
							ForeColor="Red" ValidationExpression=".*[0-9]+.*" Display="Dynamic">*</asp:RegularExpressionValidator>
						<asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server"
							ControlToValidate="passField" ErrorMessage="В пароле отсутствует _"
							ForeColor="Red" ValidationExpression=".*_+.*" Display="Dynamic">*</asp:RegularExpressionValidator>
						<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server"
							ControlToValidate="passField" ErrorMessage="Разрешены только буквы, цифры и _"
							ForeColor="Red" ValidationExpression="\w+" Display="Dynamic">*</asp:RegularExpressionValidator>
					</td>
				</tr>
				<tr>
					<td>&nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Подтвердите пароль:"></asp:Label>
					</td>
					<td>&nbsp;
                    <asp:TextBox ID="confirmField" runat="server"></asp:TextBox>
						<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server"
							ControlToValidate="confirmField" ErrorMessage="Пароль не подтвержден"
							ForeColor="Red" Display="Dynamic">*</asp:RequiredFieldValidator>
						<asp:CompareValidator ID="CompareValidator1" runat="server"
							ControlToCompare="passField" ControlToValidate="confirmField"
							ErrorMessage="Пароли не совпадают" ForeColor="Red">*</asp:CompareValidator>
					</td>
				</tr>
				<tr>
					<td>&nbsp;
					</td>
					<td>&nbsp;
                    <asp:Button ID="btnOk" runat="server" Text="Ok" Height="26px" />
					</td>
				</tr>
			</table>
		</div>
	</form>
</body>
</html>
