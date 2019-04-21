<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DuyetSanPham.ascx.cs" Inherits="WebNangCao.Admin.SanPham.DuyetSanPham" %>
<div class="item">
    <asp:MultiView runat="server" ID="mul" ActiveViewIndex="0">
        <asp:View ID="v0" runat="server">
            <asp:DropDownList runat="server" ID="drpSanPhamCategory" AutoPostBack="true" OnSelectedIndexChanged="drpSanPhamCategory_SelectedIndexChanged"></asp:DropDownList>

            <asp:Repeater ID="rptSanPhamNewsDetails" runat="server" OnItemCommand="rptSanPhamNewsDetails_ItemCommand">
                <HeaderTemplate>
                    <table border='1px' cellspacing='10px' cellpadding='10px' style='border-collapse: collapse; text-align: left;'>
                        <tr style="text-align:center">
                            <th>Image</th>
                            <th>Tên sản phẩm</th>
                            <th>Số lượng</th>
                            <th>Giá/cái</th>
                            <th>Ngày tạo</th>
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
                            &nbsp;|&nbsp;<asp:LinkButton ID="lnkDelete" runat="server" CommandName="thaydoi" CommandArgument='<%#:Eval("ID") %>' OnLoad="Delete_Load">Duyệt</asp:LinkButton></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>

            </asp:Repeater>
            <asp:HiddenField runat="server" ID="hdInsert" />
            <asp:HiddenField runat="server" ID="hdDelID" />
            <asp:HiddenField runat="server" ID="hdImage" />

        </asp:View>
        <asp:View ID="v1" runat="server">
            <table style="width: 100%; font-size: 15px;">
                <tr>
                    <td style="width: 20%; height: auto; font-weight: bold;">Loại sản phẩm</td>
                    <td style="width: 75%; height: auto">
                        <asp:Label ID="lbLoaiSanPham" runat="server"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 20%; height: auto; font-weight: bold;">Tên sản phẩm</td>
                    <td style="width: 75%; height: auto">
                        <asp:Label ID="txtTenSP" runat="server" Style="width: 500px;"></asp:Label></td>
                </tr>

                <tr>
                    <td style="width: 20%; height: auto; font-weight: bold;">Hình ảnh</td>
                    <td style="width: 75%; height: auto">
                        <asp:Image runat="server" ID="imgHinhHanh" Width="100px" Height="100px" /></td>
                    <td></td>
                </tr>

                <tr>
                    <td style="width: 20%; height: auto; font-weight: bold;">Mô tả</td>
                    <td style="width: 75%; height: auto;">
                        <asp:Label ID="txtMoTa" runat="server" Style="width: 800px; height: 500px;"></asp:Label></td>

                </tr>
                <tr>
                    <td style="width: 20%; height: auto; font-weight: bold;">Số Lượng</td>
                    <td style="width: 75%; height: auto">
                        <asp:Label ID="txtSoLuong" runat="server" Style="width: 100px;"></asp:Label>&nbsp;&nbsp cái</td>

                </tr>

                <tr>
                    <td style="width: 20%; height: auto; font-weight: bold;">Giá</td>
                    <td style="width: 75%; height: auto">
                        <asp:Label ID="txtGia" runat="server" Style="width: 100px;"></asp:Label>&nbsp;&nbsp / cái</td>

                </tr>

                <tr>
                    <td style="width: 20%; height: auto; font-weight: bold;">Ngày tạo sản phẩm</td>
                    <td style="width: 75%; height: auto">
                        <asp:Label ID="txtNgayTao" runat="server" Style="width: 300px;"></asp:Label></td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</div>
