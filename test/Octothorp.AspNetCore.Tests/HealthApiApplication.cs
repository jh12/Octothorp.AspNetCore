using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Testing;
using Octothorp.AspNetCore.Health;
using Octothorp.AspNetCore.Tests.Helpers;

namespace Octothorp.AspNetCore.Tests;

class HealthApiApplication : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.Configure(app =>
        {
            app
               .MapGet("/health", () => "Alive")
               .MapGet("/health/version", HealthUtil.GetVersion);
        });
        base.ConfigureWebHost(builder);
    }
}