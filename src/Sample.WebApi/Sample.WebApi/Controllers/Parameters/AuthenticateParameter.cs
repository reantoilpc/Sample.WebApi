using System.ComponentModel.DataAnnotations;

namespace Sample.WebApi.Controllers.Parameters
{
    /// <summary>
    /// 登入參數
    /// </summary>
    public class AuthenticateParameter
    {
        /// <summary>
        /// 帳號
        /// </summary>
        [Required]
        public string Account { get; set; }

        /// <summary>
        /// 密碼
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}