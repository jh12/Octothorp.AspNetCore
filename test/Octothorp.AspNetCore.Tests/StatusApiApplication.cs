using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Octothorp.AspNetCore.Helpers;

namespace Octothorp.AspNetCore.Tests;

class StatusApiApplication : WebApplicationFactory<Program>
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.Configure(app =>
        {
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapStatus();
            });
        });
        base.ConfigureWebHost(builder);
    }
}