<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Calculator.aspx.cs" Inherits="Calculator" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:TextBox ID="addend1" runat="server"></asp:TextBox>
                <asp:Label ID="Label1" runat="server" Text=" + "></asp:Label>
                <asp:TextBox ID="addend2" runat="server"></asp:TextBox>
                <asp:Button ID="sumBtn" runat="server" Text="=" OnClick="sumBtn_Click" />
                <div>
                    <asp:Label ID="Label2" runat="server" Text="Результат"></asp:Label>
                </div>
                <div>
                    <asp:Label ID="resultField" runat="server" Text=""></asp:Label>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
</body>
</html>
