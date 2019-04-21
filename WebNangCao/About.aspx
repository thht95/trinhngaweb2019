<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebNangCao.About" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
    <div class="content">
    	<div class="section group">
				<div class="col_1_of_3 span_1_of_3">
					<h3>Who We Are</h3>
					<img src="images/about_img.jpg" alt="">
					<p>Với mục tiêu tạo ra những trải nghiệm mua sắm trực tuyến tuyệt vời, Taka luôn nỗ lực không ngừng nhằm nâng cao chất lượng dịch vụ. Khi mua hàng qua mạng tại Taka khách hàng sẽ được hưởng các tiện ích như sau:</p>
					<p>Dịch vụ chăm sóc khách hàng tận tình trước-trong-sau khi mua hàng, xuyên suốt 7 ngày/tuần, từ 8:00 đến 21:00
                       </p>
                    <p>Mức giá cạnh tranh: hơn 90% sản phẩm được giảm giá từ 10% trở lên</p>
                    <p>Giao hàng miễn phí (đối với đơn hàng từ 150.000đ trong phạm vi TP.HCM và từ 250.000đ đối với đơn hàng giao đến các tỉnh thành khác thuộc Việt Nam)</p>
                    <p></p>
				</div>
				<div class="col_1_of_3 span_1_of_3">
					<h3>Thành lập từ tháng 3/2019, đến nay website thương mại điện tử Taka cung cấp các sản phẩm thuộc các ngành hàng như sau:</h3>
				 
				 <asp:Repeater ID="rptNewsList" runat="server">
    <ItemTemplate>
        <div class="history-desc">
					<div class="history"><a href='SanPham.aspx?f=product&fs=ls&id_danhmuc=<%#:Eval("ID") %>'><%#: Eval("sName") %></a></div>
					
				 <div class="clear"></div>
				</div>
    </ItemTemplate>
</asp:Repeater>

                    
			</div>
				<div class="col_1_of_3 span_1_of_3">
					<h3>Liên hệ</h3>
					<p>Quý khách có nhu cầu liên lạc, trao đổi hoặc đóng góp ý kiến, vui lòng tham khảo các thông tin sau:</p>
				    <div class="list">
					     <ul>
					     	<li><a href="#">Liên lạc qua điện thoại: 1900 1900</a></li>
					     	<li><a href="#">Liên lạc qua email: Truy cập hotro.taka.vn</a></li>
					     	<li><a href="#">Fanpage của Taka:facebook.com/taka </a></li>
					     	<li><a href="Contact.aspx">Đối tác có nhu cầu hợp tác quảng cáo hoặc kinh doanh: </a></li>
					     	<li><a href="#">Địa chỉ nhận hàng đổi/trả/bảo hành: Trung tâm xử lý đơn hàng TAKA - 367/F370 Đường Bạch Đằng, P.2, Q.Tân Bình TP. Hồ Chí Minh (Tham khảo hướng dẫn đổi, trả, bảo hành hoặc liên hệ 1900-1900 để được hướng dẫn trước khi gửi sản phẩm về Taka)</a></li>
					     	<li><a href="#">Văn phòng: 52 Út Tịch, phường 4, quận Tân Bình, thành phố Hồ Chí Minh</a></li>
					     	
					     </ul>
					 </div>
					
				</div>
			</div>			
    </div>
 </div>
</asp:Content>
