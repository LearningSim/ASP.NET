﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <h1><asp:Label ID="greetingLabel" runat="server" Text=""></asp:Label></h1>
        <br />
        <asp:Label ID="nameTip" runat="server" Text="Введи имя: "></asp:Label>
        <asp:TextBox ID="userNameField" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" onclick="Button1_Click" Text="Process" />
    
    </div>
    </form>
</body>
</html>
