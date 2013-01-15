using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Web.Core.BLL;
using Web.Core.Model;

namespace Web
{
    public partial class CommodityDetail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["a"] != null && Request.QueryString["a"] == "1")
            {
                tbnAdd.Visible = false;
            }
            else
            {
                tbnAdd.Visible = true;
            }
            BindDetail(Convert.ToInt64(Request.QueryString["cid"]));
        }
        protected void BindDetail(long lID)
        {
            BrandCommodityBLL bll = new BrandCommodityBLL();
            Web.Core.Model.BrandCommodity bc = bll.GetCommodity(lID);
            imgCommodity.ImageUrl = bc.ImageUrl;
            lblComCode.Text = bc.CommodityCode;
            lblComName.Text = bc.CommodityName;
            lblComPrice.Text = bc.Price.ToString();
            
        }
    }
}