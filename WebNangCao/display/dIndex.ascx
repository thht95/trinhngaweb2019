<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dIndex.ascx.cs" Inherits="WebNangCao.display.dIndex" %>
<div class="content-left">
            <div class="header_slide">
			<div class="header_bottom_left">				
				<div class="categories">
				  <ul>
				  	<h3>Categories</h3>
                       <asp:PlaceHolder runat="server" ID="plLoad">

		 </asp:PlaceHolder> 
				  </ul>
				</div>					
	  	     </div>
					 
		  
		</div>

             
        </div>
<div class="content-right">
<div class="slideshow-container ">
			<!-- Full-width images with number and caption text -->
			    <div  class="mySlides fade">
								<a href='SanPham.aspx?f=product&fs=ls&id_danhmuc=4'>
                    <img src="images/slide1.jpg" class="img-responsive" style="width:100%"/>
                                     </a>
								<div class="text">Thời trang</div>
                                   
							</div>
							<div class="mySlides fade">
								<a href='SanPham.aspx?f=product&fs=ls&id_danhmuc=1007'>
                                    <img src="images/slide2.jpg" class="img-responsive" style="width:100%"/>
								</a>
								<div class="text">Đồ dùng gia dụng</div>
							</div>
                <div class="mySlides fade">
								<a href='SanPham.aspx?f=product&fs=ls&id_danhmuc=6'>
                                    <img src="images/slide3.jpg" class="img-responsive" style="width:100%" /> 
								</a>
								<div class="text">Mỹ phẩm làm đẹp</div>
							</div>

							<!-- Next and previous buttons -->
							<a class="prev" onclick="plusSlides(-1)">&#10094;</a>
							<a class="next" onclick="plusSlides(1)">&#10095;</a>
						</div>
        <br>
						<!-- The dots/circles -->
<div style="text-align:center">
							<span class="dot" onclick="currentSlide(1)"></span> 
							<span class="dot" onclick="currentSlide(2)"></span> 
                            <span class="dot" onclick="currentSlide(3)"></span> 
						</div>
    
    </div>
 <div class="main" style="display:inline-table;width:100%;">
    <div class="content">
    	<div class="content_top">
    		<div class="heading">
    		<h3>New Products</h3>
    		</div>
    		<div class="see">
    			<p><a href="SanPham.aspx">See all Products</a></p>
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
									<h4><a href='SanPham.aspx?f=product&fs=des&id=<%#:Eval("ID") %>'>Xem chi tiết</a></h4>
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
    			<p><a href="SanPham.aspx">See all Products</a></p>
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
									<h4><a href='SanPham.aspx?f=product&fs=des&id=<%#:Eval("ID") %>'>Xem chi tiêt</a></h4>
							     </div>
							 <div class="clear"></div>
					</div>
					 
				</div>
                    </ItemTemplate>
             
                </asp:Repeater>
			</div>
    </div>
 </div>