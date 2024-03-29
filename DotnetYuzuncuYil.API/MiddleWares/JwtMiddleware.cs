﻿using DotnetYuzuncuYil.Core.Services;
using DotnetYuzuncuYil.Service.Authorization.Abstraction;

namespace DotnetYuzuncuYil.API.MiddleWares
{
    public class JwtMiddleware
    {
        private readonly RequestDelegate _next;

        public JwtMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context, IWriterService writerService, IJwtAuthenticationManager iJwtAuthenticationManager)
        {
            var authorizationHeader = context.Request.Headers["Authorization"].FirstOrDefault();
            string token = null;

            if (!string.IsNullOrEmpty(authorizationHeader))
            {
                var parts = authorizationHeader.Split(" ");
                if (parts.Length > 1)
                {
                    token = parts[parts.Length - 1];
                }
            }

            var userId = iJwtAuthenticationManager.ValidateJwtToken(token);
            if (userId != null)
            {
                context.Items["Writer"] = writerService.GetById(userId.Value).Result;
            }
            await _next(context);
        }
    }
}
