using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Web.Controls
{
    public partial class ucChecking : System.Web.UI.UserControl
    {
        private string _WishPrice;
        private string _ImageUrl;
        public string WishPrice
        {
            get { return _WishPrice; }
            set { _WishPrice = value; }
        }
        public string ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            lblWishPrice.Text = _WishPrice;
            ibCommodity.ImageUrl = ImageUrl == "" ? "~/Styles/Image/defaultimg.png" : ImageUrl;
        }
    }
}