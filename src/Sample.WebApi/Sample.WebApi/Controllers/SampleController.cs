using System;
using Microsoft.AspNetCore.Mvc;

namespace Sample.WebApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class SampleController : ControllerBase
    {
        public SampleController()
        {
        }

        /// <summary>
        /// 使用者名稱
        /// </summary>
        /// <returns></returns>
        [HttpGet()]
        public string GetUserName()
        {
            return "rayhsu";
        }
    }
}
