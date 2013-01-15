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
    public partial class BrandCommodity : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["bid"] != null)
            {
                hfBrandID.Value = Request.QueryString["bid"];
            }
            else
            {
                hfBrandID.Value = "9";
            }
            BindBrand();
            BindCommodity();
        }
        /// <summary>
        /// 绑定品牌基本信息
        /// </summary>
        protected void BindBrand()
        {
            BrandCommodityBLL bll = new BrandCommodityBLL();
            Web.Core.Model.Brand brand = bll.GetBrand(Convert.ToInt64(hfBrandID.Value));
            lblBrandName.Text = brand.BrandName;
            //imgBLogo.ImageUrl = brand.LogoUrl;
            //imgBAd.ImageUrl = brand.AdUrl;
        }
        /// <summary>
        /// 绑定品牌商品
        /// </summary>
        protected void BindCommodity()
        {
            BrandCommodityBLL bll = new BrandCommodityBLL();
            //上衣
            dlJacket.DataSource = bll.GetJacket(8, Convert.ToInt32( hfBrandID.Value));
            dlJacket.DataBind();
            //下装
            dlbottoms.DataSource = bll.GetBottoms(8, Convert.ToInt32(hfBrandID.Value));
            dlbottoms.DataBind();
            //连衣裙
            dldress.DataSource = bll.GetDress(8, Convert.ToInt32(hfBrandID.Value));
            dldress.DataBind();
        }
    }
}