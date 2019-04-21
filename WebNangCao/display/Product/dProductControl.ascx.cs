using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.display.Product
{
    public partial class dProductControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            switch (Request["fs"])
            {
                case "ls":
                    Controls.Add(LoadControl("dProductList.ascx"));
                    break;
                case "des":
                    Controls.Add(LoadControl("dProductDetail.ascx"));
                    break;
                case "cart":
                    Controls.Add(LoadControl("dProductCart.ascx"));
                    break;
                default:
                    Controls.Add(LoadControl("dSanPham.ascx"));
                    break;
            }
        }
    }
}