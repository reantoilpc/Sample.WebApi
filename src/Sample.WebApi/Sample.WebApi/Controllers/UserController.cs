using Microsoft.AspNetCore.Mvc;
using Sample.Service.Interfaces;
using Sample.WebApi.Controllers.Parameters;

namespace Sample.WebApi.Controllers
{
    /// <summary>
    /// 使用者 API
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="userService"></param>
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// 使用者驗證
        /// </summary>
        /// <returns></returns>
        [HttpPost("authenticate")]
        public string Authenticate([FromBody] AuthenticateParameter parameter)
        {
            return "aaaa";
        }
    }
}