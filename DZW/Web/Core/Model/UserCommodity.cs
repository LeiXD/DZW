using System;
namespace Web.Core.Model
{
	/// <summary>
	/// 用户已确认商品的品牌
	/// </summary>
	[Serializable]
	public partial class UserCommodity
	{
		public UserCommodity()
		{}
		#region Model
		private long _id;
		private string _userid;
		private string _commoditycode;
		private string _brandname;
		private decimal? _wishprice;
		private string _imageurl;
		private string _description;
		private bool _ismatched;
		private DateTime? _updatetime;
		/// <summary>
		/// 
		/// </summary>
		public long ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 牌號
		/// </summary>
		public string CommodityCode
		{
			set{ _commoditycode=value;}
			get{return _commoditycode;}
		}
		/// <summary>
		/// 品牌名
		/// </summary>
		public string BrandName
		{
			set{ _brandname=value;}
			get{return _brandname;}
		}
		/// <summary>
		/// 心愿价
		/// </summary>
		public decimal? WishPrice
		{
			set{ _wishprice=value;}
			get{return _wishprice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ImageUrl
		{
			set{ _imageurl=value;}
			get{return _imageurl;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsMatched
		{
			set{ _ismatched=value;}
			get{return _ismatched;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		#endregion Model

	}
}

