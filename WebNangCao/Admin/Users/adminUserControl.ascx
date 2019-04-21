<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminUserControl.ascx.cs" Inherits="WebNangCao.Admin.Users.adminUserControl" %>
<div class="item">
    <table border='1px' cellspacing='10px' cellpadding='10px' style='border-collapse: collapse; text-align: left;'>
        <tr>
            <th>UserName</th>
            <td>
                <asp:TextBox runat="server" ID="txtUserName"></asp:TextBox></td>
        </tr>
        <tr>
            <th>PassWord</th>
            <td>
                <asp:TextBox runat="server" ID="txtPassWord" TextMode="Password"></asp:TextBox></td>
        </tr>
        <tr>
            <th>FullName</th>
            <td>
                <asp:TextBox runat="server" ID="txtFullName"></asp:TextBox></td>
        </tr>
        <tr>
            <th>Address</th>
            <td>
                <asp:TextBox runat="server" ID="txtAddress"></asp:TextBox></td>
        </tr>
        <tr>
            <th>Phone</th>
            <td>
                <asp:TextBox runat="server" ID="txtPhone"></asp:TextBox></td>
        </tr>
        <tr>
            <th>Email</th>
            <td>
                <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox></td>
        </tr>
        <tr>
            <th></th>
            <td>
                <asp:Button runat="server" ID="btnUpdate" Text="Update" OnClick="btnUpdate_Click" /></td>
        </tr>
    </table>
</div>
