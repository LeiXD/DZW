using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Web.Core.BLL;

namespace Web
{
    public partial class PersonalPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["UserID"] = "Candy@dz.com";
            Session["UserName"] = "Candy";
            Session["Station"] = "xm";
            BindChecked();
            BindUnChecked();
        }
        private void BindChecked()
        {
            UserCommodityBLL bll = new UserCommodityBLL();
            DataSet ds = bll.GetPartCheckdCommodity(Session["Station"].ToString(), Session["UserID"].ToString());
            ds.Tables[0].Rows.Add("00", "0");
            Session["checkedcount"] = ds.Tables[0].Rows.Count;
            dlChecked.DataSource = ds;// bll.GetPartCheckdCommodity(Session["UserID"].ToString());
            dlChecked.DataBind();

            dlChecked.Items[dlChecked.Items.Count - 1].FindControl("ucCheckedCommodity1").Visible = false;
            dlChecked.Items[dlChecked.Items.Count - 1].FindControl("imgAdd").Visible = true;       
        }
        private void BindUnChecked()
        {
            UserCommodityBLL bll = new UserCommodityBLL(); 
            dlChecking.DataSource = bll.GetPartCheckingCommodity();
            dlChecking.DataBind();
        }
    }
}