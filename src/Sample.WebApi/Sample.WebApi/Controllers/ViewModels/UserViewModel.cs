namespace Sample.WebApi.Controllers.ViewModels
{
    /// <summary>
    /// User View Model
    /// </summary>
    public class UserViewModel
    {
        /// <summary>
        /// 使用者編號
        /// </summary>
        public int UserId { get; set; }

        /// <summary>
        /// 使用者姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 使用者地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 使用者信箱
        /// </summary>
        public string Email { get; set; }
    }
}