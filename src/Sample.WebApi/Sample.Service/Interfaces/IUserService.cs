using Sample.Service.Dtos;

namespace Sample.Service.Interfaces
{
    public interface IUserService
    {
        /// <summary>
        /// 使用者驗證
        /// </summary>
        /// <param name="dto"></param>
        string Authenticate(AuthenticateDto dto);

        /// <summary>
        /// 使用者資訊
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        UserDto GetUser(int userId);
    }
}