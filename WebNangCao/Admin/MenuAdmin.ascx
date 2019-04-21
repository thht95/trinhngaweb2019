<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MenuAdmin.ascx.cs" Inherits="WebNangCao.Admin.MenuAdmin" %>
<style>
    /*//CSS nav*/
    .nav ul{
        margin-top: 50px;
        list-style-type: none;
        text-align: left;
        width: 250px;
    }
    .nav ul li{
        width: auto;
        height: 45px;
        line-height: 45px;
        border-bottom: 1px solid white;
    }
    .nav a{
        font-size: 20px;
        text-decoration: none;
        color: white;
        font-weight: bold;
        text-transform: uppercase;
        display: block;
        background: #ff6a00;

    }
    .nav li a:hover{
        background: #4cff00;
    }

    /*CSS control*/
    .nav-bar{
        position: relative;
        left: 250px;
    }
    .nav-bar a{
        padding: 10px;
        background: #ffd800;
    }
    .nav-bar a:hover{
        background: #b6ff00;
    }

    .item{
        width: 1000px;
        position: relative;
        left: 250px;
        top: 30px;
    }
  
</style>
<div class="nav">
    <ul>
        <li><a href="../TrangChu.aspx">Trang chủ</a></li>
        <li><a href="../Administrator.aspx">Trang quản trị</a></li>
        <li><a href="../Administrator.aspx?f=tintuc">Trang tin tức</a></li>
        <li><a href="../Administrator.aspx?f=sanpham">Trang sản phẩm</a></li>
        <li><a href="../Administrator.aspx?f=user" id="fff">Trang tài khoản</a></li>
        <li><a href="../Administrator.aspx?f=contact">Trang liên hệ</a></li>
    </ul>
</div>
