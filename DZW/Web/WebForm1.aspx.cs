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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BrandCommodityBLL bll = new BrandCommodityBLL();
            //上衣
            dlJacket.DataSource = bll.GetJacket(8, 5);
            dlJacket.DataBind();
        }
    }
}