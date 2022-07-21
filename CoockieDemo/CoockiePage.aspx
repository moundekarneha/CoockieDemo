<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CoockiePage.aspx.cs" Inherits="CoockieDemo.CoockiePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox runat="server" ID="txt1"></asp:TextBox><br/>
            <asp:TextBox runat="server" ID="txt2"></asp:TextBox><br/>
            <asp:Button ID="btn1" runat="server" Text="Click me" OnClick="btn1_Click" />
        </div>
    </form>
</body>
</html>

