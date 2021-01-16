using AutoMapper;
using Sample.Service.Dtos;
using Sample.WebApi.Controllers.Parameters;

namespace Sample.WebApi.Controllers.Infrastructures.Mappings
{
    /// <summary>
    /// Controller Profile
    /// </summary>
    public class ControllerProfile : Profile
    {
        /// <summary>
        /// 建構子
        /// </summary>
        public ControllerProfile()
        {
            this.CreateMap<AuthenticateParameter, AuthenticateDto>();
        }
    }
}