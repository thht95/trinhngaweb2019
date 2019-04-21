using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao
{
    public partial class TrangChu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request["f"])
            {
                 case "news":
                     Response.Redirect("/TinTuc.aspx");
                     //plLoad.Controls.Add(LoadControl("/display/News/dNewsControl.ascx"));
                     break;
                case "product":
                    Response.Redirect("/SanPham.aspx");
                    
                    // plLoad.Controls.Add(LoadControl("/display/Product/dProductControl.ascx"));
                    break;
                case "contact":
                    break;
                case "users":
                    plLoad.Controls.Add(LoadControl("/display/users/dUserDisplayControl.ascx"));
                    break;
                default:
                    plLoad.Controls.Add(LoadControl("/display/dIndex.ascx"));
                    break;
            }
        }
    }
}