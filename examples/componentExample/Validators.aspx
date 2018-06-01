<%@ Page Title="" Language="C#" MasterPageFile="~/Main.master" AutoEventWireup="true" CodeFile="Validators.aspx.cs" Inherits="Validators" %>

<asp:Content ID="Content4" ContentPlaceHolderID="contentHolder" Runat="Server">
    <script type="text/javascript">
        function testName(sender, args) {
            args.IsValid = args.Value.length >= 6;
        }
    </script>

    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
    <table style="width: 46%;">
        <tr>
            <td>
                &nbsp;
                <asp:Label ID="Label1" runat="server" Text="Имя:"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtName" runat="server" Width="153px"></asp:TextBox>
                <asp:CustomValidator ID="CustomValidator1" runat="server" 
                    ControlToValidate="txtName" Display="Dynamic" ErrorMessage="Короткое имя" 
                    ForeColor="Red" onservervalidate="CustomValidator1_ServerValidate" 
                    ClientValidationFunction="testName">*</asp:CustomValidator>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtName" ErrorMessage="Имя пустое" ForeColor="#FF3300" 
                    SetFocusOnError="True">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;
                <asp:Label ID="Label4" runat="server" Text="Возраст:"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="txtAge" runat="server" Width="48px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtAge" Display="Dynamic" ErrorMessage="Укажите возраст" 
                    ForeColor="#FF3300">*</asp:RequiredFieldValidator>
                <asp:CompareValidator ID="CompareValidator1" runat="server" 
                    ControlToValidate="txtAge" Display="Dynamic" 
                    ErrorMessage="Возраст должен быть числом" ForeColor="Red" 
                    Operator="DataTypeCheck" Type="Integer">*</asp:CompareValidator>
                <asp:CompareValidator ID="CompareValidator2" runat="server" 
                    ControlToValidate="txtAge" ErrorMessage="Возраст &lt;  18" ForeColor="Red" 
                    Operator="GreaterThanEqual" Type="Integer" ValueToCompare="18">*</asp:CompareValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;
                <asp:Label ID="Label2" runat="server" Text="E-Mail:"></asp:Label>
            </td>
            <td>
                &nbsp;
                <asp:TextBox ID="TxtEmail" runat="server" Width="152px"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                    ControlToValidate="TxtEmail" Display="Dynamic" 
                    ErrorMessage="Некорректный e-mail" ForeColor="Red" 
                    ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*">*</asp:RegularExpressionValidator>
            </td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td>
                &nbsp;
            </td>
            <td>
                &nbsp;
                <asp:Button ID="btnOk" runat="server" Text="Ok" />
            </td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
</asp:Content>

