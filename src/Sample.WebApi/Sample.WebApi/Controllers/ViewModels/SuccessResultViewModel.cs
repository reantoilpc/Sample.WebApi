using System;

namespace Sample.WebApi.Controllers.ViewModels
{
    /// <summary>
    /// Success Result View Model
    /// </summary>
    public class SuccessResultViewModel
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// API 
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// 版號
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// 狀態
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// 回傳資料
        /// </summary>
        public object Data { get; set; }
    }
}