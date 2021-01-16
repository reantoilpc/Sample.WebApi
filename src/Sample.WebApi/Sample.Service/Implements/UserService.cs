using System.Security.Authentication;
using Sample.Service.Dtos;
using Sample.Service.Interfaces;

namespace Sample.Service.Implements
{
    public class UserService : IUserService
    {
        /// <summary>
        /// 使用者驗證
        /// </summary>
        /// <param name="dto"></param>
        public string Authenticate(AuthenticateDto dto)
        {
            if (dto.Account != "rayhsu" ||
                dto.Password != "0921666999")
            {
                throw new AuthenticationException("帳號或密碼輸入錯誤！！");
            }

            return "abc123456789";
        }
    }
}