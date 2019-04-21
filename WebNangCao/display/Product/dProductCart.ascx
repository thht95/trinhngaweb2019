<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dProductCart.ascx.cs" Inherits="WebNangCao.display.Product.dProductCart" %>


<asp:MultiView runat="server" ID="mul" ActiveViewIndex="0">
    <asp:View ID="v1" runat="server"> <!-- v1 có giá trị là 0 và được chạy ẩn !-->
    <asp:Label runat="server" ID="txtText" Text="Chưa có sản phẩm nào được chọn" ForeColor="Red" Font-Bold="true" Font-Size="Medium" ></asp:Label>
<div id="giohang" runat="server">
<asp:Repeater runat="server" ID="rptProductCart" OnItemCommand="rptProductCart_ItemCommand">
    <HeaderTemplate>
        <table style="width:100%;border:1px;border-collapse:collapse" >
            <tr>
                <th>Tên sản phẩm</th>
                <th>Số Lượng</th>
                <th>Giá</th>
                <th>Thành tiền</th>
                <th></th>
            </tr>
    </HeaderTemplate>
    <ItemTemplate>
        <tr>
            <td> <a href='?f=product&fs=des&id=<%#:Eval("ID") %>'><%#:Eval("sName") %></a></td>
            <td><%#:Eval("iSoLuong") %></td>
            <td><%#:string.Format("{0:N0}", Eval("fGia")) %></td>
            <td><%#:string.Format("{0:N0}", Eval("Money")) %></td>
            <td><asp:LinkButton runat="server" ID="lnkDelete" OnLoad="msgDelete" CommandArgument='<%#:Eval("ID") %>'>Xóa</asp:LinkButton></td>
        </tr>
    </ItemTemplate>
    <FooterTemplate>
      </table>
        </FooterTemplate>
</asp:Repeater>

<div style="color:red;font-weight:bold;text-align:right;"><asp:Literal runat="server" ID="ltTotal"></asp:Literal></div>
   
<div><asp:Button  runat="server" Text="Thanh Toán" ID="btnThanhToan" OnLoad="btnThanhToan_Load" OnClick="btnThanhToan_Click"/></div>    
</div>
        

        
    </asp:View>
    
    <asp:View ID="v2" runat="server">
       <asp:Label runat="server" ID="Label1" Text="Thanh toán thành công" ForeColor="Blue" Font-Bold="true"  Font-Size="Medium" ></asp:Label>
     
        <table style="margin-top:10px;padding:10px;">
            <tr>
                <td>Mã Hóa Đơn</td>
                <td><asp:Label runat="server" ID="lbMaHoaDon"></asp:Label></td>
            </tr>
            <tr>
                <td>Người mua</td>
                <td><asp:Label runat="server" ID="lbNguoiMua"></asp:Label></td>
            </tr>
             <tr>
                <td>Tổng tiền</td>
                <td><asp:Label runat="server" ID="lbTongTien"></asp:Label></td>
            </tr>
             <tr>
                <td>Số điện thoại</td>
                <td><asp:Label runat="server" ID="lbDienThoai"></asp:Label></td>
            </tr>
             <tr>
                <td>Địa chỉ</td>
                <td><asp:Label runat="server" ID="lbDiaChi"></asp:Label></td>
            </tr>
           
        </table>
    </asp:View>
</asp:MultiView>