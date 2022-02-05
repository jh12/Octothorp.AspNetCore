using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Octothorp.AspNetCore.Health;

namespace Octothorp.AspNetCore.Tests.Helpers;

internal static class MapHelper
{
    public static IApplicationBuilder MapGet(this IApplicationBuilder builder, string route, Func<string> methodFunc)
    {
        return builder.Map(route, ap => ap.Run(async (context) => await context.Response.WriteAsync(methodFunc())));
    }

    public static IApplicationBuilder MapGet(this IApplicationBuilder builder, string route, Func<Task<string>> methodFuncAsync)
    {
        return builder.Map(route, ap => ap.Run(async (context) => await context.Response.WriteAsync(await methodFuncAsync())));
    }
}