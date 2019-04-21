<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="adminControl.ascx.cs" Inherits="WebNangCao.Admin.adminControl" %>

<style>
    .menu-admin{
        position: absolute;
        left: 50px;
        border: 1px solid red;
        border-radius: 5px;
        padding: 10px;
    }
    .menu-admin b{
        float: right;
        background: #2a00ff;
        color: #feff00;
        padding: 10px;
        border-radius: 3px;
    }
</style>

<div class="menu-admin">
    <h3>Banner Admin UserName: <i><u><%=Session["username"] %></u></i></h3>
    <asp:LinkButton runat="server" ID="lnkExit" OnClick="lnkExit_Click"><b>LOG OUT</b></asp:LinkButton>
</div>
<div style="width: 100%; margin-top: 50px;">
    <div style="width: 10%; float: left;">
        <td>
            <asp:PlaceHolder runat="server" ID="plMenu"></asp:PlaceHolder>
        </td>
    </div>
    <div style="vertical-align: top; float: right; width: 88%">
        <asp:PlaceHolder runat="server" ID="plLoad"></asp:PlaceHolder>
    </div>
</div>
