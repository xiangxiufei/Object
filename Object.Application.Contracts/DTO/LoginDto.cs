﻿namespace Object.Application.Contracts.DTO
{
    public class LoginDto
    {
        /// <summary>
        /// 人员代码
        /// </summary>
        public string Rydm { get; set; }

        /// <summary>
        /// 人员名称
        /// </summary>
        public string Rymc { get; set; }

        public string Token { get; set; }
    }
}