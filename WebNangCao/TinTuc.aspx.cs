﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebNangCao
{
    public partial class TinTuc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            plLoad.Controls.Add(LoadControl("/display/News/dNewsControl.ascx"));
        }
    }
}