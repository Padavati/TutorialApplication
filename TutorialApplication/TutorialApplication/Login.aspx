<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TutorialApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
    <link rel="stylesheet" href="Content/MyStyleSheet.css" />
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <table class="tablestyle1">
                <tr>
                    <td>EmailID</td>
                    <td>
                        <asp:TextBox ID="txtlogin" runat="server" />
                    </td>
                </tr>
                <tr>
                    <td>Password</td>
                    <td><asp:TextBox ID="txtpwd" TextMode="Password" runat="server" /></td>
                </tr>
            <tr>
                <td></td>
                <td><asp:Button ID="btnLogin" runat="server" Text="Login" />
                <asp:Button ID="btnReset" runat="server" Text="Reset"/>
                    </td>
            </tr>
                </table>
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Register.aspx">Register</asp:HyperLink>
            <hr />
            <div>
                <asp:Label Text="" ID="lblResult" runat="server" />
            </div>
            
        </div>
    </form>
</body>
</html>
