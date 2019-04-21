<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dKenhBanQuanLyDonHang.ascx.cs" Inherits="WebNangCao.display.users.dKenhBanQuanLyDonHang" %>
<asp:MultiView runat="server" ID="mul" ActiveViewIndex="0">
    <asp:View ID="v0" runat="server">
<asp:GridView ID="gvHoaDon" runat="server" AutoGenerateColumns="False" AllowPaging="False" AllowSorting="True" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnPageIndexChanging="gvHoaDon_PageIndexChanging" OnSorting="gvHoaDon_Sorting" PageSize="8">
    <Columns>
       <asp:TemplateField HeaderText="STT" ItemStyle-HorizontalAlign="Center"><ItemTemplate><asp:LinkButton runat="server" ID="lnkHoaDon" Text='<%# Container.DataItemIndex + 1 %>' CommandArgument='<%#:Eval("ID") %>' OnClick="lnkHoaDon_Click"></asp:LinkButton> </ItemTemplate>
           <ItemStyle HorizontalAlign="Center" />
        </asp:TemplateField>
        <asp:BoundField DataField="fTongTien" HeaderText="Tổng tiền" SortExpression="fTongTien" />
         <asp:BoundField DataField="dNgayTao" HeaderText="Ngày mua" />
    </Columns>
    <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
    <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="#FFFFCC" />
    <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
    <RowStyle BackColor="White" ForeColor="#330099" />
    <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
    <SortedAscendingCellStyle BackColor="#FEFCEB" />
    <SortedAscendingHeaderStyle BackColor="#AF0101" />
    <SortedDescendingCellStyle BackColor="#F6F0C0" />
    <SortedDescendingHeaderStyle BackColor="#7E0000" />
</asp:GridView>

    </asp:View>
     <asp:View ID="v1" runat="server">
    <span style="font-weight:100;"> Mã Đơn Hàng <asp:Label runat="server" ID="lbMaDonHang"></asp:Label></span>
         <asp:HiddenField runat="server" ID="hdshort" Value="ASC" />
         <asp:ListView ID="ListView1" runat="server">
             <AlternatingItemTemplate>
                 <tr>
                     <td><asp:Label runat="server" ID="lbTenSanPham" Text='<%#:Eval("sName") %>'></asp:Label></td>
                     <td><asp:Label runat="server" ID="Label1" Text='<%#:Eval("Số lượng mua") %>'></asp:Label></td>
                     <td><asp:Label runat="server" ID="Label2" Text='<%#:Eval("Giá sản phẩm") %>'></asp:Label></td>
                      <td><asp:Label runat="server" ID="Label3" Text='<%#:Eval("Thành tiên") %>'></asp:Label></td>
                 </tr>
                 </tr>
             </AlternatingItemTemplate>
              <ItemTemplate>
                  <tr style="background-color:#E0FFFF;color:#333333">
                       <td>
                          <asp:Label runat="server" ID="lbTenSanPham" Text='<%# Eval("sName") %>'></asp:Label>
                      </td>
                       <td>
                          <asp:Label runat="server" ID="lbSoLuongMua" Text='<%# Eval("Số lượng mua") %>'></asp:Label>
                      </td>
                                             <td>
                          <asp:Label runat="server" ID="lbGiaSP" Text='<%# Eval("Giá sản phẩm") %>'></asp:Label>
                      </td>
                          <td>
                          <asp:Label runat="server" ID="lbThanhTien" Text='<%# Eval("Thành tiên") %>'></asp:Label>
                      </td>

                  </tr>
              </ItemTemplate>
             <LayoutTemplate>
                 <table runat="server" >
                     <tr runat="server">
                         <td runat="server">
                             <table runat="server" id="itemPlaceHolderContainer" border="1" style="background-color:#ffffff;border-collapse:collapse;border-color:#999999;border-style:none;border-width:1px;">
                                <tr runat="server" style="background-color:#E0ffff;color:#333333">
                                    <th>Tên Sản Phẩm</th>
                                    <th runat="server">Số lượng mua</th>
                                    <th runat="server">Giá sản phẩm</th>
                                    <th runat="server">Thành tiền</th>
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
                       <td>
                          <asp:Label runat="server" ID="lbTenSanPham" Text='<%# Eval("sName") %>'></asp:Label>
                      </td>
                       <td>
                          <asp:Label runat="server" ID="lbSoLuongMua" Text='<%# Eval("Số lượng mua") %>'></asp:Label>
                      </td>
                       <td>
                          <asp:Label runat="server" ID="lbGiaSP" Text='<%# Eval("Giá sản phẩm") %>'></asp:Label>
                      </td>
                          <td>
                          <asp:Label runat="server" ID="lbThanhTien" Text='<%# Eval("Thành tiên") %>'></asp:Label>
                      </td>

                  </tr>
             </SelectedItemTemplate>
            
             
         </asp:ListView>
         
         
             <span style="font-weight:100;">Tổng tiền <asp:Label runat="server" ID="lbTongTien"></asp:Label></span>
         </asp:View>

</asp:MultiView>