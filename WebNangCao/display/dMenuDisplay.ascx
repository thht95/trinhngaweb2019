<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dMenuDisplay.ascx.cs" Inherits="WebNangCao.display.dMenuDisplay" %>
<asp:Repeater runat="server" ID="rptProductList">
    <ItemTemplate><li><a href='SanPham.aspx?f=product&fs=ls&id_danhmuc=<%#:Eval("ID") %>'><%#: Eval("sName") %></a></li></ItemTemplate>
</asp:Repeater>