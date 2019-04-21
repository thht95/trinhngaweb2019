<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dUserDangKy.ascx.cs" Inherits="WebNangCao.display.users.dUserDangKy" %>
<div class="login">
    <div class="login-triangle"></div>

    <h2 class="login-header">SIGN UP</h2>
    <p>
        <asp:TextBox ID="txtName" placeholder="UserName" runat="server"></asp:TextBox>
        

    </p>
    <p>
        <asp:TextBox ID="txtPassWord" placeholder="PassWord" runat="server" TextMode="Password"></asp:TextBox>
        
    </p>
    <p>
        <asp:TextBox ID="txtPassWord2" placeholder="Confirm password" runat="server" TextMode="Password"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtEmail" placeholder="Mail" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtPhone" placeholder="Phone" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtFullName" placeholder="Full name" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:TextBox ID="txtDiaChi" placeholder="Địa chỉ" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button runat="server" ID="btnDangKy" Text="Đăng ký" OnClick="btnDangKy_Click" /></p>
    <asp:Label ID="lbError" runat="server" Text="" Font-Bold="true" Font-Size="Larger" ForeColor="Red"></asp:Label>
</div>
