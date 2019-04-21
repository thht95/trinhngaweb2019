<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dSanPham.ascx.cs" Inherits="WebNangCao.display.dSanPham" %>
 <div class="main"  style="display:inline-table;width:100%;">
    <div class="content">
    	<div class="content_top">
    		<div class="heading">
    		<h3>New Products</h3>
    		</div>
    		<div class="see">
    			<p><a href="#">See all Products</a></p>
    		</div>
    		<div class="clear"></div>
    	</div>
	      <div class="section group">
                <asp:Repeater runat="server" ID="rptNewProduct">
                    <ItemTemplate>
                        <div class="grid_1_of_4 images_1_of_4">
					 <a href='SanPham.aspx?f=product&fs=des&id=<%#:Eval("ID") %>'><img src='/<%#: Eval("sImage") %>' />
					 <h2><%#: Eval("sName") %></h2></a>
					<div class="price-details">
				       <div class="price-number">
							<p><span class="rupees"><%#:string.Format("{0:N0}",Eval("fGia")) %>  VNĐ</span></p>
					    </div>
					       		<div class="add-cart">								
									<h4><a href="#">Add to Cart</a></h4>
							     </div>
							 <div class="clear"></div>
					</div>
					 
				</div>
                    </ItemTemplate>
                </asp:Repeater>
              
             
			
			</div>
			<div class="content_bottom">
    		<div class="heading">
    		<h3>Best Seller</h3>
    		</div>
    		<div class="see">
    			<p><a href="#">See all Products</a></p>
    		</div>
    		<div class="clear"></div>
    	</div>
			<div class="section group">
			                <asp:Repeater runat="server" ID="rptHotProduct">
                                    <ItemTemplate>
                        <div class="grid_1_of_4 images_1_of_4">
					 <a href='SanPham.aspx?f=product&fs=des&id=<%#:Eval("ID") %>'><img src='/<%#: Eval("sImage") %>' />
					 <h2><%#: Eval("sName") %></h2></a>
					<div class="price-details">
				       <div class="price-number">
							<p><span class="rupees"><%#:string.Format("{0:N0}",Eval("fGia")) %>  VNĐ</span></p>
					    </div>
					       		<div class="add-cart">								
									<h4><a href="#">Add to Cart</a></h4>
							     </div>
							 <div class="clear"></div>
					</div>
					 
				</div>
                    </ItemTemplate>
             
                </asp:Repeater>
			</div>
    </div>
 </div>