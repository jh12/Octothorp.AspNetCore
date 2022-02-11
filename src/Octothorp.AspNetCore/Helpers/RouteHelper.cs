using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Octothorp.AspNetCore.Status;

namespace Octothorp.AspNetCore.Helpers;

public static class RouteHelper
{
    public static IEndpointRouteBuilder MapStatus(this IEndpointRouteBuilder builder, string path = "status")
    {
        builder.MapGet($"{path}/version", StatusUtil.GetVersion)
            .WithTags("Status")
            .Produces(StatusCodes.Status200OK);
            
        return builder;
    }
}