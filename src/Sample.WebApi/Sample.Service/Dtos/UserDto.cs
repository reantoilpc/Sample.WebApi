namespace Sample.Service.Dtos
{
    /// <summary>
    /// 使用者資訊
    /// </summary>
    public class UserDto
    {
        /// <summary>
        /// 流水號
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 使用者帳號
        /// </summary>
        public string Account { get; set; }

        /// <summary>
        /// 使用者名稱
        /// </summary>
        public string Username { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }
    }
}