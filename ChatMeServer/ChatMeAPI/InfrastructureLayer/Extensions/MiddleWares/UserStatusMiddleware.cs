using BusinessLogicLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;
using System.Security.Claims;

namespace InfrastructureLayer.Extensions.MiddleWares
{
    public class UserStatusMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ICache _cache;

        public UserStatusMiddleware(RequestDelegate next, ICache cache)
        {
            _next = next;

            _cache = cache;
        }

        //public async Task Invoke(HttpContext context, IOptions<CacheOptions> cacheOptions)
        //{
        //    if (context.User.Identity.IsAuthenticated)
        //    {
        //        _cache.Set($"{context.Get()}", true, TimeSpan.FromSeconds(cacheOptions.Value.isOnlineTime));
        //    }

        //    await _next(context);
        //}
    }
}
