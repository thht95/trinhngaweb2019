using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.display.users
{
    public partial class dUserKenhBan : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            plLoad.Controls.Add(LoadControl("/display/dMenuKenhBan.ascx"));

            switch (Request["id"])
            {
                case "2":
                   
                    Controls.Add(LoadControl("/display/users/dKenhBanThemSP.ascx"));
                    break;
                case "3":
                    Controls.Add(LoadControl("/display/users/dKenhBanQuanLyDonHang.ascx"));
                    break;
                default:
                    Controls.Add(LoadControl("/display/users/dKenhBanQuanLy.ascx"));
                    break;

            }
          
            if (!IsPostBack)
            {
             
            }
        }
    }
}