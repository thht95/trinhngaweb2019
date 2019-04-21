<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebNangCao.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="main">
    <div class="content">
    	<div class="section group">
				<div class="col span_2_of_3">
				  <div class="contact-form">
				  	<h2>Contact Us</h2>
					    
					    	<div>
						    	<span><label>Name</label></span>
						    	<span><input type="text" class="textbox" id="txtName" runat="server" ></span>
						    </div>
						    <div>
						    	<span><label>E-mail</label></span>
						    	<span><input type="text" class="textbox" id="txtEmail" runat="server"></span>
						    </div>
						    <div>
						     	<span><label>Company Name</label></span>
						    	<span><input type="text" class="textbox" id="txtCompany" runat="server"></span>
						    </div>
						    <div>
						    	<span><label>Subject</label></span>
						    	<span><textarea id="txtSubJect" runat="server"> </textarea></span>
						    </div>
						   <div>
						   		<span><asp:Button ID="btnSubmit" runat="server" Text="submit" CssClass="myButton"  OnClick="btnSubmit_Click"/></span>
						  </div>
                     
					
				  </div>
  				</div>
				<div class="col span_1_of_3">
				
      			<div class="company_address">
				     	<h3>Thông tin về công ty</h3>
						    	<p>Liên lạc qua điện thoại: 1900 1900</p>
						   		<p>ua email: Truy cập<a href="#">hotro.taka.vn</a> </p>
						   		<p>Fanpage của Taka:<a href="#">facebook.com/taka</a> </p>
				   		        <p>Đối tác có nhu cầu hợp tác quảng cáo hoặc kinh doanh: <a href="Contact.aspx">Liên hệ</a> </p>
				   		        <p>Fax: (000) 000 00 00 0</p>
				 	 	        <p>Địa chỉ nhận hàng đổi/trả/bảo hành: Trung tâm xử lý đơn hàng TAKA - 367/F370 Đường Bạch Đằng, P.2, Q.Tân Bình TP. Hồ Chí Minh (Tham khảo hướng dẫn đổi, trả, bảo hành hoặc liên hệ 1900-1900 để được hướng dẫn trước khi gửi sản phẩm về Taka)</p>
				   		        <p>Văn phòng: 52 Út Tịch, phường 4, quận Tân Bình, thành phố Hồ Chí Minh</p>
				   </div>
				 </div>
			  </div>		
         </div> 
    </div>
</asp:Content>
