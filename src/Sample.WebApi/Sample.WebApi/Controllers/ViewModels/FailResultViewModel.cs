namespace Sample.WebApi.Controllers.ViewModels
{
    /// <summary>
    /// Fail Result View Model
    /// </summary>
    public class FailResultViewModel
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
        /// 錯誤相關資訊 
        /// </summary>
        public FailInformation Error { get; set; }
    }

    /// <summary>
    /// 錯誤相關資訊
    /// </summary>
    public class FailInformation
    {
        /// <summary>
        /// 錯誤代碼
        /// </summary>
        public string ErrorCode { get; set; }

        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Exception Description
        /// </summary>
        public string Description { get; set; }
    }
}