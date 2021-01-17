using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Authentication;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Sample.Common.Helpers.Auth;
using Sample.Service.Interfaces;

namespace Sample.WebApi.Infrastructures.Middlewares
{
    /// <summary>
    /// Json Web Token Middleware
    /// </summary>
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppSettings _appSettings;

        /// <summary>
        /// Constructor
        /// </summary>
        public JwtMiddleware(RequestDelegate next, IOptions<AppSettings> appSettings)
        {
            _next = next;
            _appSettings = appSettings.Value;
        }

        /// <summary>
        /// Invoke
        /// </summary>
        /// <param name="context"></param>
        /// <param name="userService"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context, IUserService userService)
        {
            var header = context.Request.Headers["Authorization"];
            var token = header.FirstOrDefault()?.Split(" ").Last();

            if (token != null) AttachUserToContext(context, userService, token);

            await _next(context);
        }

        private void AttachUserToContext(HttpContext context, IUserService userService, string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();
                var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
                tokenHandler.ValidateToken(token, new TokenValidationParameters()
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ClockSkew = TimeSpan.Zero
                }, out var validatedToken);

                var jwtToken = (JwtSecurityToken) validatedToken;
                var claim = jwtToken.Claims.First(x => x.Type == "Id");
                var userId = int.Parse(claim.Value);
                
                context.Items["User"] = userService.GetUser(userId);
            }
            catch (Exception exception)
            {
                throw new AuthenticationException("您無權限存取！！");
            }
        }
    }
}