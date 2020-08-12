<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebCustom.aspx.cs" Inherits="WebApplication1.WebCustom" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button1" runat="server" Text="Click" />
        <div>
        </div>
        <p>
            First Name:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            LastName:<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </p>
    </form>
</body>
</html>
