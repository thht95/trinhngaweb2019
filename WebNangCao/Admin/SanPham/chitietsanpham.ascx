<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="chitietsanpham.ascx.cs" Inherits="WebNangCao.Admin.SanPham.chitietsanpham" %>
<div class="item">
    <asp:MultiView runat="server" ID="mul" ActiveViewIndex="0">
        <asp:View ID="v0" runat="server">
            <asp:DropDownList runat="server" ID="drpSanPhamCategory" AutoPostBack="true" OnSelectedIndexChanged="drpSanPhamCategory_SelectedIndexChanged"></asp:DropDownList>

            <asp:Repeater ID="rptSanPhamNewsDetails" runat="server" OnItemCommand="rptSanPhamNewsDetails_ItemCommand">
                <HeaderTemplate>
                    <table border='1px' cellspacing='10px' cellpadding='10px' style='border-collapse: collapse; text-align: left;'>
                        <tr style="text-align: center;">
                            <th>Image</th>
                            <th>
                            Tên sản phẩm</td>
                            <th>
                            Số lượng</td>
                            <th>
                            Giá/cái</td>
                            <th>
                            Ngày tạo</td>
                            <th>Chức năng</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td>
                            <img src='<%#:Eval("sImage") %>' width="100px;" /></td>
                        <td style="text-align: center;"><%#:Eval("sName") %></td>
                        <td style="text-align: center;"><%#:Eval("iSoLuong") %></td>
                        <td style="text-align: center;"><%#:Eval("fGia") %></td>
                        <td style="text-align: center;"><%#:Eval("dNgayTao") %></td>

                        <td>
                            <asp:LinkButton ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%#:Eval("ID") %>'>Xem chi tiết</asp:LinkButton>
                            &nbsp;|&nbsp;
                            <asp:LinkButton ID="lnkDelete" runat="server" CommandName="thaydoi" CommandArgument='<%#:Eval("ID") %>' OnLoad="Delete_Load">Ẩn</asp:LinkButton>
                        </td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>

            </asp:Repeater>

            <asp:Label runat="server" ID="lbTest"></asp:Label>
            <asp:HiddenField runat="server" ID="hdInsert" />
            <asp:HiddenField runat="server" ID="hdDelID" />
            <asp:HiddenField runat="server" ID="hdImage" />

        </asp:View>
        <asp:View ID="v1" runat="server">
            <table border='1px' cellspacing='10px' cellpadding='10px' style='border-collapse: collapse; text-align: left;'>
                <tr>
                    <th>Loại sản phẩm</th>
                    <td>
                        <asp:Label ID="lbLoaiSanPham" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th>Tên sản phẩm</th>
                    <td>
                        <asp:Label ID="txtTenSP" runat="server" Style="width: 500px;"></asp:Label>
                    </td>
                </tr>

                <tr>
                    <th>Hình ảnh</th>
                    <td>
                        <asp:Image runat="server" ID="imgHinhHanh" Width="100px" Height="100px" />
                    </td>
                </tr>

                <tr>
                    <th>Mô tả</th>
                    <td>
                        <asp:Label ID="txtMoTa" runat="server" Style="width: 800px; height: 500px;"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <th>Số Lượng</th>
                    <td>
                        <asp:Label ID="txtSoLuong" runat="server" Style="width: 100px;"></asp:Label>&nbsp;&nbsp cái</td>
                </tr>

                <tr>
                    <th>Giá</th>
                    <td>
                        <asp:Label ID="txtGia" runat="server" Style="width: 100px;"></asp:Label>&nbsp;&nbsp / cái</td>
                </tr>

                <tr>
                    <th>Ngày tạo sản phẩm</th>
                    <td>
                        <asp:Label ID="txtNgayTao" runat="server" Style="width: 300px;"></asp:Label></td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</div>
