<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserForm.ascx.cs" Inherits="UserForm_UC" %>

<table style="width: 50%;">
    <tr>
        <td>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Имя:"></asp:Label>
        </td>
        <td>
            &nbsp;
            <asp:TextBox ID="txtName" runat="server" Width="218px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
            <asp:Label ID="Label2" runat="server" Text="Возраст:"></asp:Label>
        </td>
        <td>
            &nbsp;
            <asp:TextBox ID="txtAge" runat="server" Width="220px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
            <asp:Label ID="Label3" runat="server" Text="E-Mail:"></asp:Label>
        </td>
        <td>
            &nbsp;
            <asp:TextBox ID="txtMail" runat="server" Width="224px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;</td>
        <td>
            <asp:Button ID="okBtn" runat="server" Text="Ok" onclick="okBtn_Click" />
        </td>
    </tr>
</table>
