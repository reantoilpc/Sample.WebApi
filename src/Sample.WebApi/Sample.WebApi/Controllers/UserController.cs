using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Sample.Service.Dtos;
using Sample.Service.Interfaces;
using Sample.WebApi.Controllers.Parameters;
using Sample.WebApi.Controllers.ViewModels;

namespace Sample.WebApi.Controllers
{
    /// <summary>
    /// 使用者 API
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        /// <summary>
        /// 建構子
        /// </summary>
        /// <param name="mapper"></param>
        /// <param name="userService"></param>
        public UserController(IMapper mapper, IUserService userService)
        {
            _mapper = mapper;
            _userService = userService;
        }

        /// <summary>
        /// 使用者驗證
        /// </summary>
        /// <returns></returns>
        [AllowAnonymous] 
        [HttpPost("authenticate")]
        public string Authenticate([FromBody] AuthenticateParameter parameter)
        {
            var dto = this._mapper.Map<AuthenticateDto>(parameter);
            var token = _userService.Authenticate(dto);
            return token;
        }
    }
}