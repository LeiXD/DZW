using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Controls
{
    public partial class ucCheckedCommodity : System.Web.UI.UserControl
    {
        private string _OriginalPrice;
        private string _CurrentPrice;
        private string _WishPrice;
        private string _ImageUrl;
        private long _CID;
        /// <summary>
        /// 原价
        /// </summary>
        public string OriginalPrice
        {
            get { return _OriginalPrice; }
            set { _OriginalPrice = value; }
        }
        /// <summary>
        /// 现价
        /// </summary>
        public string CurrentPrice
        {
            get { return _CurrentPrice; }
            set { _CurrentPrice = value; }
        }
        /// <summary>
        /// 心愿价
        /// </summary>
        public string WishPrice
        {
            get { return _WishPrice; }
            set { _WishPrice = value; }
        }
        /// <summary>
        /// 图片地址
        /// </summary>
        public string ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }
        public long CID
        {
            get { return _CID; }
            set { _CID = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCurrent.Text = CurrentPrice + " 元";
            lblOriginal.Text = OriginalPrice + " 元";
            lblWish.Text = WishPrice + " 元";
            ibCommodity.ImageUrl = ImageUrl == "" ? "~/Styles/Image/defaultimg.png" : ImageUrl;
            ibCommodity.CommandArgument = CID.ToString();
        }

        protected void ibCommodity_Click(object sender, ImageClickEventArgs e)
        {
            Page.Response.Redirect("~/CommodityDetail.aspx?a=1&cid="+(sender as ImageButton).CommandArgument);
        }
    }
}