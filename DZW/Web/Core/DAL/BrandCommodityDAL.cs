using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Web.Core.DAL
{
	/// <summary>
	/// 数据访问类:BrandCommodity
	/// </summary>
	public partial class BrandCommodityDAL
    {
        static readonly DataBaseLayer dbl = new DataBaseLayer();
		public BrandCommodityDAL()
		{}
		#region  Method

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public long Add(Web.Core.Model.BrandCommodity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into BrandCommodity(");
            strSql.Append("BrandID,CommodityCode,CommodityName,CategoryID,ImageUrl,Price,Discount,SalePrice,Color,Size,Stuff,Description,Status,Creator,CreateTime,Modifier,LastUpdate)");
            strSql.Append(" values (");
            strSql.Append("@BrandID,@CommodityCode,@CommodityName,@CategoryID,@ImageUrl,@Price,@Discount,@SalePrice,@Color,@Size,@Stuff,@Description,@Status,@Creator,@CreateTime,@Modifier,@LastUpdate)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@BrandID", SqlDbType.BigInt,8),
					new SqlParameter("@CommodityCode", SqlDbType.NVarChar,50),
					new SqlParameter("@CommodityName", SqlDbType.NVarChar,500),
					new SqlParameter("@CategoryID", SqlDbType.VarChar,10),
					new SqlParameter("@ImageUrl", SqlDbType.NVarChar,500),
					new SqlParameter("@Price", SqlDbType.Decimal,13),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@SalePrice", SqlDbType.Decimal,13),
					new SqlParameter("@Color", SqlDbType.NVarChar),
					new SqlParameter("@Size", SqlDbType.NVarChar),
					new SqlParameter("@Stuff", SqlDbType.NVarChar,200),
					new SqlParameter("@Description", SqlDbType.NVarChar),
					new SqlParameter("@Status", SqlDbType.Char,1),
					new SqlParameter("@Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Modifier", SqlDbType.NVarChar,50),
					new SqlParameter("@LastUpdate", SqlDbType.DateTime)};
            parameters[0].Value = model.BrandID;
            parameters[1].Value = model.CommodityCode;
            parameters[2].Value = model.CommodityName;
            parameters[3].Value = model.CategoryID;
            parameters[4].Value = model.ImageUrl;
            parameters[5].Value = model.Price;
            parameters[6].Value = model.Discount;
            parameters[7].Value = model.SalePrice;
            parameters[8].Value = model.Color;
            parameters[9].Value = model.Size;
            parameters[10].Value = model.Stuff;
            parameters[11].Value = model.Description;
            parameters[12].Value = model.Status;
            parameters[13].Value = model.Creator;
            parameters[14].Value = model.CreateTime;
            parameters[15].Value = model.Modifier;
            parameters[16].Value = model.LastUpdate;

            object obj = dbl.GetSingle(strSql.ToString(), parameters);
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt64(obj);
            }
        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Web.Core.Model.BrandCommodity model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update BrandCommodity set ");
            strSql.Append("BrandID=@BrandID,");
            strSql.Append("CommodityCode=@CommodityCode,");
            strSql.Append("CommodityName=@CommodityName,");
            strSql.Append("CategoryID=@CategoryID,");
            strSql.Append("ImageUrl=@ImageUrl,");
            strSql.Append("Price=@Price,");
            strSql.Append("Discount=@Discount,");
            strSql.Append("SalePrice=@SalePrice,");
            strSql.Append("Color=@Color,");
            strSql.Append("Size=@Size,");
            strSql.Append("Stuff=@Stuff,");
            strSql.Append("Description=@Description,");
            strSql.Append("Status=@Status,");
            strSql.Append("Creator=@Creator,");
            strSql.Append("CreateTime=@CreateTime,");
            strSql.Append("Modifier=@Modifier,");
            strSql.Append("LastUpdate=@LastUpdate");
            strSql.Append(" where CommodityID=@CommodityID");
            SqlParameter[] parameters = {
					new SqlParameter("@BrandID", SqlDbType.BigInt,8),
					new SqlParameter("@CommodityCode", SqlDbType.NVarChar,50),
					new SqlParameter("@CommodityName", SqlDbType.NVarChar,500),
					new SqlParameter("@CategoryID", SqlDbType.VarChar,10),
					new SqlParameter("@ImageUrl", SqlDbType.NVarChar,500),
					new SqlParameter("@Price", SqlDbType.Decimal,13),
					new SqlParameter("@Discount", SqlDbType.Decimal,9),
					new SqlParameter("@SalePrice", SqlDbType.Decimal,13),
					new SqlParameter("@Color", SqlDbType.NVarChar),
					new SqlParameter("@Size", SqlDbType.NVarChar),
					new SqlParameter("@Stuff", SqlDbType.NVarChar,200),
					new SqlParameter("@Description", SqlDbType.NVarChar),
					new SqlParameter("@Status", SqlDbType.Char,1),
					new SqlParameter("@Creator", SqlDbType.NVarChar,50),
					new SqlParameter("@CreateTime", SqlDbType.DateTime),
					new SqlParameter("@Modifier", SqlDbType.NVarChar,50),
					new SqlParameter("@LastUpdate", SqlDbType.DateTime),
					new SqlParameter("@CommodityID", SqlDbType.BigInt,8)};
            parameters[0].Value = model.BrandID;
            parameters[1].Value = model.CommodityCode;
            parameters[2].Value = model.CommodityName;
            parameters[3].Value = model.CategoryID;
            parameters[4].Value = model.ImageUrl;
            parameters[5].Value = model.Price;
            parameters[6].Value = model.Discount;
            parameters[7].Value = model.SalePrice;
            parameters[8].Value = model.Color;
            parameters[9].Value = model.Size;
            parameters[10].Value = model.Stuff;
            parameters[11].Value = model.Description;
            parameters[12].Value = model.Status;
            parameters[13].Value = model.Creator;
            parameters[14].Value = model.CreateTime;
            parameters[15].Value = model.Modifier;
            parameters[16].Value = model.LastUpdate;
            parameters[17].Value = model.CommodityID;

            int rows = dbl.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(long CommodityID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from BrandCommodity ");
            strSql.Append(" where CommodityID=@CommodityID");
            SqlParameter[] parameters = {
					new SqlParameter("@CommodityID", SqlDbType.BigInt)
			};
            parameters[0].Value = CommodityID;

            int rows = dbl.ExecuteSql(strSql.ToString(), parameters);
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string CommodityIDlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from BrandCommodity ");
            strSql.Append(" where CommodityID in (" + CommodityIDlist + ")  ");
            int rows = dbl.ExecuteSql(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Web.Core.Model.BrandCommodity GetModel(long CommodityID)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1 CommodityID,BrandID,CommodityCode,CommodityName,CategoryID,ImageUrl,Price,Discount,SalePrice,Color,Size,Stuff,Description,Status,Creator,CreateTime,Modifier,LastUpdate from BrandCommodity ");
            strSql.Append(" where CommodityID=@CommodityID");
            SqlParameter[] parameters = {
					new SqlParameter("@CommodityID", SqlDbType.BigInt)
			};
            parameters[0].Value = CommodityID;

            Web.Core.Model.BrandCommodity model = new Web.Core.Model.BrandCommodity();
            DataSet ds = dbl.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["CommodityID"] != null && ds.Tables[0].Rows[0]["CommodityID"].ToString() != "")
                {
                    model.CommodityID = long.Parse(ds.Tables[0].Rows[0]["CommodityID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["BrandID"] != null && ds.Tables[0].Rows[0]["BrandID"].ToString() != "")
                {
                    model.BrandID = long.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
                }
                if (ds.Tables[0].Rows[0]["CommodityCode"] != null && ds.Tables[0].Rows[0]["CommodityCode"].ToString() != "")
                {
                    model.CommodityCode = ds.Tables[0].Rows[0]["CommodityCode"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CommodityName"] != null && ds.Tables[0].Rows[0]["CommodityName"].ToString() != "")
                {
                    model.CommodityName = ds.Tables[0].Rows[0]["CommodityName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CategoryID"] != null && ds.Tables[0].Rows[0]["CategoryID"].ToString() != "")
                {
                    model.CategoryID = ds.Tables[0].Rows[0]["CategoryID"].ToString();
                }
                if (ds.Tables[0].Rows[0]["ImageUrl"] != null && ds.Tables[0].Rows[0]["ImageUrl"].ToString() != "")
                {
                    model.ImageUrl = ds.Tables[0].Rows[0]["ImageUrl"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Price"] != null && ds.Tables[0].Rows[0]["Price"].ToString() != "")
                {
                    model.Price = decimal.Parse(ds.Tables[0].Rows[0]["Price"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Discount"] != null && ds.Tables[0].Rows[0]["Discount"].ToString() != "")
                {
                    model.Discount = decimal.Parse(ds.Tables[0].Rows[0]["Discount"].ToString());
                }
                if (ds.Tables[0].Rows[0]["SalePrice"] != null && ds.Tables[0].Rows[0]["SalePrice"].ToString() != "")
                {
                    model.SalePrice = decimal.Parse(ds.Tables[0].Rows[0]["SalePrice"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Color"] != null && ds.Tables[0].Rows[0]["Color"].ToString() != "")
                {
                    model.Color = ds.Tables[0].Rows[0]["Color"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Size"] != null && ds.Tables[0].Rows[0]["Size"].ToString() != "")
                {
                    model.Size = ds.Tables[0].Rows[0]["Size"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Stuff"] != null && ds.Tables[0].Rows[0]["Stuff"].ToString() != "")
                {
                    model.Stuff = ds.Tables[0].Rows[0]["Stuff"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Description"] != null && ds.Tables[0].Rows[0]["Description"].ToString() != "")
                {
                    model.Description = ds.Tables[0].Rows[0]["Description"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Status"] != null && ds.Tables[0].Rows[0]["Status"].ToString() != "")
                {
                    model.Status = ds.Tables[0].Rows[0]["Status"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Creator"] != null && ds.Tables[0].Rows[0]["Creator"].ToString() != "")
                {
                    model.Creator = ds.Tables[0].Rows[0]["Creator"].ToString();
                }
                if (ds.Tables[0].Rows[0]["CreateTime"] != null && ds.Tables[0].Rows[0]["CreateTime"].ToString() != "")
                {
                    model.CreateTime = DateTime.Parse(ds.Tables[0].Rows[0]["CreateTime"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Modifier"] != null && ds.Tables[0].Rows[0]["Modifier"].ToString() != "")
                {
                    model.Modifier = ds.Tables[0].Rows[0]["Modifier"].ToString();
                }
                if (ds.Tables[0].Rows[0]["LastUpdate"] != null && ds.Tables[0].Rows[0]["LastUpdate"].ToString() != "")
                {
                    model.LastUpdate = DateTime.Parse(ds.Tables[0].Rows[0]["LastUpdate"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select CommodityID,BrandID,CommodityCode,CommodityName,CategoryID,ImageUrl,Price,Discount,SalePrice,Color,Size,Stuff,Description,Status,Creator,CreateTime,Modifier,LastUpdate ");
            strSql.Append(" FROM BrandCommodity ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return dbl.Query(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" CommodityID,BrandID,CommodityCode,CommodityName,CategoryID,ImageUrl,Price,Discount,SalePrice,Color,Size,Stuff,Description,Status,Creator,CreateTime,Modifier,LastUpdate ");
            strSql.Append(" FROM BrandCommodity ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return dbl.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM BrandCommodity ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = dbl.GetSingle(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.CommodityID desc");
            }
            strSql.Append(")AS Row, T.*  from BrandCommodity T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return dbl.Query(strSql.ToString());
        }

		#endregion  Method
	}
}

