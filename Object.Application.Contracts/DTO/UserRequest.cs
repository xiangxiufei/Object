using System.ComponentModel.DataAnnotations;

namespace Object.Application.Contracts
{
    public class LoginRequest
    {
        /// <summary>
        /// 账号
        /// </summary>
        [Required]
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        public string Password { get; set; }
    }
}