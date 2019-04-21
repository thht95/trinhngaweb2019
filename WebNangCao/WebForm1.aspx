<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebNangCao.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:MultiView runat="server" ID="mul" ActiveViewIndex="0">
    <asp:View ID="v0" runat="server">
<asp:GridView ID="gvHoaDon" runat="server" AutoGenerateColumns="false">
    <Columns>
       <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center"><ItemTemplate><asp:LinkButton runat="server" ID="lnkHoaDon" Text='<%# Container.DataItemIndex + 1 %>' CommandArgument='<%#:Eval("ID") %>' OnClick="lnkHoaDon_Click"></asp:LinkButton> </ItemTemplate></asp:TemplateField>
        <asp:BoundField DataField="fTongTien" HeaderText="fTongTien" />
         <asp:BoundField DataField="dNgayTao" HeaderText="dNgayTao" />
    </Columns>
</asp:GridView>

    </asp:View>
     <asp:View ID="v1" runat="server">
         <asp:Label ID="txt" Text="f" runat="server"></asp:Label>
         <asp:ListView ID="ListView1" runat="server">
             <AlternatingItemTemplate>
                 <tr>
                     <%--<td><asp:Label runat="server" ID="lbTenSanPham" Text='<%#:Eval("sName") %>'></asp:Label></td>--%>
                     <td><asp:Label runat="server" ID="Label1" Text='<%#:Eval("fGia") %>'></asp:Label></td>
                     <td><asp:Label runat="server" ID="Label2" Text='<%#:Eval("iSoluong") %>'></asp:Label></td>
                 </tr>
             </AlternatingItemTemplate>
              <ItemTemplate>
                  <tr style="background-color:#E0FFFF;color:#333333">
                     <%-- <td>
                          <asp:Label runat="server" ID="lbIDGioHang" Text='<%# Eval("id_giohang") %>'></asp:Label>
                      </td
                       <td>
                          <asp:Label runat="server" ID="lbTenSanPham" Text='<%# Eval("sName") %>'></asp:Label>
                      </td>--%>
                       <td>
                          <asp:Label runat="server" ID="lbSoLuongMua" Text='<%# Eval("iSoLuong") %>'></asp:Label>
                      </td>
                                             <td>
                          <asp:Label runat="server" ID="lbGia" Text='<%# Eval("fGIa") %>'></asp:Label>
                      </td>

                  </tr>
              </ItemTemplate>
             <LayoutTemplate>
                 <table runat="server" >
                     <tr runat="server">
                         <td runat="server">
                             <table runat="server" id="itemPlaceHolderContainer" border="1" style="background-color:#ffffff;border-collapse:collapse;border-color:#999999;border-style:none;border-width:1px;">
                                <tr runat="server" style="background-color:#E0ffff;color:#333333">
                                <%--    <th>Mã Hóa Đơn</th>
                                    <th>Tên Sản Phẩm</th>--%>
                                    <th runat="server">Số lượng mua</th>
                                    <th runat="server">Giá</th>
                                </tr>
                                 <tr id="itemPlaceholder" runat="server">
                                     
                                 </tr>

                             </table>
                         </td>
                     </tr>

                 </table>
             </LayoutTemplate>
             <SelectedItemTemplate>
                   <tr style="background-color:#E2DED6;color:#333333;font-weight:bold;">
                     <%-- <td>
                          <asp:Label runat="server" ID="lbIDGioHang" Text='<%# Eval("id_giohang") %>'></asp:Label>
                      </td
                       <td>
                          <asp:Label runat="server" ID="lbTenSanPham" Text='<%# Eval("sName") %>'></asp:Label>
                      </td>--%>
                       <td>
                          <asp:Label runat="server" ID="lbSoLuongMua" Text='<%# Eval("iSoLuong") %>'></asp:Label>
                      </td>
                                             <td>
                          <asp:Label runat="server" ID="lbGia" Text='<%# Eval("lbGia") %>'></asp:Label>
                      </td>

                  </tr>
             </SelectedItemTemplate>
            
             
         </asp:ListView>
            
         </asp:View>

</asp:MultiView>
        </div>
    </form>
</body>
</html>
