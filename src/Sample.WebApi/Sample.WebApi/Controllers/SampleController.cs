using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Sample.WebApi.Controllers.ViewModels;

namespace Sample.WebApi.Controllers
{
    /// <summary>
    /// API 範例
    /// </summary>
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SampleController : ControllerBase
    {
        /// <summary>
        /// 取得使用者名稱
        /// </summary>
        [HttpGet("UserName")]
        public string GetUserName()
        {
            return "rayhsu";
        }

        /// <summary>
        /// 取得使用者們
        /// </summary>
        [HttpGet("users")]
        public IEnumerable<UserViewModel> GetUsers([FromQuery] string name)
        {
            throw new Exception("有 bug !!");
        }
    }
}