<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="CompanyContacts.aspx.cs" Inherits="CompanyContacts" ValidateRequest="false" %>

<%@ Register src="Person.ascx" tagname="Person" tagprefix="uc1" %>

<asp:Content ID="Content4" ContentPlaceHolderID="contentHolder" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td class="style2">
                <uc1:Person ID="Person1" runat="server" HeaderText="Иванов" />
            </td>
            <td class="style3">
                &nbsp;</td>
            <td class="style1">
                <uc1:Person ID="Person2" runat="server" HeaderText="Сидоров Григорий" />
            </td>
        </tr>
    </table>
</asp:Content>

<asp:Content ID="Content5" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style1
        {
            width: 16px;
        }
        .style2
        {
            width: 169px;
        }
        .style3
        {
            width: 45px;
        }
    </style>
</asp:Content>


