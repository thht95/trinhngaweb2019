<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="dProductList.ascx.cs" Inherits="WebNangCao.display.Product.dProductList" %>
<div class="header_bottom_right">					 
					 	 <div class="slider">					     
							 <div id="slider">
		<div class="section group">
			                <asp:Repeater runat="server" ID="rptListSanPham">
                                    <ItemTemplate>
                        <div class="grid_1_of_4 images_1_of_4" style="width:18%">
					 <a href='?f=product&fs=des&id=<%#:Eval("ID") %>'><img src='/<%#: Eval("sImage") %>' />
					 <h2><%#: Eval("sName") %></h2></a>
					<div class="price-details">
				       <div class="price-number">
							<p><span class="rupees"><%#:string.Format("{0:N0}",Eval("fGia")) %>  VNĐ</span></p>
					    </div>
					       		<div class="add-cart">								
									<h4><a href='?f=product&fs=des&id=<%#:Eval("ID") %>'>Xem chi tiết</a></h4>
							     </div>
							 <div class="clear"></div>
					</div>
					 
				</div>
                    </ItemTemplate>
             
                </asp:Repeater>
			</div>
		                </div>
					 <div class="clear"></div>	
                             <div style="padding-top:10px;text-align:right;">
         
             <asp:Repeater ID="rptPages" runat="server" OnItemCommand="rptPages_ItemCommand">
            <ItemTemplate>
                <asp:LinkButton id="btnPage"
                 style="padding:1px 3px; margin:1px; background:#ccc; border:solid 1px #666; font:8pt tahoma;"
                 CommandName="Page" CommandArgument="<%# Container.DataItem %>"
                 runat="server"><%# Container.DataItem %>
                </asp:LinkButton>
              
                  
            </ItemTemplate>
        </asp:Repeater>
        </div>
		         </div>
		      </div>


		   <div class="clear"></div>
