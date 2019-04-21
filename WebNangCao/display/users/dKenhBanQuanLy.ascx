<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dKenhBanQuanLy.ascx.cs" Inherits="WebNangCao.display.users.dKenhBanQuanLy" %>
<div class="content-right">

     <asp:DropDownList runat="server" ID="drpSanPhamCategory1"  AutoPostBack="true" OnSelectedIndexChanged="drpSanPhamCategory1_SelectedIndexChanged"></asp:DropDownList>
      
        <asp:Repeater ID="rptSanPhamDetails" runat="server">
            <HeaderTemplate>
            <table cellspacing="0" cellpadding="0" style="width:100%;margin-top:10px;padding:10px;">
                <tr class="rptHead">
                    <td style="width:100px;">Image</td>
                    <td style="width:200px;">Tên sản phẩm</td>
                    <td style="width:100px;">Số lượng còn </td>
                    <td style="width:100px;">Số lượng đã bán</td>
                  
                   <td style="width:100px;">Giá</td>
              
                </tr>
            
        </HeaderTemplate>
            <ItemTemplate>
                <tr class="rptItem">
                    <td><img src='/images/<%#:Eval("sImage") %>' width="90px" style="padding:5px 0 5px 0" /></td>
                    <td><%#:Eval("sName") %></td>
                    <td><%#:Eval("iSoLuong") %></td>
                    <td><%#:Eval("iSoLuongBan") %></td>
                    <td><%#:Eval("fGia") %></td>
       
                </tr>
            </ItemTemplate>
              <AlternatingItemTemplate>
                  <tr class="rptAlt">
                      <td><img src='/images/<%#:Eval("sImage") %>' width="90px" style="padding:5px 0 5px 0" /></td>
                    <td><%#:Eval("sName") %></td>
                    <td><%#:Eval("iSoLuong") %></td>
                    <td><%#:Eval("iSoLuongBan") %></td>
                    <td><%#:Eval("fGia") %></td>
               <</tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                 </table>
            </FooterTemplate>
           
        </asp:Repeater>
           
        
        <asp:HiddenField  runat="server" ID="hdInsert"/>
        <asp:HiddenField  runat="server" ID="hdDelID"/>
        <asp:HiddenField  runat="server" ID="hdImage"/>
    </div>
 <div class="main" style="display:inline-table;width:100%;">
    <div class="content">
 
    </div>
 </div>