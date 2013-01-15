using System;
namespace Web.Core.Model
{
	/// <summary>
	/// BrandCommodity:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class BrandCommodity
	{
		public BrandCommodity()
		{}
        
        #region Model
		private long _commodityid;
		private long _brandid;
		private string _commoditycode;
		private string _commodityname;
		private string _categoryid;
		private string _imageurl;
		private decimal? _price;
		private decimal? _discount;
		private decimal? _saleprice;
		private string _color;
		private string _size;
		private string _stuff;
		private string _description;
		private string _status;
		private string _creator;
		private DateTime? _createtime;
		private string _modifier;
		private DateTime? _lastupdate;
		/// <summary>
		/// 
		/// </summary>
		public long CommodityID
		{
			set{ _commodityid=value;}
			get{return _commodityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long BrandID
		{
			set{ _brandid=value;}
			get{return _brandid;}
		}
		/// <summary>
		/// 牌号
		/// </summary>
		public string CommodityCode
		{
			set{ _commoditycode=value;}
			get{return _commoditycode;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CommodityName
		{
			set{ _commodityname=value;}
			get{return _commodityname;}
		}
		/// <summary>
		/// 类别
		/// </summary>
		public string CategoryID
		{
			set{ _categoryid=value;}
			get{return _categoryid;}
		}
		/// <summary>
		/// 商品图片地址
		/// </summary>
		public string ImageUrl
		{
			set{ _imageurl=value;}
			get{return _imageurl;}
		}
		/// <summary>
		/// 同一零售价
		/// </summary>
		public decimal? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 统一折扣
		/// </summary>
		public decimal? Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 统一折扣后价格
		/// </summary>
		public decimal? SalePrice
		{
			set{ _saleprice=value;}
			get{return _saleprice;}
		}
		/// <summary>
		/// 颜色，多种颜色逗号分隔
		/// </summary>
		public string Color
		{
			set{ _color=value;}
			get{return _color;}
		}
		/// <summary>
		/// 尺码，多种逗号分隔
		/// </summary>
		public string Size
		{
			set{ _size=value;}
			get{return _size;}
		}
		/// <summary>
		/// 面料
		/// </summary>
		public string Stuff
		{
			set{ _stuff=value;}
			get{return _stuff;}
		}
		/// <summary>
		/// 备注
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 1：销售中，0：停止销售
		/// </summary>
		public string Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Creator
		{
			set{ _creator=value;}
			get{return _creator;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? CreateTime
		{
			set{ _createtime=value;}
			get{return _createtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Modifier
		{
			set{ _modifier=value;}
			get{return _modifier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastUpdate
		{
			set{ _lastupdate=value;}
			get{return _lastupdate;}
		}
		#endregion Model

	}
}

