<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Validation.aspx.cs" Inherits="Validation" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
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
                    <asp:Label ID="Label1" runat="server" Text="Логин:"></asp:Label>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="loginField" runat="server" Width="153px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                        ControlToValidate="loginField" ErrorMessage="Пустое  имя" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    <asp:Label ID="Label4" runat="server" Text="Пароль:"></asp:Label>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="passField" runat="server" Width="149px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                        ControlToValidate="loginField" ErrorMessage="Пароль пустой" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" 
                        ControlToValidate="passField" ErrorMessage="Разрешены быть буквы, цифры и _" 
                        ForeColor="Red" ValidationExpression="^\w+$">*</asp:RegularExpressionValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                    <asp:Label ID="Label2" runat="server" Text="Подтвердите пароль:"></asp:Label>
                </td>
                <td>
                    &nbsp;
                    <asp:TextBox ID="confirmField" runat="server" Width="152px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                        ControlToValidate="confirmField" ErrorMessage="Пароль не подтвержден" 
                        ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" 
                        ControlToCompare="passField" ControlToValidate="confirmField" 
                        ErrorMessage="Пароли не совпадают" ForeColor="Red">*</asp:CompareValidator>
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;
                </td>
                <td>
                    &nbsp;
                    <asp:Button ID="btnOk" runat="server" Text="Ok" Height="26px" />
                </td>
                <td>
                    &nbsp;
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
