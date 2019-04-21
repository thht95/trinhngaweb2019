using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.Admin.SanPham
{
    public partial class danhmucsanpham : System.Web.UI.UserControl
    {
        clsSanPham _clsSanPham = new clsSanPham();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {
                LoadData();
            }
        }
        void LoadData()
        {
            rptDanhMucSanPham.DataSource = _clsSanPham.GetList(conn, 0);
            rptDanhMucSanPham.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            hdInsert.Value = "insert";
            mul.ActiveViewIndex = 1;
        }

        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (hdInsert.Value.Equals("insert"))
            {
                if (!string.IsNullOrEmpty(tendanhmucsanpham.Text.Trim()))
                {
                    bool active = chkTrangThai.Checked ? true : false;
                    _clsSanPham.ThemDanhMucSanPham(conn, tendanhmucsanpham.Text.Trim(), active);
                    Response.Redirect(Request.Url.ToString());
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tendanhmucsanpham.Text.Trim()))
                {
                    bool active = chkTrangThai.Checked ? true : false;
                    _clsSanPham.UpdateDanhMucSanPham(conn, int.Parse(hdIDdanhmucsanpham.Value), tendanhmucsanpham.Text.Trim(), active);
                    Response.Redirect(Request.Url.ToString());
                }
            }
        }

        protected void rptDanhMucSanPham_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dt = new DataTable();
            switch (e.CommandName.ToString())
            {
                case "Update":
                    dt = _clsSanPham.GetList(conn, int.Parse(e.CommandArgument.ToString()));
                    if (dt.Rows.Count > 0)
                    {
                        tendanhmucsanpham.Text = dt.Rows[0]["sName"].ToString();
                        bool trangt = (bool)(dt.Rows[0]["bActive"]);
                        if (trangt == true)
                        {
                            chkTrangThai.Checked = true;
                        }
                        else
                        {
                            chkTrangThai.Checked = false;
                        }
                        hdIDdanhmucsanpham.Value = e.CommandArgument.ToString();
                        hdInsert.Value = "Update";
                        mul.ActiveViewIndex = 1;
                    }

                    break;

            }
        }
    }
}