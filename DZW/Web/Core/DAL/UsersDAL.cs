using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
namespace Web.Core.DAL
{
	/// <summary>
	/// 数据访问类:Users
	/// </summary>
	public partial class UsersDAL
	{
		public UsersDAL()
		{}
		#region  Method

        static readonly DataBaseLayer dbl = new DataBaseLayer();
		/// <summary>
		/// 是否存在该记录
		/// </summary>
        //public bool Exists(string UserID)
        //{
        //    StringBuilder strSql=new StringBuilder();
        //    strSql.Append("select count(1) from Users");
        //    strSql.Append(" where UserID=@UserID ");
        //    SqlParameter[] parameters = {
        //            new SqlParameter("@UserID", SqlDbType.NVarChar,50)			};
        //    parameters[0].Value = UserID;
        //    return DbHelperSQL.Exists(strSql.ToString(),parameters);
        //}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Web.Core.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Users(");
			strSql.Append("UserID,UserName,Gender,QQ,Phone,Birthday,FavoriteBrand,ServiceID,LiveCity)");
			strSql.Append(" values (");
			strSql.Append("@UserID,@UserName,@Gender,@QQ,@Phone,@Birthday,@FavoriteBrand,@ServiceID,@LiveCity)");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.NVarChar,50),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Gender", SqlDbType.Char,1),
					new SqlParameter("@QQ", SqlDbType.VarChar,20),
					new SqlParameter("@Phone", SqlDbType.VarChar,20),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@FavoriteBrand", SqlDbType.NVarChar),
					new SqlParameter("@ServiceID", SqlDbType.NVarChar,50),
					new SqlParameter("@LiveCity", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.UserID;
			parameters[1].Value = model.UserName;
			parameters[2].Value = model.Gender;
			parameters[3].Value = model.QQ;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Birthday;
			parameters[6].Value = model.FavoriteBrand;
			parameters[7].Value = model.ServiceID;
			parameters[8].Value = model.LiveCity;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Web.Core.Model.Users model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Users set ");
			strSql.Append("UserName=@UserName,");
			strSql.Append("Gender=@Gender,");
			strSql.Append("QQ=@QQ,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Birthday=@Birthday,");
			strSql.Append("FavoriteBrand=@FavoriteBrand,");
			strSql.Append("ServiceID=@ServiceID,");
			strSql.Append("LiveCity=@LiveCity");
			strSql.Append(" where UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@Gender", SqlDbType.Char,1),
					new SqlParameter("@QQ", SqlDbType.VarChar,20),
					new SqlParameter("@Phone", SqlDbType.VarChar,20),
					new SqlParameter("@Birthday", SqlDbType.DateTime),
					new SqlParameter("@FavoriteBrand", SqlDbType.NVarChar),
					new SqlParameter("@ServiceID", SqlDbType.NVarChar,50),
					new SqlParameter("@LiveCity", SqlDbType.NVarChar,50),
					new SqlParameter("@UserID", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.UserName;
			parameters[1].Value = model.Gender;
			parameters[2].Value = model.QQ;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.Birthday;
			parameters[5].Value = model.FavoriteBrand;
			parameters[6].Value = model.ServiceID;
			parameters[7].Value = model.LiveCity;
			parameters[8].Value = model.UserID;

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
		public bool Delete(string UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = UserID;

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
		public bool DeleteList(string UserIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Users ");
			strSql.Append(" where UserID in ("+UserIDlist + ")  ");
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
		public Web.Core.Model.Users GetModel(string UserID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UserID,UserName,Gender,QQ,Phone,Birthday,FavoriteBrand,ServiceID,LiveCity,Integral from Users ");
			strSql.Append(" where UserID=@UserID ");
			SqlParameter[] parameters = {
					new SqlParameter("@UserID", SqlDbType.NVarChar,50)			};
			parameters[0].Value = UserID;

			Web.Core.Model.Users model=new Web.Core.Model.Users();
			DataSet ds=dbl.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				if(ds.Tables[0].Rows[0]["UserID"]!=null && ds.Tables[0].Rows[0]["UserID"].ToString()!="")
				{
					model.UserID=ds.Tables[0].Rows[0]["UserID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["UserName"]!=null && ds.Tables[0].Rows[0]["UserName"].ToString()!="")
				{
					model.UserName=ds.Tables[0].Rows[0]["UserName"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Gender"]!=null && ds.Tables[0].Rows[0]["Gender"].ToString()!="")
				{
					model.Gender=ds.Tables[0].Rows[0]["Gender"].ToString();
				}
				if(ds.Tables[0].Rows[0]["QQ"]!=null && ds.Tables[0].Rows[0]["QQ"].ToString()!="")
				{
					model.QQ=ds.Tables[0].Rows[0]["QQ"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Phone"]!=null && ds.Tables[0].Rows[0]["Phone"].ToString()!="")
				{
					model.Phone=ds.Tables[0].Rows[0]["Phone"].ToString();
				}
				if(ds.Tables[0].Rows[0]["Birthday"]!=null && ds.Tables[0].Rows[0]["Birthday"].ToString()!="")
				{
					model.Birthday=DateTime.Parse(ds.Tables[0].Rows[0]["Birthday"].ToString());
				}
				if(ds.Tables[0].Rows[0]["FavoriteBrand"]!=null && ds.Tables[0].Rows[0]["FavoriteBrand"].ToString()!="")
				{
					model.FavoriteBrand=ds.Tables[0].Rows[0]["FavoriteBrand"].ToString();
				}
				if(ds.Tables[0].Rows[0]["ServiceID"]!=null && ds.Tables[0].Rows[0]["ServiceID"].ToString()!="")
				{
					model.ServiceID=ds.Tables[0].Rows[0]["ServiceID"].ToString();
				}
				if(ds.Tables[0].Rows[0]["LiveCity"]!=null && ds.Tables[0].Rows[0]["LiveCity"].ToString()!="")
				{
					model.LiveCity=ds.Tables[0].Rows[0]["LiveCity"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Integral"] != null && ds.Tables[0].Rows[0]["Integral"].ToString() != "")
                {
                    model.Integral = Convert.ToInt32( ds.Tables[0].Rows[0]["Integral"]);
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
			strSql.Append("select UserID,UserName,Gender,QQ,Phone,Birthday,FavoriteBrand,ServiceID,LiveCity ");
			strSql.Append(" FROM Users ");
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
			strSql.Append(" UserID,UserName,Gender,QQ,Phone,Birthday,FavoriteBrand,ServiceID,LiveCity ");
			strSql.Append(" FROM Users ");
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
			strSql.Append("select count(1) FROM Users ");
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
				strSql.Append("order by T.UserID desc");
			}
			strSql.Append(")AS Row, T.*  from Users T ");
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
			parameters[0].Value = "Users";
			parameters[1].Value = "UserID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  Method
	}
}

