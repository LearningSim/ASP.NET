<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AjaxExtenders.aspx.cs" Inherits="AjaxExtenders" %>

<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="ajaxToolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title></title>
</head>
<body>
<form id="form1" runat="server">
	<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
	<div>
		<asp:Label ID="Label1" runat="server" Text="Дата рождения "></asp:Label>
		<asp:TextBox ID="dateField" runat="server"></asp:TextBox>
		<ajaxToolkit:CalendarExtender ID="dateField_CalendarExtender" runat="server" BehaviorID="dateField_CalendarExtender" TargetControlID="dateField">
		</ajaxToolkit:CalendarExtender>
		<asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="dateField" EnableTheming="True" ErrorMessage="CompareValidator" ForeColor="Red" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
	</div>
</form>
</body>
</html>