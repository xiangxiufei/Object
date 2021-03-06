﻿using Object.Application.Contracts;
using Object.Application.Contracts.DTO;
using Object.Application.Contracts.Smkt;
using Object.Domain.Shared;
using Object.Domain.Shared.Smkt;
using Object.Domain.Smkt;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;
using static Object.Domain.Shared.Jwt;

namespace Object.Application.Smkt
{
    public class Info107Service : ApplicationService, IInfo107Service
    {
        private readonly IRepository<Info107> users;

        public Info107Service(IRepository<Info107> users)
        {
            this.users = users;
        }

        public async Task<Response<LoginDto>> Login(LoginRequest request)
        {
            var response = new Response<LoginDto>();

            var user = await users.FindAsync(t => t.Rydm.Equals(request.Account));

            var dto = ObjectMapper.Map<Info107, LoginDto>(user);

            if (user != null)
            {
                if (user.Kl.Equals(request.Password.ToSmktEncrypt()))
                {
                    dto.Token = GetToken(dto.Rydm);

                    response.Status = 200;
                    response.Msg = "登录成功";
                    response.Data = dto;
                }
                else
                {
                    response.Status = 500;
                    response.Msg = "用户密码不正确！";
                }
            }
            else
            {
                response.Status = 500;
                response.Msg = "用户名不存在！";
            }

            return response;
        }
    }
}