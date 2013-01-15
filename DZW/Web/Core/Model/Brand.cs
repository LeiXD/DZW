using System;
namespace Web.Core.Model
{
    /// <summary>
    /// Brand:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class Brand
    {
        public Brand()
        { }
        #region Model
        private long _brandid;
        private string _brandname;
        private string _updateuser;
        private DateTime? _updatetime;
        private bool _isrecommended;
        private string _logourl;
        private string _adurl;
        /// <summary>
        /// 
        /// </summary>
        public long BrandID
        {
            set { _brandid = value; }
            get { return _brandid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string BrandName
        {
            set { _brandname = value; }
            get { return _brandname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UpdateUser
        {
            set { _updateuser = value; }
            get { return _updateuser; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? UpdateTime
        {
            set { _updatetime = value; }
            get { return _updatetime; }
        }
        /// <summary>
        /// 客服推荐
        /// </summary>
        public bool IsRecommended
        {
            set { _isrecommended = value; }
            get { return _isrecommended; }
        }
        public string LogoUrl
        {
            set { _logourl = value; }
            get { return _logourl; }
        }
        public string AdUrl
        {
            set { _adurl = value; }
            get { return _adurl; }
        }
        #endregion Model

    }
}

