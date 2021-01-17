using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.IdentityModel.Tokens;
using Sample.Repository.DbContext.Entities;

namespace Sample.Service.Interfaces
{
    public interface IAuthenticationService
    {
        /// <summary>
        /// 產生 JwtToken
        /// </summary>
        string GenerateJwtToke(User user);
    }
}