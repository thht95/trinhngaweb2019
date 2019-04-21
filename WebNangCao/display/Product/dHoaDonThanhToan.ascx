<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dHoaDonThanhToan.ascx.cs" Inherits="WebNangCao.display.Product.dHoaDonThanhToan" %>
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