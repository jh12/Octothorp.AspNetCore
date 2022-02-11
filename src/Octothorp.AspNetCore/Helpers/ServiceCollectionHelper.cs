using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace Octothorp.AspNetCore.Helpers;

public static class ServiceCollectionHelper
{
    public static IServiceCollection AddCommonSwagger(this IServiceCollection collection, Action<SwaggerGenOptions>? setupAction = null)
    {
        collection.AddEndpointsApiExplorer();
        collection.AddSwaggerGen(setupAction);

        return collection;
    }

    public static IApplicationBuilder UseCommonSwagger(this IApplicationBuilder builder, Action<SwaggerOptions>? options = null, Action<SwaggerUIOptions>? uiOptions = null)
    {
        builder
            .UseSwagger(options)
            .UseSwaggerUI(uiOptions);

        return builder;
    }
}