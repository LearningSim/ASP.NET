<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CountryChooser.aspx.cs" Inherits="CountryChooser" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <div>
            Выбери страну: 
            <asp:DropDownList ID="countries" runat="server" AutoPostBack="True" 
                onselectedindexchanged="countries_SelectedIndexChanged">
                <asp:ListItem>Америка</asp:ListItem>
                <asp:ListItem>Россия</asp:ListItem>
            </asp:DropDownList>
        </div>
        <div>
            Список городов: 
            <asp:DropDownList ID="cities" runat="server">
            </asp:DropDownList>
        </div>
    </div>
    </form>
</body>
</html>
