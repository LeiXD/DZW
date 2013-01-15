using System;
using System.Data;
using System.Collections.Generic;
using Web.Core.Model;
namespace Web.Core.BLL
{
	/// <summary>
	/// 用户已确认商品的品牌
	/// </summary>
	public partial class UsersBLL
	{
		private readonly Web.Core.DAL.UsersDAL dal=new Web.Core.DAL.UsersDAL();
		public UsersBLL()
		{}
		#region  Method
        public Web.Core.Model.Users GetUser(string UserID)
        {
            return dal.GetModel(UserID);
        }
		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Web.Core.Model.Users GetModel(string UserID)
		{
			return dal.GetModel(UserID);
		}
		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Web.Core.Model.Users model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Web.Core.Model.Users model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string UserID)
		{
			
			return dal.Delete(UserID);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string UserIDlist )
		{
			return dal.DeleteList(UserIDlist );
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			return dal.GetList(Top,strWhere,filedOrder);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Web.Core.Model.Users> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Web.Core.Model.Users> DataTableToList(DataTable dt)
		{
			List<Web.Core.Model.Users> modelList = new List<Web.Core.Model.Users>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Web.Core.Model.Users model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = new Web.Core.Model.Users();
					if(dt.Rows[n]["UserID"]!=null && dt.Rows[n]["UserID"].ToString()!="")
					{
					model.UserID=dt.Rows[n]["UserID"].ToString();
					}
					if(dt.Rows[n]["UserName"]!=null && dt.Rows[n]["UserName"].ToString()!="")
					{
					model.UserName=dt.Rows[n]["UserName"].ToString();
					}
					if(dt.Rows[n]["Gender"]!=null && dt.Rows[n]["Gender"].ToString()!="")
					{
					model.Gender=dt.Rows[n]["Gender"].ToString();
					}
					if(dt.Rows[n]["QQ"]!=null && dt.Rows[n]["QQ"].ToString()!="")
					{
					model.QQ=dt.Rows[n]["QQ"].ToString();
					}
					if(dt.Rows[n]["Phone"]!=null && dt.Rows[n]["Phone"].ToString()!="")
					{
					model.Phone=dt.Rows[n]["Phone"].ToString();
					}
					if(dt.Rows[n]["Birthday"]!=null && dt.Rows[n]["Birthday"].ToString()!="")
					{
						model.Birthday=DateTime.Parse(dt.Rows[n]["Birthday"].ToString());
					}
					if(dt.Rows[n]["FavoriteBrand"]!=null && dt.Rows[n]["FavoriteBrand"].ToString()!="")
					{
					model.FavoriteBrand=dt.Rows[n]["FavoriteBrand"].ToString();
					}
					if(dt.Rows[n]["ServiceID"]!=null && dt.Rows[n]["ServiceID"].ToString()!="")
					{
					model.ServiceID=dt.Rows[n]["ServiceID"].ToString();
					}
					if(dt.Rows[n]["LiveCity"]!=null && dt.Rows[n]["LiveCity"].ToString()!="")
					{
					model.LiveCity=dt.Rows[n]["LiveCity"].ToString();
					}
					modelList.Add(model);
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  Method
	}
}

