using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Controls
{
    public partial class ucCommodity : System.Web.UI.UserControl
    {
        private decimal _OriginalPrice;
        private decimal _CurrentPrice;
        private string _ImageUrl;
        private long _CommodityID;
        public decimal OrginalPrice
        {
            get { return _OriginalPrice; }
            set { _OriginalPrice = value; }
        }
        public decimal CurrentPrice
        {
            get { return _CurrentPrice; }
            set { _CurrentPrice = value; }
        }
        public string ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }
        public long CommodityID
        {
            get { return _CommodityID; }
            set { _CommodityID = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCurrentPrice.Text = "现价:" + CurrentPrice.ToString();
            lblOrigialPrice.Text = "原价:" + OrginalPrice.ToString();
            imgCom.ImageUrl = ImageUrl;
            imgCom.CommandArgument = CommodityID.ToString();
        }

        protected void imgCom_Click(object sender, ImageClickEventArgs e)
        {
            Page.Response.Redirect("~/CommodityDetail.aspx?a=0&cid=" + (sender as ImageButton).CommandArgument);
        }
    }
}