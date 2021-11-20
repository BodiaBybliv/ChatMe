using System;
using Microsoft.ApplicationInsights;
using System.Threading.Tasks;
using DataAccessLayer.Exceptions;
using Microsoft.AspNetCore.Http;

namespace InfrastructureLayer.Extensions.MiddleWares
{
    public class ErrorHandlingMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlingMiddleware(RequestDelegate next)
        {
            _next = next;

        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.ContentType = "application/json";

                if (ex is BaseException)
                    context.Response.StatusCode = ((BaseException)ex).StatusCode;
                else
                    context.Response.StatusCode = 400;

                await context.Response.WriteAsync(ex.Message);
            }
        }
    }
}
