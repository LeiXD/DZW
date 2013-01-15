using System;
namespace Web.Core.Model
{
    /// <summary>
    /// 用户已确认商品的品牌
    /// </summary>
    [Serializable]
    public partial class Users
    {
        public Users()
        { }
        #region Model
        private string _userid;
        private string _username;
        private string _gender;
        private string _qq;
        private string _phone;
        private DateTime? _birthday;
        private string _favoritebrand;
        private string _serviceid;
        private string _livecity;
        private int _integral;
        /// <summary>
        /// 
        /// </summary>
        public string UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string UserName
        {
            set { _username = value; }
            get { return _username; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Gender
        {
            set { _gender = value; }
            get { return _gender; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string QQ
        {
            set { _qq = value; }
            get { return _qq; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Phone
        {
            set { _phone = value; }
            get { return _phone; }
        }
        /// <summary>
        /// 
        /// </summary>
        public DateTime? Birthday
        {
            set { _birthday = value; }
            get { return _birthday; }
        }
        /// <summary>
        /// 喜欢的品牌，逗号分隔
        /// </summary>
        public string FavoriteBrand
        {
            set { _favoritebrand = value; }
            get { return _favoritebrand; }
        }
        /// <summary>
        /// 客服
        /// </summary>
        public string ServiceID
        {
            set { _serviceid = value; }
            get { return _serviceid; }
        }
        /// <summary>
        /// 居住城市
        /// </summary>
        public string LiveCity
        {
            set { _livecity = value; }
            get { return _livecity; }
        }
        public int Integral
        {
            set { _integral = value; }
            get { return _integral; }
        }
        #endregion Model

    }
}

