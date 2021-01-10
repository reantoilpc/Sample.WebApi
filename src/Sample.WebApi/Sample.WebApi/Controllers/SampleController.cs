using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

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
        /// <returns></returns>
        [HttpGet("UserName")]
        public string GetUserName()
        {
            return "rayhsu";
        }
    }
}