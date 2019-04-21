using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao.display.News
{
    public partial class dNewsControl : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request["fs"])
            {
                case "del":
                    Controls.Add(LoadControl("/display/News/dNewsDetail.ascx"));
                    break;
                default:
                    Controls.Add(LoadControl("/display/News/dNewsList.ascx"));
                    break;
            }
        }
    }
}