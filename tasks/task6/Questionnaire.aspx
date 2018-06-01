<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Questionnaire.aspx.cs" Inherits="Questionnaire" %>

<%@ Register src="UserForm.ascx" tagname="UserForm" tagprefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <uc1:UserForm ID="UserForm1" runat="server" />
        <asp:Label ID="nameLabel" runat="server" Text=""></asp:Label>
    
    </div>
    </form>
</body>
</html>
