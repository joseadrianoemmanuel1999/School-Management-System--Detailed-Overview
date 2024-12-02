using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;

namespace School.Identity.Helpers;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly AuthSettings _authSettings;
    public JwtMiddleware(RequestDelegate next, IOptions<AuthSettings> appSettings)
    {
        
    }
}