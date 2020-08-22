﻿using Object.Application.Contracts.DTO;
using Object.Domain.Shared;
using System.Threading.Tasks;
using static Object.Domain.Shared.Jwt;

namespace Object.Application.Contracts.Smkt
{
    public interface IInfo107Service
    {
        Task<Response<UserResponse>> Login(UserRequest request);
    }
}