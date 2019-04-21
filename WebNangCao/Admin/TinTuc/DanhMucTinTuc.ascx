<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DanhMucTinTuc.ascx.cs" Inherits="WebNangCao.Admin.TinTuc.DanhMucTinTuc" %>

<div class="item">
    <div><h3>Danh sách tin tức</h3></div>
    <asp:MultiView runat="server" ID="mul" ActiveViewIndex="0">
        <asp:View ID="v1" runat="server">
            <!-- v1 có giá trị là 0 và được chạy ẩn !-->
            <div>
                <asp:Repeater ID="rptDanhMucTinTuc" runat="server" OnItemCommand="rptDanhMucTinTuc_ItemCommand">
                    <HeaderTemplate>
                        <table border='1px' cellspacing='10px' cellpadding='10px' style='border-collapse: collapse; text-align: left;'>
                            <tr>
                                <th>STT</th>
                                <th>Tên danh mục</th>
                                <th>Trạng thái</td>
                                <th colspan="2">Chức năng</td>
                                <%--<th>Chức năng</th>--%>
                            </tr>
                    </HeaderTemplate>
                    <ItemTemplate>
                        <tr>
                            <td><%#  Container.ItemIndex + 1 %></td>
                            <td><%# Eval("sName") %></td>
                            <td><%# Eval("bActive") %></td>
                            <td>
                                <asp:LinkButton runat="server" CommandName="Update" CommandArgument='<%# Eval("ID") %>'> Sửa</asp:LinkButton></td>
                            <td>
                                <asp:LinkButton runat="server" CommandName="Delete" CommandArgument='<%# Eval("ID") %>' OnLoad="msgDelete">Xóa</asp:LinkButton></td>
                        </tr>
                    </ItemTemplate>
                    <FooterTemplate>
                        </table>
                    </FooterTemplate>
                </asp:Repeater>
            </div>
            <div>
                <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Thêm mới sản phẩm</asp:LinkButton>
            </div>



        </asp:View>
        <asp:View ID="v2" runat="server">
            <asp:HiddenField ID="hdIDdanhmuctintuc" runat="server" />
            <asp:HiddenField ID="hdInsert" runat="server" />
            <table style="margin-top: 10px; padding: 10px;">
                <tr>
                    <td>Tên danh mục</td>
                    <td>
                        <asp:TextBox runat="server" ID="tendanhmuctintuc"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Trạng thái</td>
                    <td>
                        <asp:CheckBox runat="server" ID="chkTrangThai" Checked="true" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button runat="server" ID="btnThem" Text="Thêm" OnClick="btnThem_Click" /></td>
                </tr>
            </table>
        </asp:View>
    </asp:MultiView>
</div>
