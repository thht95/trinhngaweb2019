<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dProductDetail.ascx.cs" Inherits="WebNangCao.display.Product.dProductDetail" %>
<div class="header_bottom_right" id="detail" runat="server">					 
					 	 <div class="slider">					     
							 <div id="slider">
			                    <div style="text-align:center;font-size:25px;font-weight:100;">
    <asp:Literal ID="ltName" runat="server"></asp:Literal></div>
<div style="float: left; width:30%;">
    <asp:Literal ID="ltImage" runat="server"></asp:Literal></div>
<div style="float: left;width:68%;margin-left:5px;">
   <asp:Literal ID="ltDesc" runat="server"></asp:Literal>
    <br />
    <br />
     
   <asp:Label runat="server" ID="lbPrice" BackColor="#FF3300" ForeColor="White"></asp:Label>
    <br />
   <br />Tình trang:<asp:Label runat="server" ID="lbTrangThai" Font-Size="Medium"></asp:Label>
    <br />
   <br />
    Số lượng mua: <asp:TextBox runat="server" ID="txtSoLuong" TextMode="Number" Width="50px" Text="1" ForeColor="Red"></asp:TextBox>
    <br /><asp:LinkButton runat="server" ID="lnkCart" OnClick="lnkCart_Click" Font-Size="25px" Font-Bold="true">Add to cart</asp:LinkButton> 
</div>
<div style="clear: both;"></div>
<div style="float: left;">
    <asp:Literal ID="ltContent" runat="server"></asp:Literal></div>
		                </div>
					 <div class="clear"></div>					       
		         </div>
		      </div>

		   <div class="clear"></div>
