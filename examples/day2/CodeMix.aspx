<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CodeMix.aspx.cs" Inherits="CodeMix" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script runat="server" language="C#">
        int sum(int a, int b){
            return a + b;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%
            int a = 20;
            int b = a * a;
        %>
        Результат 
        <%
           =b
        %>
        <p>
            <% =sum(10, 5) %>
        </p>
    </div>
    </form>
</body>
</html>
