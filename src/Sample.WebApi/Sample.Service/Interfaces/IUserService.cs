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
    }
}