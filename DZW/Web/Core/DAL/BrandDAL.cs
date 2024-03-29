﻿using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace Web.Core.DAL
{
	/// <summary>
	/// 数据访问类:Brand
	/// </summary>
	public partial class BrandDAL
	{
		public BrandDAL()
		{}
		#region  Method

        static readonly DataBaseLayer dbl = new DataBaseLayer();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        //public bool Exists(long BrandID)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select count(1) from Brand");
        //    strSql.Append(" where BrandID=@BrandID");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@BrandID", SqlDbType.BigInt)
        //    };
        //    parameters[0].Value = BrandID;

        //    return DbHelperSQL.Exists(strSql.ToString(),parameters);
        //}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public long Add(Web.Core.Model.Brand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Brand(");
			strSql.Append("BrandName,UpdateUser,UpdateTime,IsRecommended)");
			strSql.Append(" values (");
			strSql.Append("@BrandName,@UpdateUser,@UpdateTime,@IsRecommended)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BrandName", SqlDbType.NVarChar,200),
					new SqlParameter("@UpdateUser", SqlDbType.NVarChar,50),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@IsRecommended", SqlDbType.Bit,1)};
			parameters[0].Value = model.BrandName;
			parameters[1].Value = model.UpdateUser;
			parameters[2].Value = model.UpdateTime;
			parameters[3].Value = model.IsRecommended;

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
		public bool Update(Web.Core.Model.Brand model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Brand set ");
			strSql.Append("BrandName=@BrandName,");
			strSql.Append("UpdateUser=@UpdateUser,");
			strSql.Append("UpdateTime=@UpdateTime,");
			strSql.Append("IsRecommended=@IsRecommended");
			strSql.Append(" where BrandID=@BrandID");
			SqlParameter[] parameters = {
					new SqlParameter("@BrandName", SqlDbType.NVarChar,200),
					new SqlParameter("@UpdateUser", SqlDbType.NVarChar,50),
					new SqlParameter("@UpdateTime", SqlDbType.DateTime),
					new SqlParameter("@IsRecommended", SqlDbType.Bit,1),
					new SqlParameter("@BrandID", SqlDbType.BigInt,8)};
			parameters[0].Value = model.BrandName;
			parameters[1].Value = model.UpdateUser;
			parameters[2].Value = model.UpdateTime;
			parameters[3].Value = model.IsRecommended;
			parameters[4].Value = model.BrandID;

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
		public bool Delete(long BrandID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Brand ");
			strSql.Append(" where BrandID=@BrandID");
			SqlParameter[] parameters = {
					new SqlParameter("@BrandID", SqlDbType.BigInt)
			};
			parameters[0].Value = BrandID;

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
		public bool DeleteList(string BrandIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Brand ");
			strSql.Append(" where BrandID in ("+BrandIDlist + ")  ");
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
		public Web.Core.Model.Brand GetModel(long BrandID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BrandID,BrandName,UpdateUser,UpdateTime,IsRecommended from Brand ");
			strSql.Append(" where BrandID=@BrandID");
			SqlParameter[] parameters = {
					new SqlParameter("@BrandID", SqlDbType.BigInt)
			};
			parameters[0].Value = BrandID;

			Web.Core.Model.Brand model=new Web.Core.Model.Brand();
			DataSet ds=dbl.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["BrandID"]!=null && ds.Tables[0].Rows[0]["BrandID"].ToString()!="")
				{
					model.BrandID=long.Parse(ds.Tables[0].Rows[0]["BrandID"].ToString());
				}
				if(ds.Tables[0].Rows[0]["BrandName"]!=null && ds.Tables[0].Rows[0]["BrandName"].ToString()!="")
				{
					model.BrandName=ds.Tables[0].Rows[0]["BrandName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UpdateUser"]!=null && ds.Tables[0].Rows[0]["UpdateUser"].ToString()!="")
				{
					model.UpdateUser=ds.Tables[0].Rows[0]["UpdateUser"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UpdateTime"]!=null && ds.Tables[0].Rows[0]["UpdateTime"].ToString()!="")
				{
					model.UpdateTime=DateTime.Parse(ds.Tables[0].Rows[0]["UpdateTime"].ToString());
				}
				if(ds.Tables[0].Rows[0]["IsRecommended"]!=null && ds.Tables[0].Rows[0]["IsRecommended"].ToString()!="")
				{
					if((ds.Tables[0].Rows[0]["IsRecommended"].ToString()=="1")||(ds.Tables[0].Rows[0]["IsRecommended"].ToString().ToLower()=="true"))
					{
						model.IsRecommended=true;
					}
					else
					{
						model.IsRecommended=false;
					}
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
			strSql.Append("select BrandID,BrandName,UpdateUser,UpdateTime,IsRecommended ");
			strSql.Append(" FROM Brand ");
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
			strSql.Append(" BrandID,BrandName,UpdateUser,UpdateTime,IsRecommended ");
			strSql.Append(" FROM Brand ");
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
			strSql.Append("select count(1) FROM Brand ");
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
				strSql.Append("order by T.BrandID desc");
			}
			strSql.Append(")AS Row, T.*  from Brand T ");
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
			parameters[0].Value = "Brand";
			parameters[1].Value = "BrandID";
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

