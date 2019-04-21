using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao
{
    public partial class SanPham : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            switch (Request["fs"])
            {
                case "cart":
                    menusanpham.Visible = false;
                    break;
               
                default:
                    menusanpham.Visible = true;
                    PlaceHolder1.Controls.Add(LoadControl("/display/dMenuDisplay.ascx"));
                    break;
            }
            plLoad.Controls.Add(LoadControl("/display/Product/dProductControl.ascx"));
        }
    }
}