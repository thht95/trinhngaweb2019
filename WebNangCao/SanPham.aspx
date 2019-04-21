<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SanPham.aspx.cs" Inherits="WebNangCao.SanPham" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  	
<div class="content-left" runat="server" id="menusanpham">
            <div class="header_slide">
			<div class="header_bottom_left">				
				<div class="categories">
				  <ul>
				  	<h3>Categories</h3>
                       <asp:PlaceHolder runat="server" ID="PlaceHolder1">

		 </asp:PlaceHolder> 
				  </ul>
				</div>					
	  	     </div>
					 
		  
		</div>

             
        </div>
  <asp:PlaceHolder runat="server" ID="plLoad">

		 </asp:PlaceHolder> 	
</asp:Content>
