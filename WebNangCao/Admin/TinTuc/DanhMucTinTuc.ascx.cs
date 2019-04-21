using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.Admin.TinTuc
{
    public partial class DanhMucTinTuc : System.Web.UI.UserControl
    {
        clsTinTuc _tintuc = new clsTinTuc();
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
            rptDanhMucTinTuc.DataSource = _tintuc.GetList(conn, 0);
            rptDanhMucTinTuc.DataBind();
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

            hdInsert.Value = "insert";
            mul.ActiveViewIndex = 1;


        }
        protected void msgDelete(object sender, System.EventArgs e)
        {
            ((LinkButton)sender).Attributes["onclick"] = "return confirm('Bạn có muốn xóa danh mục này ??')";
        }
        protected void btnThem_Click(object sender, EventArgs e)
        {
            if (hdInsert.Value.Equals("insert"))
            {
                if (!string.IsNullOrEmpty(tendanhmuctintuc.Text.Trim()))
                {
                    bool active = chkTrangThai.Checked ? true : false;
                    _tintuc.ThemDanhMucTinTuc(conn, tendanhmuctintuc.Text.Trim(), active);
                    Response.Redirect(Request.Url.ToString());
                }
            }
            else
            {
                if (!string.IsNullOrEmpty(tendanhmuctintuc.Text.Trim()))
                {
                    bool active = chkTrangThai.Checked ? true : false;
                    _tintuc.UpdateDanhMucTinTuc(conn, int.Parse(hdIDdanhmuctintuc.Value), tendanhmuctintuc.Text.Trim(), active);
                    Response.Redirect(Request.Url.ToString());
                }
            }

        }

        protected void rptDanhMucTinTuc_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dt = new DataTable();
            switch (e.CommandName.ToString())
            {
                case "Update":
                    dt = _tintuc.GetList(conn, int.Parse(e.CommandArgument.ToString()));
                    if (dt.Rows.Count > 0)
                    {
                        tendanhmuctintuc.Text = dt.Rows[0]["sName"].ToString();
                        bool trangt = (bool)(dt.Rows[0]["bActive"]);
                        if (trangt == true)
                        {
                            chkTrangThai.Checked = true;
                        }
                        else
                        {
                            chkTrangThai.Checked = false;
                        }
                        hdIDdanhmuctintuc.Value = e.CommandArgument.ToString();
                        hdInsert.Value = "Update";
                        mul.ActiveViewIndex = 1;
                    }

                    break;
                case "Delete":
                    dt = _tintuc.GetList(conn, int.Parse(e.CommandArgument.ToString()));
                    if (dt.Rows.Count > 0)
                    {
                        _tintuc.DeleteDanhMucTinTuc(conn, int.Parse(e.CommandArgument.ToString()));
                        Response.Redirect(Request.Url.ToString());
                    }
                    break;
            }
        }
    }
}