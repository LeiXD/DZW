using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;

namespace Web.Core.DAL
{
	/// <summary>
	/// 数据访问类:UserCommodity
	/// </summary>
	public partial class UserCommodityDAL
	{
        static readonly DataBaseLayer dbl = new DataBaseLayer();
		public UserCommodityDAL()
		{}
		#region  Method
        /// <summary>
        /// 获取用户已确认的商品
        /// </summary>
        /// <param name="iTop"></param>
        /// <param name="sStationCode"></param>
        /// <param name="sUserID"></param>
        /// <returns></returns>
        public DataSet GetMatchedCommodity(int iTop, string sStationCode, string sUserID)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (iTop > 0)
            {
                strSql.Append(" top " + iTop.ToString());
            }
            strSql.Append(string.Format(@" m.ID, m.CommodityID, u.WishPrice, b.Price, p.SalePrice, u.ImageUrl
from CommodityMatch m
left join UserCommodity u on m.ID=u.ID
left join BrandCommodity b on b.CommodityID = m.CommodityID
inner join 
	(select p.CommodityID, MIN( p.SalePrice ) as SalePrice
	from CommodityPrice p
		left join BrandShop s on p.ShopID=s.ShopID
	where p.EffectDate<= GETDATE() and isnull(ExpiredDate,GETDATE())>=GETDATE()
		and s.StationCode like '{0}' and p.Status='1'
	group by p.CommodityID
	) p on p.CommodityID = m.CommodityID 
where u.UserID='{1}'", sStationCode == "" ? "%" : sStationCode, sUserID));
            //strSql.Append(" order by " + sFiledOrder);
            return dbl.Query(strSql.ToString());
        }
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(Web.Core.Model.UserCommodity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into UserCommodity(");
			strSql.Append("UserID,CommodityCode,BrandName,WishPrice,ImageUrl,Description,IsMatched,UpdateTime)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@CommodityCode,@BrandName,@WishPrice,@ImageUrl,@Description,@IsMatched,@UpdateTime)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.NVarChar,50),
					new SqlParameter("@CommodityCode", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandName", SqlDbType.NVarChar,200),
					new SqlParameter("@WishPrice", SqlDbType.Decimal,13),
					new SqlParameter("@ImageUrl", SqlDbType.NVarChar,500),
					new SqlParameter("@Description", SqlDbType.NVarChar),
					new SqlParameter("@IsMatched", SqlDbType.Bit,1),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.CommodityCode;
			parameters[2].Value = model.BrandName;
			parameters[3].Value = model.WishPrice;
			parameters[4].Value = model.ImageUrl;
			parameters[5].Value = model.Description;
			parameters[6].Value = model.IsMatched;
			parameters[7].Value = model.UpdateTime;

			object obj = dbl.GetSingle(strSql.ToString(),parameters);
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
		public bool Update(Web.Core.Model.UserCommodity model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update UserCommodity set ");
			strSql.Append("UserID=@UserID,");
			strSql.Append("CommodityCode=@CommodityCode,");
			strSql.Append("BrandName=@BrandName,");
			strSql.Append("WishPrice=@WishPrice,");
			strSql.Append("ImageUrl=@ImageUrl,");
			strSql.Append("Description=@Description,");
			strSql.Append("IsMatched=@IsMatched,");
			strSql.Append("UpdateTime=@UpdateTime");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.NVarChar,50),
					new SqlParameter("@CommodityCode", SqlDbType.NVarChar,50),
					new SqlParameter("@BrandName", SqlDbType.NVarChar,200),
					new SqlParameter("@WishPrice", SqlDbType.Decimal,13),
					new SqlParameter("@ImageUrl", SqlDbType.NVarChar,500),
					new SqlParameter("@Description", SqlDbType.NVarChar),
					new SqlParameter("@IsMatched", SqlDbType.Bit,1),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@ID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.CommodityCode;
			parameters[2].Value = model.BrandName;
			parameters[3].Value = model.WishPrice;
			parameters[4].Value = model.ImageUrl;
			parameters[5].Value = model.Description;
			parameters[6].Value = model.IsMatched;
			parameters[7].Value = model.UpdateTime;
			parameters[8].Value = model.ID;

			int rows=dbl.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(long ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserCommodity ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			int rows=dbl.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from UserCommodity ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=dbl.ExecuteSql(strSql.ToString());
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
		public Web.Core.Model.UserCommodity GetModel(long ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,UserID,CommodityCode,BrandName,WishPrice,ImageUrl,Description,IsMatched,UpdateTime from UserCommodity ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.BigInt)
			};
			parameters[0].Value = ID;

			Web.Core.Model.UserCommodity model=new Web.Core.Model.UserCommodity();
			DataSet ds=dbl.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["ID"]!=null && ds.Tables[0].Rows[0]["ID"].ToString()!="")
				{
					model.ID=long.Parse(ds.Tables[0].Rows[0]["ID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["UserID"]!=null && ds.Tables[0].Rows[0]["UserID"].ToString()!="")
				{
					model.UserID=ds.Tables[0].Rows[0]["UserID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["CommodityCode"]!=null && ds.Tables[0].Rows[0]["CommodityCode"].ToString()!="")
				{
					model.CommodityCode=ds.Tables[0].Rows[0]["CommodityCode"].ToString();
				}
				if(ds.Tables[0].Rows[0]["BrandName"]!=null && ds.Tables[0].Rows[0]["BrandName"].ToString()!="")
				{
					model.BrandName=ds.Tables[0].Rows[0]["BrandName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["WishPrice"]!=null && ds.Tables[0].Rows[0]["WishPrice"].ToString()!="")
				{
					model.WishPrice=decimal.Parse(ds.Tables[0].Rows[0]["WishPrice"].ToString());
				}
				if(ds.Tables[0].Rows[0]["ImageUrl"]!=null && ds.Tables[0].Rows[0]["ImageUrl"].ToString()!="")
				{
					model.ImageUrl=ds.Tables[0].Rows[0]["ImageUrl"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Description"]!=null && ds.Tables[0].Rows[0]["Description"].ToString()!="")
				{
					model.Description=ds.Tables[0].Rows[0]["Description"].ToString();
				}
				if(ds.Tables[0].Rows[0]["IsMatched"]!=null && ds.Tables[0].Rows[0]["IsMatched"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsMatched"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsMatched"].ToString().ToLower()=="true"))
					{
						model.IsMatched=true;
					}
					else
					{
						model.IsMatched=false;
					}
				}
				if(ds.Tables[0].Rows[0]["UpdateTime"]!=null && ds.Tables[0].Rows[0]["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(ds.Tables[0].Rows[0]["UpdateTime"].ToString());
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,UserID,CommodityCode,BrandName,WishPrice,ImageUrl,Description,IsMatched,UpdateTime ");
			strSql.Append(" FROM UserCommodity ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return dbl.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,UserID,CommodityCode,BrandName,WishPrice,ImageUrl,Description,IsMatched,UpdateTime ");
			strSql.Append(" FROM UserCommodity ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return dbl.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM UserCommodity ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from UserCommodity T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return dbl.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "UserCommodity";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return dbl.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method

    }
}

