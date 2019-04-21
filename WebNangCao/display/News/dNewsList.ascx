<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dNewsList.ascx.cs" Inherits="WebNangCao.display.News.dNewsList" %>
<asp:Repeater ID="rptNewsDetailsnn" runat="server" >
            <HeaderTemplate>

            <table cellspacing="0" cellpadding="0" style="width:100%">
        </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td colspan="2"><a href="?f=news&fs=del&id=<%#: Eval("ID") %>" class="title"> <%#:Eval("sTitle") %></a></td>
                </tr>
                <tr>
                    <td style="vertical-align:top;"><img src='/images/<%#:Eval("sImage") %>' width="120px" style="padding:5px 0 5px 0" /></td>
                    <td style="vertical-align:top;"><%#:Eval("dNgayTao") %></td>
                </tr>
            </ItemTemplate>
            <FooterTemplate>
                 </table>
            </FooterTemplate>
         
        </asp:Repeater>
