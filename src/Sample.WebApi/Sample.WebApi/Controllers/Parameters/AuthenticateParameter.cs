namespace Sample.WebApi.Controllers.Parameters
{
    /// <summary>
    /// 使用者驗證
    /// </summary>
    public class AuthenticateParameter
    {
        /// <summary>
        /// 帳號
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        public string Password { get; set; }
    }
}