using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebNangCao.Dal;

namespace WebNangCao.display.users
{
    public partial class dKenhBanThemSP : System.Web.UI.UserControl
    {
        clsSanPham _clsSanPham = new clsSanPham();
        private CommonConnect cc = new CommonConnect();
        private SqlConnection conn = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usernamedisplay"] == null)
                Controls.Add(LoadControl("/display/user/dUserLogin.ascx"));
            conn = cc.Connected("WebNC");
            if (!IsPostBack)
            {
                LoadDataDropDownList();
            }
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
                        file = FileUpload1.FileName.Replace(file, Session["usernamedisplay"] + "" + DateTime.Now.Hour + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Minute + DateTime.Now.Second + typefile);
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
            if (!string.IsNullOrEmpty(txtTenSanPham.Text.Trim()))
            {

                String nguoitao = Session["usernamedisplay"].ToString();
                String duongdananh = "images/" + file;
                _clsSanPham.ThemChiTietSanPhamDisPlay(conn, int.Parse(drpNewsCategory.SelectedValue.ToString()), txtTenSanPham.Text, DateTime.Now, float.Parse(txtGia.Text.Trim()), int.Parse(txtSoLuong.Text.Trim()), txtChitiet.Text, duongdananh, nguoitao);

                Response.Redirect(Request.Url.ToString());
            }
        }
        void LoadDataDropDownList()
        {
            drpNewsCategory.DataSource = _clsSanPham.GetListDisPlay(conn);
            drpNewsCategory.DataValueField = "ID";
            drpNewsCategory.DataTextField = "sName";
            drpNewsCategory.DataBind();
        }
    }
}