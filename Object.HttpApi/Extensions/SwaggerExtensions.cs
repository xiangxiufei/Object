﻿using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.IO;

namespace Object.HttpApi.Extensions
{
    public static class SwaggerExtensions
    {
        public static void AddSwagger(this IServiceCollection service)
        {
            service.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Object",
                });

                var apiPath = Path.Combine(AppContext.BaseDirectory, "Object.HttpApi.xml");
                if (File.Exists(apiPath))
                {
                    options.IncludeXmlComments(apiPath, true);
                }

                var dtoPath = Path.Combine(AppContext.BaseDirectory, "Object.Application.Contracts.xml");
                if (File.Exists(dtoPath))
                {
                    options.IncludeXmlComments(dtoPath);
                }

                var security = new OpenApiSecurityScheme
                {
                    Description = "JWT授权，请输入 Bearer {Token} 进行身份验证",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                };

                options.AddSecurityDefinition("oauth2", security);
                options.AddSecurityRequirement(new OpenApiSecurityRequirement { { security, new List<string>() } });
                options.OperationFilter<AddResponseHeadersFilter>();
                options.OperationFilter<AppendAuthorizeToSummaryOperationFilter>();
                options.OperationFilter<SecurityRequirementsOperationFilter>();
            });
        }
    }
}