using AutoMapper;
using Sample.Repository.DbContext.Entities;
using Sample.Service.Dtos;

namespace Sample.Service.Mappings
{
    public class UserServiceProfile : Profile
    {
        public UserServiceProfile()
        {
            this.CreateMap<User, UserDto>();
        }
    }
}