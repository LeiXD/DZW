using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using Web.Core.DAL;
using Web.Core.Model;
namespace Web.Core.BLL
{
    public class UserCommodityBLL
    {
        static readonly UserCommodityDAL dal = new UserCommodityDAL ();
        /// <summary>
        /// 获取已确认的商品
        /// </summary>
        /// <returns></returns>
        public DataSet GetPartCheckdCommodity(string sStation,string sUserID)
        {
            DataSet ds = dal.GetMatchedCommodity(8, sStation, sUserID);
            return ds;
        }
        /// <summary>
        /// 获取待确认的商品
        /// </summary>
        /// <returns></returns>
        public DataSet GetPartCheckingCommodity()
        {
            DataSet ds = dal.GetList(3, "IsMatched = 'False'", "UpdateTime desc");
            return ds;
        }
        /// <summary>
        /// 插入一條用戶商品
        /// </summary>
        /// <returns></returns>
        public bool AddUserCommodity(string sBrandName, string sCommodityCode, string sImageUrl
            , string sUserID, decimal dWishPrice, string sDescription)
        {
            Model.UserCommodity model = new UserCommodity();
            model.BrandName = sBrandName;       //品牌名
            model.CommodityCode = sCommodityCode;   //牌號
            model.IsMatched = false;            //默認設為未确认
            model.ImageUrl = (sImageUrl == "" ? "~/Styles/Image/defaultimg.png" : sImageUrl);//圖片地址，默認為defaultimg
            model.UserID = sUserID;             //用戶ID
            model.WishPrice = dWishPrice;       //心願價
            model.Description = sDescription;   //備註
            model.UpdateTime = DateTime.Now;
            if( dal.Add(model)>0)
               return true;
            return false;
        }
    }
}