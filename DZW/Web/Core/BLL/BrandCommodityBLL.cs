using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Core.DAL;
using Web.Core.Model;
using System.Data;

namespace Web.Core.BLL
{
    public class BrandCommodityBLL
    {
        static readonly BrandCommodityDAL dal = new BrandCommodityDAL();
        static readonly BrandDAL dalBrand = new BrandDAL();
        public Model.Brand GetBrand(long iBrandID)
        {
            return dalBrand.GetModel(iBrandID);
        }
        public Model.BrandCommodity GetCommodity(long lCommodityID)
        {
            return dal.GetModel(lCommodityID);
        }
        public DataSet GetJacket(int iTop, int iBrandID)
        {
            return GetCommodity(iTop, iBrandID, "jacket");
        }
        public DataSet GetDress(int iTop, int iBrandID)
        {
            return GetCommodity(iTop, iBrandID, "dress");
        }
        public DataSet GetBottoms(int iTop, int iBrandID)
        {
            return GetCommodity(iTop, iBrandID, "bottoms");
        }
        private DataSet GetCommodity(int iTop, int iBrandID, string sCategory)
        {
            return dal.GetList(iTop, string.Format(" BrandID={0} and CategoryID = '{1}' and Status='1'", iBrandID, sCategory)
                , "LastUpdate desc");
        }
    }
}