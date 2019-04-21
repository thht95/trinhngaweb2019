using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.Admin.TinTuc
{
    public partial class ChiTietTinTUc : System.Web.UI.UserControl
    {
        clsTinTuc _clsTinTuc = new clsTinTuc();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {
                LoadDataDropDownList1();
                LoadDataDropDownList();

                LoadNewsDetail();

            }
        }
        void LoadDataDropDownList()
        {
            drpNewsCategory.DataSource = _clsTinTuc.GetList(conn, 0);
            drpNewsCategory.DataValueField = "ID";
            drpNewsCategory.DataTextField = "sName";
            drpNewsCategory.DataBind();
        }
        void LoadDataDropDownList1()
        {
            drpNewsCategory1.DataSource = _clsTinTuc.GetList(conn, 0);
            drpNewsCategory1.DataValueField = "ID";
            drpNewsCategory1.DataTextField = "sName";
            drpNewsCategory1.DataBind();
        }
        void LoadNewsDetail()
        {
            rptNewsDetails.DataSource = _clsTinTuc.GetListChiTietTinTuc(conn, int.Parse(drpNewsCategory1.SelectedValue.ToString()));
            rptNewsDetails.DataBind();
        }
        protected void btn_Click(object sender, EventArgs e)
        {
            string typefile = "";
            string file = hdImage.Value;

            if (FileUpload1.FileName.Length > 0)
            {
                if (FileUpload1.PostedFile.ContentLength < 5000000)
                {
                    if (FileUpload1.PostedFile.ContentType.Equals("image/jpeg") || FileUpload1.PostedFile.ContentType.Equals("image/pjeg") || FileUpload1.PostedFile.ContentType.Equals("image/x-png") || FileUpload1.PostedFile.ContentType.Equals("image/png") || FileUpload1.PostedFile.ContentType.Equals("image/gif") || FileUpload1.PostedFile.ContentType.Equals("image/x-shockwave-flash"))
                    {
                        typefile = Path.GetExtension(FileUpload1.FileName).ToLower();
                        file = System.IO.Path.GetFileName(FileUpload1.PostedFile.FileName);
                        file = FileUpload1.FileName.Replace(file, "hungvu98" + DateTime.Now.Hour + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Minute + DateTime.Now.Second + typefile);
                        FileUpload1.PostedFile.SaveAs(Server.MapPath("~/images/" + file));
                    }
                }

            }
            //kiemtra image da ton tai
            if (!file.Equals(hdImage.Value))
            {
                if (!hdImage.Value.Equals(""))
                {
                    if (System.IO.File.Exists(Server.MapPath("~/images/" + hdImage.Value)) == true)
                    {
                        System.IO.File.Delete(Server.MapPath("~/images/" + hdImage.Value));
                    }
                }
            }
            //them data
            if (!string.IsNullOrEmpty(txtTitle.Text.Trim()))
            {
                bool trangthai = (bool)chkActive.Checked;
                String tacgia = Session["username"].ToString();
                if (hdInsert.Value == "insert")
                {
                    _clsTinTuc.ThemChiTietTinTuc(conn, int.Parse(drpNewsCategory.SelectedValue.ToString()), txtTitle.Text.Trim(), txtChitiet.Text, file, tacgia, trangthai, DateTime.Now);
                }
                else if (hdInsert.Value == "update")
                {
                    _clsTinTuc.UpdateChiTietTinTuc(conn, int.Parse(hdDelID.Value.ToString()), int.Parse(drpNewsCategory.SelectedValue.ToString()), txtTitle.Text, txtChitiet.Text, file, tacgia, trangthai, DateTime.Now);
                }
                Response.Redirect(Request.Url.ToString());
            }
        }
        protected void Delete_Load(object sender, System.EventArgs e)
        {
            ((LinkButton)sender).Attributes["onclick"] = "return confirm('Delete selected Detail')";
        }

        protected void lnkThemMoi_Click(object sender, EventArgs e)
        {
            mul.ActiveViewIndex = 1;
            hdInsert.Value = "insert";
        }

        protected void drpNewsCategory1_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNewsDetail();
        }

        protected void rptNewsDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            DataTable dt = new DataTable();
            dt = _clsTinTuc.GetChiTietTinTuc(conn, int.Parse(e.CommandArgument.ToString()));
            switch (e.CommandName.ToString())
            {
                case "update":
                    if (dt.Rows.Count > 0)
                    {
                        bool trangthai = (bool)dt.Rows[0]["bActive"];
                        txtTitle.Text = dt.Rows[0]["sTitle"].ToString();
                        txtChitiet.Text = dt.Rows[0]["sContent"].ToString();

                        hdImage.Value = dt.Rows[0]["sImage"].ToString();
                        drpNewsCategory.SelectedValue = dt.Rows[0]["id_danhmuc"].ToString();
                        chkActive.Checked = trangthai;
                        hdDelID.Value = e.CommandArgument.ToString();

                        hdInsert.Value = "update";
                        mul.ActiveViewIndex = 1;
                    }
                    break;
                case "delete":

                    if (dt.Rows.Count > 0)
                    {
                        _clsTinTuc.DeleteChiTietTinTuc(conn, int.Parse(e.CommandArgument.ToString()));
                        Response.Redirect(Request.Url.ToString());
                    }
                    break;
            }
        }
    }
}