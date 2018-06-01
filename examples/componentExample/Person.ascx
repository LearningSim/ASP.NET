<%@ Control Language="C#" AutoEventWireup="true" CodeFile="Person.ascx.cs" Inherits="Person_UC" %>

<asp:Label ID="headLabel" runat="server" Text=""></asp:Label>
<table style="width: 46%;">
    <tr>
        <td>
            &nbsp;
            <asp:Label ID="Label1" runat="server" Text="Имя:"></asp:Label>
        </td>
        <td>
            &nbsp;
            <asp:TextBox ID="txtName" runat="server" Width="153px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
            <asp:Label ID="Label2" runat="server" Text="E-Mail:"></asp:Label>
        </td>
        <td>
            &nbsp;
            <asp:TextBox ID="TxtEmail" runat="server" Width="152px"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            &nbsp;
        </td>
        <td>
            &nbsp;
            <asp:Button ID="btnOk" runat="server" Text="Ok" onclick="btnOk_Click" />
        </td>
    </tr>
</table>
