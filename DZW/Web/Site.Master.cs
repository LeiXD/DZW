using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using Web.Core.BLL;

namespace Web
{
    public partial class Site : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserID"] = "Candy@dz.com";
            //用户登录信息
            if (Session["UserID"] != null && Session["UserID"].ToString() != "")
            {
                BindUserInfo(Session["UserID"].ToString());

            }
            else
            {
                Page.Response.Redirect("Default.aspx");
            }
            if (Session["Station"] == null)
            {
                Session["Station"] = "";
            }
            btnUpload.Visible = false;
            //更换选中的菜单背景
        }
        protected void BindUserInfo(string sUserID)
        {
            UsersBLL bll = new UsersBLL();
            Web.Core.Model.Users user = bll.GetUser(sUserID);
            lbName.Text = user.UserName;
            lbIntegral.Text = user.Integral.ToString();
            Web.Core.Model .Users ser = bll.GetUser(user.ServiceID);
            lblSerName.Text = ser.UserName;
            lblSerPhone.Text = ser.Phone;
            lblSerQQ.Text = ser.QQ;
        }
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile.FileName.Trim() != "")  //判断上传文件名是否存在
            {
                string extension = Path.GetExtension(FileUpload1.PostedFile.FileName).ToUpper();
                string filename = DateTime.Now.ToString("yyyMMddhhmmss");
                string path = Server.MapPath("") + "/Info/UserCommodity/" + filename + extension;
                this.FileUpload1.PostedFile.SaveAs(path);
                hfImgUrl.Value = "/Info/UserCommodity/" + filename + extension; //保存下上傳的圖片在服務端的地址
                ShowMsg("上传成功");
            }
        }
        /// <summary>
        /// 商品資料登入資料庫
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            string sUrl = "";
            if (FileUpload1.PostedFile.FileName.Trim() != "")  //判断上传文件名是否存在
            {
                string extension = Path.GetExtension(FileUpload1.PostedFile.FileName).ToUpper();
                string filename = DateTime.Now.ToString("yyyMMddhhmmss");
                string path = Server.MapPath("") + "/Info/UserCommodity/" + filename + extension;
                this.FileUpload1.PostedFile.SaveAs(path);
                sUrl = "/Info/UserCommodity/" + filename + extension; //保存下上傳的圖片在服務端的地址
                //ShowMsg("上传成功");
            }
            if (tbBrandName.Text.Trim() == "" && tbCommodityCode.Text.Trim() == "" && tbDescription.Text.Trim() == ""
                && tbUrl.Text.Trim() == "" && tbWishPrice.Text.Trim()=="")
            {
                ShowMsg("请先输入商品信息");
            }
            UserCommodityBLL bll = new UserCommodityBLL();
            decimal dWish = 0;
            if (tbWishPrice.Text.Trim() != "" && !decimal.TryParse(tbWishPrice.Text.Trim(), out dWish))
            {
                ShowMsg("输入的价格的格式有误");
            }
            if (bll.AddUserCommodity(tbBrandName.Text.Trim(), tbCommodityCode.Text.Trim()
                , sUrl, Session["UserID"].ToString(), dWish
                , tbDescription.Text.Trim()))
            {
                ShowMsg("商品登录成功");
            }
            else
            {
                ShowMsg("商品登录失败");
            }
        }
        /// <summary>
        /// 彈出提示信息框
        /// </summary>
        /// <param name="sMsg"></param>
        protected void ShowMsg(string sMsg)
        {
            ScriptManager.RegisterStartupScript(this.Page, this.GetType(), "k", "$(function () {showMsg('" + sMsg + "');});", true);
        }
    }
}