<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="TutorialApplication.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript">
        function Validate()
        {
            var Firstname = document.getElementById("<%=txtfname.ClientID %>".value;)
            var Lastname = document.getElementById("<%=txtlname.ClientID%>".value;)
            var flag = false;
            if (Firstname == '')
                alert('EmailID cannot be empty')
            else if (Lastname == '')
                alert('Password cannot be empty')
            else
                flag = true;
            return flag;
        }

    </script>
    <link rel="stylesheet" href="Content/MyStyleSheet.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Register</h1>
            <hr />
            <table class="tablestyle1">
                <tr>
                    <td class="auto-style4">Firstname</td>
                    <td>&nbsp;<asp:TextBox ID="txtfname" runat="server"></asp:TextBox>
                    <td class="auto-style1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Firstname can't be empty!" ControlToValidate="txtfname" ForeColor="Red"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Lastname</td>
                    <td><asp:TextBox ID="txtlname" runat="server"></asp:TextBox>
                    <td class="auto-style1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Lastname can't be empty" ControlToValidate="txtLname" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Email</td>
                    <td><asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    <td class="auto-style1">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtemail" ErrorMessage="Email must" ForeColor="#FF3300"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Incorrect Format" ForeColor="#FF3300" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vg">Invalid Email</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Mobile</td>
                    <td><asp:TextBox ID="txtmobile" runat="server"></asp:TextBox>
                    <td class="auto-style3">
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtmobile" ErrorMessage="Numerics only" ForeColor="#FF3300" ValidationExpression="\d{10}"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Password</td>
                    <td><asp:TextBox ID="txtpwd" TextMode="Password" runat="server"></asp:TextBox></td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtpwd" ErrorMessage="Required" ForeColor="#FF3300">Enter valid password</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">ReType Password</td>
                    <td><asp:TextBox ID="txtretypepwd" TextMode="Password" runat="server" ></asp:TextBox></td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="txtpwd" ControlToValidate="txtretypepwd" ErrorMessage="Not matched" ForeColor="#FF3300">Password Mismatched</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td>
                        <asp:Button ID="btnRegister" runat="server" Text="Register" OnclientClick="return Validate()" OnClick="btnRegister_Click" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" />
                    </td>
                </tr>
            </table>
            <div>
                <asp:Label Text="" ID="lblResult" runat="server" />
            </div>
            <div>
                <h1>User Details</h1>
                <asp:GridView ID="gvUserInfo" runat="server"></asp:GridView>
            </div>
        </div>
    </form>
</body>
</html>
