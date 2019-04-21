<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ChiTietLienHe.ascx.cs" Inherits="WebNangCao.Admin.LienHe.ChiTietLienHe" %>

dssdf<div class="item">
  
        <asp:Repeater ID="rptNewsDetails" runat="server" >
            <HeaderTemplate>
            <table border='1px' cellspacing='10px' cellpadding='10px' style='border-collapse: collapse; text-align: left;'>
                <tr class="rptHead">
                    <th>Name</th>
                    <th>Company</th>
                    <th>Email</th>
                    <th>Active</th>
                     <th>Subject</th>
                    
                </tr>
            
        </HeaderTemplate>
            <ItemTemplate>
                <tr class="rptItem">
                   
                    <td><%#:Eval("sName") %></td>
                    <td><%#:Eval("sEmail") %></td>
                    <td><%#:Eval("sCompany") %></td>
                    <td><%#:Eval("bActive") %></td>
                    <td><%#:Eval("sSubject") %></td>
                </tr>
            </ItemTemplate>
              <AlternatingItemTemplate>
                  <tr class="rptAlt">
             <td><%#:Eval("sName") %></td>
                    <td><%#:Eval("sEmail") %></td>
                    <td><%#:Eval("sCompany") %></td>
                    <td><%#:Eval("bActive") %></td>
                    <td><%#:Eval("sSubject") %></td>
                </tr>
            </AlternatingItemTemplate>
            <FooterTemplate>
                 </table>
            </FooterTemplate>
           
        </asp:Repeater>
           
      

  

</div>