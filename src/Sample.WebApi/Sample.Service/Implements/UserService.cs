using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using AutoMapper;
using Sample.Repository.DbContext.Entities;
using Sample.Service.Dtos;
using Sample.Service.Interfaces;

namespace Sample.Service.Implements
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IAuthenticationService _authenticationService;

        private readonly IEnumerable<User> _users = new List<User>
        {
            new User {Id = 1, Account = "ray", Email = "ray@test.com.tw", Username = "王大明", Password = "0921666999"},
            new User {Id = 2, Account = "jane", Email = "jane@test.com.tw", Username = "李小妹", Password = "0921777888"},
        };

        public UserService(IMapper mapper, IAuthenticationService authenticationService)
        {
            _mapper = mapper;
            _authenticationService = authenticationService;
        }

        /// <summary>
        /// 使用者驗證
        /// </summary>
        /// <param name="dto"></param>
        public string Authenticate(AuthenticateDto dto)
        {
            var user = _users.SingleOrDefault(x => x.Account == dto.Account && x.Password == dto.Password);
            if (user == null)
            {
                throw new AuthenticationException("帳號或密碼輸入錯誤！！");
            }

            return _authenticationService.GenerateJwtToke(user);
        }

        public UserDto GetUser(int userId)
        {
            var user = _users.FirstOrDefault(x => x.Id == userId);
            var userDto = _mapper.Map<UserDto>(user);
            return userDto;
        }
    }
}