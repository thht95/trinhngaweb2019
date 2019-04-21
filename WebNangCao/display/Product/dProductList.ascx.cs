using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.display.Product
{
    public partial class dProductList : System.Web.UI.UserControl
    {
        clsSanPham _clsSanPham = new clsSanPham();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;

        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");



            if (!IsPostBack)
            {
                LoadList2();
            }

        }


  





        void LoadList2()
        {
            DataTable dt2 = new DataTable();
            string id = Request["id_danhmuc"];
            dt2 = _clsSanPham.GetListChiTietSanPhambyIDdanhmucDisplay(conn, int.Parse(id));
            if (dt2.Rows.Count > 0)
            {
                PagedDataSource pgitems = new PagedDataSource();
                System.Data.DataView dv = new System.Data.DataView(dt2);
                pgitems.DataSource = dv;
                pgitems.AllowPaging = true;
                pgitems.PageSize = 12;
                pgitems.CurrentPageIndex = PageNumber;
                if (pgitems.PageCount > 1)
                {
                    rptPages.Visible = true;
                    System.Collections.ArrayList pages = new System.Collections.ArrayList();
                    for (int i = 0; i < pgitems.PageCount; i++)
                        pages.Add((i + 1).ToString());
                    rptPages.DataSource = pages;
                    rptPages.DataBind();
                }
                else
                    rptPages.Visible = false;

                rptListSanPham.DataSource = _clsSanPham.GetListChiTietSanPhambyIDdanhmucDisplay2(conn, int.Parse(id), int.Parse(pgitems.CurrentPageIndex.ToString()));
                rptListSanPham.DataBind();


            }
        }
        public int PageNumber
        {
            get
            {
                if (ViewState["PageNumber"] != null)
                    return Convert.ToInt32(ViewState["PageNumber"]);
                else
                    return 0;
            }
            set
            {
                ViewState["PageNumber"] = value;
            }
        }

        protected void rptPages_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            PageNumber = Convert.ToInt32(e.CommandArgument) - 1;


            if (e.CommandName == "Page")
            {
                LoadList2();

            };


        }
    }
}