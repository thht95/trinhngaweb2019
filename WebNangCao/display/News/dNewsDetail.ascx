<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dNewsDetail.ascx.cs" Inherits="WebNangCao.display.News.dNewsDetail" %>

<style>
    div{
        text-align: justify;
    }

    .title{
        font-size: 25px;
        text-align: center;
        font-weight: bold;
    }
    .date{
        color: #00bdff;
        padding: 10px;
    }
    .content{
        padding: 10px;

    }
    .author{
        margin-top: 20px;
        color: #6c6cb3;
    }
</style>

<div class="title">
    <asp:Literal ID="ltTitle" runat="server"></asp:Literal>
</div>
<div class="date">
    <asp:Literal ID="ltNgayTao" runat="server"></asp:Literal>
</div>
<div class="content">
    <asp:Literal ID="ltContent" runat="server"></asp:Literal>
</div>
<div class="author">
    <label>Tác giả: </label>
    <asp:Literal ID="ltAuthor" runat="server"></asp:Literal>
</div>
<hr/>
<div style="margin-top: 20px; color: red; font-size: 30px">TIN TỨC KHÁC</div>
<hr / style="width: 250px; float: left">
<br />
<asp:Repeater ID="rptNewsList" runat="server">
    <ItemTemplate>
        <div>
            <a href="?f=news&fs=del&id=<%#: Eval("ID") %>" class="title"><%#:Eval("sTitle") %></a>
        </div>
    </ItemTemplate>
</asp:Repeater>
