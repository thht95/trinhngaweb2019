<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dKenhBanThemSP.ascx.cs" Inherits="WebNangCao.display.users.dKenhBanThemSP" %>
<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>
<div class="content-right">
<table style="width:100%;">
            <tr>
                <td style="width:100px;" class="bodertd">Sản Phẩm Category</td>
                <td class="bodertd" ><asp:DropDownList ID="drpNewsCategory" runat="server"></asp:DropDownList></td>
                <td class="bodertd"></td>
            </tr>
            <tr>
                <td class="bodertd">Tên sản phẩm</td>
                
                <td class="bodertd"><asp:TextBox ID="txtTenSanPham" runat="server" style="width:500px;" ></asp:TextBox></td>
                <td class="bodertd"></td>
            </tr>

            <tr>
                <td class="bodertd">Giá</td>
                
                <td class="bodertd"><asp:TextBox ID="txtGia" runat="server" style="width:200px;" TextMode="Number"></asp:TextBox></td>
                <td class="bodertd"></td>
            </tr>
            
            <tr>
                <td class="bodertd">Số lượng</td>
                
                <td class="bodertd"><asp:TextBox ID="txtSoLuong" runat="server" style="width:100px;" TextMode="Number" ></asp:TextBox></td>
                <td class="bodertd"></td>
            </tr>
             <tr>
                <td class="bodertd">Mô tả sản phẩm</td>
                
                <td class="bodertd"><FTB:FreeTextBox ID="txtChitiet" runat="server"></FTB:FreeTextBox></td>
                <td class="bodertd"></td>
            </tr>
            <tr>
                <td class="bodertd">Image</td>
                <td class="bodertd"> <asp:FileUpload ID="FileUpload1" runat="server"  /></td>
                <td class="bodertd"></td>
            </tr>
            
         

             <tr>
                
                <td class="bodertd"><asp:Button ID="btn" runat="server" Text="LoadData\"  CssClass="button" OnClick="btn_Click"/></td>
                <td class="bodertd"></td>
                <td class="bodertd"></td>
            </tr>
            
        </table>
<asp:HiddenField  runat="server" ID="hdImage"/>
    </div>