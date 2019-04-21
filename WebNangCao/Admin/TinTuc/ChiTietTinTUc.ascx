<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietTinTUc.ascx.cs" Inherits="WebNangCao.Admin.TinTuc.ChiTietTinTUc"  %>
<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

<div class="item">
    <asp:MultiView runat="server" ID="mul" ActiveViewIndex="0">
    <asp:View ID="v0" runat="server">
        <asp:DropDownList runat="server" ID="drpNewsCategory1"  AutoPostBack="true" OnSelectedIndexChanged="drpNewsCategory1_SelectedIndexChanged"></asp:DropDownList>
      
        <asp:Repeater ID="rptNewsDetails" runat="server" OnItemCommand="rptNewsDetails_ItemCommand">
            <HeaderTemplate>
            <table border='1px' cellspacing='10px' cellpadding='10px' style='border-collapse: collapse; text-align: left;'>
                <tr class="rptHead">
                    <th>Image</th>
                    <th>Title</th>
                    <th>Author</th>
                    <th>Active</th>
                    <th colspan="2">Function</th>
                </tr>
            
        </HeaderTemplate>
            <ItemTemplate>
                <tr class="rptItem">
                    <td><img src='/images/<%#:Eval("sImage") %>' width="90px" style="padding:5px 0 5px 0" /></td>
                    <td><%#:Eval("sTitle") %></td>
                    <td><%#:Eval("sAuthor") %></td>
                    <td><%#:Eval("bActive") %></td>
                    <td><asp:LinkButton ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%#:Eval("ID") %>' CssClass="lnk">Cập nhật</asp:LinkButton>
                        &nbsp;|&nbsp;<asp:LinkButton ID="lnkDelete" runat="server" CommandName="delete" CommandArgument='<%#:Eval("ID") %>' OnLoad="Delete_Load" CssClass="lnk">Xóa</asp:LinkButton></td>
                </tr>
            </ItemTemplate>
              <AlternatingItemTemplate>
                  <tr class="rptAlt">
                    <td><img src='/images/<%#:Eval("sImage") %>'  width="90px" style="padding:5px 0 5px 0" /></td>
                    <td><%#:Eval("sTitle") %></td>
                    <td><%#:Eval("sAuthor") %></td>
                    <td><%#:Eval("bActive") %></td>
                     <td><asp:LinkButton ID="lnkUpdate" runat="server" CommandName="update" CommandArgument='<%#:Eval("ID") %>' CssClass="lnk">Cập nhật</asp:LinkButton>
                        &nbsp;|&nbsp;<asp:LinkButton ID="lnkDelete" runat="server" CommandName="delete" CommandArgument='<%#:Eval("ID") %>' OnLoad="Delete_Load" CssClass="lnk">Xóa</asp:LinkButton></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                 </table>
            </FooterTemplate>
           
        </asp:Repeater>
           
        
        <asp:HiddenField  runat="server" ID="hdInsert"/>
        <asp:HiddenField  runat="server" ID="hdDelID"/>
        <asp:HiddenField  runat="server" ID="hdImage"/>
        <div><asp:LinkButton ID="lnkThemMoi" runat="server" OnClick="lnkThemMoi_Click" CssClass="lnk">Thêm mới</asp:LinkButton></div>
    </asp:View>
    <asp:View ID="v1" runat="server">
        <table style="width:100%;margin-top:10px;padding:10px;">
            <tr>
                <td style="width:100px;" class="bodertd">News Category</td>
               
                <td class="bodertd" ><asp:DropDownList ID="drpNewsCategory" runat="server"></asp:DropDownList></td>
                <td class="bodertd"></td>
            </tr>
            <tr>
                <td class="bodertd">Tiêu đề</td>
                
                <td class="bodertd"><asp:TextBox ID="txtTitle" runat="server" style="width:500px;" CssClass="text"></asp:TextBox></td>
                <td class="bodertd"></td>
            </tr>
       
             <tr>
                <td class="bodertd">Content</td>
                
                <td class="bodertd"><FTB:FreeTextBox ID="txtChitiet" runat="server"></FTB:FreeTextBox></td>
                <td class="bodertd"></td>
            </tr>
            <tr>
                <td class="bodertd">Image</td>
                
                <td class="bodertd"> <asp:FileUpload ID="FileUpload1" runat="server"  /></td>
                <td class="bodertd"></td>
            </tr>
            
            <tr>
                <td class="bodertd">Active</td>
                <td class="bodertd">
                    <asp:CheckBox ID="chkActive" runat="server" Checked="true" />
                </td>
                <td class="bodertd"> &nbsp;</td>
                
            </tr>

             <tr>
                
                <td class="bodertd"><asp:Button ID="btn" runat="server" Text="LoadData\" OnClick="btn_Click" CssClass="button"/></td>
                <td class="bodertd"></td>
                <td class="bodertd"></td>
            </tr>
            
        </table>
       
    </asp:View>
</asp:MultiView>
</div>

