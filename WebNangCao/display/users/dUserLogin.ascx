<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dUserLogin.ascx.cs" Inherits="WebNangCao.display.users.dUserLogin" %>
<div class="login" style="height:470px">
        <div class="login-triangle"></div>

        <h2 class="login-header" >Welcome to TAKA</h2>

        
           <p> <asp:TextBox ID="txtName" placeholder="UserName" runat="server"></asp:TextBox>
             
          
        </p>
            <p> <asp:TextBox ID="txtPassWord" placeholder="PassWord" runat="server" TextMode="Password"></asp:TextBox>
           
          
        </p>
       
            <p><asp:Button runat="server" ID="btnDangNhap" Text="Đăng nhập" OnClick="btnDangNhap_Click" /></p>
             <asp:Label runat="server" ID="lbError"></asp:Label>

    </div>