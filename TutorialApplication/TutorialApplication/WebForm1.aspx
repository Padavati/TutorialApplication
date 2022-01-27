<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" MasterPageFile="~/TutorialMaster.Master" Inherits="TutorialApplication.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="Content/MyStyleSheet.css" />
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <div>
            <table class="tablestyle1">
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label1" runat="server" Text="ID"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtID" runat="server" Width="385px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtName" runat="server" Width="384px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label3" runat="server" Text="Course"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtCourse" runat="server" Width="386px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label4" runat="server" Text="Fee"></asp:Label></td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtFee" runat="server" Width="385px"></asp:TextBox></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="btnSave" runat="server" OnClick="btnSave_Click" Text="Save"/>
                        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
                        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
                        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" />
                        <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" /></td>
                </tr>
            </table>



            <hr />
            <asp:Label Text="" ID="lblResult" runat="server" />
            <hr />
            <h2>Tutorial Details</h2>
            <asp:GridView ID="gvTutorialDetails" runat="server"></asp:GridView>
        </div>
    
 </asp:Content>
